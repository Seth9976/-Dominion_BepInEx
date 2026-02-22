using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000141 RID: 321
	public class RenderPipeline : Object
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x00059A44 File Offset: 0x00057C44
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipeline()
		{
			Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr);
			RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "<disposed>k__BackingField");
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665099);
			RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_List_1_RenderRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665100);
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665101);
			RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665102);
			RenderPipeline.NativeMethodInfoPtr_InternalRenderWithRequests_Internal_Void_ScriptableRenderContext_List_1_Camera_List_1_RenderRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665103);
			RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665104);
			RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665105);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665106);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100665107);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00059B3C File Offset: 0x00057D3C
		[CallerCount(0)]
		public unsafe virtual void Render(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00059B98 File Offset: 0x00057D98
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_List_1_RenderRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00059C08 File Offset: 0x00057E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82265, XrefRangeEnd = 82269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00059C64 File Offset: 0x00057E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82269, XrefRangeEnd = 82276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00059CB4 File Offset: 0x00057EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82276, XrefRangeEnd = 82286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_InternalRenderWithRequests_Internal_Void_ScriptableRenderContext_List_1_Camera_List_1_RenderRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00059D18 File Offset: 0x00057F18
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00059D54 File Offset: 0x00057F54
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00059D94 File Offset: 0x00057F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82286, XrefRangeEnd = 82290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00059DC8 File Offset: 0x00057FC8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0000D85E File Offset: 0x0000BA5E
		public RenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00059E14 File Offset: 0x00058014
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000D867 File Offset: 0x0000BA67
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0000D882 File Offset: 0x0000BA82
		public static void BeginFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0000D892 File Offset: 0x0000BA92
		public static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, cameras);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0000D89D File Offset: 0x0000BA9D
		public static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			RenderPipelineManager.BeginCameraRendering(context, camera);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		public static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			RenderPipelineManager.EndContextRendering(context, cameras);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0000D8B3 File Offset: 0x0000BAB3
		public static void EndFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.EndContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0000D8C3 File Offset: 0x0000BAC3
		public static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			RenderPipelineManager.EndCameraRendering(context, camera);
		}

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_List_1_RenderRequest_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_InternalRenderWithRequests_Internal_Void_ScriptableRenderContext_List_1_Camera_List_1_RenderRequest_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;
	}
}
