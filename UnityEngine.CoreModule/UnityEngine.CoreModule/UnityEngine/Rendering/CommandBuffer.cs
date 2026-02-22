using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A6 RID: 678
	public class CommandBuffer
	{
		// Token: 0x0600201B RID: 8219 RVA: 0x000128F5 File Offset: 0x00010AF5
		public void ConvertTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ConvertTexture_Internal(src, 0, dst, 0);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0001290C File Offset: 0x00010B0C
		public void ConvertTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ConvertTexture_Internal(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00012924 File Offset: 0x00010B24
		public void WaitAllAsyncReadbackRequests()
		{
			CommandBuffer.WaitAllAsyncReadbackRequestsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00012936 File Offset: 0x00010B36
		public void SetInvertCulling(bool invertCulling)
		{
			CommandBuffer.SetInvertCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), invertCulling);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00012949 File Offset: 0x00010B49
		public void ConvertTexture_Internal(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.ConvertTexture_Internal_Injected(ref src, srcElement, ref dst, dstElement);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00012958 File Offset: 0x00010B58
		public void Internal_SetSinglePassStereo(SinglePassStereoMode mode)
		{
			CommandBuffer.Internal_SetSinglePassStereoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0001296B File Offset: 0x00010B6B
		public static IntPtr InitBuffer()
		{
			return CommandBuffer.InitBufferDelegateField();
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00012977 File Offset: 0x00010B77
		public IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return CommandBuffer.CreateGPUFence_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fenceType, stage);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0001298B File Offset: 0x00010B8B
		public void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage)
		{
			CommandBuffer.WaitOnGPUFence_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fencePtr, stage);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0001299F File Offset: 0x00010B9F
		public void ReleaseBuffer()
		{
			CommandBuffer.ReleaseBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000129B1 File Offset: 0x00010BB1
		public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val)
		{
			CommandBuffer.SetComputeFloatParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, val);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000129CB File Offset: 0x00010BCB
		public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val)
		{
			CommandBuffer.SetComputeIntParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, val);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000129E5 File Offset: 0x00010BE5
		public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val)
		{
			this.SetComputeVectorParam_Injected(computeShader, nameID, ref val);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000129F1 File Offset: 0x00010BF1
		public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.SetComputeVectorArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00012A10 File Offset: 0x00010C10
		public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val)
		{
			this.SetComputeMatrixParam_Injected(computeShader, nameID, ref val);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00012A1C File Offset: 0x00010C1C
		public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.SetComputeMatrixArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00012A3B File Offset: 0x00010C3B
		public void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, Il2CppStructArray<float> values)
		{
			CommandBuffer.Internal_SetComputeFloatsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00012A5A File Offset: 0x00010C5A
		public void Internal_SetComputeInts(ComputeShader computeShader, int nameID, Il2CppStructArray<int> values)
		{
			CommandBuffer.Internal_SetComputeIntsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00012A79 File Offset: 0x00010C79
		public void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			CommandBuffer.Internal_SetComputeTextureParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, nameID, ref rt, mipLevel, element);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00012A99 File Offset: 0x00010C99
		public void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			CommandBuffer.Internal_SetComputeBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00012ABA File Offset: 0x00010CBA
		public void Internal_SetComputeGraphicsBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00012ADB File Offset: 0x00010CDB
		public void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00012AFE File Offset: 0x00010CFE
		public void Internal_SetComputeConstantGraphicsBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00012B21 File Offset: 0x00010D21
		public void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			CommandBuffer.Internal_DispatchComputeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00012B3F File Offset: 0x00010D3F
		public void Internal_DispatchComputeIndirect(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
			CommandBuffer.Internal_DispatchComputeIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(indirectBuffer), argsOffset);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00012B60 File Offset: 0x00010D60
		public void Internal_DispatchComputeIndirectGraphicsBuffer(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
			CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(indirectBuffer), argsOffset);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00012B81 File Offset: 0x00010D81
		public void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
			CommandBuffer.Internal_SetRayTracingBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00012BA0 File Offset: 0x00010DA0
		public void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00012BC3 File Offset: 0x00010DC3
		public void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00012BE6 File Offset: 0x00010DE6
		public void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref RenderTargetIdentifier rt)
		{
			CommandBuffer.Internal_SetRayTracingTextureParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref rt);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00012C00 File Offset: 0x00010E00
		public void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
		{
			CommandBuffer.Internal_SetRayTracingFloatParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, val);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00012C1A File Offset: 0x00010E1A
		public void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
		{
			CommandBuffer.Internal_SetRayTracingIntParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, val);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00012C34 File Offset: 0x00010E34
		public void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam_Injected(rayTracingShader, nameID, ref val);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00012C40 File Offset: 0x00010E40
		public void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00012C5F File Offset: 0x00010E5F
		public void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam_Injected(rayTracingShader, nameID, ref val);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00012C6B File Offset: 0x00010E6B
		public void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00012C8A File Offset: 0x00010E8A
		public void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<float> values)
		{
			CommandBuffer.Internal_SetRayTracingFloatsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00012CA9 File Offset: 0x00010EA9
		public void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<int> values)
		{
			CommandBuffer.Internal_SetRayTracingIntsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00012CC8 File Offset: 0x00010EC8
		public void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin)
		{
			this.Internal_BuildRayTracingAccelerationStructure_Injected(accelerationStructure, ref relativeOrigin);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00012CD3 File Offset: 0x00010ED3
		public void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
		{
			CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00012CF2 File Offset: 0x00010EF2
		public void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string passName)
		{
			CommandBuffer.SetRayTracingShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00012D10 File Offset: 0x00010F10
		public void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, [Optional] Camera camera)
		{
			CommandBuffer.Internal_DispatchRaysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), IL2CPP.ManagedStringToIl2Cpp(rayGenShaderName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00012D3A File Offset: 0x00010F3A
		public void Internal_GenerateMips(RenderTargetIdentifier rt)
		{
			this.Internal_GenerateMips_Injected(ref rt);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00012D44 File Offset: 0x00010F44
		public void Internal_ResolveAntiAliasedSurface(RenderTexture rt, RenderTexture target)
		{
			CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt), IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00012D62 File Offset: 0x00010F62
		public void CopyCounterValueCC(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueCCDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00012D81 File Offset: 0x00010F81
		public void CopyCounterValueGC(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueGCDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00012DA0 File Offset: 0x00010FA0
		public void CopyCounterValueCG(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueCGDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00012DBF File Offset: 0x00010FBF
		public void CopyCounterValueGG(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueGGDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00067A00 File Offset: 0x00065C00
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x00012DDE File Offset: 0x00010FDE
		public string name
		{
			get
			{
				IntPtr intPtr = CommandBuffer.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				CommandBuffer.set_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00012DF6 File Offset: 0x00010FF6
		public int sizeInBytes
		{
			get
			{
				return CommandBuffer.get_sizeInBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00012E08 File Offset: 0x00011008
		public void Clear()
		{
			CommandBuffer.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00012E1A File Offset: 0x0001101A
		public void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			this.Internal_DrawMesh_Injected(mesh, ref matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00012E2C File Offset: 0x0001102C
		public void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
			CommandBuffer.Internal_DrawRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), IL2CPP.Il2CppObjectBaseToPtr(material), submeshIndex, shaderPass);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00012E4D File Offset: 0x0001104D
		public void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawRenderer(renderer, material, submeshIndex, -1);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00012E64 File Offset: 0x00011064
		public void Internal_DrawRenderer(Renderer renderer, Material material)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawRenderer(renderer, material, 0);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00012E7A File Offset: 0x0001107A
		public void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProcedural_Injected(ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00067A24 File Offset: 0x00065C24
		public void Internal_DrawProceduralIndexed(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexed_Injected(indexBuffer, ref matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00012E8E File Offset: 0x0001108E
		public void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndirect_Injected(ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00067A48 File Offset: 0x00065C48
		public void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexedIndirect_Injected(indexBuffer, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00012EA2 File Offset: 0x000110A2
		public void Internal_DrawProceduralIndirectGraphicsBuffer(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00067A6C File Offset: 0x00065C6C
		public void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(indexBuffer, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00067A90 File Offset: 0x00065C90
		public void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(matrices), count, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00012EB6 File Offset: 0x000110B6
		public void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedProceduralDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, count, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00067ACC File Offset: 0x00065CCC
		public void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00067B08 File Offset: 0x00065D08
		public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00012EE0 File Offset: 0x000110E0
		public void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
			this.Internal_DrawOcclusionMesh_Injected(ref normalizedCamViewport);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00012EEA File Offset: 0x000110EA
		public void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt)
		{
			CommandBuffer.SetRandomWriteTarget_TextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref rt);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00012EFE File Offset: 0x000110FE
		public void SetRandomWriteTarget_Buffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			CommandBuffer.SetRandomWriteTarget_BufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00012F18 File Offset: 0x00011118
		public void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00012F32 File Offset: 0x00011132
		public void ClearRandomWriteTargets()
		{
			CommandBuffer.ClearRandomWriteTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00012F44 File Offset: 0x00011144
		public void SetViewport(Rect pixelRect)
		{
			this.SetViewport_Injected(ref pixelRect);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00012F4E File Offset: 0x0001114E
		public void EnableScissorRect(Rect scissor)
		{
			this.EnableScissorRect_Injected(ref scissor);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00012F58 File Offset: 0x00011158
		public void DisableScissorRect()
		{
			CommandBuffer.DisableScissorRectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00067B44 File Offset: 0x00065D44
		public void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode)
		{
			CommandBuffer.CopyTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, ref dst, dstElement, dstMip, dstX, dstY, mode);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00067B78 File Offset: 0x00065D78
		public void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			this.Blit_Texture_Injected(source, ref dest, mat, pass, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00067B98 File Offset: 0x00065D98
		public void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			this.Blit_Identifier_Injected(ref source, ref dest, mat, pass, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00067BB8 File Offset: 0x00065DB8
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
		{
			CommandBuffer.GetTemporaryRTDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00067BE8 File Offset: 0x00065DE8
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode, false);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00067C10 File Offset: 0x00065E10
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, RenderTextureMemoryless.None);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00067C34 File Offset: 0x00065E34
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, false, RenderTextureMemoryless.None);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00012F6A File Offset: 0x0001116A
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, 1);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00067C58 File Offset: 0x00065E58
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00067C88 File Offset: 0x00065E88
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode, false);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00067CB0 File Offset: 0x00065EB0
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, RenderTextureMemoryless.None);
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00067CD8 File Offset: 0x00065ED8
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, false);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00067CFC File Offset: 0x00065EFC
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, 1);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00012F7E File Offset: 0x0001117E
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, RenderTextureReadWrite.Default));
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00012F97 File Offset: 0x00011197
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, SystemInfo.GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat.LDR));
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00012FAE File Offset: 0x000111AE
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, FilterMode.Point);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00012FBE File Offset: 0x000111BE
		public void GetTemporaryRT(int nameID, int width, int height)
		{
			this.GetTemporaryRT(nameID, width, height, 0);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00012FCC File Offset: 0x000111CC
		public void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
			this.GetTemporaryRTWithDescriptor_Injected(nameID, ref desc, filter);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00012FD8 File Offset: 0x000111D8
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
			this.GetTemporaryRTWithDescriptor(nameID, desc, filter);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00012FE5 File Offset: 0x000111E5
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc)
		{
			this.GetTemporaryRT(nameID, desc, FilterMode.Point);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00067D20 File Offset: 0x00065F20
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale)
		{
			CommandBuffer.GetTemporaryRTArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, useDynamicScale);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00067D50 File Offset: 0x00065F50
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, false);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00067D78 File Offset: 0x00065F78
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, false);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00067D9C File Offset: 0x00065F9C
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, 1);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00067DC0 File Offset: 0x00065FC0
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, enableRandomWrite, false);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00067DEC File Offset: 0x00065FEC
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, false);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00067E18 File Offset: 0x00066018
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), 1, false);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00067E44 File Offset: 0x00066044
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, RenderTextureReadWrite.Default), 1, false);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00067E6C File Offset: 0x0006606C
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, SystemInfo.GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat.LDR), 1, false);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00012FF2 File Offset: 0x000111F2
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, FilterMode.Point);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00013004 File Offset: 0x00011204
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, 0);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00013014 File Offset: 0x00011214
		public void ReleaseTemporaryRT(int nameID)
		{
			CommandBuffer.ReleaseTemporaryRTDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00013027 File Offset: 0x00011227
		public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil)
		{
			this.ClearRenderTarget_Injected(clearFlags, ref backgroundColor, depth, stencil);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00013035 File Offset: 0x00011235
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ClearRenderTarget((clearColor ? RTClearFlags.Color : RTClearFlags.None) | (clearDepth ? RTClearFlags.DepthStencil : RTClearFlags.None), backgroundColor, 1f, 0U);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0001305E File Offset: 0x0001125E
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ClearRenderTarget((clearColor ? RTClearFlags.Color : RTClearFlags.None) | (clearDepth ? RTClearFlags.DepthStencil : RTClearFlags.None), backgroundColor, depth, 0U);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00013084 File Offset: 0x00011284
		public void SetGlobalFloat(int nameID, float value)
		{
			CommandBuffer.SetGlobalFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, value);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00013098 File Offset: 0x00011298
		public void SetGlobalInt(int nameID, int value)
		{
			CommandBuffer.SetGlobalIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, value);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000130AC File Offset: 0x000112AC
		public void SetGlobalVector(int nameID, Vector4 value)
		{
			this.SetGlobalVector_Injected(nameID, ref value);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000130B7 File Offset: 0x000112B7
		public void SetGlobalColor(int nameID, Color value)
		{
			this.SetGlobalColor_Injected(nameID, ref value);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000130C2 File Offset: 0x000112C2
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			this.SetGlobalMatrix_Injected(nameID, ref value);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000130CD File Offset: 0x000112CD
		public void EnableShaderKeyword(string keyword)
		{
			CommandBuffer.EnableShaderKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000130E5 File Offset: 0x000112E5
		public void DisableShaderKeyword(string keyword)
		{
			CommandBuffer.DisableShaderKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000130FD File Offset: 0x000112FD
		public void SetViewMatrix(Matrix4x4 view)
		{
			this.SetViewMatrix_Injected(ref view);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00013107 File Offset: 0x00011307
		public void SetProjectionMatrix(Matrix4x4 proj)
		{
			this.SetProjectionMatrix_Injected(ref proj);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00013111 File Offset: 0x00011311
		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
			this.SetViewProjectionMatrices_Injected(ref view, ref proj);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0001311D File Offset: 0x0001131D
		public void SetGlobalDepthBias(float bias, float slopeBias)
		{
			CommandBuffer.SetGlobalDepthBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bias, slopeBias);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00013131 File Offset: 0x00011331
		public void SetExecutionFlags(CommandBufferExecutionFlags flags)
		{
			CommandBuffer.SetExecutionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flags);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00013144 File Offset: 0x00011344
		public bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
		{
			return CommandBuffer.ValidateAgainstExecutionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), requiredFlags, invalidFlags);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00013158 File Offset: 0x00011358
		public void SetGlobalFloatArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalFloatArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00013171 File Offset: 0x00011371
		public void SetGlobalVectorArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalVectorArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0001318A File Offset: 0x0001138A
		public void SetGlobalMatrixArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalMatrixArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000131A3 File Offset: 0x000113A3
		public void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			CommandBuffer.SetGlobalFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000131BC File Offset: 0x000113BC
		public void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.SetGlobalVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000131D5 File Offset: 0x000113D5
		public void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.SetGlobalMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000131EE File Offset: 0x000113EE
		public void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
		{
			CommandBuffer.SetGlobalTexture_ImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref rt, element);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00013203 File Offset: 0x00011403
		public void SetGlobalBufferInternal(int nameID, ComputeBuffer value)
		{
			CommandBuffer.SetGlobalBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0001321C File Offset: 0x0001141C
		public void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value)
		{
			CommandBuffer.SetGlobalGraphicsBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00013235 File Offset: 0x00011435
		public void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
			CommandBuffer.SetShadowSamplingMode_ImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref shadowmap, mode);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00013249 File Offset: 0x00011449
		public void IssuePluginEventInternal(IntPtr callback, int eventID)
		{
			CommandBuffer.IssuePluginEventInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, eventID);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0001325D File Offset: 0x0001145D
		public void BeginSample(string name)
		{
			CommandBuffer.BeginSampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00013275 File Offset: 0x00011475
		public void EndSample(string name)
		{
			CommandBuffer.EndSampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0001328D File Offset: 0x0001148D
		public void BeginSample(UnityEngine.Profiling.CustomSampler sampler)
		{
			this.BeginSample_CustomSampler(sampler);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00013298 File Offset: 0x00011498
		public void EndSample(UnityEngine.Profiling.CustomSampler sampler)
		{
			this.EndSample_CustomSampler(sampler);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000132A3 File Offset: 0x000114A3
		public void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
		{
			CommandBuffer.BeginSample_CustomSamplerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sampler));
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000132BB File Offset: 0x000114BB
		public void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
		{
			CommandBuffer.EndSample_CustomSamplerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sampler));
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000132D3 File Offset: 0x000114D3
		public void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data)
		{
			CommandBuffer.IssuePluginEventAndDataInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, eventID, data);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000132E8 File Offset: 0x000114E8
		public void IssuePluginCustomBlitInternal(IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
			CommandBuffer.IssuePluginCustomBlitInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, command, ref source, ref dest, commandParam, commandFlags);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00013303 File Offset: 0x00011503
		public void IssuePluginCustomTextureUpdateInternal(IntPtr callback, Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2)
		{
			CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, IL2CPP.Il2CppObjectBaseToPtr(targetTexture), userData, useNewUnityRenderingExtTextureUpdateParamsV2);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0001331F File Offset: 0x0001151F
		public void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size)
		{
			CommandBuffer.SetGlobalConstantBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), nameID, offset, size);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0001333B File Offset: 0x0001153B
		public void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
			CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), nameID, offset, size);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00013357 File Offset: 0x00011557
		public void IncrementUpdateCount(RenderTargetIdentifier dest)
		{
			this.IncrementUpdateCount_Injected(ref dest);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00013361 File Offset: 0x00011561
		public void SetInstanceMultiplier(uint multiplier)
		{
			CommandBuffer.SetInstanceMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), multiplier);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00013374 File Offset: 0x00011574
		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRenderTargetSingle_Internal(rt, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00067E94 File Offset: 0x00066094
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = loadAction == RenderBufferLoadAction.Clear;
			if (flag)
			{
				throw new ArgumentException("RenderBufferLoadAction.Clear is not supported");
			}
			this.SetRenderTargetSingle_Internal(rt, loadAction, storeAction, loadAction, storeAction);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00067ECC File Offset: 0x000660CC
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colorLoadAction == RenderBufferLoadAction.Clear || depthLoadAction == RenderBufferLoadAction.Clear;
			if (flag)
			{
				throw new ArgumentException("RenderBufferLoadAction.Clear is not supported");
			}
			this.SetRenderTargetSingle_Internal(rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00067F0C File Offset: 0x0006610C
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetSingle_Internal(new RenderTargetIdentifier(rt, mipLevel, CubemapFace.Unknown, 0), RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00067F58 File Offset: 0x00066158
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetSingle_Internal(new RenderTargetIdentifier(rt, mipLevel, cubemapFace, 0), RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00067FA4 File Offset: 0x000661A4
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = depthSlice < -1;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for depthSlice ({0})", depthSlice));
			}
			bool flag2 = mipLevel < 0;
			if (flag2)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetSingle_Internal(new RenderTargetIdentifier(rt, mipLevel, cubemapFace, depthSlice), RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0001338C File Offset: 0x0001158C
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRenderTargetColorDepth_Internal(color, depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00068010 File Offset: 0x00066210
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, CubemapFace.Unknown, 0), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0006805C File Offset: 0x0006625C
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, cubemapFace, 0), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000680A8 File Offset: 0x000662A8
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = depthSlice < -1;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for depthSlice ({0})", depthSlice));
			}
			bool flag2 = mipLevel < 0;
			if (flag2)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, cubemapFace, depthSlice), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00068118 File Offset: 0x00066318
		public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colorLoadAction == RenderBufferLoadAction.Clear || depthLoadAction == RenderBufferLoadAction.Clear;
			if (flag)
			{
				throw new ArgumentException("RenderBufferLoadAction.Clear is not supported");
			}
			this.SetRenderTargetColorDepth_Internal(color, depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, RenderTargetFlags.None);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0006815C File Offset: 0x0006635C
		public void SetRenderTarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colors.Length < 1;
			if (flag)
			{
				throw new ArgumentException(String.Format("colors.Length must be at least 1, but was {0}", colors.Length));
			}
			bool flag2 = colors.Length > SystemInfo.supportedRenderTargetCount;
			if (flag2)
			{
				throw new ArgumentException(String.Format("colors.Length is {0} and exceeds the maximum number of supported render targets ({1})", colors.Length, SystemInfo.supportedRenderTargetCount));
			}
			this.SetRenderTargetMulti_Internal(colors, depth, null, null, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000681E4 File Offset: 0x000663E4
		public void SetRenderTarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colors.Length < 1;
			if (flag)
			{
				throw new ArgumentException(String.Format("colors.Length must be at least 1, but was {0}", colors.Length));
			}
			bool flag2 = colors.Length > SystemInfo.supportedRenderTargetCount;
			if (flag2)
			{
				throw new ArgumentException(String.Format("colors.Length is {0} and exceeds the maximum number of supported render targets ({1})", colors.Length, SystemInfo.supportedRenderTargetCount));
			}
			this.SetRenderTargetMultiSubtarget(colors, depth, null, null, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x000133A6 File Offset: 0x000115A6
		public void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this.SetRenderTargetSingle_Internal_Injected(ref rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000133B6 File Offset: 0x000115B6
		public void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			this.SetRenderTargetColorDepth_Internal_Injected(ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, flags);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000133CB File Offset: 0x000115CB
		public void SetRenderTargetMulti_Internal(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			this.SetRenderTargetMulti_Internal_Injected(colors, ref depth, colorLoadActions, colorStoreActions, depthLoadAction, depthStoreAction, flags);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00068270 File Offset: 0x00066470
		public void SetRenderTargetColorDepthSubtarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTargetColorDepthSubtarget_Injected(ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00068294 File Offset: 0x00066494
		public void SetRenderTargetMultiSubtarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTargetMultiSubtarget_Injected(colors, ref depth, colorLoadActions, colorStoreActions, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x000682B8 File Offset: 0x000664B8
		public void Internal_ProcessVTFeedback(RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			this.Internal_ProcessVTFeedback_Injected(ref rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x000682DC File Offset: 0x000664DC
		public void SetBufferData(ComputeBuffer buffer, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetComputeBufferData(buffer, data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00068344 File Offset: 0x00066544
		public void SetBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetComputeBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000133DF File Offset: 0x000115DF
		public void SetBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetComputeBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000683B8 File Offset: 0x000665B8
		public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferData(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00068460 File Offset: 0x00066660
		public void SetBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00068514 File Offset: 0x00066714
		public void SetBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, graphicsBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00013406 File Offset: 0x00011606
		public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue)
		{
			this.InternalSetComputeBufferCounterValue(buffer, counterValue);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00013412 File Offset: 0x00011612
		public void InternalSetComputeBufferNativeData(ComputeBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetComputeBufferNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), data, nativeBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00013432 File Offset: 0x00011632
		public void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetComputeBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00013457 File Offset: 0x00011657
		public void InternalSetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue)
		{
			CommandBuffer.InternalSetComputeBufferCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), counterValue);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00068588 File Offset: 0x00066788
		public void SetBufferData(GraphicsBuffer buffer, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetGraphicsBufferData(buffer, data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x000685F0 File Offset: 0x000667F0
		public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetGraphicsBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00013470 File Offset: 0x00011670
		public void SetBufferData<T>(GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetGraphicsBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00068664 File Offset: 0x00066864
		public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetGraphicsBufferData(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x0006870C File Offset: 0x0006690C
		public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetGraphicsBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000687C0 File Offset: 0x000669C0
		public void SetBufferData<T>(GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetGraphicsBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, graphicsBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00013497 File Offset: 0x00011697
		public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue)
		{
			this.InternalSetGraphicsBufferCounterValue(buffer, counterValue);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000134A3 File Offset: 0x000116A3
		public void InternalSetGraphicsBufferNativeData(GraphicsBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetGraphicsBufferNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), data, nativeBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000134C3 File Offset: 0x000116C3
		public void InternalSetGraphicsBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetGraphicsBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000134E8 File Offset: 0x000116E8
		public void InternalSetGraphicsBufferCounterValue(GraphicsBuffer buffer, uint counterValue)
		{
			CommandBuffer.InternalSetGraphicsBufferCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), counterValue);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00068834 File Offset: 0x00066A34
		public ~CommandBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00013501 File Offset: 0x00011701
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00013513 File Offset: 0x00011713
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00013520 File Offset: 0x00011720
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0001352A File Offset: 0x0001172A
		public void SetComputeFloatParam(ComputeShader computeShader, string name, float val)
		{
			this.SetComputeFloatParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0001353C File Offset: 0x0001173C
		public void SetComputeIntParam(ComputeShader computeShader, string name, int val)
		{
			this.SetComputeIntParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0001354E File Offset: 0x0001174E
		public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
		{
			this.SetComputeVectorParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00013560 File Offset: 0x00011760
		public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Il2CppStructArray<Vector4> values)
		{
			this.SetComputeVectorArrayParam(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00013572 File Offset: 0x00011772
		public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val)
		{
			this.SetComputeMatrixParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00013584 File Offset: 0x00011784
		public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetComputeMatrixArrayParam(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00013596 File Offset: 0x00011796
		public void SetComputeFloatParams(ComputeShader computeShader, string name, Il2CppStructArray<float> values)
		{
			this.Internal_SetComputeFloats(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x000135A8 File Offset: 0x000117A8
		public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
		{
			this.SetComputeFloatParams(computeShader, name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x000135B8 File Offset: 0x000117B8
		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, Il2CppStructArray<float> values)
		{
			this.Internal_SetComputeFloats(computeShader, nameID, values);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000135C5 File Offset: 0x000117C5
		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values)
		{
			this.SetComputeFloatParams(computeShader, nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000135D5 File Offset: 0x000117D5
		public void SetComputeIntParams(ComputeShader computeShader, string name, Il2CppStructArray<int> values)
		{
			this.Internal_SetComputeInts(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000135E7 File Offset: 0x000117E7
		public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values)
		{
			this.SetComputeIntParams(computeShader, name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000135F7 File Offset: 0x000117F7
		public void SetComputeIntParams(ComputeShader computeShader, int nameID, Il2CppStructArray<int> values)
		{
			this.Internal_SetComputeInts(computeShader, nameID, values);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00013604 File Offset: 0x00011804
		public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values)
		{
			this.SetComputeIntParams(computeShader, nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00013614 File Offset: 0x00011814
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, Shader.PropertyToID(name), ref rt, 0, RenderTextureSubElement.Default);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x0001362A File Offset: 0x0001182A
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, 0, RenderTextureSubElement.Default);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0001363B File Offset: 0x0001183B
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, Shader.PropertyToID(name), ref rt, mipLevel, RenderTextureSubElement.Default);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00013652 File Offset: 0x00011852
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, mipLevel, RenderTextureSubElement.Default);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00013664 File Offset: 0x00011864
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, Shader.PropertyToID(name), ref rt, mipLevel, element);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0001367C File Offset: 0x0001187C
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, mipLevel, element);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0001368F File Offset: 0x0001188F
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0001369E File Offset: 0x0001189E
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
		{
			this.Internal_SetComputeBufferParam(computeShader, kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000136B2 File Offset: 0x000118B2
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetComputeGraphicsBufferParam(computeShader, kernelIndex, nameID, buffer);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000136C1 File Offset: 0x000118C1
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.Internal_SetComputeGraphicsBufferParam(computeShader, kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000136D5 File Offset: 0x000118D5
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantComputeBufferParam(computeShader, nameID, buffer, offset, size);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000136E6 File Offset: 0x000118E6
		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantComputeBufferParam(computeShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000136FC File Offset: 0x000118FC
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantGraphicsBufferParam(computeShader, nameID, buffer, offset, size);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0001370D File Offset: 0x0001190D
		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantGraphicsBufferParam(computeShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00013723 File Offset: 0x00011923
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			this.Internal_DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00013734 File Offset: 0x00011934
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
			this.Internal_DispatchComputeIndirect(computeShader, kernelIndex, indirectBuffer, argsOffset);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00013743 File Offset: 0x00011943
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
			this.Internal_DispatchComputeIndirectGraphicsBuffer(computeShader, kernelIndex, indirectBuffer, argsOffset);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00068868 File Offset: 0x00066A68
		public void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
		{
			Vector3 vector = new Vector3(0f, 0f, 0f);
			this.Internal_BuildRayTracingAccelerationStructure(accelerationStructure, vector);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00013752 File Offset: 0x00011952
		public void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin)
		{
			this.Internal_BuildRayTracingAccelerationStructure(accelerationStructure, relativeOrigin);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0001375E File Offset: 0x0001195E
		public void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
			this.Internal_SetRayTracingAccelerationStructure(rayTracingShader, Shader.PropertyToID(name), rayTracingAccelerationStructure);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00013770 File Offset: 0x00011970
		public void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
			this.Internal_SetRayTracingAccelerationStructure(rayTracingShader, nameID, rayTracingAccelerationStructure);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0001377D File Offset: 0x0001197D
		public void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, ComputeBuffer buffer)
		{
			this.Internal_SetRayTracingBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0001378F File Offset: 0x0001198F
		public void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetRayTracingBufferParam(rayTracingShader, nameID, buffer);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0001379C File Offset: 0x0001199C
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantComputeBufferParam(rayTracingShader, nameID, buffer, offset, size);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000137AD File Offset: 0x000119AD
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantComputeBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000137C3 File Offset: 0x000119C3
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantGraphicsBufferParam(rayTracingShader, nameID, buffer, offset, size);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000137D4 File Offset: 0x000119D4
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantGraphicsBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000137EA File Offset: 0x000119EA
		public void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt)
		{
			this.Internal_SetRayTracingTextureParam(rayTracingShader, Shader.PropertyToID(name), ref rt);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000137FD File Offset: 0x000119FD
		public void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt)
		{
			this.Internal_SetRayTracingTextureParam(rayTracingShader, nameID, ref rt);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0001380B File Offset: 0x00011A0B
		public void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, float val)
		{
			this.Internal_SetRayTracingFloatParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0001381D File Offset: 0x00011A1D
		public void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
		{
			this.Internal_SetRayTracingFloatParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0001382A File Offset: 0x00011A2A
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<float> values)
		{
			this.Internal_SetRayTracingFloats(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x0001383C File Offset: 0x00011A3C
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params float[] values)
		{
			this.SetRayTracingFloatParams(rayTracingShader, name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0001384C File Offset: 0x00011A4C
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<float> values)
		{
			this.Internal_SetRayTracingFloats(rayTracingShader, nameID, values);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00013859 File Offset: 0x00011A59
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params float[] values)
		{
			this.SetRayTracingFloatParams(rayTracingShader, nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00013869 File Offset: 0x00011A69
		public void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, int val)
		{
			this.Internal_SetRayTracingIntParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0001387B File Offset: 0x00011A7B
		public void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
		{
			this.Internal_SetRayTracingIntParam(rayTracingShader, nameID, val);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00013888 File Offset: 0x00011A88
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<int> values)
		{
			this.Internal_SetRayTracingInts(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0001389A File Offset: 0x00011A9A
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params int[] values)
		{
			this.SetRayTracingIntParams(rayTracingShader, name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000138AA File Offset: 0x00011AAA
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<int> values)
		{
			this.Internal_SetRayTracingInts(rayTracingShader, nameID, values);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000138B7 File Offset: 0x00011AB7
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params int[] values)
		{
			this.SetRayTracingIntParams(rayTracingShader, nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000138C7 File Offset: 0x00011AC7
		public void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000138D9 File Offset: 0x00011AD9
		public void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000138E6 File Offset: 0x00011AE6
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<Vector4> values)
		{
			this.Internal_SetRayTracingVectorArrayParam(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000138F8 File Offset: 0x00011AF8
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params Vector4[] values)
		{
			this.SetRayTracingVectorArrayParam(rayTracingShader, name, new Il2CppStructArray<Vector4>(values));
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00013908 File Offset: 0x00011B08
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			this.Internal_SetRayTracingVectorArrayParam(rayTracingShader, nameID, values);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00013915 File Offset: 0x00011B15
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params Vector4[] values)
		{
			this.SetRayTracingVectorArrayParam(rayTracingShader, nameID, new Il2CppStructArray<Vector4>(values));
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00013925 File Offset: 0x00011B25
		public void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00013937 File Offset: 0x00011B37
		public void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00013944 File Offset: 0x00011B44
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.Internal_SetRayTracingMatrixArrayParam(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00013956 File Offset: 0x00011B56
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params Matrix4x4[] values)
		{
			this.SetRayTracingMatrixArrayParam(rayTracingShader, name, new Il2CppStructArray<Matrix4x4>(values));
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00013966 File Offset: 0x00011B66
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.Internal_SetRayTracingMatrixArrayParam(rayTracingShader, nameID, values);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00013973 File Offset: 0x00011B73
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params Matrix4x4[] values)
		{
			this.SetRayTracingMatrixArrayParam(rayTracingShader, nameID, new Il2CppStructArray<Matrix4x4>(values));
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00013983 File Offset: 0x00011B83
		public void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, [Optional] Camera camera)
		{
			this.Internal_DispatchRays(rayTracingShader, rayGenName, width, height, depth, camera);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00013996 File Offset: 0x00011B96
		public void GenerateMips(RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_GenerateMips(rt);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00068898 File Offset: 0x00066A98
		public void GenerateMips(RenderTexture rt)
		{
			bool flag = rt == null;
			if (flag)
			{
				throw new ArgumentNullException("rt");
			}
			this.GenerateMips(new RenderTargetIdentifier(rt));
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000688CC File Offset: 0x00066ACC
		public void ResolveAntiAliasedSurface(RenderTexture rt, [Optional] RenderTexture target)
		{
			bool flag = rt == null;
			if (flag)
			{
				throw new ArgumentNullException("rt");
			}
			this.Internal_ResolveAntiAliasedSurface(rt, target);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000688FC File Offset: 0x00066AFC
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag2 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag2)
			{
				submeshIndex = Mathf.Clamp(submeshIndex, 0, mesh.subMeshCount - 1);
				Debug.LogWarning(String.Format("submeshIndex out of range. Clampped to {0}.", submeshIndex));
			}
			bool flag3 = material == null;
			if (flag3)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000139AA File Offset: 0x00011BAA
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
			this.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, null);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000139BC File Offset: 0x00011BBC
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
			this.DrawMesh(mesh, matrix, material, submeshIndex, -1);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000139CC File Offset: 0x00011BCC
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
			this.DrawMesh(mesh, matrix, material, 0);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00068994 File Offset: 0x00066B94
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
			bool flag = renderer == null;
			if (flag)
			{
				throw new ArgumentNullException("renderer");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag2 = submeshIndex < 0;
			if (flag2)
			{
				submeshIndex = Mathf.Max(submeshIndex, 0);
				Debug.LogWarning(String.Format("submeshIndex out of range. Clampped to {0}.", submeshIndex));
			}
			bool flag3 = material == null;
			if (flag3)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000139DA File Offset: 0x00011BDA
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			this.DrawRenderer(renderer, material, submeshIndex, -1);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000139E8 File Offset: 0x00011BE8
		public void DrawRenderer(Renderer renderer, Material material)
		{
			this.DrawRenderer(renderer, material, 0);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00068A0C File Offset: 0x00066C0C
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000139F5 File Offset: 0x00011BF5
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, null);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00013A09 File Offset: 0x00011C09
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, 1);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00068A4C File Offset: 0x00066C4C
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawProceduralIndexed(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00068A98 File Offset: 0x00066C98
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount)
		{
			this.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, null);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00013A1B File Offset: 0x00011C1B
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount)
		{
			this.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, 1);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00068ABC File Offset: 0x00066CBC
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00013A2F File Offset: 0x00011C2F
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00013A43 File Offset: 0x00011C43
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00068B10 File Offset: 0x00066D10
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawProceduralIndexedIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00068B70 File Offset: 0x00066D70
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00013A55 File Offset: 0x00011C55
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00068B94 File Offset: 0x00066D94
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProceduralIndirectGraphicsBuffer(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00013A69 File Offset: 0x00011C69
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00013A7D File Offset: 0x00011C7D
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00068BE8 File Offset: 0x00066DE8
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawProceduralIndexedIndirectGraphicsBuffer(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00068C48 File Offset: 0x00066E48
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00013A8F File Offset: 0x00011C8F
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00068C6C File Offset: 0x00066E6C
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("DrawMeshInstanced is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = matrices == null;
			if (flag5)
			{
				throw new ArgumentNullException("matrices");
			}
			bool flag6 = count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length);
			if (flag6)
			{
				throw new ArgumentOutOfRangeException("count", String.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag7 = count > 0;
			if (flag7)
			{
				this.Internal_DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
			}
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00013AA3 File Offset: 0x00011CA3
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, null);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00013AB7 File Offset: 0x00011CB7
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices)
		{
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, matrices.Length);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00068D70 File Offset: 0x00066F70
		public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, [Optional] MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("DrawMeshInstancedProcedural is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag6 = count > 0;
			if (flag6)
			{
				this.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count, properties);
			}
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00068E28 File Offset: 0x00067028
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = bufferWithArgs == null;
			if (flag5)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00013AD0 File Offset: 0x00011CD0
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00013AE4 File Offset: 0x00011CE4
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, 0, null);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00068EC8 File Offset: 0x000670C8
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = bufferWithArgs == null;
			if (flag5)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00013AF7 File Offset: 0x00011CF7
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00013B0B File Offset: 0x00011D0B
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, 0, null);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00013B1E File Offset: 0x00011D1E
		public void DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
			this.Internal_DrawOcclusionMesh(normalizedCamViewport);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00013B29 File Offset: 0x00011D29
		public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_Texture(index, ref rt);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00013B3F File Offset: 0x00011D3F
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_Buffer(index, buffer, preserveCounterValue);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00013B55 File Offset: 0x00011D55
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer)
		{
			this.SetRandomWriteTarget(index, buffer, false);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00013B62 File Offset: 0x00011D62
		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_GraphicsBuffer(index, buffer, preserveCounterValue);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00013B78 File Offset: 0x00011D78
		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer)
		{
			this.SetRandomWriteTarget(index, buffer, false);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00013B85 File Offset: 0x00011D85
		public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00013B92 File Offset: 0x00011D92
		public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00013B9F File Offset: 0x00011D9F
		public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00013BAC File Offset: 0x00011DAC
		public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00068F68 File Offset: 0x00067168
		public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
			this.CopyTexture_Internal(ref src, -1, -1, -1, -1, -1, -1, ref dst, -1, -1, -1, -1, 1);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00068F8C File Offset: 0x0006718C
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.CopyTexture_Internal(ref src, srcElement, -1, -1, -1, -1, -1, ref dst, dstElement, -1, -1, -1, 2);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00068FB4 File Offset: 0x000671B4
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
		{
			this.CopyTexture_Internal(ref src, srcElement, srcMip, -1, -1, -1, -1, ref dst, dstElement, dstMip, -1, -1, 3);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00068FDC File Offset: 0x000671DC
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			this.CopyTexture_Internal(ref src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, ref dst, dstElement, dstMip, dstX, dstY, 4);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00069008 File Offset: 0x00067208
		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, null, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00069050 File Offset: 0x00067250
		public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, null, -1, scale, offset, Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0006907C File Offset: 0x0006727C
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, mat, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000690C4 File Offset: 0x000672C4
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, mat, pass, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0006910C File Offset: 0x0006730C
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00069154 File Offset: 0x00067354
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, scale, offset, Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00069184 File Offset: 0x00067384
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, mat, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000691CC File Offset: 0x000673CC
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, mat, pass, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00069218 File Offset: 0x00067418
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00069260 File Offset: 0x00067460
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0006928C File Offset: 0x0006748C
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, mat, pass, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, destDepthSlice);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00013BB9 File Offset: 0x00011DB9
		public void SetGlobalFloat(string name, float value)
		{
			this.SetGlobalFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00013BCA File Offset: 0x00011DCA
		public void SetGlobalInt(string name, int value)
		{
			this.SetGlobalInt(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00013BDB File Offset: 0x00011DDB
		public void SetGlobalVector(string name, Vector4 value)
		{
			this.SetGlobalVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00013BEC File Offset: 0x00011DEC
		public void SetGlobalColor(string name, Color value)
		{
			this.SetGlobalColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00013BFD File Offset: 0x00011DFD
		public void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			this.SetGlobalMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00013C0E File Offset: 0x00011E0E
		public void SetGlobalFloatArray(string propertyName, List<float> values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000692D8 File Offset: 0x000674D8
		public void SetGlobalFloatArray(int nameID, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalFloatArrayListImpl(nameID, values);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00013C1F File Offset: 0x00011E1F
		public void SetGlobalFloatArray(string propertyName, Il2CppStructArray<float> values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00013C30 File Offset: 0x00011E30
		public void SetGlobalVectorArray(string propertyName, List<Vector4> values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0006931C File Offset: 0x0006751C
		public void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalVectorArrayListImpl(nameID, values);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00013C41 File Offset: 0x00011E41
		public void SetGlobalVectorArray(string propertyName, Il2CppStructArray<Vector4> values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00013C52 File Offset: 0x00011E52
		public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00069360 File Offset: 0x00067560
		public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalMatrixArrayListImpl(nameID, values);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00013C63 File Offset: 0x00011E63
		public void SetGlobalMatrixArray(string propertyName, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00013C74 File Offset: 0x00011E74
		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture(Shader.PropertyToID(name), value, RenderTextureSubElement.Default);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00013C86 File Offset: 0x00011E86
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture_Impl(nameID, ref value, RenderTextureSubElement.Default);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00013C94 File Offset: 0x00011E94
		public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
			this.SetGlobalTexture(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00013CA6 File Offset: 0x00011EA6
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
			this.SetGlobalTexture_Impl(nameID, ref value, element);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00013CB4 File Offset: 0x00011EB4
		public void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			this.SetGlobalBufferInternal(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00013CC5 File Offset: 0x00011EC5
		public void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			this.SetGlobalBufferInternal(nameID, value);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00013CD1 File Offset: 0x00011ED1
		public void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			this.SetGlobalGraphicsBufferInternal(Shader.PropertyToID(name), value);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00013CE2 File Offset: 0x00011EE2
		public void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGlobalGraphicsBufferInternal(nameID, value);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00013CEE File Offset: 0x00011EEE
		public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
		{
			this.SetGlobalConstantBufferInternal(buffer, nameID, offset, size);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00013CFD File Offset: 0x00011EFD
		public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size)
		{
			this.SetGlobalConstantBufferInternal(buffer, Shader.PropertyToID(name), offset, size);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00013D11 File Offset: 0x00011F11
		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
			this.SetGlobalConstantGraphicsBufferInternal(buffer, nameID, offset, size);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00013D20 File Offset: 0x00011F20
		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size)
		{
			this.SetGlobalConstantGraphicsBufferInternal(buffer, Shader.PropertyToID(name), offset, size);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00013D34 File Offset: 0x00011F34
		public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetShadowSamplingMode_Impl(ref shadowmap, mode);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00013D4A File Offset: 0x00011F4A
		public void SetSinglePassStereo(SinglePassStereoMode mode)
		{
			this.Internal_SetSinglePassStereo(mode);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000693A4 File Offset: 0x000675A4
		public void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000693D8 File Offset: 0x000675D8
		public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginEventAndDataInternal(callback, eventID, data);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00013D55 File Offset: 0x00011F55
		public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginCustomBlitInternal(callback, command, ref source, ref dest, commandParam, commandFlags);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00013D72 File Offset: 0x00011F72
		public void IssuePluginCustomTextureUpdate(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, false);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00013D80 File Offset: 0x00011F80
		public void IssuePluginCustomTextureUpdateV1(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, false);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00013D8E File Offset: 0x00011F8E
		public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, true);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00069414 File Offset: 0x00067614
		public void ProcessVTFeedback(RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_ProcessVTFeedback(rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00069440 File Offset: 0x00067640
		public GPUFence CreateGPUFence(SynchronisationStage stage)
		{
			return default(GPUFence);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0006945C File Offset: 0x0006765C
		public GPUFence CreateGPUFence()
		{
			return default(GPUFence);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00013DA5 File Offset: 0x00011FA5
		public void WaitOnGPUFence(GPUFence fence, SynchronisationStage stage)
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00013DA8 File Offset: 0x00011FA8
		public void WaitOnGPUFence(GPUFence fence)
		{
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00013DAB File Offset: 0x00011FAB
		public void SetComputeBufferData(ComputeBuffer buffer, Array data)
		{
			this.SetBufferData(buffer, data);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00013DB7 File Offset: 0x00011FB7
		public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct
		{
			this.SetBufferData<T>(buffer, data);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00013DC3 File Offset: 0x00011FC3
		public void SetComputeBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.SetBufferData<T>(buffer, data);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00013DCF File Offset: 0x00011FCF
		public void SetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			this.SetBufferData(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			this.SetBufferData<T>(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00013DF1 File Offset: 0x00011FF1
		public void SetComputeBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			this.SetBufferData<T>(buffer, data, nativeBufferStartIndex, graphicsBufferStartIndex, count);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00013E02 File Offset: 0x00012002
		public void SetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue)
		{
			this.SetBufferCounterValue(buffer, counterValue);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00013E0E File Offset: 0x0001200E
		public void ConvertTexture_Internal_Injected(ref RenderTargetIdentifier src, int srcElement, ref RenderTargetIdentifier dst, int dstElement)
		{
			CommandBuffer.ConvertTexture_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref src, srcElement, ref dst, dstElement);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00013E25 File Offset: 0x00012025
		public void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val)
		{
			CommandBuffer.SetComputeVectorParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, ref val);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00013E3F File Offset: 0x0001203F
		public void SetComputeMatrixParam_Injected(ComputeShader computeShader, int nameID, ref Matrix4x4 val)
		{
			CommandBuffer.SetComputeMatrixParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, ref val);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00013E59 File Offset: 0x00012059
		public void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref Vector4 val)
		{
			CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref val);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00013E73 File Offset: 0x00012073
		public void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref Matrix4x4 val)
		{
			CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref val);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00013E8D File Offset: 0x0001208D
		public void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, ref Vector3 relativeOrigin)
		{
			CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure), ref relativeOrigin);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00013EA6 File Offset: 0x000120A6
		public void Internal_GenerateMips_Injected(ref RenderTargetIdentifier rt)
		{
			CommandBuffer.Internal_GenerateMips_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rt);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00013EB9 File Offset: 0x000120B9
		public void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), submeshIndex, shaderPass, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00069478 File Offset: 0x00067678
		public void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x000694AC File Offset: 0x000676AC
		public void Internal_DrawProceduralIndexed_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000694E8 File Offset: 0x000676E8
		public void Internal_DrawProceduralIndirect_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00069520 File Offset: 0x00067720
		public void Internal_DrawProceduralIndexedIndirect_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00069560 File Offset: 0x00067760
		public void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00069598 File Offset: 0x00067798
		public void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00013EE3 File Offset: 0x000120E3
		public void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport)
		{
			CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref normalizedCamViewport);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00013EF6 File Offset: 0x000120F6
		public void SetViewport_Injected(ref Rect pixelRect)
		{
			CommandBuffer.SetViewport_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref pixelRect);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00013F09 File Offset: 0x00012109
		public void EnableScissorRect_Injected(ref Rect scissor)
		{
			CommandBuffer.EnableScissorRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref scissor);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000695D8 File Offset: 0x000677D8
		public void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			CommandBuffer.Blit_Texture_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(source), ref dest, IL2CPP.Il2CppObjectBaseToPtr(mat), pass, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0006960C File Offset: 0x0006780C
		public void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			CommandBuffer.Blit_Identifier_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref source, ref dest, IL2CPP.Il2CppObjectBaseToPtr(mat), pass, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00013F1C File Offset: 0x0001211C
		public void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter)
		{
			CommandBuffer.GetTemporaryRTWithDescriptor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref desc, filter);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00013F31 File Offset: 0x00012131
		public void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil)
		{
			CommandBuffer.ClearRenderTarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), clearFlags, ref backgroundColor, depth, stencil);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00013F48 File Offset: 0x00012148
		public void SetGlobalVector_Injected(int nameID, ref Vector4 value)
		{
			CommandBuffer.SetGlobalVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref value);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00013F5C File Offset: 0x0001215C
		public void SetGlobalColor_Injected(int nameID, ref Color value)
		{
			CommandBuffer.SetGlobalColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref value);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00013F70 File Offset: 0x00012170
		public void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value)
		{
			CommandBuffer.SetGlobalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref value);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00013F84 File Offset: 0x00012184
		public void SetViewMatrix_Injected(ref Matrix4x4 view)
		{
			CommandBuffer.SetViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref view);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00013F97 File Offset: 0x00012197
		public void SetProjectionMatrix_Injected(ref Matrix4x4 proj)
		{
			CommandBuffer.SetProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref proj);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00013FAA File Offset: 0x000121AA
		public void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj)
		{
			CommandBuffer.SetViewProjectionMatrices_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref view, ref proj);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00013FBE File Offset: 0x000121BE
		public void IncrementUpdateCount_Injected(ref RenderTargetIdentifier dest)
		{
			CommandBuffer.IncrementUpdateCount_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref dest);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00013FD1 File Offset: 0x000121D1
		public void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			CommandBuffer.SetRenderTargetSingle_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0006963C File Offset: 0x0006783C
		public void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			CommandBuffer.SetRenderTargetColorDepth_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, flags);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00069664 File Offset: 0x00067864
		public void SetRenderTargetMulti_Internal_Injected(Il2CppStructArray<RenderTargetIdentifier> colors, ref RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			CommandBuffer.SetRenderTargetMulti_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), ref depth, IL2CPP.Il2CppObjectBaseToPtr(colorLoadActions), IL2CPP.Il2CppObjectBaseToPtr(colorStoreActions), depthLoadAction, depthStoreAction, flags);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0006969C File Offset: 0x0006789C
		public void SetRenderTargetColorDepthSubtarget_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000696C8 File Offset: 0x000678C8
		public void SetRenderTargetMultiSubtarget_Injected(Il2CppStructArray<RenderTargetIdentifier> colors, ref RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), ref depth, IL2CPP.Il2CppObjectBaseToPtr(colorLoadActions), IL2CPP.Il2CppObjectBaseToPtr(colorStoreActions), depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00069704 File Offset: 0x00067904
		public void Internal_ProcessVTFeedback_Injected(ref RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x04001AC2 RID: 6850
		private static readonly CommandBuffer.WaitAllAsyncReadbackRequestsDelegate WaitAllAsyncReadbackRequestsDelegateField = IL2CPP.ResolveICall<CommandBuffer.WaitAllAsyncReadbackRequestsDelegate>("UnityEngine.Rendering.CommandBuffer::WaitAllAsyncReadbackRequests");

		// Token: 0x04001AC3 RID: 6851
		private static readonly CommandBuffer.SetInvertCullingDelegate SetInvertCullingDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetInvertCullingDelegate>("UnityEngine.Rendering.CommandBuffer::SetInvertCulling");

		// Token: 0x04001AC4 RID: 6852
		private static readonly CommandBuffer.Internal_SetSinglePassStereoDelegate Internal_SetSinglePassStereoDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetSinglePassStereoDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetSinglePassStereo");

		// Token: 0x04001AC5 RID: 6853
		private static readonly CommandBuffer.InitBufferDelegate InitBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.InitBufferDelegate>("UnityEngine.Rendering.CommandBuffer::InitBuffer");

		// Token: 0x04001AC6 RID: 6854
		private static readonly CommandBuffer.CreateGPUFence_InternalDelegate CreateGPUFence_InternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.CreateGPUFence_InternalDelegate>("UnityEngine.Rendering.CommandBuffer::CreateGPUFence_Internal");

		// Token: 0x04001AC7 RID: 6855
		private static readonly CommandBuffer.WaitOnGPUFence_InternalDelegate WaitOnGPUFence_InternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.WaitOnGPUFence_InternalDelegate>("UnityEngine.Rendering.CommandBuffer::WaitOnGPUFence_Internal");

		// Token: 0x04001AC8 RID: 6856
		private static readonly CommandBuffer.ReleaseBufferDelegate ReleaseBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.ReleaseBufferDelegate>("UnityEngine.Rendering.CommandBuffer::ReleaseBuffer");

		// Token: 0x04001AC9 RID: 6857
		private static readonly CommandBuffer.SetComputeFloatParamDelegate SetComputeFloatParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeFloatParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeFloatParam");

		// Token: 0x04001ACA RID: 6858
		private static readonly CommandBuffer.SetComputeIntParamDelegate SetComputeIntParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeIntParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeIntParam");

		// Token: 0x04001ACB RID: 6859
		private static readonly CommandBuffer.SetComputeVectorArrayParamDelegate SetComputeVectorArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeVectorArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeVectorArrayParam");

		// Token: 0x04001ACC RID: 6860
		private static readonly CommandBuffer.SetComputeMatrixArrayParamDelegate SetComputeMatrixArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeMatrixArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeMatrixArrayParam");

		// Token: 0x04001ACD RID: 6861
		private static readonly CommandBuffer.Internal_SetComputeFloatsDelegate Internal_SetComputeFloatsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeFloatsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeFloats");

		// Token: 0x04001ACE RID: 6862
		private static readonly CommandBuffer.Internal_SetComputeIntsDelegate Internal_SetComputeIntsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeIntsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeInts");

		// Token: 0x04001ACF RID: 6863
		private static readonly CommandBuffer.Internal_SetComputeTextureParamDelegate Internal_SetComputeTextureParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeTextureParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeTextureParam");

		// Token: 0x04001AD0 RID: 6864
		private static readonly CommandBuffer.Internal_SetComputeBufferParamDelegate Internal_SetComputeBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeBufferParam");

		// Token: 0x04001AD1 RID: 6865
		private static readonly CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegate Internal_SetComputeGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeGraphicsBufferParam");

		// Token: 0x04001AD2 RID: 6866
		private static readonly CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegate Internal_SetComputeConstantComputeBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeConstantComputeBufferParam");

		// Token: 0x04001AD3 RID: 6867
		private static readonly CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegate Internal_SetComputeConstantGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeConstantGraphicsBufferParam");

		// Token: 0x04001AD4 RID: 6868
		private static readonly CommandBuffer.Internal_DispatchComputeDelegate Internal_DispatchComputeDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchComputeDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchCompute");

		// Token: 0x04001AD5 RID: 6869
		private static readonly CommandBuffer.Internal_DispatchComputeIndirectDelegate Internal_DispatchComputeIndirectDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchComputeIndirectDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchComputeIndirect");

		// Token: 0x04001AD6 RID: 6870
		private static readonly CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegate Internal_DispatchComputeIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchComputeIndirectGraphicsBuffer");

		// Token: 0x04001AD7 RID: 6871
		private static readonly CommandBuffer.Internal_SetRayTracingBufferParamDelegate Internal_SetRayTracingBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingBufferParam");

		// Token: 0x04001AD8 RID: 6872
		private static readonly CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegate Internal_SetRayTracingConstantComputeBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingConstantComputeBufferParam");

		// Token: 0x04001AD9 RID: 6873
		private static readonly CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegate Internal_SetRayTracingConstantGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingConstantGraphicsBufferParam");

		// Token: 0x04001ADA RID: 6874
		private static readonly CommandBuffer.Internal_SetRayTracingTextureParamDelegate Internal_SetRayTracingTextureParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingTextureParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingTextureParam");

		// Token: 0x04001ADB RID: 6875
		private static readonly CommandBuffer.Internal_SetRayTracingFloatParamDelegate Internal_SetRayTracingFloatParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingFloatParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingFloatParam");

		// Token: 0x04001ADC RID: 6876
		private static readonly CommandBuffer.Internal_SetRayTracingIntParamDelegate Internal_SetRayTracingIntParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingIntParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingIntParam");

		// Token: 0x04001ADD RID: 6877
		private static readonly CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegate Internal_SetRayTracingVectorArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingVectorArrayParam");

		// Token: 0x04001ADE RID: 6878
		private static readonly CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegate Internal_SetRayTracingMatrixArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingMatrixArrayParam");

		// Token: 0x04001ADF RID: 6879
		private static readonly CommandBuffer.Internal_SetRayTracingFloatsDelegate Internal_SetRayTracingFloatsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingFloatsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingFloats");

		// Token: 0x04001AE0 RID: 6880
		private static readonly CommandBuffer.Internal_SetRayTracingIntsDelegate Internal_SetRayTracingIntsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingIntsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingInts");

		// Token: 0x04001AE1 RID: 6881
		private static readonly CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegate Internal_SetRayTracingAccelerationStructureDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingAccelerationStructure");

		// Token: 0x04001AE2 RID: 6882
		private static readonly CommandBuffer.SetRayTracingShaderPassDelegate SetRayTracingShaderPassDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRayTracingShaderPassDelegate>("UnityEngine.Rendering.CommandBuffer::SetRayTracingShaderPass");

		// Token: 0x04001AE3 RID: 6883
		private static readonly CommandBuffer.Internal_DispatchRaysDelegate Internal_DispatchRaysDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchRaysDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchRays");

		// Token: 0x04001AE4 RID: 6884
		private static readonly CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegate Internal_ResolveAntiAliasedSurfaceDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_ResolveAntiAliasedSurface");

		// Token: 0x04001AE5 RID: 6885
		private static readonly CommandBuffer.CopyCounterValueCCDelegate CopyCounterValueCCDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueCCDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueCC");

		// Token: 0x04001AE6 RID: 6886
		private static readonly CommandBuffer.CopyCounterValueGCDelegate CopyCounterValueGCDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueGCDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueGC");

		// Token: 0x04001AE7 RID: 6887
		private static readonly CommandBuffer.CopyCounterValueCGDelegate CopyCounterValueCGDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueCGDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueCG");

		// Token: 0x04001AE8 RID: 6888
		private static readonly CommandBuffer.CopyCounterValueGGDelegate CopyCounterValueGGDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueGGDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueGG");

		// Token: 0x04001AE9 RID: 6889
		private static readonly CommandBuffer.get_nameDelegate get_nameDelegateField = IL2CPP.ResolveICall<CommandBuffer.get_nameDelegate>("UnityEngine.Rendering.CommandBuffer::get_name");

		// Token: 0x04001AEA RID: 6890
		private static readonly CommandBuffer.set_nameDelegate set_nameDelegateField = IL2CPP.ResolveICall<CommandBuffer.set_nameDelegate>("UnityEngine.Rendering.CommandBuffer::set_name");

		// Token: 0x04001AEB RID: 6891
		private static readonly CommandBuffer.get_sizeInBytesDelegate get_sizeInBytesDelegateField = IL2CPP.ResolveICall<CommandBuffer.get_sizeInBytesDelegate>("UnityEngine.Rendering.CommandBuffer::get_sizeInBytes");

		// Token: 0x04001AEC RID: 6892
		private static readonly CommandBuffer.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<CommandBuffer.ClearDelegate>("UnityEngine.Rendering.CommandBuffer::Clear");

		// Token: 0x04001AED RID: 6893
		private static readonly CommandBuffer.Internal_DrawRendererDelegate Internal_DrawRendererDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawRendererDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawRenderer");

		// Token: 0x04001AEE RID: 6894
		private static readonly CommandBuffer.Internal_DrawMeshInstancedDelegate Internal_DrawMeshInstancedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstanced");

		// Token: 0x04001AEF RID: 6895
		private static readonly CommandBuffer.Internal_DrawMeshInstancedProceduralDelegate Internal_DrawMeshInstancedProceduralDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedProceduralDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedProcedural");

		// Token: 0x04001AF0 RID: 6896
		private static readonly CommandBuffer.Internal_DrawMeshInstancedIndirectDelegate Internal_DrawMeshInstancedIndirectDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedIndirectDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedIndirect");

		// Token: 0x04001AF1 RID: 6897
		private static readonly CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate Internal_DrawMeshInstancedIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedIndirectGraphicsBuffer");

		// Token: 0x04001AF2 RID: 6898
		private static readonly CommandBuffer.SetRandomWriteTarget_TextureDelegate SetRandomWriteTarget_TextureDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_TextureDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_Texture");

		// Token: 0x04001AF3 RID: 6899
		private static readonly CommandBuffer.SetRandomWriteTarget_BufferDelegate SetRandomWriteTarget_BufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_BufferDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_Buffer");

		// Token: 0x04001AF4 RID: 6900
		private static readonly CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegate SetRandomWriteTarget_GraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_GraphicsBuffer");

		// Token: 0x04001AF5 RID: 6901
		private static readonly CommandBuffer.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<CommandBuffer.ClearRandomWriteTargetsDelegate>("UnityEngine.Rendering.CommandBuffer::ClearRandomWriteTargets");

		// Token: 0x04001AF6 RID: 6902
		private static readonly CommandBuffer.DisableScissorRectDelegate DisableScissorRectDelegateField = IL2CPP.ResolveICall<CommandBuffer.DisableScissorRectDelegate>("UnityEngine.Rendering.CommandBuffer::DisableScissorRect");

		// Token: 0x04001AF7 RID: 6903
		private static readonly CommandBuffer.CopyTexture_InternalDelegate CopyTexture_InternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyTexture_InternalDelegate>("UnityEngine.Rendering.CommandBuffer::CopyTexture_Internal");

		// Token: 0x04001AF8 RID: 6904
		private static readonly CommandBuffer.GetTemporaryRTDelegate GetTemporaryRTDelegateField = IL2CPP.ResolveICall<CommandBuffer.GetTemporaryRTDelegate>("UnityEngine.Rendering.CommandBuffer::GetTemporaryRT");

		// Token: 0x04001AF9 RID: 6905
		private static readonly CommandBuffer.GetTemporaryRTArrayDelegate GetTemporaryRTArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.GetTemporaryRTArrayDelegate>("UnityEngine.Rendering.CommandBuffer::GetTemporaryRTArray");

		// Token: 0x04001AFA RID: 6906
		private static readonly CommandBuffer.ReleaseTemporaryRTDelegate ReleaseTemporaryRTDelegateField = IL2CPP.ResolveICall<CommandBuffer.ReleaseTemporaryRTDelegate>("UnityEngine.Rendering.CommandBuffer::ReleaseTemporaryRT");

		// Token: 0x04001AFB RID: 6907
		private static readonly CommandBuffer.SetGlobalFloatDelegate SetGlobalFloatDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalFloatDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalFloat");

		// Token: 0x04001AFC RID: 6908
		private static readonly CommandBuffer.SetGlobalIntDelegate SetGlobalIntDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalIntDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalInt");

		// Token: 0x04001AFD RID: 6909
		private static readonly CommandBuffer.EnableShaderKeywordDelegate EnableShaderKeywordDelegateField = IL2CPP.ResolveICall<CommandBuffer.EnableShaderKeywordDelegate>("UnityEngine.Rendering.CommandBuffer::EnableShaderKeyword");

		// Token: 0x04001AFE RID: 6910
		private static readonly CommandBuffer.DisableShaderKeywordDelegate DisableShaderKeywordDelegateField = IL2CPP.ResolveICall<CommandBuffer.DisableShaderKeywordDelegate>("UnityEngine.Rendering.CommandBuffer::DisableShaderKeyword");

		// Token: 0x04001AFF RID: 6911
		private static readonly CommandBuffer.SetGlobalDepthBiasDelegate SetGlobalDepthBiasDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalDepthBiasDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalDepthBias");

		// Token: 0x04001B00 RID: 6912
		private static readonly CommandBuffer.SetExecutionFlagsDelegate SetExecutionFlagsDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetExecutionFlagsDelegate>("UnityEngine.Rendering.CommandBuffer::SetExecutionFlags");

		// Token: 0x04001B01 RID: 6913
		private static readonly CommandBuffer.ValidateAgainstExecutionFlagsDelegate ValidateAgainstExecutionFlagsDelegateField = IL2CPP.ResolveICall<CommandBuffer.ValidateAgainstExecutionFlagsDelegate>("UnityEngine.Rendering.CommandBuffer::ValidateAgainstExecutionFlags");

		// Token: 0x04001B02 RID: 6914
		private static readonly CommandBuffer.SetGlobalFloatArrayListImplDelegate SetGlobalFloatArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalFloatArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalFloatArrayListImpl");

		// Token: 0x04001B03 RID: 6915
		private static readonly CommandBuffer.SetGlobalVectorArrayListImplDelegate SetGlobalVectorArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalVectorArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalVectorArrayListImpl");

		// Token: 0x04001B04 RID: 6916
		private static readonly CommandBuffer.SetGlobalMatrixArrayListImplDelegate SetGlobalMatrixArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrixArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrixArrayListImpl");

		// Token: 0x04001B05 RID: 6917
		private static readonly CommandBuffer.SetGlobalFloatArrayDelegate SetGlobalFloatArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalFloatArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalFloatArray");

		// Token: 0x04001B06 RID: 6918
		private static readonly CommandBuffer.SetGlobalVectorArrayDelegate SetGlobalVectorArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalVectorArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalVectorArray");

		// Token: 0x04001B07 RID: 6919
		private static readonly CommandBuffer.SetGlobalMatrixArrayDelegate SetGlobalMatrixArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrixArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrixArray");

		// Token: 0x04001B08 RID: 6920
		private static readonly CommandBuffer.SetGlobalTexture_ImplDelegate SetGlobalTexture_ImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalTexture_ImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalTexture_Impl");

		// Token: 0x04001B09 RID: 6921
		private static readonly CommandBuffer.SetGlobalBufferInternalDelegate SetGlobalBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalBufferInternal");

		// Token: 0x04001B0A RID: 6922
		private static readonly CommandBuffer.SetGlobalGraphicsBufferInternalDelegate SetGlobalGraphicsBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalGraphicsBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalGraphicsBufferInternal");

		// Token: 0x04001B0B RID: 6923
		private static readonly CommandBuffer.SetShadowSamplingMode_ImplDelegate SetShadowSamplingMode_ImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetShadowSamplingMode_ImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetShadowSamplingMode_Impl");

		// Token: 0x04001B0C RID: 6924
		private static readonly CommandBuffer.IssuePluginEventInternalDelegate IssuePluginEventInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginEventInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginEventInternal");

		// Token: 0x04001B0D RID: 6925
		private static readonly CommandBuffer.BeginSampleDelegate BeginSampleDelegateField = IL2CPP.ResolveICall<CommandBuffer.BeginSampleDelegate>("UnityEngine.Rendering.CommandBuffer::BeginSample");

		// Token: 0x04001B0E RID: 6926
		private static readonly CommandBuffer.EndSampleDelegate EndSampleDelegateField = IL2CPP.ResolveICall<CommandBuffer.EndSampleDelegate>("UnityEngine.Rendering.CommandBuffer::EndSample");

		// Token: 0x04001B0F RID: 6927
		private static readonly CommandBuffer.BeginSample_CustomSamplerDelegate BeginSample_CustomSamplerDelegateField = IL2CPP.ResolveICall<CommandBuffer.BeginSample_CustomSamplerDelegate>("UnityEngine.Rendering.CommandBuffer::BeginSample_CustomSampler");

		// Token: 0x04001B10 RID: 6928
		private static readonly CommandBuffer.EndSample_CustomSamplerDelegate EndSample_CustomSamplerDelegateField = IL2CPP.ResolveICall<CommandBuffer.EndSample_CustomSamplerDelegate>("UnityEngine.Rendering.CommandBuffer::EndSample_CustomSampler");

		// Token: 0x04001B11 RID: 6929
		private static readonly CommandBuffer.IssuePluginEventAndDataInternalDelegate IssuePluginEventAndDataInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginEventAndDataInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginEventAndDataInternal");

		// Token: 0x04001B12 RID: 6930
		private static readonly CommandBuffer.IssuePluginCustomBlitInternalDelegate IssuePluginCustomBlitInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginCustomBlitInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginCustomBlitInternal");

		// Token: 0x04001B13 RID: 6931
		private static readonly CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegate IssuePluginCustomTextureUpdateInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginCustomTextureUpdateInternal");

		// Token: 0x04001B14 RID: 6932
		private static readonly CommandBuffer.SetGlobalConstantBufferInternalDelegate SetGlobalConstantBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalConstantBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalConstantBufferInternal");

		// Token: 0x04001B15 RID: 6933
		private static readonly CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegate SetGlobalConstantGraphicsBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalConstantGraphicsBufferInternal");

		// Token: 0x04001B16 RID: 6934
		private static readonly CommandBuffer.SetInstanceMultiplierDelegate SetInstanceMultiplierDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetInstanceMultiplierDelegate>("UnityEngine.Rendering.CommandBuffer::SetInstanceMultiplier");

		// Token: 0x04001B17 RID: 6935
		private static readonly CommandBuffer.InternalSetComputeBufferNativeDataDelegate InternalSetComputeBufferNativeDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetComputeBufferNativeDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetComputeBufferNativeData");

		// Token: 0x04001B18 RID: 6936
		private static readonly CommandBuffer.InternalSetComputeBufferDataDelegate InternalSetComputeBufferDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetComputeBufferDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetComputeBufferData");

		// Token: 0x04001B19 RID: 6937
		private static readonly CommandBuffer.InternalSetComputeBufferCounterValueDelegate InternalSetComputeBufferCounterValueDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetComputeBufferCounterValueDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetComputeBufferCounterValue");

		// Token: 0x04001B1A RID: 6938
		private static readonly CommandBuffer.InternalSetGraphicsBufferNativeDataDelegate InternalSetGraphicsBufferNativeDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetGraphicsBufferNativeDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetGraphicsBufferNativeData");

		// Token: 0x04001B1B RID: 6939
		private static readonly CommandBuffer.InternalSetGraphicsBufferDataDelegate InternalSetGraphicsBufferDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetGraphicsBufferDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetGraphicsBufferData");

		// Token: 0x04001B1C RID: 6940
		private static readonly CommandBuffer.InternalSetGraphicsBufferCounterValueDelegate InternalSetGraphicsBufferCounterValueDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetGraphicsBufferCounterValueDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetGraphicsBufferCounterValue");

		// Token: 0x04001B1D RID: 6941
		private static readonly CommandBuffer.ConvertTexture_Internal_InjectedDelegate ConvertTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.ConvertTexture_Internal_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::ConvertTexture_Internal_Injected");

		// Token: 0x04001B1E RID: 6942
		private static readonly CommandBuffer.SetComputeVectorParam_InjectedDelegate SetComputeVectorParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeVectorParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeVectorParam_Injected");

		// Token: 0x04001B1F RID: 6943
		private static readonly CommandBuffer.SetComputeMatrixParam_InjectedDelegate SetComputeMatrixParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeMatrixParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeMatrixParam_Injected");

		// Token: 0x04001B20 RID: 6944
		private static readonly CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegate Internal_SetRayTracingVectorParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingVectorParam_Injected");

		// Token: 0x04001B21 RID: 6945
		private static readonly CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegate Internal_SetRayTracingMatrixParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingMatrixParam_Injected");

		// Token: 0x04001B22 RID: 6946
		private static readonly CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegate Internal_BuildRayTracingAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_BuildRayTracingAccelerationStructure_Injected");

		// Token: 0x04001B23 RID: 6947
		private static readonly CommandBuffer.Internal_GenerateMips_InjectedDelegate Internal_GenerateMips_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_GenerateMips_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_GenerateMips_Injected");

		// Token: 0x04001B24 RID: 6948
		private static readonly CommandBuffer.Internal_DrawMesh_InjectedDelegate Internal_DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMesh_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMesh_Injected");

		// Token: 0x04001B25 RID: 6949
		private static readonly CommandBuffer.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProcedural_Injected");

		// Token: 0x04001B26 RID: 6950
		private static readonly CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexed_Injected");

		// Token: 0x04001B27 RID: 6951
		private static readonly CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndirect_Injected");

		// Token: 0x04001B28 RID: 6952
		private static readonly CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexedIndirect_Injected");

		// Token: 0x04001B29 RID: 6953
		private static readonly CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");

		// Token: 0x04001B2A RID: 6954
		private static readonly CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");

		// Token: 0x04001B2B RID: 6955
		private static readonly CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegate Internal_DrawOcclusionMesh_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawOcclusionMesh_Injected");

		// Token: 0x04001B2C RID: 6956
		private static readonly CommandBuffer.SetViewport_InjectedDelegate SetViewport_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetViewport_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetViewport_Injected");

		// Token: 0x04001B2D RID: 6957
		private static readonly CommandBuffer.EnableScissorRect_InjectedDelegate EnableScissorRect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.EnableScissorRect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::EnableScissorRect_Injected");

		// Token: 0x04001B2E RID: 6958
		private static readonly CommandBuffer.Blit_Texture_InjectedDelegate Blit_Texture_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Blit_Texture_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Blit_Texture_Injected");

		// Token: 0x04001B2F RID: 6959
		private static readonly CommandBuffer.Blit_Identifier_InjectedDelegate Blit_Identifier_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Blit_Identifier_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Blit_Identifier_Injected");

		// Token: 0x04001B30 RID: 6960
		private static readonly CommandBuffer.GetTemporaryRTWithDescriptor_InjectedDelegate GetTemporaryRTWithDescriptor_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.GetTemporaryRTWithDescriptor_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::GetTemporaryRTWithDescriptor_Injected");

		// Token: 0x04001B31 RID: 6961
		private static readonly CommandBuffer.ClearRenderTarget_InjectedDelegate ClearRenderTarget_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.ClearRenderTarget_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::ClearRenderTarget_Injected");

		// Token: 0x04001B32 RID: 6962
		private static readonly CommandBuffer.SetGlobalVector_InjectedDelegate SetGlobalVector_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalVector_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalVector_Injected");

		// Token: 0x04001B33 RID: 6963
		private static readonly CommandBuffer.SetGlobalColor_InjectedDelegate SetGlobalColor_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalColor_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalColor_Injected");

		// Token: 0x04001B34 RID: 6964
		private static readonly CommandBuffer.SetGlobalMatrix_InjectedDelegate SetGlobalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrix_Injected");

		// Token: 0x04001B35 RID: 6965
		private static readonly CommandBuffer.SetViewMatrix_InjectedDelegate SetViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetViewMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetViewMatrix_Injected");

		// Token: 0x04001B36 RID: 6966
		private static readonly CommandBuffer.SetProjectionMatrix_InjectedDelegate SetProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetProjectionMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetProjectionMatrix_Injected");

		// Token: 0x04001B37 RID: 6967
		private static readonly CommandBuffer.SetViewProjectionMatrices_InjectedDelegate SetViewProjectionMatrices_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetViewProjectionMatrices_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetViewProjectionMatrices_Injected");

		// Token: 0x04001B38 RID: 6968
		private static readonly CommandBuffer.IncrementUpdateCount_InjectedDelegate IncrementUpdateCount_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.IncrementUpdateCount_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::IncrementUpdateCount_Injected");

		// Token: 0x04001B39 RID: 6969
		private static readonly CommandBuffer.SetRenderTargetSingle_Internal_InjectedDelegate SetRenderTargetSingle_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetSingle_Internal_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetSingle_Internal_Injected");

		// Token: 0x04001B3A RID: 6970
		private static readonly CommandBuffer.SetRenderTargetColorDepth_Internal_InjectedDelegate SetRenderTargetColorDepth_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetColorDepth_Internal_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetColorDepth_Internal_Injected");

		// Token: 0x04001B3B RID: 6971
		private static readonly CommandBuffer.SetRenderTargetMulti_Internal_InjectedDelegate SetRenderTargetMulti_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetMulti_Internal_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetMulti_Internal_Injected");

		// Token: 0x04001B3C RID: 6972
		private static readonly CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegate SetRenderTargetColorDepthSubtarget_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetColorDepthSubtarget_Injected");

		// Token: 0x04001B3D RID: 6973
		private static readonly CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegate SetRenderTargetMultiSubtarget_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetMultiSubtarget_Injected");

		// Token: 0x04001B3E RID: 6974
		private static readonly CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegate Internal_ProcessVTFeedback_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_ProcessVTFeedback_Injected");

		// Token: 0x02000C7B RID: 3195
		// (Invoke) Token: 0x060036DC RID: 14044
		private delegate void WaitAllAsyncReadbackRequestsDelegate(IntPtr @this);

		// Token: 0x02000C7C RID: 3196
		// (Invoke) Token: 0x060036DE RID: 14046
		private delegate void SetInvertCullingDelegate(IntPtr @this, bool invertCulling);

		// Token: 0x02000C7D RID: 3197
		// (Invoke) Token: 0x060036E0 RID: 14048
		private delegate void Internal_SetSinglePassStereoDelegate(IntPtr @this, SinglePassStereoMode mode);

		// Token: 0x02000C7E RID: 3198
		// (Invoke) Token: 0x060036E2 RID: 14050
		private delegate IntPtr InitBufferDelegate();

		// Token: 0x02000C7F RID: 3199
		// (Invoke) Token: 0x060036E4 RID: 14052
		private delegate IntPtr CreateGPUFence_InternalDelegate(IntPtr @this, GraphicsFenceType fenceType, SynchronisationStageFlags stage);

		// Token: 0x02000C80 RID: 3200
		// (Invoke) Token: 0x060036E6 RID: 14054
		private delegate void WaitOnGPUFence_InternalDelegate(IntPtr @this, IntPtr fencePtr, SynchronisationStageFlags stage);

		// Token: 0x02000C81 RID: 3201
		// (Invoke) Token: 0x060036E8 RID: 14056
		private delegate void ReleaseBufferDelegate(IntPtr @this);

		// Token: 0x02000C82 RID: 3202
		// (Invoke) Token: 0x060036EA RID: 14058
		private delegate void SetComputeFloatParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, float val);

		// Token: 0x02000C83 RID: 3203
		// (Invoke) Token: 0x060036EC RID: 14060
		private delegate void SetComputeIntParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, int val);

		// Token: 0x02000C84 RID: 3204
		// (Invoke) Token: 0x060036EE RID: 14062
		private delegate void SetComputeVectorArrayParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x02000C85 RID: 3205
		// (Invoke) Token: 0x060036F0 RID: 14064
		private delegate void SetComputeMatrixArrayParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x02000C86 RID: 3206
		// (Invoke) Token: 0x060036F2 RID: 14066
		private delegate void Internal_SetComputeFloatsDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x02000C87 RID: 3207
		// (Invoke) Token: 0x060036F4 RID: 14068
		private delegate void Internal_SetComputeIntsDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x02000C88 RID: 3208
		// (Invoke) Token: 0x060036F6 RID: 14070
		private delegate void Internal_SetComputeTextureParamDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, int nameID, IntPtr rt, int mipLevel, RenderTextureSubElement element);

		// Token: 0x02000C89 RID: 3209
		// (Invoke) Token: 0x060036F8 RID: 14072
		private delegate void Internal_SetComputeBufferParamDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x02000C8A RID: 3210
		// (Invoke) Token: 0x060036FA RID: 14074
		private delegate void Internal_SetComputeGraphicsBufferParamDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x02000C8B RID: 3211
		// (Invoke) Token: 0x060036FC RID: 14076
		private delegate void Internal_SetComputeConstantComputeBufferParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C8C RID: 3212
		// (Invoke) Token: 0x060036FE RID: 14078
		private delegate void Internal_SetComputeConstantGraphicsBufferParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C8D RID: 3213
		// (Invoke) Token: 0x06003700 RID: 14080
		private delegate void Internal_DispatchComputeDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x02000C8E RID: 3214
		// (Invoke) Token: 0x06003702 RID: 14082
		private delegate void Internal_DispatchComputeIndirectDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset);

		// Token: 0x02000C8F RID: 3215
		// (Invoke) Token: 0x06003704 RID: 14084
		private delegate void Internal_DispatchComputeIndirectGraphicsBufferDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset);

		// Token: 0x02000C90 RID: 3216
		// (Invoke) Token: 0x06003706 RID: 14086
		private delegate void Internal_SetRayTracingBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer);

		// Token: 0x02000C91 RID: 3217
		// (Invoke) Token: 0x06003708 RID: 14088
		private delegate void Internal_SetRayTracingConstantComputeBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C92 RID: 3218
		// (Invoke) Token: 0x0600370A RID: 14090
		private delegate void Internal_SetRayTracingConstantGraphicsBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C93 RID: 3219
		// (Invoke) Token: 0x0600370C RID: 14092
		private delegate void Internal_SetRayTracingTextureParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr rt);

		// Token: 0x02000C94 RID: 3220
		// (Invoke) Token: 0x0600370E RID: 14094
		private delegate void Internal_SetRayTracingFloatParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, float val);

		// Token: 0x02000C95 RID: 3221
		// (Invoke) Token: 0x06003710 RID: 14096
		private delegate void Internal_SetRayTracingIntParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, int val);

		// Token: 0x02000C96 RID: 3222
		// (Invoke) Token: 0x06003712 RID: 14098
		private delegate void Internal_SetRayTracingVectorArrayParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x02000C97 RID: 3223
		// (Invoke) Token: 0x06003714 RID: 14100
		private delegate void Internal_SetRayTracingMatrixArrayParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x02000C98 RID: 3224
		// (Invoke) Token: 0x06003716 RID: 14102
		private delegate void Internal_SetRayTracingFloatsDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x02000C99 RID: 3225
		// (Invoke) Token: 0x06003718 RID: 14104
		private delegate void Internal_SetRayTracingIntsDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x02000C9A RID: 3226
		// (Invoke) Token: 0x0600371A RID: 14106
		private delegate void Internal_SetRayTracingAccelerationStructureDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr accelerationStructure);

		// Token: 0x02000C9B RID: 3227
		// (Invoke) Token: 0x0600371C RID: 14108
		private delegate void SetRayTracingShaderPassDelegate(IntPtr @this, IntPtr rayTracingShader, IntPtr passName);

		// Token: 0x02000C9C RID: 3228
		// (Invoke) Token: 0x0600371E RID: 14110
		private delegate void Internal_DispatchRaysDelegate(IntPtr @this, IntPtr rayTracingShader, IntPtr rayGenShaderName, uint width, uint height, uint depth, IntPtr camera);

		// Token: 0x02000C9D RID: 3229
		// (Invoke) Token: 0x06003720 RID: 14112
		private delegate void Internal_ResolveAntiAliasedSurfaceDelegate(IntPtr @this, IntPtr rt, IntPtr target);

		// Token: 0x02000C9E RID: 3230
		// (Invoke) Token: 0x06003722 RID: 14114
		private delegate void CopyCounterValueCCDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000C9F RID: 3231
		// (Invoke) Token: 0x06003724 RID: 14116
		private delegate void CopyCounterValueGCDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000CA0 RID: 3232
		// (Invoke) Token: 0x06003726 RID: 14118
		private delegate void CopyCounterValueCGDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000CA1 RID: 3233
		// (Invoke) Token: 0x06003728 RID: 14120
		private delegate void CopyCounterValueGGDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000CA2 RID: 3234
		// (Invoke) Token: 0x0600372A RID: 14122
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000CA3 RID: 3235
		// (Invoke) Token: 0x0600372C RID: 14124
		private delegate void set_nameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000CA4 RID: 3236
		// (Invoke) Token: 0x0600372E RID: 14126
		private delegate int get_sizeInBytesDelegate(IntPtr @this);

		// Token: 0x02000CA5 RID: 3237
		// (Invoke) Token: 0x06003730 RID: 14128
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000CA6 RID: 3238
		// (Invoke) Token: 0x06003732 RID: 14130
		private delegate void Internal_DrawRendererDelegate(IntPtr @this, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass);

		// Token: 0x02000CA7 RID: 3239
		// (Invoke) Token: 0x06003734 RID: 14132
		private delegate void Internal_DrawMeshInstancedDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr matrices, int count, IntPtr properties);

		// Token: 0x02000CA8 RID: 3240
		// (Invoke) Token: 0x06003736 RID: 14134
		private delegate void Internal_DrawMeshInstancedProceduralDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, int count, IntPtr properties);

		// Token: 0x02000CA9 RID: 3241
		// (Invoke) Token: 0x06003738 RID: 14136
		private delegate void Internal_DrawMeshInstancedIndirectDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CAA RID: 3242
		// (Invoke) Token: 0x0600373A RID: 14138
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CAB RID: 3243
		// (Invoke) Token: 0x0600373C RID: 14140
		private delegate void SetRandomWriteTarget_TextureDelegate(IntPtr @this, int index, IntPtr rt);

		// Token: 0x02000CAC RID: 3244
		// (Invoke) Token: 0x0600373E RID: 14142
		private delegate void SetRandomWriteTarget_BufferDelegate(IntPtr @this, int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x02000CAD RID: 3245
		// (Invoke) Token: 0x06003740 RID: 14144
		private delegate void SetRandomWriteTarget_GraphicsBufferDelegate(IntPtr @this, int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x02000CAE RID: 3246
		// (Invoke) Token: 0x06003742 RID: 14146
		private delegate void ClearRandomWriteTargetsDelegate(IntPtr @this);

		// Token: 0x02000CAF RID: 3247
		// (Invoke) Token: 0x06003744 RID: 14148
		private delegate void DisableScissorRectDelegate(IntPtr @this);

		// Token: 0x02000CB0 RID: 3248
		// (Invoke) Token: 0x06003746 RID: 14150
		private delegate void CopyTexture_InternalDelegate(IntPtr @this, IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY, int mode);

		// Token: 0x02000CB1 RID: 3249
		// (Invoke) Token: 0x06003748 RID: 14152
		private delegate void GetTemporaryRTDelegate(IntPtr @this, int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale);

		// Token: 0x02000CB2 RID: 3250
		// (Invoke) Token: 0x0600374A RID: 14154
		private delegate void GetTemporaryRTArrayDelegate(IntPtr @this, int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale);

		// Token: 0x02000CB3 RID: 3251
		// (Invoke) Token: 0x0600374C RID: 14156
		private delegate void ReleaseTemporaryRTDelegate(IntPtr @this, int nameID);

		// Token: 0x02000CB4 RID: 3252
		// (Invoke) Token: 0x0600374E RID: 14158
		private delegate void SetGlobalFloatDelegate(IntPtr @this, int nameID, float value);

		// Token: 0x02000CB5 RID: 3253
		// (Invoke) Token: 0x06003750 RID: 14160
		private delegate void SetGlobalIntDelegate(IntPtr @this, int nameID, int value);

		// Token: 0x02000CB6 RID: 3254
		// (Invoke) Token: 0x06003752 RID: 14162
		private delegate void EnableShaderKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x02000CB7 RID: 3255
		// (Invoke) Token: 0x06003754 RID: 14164
		private delegate void DisableShaderKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x02000CB8 RID: 3256
		// (Invoke) Token: 0x06003756 RID: 14166
		private delegate void SetGlobalDepthBiasDelegate(IntPtr @this, float bias, float slopeBias);

		// Token: 0x02000CB9 RID: 3257
		// (Invoke) Token: 0x06003758 RID: 14168
		private delegate void SetExecutionFlagsDelegate(IntPtr @this, CommandBufferExecutionFlags flags);

		// Token: 0x02000CBA RID: 3258
		// (Invoke) Token: 0x0600375A RID: 14170
		private delegate bool ValidateAgainstExecutionFlagsDelegate(IntPtr @this, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags);

		// Token: 0x02000CBB RID: 3259
		// (Invoke) Token: 0x0600375C RID: 14172
		private delegate void SetGlobalFloatArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CBC RID: 3260
		// (Invoke) Token: 0x0600375E RID: 14174
		private delegate void SetGlobalVectorArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CBD RID: 3261
		// (Invoke) Token: 0x06003760 RID: 14176
		private delegate void SetGlobalMatrixArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CBE RID: 3262
		// (Invoke) Token: 0x06003762 RID: 14178
		private delegate void SetGlobalFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CBF RID: 3263
		// (Invoke) Token: 0x06003764 RID: 14180
		private delegate void SetGlobalVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CC0 RID: 3264
		// (Invoke) Token: 0x06003766 RID: 14182
		private delegate void SetGlobalMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000CC1 RID: 3265
		// (Invoke) Token: 0x06003768 RID: 14184
		private delegate void SetGlobalTexture_ImplDelegate(IntPtr @this, int nameID, IntPtr rt, RenderTextureSubElement element);

		// Token: 0x02000CC2 RID: 3266
		// (Invoke) Token: 0x0600376A RID: 14186
		private delegate void SetGlobalBufferInternalDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x02000CC3 RID: 3267
		// (Invoke) Token: 0x0600376C RID: 14188
		private delegate void SetGlobalGraphicsBufferInternalDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x02000CC4 RID: 3268
		// (Invoke) Token: 0x0600376E RID: 14190
		private delegate void SetShadowSamplingMode_ImplDelegate(IntPtr @this, IntPtr shadowmap, ShadowSamplingMode mode);

		// Token: 0x02000CC5 RID: 3269
		// (Invoke) Token: 0x06003770 RID: 14192
		private delegate void IssuePluginEventInternalDelegate(IntPtr @this, IntPtr callback, int eventID);

		// Token: 0x02000CC6 RID: 3270
		// (Invoke) Token: 0x06003772 RID: 14194
		private delegate void BeginSampleDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000CC7 RID: 3271
		// (Invoke) Token: 0x06003774 RID: 14196
		private delegate void EndSampleDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000CC8 RID: 3272
		// (Invoke) Token: 0x06003776 RID: 14198
		private delegate void BeginSample_CustomSamplerDelegate(IntPtr @this, IntPtr sampler);

		// Token: 0x02000CC9 RID: 3273
		// (Invoke) Token: 0x06003778 RID: 14200
		private delegate void EndSample_CustomSamplerDelegate(IntPtr @this, IntPtr sampler);

		// Token: 0x02000CCA RID: 3274
		// (Invoke) Token: 0x0600377A RID: 14202
		private delegate void IssuePluginEventAndDataInternalDelegate(IntPtr @this, IntPtr callback, int eventID, IntPtr data);

		// Token: 0x02000CCB RID: 3275
		// (Invoke) Token: 0x0600377C RID: 14204
		private delegate void IssuePluginCustomBlitInternalDelegate(IntPtr @this, IntPtr callback, uint command, IntPtr source, IntPtr dest, uint commandParam, uint commandFlags);

		// Token: 0x02000CCC RID: 3276
		// (Invoke) Token: 0x0600377E RID: 14206
		private delegate void IssuePluginCustomTextureUpdateInternalDelegate(IntPtr @this, IntPtr callback, IntPtr targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);

		// Token: 0x02000CCD RID: 3277
		// (Invoke) Token: 0x06003780 RID: 14208
		private delegate void SetGlobalConstantBufferInternalDelegate(IntPtr @this, IntPtr buffer, int nameID, int offset, int size);

		// Token: 0x02000CCE RID: 3278
		// (Invoke) Token: 0x06003782 RID: 14210
		private delegate void SetGlobalConstantGraphicsBufferInternalDelegate(IntPtr @this, IntPtr buffer, int nameID, int offset, int size);

		// Token: 0x02000CCF RID: 3279
		// (Invoke) Token: 0x06003784 RID: 14212
		private delegate void SetInstanceMultiplierDelegate(IntPtr @this, uint multiplier);

		// Token: 0x02000CD0 RID: 3280
		// (Invoke) Token: 0x06003786 RID: 14214
		private delegate void InternalSetComputeBufferNativeDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000CD1 RID: 3281
		// (Invoke) Token: 0x06003788 RID: 14216
		private delegate void InternalSetComputeBufferDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000CD2 RID: 3282
		// (Invoke) Token: 0x0600378A RID: 14218
		private delegate void InternalSetComputeBufferCounterValueDelegate(IntPtr @this, IntPtr buffer, uint counterValue);

		// Token: 0x02000CD3 RID: 3283
		// (Invoke) Token: 0x0600378C RID: 14220
		private delegate void InternalSetGraphicsBufferNativeDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000CD4 RID: 3284
		// (Invoke) Token: 0x0600378E RID: 14222
		private delegate void InternalSetGraphicsBufferDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000CD5 RID: 3285
		// (Invoke) Token: 0x06003790 RID: 14224
		private delegate void InternalSetGraphicsBufferCounterValueDelegate(IntPtr @this, IntPtr buffer, uint counterValue);

		// Token: 0x02000CD6 RID: 3286
		// (Invoke) Token: 0x06003792 RID: 14226
		private delegate void ConvertTexture_Internal_InjectedDelegate(IntPtr @this, IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000CD7 RID: 3287
		// (Invoke) Token: 0x06003794 RID: 14228
		private delegate void SetComputeVectorParam_InjectedDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr val);

		// Token: 0x02000CD8 RID: 3288
		// (Invoke) Token: 0x06003796 RID: 14230
		private delegate void SetComputeMatrixParam_InjectedDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr val);

		// Token: 0x02000CD9 RID: 3289
		// (Invoke) Token: 0x06003798 RID: 14232
		private delegate void Internal_SetRayTracingVectorParam_InjectedDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr val);

		// Token: 0x02000CDA RID: 3290
		// (Invoke) Token: 0x0600379A RID: 14234
		private delegate void Internal_SetRayTracingMatrixParam_InjectedDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr val);

		// Token: 0x02000CDB RID: 3291
		// (Invoke) Token: 0x0600379C RID: 14236
		private delegate void Internal_BuildRayTracingAccelerationStructure_InjectedDelegate(IntPtr @this, IntPtr accelerationStructure, IntPtr relativeOrigin);

		// Token: 0x02000CDC RID: 3292
		// (Invoke) Token: 0x0600379E RID: 14238
		private delegate void Internal_GenerateMips_InjectedDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x02000CDD RID: 3293
		// (Invoke) Token: 0x060037A0 RID: 14240
		private delegate void Internal_DrawMesh_InjectedDelegate(IntPtr @this, IntPtr mesh, IntPtr matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties);

		// Token: 0x02000CDE RID: 3294
		// (Invoke) Token: 0x060037A2 RID: 14242
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, IntPtr properties);

		// Token: 0x02000CDF RID: 3295
		// (Invoke) Token: 0x060037A4 RID: 14244
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, IntPtr properties);

		// Token: 0x02000CE0 RID: 3296
		// (Invoke) Token: 0x060037A6 RID: 14246
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CE1 RID: 3297
		// (Invoke) Token: 0x060037A8 RID: 14248
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CE2 RID: 3298
		// (Invoke) Token: 0x060037AA RID: 14250
		private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CE3 RID: 3299
		// (Invoke) Token: 0x060037AC RID: 14252
		private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x02000CE4 RID: 3300
		// (Invoke) Token: 0x060037AE RID: 14254
		private delegate void Internal_DrawOcclusionMesh_InjectedDelegate(IntPtr @this, IntPtr normalizedCamViewport);

		// Token: 0x02000CE5 RID: 3301
		// (Invoke) Token: 0x060037B0 RID: 14256
		private delegate void SetViewport_InjectedDelegate(IntPtr @this, IntPtr pixelRect);

		// Token: 0x02000CE6 RID: 3302
		// (Invoke) Token: 0x060037B2 RID: 14258
		private delegate void EnableScissorRect_InjectedDelegate(IntPtr @this, IntPtr scissor);

		// Token: 0x02000CE7 RID: 3303
		// (Invoke) Token: 0x060037B4 RID: 14260
		private delegate void Blit_Texture_InjectedDelegate(IntPtr @this, IntPtr source, IntPtr dest, IntPtr mat, int pass, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x02000CE8 RID: 3304
		// (Invoke) Token: 0x060037B6 RID: 14262
		private delegate void Blit_Identifier_InjectedDelegate(IntPtr @this, IntPtr source, IntPtr dest, IntPtr mat, int pass, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x02000CE9 RID: 3305
		// (Invoke) Token: 0x060037B8 RID: 14264
		private delegate void GetTemporaryRTWithDescriptor_InjectedDelegate(IntPtr @this, int nameID, IntPtr desc, FilterMode filter);

		// Token: 0x02000CEA RID: 3306
		// (Invoke) Token: 0x060037BA RID: 14266
		private delegate void ClearRenderTarget_InjectedDelegate(IntPtr @this, RTClearFlags clearFlags, IntPtr backgroundColor, float depth, uint stencil);

		// Token: 0x02000CEB RID: 3307
		// (Invoke) Token: 0x060037BC RID: 14268
		private delegate void SetGlobalVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x02000CEC RID: 3308
		// (Invoke) Token: 0x060037BE RID: 14270
		private delegate void SetGlobalColor_InjectedDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x02000CED RID: 3309
		// (Invoke) Token: 0x060037C0 RID: 14272
		private delegate void SetGlobalMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x02000CEE RID: 3310
		// (Invoke) Token: 0x060037C2 RID: 14274
		private delegate void SetViewMatrix_InjectedDelegate(IntPtr @this, IntPtr view);

		// Token: 0x02000CEF RID: 3311
		// (Invoke) Token: 0x060037C4 RID: 14276
		private delegate void SetProjectionMatrix_InjectedDelegate(IntPtr @this, IntPtr proj);

		// Token: 0x02000CF0 RID: 3312
		// (Invoke) Token: 0x060037C6 RID: 14278
		private delegate void SetViewProjectionMatrices_InjectedDelegate(IntPtr @this, IntPtr view, IntPtr proj);

		// Token: 0x02000CF1 RID: 3313
		// (Invoke) Token: 0x060037C8 RID: 14280
		private delegate void IncrementUpdateCount_InjectedDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x02000CF2 RID: 3314
		// (Invoke) Token: 0x060037CA RID: 14282
		private delegate void SetRenderTargetSingle_Internal_InjectedDelegate(IntPtr @this, IntPtr rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);

		// Token: 0x02000CF3 RID: 3315
		// (Invoke) Token: 0x060037CC RID: 14284
		private delegate void SetRenderTargetColorDepth_Internal_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags);

		// Token: 0x02000CF4 RID: 3316
		// (Invoke) Token: 0x060037CE RID: 14286
		private delegate void SetRenderTargetMulti_Internal_InjectedDelegate(IntPtr @this, IntPtr colors, IntPtr depth, IntPtr colorLoadActions, IntPtr colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags);

		// Token: 0x02000CF5 RID: 3317
		// (Invoke) Token: 0x060037D0 RID: 14288
		private delegate void SetRenderTargetColorDepthSubtarget_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x02000CF6 RID: 3318
		// (Invoke) Token: 0x060037D2 RID: 14290
		private delegate void SetRenderTargetMultiSubtarget_InjectedDelegate(IntPtr @this, IntPtr colors, IntPtr depth, IntPtr colorLoadActions, IntPtr colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x02000CF7 RID: 3319
		// (Invoke) Token: 0x060037D4 RID: 14292
		private delegate void Internal_ProcessVTFeedback_InjectedDelegate(IntPtr @this, IntPtr rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip);
	}
}
