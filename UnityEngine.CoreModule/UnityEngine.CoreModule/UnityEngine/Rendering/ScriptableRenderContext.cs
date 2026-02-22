using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct ScriptableRenderContext
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x0005AA30 File Offset: 0x00058C30
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderContext()
		{
			Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableRenderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
			ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "kRenderTypeTag");
			ScriptableRenderContext.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "m_Ptr");
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665139);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665141);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665142);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665143);
			ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665144);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665146);
			ScriptableRenderContext.BeginRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginRenderPass_Internal");
			ScriptableRenderContext.BeginSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginSubPass_Internal");
			ScriptableRenderContext.EndSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndSubPass_Internal");
			ScriptableRenderContext.EndRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndRenderPass_Internal");
			ScriptableRenderContext.InitializeSortSettingsDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.InitializeSortSettingsDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InitializeSortSettings");
			ScriptableRenderContext.EmitGeometryForCameraDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EmitGeometryForCameraDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EmitGeometryForCamera");
			ScriptableRenderContext.Submit_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.Submit_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::Submit_Internal_Injected");
			ScriptableRenderContext.DrawShadows_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawShadows_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal_Injected");
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBuffer_Internal_Injected");
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBufferAsync_Internal_Injected");
			ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::SetupCameraProperties_Internal_Injected");
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal_Injected");
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
			ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawWireOverlay_Impl_Injected");
			ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawUIOverlay_Internal_Injected");
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0005AC20 File Offset: 0x00058E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82501, RefRangeEnd = 82502, XrefRangeStart = 82496, XrefRangeEnd = 82501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras_Internal(Type listType, Object resultList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0005AC68 File Offset: 0x00058E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82502, XrefRangeEnd = 82509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras(List<Camera> results)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82513, RefRangeEnd = 82514, XrefRangeStart = 82509, XrefRangeEnd = 82513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableRenderContext other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82514, XrefRangeEnd = 82518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0005AD24 File Offset: 0x00058F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82518, XrefRangeEnd = 82525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0005AD54 File Offset: 0x00058F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82525, XrefRangeEnd = 82527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, Object resultList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0000D96A File Offset: 0x0000BB6A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, ref this));
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0005ADAC File Offset: 0x00058FAC
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000D97C File Offset: 0x0000BB7C
		public unsafe static ShaderTagId kRenderTypeTag
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&value));
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0000D98A File Offset: 0x0000BB8A
		public static void BeginRenderPass_Internal(IntPtr self, int width, int height, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex)
		{
			ScriptableRenderContext.BeginRenderPass_InternalDelegateField(self, width, height, samples, colors, colorCount, depthAttachmentIndex);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		public static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_InternalDelegateField(self, colors, colorCount, inputs, inputCount, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0000D9B6 File Offset: 0x0000BBB6
		public static void EndSubPass_Internal(IntPtr self)
		{
			ScriptableRenderContext.EndSubPass_InternalDelegateField(self);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0000D9C3 File Offset: 0x0000BBC3
		public static void EndRenderPass_Internal(IntPtr self)
		{
			ScriptableRenderContext.EndRenderPass_InternalDelegateField(self);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
		{
			ScriptableRenderContext.InitializeSortSettingsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), out sortingSettings);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0000D9E3 File Offset: 0x0000BBE3
		public void Submit_Internal()
		{
			ScriptableRenderContext.Submit_Internal_Injected(ref this);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0000D9EB File Offset: 0x0000BBEB
		public void DrawShadows_Internal(IntPtr shadowDrawingSettings)
		{
			ScriptableRenderContext.DrawShadows_Internal_Injected(ref this, shadowDrawingSettings);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		public static void EmitGeometryForCamera(Camera camera)
		{
			ScriptableRenderContext.EmitGeometryForCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0000DA06 File Offset: 0x0000BC06
		public void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
		{
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_Injected(ref this, commandBuffer);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0000DA0F File Offset: 0x0000BC0F
		public void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_Injected(ref this, commandBuffer, queueType);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0000DA19 File Offset: 0x0000BC19
		public void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
		{
			ScriptableRenderContext.SetupCameraProperties_Internal_Injected(ref this, camera, stereoSetup, eye);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0000DA24 File Offset: 0x0000BC24
		public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_Injected(ref this, camera, eye, isFinalPass);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000DA2F File Offset: 0x0000BC2F
		public void StartMultiEye_Internal(Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_Injected(ref this, camera, eye);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public void StopMultiEye_Internal(Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0000DA42 File Offset: 0x0000BC42
		public void DrawSkybox_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000DA4B File Offset: 0x0000BC4B
		public void InvokeOnRenderObjectCallback_Internal()
		{
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_Injected(ref this);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0000DA53 File Offset: 0x0000BC53
		public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_Injected(ref this, camera, gizmoSubset);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000DA5D File Offset: 0x0000BC5D
		public void DrawWireOverlay_Impl(Camera camera)
		{
			ScriptableRenderContext.DrawWireOverlay_Impl_Injected(ref this, camera);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0000DA66 File Offset: 0x0000BC66
		public void DrawUIOverlay_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawUIOverlay_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		public IntPtr Internal_GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0000DA6F File Offset: 0x0000BC6F
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0000DAA5 File Offset: 0x0000BCA5
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthStencilReadOnly, isDepthStencilReadOnly);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000DADA File Offset: 0x0000BCDA
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000DB03 File Offset: 0x0000BD03
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthStencilReadOnly, isDepthStencilReadOnly);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0005ADE0 File Offset: 0x00058FE0
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0005AE0C File Offset: 0x0005900C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0005AE34 File Offset: 0x00059034
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0005AE5C File Offset: 0x0005905C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		public void EndSubPass()
		{
			ScriptableRenderContext.EndSubPass_Internal(this.m_Ptr);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0000DB3B File Offset: 0x0000BD3B
		public void EndRenderPass()
		{
			ScriptableRenderContext.EndRenderPass_Internal(this.m_Ptr);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0000DB4A File Offset: 0x0000BD4A
		public void Submit()
		{
			this.Submit_Internal();
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0005AE84 File Offset: 0x00059084
		public void ExecuteCommandBuffer(CommandBuffer commandBuffer)
		{
			bool flag = commandBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("commandBuffer");
			}
			this.ExecuteCommandBuffer_Internal(commandBuffer);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0005AEB0 File Offset: 0x000590B0
		public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			bool flag = commandBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("commandBuffer");
			}
			this.ExecuteCommandBufferAsync_Internal(commandBuffer, queueType);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000DB54 File Offset: 0x0000BD54
		public void SetupCameraProperties(Camera camera, [Optional] bool stereoSetup)
		{
			this.SetupCameraProperties(camera, stereoSetup, 0);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000DB61 File Offset: 0x0000BD61
		public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
		{
			this.SetupCameraProperties_Internal(camera, stereoSetup, eye);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0000DB6E File Offset: 0x0000BD6E
		public void StereoEndRender(Camera camera)
		{
			this.StereoEndRender(camera, 0, true);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		public void StereoEndRender(Camera camera, int eye)
		{
			this.StereoEndRender(camera, eye, true);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000DB88 File Offset: 0x0000BD88
		public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
		{
			this.StereoEndRender_Internal(camera, eye, isFinalPass);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000DB95 File Offset: 0x0000BD95
		public void StartMultiEye(Camera camera)
		{
			this.StartMultiEye(camera, 0);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		public void StartMultiEye(Camera camera, int eye)
		{
			this.StartMultiEye_Internal(camera, eye);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0000DBAD File Offset: 0x0000BDAD
		public void StopMultiEye(Camera camera)
		{
			this.StopMultiEye_Internal(camera);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public void DrawSkybox(Camera camera)
		{
			this.DrawSkybox_Internal(camera);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		public void InvokeOnRenderObjectCallback()
		{
			this.InvokeOnRenderObjectCallback_Internal();
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000DBCD File Offset: 0x0000BDCD
		public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
		{
			this.DrawGizmos_Internal(camera, gizmoSubset);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000DBD9 File Offset: 0x0000BDD9
		public void DrawWireOverlay(Camera camera)
		{
			this.DrawWireOverlay_Impl(camera);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		public void DrawUIOverlay(Camera camera)
		{
			this.DrawUIOverlay_Internal(camera);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0000DBEF File Offset: 0x0000BDEF
		public void Validate()
		{
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0005AEDC File Offset: 0x000590DC
		public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return left.Equals(right);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0005AEF8 File Offset: 0x000590F8
		public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0000DBF2 File Offset: 0x0000BDF2
		public static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			ScriptableRenderContext.Submit_Internal_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0000DBFF File Offset: 0x0000BDFF
		public static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings)
		{
			ScriptableRenderContext.DrawShadows_Internal_InjectedDelegateField(ref _unity_self, shadowDrawingSettings);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0000DC0D File Offset: 0x0000BE0D
		public static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer)
		{
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(commandBuffer));
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0000DC20 File Offset: 0x0000BE20
		public static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(commandBuffer), queueType);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye)
		{
			ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), stereoSetup, eye);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000DC49 File Offset: 0x0000BE49
		public static void StereoEndRender_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye, isFinalPass);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0000DC5E File Offset: 0x0000BE5E
		public static void StartMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0000DC72 File Offset: 0x0000BE72
		public static void StopMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0000DC85 File Offset: 0x0000BE85
		public static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000DC98 File Offset: 0x0000BE98
		public static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
		public static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), gizmoSubset);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0000DCB9 File Offset: 0x0000BEB9
		public static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0000DCCC File Offset: 0x0000BECC
		public static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr_kRenderTypeTag;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0;

		// Token: 0x04001227 RID: 4647
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04001228 RID: 4648
		private static readonly ScriptableRenderContext.BeginRenderPass_InternalDelegate BeginRenderPass_InternalDelegateField;

		// Token: 0x04001229 RID: 4649
		private static readonly ScriptableRenderContext.BeginSubPass_InternalDelegate BeginSubPass_InternalDelegateField;

		// Token: 0x0400122A RID: 4650
		private static readonly ScriptableRenderContext.EndSubPass_InternalDelegate EndSubPass_InternalDelegateField;

		// Token: 0x0400122B RID: 4651
		private static readonly ScriptableRenderContext.EndRenderPass_InternalDelegate EndRenderPass_InternalDelegateField;

		// Token: 0x0400122C RID: 4652
		private static readonly ScriptableRenderContext.InitializeSortSettingsDelegate InitializeSortSettingsDelegateField;

		// Token: 0x0400122D RID: 4653
		private static readonly ScriptableRenderContext.EmitGeometryForCameraDelegate EmitGeometryForCameraDelegateField;

		// Token: 0x0400122E RID: 4654
		private static readonly ScriptableRenderContext.Submit_Internal_InjectedDelegate Submit_Internal_InjectedDelegateField;

		// Token: 0x0400122F RID: 4655
		private static readonly ScriptableRenderContext.DrawShadows_Internal_InjectedDelegate DrawShadows_Internal_InjectedDelegateField;

		// Token: 0x04001230 RID: 4656
		private static readonly ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegate ExecuteCommandBuffer_Internal_InjectedDelegateField;

		// Token: 0x04001231 RID: 4657
		private static readonly ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegate ExecuteCommandBufferAsync_Internal_InjectedDelegateField;

		// Token: 0x04001232 RID: 4658
		private static readonly ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegate SetupCameraProperties_Internal_InjectedDelegateField;

		// Token: 0x04001233 RID: 4659
		private static readonly ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;

		// Token: 0x04001234 RID: 4660
		private static readonly ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04001235 RID: 4661
		private static readonly ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04001236 RID: 4662
		private static readonly ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;

		// Token: 0x04001237 RID: 4663
		private static readonly ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegate InvokeOnRenderObjectCallback_Internal_InjectedDelegateField;

		// Token: 0x04001238 RID: 4664
		private static readonly ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;

		// Token: 0x04001239 RID: 4665
		private static readonly ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate DrawWireOverlay_Impl_InjectedDelegateField;

		// Token: 0x0400123A RID: 4666
		private static readonly ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate DrawUIOverlay_Internal_InjectedDelegateField;

		// Token: 0x02000997 RID: 2455
		// (Invoke) Token: 0x06003151 RID: 12625
		private delegate void BeginRenderPass_InternalDelegate(IntPtr self, int width, int height, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex);

		// Token: 0x02000998 RID: 2456
		// (Invoke) Token: 0x06003153 RID: 12627
		private delegate void BeginSubPass_InternalDelegate(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);

		// Token: 0x02000999 RID: 2457
		// (Invoke) Token: 0x06003155 RID: 12629
		private delegate void EndSubPass_InternalDelegate(IntPtr self);

		// Token: 0x0200099A RID: 2458
		// (Invoke) Token: 0x06003157 RID: 12631
		private delegate void EndRenderPass_InternalDelegate(IntPtr self);

		// Token: 0x0200099B RID: 2459
		// (Invoke) Token: 0x06003159 RID: 12633
		private delegate void InitializeSortSettingsDelegate(IntPtr camera, [Out] IntPtr sortingSettings);

		// Token: 0x0200099C RID: 2460
		// (Invoke) Token: 0x0600315B RID: 12635
		private delegate void EmitGeometryForCameraDelegate(IntPtr camera);

		// Token: 0x0200099D RID: 2461
		// (Invoke) Token: 0x0600315D RID: 12637
		private delegate void Submit_Internal_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200099E RID: 2462
		// (Invoke) Token: 0x0600315F RID: 12639
		private delegate void DrawShadows_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr shadowDrawingSettings);

		// Token: 0x0200099F RID: 2463
		// (Invoke) Token: 0x06003161 RID: 12641
		private delegate void ExecuteCommandBuffer_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr commandBuffer);

		// Token: 0x020009A0 RID: 2464
		// (Invoke) Token: 0x06003163 RID: 12643
		private delegate void ExecuteCommandBufferAsync_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr commandBuffer, ComputeQueueType queueType);

		// Token: 0x020009A1 RID: 2465
		// (Invoke) Token: 0x06003165 RID: 12645
		private delegate void SetupCameraProperties_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, bool stereoSetup, int eye);

		// Token: 0x020009A2 RID: 2466
		// (Invoke) Token: 0x06003167 RID: 12647
		private delegate void StereoEndRender_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye, bool isFinalPass);

		// Token: 0x020009A3 RID: 2467
		// (Invoke) Token: 0x06003169 RID: 12649
		private delegate void StartMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye);

		// Token: 0x020009A4 RID: 2468
		// (Invoke) Token: 0x0600316B RID: 12651
		private delegate void StopMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009A5 RID: 2469
		// (Invoke) Token: 0x0600316D RID: 12653
		private delegate void DrawSkybox_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009A6 RID: 2470
		// (Invoke) Token: 0x0600316F RID: 12655
		private delegate void InvokeOnRenderObjectCallback_Internal_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009A7 RID: 2471
		// (Invoke) Token: 0x06003171 RID: 12657
		private delegate void DrawGizmos_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, GizmoSubset gizmoSubset);

		// Token: 0x020009A8 RID: 2472
		// (Invoke) Token: 0x06003173 RID: 12659
		private delegate void DrawWireOverlay_Impl_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009A9 RID: 2473
		// (Invoke) Token: 0x06003175 RID: 12661
		private delegate void DrawUIOverlay_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);
	}
}
