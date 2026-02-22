using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public sealed class CanvasRenderer : Component
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002718 File Offset: 0x00000918
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasRenderer()
		{
			Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "CanvasRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr);
			CanvasRenderer.NativeFieldInfoPtr__isMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, "<isMask>k__BackingField");
			CanvasRenderer.NativeMethodInfoPtr_set_hasPopInstruction_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663307);
			CanvasRenderer.NativeMethodInfoPtr_get_materialCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663308);
			CanvasRenderer.NativeMethodInfoPtr_set_materialCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663309);
			CanvasRenderer.NativeMethodInfoPtr_set_popMaterialCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663310);
			CanvasRenderer.NativeMethodInfoPtr_get_absoluteDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663311);
			CanvasRenderer.NativeMethodInfoPtr_get_hasMoved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663312);
			CanvasRenderer.NativeMethodInfoPtr_get_cullTransparentMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663313);
			CanvasRenderer.NativeMethodInfoPtr_set_cullTransparentMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663314);
			CanvasRenderer.NativeMethodInfoPtr_get_cull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663315);
			CanvasRenderer.NativeMethodInfoPtr_set_cull_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663316);
			CanvasRenderer.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663317);
			CanvasRenderer.NativeMethodInfoPtr_GetColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663318);
			CanvasRenderer.NativeMethodInfoPtr_EnableRectClipping_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663319);
			CanvasRenderer.NativeMethodInfoPtr_set_clippingSoftness_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663320);
			CanvasRenderer.NativeMethodInfoPtr_DisableRectClipping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663321);
			CanvasRenderer.NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663322);
			CanvasRenderer.NativeMethodInfoPtr_GetMaterial_Public_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663323);
			CanvasRenderer.NativeMethodInfoPtr_SetPopMaterial_Public_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663324);
			CanvasRenderer.NativeMethodInfoPtr_SetTexture_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663325);
			CanvasRenderer.NativeMethodInfoPtr_SetAlphaTexture_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663326);
			CanvasRenderer.NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663327);
			CanvasRenderer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663328);
			CanvasRenderer.NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663329);
			CanvasRenderer.NativeMethodInfoPtr_GetMaterial_Public_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663330);
			CanvasRenderer.NativeMethodInfoPtr_SplitUIVertexStreams_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663331);
			CanvasRenderer.NativeMethodInfoPtr_CreateUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663332);
			CanvasRenderer.NativeMethodInfoPtr_AddUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663333);
			CanvasRenderer.NativeMethodInfoPtr_SplitIndicesStreamsInternal_Private_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663334);
			CanvasRenderer.NativeMethodInfoPtr_SplitUIVertexStreamsInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663335);
			CanvasRenderer.NativeMethodInfoPtr_CreateUIVertexStreamInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663336);
			CanvasRenderer.NativeMethodInfoPtr_SetColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663337);
			CanvasRenderer.NativeMethodInfoPtr_GetColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663338);
			CanvasRenderer.NativeMethodInfoPtr_EnableRectClipping_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663339);
			CanvasRenderer.NativeMethodInfoPtr_set_clippingSoftness_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasRenderer>.NativeClassPtr, 100663340);
			CanvasRenderer.get_hasPopInstructionDelegateField = IL2CPP.ResolveICall<CanvasRenderer.get_hasPopInstructionDelegate>("UnityEngine.CanvasRenderer::get_hasPopInstruction");
			CanvasRenderer.get_popMaterialCountDelegateField = IL2CPP.ResolveICall<CanvasRenderer.get_popMaterialCountDelegate>("UnityEngine.CanvasRenderer::get_popMaterialCount");
			CanvasRenderer.get_hasRectClippingDelegateField = IL2CPP.ResolveICall<CanvasRenderer.get_hasRectClippingDelegate>("UnityEngine.CanvasRenderer::get_hasRectClipping");
			CanvasRenderer.get_relativeDepthDelegateField = IL2CPP.ResolveICall<CanvasRenderer.get_relativeDepthDelegate>("UnityEngine.CanvasRenderer::get_relativeDepth");
			CanvasRenderer.GetPopMaterialDelegateField = IL2CPP.ResolveICall<CanvasRenderer.GetPopMaterialDelegate>("UnityEngine.CanvasRenderer::GetPopMaterial");
			CanvasRenderer.GetInheritedAlphaDelegateField = IL2CPP.ResolveICall<CanvasRenderer.GetInheritedAlphaDelegate>("UnityEngine.CanvasRenderer::GetInheritedAlpha");
			CanvasRenderer.get_clippingSoftness_InjectedDelegateField = IL2CPP.ResolveICall<CanvasRenderer.get_clippingSoftness_InjectedDelegate>("UnityEngine.CanvasRenderer::get_clippingSoftness_Injected");
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000020B5 File Offset: 0x000002B5
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002A70 File Offset: 0x00000C70
		public unsafe bool hasPopInstruction
		{
			get
			{
				return CanvasRenderer.get_hasPopInstructionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97406, RefRangeEnd = 97409, XrefRangeStart = 97404, XrefRangeEnd = 97406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_hasPopInstruction_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002AB0 File Offset: 0x00000CB0
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002AEC File Offset: 0x00000CEC
		public unsafe int materialCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97409, XrefRangeEnd = 97411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_get_materialCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97413, RefRangeEnd = 97416, XrefRangeStart = 97411, XrefRangeEnd = 97413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_materialCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000020C7 File Offset: 0x000002C7
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002B2C File Offset: 0x00000D2C
		public unsafe int popMaterialCount
		{
			get
			{
				return CanvasRenderer.get_popMaterialCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97418, RefRangeEnd = 97420, XrefRangeStart = 97416, XrefRangeEnd = 97418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_popMaterialCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002B6C File Offset: 0x00000D6C
		public unsafe int absoluteDepth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97422, RefRangeEnd = 97425, XrefRangeStart = 97420, XrefRangeEnd = 97422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_get_absoluteDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public unsafe bool hasMoved
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97427, RefRangeEnd = 97428, XrefRangeStart = 97425, XrefRangeEnd = 97427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_get_hasMoved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002BE4 File Offset: 0x00000DE4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002C20 File Offset: 0x00000E20
		public unsafe bool cullTransparentMesh
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97430, RefRangeEnd = 97431, XrefRangeStart = 97428, XrefRangeEnd = 97430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_get_cullTransparentMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97433, RefRangeEnd = 97434, XrefRangeStart = 97431, XrefRangeEnd = 97433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_cullTransparentMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002C60 File Offset: 0x00000E60
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002C9C File Offset: 0x00000E9C
		public unsafe bool cull
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 97436, RefRangeEnd = 97442, XrefRangeStart = 97434, XrefRangeEnd = 97436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_get_cull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 97444, RefRangeEnd = 97449, XrefRangeStart = 97442, XrefRangeEnd = 97444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_cull_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002CDC File Offset: 0x00000EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97451, RefRangeEnd = 97452, XrefRangeStart = 97449, XrefRangeEnd = 97451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002D1C File Offset: 0x00000F1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 97454, RefRangeEnd = 97458, XrefRangeStart = 97452, XrefRangeEnd = 97454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_GetColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002D58 File Offset: 0x00000F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97460, RefRangeEnd = 97461, XrefRangeStart = 97458, XrefRangeEnd = 97460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableRectClipping(Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_EnableRectClipping_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003634 File Offset: 0x00001834
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002D98 File Offset: 0x00000F98
		public unsafe Vector2 clippingSoftness
		{
			get
			{
				Vector2 vector;
				this.get_clippingSoftness_Injected(out vector);
				return vector;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97463, RefRangeEnd = 97464, XrefRangeStart = 97461, XrefRangeEnd = 97463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_clippingSoftness_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97466, RefRangeEnd = 97467, XrefRangeStart = 97464, XrefRangeEnd = 97466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableRectClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_DisableRectClipping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002E0C File Offset: 0x0000100C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97469, RefRangeEnd = 97472, XrefRangeStart = 97467, XrefRangeEnd = 97469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material material, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002E5C File Offset: 0x0000105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97472, XrefRangeEnd = 97474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_GetMaterial_Public_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002EA8 File Offset: 0x000010A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97476, RefRangeEnd = 97477, XrefRangeStart = 97474, XrefRangeEnd = 97476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPopMaterial(Material material, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetPopMaterial_Public_Void_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002EF8 File Offset: 0x000010F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97479, RefRangeEnd = 97480, XrefRangeStart = 97477, XrefRangeEnd = 97479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetTexture_Public_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002F3C File Offset: 0x0000113C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97482, RefRangeEnd = 97483, XrefRangeStart = 97480, XrefRangeEnd = 97482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlphaTexture(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetAlphaTexture_Public_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F80 File Offset: 0x00001180
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 97485, RefRangeEnd = 97500, XrefRangeStart = 97483, XrefRangeEnd = 97485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002FC4 File Offset: 0x000011C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 97502, RefRangeEnd = 97506, XrefRangeStart = 97500, XrefRangeEnd = 97502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002FF8 File Offset: 0x000011F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 97518, RefRangeEnd = 97525, XrefRangeStart = 97506, XrefRangeEnd = 97518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material material, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000304C File Offset: 0x0000124C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97527, RefRangeEnd = 97528, XrefRangeStart = 97525, XrefRangeEnd = 97527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_GetMaterial_Public_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000308C File Offset: 0x0000128C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97532, RefRangeEnd = 97534, XrefRangeStart = 97528, XrefRangeEnd = 97532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv0S);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv1S);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv2S);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv3S);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SplitUIVertexStreams_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000316C File Offset: 0x0000136C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97536, RefRangeEnd = 97538, XrefRangeStart = 97534, XrefRangeEnd = 97536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv0S);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv1S);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv2S);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv3S);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_CreateUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000324C File Offset: 0x0000144C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97540, RefRangeEnd = 97541, XrefRangeStart = 97538, XrefRangeEnd = 97540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv0S);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv1S);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv2S);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv3S);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_AddUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003318 File Offset: 0x00001518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97541, XrefRangeEnd = 97543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitIndicesStreamsInternal(Object verts, Object indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SplitIndicesStreamsInternal_Private_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003360 File Offset: 0x00001560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97540, RefRangeEnd = 97541, XrefRangeStart = 97540, XrefRangeEnd = 97541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitUIVertexStreamsInternal(Object verts, Object positions, Object colors, Object uv0S, Object uv1S, Object uv2S, Object uv3S, Object normals, Object tangents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv0S);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv1S);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv2S);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv3S);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SplitUIVertexStreamsInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000342C File Offset: 0x0000162C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97536, RefRangeEnd = 97538, XrefRangeStart = 97536, XrefRangeEnd = 97538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateUIVertexStreamInternal(Object verts, Object positions, Object colors, Object uv0S, Object uv1S, Object uv2S, Object uv3S, Object normals, Object tangents, Object indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv0S);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv1S);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv2S);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv3S);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_CreateUIVertexStreamInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000350C File Offset: 0x0000170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97543, XrefRangeEnd = 97545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor_Injected(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_SetColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000354C File Offset: 0x0000174C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97545, XrefRangeEnd = 97547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_GetColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000358C File Offset: 0x0000178C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97547, XrefRangeEnd = 97549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableRectClipping_Injected(ref Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_EnableRectClipping_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000035CC File Offset: 0x000017CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97549, XrefRangeEnd = 97551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_clippingSoftness_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasRenderer.NativeMethodInfoPtr_set_clippingSoftness_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002091 File Offset: 0x00000291
		public CanvasRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000360C File Offset: 0x0000180C
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000209A File Offset: 0x0000029A
		public unsafe bool _isMask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasRenderer.NativeFieldInfoPtr__isMask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasRenderer.NativeFieldInfoPtr__isMask_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000020D9 File Offset: 0x000002D9
		public bool hasRectClipping
		{
			get
			{
				return CanvasRenderer.get_hasRectClippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000020EB File Offset: 0x000002EB
		public int relativeDepth
		{
			get
			{
				return CanvasRenderer.get_relativeDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000020FD File Offset: 0x000002FD
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002105 File Offset: 0x00000305
		public bool isMask
		{
			get
			{
				return this._isMask_k__BackingField;
			}
			set
			{
				this._isMask_k__BackingField = value;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000364C File Offset: 0x0000184C
		public Material GetPopMaterial(int index)
		{
			IntPtr intPtr = CanvasRenderer.GetPopMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000367C File Offset: 0x0000187C
		public float GetAlpha()
		{
			return this.GetColor().a;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000369C File Offset: 0x0000189C
		public void SetAlpha(float alpha)
		{
			Color color = this.GetColor();
			color.a = alpha;
			this.SetColor(color);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210E File Offset: 0x0000030E
		public float GetInheritedAlpha()
		{
			return CanvasRenderer.GetInheritedAlphaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000036C4 File Offset: 0x000018C4
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			CanvasRenderer.SplitUIVertexStreams(verts, positions, colors, uv0S, uv1S, new List<Vector4>(), new List<Vector4>(), normals, tangents, indices);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000036F0 File Offset: 0x000018F0
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			CanvasRenderer.CreateUIVertexStream(verts, positions, colors, uv0S, uv1S, new List<Vector4>(), new List<Vector4>(), normals, tangents, indices);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000371C File Offset: 0x0000191C
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents)
		{
			CanvasRenderer.AddUIVertexStream(verts, positions, colors, uv0S, uv1S, new List<Vector4>(), new List<Vector4>(), normals, tangents);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002120 File Offset: 0x00000320
		public void SetVertices(List<UIVertex> vertices)
		{
			this.SetVertices(vertices.ToArray(), vertices.Count);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002136 File Offset: 0x00000336
		public void SetVertices(Il2CppStructArray<UIVertex> vertices, int size)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002143 File Offset: 0x00000343
		public void get_clippingSoftness_Injected(out Vector2 ret)
		{
			CanvasRenderer.get_clippingSoftness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr__isMask_k__BackingField;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_hasPopInstruction_Public_set_Void_Boolean_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_materialCount_Public_get_Int32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_materialCount_Public_set_Void_Int32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_popMaterialCount_Public_set_Void_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_absoluteDepth_Public_get_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_hasMoved_Public_get_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_cullTransparentMesh_Public_get_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_cullTransparentMesh_Public_set_Void_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_cull_Public_get_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_cull_Public_set_Void_Boolean_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_EnableRectClipping_Public_Void_Rect_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_clippingSoftness_Public_set_Void_Vector2_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_DisableRectClipping_Public_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Public_Material_Int32_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_SetPopMaterial_Public_Void_Material_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Texture_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_SetAlphaTexture_Public_Void_Texture_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_Material_Texture_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Public_Material_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_SplitUIVertexStreams_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_List_1_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexStream_Public_Static_Void_List_1_UIVertex_List_1_Vector3_List_1_Color32_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector4_List_1_Vector3_List_1_Vector4_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_SplitIndicesStreamsInternal_Private_Static_Void_Object_Object_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_SplitUIVertexStreamsInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIVertexStreamInternal_Private_Static_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_EnableRectClipping_Injected_Private_Void_byref_Rect_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_clippingSoftness_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400002E RID: 46
		private static readonly CanvasRenderer.get_hasPopInstructionDelegate get_hasPopInstructionDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly CanvasRenderer.get_popMaterialCountDelegate get_popMaterialCountDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly CanvasRenderer.get_hasRectClippingDelegate get_hasRectClippingDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly CanvasRenderer.get_relativeDepthDelegate get_relativeDepthDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly CanvasRenderer.GetPopMaterialDelegate GetPopMaterialDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly CanvasRenderer.GetInheritedAlphaDelegate GetInheritedAlphaDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly CanvasRenderer.get_clippingSoftness_InjectedDelegate get_clippingSoftness_InjectedDelegateField;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x060000A9 RID: 169
		private delegate bool get_hasPopInstructionDelegate(IntPtr @this);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x060000AB RID: 171
		private delegate int get_popMaterialCountDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x060000AD RID: 173
		private delegate bool get_hasRectClippingDelegate(IntPtr @this);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x060000AF RID: 175
		private delegate int get_relativeDepthDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x060000B1 RID: 177
		private delegate IntPtr GetPopMaterialDelegate(IntPtr @this, int index);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000B3 RID: 179
		private delegate float GetInheritedAlphaDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000B5 RID: 181
		private delegate void get_clippingSoftness_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
