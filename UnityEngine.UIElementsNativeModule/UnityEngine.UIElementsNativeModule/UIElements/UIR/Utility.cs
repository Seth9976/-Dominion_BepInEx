using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200000D RID: 13
	public class Utility : Object
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00004A90 File Offset: 0x00002C90
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Il2CppClassPointerStore<Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.UIElements.UIR", "Utility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility>.NativeClassPtr);
			Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GraphicsResourcesRecreate");
			Utility.NativeFieldInfoPtr_EngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "EngineUpdate");
			Utility.NativeFieldInfoPtr_FlushPendingResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "FlushPendingResources");
			Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RegisterIntermediateRenderers");
			Utility.NativeFieldInfoPtr_RenderNodeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeAdd");
			Utility.NativeFieldInfoPtr_RenderNodeExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeExecute");
			Utility.NativeFieldInfoPtr_RenderNodeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeCleanup");
			Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "s_MarkerRaiseEngineUpdate");
			Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663328);
			Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663329);
			Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663330);
			Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663331);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663332);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663333);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663334);
			Utility.AllocateBufferDelegateField = IL2CPP.ResolveICall<Utility.AllocateBufferDelegate>("UnityEngine.UIElements.UIR.Utility::AllocateBuffer");
			Utility.FreeBufferDelegateField = IL2CPP.ResolveICall<Utility.FreeBufferDelegate>("UnityEngine.UIElements.UIR.Utility::FreeBuffer");
			Utility.UpdateBufferRangesDelegateField = IL2CPP.ResolveICall<Utility.UpdateBufferRangesDelegate>("UnityEngine.UIElements.UIR.Utility::UpdateBufferRanges");
			Utility.SetVectorArrayDelegateField = IL2CPP.ResolveICall<Utility.SetVectorArrayDelegate>("UnityEngine.UIElements.UIR.Utility::SetVectorArray");
			Utility.DrawRangesDelegateField = IL2CPP.ResolveICall<Utility.DrawRangesDelegate>("UnityEngine.UIElements.UIR.Utility::DrawRanges");
			Utility.SetPropertyBlockDelegateField = IL2CPP.ResolveICall<Utility.SetPropertyBlockDelegate>("UnityEngine.UIElements.UIR.Utility::SetPropertyBlock");
			Utility.DisableScissorDelegateField = IL2CPP.ResolveICall<Utility.DisableScissorDelegate>("UnityEngine.UIElements.UIR.Utility::DisableScissor");
			Utility.IsScissorEnabledDelegateField = IL2CPP.ResolveICall<Utility.IsScissorEnabledDelegate>("UnityEngine.UIElements.UIR.Utility::IsScissorEnabled");
			Utility.HasMappedBufferRangeDelegateField = IL2CPP.ResolveICall<Utility.HasMappedBufferRangeDelegate>("UnityEngine.UIElements.UIR.Utility::HasMappedBufferRange");
			Utility.InsertCPUFenceDelegateField = IL2CPP.ResolveICall<Utility.InsertCPUFenceDelegate>("UnityEngine.UIElements.UIR.Utility::InsertCPUFence");
			Utility.CPUFencePassedDelegateField = IL2CPP.ResolveICall<Utility.CPUFencePassedDelegate>("UnityEngine.UIElements.UIR.Utility::CPUFencePassed");
			Utility.WaitForCPUFencePassedDelegateField = IL2CPP.ResolveICall<Utility.WaitForCPUFencePassedDelegate>("UnityEngine.UIElements.UIR.Utility::WaitForCPUFencePassed");
			Utility.SyncRenderThreadDelegateField = IL2CPP.ResolveICall<Utility.SyncRenderThreadDelegate>("UnityEngine.UIElements.UIR.Utility::SyncRenderThread");
			Utility.ProfileDrawChainBeginDelegateField = IL2CPP.ResolveICall<Utility.ProfileDrawChainBeginDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileDrawChainBegin");
			Utility.ProfileDrawChainEndDelegateField = IL2CPP.ResolveICall<Utility.ProfileDrawChainEndDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileDrawChainEnd");
			Utility.ProfileImmediateRendererBeginDelegateField = IL2CPP.ResolveICall<Utility.ProfileImmediateRendererBeginDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileImmediateRendererBegin");
			Utility.ProfileImmediateRendererEndDelegateField = IL2CPP.ResolveICall<Utility.ProfileImmediateRendererEndDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileImmediateRendererEnd");
			Utility.NotifyOfUIREventsDelegateField = IL2CPP.ResolveICall<Utility.NotifyOfUIREventsDelegate>("UnityEngine.UIElements.UIR.Utility::NotifyOfUIREvents");
			Utility.DebugIsMainThreadDelegateField = IL2CPP.ResolveICall<Utility.DebugIsMainThreadDelegate>("UnityEngine.UIElements.UIR.Utility::DebugIsMainThread");
			Utility.RegisterIntermediateRenderer_InjectedDelegateField = IL2CPP.ResolveICall<Utility.RegisterIntermediateRenderer_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::RegisterIntermediateRenderer_Injected");
			Utility.SetScissorRect_InjectedDelegateField = IL2CPP.ResolveICall<Utility.SetScissorRect_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::SetScissorRect_Injected");
			Utility.GetActiveViewport_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetActiveViewport_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetActiveViewport_Injected");
			Utility.GetUnityProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetUnityProjectionMatrix_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetUnityProjectionMatrix_Injected");
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetDeviceProjectionMatrix_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetDeviceProjectionMatrix_Injected");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004D54 File Offset: 0x00002F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89455, XrefRangeEnd = 89462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseGraphicsResourcesRecreate(bool recreate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recreate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004D88 File Offset: 0x00002F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89462, XrefRangeEnd = 89469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseEngineUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004DB0 File Offset: 0x00002FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89469, XrefRangeEnd = 89474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseFlushPendingResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004DD8 File Offset: 0x00002FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89474, XrefRangeEnd = 89481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRegisterIntermediateRenderers(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004E10 File Offset: 0x00003010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89481, XrefRangeEnd = 89488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeAdd(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004E44 File Offset: 0x00003044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89488, XrefRangeEnd = 89495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeExecute(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004E78 File Offset: 0x00003078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89495, XrefRangeEnd = 89502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeCleanup(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002995 File Offset: 0x00000B95
		public Utility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004EAC File Offset: 0x000030AC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000299E File Offset: 0x00000B9E
		public unsafe static Action<bool> GraphicsResourcesRecreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000029B0 File Offset: 0x00000BB0
		public unsafe static Action EngineUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_EngineUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_EngineUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004EFC File Offset: 0x000030FC
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe static Action FlushPendingResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_FlushPendingResources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_FlushPendingResources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004F24 File Offset: 0x00003124
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000029D4 File Offset: 0x00000BD4
		public unsafe static Action<Camera> RegisterIntermediateRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00004F4C File Offset: 0x0000314C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000029E6 File Offset: 0x00000BE6
		public unsafe static Action<IntPtr> RenderNodeAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004F74 File Offset: 0x00003174
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe static Action<IntPtr> RenderNodeExecute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004F9C File Offset: 0x0000319C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002A0A File Offset: 0x00000C0A
		public unsafe static Action<IntPtr> RenderNodeCleanup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004FC4 File Offset: 0x000031C4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002A1C File Offset: 0x00000C1C
		public unsafe static ProfilerMarker s_MarkerRaiseEngineUpdate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&value));
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002A2A File Offset: 0x00000C2A
		public static void add_GraphicsResourcesRecreate(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002A37 File Offset: 0x00000C37
		public static void remove_GraphicsResourcesRecreate(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002A44 File Offset: 0x00000C44
		public static void add_RegisterIntermediateRenderers(Action<Camera> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002A51 File Offset: 0x00000C51
		public static void remove_RegisterIntermediateRenderers(Action<Camera> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002A5E File Offset: 0x00000C5E
		public static void add_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002A6B File Offset: 0x00000C6B
		public static void remove_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002A78 File Offset: 0x00000C78
		public static void add_RenderNodeExecute(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002A85 File Offset: 0x00000C85
		public static void remove_RenderNodeExecute(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002A92 File Offset: 0x00000C92
		public static void add_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002A9F File Offset: 0x00000C9F
		public static void remove_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002AAC File Offset: 0x00000CAC
		public static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer)
		{
			return Utility.AllocateBufferDelegateField(elementCount, elementStride, vertexBuffer);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002ABB File Offset: 0x00000CBB
		public static void FreeBuffer(IntPtr buffer)
		{
			Utility.FreeBufferDelegateField(buffer);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd)
		{
			Utility.UpdateBufferRangesDelegateField(buffer, ranges, rangeCount, writeRangeStart, writeRangeEnd);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002ADA File Offset: 0x00000CDA
		public static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count)
		{
			Utility.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(props), name, vector4s, count);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004FE0 File Offset: 0x000031E0
		public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			Utility.RegisterIntermediateRenderer_Injected(camera, material, ref transform, ref aabb, renderLayer, shadowCasting, receiveShadows, sameDistanceSortPriority, sceneCullingMask, rendererCallbackFlags, userData, userDataSize);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002AEF File Offset: 0x00000CEF
		public unsafe static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl)
		{
			Utility.DrawRangesDelegateField(ib, vertexStreams, streamCount, ranges, rangeCount, vertexDecl);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002B03 File Offset: 0x00000D03
		public static void SetPropertyBlock(MaterialPropertyBlock props)
		{
			Utility.SetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtr(props));
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002B15 File Offset: 0x00000D15
		public static void SetScissorRect(RectInt scissorRect)
		{
			Utility.SetScissorRect_Injected(ref scissorRect);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002B1E File Offset: 0x00000D1E
		public static void DisableScissor()
		{
			Utility.DisableScissorDelegateField();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002B2A File Offset: 0x00000D2A
		public static bool IsScissorEnabled()
		{
			return Utility.IsScissorEnabledDelegateField();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002B36 File Offset: 0x00000D36
		public static bool HasMappedBufferRange()
		{
			return Utility.HasMappedBufferRangeDelegateField();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002B42 File Offset: 0x00000D42
		public static uint InsertCPUFence()
		{
			return Utility.InsertCPUFenceDelegateField();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002B4E File Offset: 0x00000D4E
		public static bool CPUFencePassed(uint fence)
		{
			return Utility.CPUFencePassedDelegateField(fence);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002B5B File Offset: 0x00000D5B
		public static void WaitForCPUFencePassed(uint fence)
		{
			Utility.WaitForCPUFencePassedDelegateField(fence);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002B68 File Offset: 0x00000D68
		public static void SyncRenderThread()
		{
			Utility.SyncRenderThreadDelegateField();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005008 File Offset: 0x00003208
		public static RectInt GetActiveViewport()
		{
			RectInt rectInt;
			Utility.GetActiveViewport_Injected(out rectInt);
			return rectInt;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002B74 File Offset: 0x00000D74
		public static void ProfileDrawChainBegin()
		{
			Utility.ProfileDrawChainBeginDelegateField();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002B80 File Offset: 0x00000D80
		public static void ProfileDrawChainEnd()
		{
			Utility.ProfileDrawChainEndDelegateField();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002B8C File Offset: 0x00000D8C
		public static void ProfileImmediateRendererBegin()
		{
			Utility.ProfileImmediateRendererBeginDelegateField();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002B98 File Offset: 0x00000D98
		public static void ProfileImmediateRendererEnd()
		{
			Utility.ProfileImmediateRendererEndDelegateField();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public static void NotifyOfUIREvents(bool subscribe)
		{
			Utility.NotifyOfUIREventsDelegateField(subscribe);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005020 File Offset: 0x00003220
		public static Matrix4x4 GetUnityProjectionMatrix()
		{
			Matrix4x4 matrix4x;
			Utility.GetUnityProjectionMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005038 File Offset: 0x00003238
		public static Matrix4x4 GetDeviceProjectionMatrix()
		{
			Matrix4x4 matrix4x;
			Utility.GetDeviceProjectionMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002BB1 File Offset: 0x00000DB1
		public static bool DebugIsMainThread()
		{
			return Utility.DebugIsMainThreadDelegateField();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005050 File Offset: 0x00003250
		public static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			Utility.RegisterIntermediateRenderer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(material), ref transform, ref aabb, renderLayer, shadowCasting, receiveShadows, sameDistanceSortPriority, sceneCullingMask, rendererCallbackFlags, userData, userDataSize);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002BBD File Offset: 0x00000DBD
		public static void SetScissorRect_Injected(ref RectInt scissorRect)
		{
			Utility.SetScissorRect_InjectedDelegateField(ref scissorRect);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002BCA File Offset: 0x00000DCA
		public static void GetActiveViewport_Injected(out RectInt ret)
		{
			Utility.GetActiveViewport_InjectedDelegateField(out ret);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Utility.GetUnityProjectionMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static void GetDeviceProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsResourcesRecreate;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_EngineUpdate;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_FlushPendingResources;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_RegisterIntermediateRenderers;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeAdd;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeExecute;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeCleanup;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0;

		// Token: 0x040000A6 RID: 166
		private static readonly Utility.AllocateBufferDelegate AllocateBufferDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly Utility.FreeBufferDelegate FreeBufferDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly Utility.UpdateBufferRangesDelegate UpdateBufferRangesDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly Utility.SetVectorArrayDelegate SetVectorArrayDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly Utility.DrawRangesDelegate DrawRangesDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly Utility.SetPropertyBlockDelegate SetPropertyBlockDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly Utility.DisableScissorDelegate DisableScissorDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly Utility.IsScissorEnabledDelegate IsScissorEnabledDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly Utility.HasMappedBufferRangeDelegate HasMappedBufferRangeDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly Utility.InsertCPUFenceDelegate InsertCPUFenceDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly Utility.CPUFencePassedDelegate CPUFencePassedDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly Utility.WaitForCPUFencePassedDelegate WaitForCPUFencePassedDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly Utility.SyncRenderThreadDelegate SyncRenderThreadDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly Utility.ProfileDrawChainBeginDelegate ProfileDrawChainBeginDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly Utility.ProfileDrawChainEndDelegate ProfileDrawChainEndDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly Utility.ProfileImmediateRendererBeginDelegate ProfileImmediateRendererBeginDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly Utility.ProfileImmediateRendererEndDelegate ProfileImmediateRendererEndDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly Utility.NotifyOfUIREventsDelegate NotifyOfUIREventsDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly Utility.DebugIsMainThreadDelegate DebugIsMainThreadDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly Utility.RegisterIntermediateRenderer_InjectedDelegate RegisterIntermediateRenderer_InjectedDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly Utility.SetScissorRect_InjectedDelegate SetScissorRect_InjectedDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly Utility.GetActiveViewport_InjectedDelegate GetActiveViewport_InjectedDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly Utility.GetUnityProjectionMatrix_InjectedDelegate GetUnityProjectionMatrix_InjectedDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly Utility.GetDeviceProjectionMatrix_InjectedDelegate GetDeviceProjectionMatrix_InjectedDelegateField;

		// Token: 0x0200007B RID: 123
		public class GPUBuffer<T> : Object where T : new()
		{
			// Token: 0x06000203 RID: 515 RVA: 0x000051E0 File Offset: 0x000033E0
			// Note: this type is marked as 'beforefieldinit'.
			static GPUBuffer()
			{
				Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GPUBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr);
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "buffer");
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "elemCount");
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "elemStride");
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00002C3F File Offset: 0x00000E3F
			public GPUBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000205 RID: 517 RVA: 0x00005284 File Offset: 0x00003484
			// (set) Token: 0x06000206 RID: 518 RVA: 0x00002C48 File Offset: 0x00000E48
			public unsafe IntPtr buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer)) = value;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000207 RID: 519 RVA: 0x000052AC File Offset: 0x000034AC
			// (set) Token: 0x06000208 RID: 520 RVA: 0x00002C63 File Offset: 0x00000E63
			public unsafe int elemCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount)) = value;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000209 RID: 521 RVA: 0x000052D4 File Offset: 0x000034D4
			// (set) Token: 0x0600020A RID: 522 RVA: 0x00002C7E File Offset: 0x00000E7E
			public unsafe int elemStride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride)) = value;
				}
			}

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr_elemCount;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeFieldInfoPtr_elemStride;
		}

		// Token: 0x0200007C RID: 124
		public enum RendererCallbacks
		{
			// Token: 0x0400010A RID: 266
			RendererCallback_Init = 1,
			// Token: 0x0400010B RID: 267
			RendererCallback_Exec,
			// Token: 0x0400010C RID: 268
			RendererCallback_Cleanup = 4
		}

		// Token: 0x0200007D RID: 125
		public enum GPUBufferType
		{
			// Token: 0x0400010E RID: 270
			Vertex,
			// Token: 0x0400010F RID: 271
			Index
		}

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate IntPtr AllocateBufferDelegate(int elementCount, int elementStride, bool vertexBuffer);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate void FreeBufferDelegate(IntPtr buffer);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate void UpdateBufferRangesDelegate(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate void SetVectorArrayDelegate(IntPtr props, int name, IntPtr vector4s, int count);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void DrawRangesDelegate(IntPtr ib, IntPtr vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate void SetPropertyBlockDelegate(IntPtr props);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate void DisableScissorDelegate();

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate bool IsScissorEnabledDelegate();

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate bool HasMappedBufferRangeDelegate();

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate uint InsertCPUFenceDelegate();

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate bool CPUFencePassedDelegate(uint fence);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate void WaitForCPUFencePassedDelegate(uint fence);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate void SyncRenderThreadDelegate();

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate void ProfileDrawChainBeginDelegate();

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate void ProfileDrawChainEndDelegate();

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate void ProfileImmediateRendererBeginDelegate();

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate void ProfileImmediateRendererEndDelegate();

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate void NotifyOfUIREventsDelegate(bool subscribe);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate bool DebugIsMainThreadDelegate();

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate void RegisterIntermediateRenderer_InjectedDelegate(IntPtr camera, IntPtr material, IntPtr transform, IntPtr aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate void SetScissorRect_InjectedDelegate(IntPtr scissorRect);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate void GetActiveViewport_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate void GetUnityProjectionMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate void GetDeviceProjectionMatrix_InjectedDelegate([Out] IntPtr ret);
	}
}
