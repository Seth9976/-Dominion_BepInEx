using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000142 RID: 322
	public class RenderPipelineAsset : ScriptableObject
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x00059E3C File Offset: 0x0005803C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineAsset()
		{
			Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr);
			RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665108);
			RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665109);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665110);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665111);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665112);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665113);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665114);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665115);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665116);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665117);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665118);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665119);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665120);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665121);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665122);
			RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665123);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665124);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665125);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665126);
			RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665127);
			RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665128);
			RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665129);
			RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100665130);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0005A038 File Offset: 0x00058238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82308, RefRangeEnd = 82309, XrefRangeStart = 82290, XrefRangeEnd = 82308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipeline InternalCreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x0005A078 File Offset: 0x00058278
		public unsafe virtual Il2CppStringArray renderingLayerMaskNames
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0005A0C4 File Offset: 0x000582C4
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0005A110 File Offset: 0x00058310
		public unsafe virtual Shader autodeskInteractiveShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0005A15C File Offset: 0x0005835C
		public unsafe virtual Shader autodeskInteractiveTransparentShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0005A1A8 File Offset: 0x000583A8
		public unsafe virtual Shader autodeskInteractiveMaskedShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0005A1F4 File Offset: 0x000583F4
		public unsafe virtual Shader terrainDetailLitShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0005A240 File Offset: 0x00058440
		public unsafe virtual Shader terrainDetailGrassShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0005A28C File Offset: 0x0005848C
		public unsafe virtual Shader terrainDetailGrassBillboardShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0005A2D8 File Offset: 0x000584D8
		public unsafe virtual Material defaultParticleMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0005A324 File Offset: 0x00058524
		public unsafe virtual Material defaultLineMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0005A370 File Offset: 0x00058570
		public unsafe virtual Material defaultTerrainMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0005A3BC File Offset: 0x000585BC
		public unsafe virtual Material defaultUIMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0005A408 File Offset: 0x00058608
		public unsafe virtual Material defaultUIOverdrawMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0005A454 File Offset: 0x00058654
		public unsafe virtual Material defaultUIETC1SupportedMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0005A4A0 File Offset: 0x000586A0
		public unsafe virtual Material default2DMaterial
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x0005A4EC File Offset: 0x000586EC
		public unsafe virtual Shader defaultShader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0005A538 File Offset: 0x00058738
		public unsafe virtual Shader defaultSpeedTree7Shader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x0005A584 File Offset: 0x00058784
		public unsafe virtual Shader defaultSpeedTree8Shader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0005A5D0 File Offset: 0x000587D0
		[CallerCount(0)]
		public unsafe virtual RenderPipeline CreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0005A61C File Offset: 0x0005881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82309, XrefRangeEnd = 82321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0005A658 File Offset: 0x00058858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82321, XrefRangeEnd = 82325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0005A694 File Offset: 0x00058894
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 72365, RefRangeEnd = 72387, XrefRangeStart = 72365, XrefRangeEnd = 72387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0000D8CE File Offset: 0x0000BACE
		public RenderPipelineAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
