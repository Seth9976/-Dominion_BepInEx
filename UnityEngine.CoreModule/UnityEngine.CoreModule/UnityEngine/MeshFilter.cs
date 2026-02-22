using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000059 RID: 89
	public sealed class MeshFilter : Component
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x00029D24 File Offset: 0x00027F24
		// Note: this type is marked as 'beforefieldinit'.
		static MeshFilter()
		{
			Il2CppClassPointerStore<MeshFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr);
			MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100663710);
			MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100663711);
			MeshFilter.get_sharedMeshDelegateField = IL2CPP.ResolveICall<MeshFilter.get_sharedMeshDelegate>("UnityEngine.MeshFilter::get_sharedMesh");
			MeshFilter.get_meshDelegateField = IL2CPP.ResolveICall<MeshFilter.get_meshDelegate>("UnityEngine.MeshFilter::get_mesh");
			MeshFilter.set_meshDelegateField = IL2CPP.ResolveICall<MeshFilter.set_meshDelegate>("UnityEngine.MeshFilter::set_mesh");
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00029DAC File Offset: 0x00027FAC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00029E24 File Offset: 0x00028024
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00029DE0 File Offset: 0x00027FE0
		public unsafe Mesh sharedMesh
		{
			get
			{
				IntPtr intPtr = MeshFilter.get_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 63525, RefRangeEnd = 63532, XrefRangeStart = 63523, XrefRangeEnd = 63525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000073FA File Offset: 0x000055FA
		public MeshFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00029E50 File Offset: 0x00028050
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00007403 File Offset: 0x00005603
		public Mesh mesh
		{
			get
			{
				IntPtr intPtr = MeshFilter.get_meshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshFilter.set_meshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;

		// Token: 0x0400059E RID: 1438
		private static readonly MeshFilter.get_sharedMeshDelegate get_sharedMeshDelegateField;

		// Token: 0x0400059F RID: 1439
		private static readonly MeshFilter.get_meshDelegate get_meshDelegateField;

		// Token: 0x040005A0 RID: 1440
		private static readonly MeshFilter.set_meshDelegate set_meshDelegateField;

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x060029D5 RID: 10709
		private delegate IntPtr get_sharedMeshDelegate(IntPtr @this);

		// Token: 0x02000604 RID: 1540
		// (Invoke) Token: 0x060029D7 RID: 10711
		private delegate IntPtr get_meshDelegate(IntPtr @this);

		// Token: 0x02000605 RID: 1541
		// (Invoke) Token: 0x060029D9 RID: 10713
		private delegate void set_meshDelegate(IntPtr @this, IntPtr value);
	}
}
