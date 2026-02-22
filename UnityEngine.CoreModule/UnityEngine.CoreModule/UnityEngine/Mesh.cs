using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200006E RID: 110
	public sealed class Mesh : Object
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x0002A19C File Offset: 0x0002839C
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh()
		{
			Il2CppClassPointerStore<Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh>.NativeClassPtr);
			Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663713);
			Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663714);
			Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663715);
			Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663716);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663717);
			Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663718);
			Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663719);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663720);
			Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663721);
			Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663722);
			Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663723);
			Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663724);
			Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663725);
			Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663726);
			Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663727);
			Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663728);
			Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663729);
			Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663730);
			Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663731);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663732);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663733);
			Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663734);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663735);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663736);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663737);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663738);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663739);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663740);
			Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663741);
			Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663742);
			Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663743);
			Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663744);
			Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663745);
			Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663746);
			Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663747);
			Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663748);
			Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663749);
			Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663750);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663751);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663752);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663753);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663754);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663755);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663756);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663757);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663758);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663759);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663760);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663761);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663762);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663763);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663764);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663765);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663766);
			Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663767);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663768);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663769);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663770);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663771);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663772);
			Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663773);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663774);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663775);
			Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663776);
			Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663777);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663778);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663779);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663780);
			Mesh.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663781);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663782);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663783);
			Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663784);
			Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663785);
			Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100663786);
			Mesh.FromInstanceIDDelegateField = IL2CPP.ResolveICall<Mesh.FromInstanceIDDelegate>("UnityEngine.Mesh::FromInstanceID");
			Mesh.get_indexFormatDelegateField = IL2CPP.ResolveICall<Mesh.get_indexFormatDelegate>("UnityEngine.Mesh::get_indexFormat");
			Mesh.set_indexFormatDelegateField = IL2CPP.ResolveICall<Mesh.set_indexFormatDelegate>("UnityEngine.Mesh::set_indexFormat");
			Mesh.GetTotalIndexCountDelegateField = IL2CPP.ResolveICall<Mesh.GetTotalIndexCountDelegate>("UnityEngine.Mesh::GetTotalIndexCount");
			Mesh.SetIndexBufferParamsDelegateField = IL2CPP.ResolveICall<Mesh.SetIndexBufferParamsDelegate>("UnityEngine.Mesh::SetIndexBufferParams");
			Mesh.InternalSetIndexBufferDataDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetIndexBufferDataDelegate>("UnityEngine.Mesh::InternalSetIndexBufferData");
			Mesh.InternalSetIndexBufferDataFromArrayDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetIndexBufferDataFromArrayDelegate>("UnityEngine.Mesh::InternalSetIndexBufferDataFromArray");
			Mesh.SetVertexBufferParamsFromPtrDelegateField = IL2CPP.ResolveICall<Mesh.SetVertexBufferParamsFromPtrDelegate>("UnityEngine.Mesh::SetVertexBufferParamsFromPtr");
			Mesh.InternalSetVertexBufferDataDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetVertexBufferDataDelegate>("UnityEngine.Mesh::InternalSetVertexBufferData");
			Mesh.InternalSetVertexBufferDataFromArrayDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetVertexBufferDataFromArrayDelegate>("UnityEngine.Mesh::InternalSetVertexBufferDataFromArray");
			Mesh.GetVertexAttributesAllocDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesAllocDelegate>("UnityEngine.Mesh::GetVertexAttributesAlloc");
			Mesh.GetVertexAttributeCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeCountImplDelegate>("UnityEngine.Mesh::GetVertexAttributeCountImpl");
			Mesh.GetIndexStartImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndexStartImplDelegate>("UnityEngine.Mesh::GetIndexStartImpl");
			Mesh.GetIndexCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndexCountImplDelegate>("UnityEngine.Mesh::GetIndexCountImpl");
			Mesh.GetTrianglesCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesCountImplDelegate>("UnityEngine.Mesh::GetTrianglesCountImpl");
			Mesh.GetBaseVertexImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBaseVertexImplDelegate>("UnityEngine.Mesh::GetBaseVertexImpl");
			Mesh.GetTrianglesImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesImplDelegate>("UnityEngine.Mesh::GetTrianglesImpl");
			Mesh.SetIndicesNativeArrayImplDelegateField = IL2CPP.ResolveICall<Mesh.SetIndicesNativeArrayImplDelegate>("UnityEngine.Mesh::SetIndicesNativeArrayImpl");
			Mesh.GetTrianglesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImplDelegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl");
			Mesh.GetTrianglesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl16");
			Mesh.GetIndicesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImplDelegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl");
			Mesh.GetIndicesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl16");
			Mesh.GetVertexAttributeDimensionDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeDimensionDelegate>("UnityEngine.Mesh::GetVertexAttributeDimension");
			Mesh.GetVertexAttributeFormatDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeFormatDelegate>("UnityEngine.Mesh::GetVertexAttributeFormat");
			Mesh.SetNativeArrayForChannelImplDelegateField = IL2CPP.ResolveICall<Mesh.SetNativeArrayForChannelImplDelegate>("UnityEngine.Mesh::SetNativeArrayForChannelImpl");
			Mesh.get_vertexBufferCountDelegateField = IL2CPP.ResolveICall<Mesh.get_vertexBufferCountDelegate>("UnityEngine.Mesh::get_vertexBufferCount");
			Mesh.GetNativeVertexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeVertexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeVertexBufferPtr");
			Mesh.GetNativeIndexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeIndexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeIndexBufferPtr");
			Mesh.get_blendShapeCountDelegateField = IL2CPP.ResolveICall<Mesh.get_blendShapeCountDelegate>("UnityEngine.Mesh::get_blendShapeCount");
			Mesh.ClearBlendShapesDelegateField = IL2CPP.ResolveICall<Mesh.ClearBlendShapesDelegate>("UnityEngine.Mesh::ClearBlendShapes");
			Mesh.GetBlendShapeNameDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeNameDelegate>("UnityEngine.Mesh::GetBlendShapeName");
			Mesh.GetBlendShapeIndexDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeIndexDelegate>("UnityEngine.Mesh::GetBlendShapeIndex");
			Mesh.GetBlendShapeFrameCountDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameCountDelegate>("UnityEngine.Mesh::GetBlendShapeFrameCount");
			Mesh.GetBlendShapeFrameWeightDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameWeightDelegate>("UnityEngine.Mesh::GetBlendShapeFrameWeight");
			Mesh.GetBlendShapeFrameVerticesDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameVerticesDelegate>("UnityEngine.Mesh::GetBlendShapeFrameVertices");
			Mesh.AddBlendShapeFrameDelegateField = IL2CPP.ResolveICall<Mesh.AddBlendShapeFrameDelegate>("UnityEngine.Mesh::AddBlendShapeFrame");
			Mesh.HasBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.HasBoneWeightsDelegate>("UnityEngine.Mesh::HasBoneWeights");
			Mesh.InternalSetBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetBoneWeightsDelegate>("UnityEngine.Mesh::InternalSetBoneWeights");
			Mesh.GetAllBoneWeightsArraySizeDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArraySizeDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArraySize");
			Mesh.GetAllBoneWeightsArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArrayDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArray");
			Mesh.GetBonesPerVertexArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetBonesPerVertexArrayDelegate>("UnityEngine.Mesh::GetBonesPerVertexArray");
			Mesh.GetBindposeCountDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposeCountDelegate>("UnityEngine.Mesh::GetBindposeCount");
			Mesh.get_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.get_bindposesDelegate>("UnityEngine.Mesh::get_bindposes");
			Mesh.set_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.set_bindposesDelegate>("UnityEngine.Mesh::set_bindposes");
			Mesh.GetBindposesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposesNonAllocImplDelegate>("UnityEngine.Mesh::GetBindposesNonAllocImpl");
			Mesh.get_isReadableDelegateField = IL2CPP.ResolveICall<Mesh.get_isReadableDelegate>("UnityEngine.Mesh::get_isReadable");
			Mesh.set_subMeshCountDelegateField = IL2CPP.ResolveICall<Mesh.set_subMeshCountDelegate>("UnityEngine.Mesh::set_subMeshCount");
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField = IL2CPP.ResolveICall<Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate>("UnityEngine.Mesh::SetAllSubMeshesAtOnceFromNativeArray");
			Mesh.RecalculateNormalsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateNormalsImplDelegate>("UnityEngine.Mesh::RecalculateNormalsImpl");
			Mesh.RecalculateTangentsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateTangentsImplDelegate>("UnityEngine.Mesh::RecalculateTangentsImpl");
			Mesh.MarkModifiedDelegateField = IL2CPP.ResolveICall<Mesh.MarkModifiedDelegate>("UnityEngine.Mesh::MarkModified");
			Mesh.UploadMeshDataImplDelegateField = IL2CPP.ResolveICall<Mesh.UploadMeshDataImplDelegate>("UnityEngine.Mesh::UploadMeshDataImpl");
			Mesh.GetTopologyImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTopologyImplDelegate>("UnityEngine.Mesh::GetTopologyImpl");
			Mesh.RecalculateUVDistributionMetricImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricImpl");
			Mesh.RecalculateUVDistributionMetricsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricsImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricsImpl");
			Mesh.GetUVDistributionMetricDelegateField = IL2CPP.ResolveICall<Mesh.GetUVDistributionMetricDelegate>("UnityEngine.Mesh::GetUVDistributionMetric");
			Mesh.OptimizeImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeImplDelegate>("UnityEngine.Mesh::OptimizeImpl");
			Mesh.OptimizeIndexBuffersImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeIndexBuffersImplDelegate>("UnityEngine.Mesh::OptimizeIndexBuffersImpl");
			Mesh.OptimizeReorderVertexBufferImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeReorderVertexBufferImplDelegate>("UnityEngine.Mesh::OptimizeReorderVertexBufferImpl");
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0002AB0C File Offset: 0x00028D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63532, XrefRangeEnd = 63534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Mesh mono)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002AB44 File Offset: 0x00028D44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 63540, RefRangeEnd = 63551, XrefRangeStart = 63534, XrefRangeEnd = 63540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002AB80 File Offset: 0x00028D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63551, XrefRangeEnd = 63553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002ABDC File Offset: 0x00028DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63553, XrefRangeEnd = 63555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002AC84 File Offset: 0x00028E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63557, RefRangeEnd = 63558, XrefRangeStart = 63555, XrefRangeEnd = 63557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63560, RefRangeEnd = 63562, XrefRangeStart = 63558, XrefRangeEnd = 63560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002AD10 File Offset: 0x00028F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63562, XrefRangeEnd = 63564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63566, RefRangeEnd = 63567, XrefRangeStart = 63564, XrefRangeEnd = 63566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0002AE20 File Offset: 0x00029020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63569, RefRangeEnd = 63570, XrefRangeStart = 63567, XrefRangeEnd = 63569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002AE90 File Offset: 0x00029090
		public unsafe bool canAccess
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 63572, RefRangeEnd = 63574, XrefRangeStart = 63570, XrefRangeEnd = 63572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002AECC File Offset: 0x000290CC
		public unsafe int vertexCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63576, RefRangeEnd = 63577, XrefRangeStart = 63574, XrefRangeEnd = 63576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002AF08 File Offset: 0x00029108
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00007904 File Offset: 0x00005B04
		public unsafe int subMeshCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63577, XrefRangeEnd = 63579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Mesh.set_subMeshCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002AF44 File Offset: 0x00029144
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0002AF80 File Offset: 0x00029180
		public unsafe Bounds bounds
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 63581, RefRangeEnd = 63585, XrefRangeStart = 63579, XrefRangeEnd = 63581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 63587, RefRangeEnd = 63590, XrefRangeStart = 63585, XrefRangeEnd = 63587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0002AFC0 File Offset: 0x000291C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63590, XrefRangeEnd = 63592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearImpl(bool keepVertexLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepVertexLayout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0002B000 File Offset: 0x00029200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63592, XrefRangeEnd = 63594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0002B040 File Offset: 0x00029240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63594, XrefRangeEnd = 63596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamicImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0002B074 File Offset: 0x00029274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63596, RefRangeEnd = 63598, XrefRangeStart = 63596, XrefRangeEnd = 63596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0002B0B4 File Offset: 0x000292B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63598, RefRangeEnd = 63601, XrefRangeStart = 63598, XrefRangeEnd = 63598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0002B0F4 File Offset: 0x000292F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63611, RefRangeEnd = 63612, XrefRangeStart = 63601, XrefRangeEnd = 63611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0002B154 File Offset: 0x00029354
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63613, RefRangeEnd = 63616, XrefRangeStart = 63612, XrefRangeEnd = 63613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0002B198 File Offset: 0x00029398
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63622, RefRangeEnd = 63626, XrefRangeStart = 63616, XrefRangeEnd = 63622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesArrayLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0002B240 File Offset: 0x00029440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63628, RefRangeEnd = 63629, XrefRangeStart = 63626, XrefRangeEnd = 63628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0002B2BC File Offset: 0x000294BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 63632, RefRangeEnd = 63637, XrefRangeStart = 63629, XrefRangeEnd = 63632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0002B31C File Offset: 0x0002951C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63639, RefRangeEnd = 63642, XrefRangeStart = 63637, XrefRangeEnd = 63639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002B3B4 File Offset: 0x000295B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 63645, RefRangeEnd = 63654, XrefRangeStart = 63642, XrefRangeEnd = 63645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0002B430 File Offset: 0x00029630
		[CallerCount(0)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0002B49C File Offset: 0x0002969C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63654, XrefRangeEnd = 63658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0002B518 File Offset: 0x00029718
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0002B558 File Offset: 0x00029758
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63661, RefRangeEnd = 63662, XrefRangeStart = 63658, XrefRangeEnd = 63661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 63665, RefRangeEnd = 63685, XrefRangeStart = 63662, XrefRangeEnd = 63665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002B59C File Offset: 0x0002979C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0002B5DC File Offset: 0x000297DC
		public unsafe Il2CppStructArray<Vector3> normals
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63688, RefRangeEnd = 63689, XrefRangeStart = 63685, XrefRangeEnd = 63688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 63692, RefRangeEnd = 63696, XrefRangeStart = 63689, XrefRangeEnd = 63692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002B620 File Offset: 0x00029820
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0002B660 File Offset: 0x00029860
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63699, RefRangeEnd = 63700, XrefRangeStart = 63696, XrefRangeEnd = 63699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 63703, RefRangeEnd = 63707, XrefRangeStart = 63700, XrefRangeEnd = 63703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002B6A4 File Offset: 0x000298A4
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord0);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 63710, RefRangeEnd = 63720, XrefRangeStart = 63707, XrefRangeEnd = 63710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0002B6E8 File Offset: 0x000298E8
		public unsafe Il2CppStructArray<Vector2> uv2
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord1);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 63723, RefRangeEnd = 63734, XrefRangeStart = 63720, XrefRangeEnd = 63723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002B72C File Offset: 0x0002992C
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0002B76C File Offset: 0x0002996C
		public unsafe Il2CppStructArray<Color32> colors32
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63737, RefRangeEnd = 63738, XrefRangeStart = 63734, XrefRangeEnd = 63737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 63741, RefRangeEnd = 63752, XrefRangeStart = 63738, XrefRangeEnd = 63741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002B7B0 File Offset: 0x000299B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63758, RefRangeEnd = 63759, XrefRangeStart = 63752, XrefRangeEnd = 63758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002B7F4 File Offset: 0x000299F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63759, XrefRangeEnd = 63762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002B854 File Offset: 0x00029A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63762, XrefRangeEnd = 63765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63771, RefRangeEnd = 63772, XrefRangeStart = 63765, XrefRangeEnd = 63771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002B904 File Offset: 0x00029B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63772, XrefRangeEnd = 63775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002B964 File Offset: 0x00029B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63775, XrefRangeEnd = 63778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63784, RefRangeEnd = 63785, XrefRangeStart = 63778, XrefRangeEnd = 63784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002BA14 File Offset: 0x00029C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63785, XrefRangeEnd = 63788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0002BA74 File Offset: 0x00029C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63788, XrefRangeEnd = 63791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63797, RefRangeEnd = 63798, XrefRangeStart = 63791, XrefRangeEnd = 63797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0002BB24 File Offset: 0x00029D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63798, XrefRangeEnd = 63801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0002BB84 File Offset: 0x00029D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63801, XrefRangeEnd = 63804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63804, XrefRangeEnd = 63812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002BC78 File Offset: 0x00029E78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63818, RefRangeEnd = 63822, XrefRangeStart = 63812, XrefRangeEnd = 63818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002BCC8 File Offset: 0x00029EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63822, XrefRangeEnd = 63825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002BD34 File Offset: 0x00029F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63825, XrefRangeEnd = 63828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63828, XrefRangeEnd = 63830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002BE10 File Offset: 0x0002A010
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63833, RefRangeEnd = 63837, XrefRangeStart = 63830, XrefRangeEnd = 63833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0002BE60 File Offset: 0x0002A060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63849, RefRangeEnd = 63850, XrefRangeStart = 63837, XrefRangeEnd = 63849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessIndices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0002BE94 File Offset: 0x0002A094
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63858, RefRangeEnd = 63865, XrefRangeStart = 63850, XrefRangeEnd = 63858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorAboutTriangles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63865, XrefRangeEnd = 63866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002BF38 File Offset: 0x0002A138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63866, XrefRangeEnd = 63867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00007CF5 File Offset: 0x00005EF5
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0002BF84 File Offset: 0x0002A184
		public unsafe Il2CppStructArray<int> triangles
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 63876, RefRangeEnd = 63880, XrefRangeStart = 63867, XrefRangeEnd = 63876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63884, RefRangeEnd = 63885, XrefRangeStart = 63880, XrefRangeEnd = 63884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0002C014 File Offset: 0x0002A214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63885, XrefRangeEnd = 63889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0002C070 File Offset: 0x0002A270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63889, RefRangeEnd = 63891, XrefRangeStart = 63889, XrefRangeEnd = 63889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valuesLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63894, RefRangeEnd = 63897, XrefRangeStart = 63891, XrefRangeEnd = 63894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesArrayLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002C170 File Offset: 0x0002A370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63907, RefRangeEnd = 63908, XrefRangeStart = 63897, XrefRangeEnd = 63907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63908, XrefRangeEnd = 63918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0002C22C File Offset: 0x0002A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63918, XrefRangeEnd = 63925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0002C2B4 File Offset: 0x0002A4B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63927, RefRangeEnd = 63931, XrefRangeStart = 63925, XrefRangeEnd = 63927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 63943, RefRangeEnd = 63954, XrefRangeStart = 63931, XrefRangeEnd = 63943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0002C31C File Offset: 0x0002A51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63954, XrefRangeEnd = 63966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002C35C File Offset: 0x0002A55C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63970, RefRangeEnd = 63972, XrefRangeStart = 63966, XrefRangeEnd = 63970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002C390 File Offset: 0x0002A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63972, XrefRangeEnd = 63974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63974, XrefRangeEnd = 63976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_bounds_Injected(ref Bounds value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000075D2 File Offset: 0x000057D2
		public Mesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002C410 File Offset: 0x0002A610
		public static Mesh FromInstanceID(int id)
		{
			IntPtr intPtr = Mesh.FromInstanceIDDelegateField(id);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x000075DB File Offset: 0x000057DB
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000075ED File Offset: 0x000057ED
		public UnityEngine.Rendering.IndexFormat indexFormat
		{
			get
			{
				return Mesh.get_indexFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Mesh.set_indexFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00007600 File Offset: 0x00005800
		public uint GetTotalIndexCount()
		{
			return Mesh.GetTotalIndexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00007612 File Offset: 0x00005812
		public void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format)
		{
			Mesh.SetIndexBufferParamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), indexCount, format);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00007626 File Offset: 0x00005826
		public void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetIndexBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00007641 File Offset: 0x00005841
		public void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetIndexBufferDataFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00007661 File Offset: 0x00005861
		public void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount)
		{
			Mesh.SetVertexBufferParamsFromPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, attributesPtr, attributesCount);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002C438 File Offset: 0x0002A638
		public void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetVertexBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream, data, dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002C460 File Offset: 0x0002A660
		public void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetVertexBufferDataFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream, IL2CPP.Il2CppObjectBaseToPtr(data), dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0002C490 File Offset: 0x0002A690
		public Array GetVertexAttributesAlloc()
		{
			IntPtr intPtr = Mesh.GetVertexAttributesAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00007676 File Offset: 0x00005876
		public int GetVertexAttributeCountImpl()
		{
			return Mesh.GetVertexAttributeCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00007688 File Offset: 0x00005888
		public uint GetIndexStartImpl(int submesh)
		{
			return Mesh.GetIndexStartImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000769B File Offset: 0x0000589B
		public uint GetIndexCountImpl(int submesh)
		{
			return Mesh.GetIndexCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000076AE File Offset: 0x000058AE
		public uint GetTrianglesCountImpl(int submesh)
		{
			return Mesh.GetTrianglesCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000076C1 File Offset: 0x000058C1
		public uint GetBaseVertexImpl(int submesh)
		{
			return Mesh.GetBaseVertexImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002C4BC File Offset: 0x0002A6BC
		public Il2CppStructArray<int> GetTrianglesImpl(int submesh, bool applyBaseVertex)
		{
			IntPtr intPtr = Mesh.GetTrianglesImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh, applyBaseVertex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002C4EC File Offset: 0x0002A6EC
		public void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			Mesh.SetIndicesNativeArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh, topology, indicesFormat, indices, arrayStart, arraySize, calculateBounds, baseVertex);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000076D4 File Offset: 0x000058D4
		public void GetTrianglesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000076EE File Offset: 0x000058EE
		public void GetTrianglesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007708 File Offset: 0x00005908
		public void GetIndicesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00007722 File Offset: 0x00005922
		public void GetIndicesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000773C File Offset: 0x0000593C
		public int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr)
		{
			return Mesh.GetVertexAttributeDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), attr);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000774F File Offset: 0x0000594F
		public UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr)
		{
			return Mesh.GetVertexAttributeFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), attr);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002C518 File Offset: 0x0002A718
		public void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetNativeArrayForChannelImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), channel, format, dim, values, arraySize, valuesStart, valuesCount, flags);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00007762 File Offset: 0x00005962
		public int vertexBufferCount
		{
			get
			{
				return Mesh.get_vertexBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00007774 File Offset: 0x00005974
		public IntPtr GetNativeVertexBufferPtr(int index)
		{
			return Mesh.GetNativeVertexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00007787 File Offset: 0x00005987
		public IntPtr GetNativeIndexBufferPtr()
		{
			return Mesh.GetNativeIndexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00007799 File Offset: 0x00005999
		public int blendShapeCount
		{
			get
			{
				return Mesh.get_blendShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000077AB File Offset: 0x000059AB
		public void ClearBlendShapes()
		{
			Mesh.ClearBlendShapesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002C544 File Offset: 0x0002A744
		public string GetBlendShapeName(int shapeIndex)
		{
			IntPtr intPtr = Mesh.GetBlendShapeNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000077BD File Offset: 0x000059BD
		public int GetBlendShapeIndex(string blendShapeName)
		{
			return Mesh.GetBlendShapeIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(blendShapeName));
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000077D5 File Offset: 0x000059D5
		public int GetBlendShapeFrameCount(int shapeIndex)
		{
			return Mesh.GetBlendShapeFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000077E8 File Offset: 0x000059E8
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
		{
			return Mesh.GetBlendShapeFrameWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000077FC File Offset: 0x000059FC
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.GetBlendShapeFrameVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00007824 File Offset: 0x00005A24
		public void AddBlendShapeFrame(string shapeName, float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.AddBlendShapeFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(shapeName), frameWeight, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00007851 File Offset: 0x00005A51
		public bool HasBoneWeights()
		{
			return Mesh.HasBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00007863 File Offset: 0x00005A63
		public void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize)
		{
			Mesh.InternalSetBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bonesPerVertex, bonesPerVertexSize, weights, weightsSize);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0002C56C File Offset: 0x0002A76C
		public unsafe Unity.Collections.NativeArray<byte> GetBonesPerVertex()
		{
			int num = (this.HasBoneWeights() ? this.vertexCount : 0);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>((void*)this.GetBonesPerVertexArray(), num, Unity.Collections.Allocator.None);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000787A File Offset: 0x00005A7A
		public int GetAllBoneWeightsArraySize()
		{
			return Mesh.GetAllBoneWeightsArraySizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000788C File Offset: 0x00005A8C
		public IntPtr GetAllBoneWeightsArray()
		{
			return Mesh.GetAllBoneWeightsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0000789E File Offset: 0x00005A9E
		public IntPtr GetBonesPerVertexArray()
		{
			return Mesh.GetBonesPerVertexArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000078B0 File Offset: 0x00005AB0
		public int GetBindposeCount()
		{
			return Mesh.GetBindposeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0002C5A4 File Offset: 0x0002A7A4
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x000078C2 File Offset: 0x00005AC2
		public Il2CppStructArray<Matrix4x4> bindposes
		{
			get
			{
				IntPtr intPtr = Mesh.get_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				Mesh.set_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000078DA File Offset: 0x00005ADA
		public void GetBindposesNonAllocImpl([Out] Il2CppStructArray<Matrix4x4> values)
		{
			Mesh.GetBindposesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x000078F2 File Offset: 0x00005AF2
		public bool isReadable
		{
			get
			{
				return Mesh.get_isReadableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00007917 File Offset: 0x00005B17
		public void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), desc, start, count, flags);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000792E File Offset: 0x00005B2E
		public void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.RecalculateNormalsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flags);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00007941 File Offset: 0x00005B41
		public void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.RecalculateTangentsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flags);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00007954 File Offset: 0x00005B54
		public void MarkModified()
		{
			Mesh.MarkModifiedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00007966 File Offset: 0x00005B66
		public void UploadMeshDataImpl(bool markNoLongerReadable)
		{
			Mesh.UploadMeshDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), markNoLongerReadable);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00007979 File Offset: 0x00005B79
		public MeshTopology GetTopologyImpl(int submesh)
		{
			return Mesh.GetTopologyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000798C File Offset: 0x00005B8C
		public void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex, uvAreaThreshold);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000079A0 File Offset: 0x00005BA0
		public void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvAreaThreshold);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000079B3 File Offset: 0x00005BB3
		public float GetUVDistributionMetric(int uvSetIndex)
		{
			return Mesh.GetUVDistributionMetricDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000079C6 File Offset: 0x00005BC6
		public void OptimizeImpl()
		{
			Mesh.OptimizeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000079D8 File Offset: 0x00005BD8
		public void OptimizeIndexBuffersImpl()
		{
			Mesh.OptimizeIndexBuffersImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000079EA File Offset: 0x00005BEA
		public void OptimizeReorderVertexBufferImpl()
		{
			Mesh.OptimizeReorderVertexBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002C5D0 File Offset: 0x0002A7D0
		public void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				bool flag = valuesStart < 0;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start index can't be negative.");
				}
				bool flag2 = valuesCount < 0;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesCount, "Mesh data array length can't be negative.");
				}
				bool flag3 = valuesStart >= valuesArrayLength && valuesCount != 0;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start is outside of array size.");
				}
				bool flag4 = valuesStart + valuesCount > valuesArrayLength;
				if (flag4)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesStart + valuesCount, "Mesh data array start+count is outside of array size.");
				}
				this.SetNativeArrayForChannelImpl(channel, format, dim, values, valuesArrayLength, valuesStart, valuesCount, flags);
			}
			else
			{
				this.PrintErrorCantAccessChannel(channel);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000079FC File Offset: 0x00005BFC
		public Il2CppStructArray<Vector2> uv3
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00007A09 File Offset: 0x00005C09
		public Il2CppStructArray<Vector2> uv4
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002C710 File Offset: 0x0002A910
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00007A16 File Offset: 0x00005C16
		public Il2CppStructArray<Vector2> uv5
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0002C72C File Offset: 0x0002A92C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00007A23 File Offset: 0x00005C23
		public Il2CppStructArray<Vector2> uv6
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002C748 File Offset: 0x0002A948
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00007A31 File Offset: 0x00005C31
		public Il2CppStructArray<Vector2> uv7
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0002C764 File Offset: 0x0002A964
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00007A3F File Offset: 0x00005C3F
		public Il2CppStructArray<Vector2> uv8
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0002C780 File Offset: 0x0002A980
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00007A4D File Offset: 0x00005C4D
		public Il2CppStructArray<Color> colors
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color);
			}
			set
			{
				this.SetArrayForChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002C79C File Offset: 0x0002A99C
		public void GetVertices(List<Vector3> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices", "The result vertices list cannot be null.");
			}
			this.GetListForChannel<Vector3>(vertices, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Position, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Position));
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00007A5A File Offset: 0x00005C5A
		public void SetVertices(Il2CppStructArray<Vector3> inVertices)
		{
			this.SetVertices(inVertices, 0, NoAllocHelpers.SafeLength(inVertices));
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00007A6C File Offset: 0x00005C6C
		public void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length)
		{
			this.SetVertices(inVertices, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		public void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Position, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Position), inVertices, NoAllocHelpers.SafeLength(inVertices), start, length, flags);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00007A7A File Offset: 0x00005C7A
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices) where T : struct
		{
			this.SetVertices<T>(inVertices, 0, inVertices.Length);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00007A8D File Offset: 0x00005C8D
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length) where T : struct
		{
			this.SetVertices<T>(inVertices, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002C800 File Offset: 0x0002AA00
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetVertices with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Position, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inVertices.GetUnsafeReadOnlyPtr<T>(), inVertices.Length, start, length, flags);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002C84C File Offset: 0x0002AA4C
		public void GetNormals(List<Vector3> normals)
		{
			bool flag = normals == null;
			if (flag)
			{
				throw new ArgumentNullException("normals", "The result normals list cannot be null.");
			}
			this.GetListForChannel<Vector3>(normals, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Normal, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Normal));
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00007A9B File Offset: 0x00005C9B
		public void SetNormals(Il2CppStructArray<Vector3> inNormals)
		{
			this.SetNormals(inNormals, 0, NoAllocHelpers.SafeLength(inNormals));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00007AAD File Offset: 0x00005CAD
		public void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length)
		{
			this.SetNormals(inNormals, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002C888 File Offset: 0x0002AA88
		public void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Normal, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Normal), inNormals, NoAllocHelpers.SafeLength(inNormals), start, length, flags);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00007ABB File Offset: 0x00005CBB
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals) where T : struct
		{
			this.SetNormals<T>(inNormals, 0, inNormals.Length);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00007ACE File Offset: 0x00005CCE
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length) where T : struct
		{
			this.SetNormals<T>(inNormals, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetNormals with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Normal, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inNormals.GetUnsafeReadOnlyPtr<T>(), inNormals.Length, start, length, flags);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0002C8FC File Offset: 0x0002AAFC
		public void GetTangents(List<Vector4> tangents)
		{
			bool flag = tangents == null;
			if (flag)
			{
				throw new ArgumentNullException("tangents", "The result tangents list cannot be null.");
			}
			this.GetListForChannel<Vector4>(tangents, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Tangent, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Tangent));
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00007ADC File Offset: 0x00005CDC
		public void SetTangents(Il2CppStructArray<Vector4> inTangents)
		{
			this.SetTangents(inTangents, 0, NoAllocHelpers.SafeLength(inTangents));
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00007AEE File Offset: 0x00005CEE
		public void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length)
		{
			this.SetTangents(inTangents, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002C938 File Offset: 0x0002AB38
		public void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Tangent, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Tangent), inTangents, NoAllocHelpers.SafeLength(inTangents), start, length, flags);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00007AFC File Offset: 0x00005CFC
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents) where T : struct
		{
			this.SetTangents<T>(inTangents, 0, inTangents.Length);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00007B0F File Offset: 0x00005D0F
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length) where T : struct
		{
			this.SetTangents<T>(inTangents, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002C960 File Offset: 0x0002AB60
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 16;
			if (flag)
			{
				throw new ArgumentException("SetTangents with NativeArray should use struct type that is 16 bytes (4x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Tangent, UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inTangents.GetUnsafeReadOnlyPtr<T>(), inTangents.Length, start, length, flags);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002C9AC File Offset: 0x0002ABAC
		public void GetColors(List<Color> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color));
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00007B1D File Offset: 0x00005D1D
		public void SetColors(List<Color> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength<Color>(inColors));
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00007B2F File Offset: 0x00005D2F
		public void SetColors(List<Color> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00007B3D File Offset: 0x00005D3D
		public void SetColors(List<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetListForChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color, inColors, start, length, flags);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00007B4D File Offset: 0x00005D4D
		public void SetColors(Il2CppStructArray<Color> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00007B5F File Offset: 0x00005D5F
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color), inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002CA10 File Offset: 0x0002AC10
		public void GetColors(List<Color32> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color32>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, 4, UnityEngine.Rendering.VertexAttributeFormat.UNorm8);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00007B6D File Offset: 0x00005D6D
		public void SetColors(Il2CppStructArray<Color32> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00007B7F File Offset: 0x00005D7F
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002CA48 File Offset: 0x0002AC48
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.UNorm8, 4, inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00007B8D File Offset: 0x00005D8D
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors) where T : struct
		{
			this.SetColors<T>(inColors, 0, inColors.Length);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length) where T : struct
		{
			this.SetColors<T>(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag = num != 16 && num != 4;
			if (flag)
			{
				throw new ArgumentException("SetColors with NativeArray should use struct type that is 16 bytes (4x float) or 4 bytes (4x unorm) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, (num == 4) ? UnityEngine.Rendering.VertexAttributeFormat.UNorm8 : UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inColors.GetUnsafeReadOnlyPtr<T>(), inColors.Length, start, length, flags);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00007BAE File Offset: 0x00005DAE
		public void SetUVs(int channel, List<Vector2> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength<Vector2>(uvs));
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00007BC1 File Offset: 0x00005DC1
		public void SetUVs(int channel, List<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength<Vector3>(uvs));
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00007BD4 File Offset: 0x00005DD4
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00007BE4 File Offset: 0x00005DE4
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl<Vector2>(channel, 2, uvs, start, length, flags);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00007BF6 File Offset: 0x00005DF6
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00007C06 File Offset: 0x00005E06
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl<Vector3>(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		public void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool flag = uvIndex < 0 || uvIndex > 7;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("uvIndex", uvIndex, "The uv index is invalid. Must be in the range 0 to 7.");
			}
			this.SetSizedArrayForChannel(Mesh.GetUVChannel(uvIndex), UnityEngine.Rendering.VertexAttributeFormat.Float32, dim, uvs, NoAllocHelpers.SafeLength(uvs), arrayStart, arraySize, flags);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00007C18 File Offset: 0x00005E18
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00007C2B File Offset: 0x00005E2B
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00007C3E File Offset: 0x00005E3E
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00007C51 File Offset: 0x00005E51
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00007C61 File Offset: 0x00005E61
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 2, uvs, start, length, flags);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00007C73 File Offset: 0x00005E73
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00007C83 File Offset: 0x00005E83
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00007C95 File Offset: 0x00005E95
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 4, uvs, start, length, flags);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00007CB7 File Offset: 0x00005EB7
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs) where T : struct
		{
			this.SetUVs<T>(channel, uvs, 0, uvs.Length);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00007CCB File Offset: 0x00005ECB
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length) where T : struct
		{
			this.SetUVs<T>(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002CB18 File Offset: 0x0002AD18
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = channel < 0 || channel > 7;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("channel", channel, "The uv index is invalid. Must be in the range 0 to 7.");
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag2 = (num & 3) != 0;
			if (flag2)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is multiple of 4 bytes in size");
			}
			int num2 = num / 4;
			bool flag3 = num2 < 1 || num2 > 4;
			if (flag3)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is 1..4 floats in size");
			}
			this.SetSizedNativeArrayForChannel(Mesh.GetUVChannel(channel), UnityEngine.Rendering.VertexAttributeFormat.Float32, num2, (IntPtr)uvs.GetUnsafeReadOnlyPtr<T>(), uvs.Length, start, length, flags);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00007CDB File Offset: 0x00005EDB
		public void GetUVs(int channel, List<Vector2> uvs)
		{
			this.GetUVsImpl<Vector2>(channel, uvs, 2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public void GetUVs(int channel, List<Vector3> uvs)
		{
			this.GetUVsImpl<Vector3>(channel, uvs, 3);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		public int vertexAttributeCount
		{
			get
			{
				return this.GetVertexAttributeCountImpl();
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		public void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferData(stream, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002CC60 File Offset: 0x0002AE60
		public void SetVertexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Array passed to SetVertexBufferData must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferDataFromArray(stream, data, dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002CD14 File Offset: 0x0002AF14
		public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetVertexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferDataFromArray(stream, NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		public Il2CppStructArray<int> GetTriangles(int submesh)
		{
			return this.GetTriangles(submesh, true);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00007D02 File Offset: 0x00005F02
		public Il2CppStructArray<int> GetTriangles(int submesh, bool applyBaseVertex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00007D0F File Offset: 0x00005F0F
		public void GetTriangles(List<int> triangles, int submesh)
		{
			this.GetTriangles(triangles, submesh, true);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
		public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002CE5C File Offset: 0x0002B05C
		public void GetTriangles(List<ushort> triangles, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00007D1C File Offset: 0x00005F1C
		public void GetIndices(List<int> indices, int submesh)
		{
			this.GetIndices(indices, submesh, true);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
		public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002CF2C File Offset: 0x0002B12C
		public void GetIndices(List<ushort> indices, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002CF94 File Offset: 0x0002B194
		public void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002D01C File Offset: 0x0002B21C
		public void SetIndexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
				if (flag2)
				{
					throw new ArgumentException(String.Concat("Array passed to SetIndexBufferData must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
				}
				bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferDataFromArray(data, dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
				if (flag2)
				{
					throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetIndexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
				}
				bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferDataFromArray(NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002D170 File Offset: 0x0002B370
		public uint GetIndexStart(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			if (flag)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			return this.GetIndexStartImpl(submesh);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002D1AC File Offset: 0x0002B3AC
		public uint GetIndexCount(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			if (flag)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			return this.GetIndexCountImpl(submesh);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		public uint GetBaseVertex(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			if (flag)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			return this.GetBaseVertexImpl(submesh);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00007D29 File Offset: 0x00005F29
		public void SetTriangles(Il2CppStructArray<int> triangles, int submesh)
		{
			this.SetTriangles(triangles, submesh, true, 0);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00007D37 File Offset: 0x00005F37
		public void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds)
		{
			this.SetTriangles(triangles, submesh, calculateBounds, 0);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00007D45 File Offset: 0x00005F45
		public void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002D224 File Offset: 0x0002B424
		public void SetTriangles(Il2CppStructArray<int> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt32, triangles, NoAllocHelpers.SafeLength(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00007D5B File Offset: 0x00005F5B
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002D258 File Offset: 0x0002B458
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, triangles, NoAllocHelpers.SafeLength(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00007D71 File Offset: 0x00005F71
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			this.SetTriangles(triangles, submesh, calculateBounds, 0);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00007D7F File Offset: 0x00005F7F
		public void SetTriangles(List<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength<ushort>(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002D28C File Offset: 0x0002B48C
		public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, NoAllocHelpers.ExtractArrayFromList(triangles), NoAllocHelpers.SafeLength<ushort>(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00007D95 File Offset: 0x00005F95
		public void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh)
		{
			this.SetIndices(indices, topology, submesh, true, 0);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00007DA4 File Offset: 0x00005FA4
		public void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
			this.SetIndices(indices, topology, submesh, calculateBounds, 0);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
		public void SetIndices(Il2CppStructArray<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt32, indices, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00007DCC File Offset: 0x00005FCC
		public void SetIndices(Il2CppStructArray<ushort> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002D304 File Offset: 0x0002B504
		public void SetIndices(Il2CppStructArray<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt16, indices, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00007DE4 File Offset: 0x00005FE4
		public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex) where T : struct
		{
			this.SetIndices<T>(indices, 0, indices.Length, topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002D344 File Offset: 0x0002B544
		public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex) where T : struct
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
				bool flag2 = num != 2 && num != 4;
				if (flag2)
				{
					throw new ArgumentException("SetIndices with NativeArray should use type is 2 or 4 bytes in size");
				}
				this.CheckIndicesArrayRange(indices.Length, indicesStart, indicesLength);
				this.SetIndicesNativeArrayImpl(submesh, topology, (num == 2) ? UnityEngine.Rendering.IndexFormat.UInt16 : UnityEngine.Rendering.IndexFormat.UInt32, (IntPtr)indices.GetUnsafeReadOnlyPtr<T>(), indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00007DFD File Offset: 0x00005FFD
		public void SetIndices(List<int> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength<int>(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002D3B8 File Offset: 0x0002B5B8
		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				Array array = NoAllocHelpers.ExtractArrayFromList(indices);
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength<int>(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt32, array, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00007E15 File Offset: 0x00006015
		public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength<ushort>(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002D400 File Offset: 0x0002B600
		public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				Array array = NoAllocHelpers.ExtractArrayFromList(indices);
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength<ushort>(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt16, array, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00007E2D File Offset: 0x0000602D
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00007E3A File Offset: 0x0000603A
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			this.SetSubMeshes<T>(desc, 0, desc.Length, flags);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002D448 File Offset: 0x0002B648
		public void GetBindposes(List<Matrix4x4> bindposes)
		{
			bool flag = bindposes == null;
			if (flag)
			{
				throw new ArgumentNullException("bindposes", "The result bindposes list cannot be null.");
			}
			NoAllocHelpers.EnsureListElemCount<Matrix4x4>(bindposes, this.GetBindposeCount());
			this.GetBindposesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(bindposes));
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00007E4E File Offset: 0x0000604E
		public void Clear(bool keepVertexLayout)
		{
			this.ClearImpl(keepVertexLayout);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00007E59 File Offset: 0x00006059
		public void RecalculateNormals()
		{
			this.RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00007E64 File Offset: 0x00006064
		public void RecalculateTangents()
		{
			this.RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002D488 File Offset: 0x0002B688
		public void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateNormalsImpl(flags);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateNormals() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0002D4C0 File Offset: 0x0002B6C0
		public void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateTangentsImpl(flags);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateTangents() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		public void RecalculateUVDistributionMetric(int uvSetIndex, [Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricImpl(uvSetIndex, uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetric() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0002D534 File Offset: 0x0002B734
		public void RecalculateUVDistributionMetrics([Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricsImpl(uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetrics() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0002D56C File Offset: 0x0002B76C
		public void UploadMeshData(bool markNoLongerReadable)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.UploadMeshDataImpl(markNoLongerReadable);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002D58C File Offset: 0x0002B78C
		public void Optimize()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call Optimize() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
		public void OptimizeIndexBuffers()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeIndexBuffersImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeIndexBuffers() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		public void OptimizeReorderVertexBuffer()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeReorderVertexBufferImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeReorderVertexBuffer() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002D634 File Offset: 0x0002B834
		public MeshTopology GetTopology(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			MeshTopology meshTopology;
			if (flag)
			{
				Debug.LogError("Failed getting topology. Submesh index is out of bounds.", this);
				meshTopology = MeshTopology.Triangles;
			}
			else
			{
				meshTopology = this.GetTopologyImpl(submesh);
			}
			return meshTopology;
		}

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamic_Public_Void_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly Mesh.FromInstanceIDDelegate FromInstanceIDDelegateField;

		// Token: 0x040006C1 RID: 1729
		private static readonly Mesh.get_indexFormatDelegate get_indexFormatDelegateField;

		// Token: 0x040006C2 RID: 1730
		private static readonly Mesh.set_indexFormatDelegate set_indexFormatDelegateField;

		// Token: 0x040006C3 RID: 1731
		private static readonly Mesh.GetTotalIndexCountDelegate GetTotalIndexCountDelegateField;

		// Token: 0x040006C4 RID: 1732
		private static readonly Mesh.SetIndexBufferParamsDelegate SetIndexBufferParamsDelegateField;

		// Token: 0x040006C5 RID: 1733
		private static readonly Mesh.InternalSetIndexBufferDataDelegate InternalSetIndexBufferDataDelegateField;

		// Token: 0x040006C6 RID: 1734
		private static readonly Mesh.InternalSetIndexBufferDataFromArrayDelegate InternalSetIndexBufferDataFromArrayDelegateField;

		// Token: 0x040006C7 RID: 1735
		private static readonly Mesh.SetVertexBufferParamsFromPtrDelegate SetVertexBufferParamsFromPtrDelegateField;

		// Token: 0x040006C8 RID: 1736
		private static readonly Mesh.InternalSetVertexBufferDataDelegate InternalSetVertexBufferDataDelegateField;

		// Token: 0x040006C9 RID: 1737
		private static readonly Mesh.InternalSetVertexBufferDataFromArrayDelegate InternalSetVertexBufferDataFromArrayDelegateField;

		// Token: 0x040006CA RID: 1738
		private static readonly Mesh.GetVertexAttributesAllocDelegate GetVertexAttributesAllocDelegateField;

		// Token: 0x040006CB RID: 1739
		private static readonly Mesh.GetVertexAttributeCountImplDelegate GetVertexAttributeCountImplDelegateField;

		// Token: 0x040006CC RID: 1740
		private static readonly Mesh.GetIndexStartImplDelegate GetIndexStartImplDelegateField;

		// Token: 0x040006CD RID: 1741
		private static readonly Mesh.GetIndexCountImplDelegate GetIndexCountImplDelegateField;

		// Token: 0x040006CE RID: 1742
		private static readonly Mesh.GetTrianglesCountImplDelegate GetTrianglesCountImplDelegateField;

		// Token: 0x040006CF RID: 1743
		private static readonly Mesh.GetBaseVertexImplDelegate GetBaseVertexImplDelegateField;

		// Token: 0x040006D0 RID: 1744
		private static readonly Mesh.GetTrianglesImplDelegate GetTrianglesImplDelegateField;

		// Token: 0x040006D1 RID: 1745
		private static readonly Mesh.SetIndicesNativeArrayImplDelegate SetIndicesNativeArrayImplDelegateField;

		// Token: 0x040006D2 RID: 1746
		private static readonly Mesh.GetTrianglesNonAllocImplDelegate GetTrianglesNonAllocImplDelegateField;

		// Token: 0x040006D3 RID: 1747
		private static readonly Mesh.GetTrianglesNonAllocImpl16Delegate GetTrianglesNonAllocImpl16DelegateField;

		// Token: 0x040006D4 RID: 1748
		private static readonly Mesh.GetIndicesNonAllocImplDelegate GetIndicesNonAllocImplDelegateField;

		// Token: 0x040006D5 RID: 1749
		private static readonly Mesh.GetIndicesNonAllocImpl16Delegate GetIndicesNonAllocImpl16DelegateField;

		// Token: 0x040006D6 RID: 1750
		private static readonly Mesh.GetVertexAttributeDimensionDelegate GetVertexAttributeDimensionDelegateField;

		// Token: 0x040006D7 RID: 1751
		private static readonly Mesh.GetVertexAttributeFormatDelegate GetVertexAttributeFormatDelegateField;

		// Token: 0x040006D8 RID: 1752
		private static readonly Mesh.SetNativeArrayForChannelImplDelegate SetNativeArrayForChannelImplDelegateField;

		// Token: 0x040006D9 RID: 1753
		private static readonly Mesh.get_vertexBufferCountDelegate get_vertexBufferCountDelegateField;

		// Token: 0x040006DA RID: 1754
		private static readonly Mesh.GetNativeVertexBufferPtrDelegate GetNativeVertexBufferPtrDelegateField;

		// Token: 0x040006DB RID: 1755
		private static readonly Mesh.GetNativeIndexBufferPtrDelegate GetNativeIndexBufferPtrDelegateField;

		// Token: 0x040006DC RID: 1756
		private static readonly Mesh.get_blendShapeCountDelegate get_blendShapeCountDelegateField;

		// Token: 0x040006DD RID: 1757
		private static readonly Mesh.ClearBlendShapesDelegate ClearBlendShapesDelegateField;

		// Token: 0x040006DE RID: 1758
		private static readonly Mesh.GetBlendShapeNameDelegate GetBlendShapeNameDelegateField;

		// Token: 0x040006DF RID: 1759
		private static readonly Mesh.GetBlendShapeIndexDelegate GetBlendShapeIndexDelegateField;

		// Token: 0x040006E0 RID: 1760
		private static readonly Mesh.GetBlendShapeFrameCountDelegate GetBlendShapeFrameCountDelegateField;

		// Token: 0x040006E1 RID: 1761
		private static readonly Mesh.GetBlendShapeFrameWeightDelegate GetBlendShapeFrameWeightDelegateField;

		// Token: 0x040006E2 RID: 1762
		private static readonly Mesh.GetBlendShapeFrameVerticesDelegate GetBlendShapeFrameVerticesDelegateField;

		// Token: 0x040006E3 RID: 1763
		private static readonly Mesh.AddBlendShapeFrameDelegate AddBlendShapeFrameDelegateField;

		// Token: 0x040006E4 RID: 1764
		private static readonly Mesh.HasBoneWeightsDelegate HasBoneWeightsDelegateField;

		// Token: 0x040006E5 RID: 1765
		private static readonly Mesh.InternalSetBoneWeightsDelegate InternalSetBoneWeightsDelegateField;

		// Token: 0x040006E6 RID: 1766
		private static readonly Mesh.GetAllBoneWeightsArraySizeDelegate GetAllBoneWeightsArraySizeDelegateField;

		// Token: 0x040006E7 RID: 1767
		private static readonly Mesh.GetAllBoneWeightsArrayDelegate GetAllBoneWeightsArrayDelegateField;

		// Token: 0x040006E8 RID: 1768
		private static readonly Mesh.GetBonesPerVertexArrayDelegate GetBonesPerVertexArrayDelegateField;

		// Token: 0x040006E9 RID: 1769
		private static readonly Mesh.GetBindposeCountDelegate GetBindposeCountDelegateField;

		// Token: 0x040006EA RID: 1770
		private static readonly Mesh.get_bindposesDelegate get_bindposesDelegateField;

		// Token: 0x040006EB RID: 1771
		private static readonly Mesh.set_bindposesDelegate set_bindposesDelegateField;

		// Token: 0x040006EC RID: 1772
		private static readonly Mesh.GetBindposesNonAllocImplDelegate GetBindposesNonAllocImplDelegateField;

		// Token: 0x040006ED RID: 1773
		private static readonly Mesh.get_isReadableDelegate get_isReadableDelegateField;

		// Token: 0x040006EE RID: 1774
		private static readonly Mesh.set_subMeshCountDelegate set_subMeshCountDelegateField;

		// Token: 0x040006EF RID: 1775
		private static readonly Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate SetAllSubMeshesAtOnceFromNativeArrayDelegateField;

		// Token: 0x040006F0 RID: 1776
		private static readonly Mesh.RecalculateNormalsImplDelegate RecalculateNormalsImplDelegateField;

		// Token: 0x040006F1 RID: 1777
		private static readonly Mesh.RecalculateTangentsImplDelegate RecalculateTangentsImplDelegateField;

		// Token: 0x040006F2 RID: 1778
		private static readonly Mesh.MarkModifiedDelegate MarkModifiedDelegateField;

		// Token: 0x040006F3 RID: 1779
		private static readonly Mesh.UploadMeshDataImplDelegate UploadMeshDataImplDelegateField;

		// Token: 0x040006F4 RID: 1780
		private static readonly Mesh.GetTopologyImplDelegate GetTopologyImplDelegateField;

		// Token: 0x040006F5 RID: 1781
		private static readonly Mesh.RecalculateUVDistributionMetricImplDelegate RecalculateUVDistributionMetricImplDelegateField;

		// Token: 0x040006F6 RID: 1782
		private static readonly Mesh.RecalculateUVDistributionMetricsImplDelegate RecalculateUVDistributionMetricsImplDelegateField;

		// Token: 0x040006F7 RID: 1783
		private static readonly Mesh.GetUVDistributionMetricDelegate GetUVDistributionMetricDelegateField;

		// Token: 0x040006F8 RID: 1784
		private static readonly Mesh.OptimizeImplDelegate OptimizeImplDelegateField;

		// Token: 0x040006F9 RID: 1785
		private static readonly Mesh.OptimizeIndexBuffersImplDelegate OptimizeIndexBuffersImplDelegateField;

		// Token: 0x040006FA RID: 1786
		private static readonly Mesh.OptimizeReorderVertexBufferImplDelegate OptimizeReorderVertexBufferImplDelegateField;

		// Token: 0x0200061E RID: 1566
		[StructLayout(2)]
		public struct MeshData
		{
			// Token: 0x06002A0A RID: 10762 RVA: 0x0001532E File Offset: 0x0001352E
			// Note: this type is marked as 'beforefieldinit'.
			static MeshData()
			{
				Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "MeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr);
				Mesh.MeshData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, "m_Ptr");
			}

			// Token: 0x06002A0B RID: 10763 RVA: 0x00015362 File Offset: 0x00013562
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, ref this));
			}

			// Token: 0x04001C66 RID: 7270
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04001C67 RID: 7271
			[FieldOffset(0)]
			public IntPtr m_Ptr;
		}

		// Token: 0x0200061F RID: 1567
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>
		{
			// Token: 0x04001C68 RID: 7272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000620 RID: 1568
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>
		{
			// Token: 0x04001C69 RID: 7273
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000621 RID: 1569
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001C6A RID: 7274
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000622 RID: 1570
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001C6B RID: 7275
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000623 RID: 1571
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001C6C RID: 7276
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000624 RID: 1572
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001C6D RID: 7277
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000625 RID: 1573
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>
		{
			// Token: 0x04001C6E RID: 7278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000626 RID: 1574
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>
		{
			// Token: 0x04001C6F RID: 7279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000627 RID: 1575
		private sealed class MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001C70 RID: 7280
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000628 RID: 1576
		private sealed class MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>
		{
			// Token: 0x04001C71 RID: 7281
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000629 RID: 1577
		// (Invoke) Token: 0x06002A17 RID: 10775
		private delegate IntPtr FromInstanceIDDelegate(int id);

		// Token: 0x0200062A RID: 1578
		// (Invoke) Token: 0x06002A19 RID: 10777
		private delegate UnityEngine.Rendering.IndexFormat get_indexFormatDelegate(IntPtr @this);

		// Token: 0x0200062B RID: 1579
		// (Invoke) Token: 0x06002A1B RID: 10779
		private delegate void set_indexFormatDelegate(IntPtr @this, UnityEngine.Rendering.IndexFormat value);

		// Token: 0x0200062C RID: 1580
		// (Invoke) Token: 0x06002A1D RID: 10781
		private delegate uint GetTotalIndexCountDelegate(IntPtr @this);

		// Token: 0x0200062D RID: 1581
		// (Invoke) Token: 0x06002A1F RID: 10783
		private delegate void SetIndexBufferParamsDelegate(IntPtr @this, int indexCount, UnityEngine.Rendering.IndexFormat format);

		// Token: 0x0200062E RID: 1582
		// (Invoke) Token: 0x06002A21 RID: 10785
		private delegate void InternalSetIndexBufferDataDelegate(IntPtr @this, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x0200062F RID: 1583
		// (Invoke) Token: 0x06002A23 RID: 10787
		private delegate void InternalSetIndexBufferDataFromArrayDelegate(IntPtr @this, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000630 RID: 1584
		// (Invoke) Token: 0x06002A25 RID: 10789
		private delegate void SetVertexBufferParamsFromPtrDelegate(IntPtr @this, int vertexCount, IntPtr attributesPtr, int attributesCount);

		// Token: 0x02000631 RID: 1585
		// (Invoke) Token: 0x06002A27 RID: 10791
		private delegate void InternalSetVertexBufferDataDelegate(IntPtr @this, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000632 RID: 1586
		// (Invoke) Token: 0x06002A29 RID: 10793
		private delegate void InternalSetVertexBufferDataFromArrayDelegate(IntPtr @this, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000633 RID: 1587
		// (Invoke) Token: 0x06002A2B RID: 10795
		private delegate IntPtr GetVertexAttributesAllocDelegate(IntPtr @this);

		// Token: 0x02000634 RID: 1588
		// (Invoke) Token: 0x06002A2D RID: 10797
		private delegate int GetVertexAttributeCountImplDelegate(IntPtr @this);

		// Token: 0x02000635 RID: 1589
		// (Invoke) Token: 0x06002A2F RID: 10799
		private delegate uint GetIndexStartImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000636 RID: 1590
		// (Invoke) Token: 0x06002A31 RID: 10801
		private delegate uint GetIndexCountImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000637 RID: 1591
		// (Invoke) Token: 0x06002A33 RID: 10803
		private delegate uint GetTrianglesCountImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000638 RID: 1592
		// (Invoke) Token: 0x06002A35 RID: 10805
		private delegate uint GetBaseVertexImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000639 RID: 1593
		// (Invoke) Token: 0x06002A37 RID: 10807
		private delegate IntPtr GetTrianglesImplDelegate(IntPtr @this, int submesh, bool applyBaseVertex);

		// Token: 0x0200063A RID: 1594
		// (Invoke) Token: 0x06002A39 RID: 10809
		private delegate void SetIndicesNativeArrayImplDelegate(IntPtr @this, int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);

		// Token: 0x0200063B RID: 1595
		// (Invoke) Token: 0x06002A3B RID: 10811
		private delegate void GetTrianglesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200063C RID: 1596
		// (Invoke) Token: 0x06002A3D RID: 10813
		private delegate void GetTrianglesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200063D RID: 1597
		// (Invoke) Token: 0x06002A3F RID: 10815
		private delegate void GetIndicesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200063E RID: 1598
		// (Invoke) Token: 0x06002A41 RID: 10817
		private delegate void GetIndicesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200063F RID: 1599
		// (Invoke) Token: 0x06002A43 RID: 10819
		private delegate int GetVertexAttributeDimensionDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute attr);

		// Token: 0x02000640 RID: 1600
		// (Invoke) Token: 0x06002A45 RID: 10821
		private delegate UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormatDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute attr);

		// Token: 0x02000641 RID: 1601
		// (Invoke) Token: 0x06002A47 RID: 10823
		private delegate void SetNativeArrayForChannelImplDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000642 RID: 1602
		// (Invoke) Token: 0x06002A49 RID: 10825
		private delegate int get_vertexBufferCountDelegate(IntPtr @this);

		// Token: 0x02000643 RID: 1603
		// (Invoke) Token: 0x06002A4B RID: 10827
		private delegate IntPtr GetNativeVertexBufferPtrDelegate(IntPtr @this, int index);

		// Token: 0x02000644 RID: 1604
		// (Invoke) Token: 0x06002A4D RID: 10829
		private delegate IntPtr GetNativeIndexBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000645 RID: 1605
		// (Invoke) Token: 0x06002A4F RID: 10831
		private delegate int get_blendShapeCountDelegate(IntPtr @this);

		// Token: 0x02000646 RID: 1606
		// (Invoke) Token: 0x06002A51 RID: 10833
		private delegate void ClearBlendShapesDelegate(IntPtr @this);

		// Token: 0x02000647 RID: 1607
		// (Invoke) Token: 0x06002A53 RID: 10835
		private delegate IntPtr GetBlendShapeNameDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x02000648 RID: 1608
		// (Invoke) Token: 0x06002A55 RID: 10837
		private delegate int GetBlendShapeIndexDelegate(IntPtr @this, IntPtr blendShapeName);

		// Token: 0x02000649 RID: 1609
		// (Invoke) Token: 0x06002A57 RID: 10839
		private delegate int GetBlendShapeFrameCountDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x0200064A RID: 1610
		// (Invoke) Token: 0x06002A59 RID: 10841
		private delegate float GetBlendShapeFrameWeightDelegate(IntPtr @this, int shapeIndex, int frameIndex);

		// Token: 0x0200064B RID: 1611
		// (Invoke) Token: 0x06002A5B RID: 10843
		private delegate void GetBlendShapeFrameVerticesDelegate(IntPtr @this, int shapeIndex, int frameIndex, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x0200064C RID: 1612
		// (Invoke) Token: 0x06002A5D RID: 10845
		private delegate void AddBlendShapeFrameDelegate(IntPtr @this, IntPtr shapeName, float frameWeight, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x0200064D RID: 1613
		// (Invoke) Token: 0x06002A5F RID: 10847
		private delegate bool HasBoneWeightsDelegate(IntPtr @this);

		// Token: 0x0200064E RID: 1614
		// (Invoke) Token: 0x06002A61 RID: 10849
		private delegate void InternalSetBoneWeightsDelegate(IntPtr @this, IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize);

		// Token: 0x0200064F RID: 1615
		// (Invoke) Token: 0x06002A63 RID: 10851
		private delegate int GetAllBoneWeightsArraySizeDelegate(IntPtr @this);

		// Token: 0x02000650 RID: 1616
		// (Invoke) Token: 0x06002A65 RID: 10853
		private delegate IntPtr GetAllBoneWeightsArrayDelegate(IntPtr @this);

		// Token: 0x02000651 RID: 1617
		// (Invoke) Token: 0x06002A67 RID: 10855
		private delegate IntPtr GetBonesPerVertexArrayDelegate(IntPtr @this);

		// Token: 0x02000652 RID: 1618
		// (Invoke) Token: 0x06002A69 RID: 10857
		private delegate int GetBindposeCountDelegate(IntPtr @this);

		// Token: 0x02000653 RID: 1619
		// (Invoke) Token: 0x06002A6B RID: 10859
		private delegate IntPtr get_bindposesDelegate(IntPtr @this);

		// Token: 0x02000654 RID: 1620
		// (Invoke) Token: 0x06002A6D RID: 10861
		private delegate void set_bindposesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000655 RID: 1621
		// (Invoke) Token: 0x06002A6F RID: 10863
		private delegate void GetBindposesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values);

		// Token: 0x02000656 RID: 1622
		// (Invoke) Token: 0x06002A71 RID: 10865
		private delegate bool get_isReadableDelegate(IntPtr @this);

		// Token: 0x02000657 RID: 1623
		// (Invoke) Token: 0x06002A73 RID: 10867
		private delegate void set_subMeshCountDelegate(IntPtr @this, int value);

		// Token: 0x02000658 RID: 1624
		// (Invoke) Token: 0x06002A75 RID: 10869
		private delegate void SetAllSubMeshesAtOnceFromNativeArrayDelegate(IntPtr @this, IntPtr desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000659 RID: 1625
		// (Invoke) Token: 0x06002A77 RID: 10871
		private delegate void RecalculateNormalsImplDelegate(IntPtr @this, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x0200065A RID: 1626
		// (Invoke) Token: 0x06002A79 RID: 10873
		private delegate void RecalculateTangentsImplDelegate(IntPtr @this, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x0200065B RID: 1627
		// (Invoke) Token: 0x06002A7B RID: 10875
		private delegate void MarkModifiedDelegate(IntPtr @this);

		// Token: 0x0200065C RID: 1628
		// (Invoke) Token: 0x06002A7D RID: 10877
		private delegate void UploadMeshDataImplDelegate(IntPtr @this, bool markNoLongerReadable);

		// Token: 0x0200065D RID: 1629
		// (Invoke) Token: 0x06002A7F RID: 10879
		private delegate MeshTopology GetTopologyImplDelegate(IntPtr @this, int submesh);

		// Token: 0x0200065E RID: 1630
		// (Invoke) Token: 0x06002A81 RID: 10881
		private delegate void RecalculateUVDistributionMetricImplDelegate(IntPtr @this, int uvSetIndex, float uvAreaThreshold);

		// Token: 0x0200065F RID: 1631
		// (Invoke) Token: 0x06002A83 RID: 10883
		private delegate void RecalculateUVDistributionMetricsImplDelegate(IntPtr @this, float uvAreaThreshold);

		// Token: 0x02000660 RID: 1632
		// (Invoke) Token: 0x06002A85 RID: 10885
		private delegate float GetUVDistributionMetricDelegate(IntPtr @this, int uvSetIndex);

		// Token: 0x02000661 RID: 1633
		// (Invoke) Token: 0x06002A87 RID: 10887
		private delegate void OptimizeImplDelegate(IntPtr @this);

		// Token: 0x02000662 RID: 1634
		// (Invoke) Token: 0x06002A89 RID: 10889
		private delegate void OptimizeIndexBuffersImplDelegate(IntPtr @this);

		// Token: 0x02000663 RID: 1635
		// (Invoke) Token: 0x06002A8B RID: 10891
		private delegate void OptimizeReorderVertexBufferImplDelegate(IntPtr @this);
	}
}
