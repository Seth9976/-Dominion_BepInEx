using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000143 RID: 323
	public static class RenderPipelineManager : Object
	{
		// Token: 0x06001845 RID: 6213 RVA: 0x0005A6D0 File Offset: 0x000588D0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineManager()
		{
			Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineAsset");
			RenderPipelineManager.NativeFieldInfoPtr_s_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_Cameras");
			RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "<currentPipeline>k__BackingField");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineTypeChanged");
			RenderPipelineManager.NativeFieldInfoPtr_hasRPTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "hasRPTypeChanged");
			RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665131);
			RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665132);
			RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665133);
			RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665134);
			RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665135);
			RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665136);
			RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665137);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0005A7F0 File Offset: 0x000589F0
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0005A824 File Offset: 0x00058A24
		public unsafe static RenderPipeline currentPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82325, XrefRangeEnd = 82329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82329, XrefRangeEnd = 82333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0005A85C File Offset: 0x00058A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82341, RefRangeEnd = 82343, XrefRangeStart = 82333, XrefRangeEnd = 82341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveRenderPipelineTypeChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0005A884 File Offset: 0x00058A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82375, RefRangeEnd = 82376, XrefRangeStart = 82343, XrefRangeEnd = 82375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0005A8BC File Offset: 0x00058ABC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 82416, RefRangeEnd = 82419, XrefRangeStart = 82376, XrefRangeEnd = 82416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0005A8E4 File Offset: 0x00058AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82419, XrefRangeEnd = 82460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0005A93C File Offset: 0x00058B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82494, RefRangeEnd = 82496, XrefRangeStart = 82460, XrefRangeEnd = 82494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
		public RenderPipelineManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0005A974 File Offset: 0x00058B74
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		public unsafe static RenderPipelineAsset s_CurrentPipelineAsset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0005A99C File Offset: 0x00058B9C
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
		public unsafe static List<Camera> s_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0005A9C4 File Offset: 0x00058BC4
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000D904 File Offset: 0x0000BB04
		public unsafe static RenderPipeline _currentPipeline_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0005A9EC File Offset: 0x00058BEC
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000D916 File Offset: 0x0000BB16
		public unsafe static Action activeRenderPipelineTypeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0005AA14 File Offset: 0x00058C14
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000D928 File Offset: 0x0000BB28
		public unsafe static bool hasRPTypeChanged
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_hasRPTypeChanged, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_hasRPTypeChanged, (void*)(&value));
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0000D936 File Offset: 0x0000BB36
		public static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0000D943 File Offset: 0x0000BB43
		public static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0000D950 File Offset: 0x0000BB50
		public static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0000D95D File Offset: 0x0000BB5D
		public static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_s_Cameras;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr__currentPipeline_k__BackingField;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineTypeChanged;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_hasRPTypeChanged;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0;
	}
}
