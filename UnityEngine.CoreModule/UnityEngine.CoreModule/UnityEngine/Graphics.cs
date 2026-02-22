using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200004E RID: 78
	public class Graphics : Object
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00022FE4 File Offset: 0x000211E4
		// Note: this type is marked as 'beforefieldinit'.
		static Graphics()
		{
			Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Graphics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
			Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "kMaxDrawMeshInstanceCount");
			Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663610);
			Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663611);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663612);
			Graphics.GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
			Graphics.get_activeTierDelegateField = IL2CPP.ResolveICall<Graphics.get_activeTierDelegate>("UnityEngine.Graphics::get_activeTier");
			Graphics.set_activeTierDelegateField = IL2CPP.ResolveICall<Graphics.set_activeTierDelegate>("UnityEngine.Graphics::set_activeTier");
			Graphics.GetPreserveFramebufferAlphaDelegateField = IL2CPP.ResolveICall<Graphics.GetPreserveFramebufferAlphaDelegate>("UnityEngine.Graphics::GetPreserveFramebufferAlpha");
			Graphics.GetMinOpenGLESVersionDelegateField = IL2CPP.ResolveICall<Graphics.GetMinOpenGLESVersionDelegate>("UnityEngine.Graphics::GetMinOpenGLESVersion");
			Graphics.Internal_SetNullRTDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetNullRTDelegate>("UnityEngine.Graphics::Internal_SetNullRT");
			Graphics.Internal_SetRandomWriteTargetRTDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetRTDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT");
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer");
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer");
			Graphics.ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<Graphics.ClearRandomWriteTargetsDelegate>("UnityEngine.Graphics::ClearRandomWriteTargets");
			Graphics.CopyTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_FullDelegate>("UnityEngine.Graphics::CopyTexture_Full");
			Graphics.CopyTexture_Slice_AllMipsDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_AllMipsDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips");
			Graphics.CopyTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_SliceDelegate>("UnityEngine.Graphics::CopyTexture_Slice");
			Graphics.CopyTexture_RegionDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_RegionDelegate>("UnityEngine.Graphics::CopyTexture_Region");
			Graphics.ConvertTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_FullDelegate>("UnityEngine.Graphics::ConvertTexture_Full");
			Graphics.ConvertTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_SliceDelegate>("UnityEngine.Graphics::ConvertTexture_Slice");
			Graphics.Internal_DrawMeshInstancedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstanced");
			Graphics.Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
			Graphics.Internal_DrawProceduralIndexedNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow");
			Graphics.Internal_DrawProceduralIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow");
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow");
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer");
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer");
			Graphics.Internal_BlitMaterial5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial5Delegate>("UnityEngine.Graphics::Internal_BlitMaterial5");
			Graphics.Internal_BlitMaterial6DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial6Delegate>("UnityEngine.Graphics::Internal_BlitMaterial6");
			Graphics.Internal_BlitMultiTap4DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap4Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap4");
			Graphics.Internal_BlitMultiTap5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap5Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap5");
			Graphics.Blit3DelegateField = IL2CPP.ResolveICall<Graphics.Blit3Delegate>("UnityEngine.Graphics::Blit3");
			Graphics.CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
			Graphics.WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
			Graphics.ExecuteCommandBufferDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferDelegate>("UnityEngine.Graphics::ExecuteCommandBuffer");
			Graphics.ExecuteCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferAsyncDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync");
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow2_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow2_Injected");
			Graphics.Internal_DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMesh_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMesh_Injected");
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirect_Injected");
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
			Graphics.Blit4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit4_InjectedDelegate>("UnityEngine.Graphics::Blit4_Injected");
			Graphics.Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000232F8 File Offset: 0x000214F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62721, XrefRangeEnd = 62727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetMaxDrawMeshInstanceCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00023328 File Offset: 0x00021528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62727, XrefRangeEnd = 62729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit2(Texture source, RenderTexture dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00023370 File Offset: 0x00021570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62734, RefRangeEnd = 62735, XrefRangeStart = 62729, XrefRangeEnd = 62734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000050F0 File Offset: 0x000032F0
		public Graphics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000233B8 File Offset: 0x000215B8
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000050F9 File Offset: 0x000032F9
		public unsafe static int kMaxDrawMeshInstanceCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&value));
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00005107 File Offset: 0x00003307
		public static ColorGamut GetActiveColorGamut()
		{
			return Graphics.GetActiveColorGamutDelegateField();
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000233D4 File Offset: 0x000215D4
		public static ColorGamut activeColorGamut
		{
			get
			{
				return Graphics.GetActiveColorGamut();
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00005113 File Offset: 0x00003313
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000511F File Offset: 0x0000331F
		public static UnityEngine.Rendering.GraphicsTier activeTier
		{
			get
			{
				return Graphics.get_activeTierDelegateField();
			}
			set
			{
				Graphics.set_activeTierDelegateField(value);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000512C File Offset: 0x0000332C
		public static bool GetPreserveFramebufferAlpha()
		{
			return Graphics.GetPreserveFramebufferAlphaDelegateField();
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000233EC File Offset: 0x000215EC
		public static bool preserveFramebufferAlpha
		{
			get
			{
				return Graphics.GetPreserveFramebufferAlpha();
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00005138 File Offset: 0x00003338
		public static UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
		{
			return Graphics.GetMinOpenGLESVersionDelegateField();
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00023404 File Offset: 0x00021604
		public static UnityEngine.Rendering.OpenGLESVersion minOpenGLESVersion
		{
			get
			{
				return Graphics.GetMinOpenGLESVersion();
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00005144 File Offset: 0x00003344
		public static void Internal_SetNullRT()
		{
			Graphics.Internal_SetNullRTDelegateField();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00005150 File Offset: 0x00003350
		public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRTDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav));
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005163 File Offset: 0x00003363
		public static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00005177 File Offset: 0x00003377
		public static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000518B File Offset: 0x0000338B
		public static void ClearRandomWriteTargets()
		{
			Graphics.ClearRandomWriteTargetsDelegateField();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00005197 File Offset: 0x00003397
		public static void CopyTexture_Full(Texture src, Texture dst)
		{
			Graphics.CopyTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000051AF File Offset: 0x000033AF
		public static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000051C9 File Offset: 0x000033C9
		public static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			Graphics.CopyTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, srcMip, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement, dstMip);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002341C File Offset: 0x0002161C
		public static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			Graphics.CopyTexture_RegionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement, dstMip, dstX, dstY);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000051E7 File Offset: 0x000033E7
		public static bool ConvertTexture_Full(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000051FF File Offset: 0x000033FF
		public static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005219 File Offset: 0x00003419
		public static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_Injected(mesh, subsetIndex, ref position, ref rotation);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00005226 File Offset: 0x00003426
		public static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_Injected(mesh, subsetIndex, ref matrix);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00023454 File Offset: 0x00021654
		public static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMesh_Injected(mesh, submeshIndex, ref matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002347C File Offset: 0x0002167C
		public static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), IL2CPP.Il2CppObjectBaseToPtr(matrices), count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000234C8 File Offset: 0x000216C8
		public static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_Injected(mesh, submeshIndex, material, ref bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000234F0 File Offset: 0x000216F0
		public static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002351C File Offset: 0x0002171C
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00005231 File Offset: 0x00003431
		public static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00005240 File Offset: 0x00003440
		public static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralIndexedNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00005255 File Offset: 0x00003455
		public static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00005269 File Offset: 0x00003469
		public static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00005283 File Offset: 0x00003483
		public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00005297 File Offset: 0x00003497
		public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00023548 File Offset: 0x00021748
		public static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_Injected(material, ref bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002356C File Offset: 0x0002176C
		public static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_Injected(material, ref bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00023594 File Offset: 0x00021794
		public static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000235B8 File Offset: 0x000217B8
		public static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000052B1 File Offset: 0x000034B1
		public static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT)
		{
			Graphics.Internal_BlitMaterial5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000052D2 File Offset: 0x000034D2
		public static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT, destDepthSlice);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000052F5 File Offset: 0x000034F5
		public static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			Graphics.Internal_BlitMultiTap4DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets));
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00005319 File Offset: 0x00003519
		public static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
		{
			Graphics.Internal_BlitMultiTap5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets), destDepthSlice);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000533F File Offset: 0x0000353F
		public static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00005359 File Offset: 0x00003559
		public static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			Graphics.Blit4_Injected(source, dest, ref scale, ref offset);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00005366 File Offset: 0x00003566
		public static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_Injected(source, dest, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00005377 File Offset: 0x00003577
		public static IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			return Graphics.CreateGPUFenceImplDelegateField(fenceType, stage);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005385 File Offset: 0x00003585
		public static void WaitOnGPUFenceImpl(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			Graphics.WaitOnGPUFenceImplDelegateField(fencePtr, stage);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00005393 File Offset: 0x00003593
		public static void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
		{
			Graphics.ExecuteCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000053A5 File Offset: 0x000035A5
		public static void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Graphics.ExecuteCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000053B8 File Offset: 0x000035B8
		public static void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000053C5 File Offset: 0x000035C5
		public static void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000053D2 File Offset: 0x000035D2
		public static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000053DF File Offset: 0x000035DF
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, face, depthSlice);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000235E0 File Offset: 0x000217E0
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			bool flag = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000053EC File Offset: 0x000035EC
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000053F9 File Offset: 0x000035F9
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005406 File Offset: 0x00003606
		public static void CopyTexture(Texture src, Texture dst)
		{
			Graphics.CopyTexture_Full(src, dst);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005411 File Offset: 0x00003611
		public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000541E File Offset: 0x0000361E
		public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			Graphics.CopyTexture_Slice(src, srcElement, srcMip, dst, dstElement, dstMip);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002362C File Offset: 0x0002182C
		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			Graphics.CopyTexture_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00023654 File Offset: 0x00021854
		public static bool ConvertTexture(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_Full(src, dst);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00023670 File Offset: 0x00021870
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000542F File Offset: 0x0000362F
		public static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002368C File Offset: 0x0002188C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000236B0 File Offset: 0x000218B0
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Color32 color = new Color32(128, 128, 128, 128);
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000236F4 File Offset: 0x000218F4
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000543C File Offset: 0x0000363C
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00023730 File Offset: 0x00021930
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00023760 File Offset: 0x00021960
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow2(mesh, materialIndex, matrix);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000544D File Offset: 0x0000364D
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.DrawMeshNow(mesh, position, rotation, -1);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000545A File Offset: 0x0000365A
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			Graphics.DrawMeshNow(mesh, matrix, -1);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00023790 File Offset: 0x00021990
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000237D0 File Offset: 0x000219D0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002380C File Offset: 0x00021A0C
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00023840 File Offset: 0x00021A40
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002388C File Offset: 0x00021A8C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag5 = !material.enableInstancing;
			if (flag5)
			{
				throw new InvalidOperationException("Material needs to enable instancing for use with DrawMeshInstanced.");
			}
			bool flag6 = matrices == null;
			if (flag6)
			{
				throw new ArgumentNullException("matrices");
			}
			bool flag7 = count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length);
			if (flag7)
			{
				throw new ArgumentOutOfRangeException("count", String.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			bool flag8 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag8)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag9 = count > 0;
			if (flag9)
			{
				Graphics.Internal_DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000239CC File Offset: 0x00021BCC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = matrices == null;
			if (flag)
			{
				throw new ArgumentNullException("matrices");
			}
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00023A10 File Offset: 0x00021C10
		public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage, [Optional] LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag7 = count > 0;
			if (flag7)
			{
				Graphics.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00023AEC File Offset: 0x00021CEC
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00023BBC File Offset: 0x00021DBC
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00005466 File Offset: 0x00003666
		public static void DrawProceduralNow(MeshTopology topology, int vertexCount, [Optional] int instanceCount)
		{
			Graphics.Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00023C8C File Offset: 0x00021E8C
		public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00023CB8 File Offset: 0x00021EB8
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00023CE4 File Offset: 0x00021EE4
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00023D24 File Offset: 0x00021F24
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00023D50 File Offset: 0x00021F50
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00023D90 File Offset: 0x00021F90
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			Graphics.Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00023DB4 File Offset: 0x00021FB4
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00023DF0 File Offset: 0x00021FF0
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00023E28 File Offset: 0x00022028
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00005472 File Offset: 0x00003672
		public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3(source, dest, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000547F File Offset: 0x0000367F
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			Graphics.Blit4(source, dest, scale, offset);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000548C File Offset: 0x0000368C
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000549D File Offset: 0x0000369D
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, dest, mat, pass, true);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000054AB File Offset: 0x000036AB
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, dest, mat, pass, true, destDepthSlice);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000054BB File Offset: 0x000036BB
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			Graphics.Blit(source, dest, mat, -1);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000054C8 File Offset: 0x000036C8
		public static void Blit(Texture source, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, null, mat, pass, false);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000054D6 File Offset: 0x000036D6
		public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, null, mat, pass, false, destDepthSlice);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000054E5 File Offset: 0x000036E5
		public static void Blit(Texture source, Material mat)
		{
			Graphics.Blit(source, mat, -1);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00023E78 File Offset: 0x00022078
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap4(source, dest, mat, offsets);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000054F1 File Offset: 0x000036F1
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00023EB0 File Offset: 0x000220B0
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00005501 File Offset: 0x00003701
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00023EE8 File Offset: 0x000220E8
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00023F14 File Offset: 0x00022114
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00023F44 File Offset: 0x00022144
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00023F74 File Offset: 0x00022174
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00023FA4 File Offset: 0x000221A4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00023FDC File Offset: 0x000221DC
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00024014 File Offset: 0x00022214
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00024044 File Offset: 0x00022244
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00024078 File Offset: 0x00022278
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000240AC File Offset: 0x000222AC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000240CC File Offset: 0x000222CC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000240F0 File Offset: 0x000222F0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00024114 File Offset: 0x00022314
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00024138 File Offset: 0x00022338
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00024164 File Offset: 0x00022364
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00024190 File Offset: 0x00022390
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000241B4 File Offset: 0x000223B4
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000241DC File Offset: 0x000223DC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00024204 File Offset: 0x00022404
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00024234 File Offset: 0x00022434
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, null);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0002425C File Offset: 0x0002245C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, matrices.Length, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00024284 File Offset: 0x00022484
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000242A8 File Offset: 0x000224A8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000242CC File Offset: 0x000224CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000242F0 File Offset: 0x000224F0
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00024314 File Offset: 0x00022514
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002433C File Offset: 0x0002253C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00024364 File Offset: 0x00022564
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0002438C File Offset: 0x0002258C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000243AC File Offset: 0x000225AC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000243CC File Offset: 0x000225CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000243F0 File Offset: 0x000225F0
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00024414 File Offset: 0x00022614
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00024438 File Offset: 0x00022638
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0002445C File Offset: 0x0002265C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00024484 File Offset: 0x00022684
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000244B0 File Offset: 0x000226B0
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000244DC File Offset: 0x000226DC
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00024500 File Offset: 0x00022700
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, null, -1);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00024524 File Offset: 0x00022724
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00024548 File Offset: 0x00022748
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00005513 File Offset: 0x00003713
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00005527 File Offset: 0x00003727
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000553A File Offset: 0x0000373A
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, mat, -1);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00005547 File Offset: 0x00003747
		public static void DrawTexture(Rect screenRect, Texture texture)
		{
			Graphics.DrawTexture(screenRect, texture, null, -1);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00005554 File Offset: 0x00003754
		public static void SetRenderTarget(RenderTexture rt)
		{
			Graphics.SetRenderTarget(rt, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00005561 File Offset: 0x00003761
		public static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			Graphics.SetRenderTarget(rt, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000556E File Offset: 0x0000376E
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(rt, mipLevel, face, 0);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000557B File Offset: 0x0000377B
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00005587 File Offset: 0x00003787
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00005593 File Offset: 0x00003793
		public static void Internal_DrawMeshNow1_Injected(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref position, ref rotation);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000055A8 File Offset: 0x000037A8
		public static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref matrix);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00024568 File Offset: 0x00022768
		public static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), layer, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, IL2CPP.Il2CppObjectBaseToPtr(probeAnchor), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000245B4 File Offset: 0x000227B4
		public static void Internal_DrawMeshInstancedProcedural_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000245F8 File Offset: 0x000227F8
		public static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00024644 File Offset: 0x00022844
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00024690 File Offset: 0x00022890
		public static void Internal_DrawProcedural_Injected(Material material, ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000246C8 File Offset: 0x000228C8
		public static void Internal_DrawProceduralIndexed_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00024708 File Offset: 0x00022908
		public static void Internal_DrawProceduralIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00024744 File Offset: 0x00022944
		public static void Internal_DrawProceduralIndexedIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000055BC File Offset: 0x000037BC
		public static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset)
		{
			Graphics.Blit4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000055D6 File Offset: 0x000037D6
		public static void Blit5_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0;

		// Token: 0x04000391 RID: 913
		private static readonly Graphics.GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;

		// Token: 0x04000392 RID: 914
		private static readonly Graphics.get_activeTierDelegate get_activeTierDelegateField;

		// Token: 0x04000393 RID: 915
		private static readonly Graphics.set_activeTierDelegate set_activeTierDelegateField;

		// Token: 0x04000394 RID: 916
		private static readonly Graphics.GetPreserveFramebufferAlphaDelegate GetPreserveFramebufferAlphaDelegateField;

		// Token: 0x04000395 RID: 917
		private static readonly Graphics.GetMinOpenGLESVersionDelegate GetMinOpenGLESVersionDelegateField;

		// Token: 0x04000396 RID: 918
		private static readonly Graphics.Internal_SetNullRTDelegate Internal_SetNullRTDelegateField;

		// Token: 0x04000397 RID: 919
		private static readonly Graphics.Internal_SetRandomWriteTargetRTDelegate Internal_SetRandomWriteTargetRTDelegateField;

		// Token: 0x04000398 RID: 920
		private static readonly Graphics.Internal_SetRandomWriteTargetBufferDelegate Internal_SetRandomWriteTargetBufferDelegateField;

		// Token: 0x04000399 RID: 921
		private static readonly Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate Internal_SetRandomWriteTargetGraphicsBufferDelegateField;

		// Token: 0x0400039A RID: 922
		private static readonly Graphics.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField;

		// Token: 0x0400039B RID: 923
		private static readonly Graphics.CopyTexture_FullDelegate CopyTexture_FullDelegateField;

		// Token: 0x0400039C RID: 924
		private static readonly Graphics.CopyTexture_Slice_AllMipsDelegate CopyTexture_Slice_AllMipsDelegateField;

		// Token: 0x0400039D RID: 925
		private static readonly Graphics.CopyTexture_SliceDelegate CopyTexture_SliceDelegateField;

		// Token: 0x0400039E RID: 926
		private static readonly Graphics.CopyTexture_RegionDelegate CopyTexture_RegionDelegateField;

		// Token: 0x0400039F RID: 927
		private static readonly Graphics.ConvertTexture_FullDelegate ConvertTexture_FullDelegateField;

		// Token: 0x040003A0 RID: 928
		private static readonly Graphics.ConvertTexture_SliceDelegate ConvertTexture_SliceDelegateField;

		// Token: 0x040003A1 RID: 929
		private static readonly Graphics.Internal_DrawMeshInstancedDelegate Internal_DrawMeshInstancedDelegateField;

		// Token: 0x040003A2 RID: 930
		private static readonly Graphics.Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;

		// Token: 0x040003A3 RID: 931
		private static readonly Graphics.Internal_DrawProceduralIndexedNowDelegate Internal_DrawProceduralIndexedNowDelegateField;

		// Token: 0x040003A4 RID: 932
		private static readonly Graphics.Internal_DrawProceduralIndirectNowDelegate Internal_DrawProceduralIndirectNowDelegateField;

		// Token: 0x040003A5 RID: 933
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate Internal_DrawProceduralIndexedIndirectNowDelegateField;

		// Token: 0x040003A6 RID: 934
		private static readonly Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040003A7 RID: 935
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040003A8 RID: 936
		private static readonly Graphics.Internal_BlitMaterial5Delegate Internal_BlitMaterial5DelegateField;

		// Token: 0x040003A9 RID: 937
		private static readonly Graphics.Internal_BlitMaterial6Delegate Internal_BlitMaterial6DelegateField;

		// Token: 0x040003AA RID: 938
		private static readonly Graphics.Internal_BlitMultiTap4Delegate Internal_BlitMultiTap4DelegateField;

		// Token: 0x040003AB RID: 939
		private static readonly Graphics.Internal_BlitMultiTap5Delegate Internal_BlitMultiTap5DelegateField;

		// Token: 0x040003AC RID: 940
		private static readonly Graphics.Blit3Delegate Blit3DelegateField;

		// Token: 0x040003AD RID: 941
		private static readonly Graphics.CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;

		// Token: 0x040003AE RID: 942
		private static readonly Graphics.WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;

		// Token: 0x040003AF RID: 943
		private static readonly Graphics.ExecuteCommandBufferDelegate ExecuteCommandBufferDelegateField;

		// Token: 0x040003B0 RID: 944
		private static readonly Graphics.ExecuteCommandBufferAsyncDelegate ExecuteCommandBufferAsyncDelegateField;

		// Token: 0x040003B1 RID: 945
		private static readonly Graphics.Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;

		// Token: 0x040003B2 RID: 946
		private static readonly Graphics.Internal_DrawMeshNow2_InjectedDelegate Internal_DrawMeshNow2_InjectedDelegateField;

		// Token: 0x040003B3 RID: 947
		private static readonly Graphics.Internal_DrawMesh_InjectedDelegate Internal_DrawMesh_InjectedDelegateField;

		// Token: 0x040003B4 RID: 948
		private static readonly Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;

		// Token: 0x040003B5 RID: 949
		private static readonly Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate Internal_DrawMeshInstancedIndirect_InjectedDelegateField;

		// Token: 0x040003B6 RID: 950
		private static readonly Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040003B7 RID: 951
		private static readonly Graphics.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

		// Token: 0x040003B8 RID: 952
		private static readonly Graphics.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

		// Token: 0x040003B9 RID: 953
		private static readonly Graphics.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

		// Token: 0x040003BA RID: 954
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

		// Token: 0x040003BB RID: 955
		private static readonly Graphics.Blit4_InjectedDelegate Blit4_InjectedDelegateField;

		// Token: 0x040003BC RID: 956
		private static readonly Graphics.Blit5_InjectedDelegate Blit5_InjectedDelegateField;

		// Token: 0x02000469 RID: 1129
		// (Invoke) Token: 0x060026A1 RID: 9889
		private delegate ColorGamut GetActiveColorGamutDelegate();

		// Token: 0x0200046A RID: 1130
		// (Invoke) Token: 0x060026A3 RID: 9891
		private delegate UnityEngine.Rendering.GraphicsTier get_activeTierDelegate();

		// Token: 0x0200046B RID: 1131
		// (Invoke) Token: 0x060026A5 RID: 9893
		private delegate void set_activeTierDelegate(UnityEngine.Rendering.GraphicsTier value);

		// Token: 0x0200046C RID: 1132
		// (Invoke) Token: 0x060026A7 RID: 9895
		private delegate bool GetPreserveFramebufferAlphaDelegate();

		// Token: 0x0200046D RID: 1133
		// (Invoke) Token: 0x060026A9 RID: 9897
		private delegate UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersionDelegate();

		// Token: 0x0200046E RID: 1134
		// (Invoke) Token: 0x060026AB RID: 9899
		private delegate void Internal_SetNullRTDelegate();

		// Token: 0x0200046F RID: 1135
		// (Invoke) Token: 0x060026AD RID: 9901
		private delegate void Internal_SetRandomWriteTargetRTDelegate(int index, IntPtr uav);

		// Token: 0x02000470 RID: 1136
		// (Invoke) Token: 0x060026AF RID: 9903
		private delegate void Internal_SetRandomWriteTargetBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x060026B1 RID: 9905
		private delegate void Internal_SetRandomWriteTargetGraphicsBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x02000472 RID: 1138
		// (Invoke) Token: 0x060026B3 RID: 9907
		private delegate void ClearRandomWriteTargetsDelegate();

		// Token: 0x02000473 RID: 1139
		// (Invoke) Token: 0x060026B5 RID: 9909
		private delegate void CopyTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x060026B7 RID: 9911
		private delegate void CopyTexture_Slice_AllMipsDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000475 RID: 1141
		// (Invoke) Token: 0x060026B9 RID: 9913
		private delegate void CopyTexture_SliceDelegate(IntPtr src, int srcElement, int srcMip, IntPtr dst, int dstElement, int dstMip);

		// Token: 0x02000476 RID: 1142
		// (Invoke) Token: 0x060026BB RID: 9915
		private delegate void CopyTexture_RegionDelegate(IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY);

		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x060026BD RID: 9917
		private delegate bool ConvertTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x060026BF RID: 9919
		private delegate bool ConvertTexture_SliceDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000479 RID: 1145
		// (Invoke) Token: 0x060026C1 RID: 9921
		private delegate void Internal_DrawMeshInstancedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr matrices, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x060026C3 RID: 9923
		private delegate void Internal_DrawProceduralNowDelegate(MeshTopology topology, int vertexCount, int instanceCount);

		// Token: 0x0200047B RID: 1147
		// (Invoke) Token: 0x060026C5 RID: 9925
		private delegate void Internal_DrawProceduralIndexedNowDelegate(MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount);

		// Token: 0x0200047C RID: 1148
		// (Invoke) Token: 0x060026C7 RID: 9927
		private delegate void Internal_DrawProceduralIndirectNowDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x0200047D RID: 1149
		// (Invoke) Token: 0x060026C9 RID: 9929
		private delegate void Internal_DrawProceduralIndexedIndirectNowDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x060026CB RID: 9931
		private delegate void Internal_DrawProceduralIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x060026CD RID: 9933
		private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x060026CF RID: 9935
		private delegate void Internal_BlitMaterial5Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT);

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x060026D1 RID: 9937
		private delegate void Internal_BlitMaterial6Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT, int destDepthSlice);

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x060026D3 RID: 9939
		private delegate void Internal_BlitMultiTap4Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets);

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x060026D5 RID: 9941
		private delegate void Internal_BlitMultiTap5Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets, int destDepthSlice);

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x060026D7 RID: 9943
		private delegate void Blit3Delegate(IntPtr source, IntPtr dest, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x02000485 RID: 1157
		// (Invoke) Token: 0x060026D9 RID: 9945
		private delegate IntPtr CreateGPUFenceImplDelegate(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x02000486 RID: 1158
		// (Invoke) Token: 0x060026DB RID: 9947
		private delegate void WaitOnGPUFenceImplDelegate(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x02000487 RID: 1159
		// (Invoke) Token: 0x060026DD RID: 9949
		private delegate void ExecuteCommandBufferDelegate(IntPtr buffer);

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x060026DF RID: 9951
		private delegate void ExecuteCommandBufferAsyncDelegate(IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x02000489 RID: 1161
		// (Invoke) Token: 0x060026E1 RID: 9953
		private delegate void Internal_DrawMeshNow1_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr position, IntPtr rotation);

		// Token: 0x0200048A RID: 1162
		// (Invoke) Token: 0x060026E3 RID: 9955
		private delegate void Internal_DrawMeshNow2_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr matrix);

		// Token: 0x0200048B RID: 1163
		// (Invoke) Token: 0x060026E5 RID: 9957
		private delegate void Internal_DrawMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr matrix, IntPtr material, int layer, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, IntPtr probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x060026E7 RID: 9959
		private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200048D RID: 1165
		// (Invoke) Token: 0x060026E9 RID: 9961
		private delegate void Internal_DrawMeshInstancedIndirect_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200048E RID: 1166
		// (Invoke) Token: 0x060026EB RID: 9963
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200048F RID: 1167
		// (Invoke) Token: 0x060026ED RID: 9965
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, int vertexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x02000490 RID: 1168
		// (Invoke) Token: 0x060026EF RID: 9967
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x02000491 RID: 1169
		// (Invoke) Token: 0x060026F1 RID: 9969
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x02000492 RID: 1170
		// (Invoke) Token: 0x060026F3 RID: 9971
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x02000493 RID: 1171
		// (Invoke) Token: 0x060026F5 RID: 9973
		private delegate void Blit4_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset);

		// Token: 0x02000494 RID: 1172
		// (Invoke) Token: 0x060026F7 RID: 9975
		private delegate void Blit5_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);
	}
}
