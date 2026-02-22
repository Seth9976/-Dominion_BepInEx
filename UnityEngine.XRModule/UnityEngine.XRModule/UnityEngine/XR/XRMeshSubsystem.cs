using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000019 RID: 25
	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00005714 File Offset: 0x00003914
		// Note: this type is marked as 'beforefieldinit'.
		static XRMeshSubsystem()
		{
			Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr);
			XRMeshSubsystem.NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663351);
			XRMeshSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663352);
			XRMeshSubsystem.get_meshDensityDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.get_meshDensityDelegate>("UnityEngine.XR.XRMeshSubsystem::get_meshDensity");
			XRMeshSubsystem.set_meshDensityDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.set_meshDensityDelegate>("UnityEngine.XR.XRMeshSubsystem::set_meshDensity");
			XRMeshSubsystem.GenerateMeshAsync_InjectedDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.GenerateMeshAsync_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GenerateMeshAsync_Injected");
			XRMeshSubsystem.SetBoundingVolume_InjectedDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.SetBoundingVolume_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::SetBoundingVolume_Injected");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000057A8 File Offset: 0x000039A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158386, XrefRangeEnd = 158389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onMeshGenerationComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005804 File Offset: 0x00003A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158389, XrefRangeEnd = 158392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRMeshSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002C32 File Offset: 0x00000E32
		public XRMeshSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002C3B File Offset: 0x00000E3B
		public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
			this.GenerateMeshAsync_Injected(ref meshId, mesh, meshCollider, attributes, onMeshGenerationComplete);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002C4B File Offset: 0x00000E4B
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002C5D File Offset: 0x00000E5D
		public float meshDensity
		{
			get
			{
				return XRMeshSubsystem.get_meshDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRMeshSubsystem.set_meshDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002C70 File Offset: 0x00000E70
		public bool SetBoundingVolume(Vector3 origin, Vector3 extents)
		{
			return this.SetBoundingVolume_Injected(ref origin, ref extents);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002C7C File Offset: 0x00000E7C
		public void GenerateMeshAsync_Injected(ref MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
			XRMeshSubsystem.GenerateMeshAsync_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref meshId, IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(meshCollider), attributes, IL2CPP.Il2CppObjectBaseToPtr(onMeshGenerationComplete));
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public bool SetBoundingVolume_Injected(ref Vector3 origin, ref Vector3 extents)
		{
			return XRMeshSubsystem.SetBoundingVolume_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref origin, ref extents);
		}

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly XRMeshSubsystem.get_meshDensityDelegate get_meshDensityDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly XRMeshSubsystem.set_meshDensityDelegate set_meshDensityDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly XRMeshSubsystem.GenerateMeshAsync_InjectedDelegate GenerateMeshAsync_InjectedDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly XRMeshSubsystem.SetBoundingVolume_InjectedDelegate SetBoundingVolume_InjectedDelegateField;

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate float get_meshDensityDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate void set_meshDensityDelegate(IntPtr @this, float value);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate void GenerateMeshAsync_InjectedDelegate(IntPtr @this, IntPtr meshId, IntPtr mesh, IntPtr meshCollider, MeshVertexAttributes attributes, IntPtr onMeshGenerationComplete);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate bool SetBoundingVolume_InjectedDelegate(IntPtr @this, IntPtr origin, IntPtr extents);
	}
}
