using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000056 RID: 86
	public class Material : Object
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x000270E0 File Offset: 0x000252E0
		// Note: this type is marked as 'beforefieldinit'.
		static Material()
		{
			Il2CppClassPointerStore<Material>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Material");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Material>.NativeClassPtr);
			Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663645);
			Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663646);
			Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663647);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663648);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663649);
			Material.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663650);
			Material.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663651);
			Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663652);
			Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663653);
			Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663654);
			Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663655);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663656);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663657);
			Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663658);
			Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663659);
			Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663660);
			Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663661);
			Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663662);
			Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663663);
			Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663664);
			Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663665);
			Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663666);
			Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663667);
			Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663668);
			Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663669);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663670);
			Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663671);
			Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663672);
			Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663673);
			Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663674);
			Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663675);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663676);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663677);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663678);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663679);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663680);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663681);
			Material.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663682);
			Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663683);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663684);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663685);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663686);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663687);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663688);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663689);
			Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663690);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663691);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663692);
			Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663693);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663694);
			Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663695);
			Material.GetDefaultMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultMaterialDelegate>("UnityEngine.Material::GetDefaultMaterial");
			Material.GetDefaultParticleMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultParticleMaterialDelegate>("UnityEngine.Material::GetDefaultParticleMaterial");
			Material.GetDefaultLineMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultLineMaterialDelegate>("UnityEngine.Material::GetDefaultLineMaterial");
			Material.get_shaderDelegateField = IL2CPP.ResolveICall<Material.get_shaderDelegate>("UnityEngine.Material::get_shader");
			Material.set_shaderDelegateField = IL2CPP.ResolveICall<Material.set_shaderDelegate>("UnityEngine.Material::set_shader");
			Material.HasFloatImplDelegateField = IL2CPP.ResolveICall<Material.HasFloatImplDelegate>("UnityEngine.Material::HasFloatImpl");
			Material.HasIntImplDelegateField = IL2CPP.ResolveICall<Material.HasIntImplDelegate>("UnityEngine.Material::HasIntImpl");
			Material.HasTextureImplDelegateField = IL2CPP.ResolveICall<Material.HasTextureImplDelegate>("UnityEngine.Material::HasTextureImpl");
			Material.HasMatrixImplDelegateField = IL2CPP.ResolveICall<Material.HasMatrixImplDelegate>("UnityEngine.Material::HasMatrixImpl");
			Material.HasVectorImplDelegateField = IL2CPP.ResolveICall<Material.HasVectorImplDelegate>("UnityEngine.Material::HasVectorImpl");
			Material.HasBufferImplDelegateField = IL2CPP.ResolveICall<Material.HasBufferImplDelegate>("UnityEngine.Material::HasBufferImpl");
			Material.HasConstantBufferImplDelegateField = IL2CPP.ResolveICall<Material.HasConstantBufferImplDelegate>("UnityEngine.Material::HasConstantBufferImpl");
			Material.get_renderQueueDelegateField = IL2CPP.ResolveICall<Material.get_renderQueueDelegate>("UnityEngine.Material::get_renderQueue");
			Material.get_rawRenderQueueDelegateField = IL2CPP.ResolveICall<Material.get_rawRenderQueueDelegate>("UnityEngine.Material::get_rawRenderQueue");
			Material.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<Material.IsKeywordEnabledDelegate>("UnityEngine.Material::IsKeywordEnabled");
			Material.get_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.get_globalIlluminationFlagsDelegate>("UnityEngine.Material::get_globalIlluminationFlags");
			Material.set_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.set_globalIlluminationFlagsDelegate>("UnityEngine.Material::set_globalIlluminationFlags");
			Material.get_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.get_doubleSidedGIDelegate>("UnityEngine.Material::get_doubleSidedGI");
			Material.set_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.set_doubleSidedGIDelegate>("UnityEngine.Material::set_doubleSidedGI");
			Material.get_enableInstancingDelegateField = IL2CPP.ResolveICall<Material.get_enableInstancingDelegate>("UnityEngine.Material::get_enableInstancing");
			Material.set_enableInstancingDelegateField = IL2CPP.ResolveICall<Material.set_enableInstancingDelegate>("UnityEngine.Material::set_enableInstancing");
			Material.SetShaderPassEnabledDelegateField = IL2CPP.ResolveICall<Material.SetShaderPassEnabledDelegate>("UnityEngine.Material::SetShaderPassEnabled");
			Material.GetShaderPassEnabledDelegateField = IL2CPP.ResolveICall<Material.GetShaderPassEnabledDelegate>("UnityEngine.Material::GetShaderPassEnabled");
			Material.GetPassNameDelegateField = IL2CPP.ResolveICall<Material.GetPassNameDelegate>("UnityEngine.Material::GetPassName");
			Material.FindPassDelegateField = IL2CPP.ResolveICall<Material.FindPassDelegate>("UnityEngine.Material::FindPass");
			Material.SetOverrideTagDelegateField = IL2CPP.ResolveICall<Material.SetOverrideTagDelegate>("UnityEngine.Material::SetOverrideTag");
			Material.GetTagImplDelegateField = IL2CPP.ResolveICall<Material.GetTagImplDelegate>("UnityEngine.Material::GetTagImpl");
			Material.LerpDelegateField = IL2CPP.ResolveICall<Material.LerpDelegate>("UnityEngine.Material::Lerp");
			Material.SetPassDelegateField = IL2CPP.ResolveICall<Material.SetPassDelegate>("UnityEngine.Material::SetPass");
			Material.GetTexturePropertyNamesDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesDelegate>("UnityEngine.Material::GetTexturePropertyNames");
			Material.GetTexturePropertyNameIDsDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsDelegate>("UnityEngine.Material::GetTexturePropertyNameIDs");
			Material.GetTexturePropertyNamesInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesInternalDelegate>("UnityEngine.Material::GetTexturePropertyNamesInternal");
			Material.GetTexturePropertyNameIDsInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsInternalDelegate>("UnityEngine.Material::GetTexturePropertyNameIDsInternal");
			Material.SetIntImplDelegateField = IL2CPP.ResolveICall<Material.SetIntImplDelegate>("UnityEngine.Material::SetIntImpl");
			Material.SetRenderTextureImplDelegateField = IL2CPP.ResolveICall<Material.SetRenderTextureImplDelegate>("UnityEngine.Material::SetRenderTextureImpl");
			Material.SetBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetBufferImplDelegate>("UnityEngine.Material::SetBufferImpl");
			Material.SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetGraphicsBufferImplDelegate>("UnityEngine.Material::SetGraphicsBufferImpl");
			Material.SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetConstantBufferImplDelegate>("UnityEngine.Material::SetConstantBufferImpl");
			Material.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetConstantGraphicsBufferImplDelegate>("UnityEngine.Material::SetConstantGraphicsBufferImpl");
			Material.GetIntImplDelegateField = IL2CPP.ResolveICall<Material.GetIntImplDelegate>("UnityEngine.Material::GetIntImpl");
			Material.SetFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetFloatArrayImplDelegate>("UnityEngine.Material::SetFloatArrayImpl");
			Material.SetVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetVectorArrayImplDelegate>("UnityEngine.Material::SetVectorArrayImpl");
			Material.SetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetColorArrayImplDelegate>("UnityEngine.Material::SetColorArrayImpl");
			Material.SetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetMatrixArrayImplDelegate>("UnityEngine.Material::SetMatrixArrayImpl");
			Material.GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetFloatArrayImplDelegate>("UnityEngine.Material::GetFloatArrayImpl");
			Material.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayImplDelegate>("UnityEngine.Material::GetVectorArrayImpl");
			Material.GetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayImplDelegate>("UnityEngine.Material::GetColorArrayImpl");
			Material.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayImplDelegate>("UnityEngine.Material::GetMatrixArrayImpl");
			Material.GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetFloatArrayCountImplDelegate>("UnityEngine.Material::GetFloatArrayCountImpl");
			Material.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayCountImplDelegate>("UnityEngine.Material::GetVectorArrayCountImpl");
			Material.GetColorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayCountImplDelegate>("UnityEngine.Material::GetColorArrayCountImpl");
			Material.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayCountImplDelegate>("UnityEngine.Material::GetMatrixArrayCountImpl");
			Material.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractFloatArrayImplDelegate>("UnityEngine.Material::ExtractFloatArrayImpl");
			Material.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractVectorArrayImplDelegate>("UnityEngine.Material::ExtractVectorArrayImpl");
			Material.ExtractColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractColorArrayImplDelegate>("UnityEngine.Material::ExtractColorArrayImpl");
			Material.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractMatrixArrayImplDelegate>("UnityEngine.Material::ExtractMatrixArrayImpl");
			Material.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.GetMatrixImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixImpl_Injected");
			Material.GetTextureScaleAndOffsetImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.GetTextureScaleAndOffsetImpl_InjectedDelegate>("UnityEngine.Material::GetTextureScaleAndOffsetImpl_Injected");
			Material.SetTextureOffsetImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.SetTextureOffsetImpl_InjectedDelegate>("UnityEngine.Material::SetTextureOffsetImpl_Injected");
			Material.SetTextureScaleImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.SetTextureScaleImpl_InjectedDelegate>("UnityEngine.Material::SetTextureScaleImpl_Injected");
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00027890 File Offset: 0x00025A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63009, XrefRangeEnd = 63011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithShader(Material self, Shader shader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000278D8 File Offset: 0x00025AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63011, XrefRangeEnd = 63013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithMaterial(Material self, Material source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00027920 File Offset: 0x00025B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63013, XrefRangeEnd = 63015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithString(Material self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00027958 File Offset: 0x00025B58
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 63021, RefRangeEnd = 63033, XrefRangeStart = 63015, XrefRangeEnd = 63021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Shader shader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000279A4 File Offset: 0x00025BA4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 63039, RefRangeEnd = 63056, XrefRangeStart = 63033, XrefRangeEnd = 63039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Material source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000279F0 File Offset: 0x00025BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63056, XrefRangeEnd = 63062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00027A3C File Offset: 0x00025C3C
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00027A78 File Offset: 0x00025C78
		public unsafe Color color
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 63069, RefRangeEnd = 63075, XrefRangeStart = 63062, XrefRangeEnd = 63069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 63082, RefRangeEnd = 63086, XrefRangeStart = 63075, XrefRangeEnd = 63082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00027AB8 File Offset: 0x00025CB8
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00027AF8 File Offset: 0x00025CF8
		public unsafe Texture mainTexture
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 63093, RefRangeEnd = 63102, XrefRangeStart = 63086, XrefRangeEnd = 63093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 63109, RefRangeEnd = 63124, XrefRangeStart = 63102, XrefRangeEnd = 63109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00027B3C File Offset: 0x00025D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63124, XrefRangeEnd = 63126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeFlag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00027B88 File Offset: 0x00025D88
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 63128, RefRangeEnd = 63170, XrefRangeStart = 63126, XrefRangeEnd = 63128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00027BD4 File Offset: 0x00025DD4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 63173, RefRangeEnd = 63184, XrefRangeStart = 63170, XrefRangeEnd = 63173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0000689B File Offset: 0x00004A9B
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00027C24 File Offset: 0x00025E24
		public unsafe int renderQueue
		{
			get
			{
				return Material.get_renderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63196, RefRangeEnd = 63197, XrefRangeStart = 63184, XrefRangeEnd = 63196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00027C64 File Offset: 0x00025E64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63199, RefRangeEnd = 63203, XrefRangeStart = 63197, XrefRangeEnd = 63199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00027CA8 File Offset: 0x00025EA8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 63205, RefRangeEnd = 63215, XrefRangeStart = 63203, XrefRangeEnd = 63205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00027CEC File Offset: 0x00025EEC
		public unsafe int passCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63217, RefRangeEnd = 63218, XrefRangeStart = 63215, XrefRangeEnd = 63217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00027D28 File Offset: 0x00025F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63220, RefRangeEnd = 63221, XrefRangeStart = 63218, XrefRangeEnd = 63220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPropertiesFromMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00027D6C File Offset: 0x00025F6C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 63223, RefRangeEnd = 63238, XrefRangeStart = 63221, XrefRangeEnd = 63223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetShaderKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00027DAC File Offset: 0x00025FAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 63240, RefRangeEnd = 63249, XrefRangeStart = 63238, XrefRangeEnd = 63240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderKeywords(Il2CppStringArray names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00027DF0 File Offset: 0x00025FF0
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00027E30 File Offset: 0x00026030
		public unsafe Il2CppStringArray shaderKeywords
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 63223, RefRangeEnd = 63238, XrefRangeStart = 63223, XrefRangeEnd = 63238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 63240, RefRangeEnd = 63249, XrefRangeStart = 63240, XrefRangeEnd = 63249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00027E74 File Offset: 0x00026074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63251, RefRangeEnd = 63253, XrefRangeStart = 63249, XrefRangeEnd = 63251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeCRC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00027EB0 File Offset: 0x000260B0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 63255, RefRangeEnd = 63289, XrefRangeStart = 63253, XrefRangeEnd = 63255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatImpl(int name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00027EFC File Offset: 0x000260FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63289, XrefRangeEnd = 63291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl(int name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00027F48 File Offset: 0x00026148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63291, XrefRangeEnd = 63293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00027F94 File Offset: 0x00026194
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 63295, RefRangeEnd = 63301, XrefRangeStart = 63293, XrefRangeEnd = 63295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureImpl(int name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00027FE4 File Offset: 0x000261E4
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 63303, RefRangeEnd = 63363, XrefRangeStart = 63301, XrefRangeEnd = 63303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloatImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00028030 File Offset: 0x00026230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63363, XrefRangeEnd = 63365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColorImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002807C File Offset: 0x0002627C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 63367, RefRangeEnd = 63386, XrefRangeStart = 63365, XrefRangeEnd = 63367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTextureImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000280C8 File Offset: 0x000262C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63389, RefRangeEnd = 63391, XrefRangeStart = 63386, XrefRangeEnd = 63389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00028118 File Offset: 0x00026318
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 63394, RefRangeEnd = 63412, XrefRangeStart = 63391, XrefRangeEnd = 63394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00028168 File Offset: 0x00026368
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 63255, RefRangeEnd = 63289, XrefRangeStart = 63255, XrefRangeEnd = 63289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000281B4 File Offset: 0x000263B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63415, RefRangeEnd = 63417, XrefRangeStart = 63412, XrefRangeEnd = 63415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(string name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00028204 File Offset: 0x00026404
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63419, RefRangeEnd = 63423, XrefRangeStart = 63417, XrefRangeEnd = 63419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00028250 File Offset: 0x00026450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63426, RefRangeEnd = 63429, XrefRangeStart = 63423, XrefRangeEnd = 63426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000282A0 File Offset: 0x000264A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 63431, RefRangeEnd = 63437, XrefRangeStart = 63429, XrefRangeEnd = 63431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000282EC File Offset: 0x000264EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63440, RefRangeEnd = 63441, XrefRangeStart = 63437, XrefRangeEnd = 63440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(string name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002833C File Offset: 0x0002653C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63443, RefRangeEnd = 63445, XrefRangeStart = 63441, XrefRangeEnd = 63443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00028388 File Offset: 0x00026588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63448, RefRangeEnd = 63449, XrefRangeStart = 63445, XrefRangeEnd = 63448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(string name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000283DC File Offset: 0x000265DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 63295, RefRangeEnd = 63301, XrefRangeStart = 63295, XrefRangeEnd = 63301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002842C File Offset: 0x0002662C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63452, RefRangeEnd = 63454, XrefRangeStart = 63449, XrefRangeEnd = 63452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002847C File Offset: 0x0002667C
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 63303, RefRangeEnd = 63363, XrefRangeStart = 63303, XrefRangeEnd = 63363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000284C8 File Offset: 0x000266C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63457, RefRangeEnd = 63461, XrefRangeStart = 63454, XrefRangeEnd = 63457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00028518 File Offset: 0x00026718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63463, RefRangeEnd = 63465, XrefRangeStart = 63461, XrefRangeEnd = 63463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00028564 File Offset: 0x00026764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63468, RefRangeEnd = 63470, XrefRangeStart = 63465, XrefRangeEnd = 63468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetVector(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000285B0 File Offset: 0x000267B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63470, XrefRangeEnd = 63473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00028600 File Offset: 0x00026800
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 63367, RefRangeEnd = 63386, XrefRangeStart = 63367, XrefRangeEnd = 63386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002864C File Offset: 0x0002684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63473, XrefRangeEnd = 63475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl_Injected(int name, ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00028698 File Offset: 0x00026898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63475, XrefRangeEnd = 63477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000286E4 File Offset: 0x000268E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63477, XrefRangeEnd = 63479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorImpl_Injected(int name, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000067F5 File Offset: 0x000049F5
		public Material(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00028730 File Offset: 0x00026930
		public static Material Create(string scriptContents)
		{
			return new Material(scriptContents);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00028748 File Offset: 0x00026948
		public static Material GetDefaultMaterial()
		{
			IntPtr intPtr = Material.GetDefaultMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00028770 File Offset: 0x00026970
		public static Material GetDefaultParticleMaterial()
		{
			IntPtr intPtr = Material.GetDefaultParticleMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00028798 File Offset: 0x00026998
		public static Material GetDefaultLineMaterial()
		{
			IntPtr intPtr = Material.GetDefaultLineMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000287C0 File Offset: 0x000269C0
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x000067FE File Offset: 0x000049FE
		public Shader shader
		{
			get
			{
				IntPtr intPtr = Material.get_shaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				Material.set_shaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000287EC File Offset: 0x000269EC
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0002882C File Offset: 0x00026A2C
		public Vector2 mainTextureOffset
		{
			get
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				Vector2 vector;
				if (flag)
				{
					vector = this.GetTextureOffset(firstPropertyNameIdByAttribute);
				}
				else
				{
					vector = this.GetTextureOffset("_MainTex");
				}
				return vector;
			}
			set
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				if (flag)
				{
					this.SetTextureOffset(firstPropertyNameIdByAttribute, value);
				}
				else
				{
					this.SetTextureOffset("_MainTex", value);
				}
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0002886C File Offset: 0x00026A6C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x000288AC File Offset: 0x00026AAC
		public Vector2 mainTextureScale
		{
			get
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				Vector2 vector;
				if (flag)
				{
					vector = this.GetTextureScale(firstPropertyNameIdByAttribute);
				}
				else
				{
					vector = this.GetTextureScale("_MainTex");
				}
				return vector;
			}
			set
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				if (flag)
				{
					this.SetTextureScale(firstPropertyNameIdByAttribute, value);
				}
				else
				{
					this.SetTextureScale("_MainTex", value);
				}
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00006816 File Offset: 0x00004A16
		public bool HasFloatImpl(int name)
		{
			return Material.HasFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000288EC File Offset: 0x00026AEC
		public bool HasFloat(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0002890C File Offset: 0x00026B0C
		public bool HasFloat(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00028928 File Offset: 0x00026B28
		public bool HasInt(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00028948 File Offset: 0x00026B48
		public bool HasInt(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00006829 File Offset: 0x00004A29
		public bool HasIntImpl(int name)
		{
			return Material.HasIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00028964 File Offset: 0x00026B64
		public bool HasInteger(string name)
		{
			return this.HasIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00028984 File Offset: 0x00026B84
		public bool HasInteger(int nameID)
		{
			return this.HasIntImpl(nameID);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000683C File Offset: 0x00004A3C
		public bool HasTextureImpl(int name)
		{
			return Material.HasTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000289A0 File Offset: 0x00026BA0
		public bool HasTexture(string name)
		{
			return this.HasTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000289C0 File Offset: 0x00026BC0
		public bool HasTexture(int nameID)
		{
			return this.HasTextureImpl(nameID);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0000684F File Offset: 0x00004A4F
		public bool HasMatrixImpl(int name)
		{
			return Material.HasMatrixImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000289DC File Offset: 0x00026BDC
		public bool HasMatrix(string name)
		{
			return this.HasMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000289FC File Offset: 0x00026BFC
		public bool HasMatrix(int nameID)
		{
			return this.HasMatrixImpl(nameID);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00006862 File Offset: 0x00004A62
		public bool HasVectorImpl(int name)
		{
			return Material.HasVectorImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00028A18 File Offset: 0x00026C18
		public bool HasVector(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00028A38 File Offset: 0x00026C38
		public bool HasVector(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00028A54 File Offset: 0x00026C54
		public bool HasColor(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00028A74 File Offset: 0x00026C74
		public bool HasColor(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00006875 File Offset: 0x00004A75
		public bool HasBufferImpl(int name)
		{
			return Material.HasBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00028A90 File Offset: 0x00026C90
		public bool HasBuffer(string name)
		{
			return this.HasBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00028AB0 File Offset: 0x00026CB0
		public bool HasBuffer(int nameID)
		{
			return this.HasBufferImpl(nameID);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00006888 File Offset: 0x00004A88
		public bool HasConstantBufferImpl(int name)
		{
			return Material.HasConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00028ACC File Offset: 0x00026CCC
		public bool HasConstantBuffer(string name)
		{
			return this.HasConstantBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00028AEC File Offset: 0x00026CEC
		public bool HasConstantBuffer(int nameID)
		{
			return this.HasConstantBufferImpl(nameID);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000068AD File Offset: 0x00004AAD
		public int rawRenderQueue
		{
			get
			{
				return Material.get_rawRenderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000068BF File Offset: 0x00004ABF
		public bool IsKeywordEnabled(string keyword)
		{
			return Material.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000068D7 File Offset: 0x00004AD7
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000068E9 File Offset: 0x00004AE9
		public MaterialGlobalIlluminationFlags globalIlluminationFlags
		{
			get
			{
				return Material.get_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000068FC File Offset: 0x00004AFC
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x0000690E File Offset: 0x00004B0E
		public bool doubleSidedGI
		{
			get
			{
				return Material.get_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00006921 File Offset: 0x00004B21
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00006933 File Offset: 0x00004B33
		public bool enableInstancing
		{
			get
			{
				return Material.get_enableInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_enableInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00006946 File Offset: 0x00004B46
		public void SetShaderPassEnabled(string passName, bool enabled)
		{
			Material.SetShaderPassEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName), enabled);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0000695F File Offset: 0x00004B5F
		public bool GetShaderPassEnabled(string passName)
		{
			return Material.GetShaderPassEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00028B08 File Offset: 0x00026D08
		public string GetPassName(int pass)
		{
			IntPtr intPtr = Material.GetPassNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), pass);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00006977 File Offset: 0x00004B77
		public int FindPass(string passName)
		{
			return Material.FindPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0000698F File Offset: 0x00004B8F
		public void SetOverrideTag(string tag, string val)
		{
			Material.SetOverrideTagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag), IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00028B30 File Offset: 0x00026D30
		public string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
		{
			IntPtr intPtr = Material.GetTagImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag), currentSubShaderOnly, IL2CPP.ManagedStringToIl2Cpp(defaultValue));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00028B64 File Offset: 0x00026D64
		public string GetTag(string tag, bool searchFallbacks, string defaultValue)
		{
			return this.GetTagImpl(tag, !searchFallbacks, defaultValue);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00028B84 File Offset: 0x00026D84
		public string GetTag(string tag, bool searchFallbacks)
		{
			return this.GetTagImpl(tag, !searchFallbacks, "");
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000069AD File Offset: 0x00004BAD
		public void Lerp(Material start, Material end, float t)
		{
			Material.LerpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(start), IL2CPP.Il2CppObjectBaseToPtr(end), t);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000069CC File Offset: 0x00004BCC
		public bool SetPass(int pass)
		{
			return Material.SetPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), pass);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00028BA8 File Offset: 0x00026DA8
		public Il2CppStringArray GetTexturePropertyNames()
		{
			IntPtr intPtr = Material.GetTexturePropertyNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00028BD4 File Offset: 0x00026DD4
		public Il2CppStructArray<int> GetTexturePropertyNameIDs()
		{
			IntPtr intPtr = Material.GetTexturePropertyNameIDsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000069DF File Offset: 0x00004BDF
		public void GetTexturePropertyNamesInternal(Object outNames)
		{
			Material.GetTexturePropertyNamesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000069F7 File Offset: 0x00004BF7
		public void GetTexturePropertyNameIDsInternal(Object outNames)
		{
			Material.GetTexturePropertyNameIDsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00028C00 File Offset: 0x00026E00
		public void GetTexturePropertyNames(List<string> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNamesInternal(outNames);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00028C2C File Offset: 0x00026E2C
		public void GetTexturePropertyNameIDs(List<int> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNameIDsInternal(outNames);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00006A0F File Offset: 0x00004C0F
		public void SetIntImpl(int name, int value)
		{
			Material.SetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, value);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00006A23 File Offset: 0x00004C23
		public void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Material.SetRenderTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00006A3D File Offset: 0x00004C3D
		public void SetBufferImpl(int name, ComputeBuffer value)
		{
			Material.SetBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00006A56 File Offset: 0x00004C56
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			Material.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00006A6F File Offset: 0x00004C6F
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			Material.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00006A8B File Offset: 0x00004C8B
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Material.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00006AA7 File Offset: 0x00004CA7
		public int GetIntImpl(int name)
		{
			return Material.GetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00028C58 File Offset: 0x00026E58
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			this.GetMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00006ABA File Offset: 0x00004CBA
		public void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			Material.SetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			Material.SetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00006AEE File Offset: 0x00004CEE
		public void SetColorArrayImpl(int name, Il2CppStructArray<Color> values, int count)
		{
			Material.SetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00006B08 File Offset: 0x00004D08
		public void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			Material.SetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00028C70 File Offset: 0x00026E70
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00028CA0 File Offset: 0x00026EA0
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00028CD0 File Offset: 0x00026ED0
		public Il2CppStructArray<Color> GetColorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00028D00 File Offset: 0x00026F00
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00006B22 File Offset: 0x00004D22
		public int GetFloatArrayCountImpl(int name)
		{
			return Material.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00006B35 File Offset: 0x00004D35
		public int GetVectorArrayCountImpl(int name)
		{
			return Material.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00006B48 File Offset: 0x00004D48
		public int GetColorArrayCountImpl(int name)
		{
			return Material.GetColorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00006B5B File Offset: 0x00004D5B
		public int GetMatrixArrayCountImpl(int name)
		{
			return Material.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00006B6E File Offset: 0x00004D6E
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Material.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00006B87 File Offset: 0x00004D87
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Material.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public void ExtractColorArrayImpl(int name, [Out] Il2CppStructArray<Color> val)
		{
			Material.ExtractColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00006BB9 File Offset: 0x00004DB9
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Material.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00028D30 File Offset: 0x00026F30
		public Vector4 GetTextureScaleAndOffsetImpl(int name)
		{
			Vector4 vector;
			this.GetTextureScaleAndOffsetImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00006BD2 File Offset: 0x00004DD2
		public void SetTextureOffsetImpl(int name, Vector2 offset)
		{
			this.SetTextureOffsetImpl_Injected(name, ref offset);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00006BDD File Offset: 0x00004DDD
		public void SetTextureScaleImpl(int name, Vector2 scale)
		{
			this.SetTextureScaleImpl_Injected(name, ref scale);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00028D48 File Offset: 0x00026F48
		public void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetFloatArrayImpl(name, values, count);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00028DA4 File Offset: 0x00026FA4
		public void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetVectorArrayImpl(name, values, count);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00028E00 File Offset: 0x00027000
		public void SetColorArray(int name, Il2CppStructArray<Color> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetColorArrayImpl(name, values, count);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00028E5C File Offset: 0x0002705C
		public void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetMatrixArrayImpl(name, values, count);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00028EB8 File Offset: 0x000270B8
		public void ExtractFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
			bool flag2 = floatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
				this.ExtractFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00028F10 File Offset: 0x00027110
		public void ExtractVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
			bool flag2 = vectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
				this.ExtractVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00028F68 File Offset: 0x00027168
		public void ExtractColorArray(int name, List<Color> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int colorArrayCountImpl = this.GetColorArrayCountImpl(name);
			bool flag2 = colorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Color>(values, colorArrayCountImpl);
				this.ExtractColorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Color>>());
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00028FC0 File Offset: 0x000271C0
		public void ExtractMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
			bool flag2 = matrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
				this.ExtractMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public void SetInt(int nameID, int value)
		{
			this.SetFloatImpl(nameID, (float)value);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00006BF5 File Offset: 0x00004DF5
		public void SetInteger(string name, int value)
		{
			this.SetIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00006C06 File Offset: 0x00004E06
		public void SetInteger(int nameID, int value)
		{
			this.SetIntImpl(nameID, value);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00006C12 File Offset: 0x00004E12
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00006C24 File Offset: 0x00004E24
		public void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00006C31 File Offset: 0x00004E31
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00006C42 File Offset: 0x00004E42
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00006C4E File Offset: 0x00004E4E
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00006C5F File Offset: 0x00004E5F
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00006C6B File Offset: 0x00004E6B
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00006C7F File Offset: 0x00004E7F
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00006C8E File Offset: 0x00004E8E
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00006CA2 File Offset: 0x00004EA2
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00006CB1 File Offset: 0x00004EB1
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00006CCD File Offset: 0x00004ECD
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00006CFC File Offset: 0x00004EFC
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00006D0F File Offset: 0x00004F0F
		public void SetColorArray(string name, List<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00006D2B File Offset: 0x00004F2B
		public void SetColorArray(int nameID, List<Color> values)
		{
			this.SetColorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00006D42 File Offset: 0x00004F42
		public void SetColorArray(string name, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00006D5A File Offset: 0x00004F5A
		public void SetColorArray(int nameID, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(nameID, values, values.Length);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00006D6D File Offset: 0x00004F6D
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00006D89 File Offset: 0x00004F89
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(nameID, values, values.Length);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00006DCB File Offset: 0x00004FCB
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00006DE7 File Offset: 0x00004FE7
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00006DFE File Offset: 0x00004FFE
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00006E16 File Offset: 0x00005016
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00029018 File Offset: 0x00027218
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00029038 File Offset: 0x00027238
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00029054 File Offset: 0x00027254
		public int GetInteger(string name)
		{
			return this.GetIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00029074 File Offset: 0x00027274
		public int GetInteger(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00029090 File Offset: 0x00027290
		public Vector4 GetVector(string name)
		{
			return this.GetColorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000290B4 File Offset: 0x000272B4
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000290D4 File Offset: 0x000272D4
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000290F0 File Offset: 0x000272F0
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00029110 File Offset: 0x00027310
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00029138 File Offset: 0x00027338
		public Il2CppStructArray<Color> GetColorArray(string name)
		{
			return this.GetColorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00029158 File Offset: 0x00027358
		public Il2CppStructArray<Color> GetColorArray(int nameID)
		{
			return (this.GetColorArrayCountImpl(nameID) != 0) ? this.GetColorArrayImpl(nameID) : null;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00029180 File Offset: 0x00027380
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000291A0 File Offset: 0x000273A0
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000291C8 File Offset: 0x000273C8
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000291E8 File Offset: 0x000273E8
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00006E29 File Offset: 0x00005029
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00006E3A File Offset: 0x0000503A
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00006E46 File Offset: 0x00005046
		public void GetColorArray(string name, List<Color> values)
		{
			this.ExtractColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00006E57 File Offset: 0x00005057
		public void GetColorArray(int nameID, List<Color> values)
		{
			this.ExtractColorArray(nameID, values);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00006E63 File Offset: 0x00005063
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00006E74 File Offset: 0x00005074
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00006E80 File Offset: 0x00005080
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00006E91 File Offset: 0x00005091
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00006E9D File Offset: 0x0000509D
		public void SetTextureOffset(string name, Vector2 value)
		{
			this.SetTextureOffsetImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00006EAE File Offset: 0x000050AE
		public void SetTextureOffset(int nameID, Vector2 value)
		{
			this.SetTextureOffsetImpl(nameID, value);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00006EBA File Offset: 0x000050BA
		public void SetTextureScale(string name, Vector2 value)
		{
			this.SetTextureScaleImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00006ECB File Offset: 0x000050CB
		public void SetTextureScale(int nameID, Vector2 value)
		{
			this.SetTextureScaleImpl(nameID, value);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00029210 File Offset: 0x00027410
		public Vector2 GetTextureOffset(string name)
		{
			return this.GetTextureOffset(Shader.PropertyToID(name));
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00029230 File Offset: 0x00027430
		public Vector2 GetTextureOffset(int nameID)
		{
			Vector4 textureScaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
			return new Vector2(textureScaleAndOffsetImpl.z, textureScaleAndOffsetImpl.w);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0002925C File Offset: 0x0002745C
		public Vector2 GetTextureScale(string name)
		{
			return this.GetTextureScale(Shader.PropertyToID(name));
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002927C File Offset: 0x0002747C
		public Vector2 GetTextureScale(int nameID)
		{
			Vector4 textureScaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
			return new Vector2(textureScaleAndOffsetImpl.x, textureScaleAndOffsetImpl.y);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00006ED7 File Offset: 0x000050D7
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Material.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00006EEB File Offset: 0x000050EB
		public void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret)
		{
			Material.GetTextureScaleAndOffsetImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00006EFF File Offset: 0x000050FF
		public void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset)
		{
			Material.SetTextureOffsetImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref offset);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00006F13 File Offset: 0x00005113
		public void SetTextureScaleImpl_Injected(int name, ref Vector2 scale)
		{
			Material.SetTextureScaleImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref scale);
		}

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCRC_Public_Int32_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_Int32_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_String_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x0400050B RID: 1291
		private static readonly Material.GetDefaultMaterialDelegate GetDefaultMaterialDelegateField;

		// Token: 0x0400050C RID: 1292
		private static readonly Material.GetDefaultParticleMaterialDelegate GetDefaultParticleMaterialDelegateField;

		// Token: 0x0400050D RID: 1293
		private static readonly Material.GetDefaultLineMaterialDelegate GetDefaultLineMaterialDelegateField;

		// Token: 0x0400050E RID: 1294
		private static readonly Material.get_shaderDelegate get_shaderDelegateField;

		// Token: 0x0400050F RID: 1295
		private static readonly Material.set_shaderDelegate set_shaderDelegateField;

		// Token: 0x04000510 RID: 1296
		private static readonly Material.HasFloatImplDelegate HasFloatImplDelegateField;

		// Token: 0x04000511 RID: 1297
		private static readonly Material.HasIntImplDelegate HasIntImplDelegateField;

		// Token: 0x04000512 RID: 1298
		private static readonly Material.HasTextureImplDelegate HasTextureImplDelegateField;

		// Token: 0x04000513 RID: 1299
		private static readonly Material.HasMatrixImplDelegate HasMatrixImplDelegateField;

		// Token: 0x04000514 RID: 1300
		private static readonly Material.HasVectorImplDelegate HasVectorImplDelegateField;

		// Token: 0x04000515 RID: 1301
		private static readonly Material.HasBufferImplDelegate HasBufferImplDelegateField;

		// Token: 0x04000516 RID: 1302
		private static readonly Material.HasConstantBufferImplDelegate HasConstantBufferImplDelegateField;

		// Token: 0x04000517 RID: 1303
		private static readonly Material.get_renderQueueDelegate get_renderQueueDelegateField;

		// Token: 0x04000518 RID: 1304
		private static readonly Material.get_rawRenderQueueDelegate get_rawRenderQueueDelegateField;

		// Token: 0x04000519 RID: 1305
		private static readonly Material.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x0400051A RID: 1306
		private static readonly Material.get_globalIlluminationFlagsDelegate get_globalIlluminationFlagsDelegateField;

		// Token: 0x0400051B RID: 1307
		private static readonly Material.set_globalIlluminationFlagsDelegate set_globalIlluminationFlagsDelegateField;

		// Token: 0x0400051C RID: 1308
		private static readonly Material.get_doubleSidedGIDelegate get_doubleSidedGIDelegateField;

		// Token: 0x0400051D RID: 1309
		private static readonly Material.set_doubleSidedGIDelegate set_doubleSidedGIDelegateField;

		// Token: 0x0400051E RID: 1310
		private static readonly Material.get_enableInstancingDelegate get_enableInstancingDelegateField;

		// Token: 0x0400051F RID: 1311
		private static readonly Material.set_enableInstancingDelegate set_enableInstancingDelegateField;

		// Token: 0x04000520 RID: 1312
		private static readonly Material.SetShaderPassEnabledDelegate SetShaderPassEnabledDelegateField;

		// Token: 0x04000521 RID: 1313
		private static readonly Material.GetShaderPassEnabledDelegate GetShaderPassEnabledDelegateField;

		// Token: 0x04000522 RID: 1314
		private static readonly Material.GetPassNameDelegate GetPassNameDelegateField;

		// Token: 0x04000523 RID: 1315
		private static readonly Material.FindPassDelegate FindPassDelegateField;

		// Token: 0x04000524 RID: 1316
		private static readonly Material.SetOverrideTagDelegate SetOverrideTagDelegateField;

		// Token: 0x04000525 RID: 1317
		private static readonly Material.GetTagImplDelegate GetTagImplDelegateField;

		// Token: 0x04000526 RID: 1318
		private static readonly Material.LerpDelegate LerpDelegateField;

		// Token: 0x04000527 RID: 1319
		private static readonly Material.SetPassDelegate SetPassDelegateField;

		// Token: 0x04000528 RID: 1320
		private static readonly Material.GetTexturePropertyNamesDelegate GetTexturePropertyNamesDelegateField;

		// Token: 0x04000529 RID: 1321
		private static readonly Material.GetTexturePropertyNameIDsDelegate GetTexturePropertyNameIDsDelegateField;

		// Token: 0x0400052A RID: 1322
		private static readonly Material.GetTexturePropertyNamesInternalDelegate GetTexturePropertyNamesInternalDelegateField;

		// Token: 0x0400052B RID: 1323
		private static readonly Material.GetTexturePropertyNameIDsInternalDelegate GetTexturePropertyNameIDsInternalDelegateField;

		// Token: 0x0400052C RID: 1324
		private static readonly Material.SetIntImplDelegate SetIntImplDelegateField;

		// Token: 0x0400052D RID: 1325
		private static readonly Material.SetRenderTextureImplDelegate SetRenderTextureImplDelegateField;

		// Token: 0x0400052E RID: 1326
		private static readonly Material.SetBufferImplDelegate SetBufferImplDelegateField;

		// Token: 0x0400052F RID: 1327
		private static readonly Material.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField;

		// Token: 0x04000530 RID: 1328
		private static readonly Material.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField;

		// Token: 0x04000531 RID: 1329
		private static readonly Material.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x04000532 RID: 1330
		private static readonly Material.GetIntImplDelegate GetIntImplDelegateField;

		// Token: 0x04000533 RID: 1331
		private static readonly Material.SetFloatArrayImplDelegate SetFloatArrayImplDelegateField;

		// Token: 0x04000534 RID: 1332
		private static readonly Material.SetVectorArrayImplDelegate SetVectorArrayImplDelegateField;

		// Token: 0x04000535 RID: 1333
		private static readonly Material.SetColorArrayImplDelegate SetColorArrayImplDelegateField;

		// Token: 0x04000536 RID: 1334
		private static readonly Material.SetMatrixArrayImplDelegate SetMatrixArrayImplDelegateField;

		// Token: 0x04000537 RID: 1335
		private static readonly Material.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField;

		// Token: 0x04000538 RID: 1336
		private static readonly Material.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x04000539 RID: 1337
		private static readonly Material.GetColorArrayImplDelegate GetColorArrayImplDelegateField;

		// Token: 0x0400053A RID: 1338
		private static readonly Material.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x0400053B RID: 1339
		private static readonly Material.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField;

		// Token: 0x0400053C RID: 1340
		private static readonly Material.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x0400053D RID: 1341
		private static readonly Material.GetColorArrayCountImplDelegate GetColorArrayCountImplDelegateField;

		// Token: 0x0400053E RID: 1342
		private static readonly Material.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x0400053F RID: 1343
		private static readonly Material.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x04000540 RID: 1344
		private static readonly Material.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x04000541 RID: 1345
		private static readonly Material.ExtractColorArrayImplDelegate ExtractColorArrayImplDelegateField;

		// Token: 0x04000542 RID: 1346
		private static readonly Material.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x04000543 RID: 1347
		private static readonly Material.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x04000544 RID: 1348
		private static readonly Material.GetTextureScaleAndOffsetImpl_InjectedDelegate GetTextureScaleAndOffsetImpl_InjectedDelegateField;

		// Token: 0x04000545 RID: 1349
		private static readonly Material.SetTextureOffsetImpl_InjectedDelegate SetTextureOffsetImpl_InjectedDelegateField;

		// Token: 0x04000546 RID: 1350
		private static readonly Material.SetTextureScaleImpl_InjectedDelegate SetTextureScaleImpl_InjectedDelegateField;

		// Token: 0x0200058B RID: 1419
		// (Invoke) Token: 0x060028E5 RID: 10469
		private delegate IntPtr GetDefaultMaterialDelegate();

		// Token: 0x0200058C RID: 1420
		// (Invoke) Token: 0x060028E7 RID: 10471
		private delegate IntPtr GetDefaultParticleMaterialDelegate();

		// Token: 0x0200058D RID: 1421
		// (Invoke) Token: 0x060028E9 RID: 10473
		private delegate IntPtr GetDefaultLineMaterialDelegate();

		// Token: 0x0200058E RID: 1422
		// (Invoke) Token: 0x060028EB RID: 10475
		private delegate IntPtr get_shaderDelegate(IntPtr @this);

		// Token: 0x0200058F RID: 1423
		// (Invoke) Token: 0x060028ED RID: 10477
		private delegate void set_shaderDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000590 RID: 1424
		// (Invoke) Token: 0x060028EF RID: 10479
		private delegate bool HasFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x02000591 RID: 1425
		// (Invoke) Token: 0x060028F1 RID: 10481
		private delegate bool HasIntImplDelegate(IntPtr @this, int name);

		// Token: 0x02000592 RID: 1426
		// (Invoke) Token: 0x060028F3 RID: 10483
		private delegate bool HasTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x02000593 RID: 1427
		// (Invoke) Token: 0x060028F5 RID: 10485
		private delegate bool HasMatrixImplDelegate(IntPtr @this, int name);

		// Token: 0x02000594 RID: 1428
		// (Invoke) Token: 0x060028F7 RID: 10487
		private delegate bool HasVectorImplDelegate(IntPtr @this, int name);

		// Token: 0x02000595 RID: 1429
		// (Invoke) Token: 0x060028F9 RID: 10489
		private delegate bool HasBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000596 RID: 1430
		// (Invoke) Token: 0x060028FB RID: 10491
		private delegate bool HasConstantBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000597 RID: 1431
		// (Invoke) Token: 0x060028FD RID: 10493
		private delegate int get_renderQueueDelegate(IntPtr @this);

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x060028FF RID: 10495
		private delegate int get_rawRenderQueueDelegate(IntPtr @this);

		// Token: 0x02000599 RID: 1433
		// (Invoke) Token: 0x06002901 RID: 10497
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x0200059A RID: 1434
		// (Invoke) Token: 0x06002903 RID: 10499
		private delegate MaterialGlobalIlluminationFlags get_globalIlluminationFlagsDelegate(IntPtr @this);

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x06002905 RID: 10501
		private delegate void set_globalIlluminationFlagsDelegate(IntPtr @this, MaterialGlobalIlluminationFlags value);

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x06002907 RID: 10503
		private delegate bool get_doubleSidedGIDelegate(IntPtr @this);

		// Token: 0x0200059D RID: 1437
		// (Invoke) Token: 0x06002909 RID: 10505
		private delegate void set_doubleSidedGIDelegate(IntPtr @this, bool value);

		// Token: 0x0200059E RID: 1438
		// (Invoke) Token: 0x0600290B RID: 10507
		private delegate bool get_enableInstancingDelegate(IntPtr @this);

		// Token: 0x0200059F RID: 1439
		// (Invoke) Token: 0x0600290D RID: 10509
		private delegate void set_enableInstancingDelegate(IntPtr @this, bool value);

		// Token: 0x020005A0 RID: 1440
		// (Invoke) Token: 0x0600290F RID: 10511
		private delegate void SetShaderPassEnabledDelegate(IntPtr @this, IntPtr passName, bool enabled);

		// Token: 0x020005A1 RID: 1441
		// (Invoke) Token: 0x06002911 RID: 10513
		private delegate bool GetShaderPassEnabledDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x020005A2 RID: 1442
		// (Invoke) Token: 0x06002913 RID: 10515
		private delegate IntPtr GetPassNameDelegate(IntPtr @this, int pass);

		// Token: 0x020005A3 RID: 1443
		// (Invoke) Token: 0x06002915 RID: 10517
		private delegate int FindPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x020005A4 RID: 1444
		// (Invoke) Token: 0x06002917 RID: 10519
		private delegate void SetOverrideTagDelegate(IntPtr @this, IntPtr tag, IntPtr val);

		// Token: 0x020005A5 RID: 1445
		// (Invoke) Token: 0x06002919 RID: 10521
		private delegate IntPtr GetTagImplDelegate(IntPtr @this, IntPtr tag, bool currentSubShaderOnly, IntPtr defaultValue);

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x0600291B RID: 10523
		private delegate void LerpDelegate(IntPtr @this, IntPtr start, IntPtr end, float t);

		// Token: 0x020005A7 RID: 1447
		// (Invoke) Token: 0x0600291D RID: 10525
		private delegate bool SetPassDelegate(IntPtr @this, int pass);

		// Token: 0x020005A8 RID: 1448
		// (Invoke) Token: 0x0600291F RID: 10527
		private delegate IntPtr GetTexturePropertyNamesDelegate(IntPtr @this);

		// Token: 0x020005A9 RID: 1449
		// (Invoke) Token: 0x06002921 RID: 10529
		private delegate IntPtr GetTexturePropertyNameIDsDelegate(IntPtr @this);

		// Token: 0x020005AA RID: 1450
		// (Invoke) Token: 0x06002923 RID: 10531
		private delegate void GetTexturePropertyNamesInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020005AB RID: 1451
		// (Invoke) Token: 0x06002925 RID: 10533
		private delegate void GetTexturePropertyNameIDsInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020005AC RID: 1452
		// (Invoke) Token: 0x06002927 RID: 10535
		private delegate void SetIntImplDelegate(IntPtr @this, int name, int value);

		// Token: 0x020005AD RID: 1453
		// (Invoke) Token: 0x06002929 RID: 10537
		private delegate void SetRenderTextureImplDelegate(IntPtr @this, int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020005AE RID: 1454
		// (Invoke) Token: 0x0600292B RID: 10539
		private delegate void SetBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x0600292D RID: 10541
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005B0 RID: 1456
		// (Invoke) Token: 0x0600292F RID: 10543
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005B1 RID: 1457
		// (Invoke) Token: 0x06002931 RID: 10545
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005B2 RID: 1458
		// (Invoke) Token: 0x06002933 RID: 10547
		private delegate int GetIntImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B3 RID: 1459
		// (Invoke) Token: 0x06002935 RID: 10549
		private delegate void SetFloatArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005B4 RID: 1460
		// (Invoke) Token: 0x06002937 RID: 10551
		private delegate void SetVectorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005B5 RID: 1461
		// (Invoke) Token: 0x06002939 RID: 10553
		private delegate void SetColorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x0600293B RID: 10555
		private delegate void SetMatrixArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005B7 RID: 1463
		// (Invoke) Token: 0x0600293D RID: 10557
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B8 RID: 1464
		// (Invoke) Token: 0x0600293F RID: 10559
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B9 RID: 1465
		// (Invoke) Token: 0x06002941 RID: 10561
		private delegate IntPtr GetColorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BA RID: 1466
		// (Invoke) Token: 0x06002943 RID: 10563
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BB RID: 1467
		// (Invoke) Token: 0x06002945 RID: 10565
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BC RID: 1468
		// (Invoke) Token: 0x06002947 RID: 10567
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BD RID: 1469
		// (Invoke) Token: 0x06002949 RID: 10569
		private delegate int GetColorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BE RID: 1470
		// (Invoke) Token: 0x0600294B RID: 10571
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BF RID: 1471
		// (Invoke) Token: 0x0600294D RID: 10573
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C0 RID: 1472
		// (Invoke) Token: 0x0600294F RID: 10575
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C1 RID: 1473
		// (Invoke) Token: 0x06002951 RID: 10577
		private delegate void ExtractColorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C2 RID: 1474
		// (Invoke) Token: 0x06002953 RID: 10579
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C3 RID: 1475
		// (Invoke) Token: 0x06002955 RID: 10581
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020005C4 RID: 1476
		// (Invoke) Token: 0x06002957 RID: 10583
		private delegate void GetTextureScaleAndOffsetImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020005C5 RID: 1477
		// (Invoke) Token: 0x06002959 RID: 10585
		private delegate void SetTextureOffsetImpl_InjectedDelegate(IntPtr @this, int name, IntPtr offset);

		// Token: 0x020005C6 RID: 1478
		// (Invoke) Token: 0x0600295B RID: 10587
		private delegate void SetTextureScaleImpl_InjectedDelegate(IntPtr @this, int name, IntPtr scale);
	}
}
