using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D6 RID: 726
	public sealed class RayTracingAccelerationStructure
	{
		// Token: 0x06002302 RID: 8962 RVA: 0x0006A980 File Offset: 0x00068B80
		public ~RayTracingAccelerationStructure()
		{
			this.Dispose(false);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0001491D File Offset: 0x00012B1D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0001492F File Offset: 0x00012B2F
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0001493C File Offset: 0x00012B3C
		public static void Destroy(RayTracingAccelerationStructure accelStruct)
		{
			RayTracingAccelerationStructure.DestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(accelStruct));
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0001494E File Offset: 0x00012B4E
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00014958 File Offset: 0x00012B58
		public void Build()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00014967 File Offset: 0x00012B67
		public void Update()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00014976 File Offset: 0x00012B76
		public void Build(Vector3 relativeOrigin)
		{
			this.Build_Injected(ref relativeOrigin);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00014980 File Offset: 0x00012B80
		public void Update(Vector3 relativeOrigin)
		{
			this.Update_Injected(ref relativeOrigin);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0001498A File Offset: 0x00012B8A
		public void AddInstance(Renderer targetRenderer, [Optional] Il2CppStructArray<bool> subMeshMask, [Optional] Il2CppStructArray<bool> subMeshTransparencyFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask)
		{
			RayTracingAccelerationStructure.AddInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshMask), IL2CPP.Il2CppObjectBaseToPtr(subMeshTransparencyFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000149B4 File Offset: 0x00012BB4
		public void RemoveInstance(Renderer targetRenderer)
		{
			RayTracingAccelerationStructure.RemoveInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer));
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0006A9B4 File Offset: 0x00068BB4
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, Matrix4x4.identity, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0006A9DC File Offset: 0x00068BDC
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0006AA00 File Offset: 0x00068C00
		public void AddInstance_Procedural(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural_Injected(aabbBuffer, numElements, material, ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000149CC File Offset: 0x00012BCC
		public void UpdateInstanceTransform(Renderer renderer)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000149E4 File Offset: 0x00012BE4
		public void UpdateInstanceMask(Renderer renderer, uint mask)
		{
			RayTracingAccelerationStructure.UpdateInstanceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), mask);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000149FD File Offset: 0x00012BFD
		public ulong GetSize()
		{
			return RayTracingAccelerationStructure.GetSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00014A0F File Offset: 0x00012C0F
		public void Build_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Build_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00014A22 File Offset: 0x00012C22
		public void Update_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Update_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0006AA24 File Offset: 0x00068C24
		public void AddInstance_Procedural_Injected(GraphicsBuffer aabbBuffer, uint numElements, Material material, ref Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), numElements, IL2CPP.Il2CppObjectBaseToPtr(material), ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x04001BEC RID: 7148
		private static readonly RayTracingAccelerationStructure.DestroyDelegate DestroyDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.DestroyDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Destroy");

		// Token: 0x04001BED RID: 7149
		private static readonly RayTracingAccelerationStructure.AddInstanceDelegate AddInstanceDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance");

		// Token: 0x04001BEE RID: 7150
		private static readonly RayTracingAccelerationStructure.RemoveInstanceDelegate RemoveInstanceDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstanceDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance");

		// Token: 0x04001BEF RID: 7151
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransformDelegate UpdateInstanceTransformDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransformDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform");

		// Token: 0x04001BF0 RID: 7152
		private static readonly RayTracingAccelerationStructure.UpdateInstanceMaskDelegate UpdateInstanceMaskDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceMaskDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask");

		// Token: 0x04001BF1 RID: 7153
		private static readonly RayTracingAccelerationStructure.GetSizeDelegate GetSizeDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetSizeDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetSize");

		// Token: 0x04001BF2 RID: 7154
		private static readonly RayTracingAccelerationStructure.Build_InjectedDelegate Build_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Build_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Build_Injected");

		// Token: 0x04001BF3 RID: 7155
		private static readonly RayTracingAccelerationStructure.Update_InjectedDelegate Update_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Update_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Update_Injected");

		// Token: 0x04001BF4 RID: 7156
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate AddInstance_Procedural_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Injected");

		// Token: 0x02000D28 RID: 3368
		public enum RayTracingModeMask
		{
			// Token: 0x04001DB9 RID: 7609
			Nothing,
			// Token: 0x04001DBA RID: 7610
			Static = 2,
			// Token: 0x04001DBB RID: 7611
			DynamicTransform = 4,
			// Token: 0x04001DBC RID: 7612
			DynamicGeometry = 8,
			// Token: 0x04001DBD RID: 7613
			Everything = 14
		}

		// Token: 0x02000D29 RID: 3369
		public enum ManagementMode
		{
			// Token: 0x04001DBF RID: 7615
			Manual,
			// Token: 0x04001DC0 RID: 7616
			Automatic
		}

		// Token: 0x02000D2A RID: 3370
		// (Invoke) Token: 0x06003834 RID: 14388
		private delegate void DestroyDelegate(IntPtr accelStruct);

		// Token: 0x02000D2B RID: 3371
		// (Invoke) Token: 0x06003836 RID: 14390
		private delegate void AddInstanceDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshMask, IntPtr subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask);

		// Token: 0x02000D2C RID: 3372
		// (Invoke) Token: 0x06003838 RID: 14392
		private delegate void RemoveInstanceDelegate(IntPtr @this, IntPtr targetRenderer);

		// Token: 0x02000D2D RID: 3373
		// (Invoke) Token: 0x0600383A RID: 14394
		private delegate void UpdateInstanceTransformDelegate(IntPtr @this, IntPtr renderer);

		// Token: 0x02000D2E RID: 3374
		// (Invoke) Token: 0x0600383C RID: 14396
		private delegate void UpdateInstanceMaskDelegate(IntPtr @this, IntPtr renderer, uint mask);

		// Token: 0x02000D2F RID: 3375
		// (Invoke) Token: 0x0600383E RID: 14398
		private delegate ulong GetSizeDelegate(IntPtr @this);

		// Token: 0x02000D30 RID: 3376
		// (Invoke) Token: 0x06003840 RID: 14400
		private delegate void Build_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000D31 RID: 3377
		// (Invoke) Token: 0x06003842 RID: 14402
		private delegate void Update_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000D32 RID: 3378
		// (Invoke) Token: 0x06003844 RID: 14404
		private delegate void AddInstance_Procedural_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint numElements, IntPtr material, IntPtr instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds);
	}
}
