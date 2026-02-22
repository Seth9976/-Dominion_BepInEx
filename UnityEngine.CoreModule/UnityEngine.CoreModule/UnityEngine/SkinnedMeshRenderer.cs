using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200006C RID: 108
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x060008FA RID: 2298 RVA: 0x00029E7C File Offset: 0x0002807C
		// Note: this type is marked as 'beforefieldinit'.
		static SkinnedMeshRenderer()
		{
			Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SkinnedMeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr);
			SkinnedMeshRenderer.get_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::get_quality");
			SkinnedMeshRenderer.set_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::set_quality");
			SkinnedMeshRenderer.get_updateWhenOffscreenDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_updateWhenOffscreenDelegate>("UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen");
			SkinnedMeshRenderer.set_updateWhenOffscreenDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_updateWhenOffscreenDelegate>("UnityEngine.SkinnedMeshRenderer::set_updateWhenOffscreen");
			SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::get_forceMatrixRecalculationPerRender");
			SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::set_forceMatrixRecalculationPerRender");
			SkinnedMeshRenderer.get_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::get_rootBone");
			SkinnedMeshRenderer.set_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::set_rootBone");
			SkinnedMeshRenderer.get_bonesDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_bonesDelegate>("UnityEngine.SkinnedMeshRenderer::get_bones");
			SkinnedMeshRenderer.set_bonesDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_bonesDelegate>("UnityEngine.SkinnedMeshRenderer::set_bones");
			SkinnedMeshRenderer.get_sharedMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_sharedMeshDelegate>("UnityEngine.SkinnedMeshRenderer::get_sharedMesh");
			SkinnedMeshRenderer.set_sharedMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_sharedMeshDelegate>("UnityEngine.SkinnedMeshRenderer::set_sharedMesh");
			SkinnedMeshRenderer.get_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors");
			SkinnedMeshRenderer.set_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors");
			SkinnedMeshRenderer.GetBlendShapeWeightDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetBlendShapeWeightDelegate>("UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight");
			SkinnedMeshRenderer.SetBlendShapeWeightDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.SetBlendShapeWeightDelegate>("UnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight");
			SkinnedMeshRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.BakeMeshDelegate>("UnityEngine.SkinnedMeshRenderer::BakeMesh");
			SkinnedMeshRenderer.GetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetLocalAABB_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::GetLocalAABB_Injected");
			SkinnedMeshRenderer.SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.SetLocalAABB_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::SetLocalAABB_Injected");
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0000741B File Offset: 0x0000561B
		public SkinnedMeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00007436 File Offset: 0x00005636
		public SkinQuality quality
		{
			get
			{
				return SkinnedMeshRenderer.get_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00007449 File Offset: 0x00005649
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0000745B File Offset: 0x0000565B
		public bool updateWhenOffscreen
		{
			get
			{
				return SkinnedMeshRenderer.get_updateWhenOffscreenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_updateWhenOffscreenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0000746E File Offset: 0x0000566E
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00007480 File Offset: 0x00005680
		public bool forceMatrixRecalculationPerRender
		{
			get
			{
				return SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00029FCC File Offset: 0x000281CC
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00007493 File Offset: 0x00005693
		public Transform rootBone
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00029FF8 File Offset: 0x000281F8
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x000074AB File Offset: 0x000056AB
		public Il2CppReferenceArray<Transform> bones
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_bonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_bonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002A024 File Offset: 0x00028224
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000074C3 File Offset: 0x000056C3
		public Mesh sharedMesh
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x000074DB File Offset: 0x000056DB
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000074ED File Offset: 0x000056ED
		public bool skinnedMotionVectors
		{
			get
			{
				return SkinnedMeshRenderer.get_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00007500 File Offset: 0x00005700
		public float GetBlendShapeWeight(int index)
		{
			return SkinnedMeshRenderer.GetBlendShapeWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00007513 File Offset: 0x00005713
		public void SetBlendShapeWeight(int index, float value)
		{
			SkinnedMeshRenderer.SetBlendShapeWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00007527 File Offset: 0x00005727
		public void BakeMesh(Mesh mesh)
		{
			this.BakeMesh(mesh, false);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00007533 File Offset: 0x00005733
		public void BakeMesh(Mesh mesh, bool useScale)
		{
			SkinnedMeshRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), useScale);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0002A050 File Offset: 0x00028250
		public Bounds GetLocalAABB()
		{
			Bounds bounds;
			this.GetLocalAABB_Injected(out bounds);
			return bounds;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0000754C File Offset: 0x0000574C
		public void SetLocalAABB(Bounds b)
		{
			this.SetLocalAABB_Injected(ref b);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002A068 File Offset: 0x00028268
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00007556 File Offset: 0x00005756
		public Bounds localBounds
		{
			get
			{
				return this.GetLocalAABB();
			}
			set
			{
				this.SetLocalAABB(value);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00007561 File Offset: 0x00005761
		public void GetLocalAABB_Injected(out Bounds ret)
		{
			SkinnedMeshRenderer.GetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00007574 File Offset: 0x00005774
		public void SetLocalAABB_Injected(ref Bounds b)
		{
			SkinnedMeshRenderer.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref b);
		}

		// Token: 0x0400065D RID: 1629
		private static readonly SkinnedMeshRenderer.get_qualityDelegate get_qualityDelegateField;

		// Token: 0x0400065E RID: 1630
		private static readonly SkinnedMeshRenderer.set_qualityDelegate set_qualityDelegateField;

		// Token: 0x0400065F RID: 1631
		private static readonly SkinnedMeshRenderer.get_updateWhenOffscreenDelegate get_updateWhenOffscreenDelegateField;

		// Token: 0x04000660 RID: 1632
		private static readonly SkinnedMeshRenderer.set_updateWhenOffscreenDelegate set_updateWhenOffscreenDelegateField;

		// Token: 0x04000661 RID: 1633
		private static readonly SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate get_forceMatrixRecalculationPerRenderDelegateField;

		// Token: 0x04000662 RID: 1634
		private static readonly SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate set_forceMatrixRecalculationPerRenderDelegateField;

		// Token: 0x04000663 RID: 1635
		private static readonly SkinnedMeshRenderer.get_rootBoneDelegate get_rootBoneDelegateField;

		// Token: 0x04000664 RID: 1636
		private static readonly SkinnedMeshRenderer.set_rootBoneDelegate set_rootBoneDelegateField;

		// Token: 0x04000665 RID: 1637
		private static readonly SkinnedMeshRenderer.get_bonesDelegate get_bonesDelegateField;

		// Token: 0x04000666 RID: 1638
		private static readonly SkinnedMeshRenderer.set_bonesDelegate set_bonesDelegateField;

		// Token: 0x04000667 RID: 1639
		private static readonly SkinnedMeshRenderer.get_sharedMeshDelegate get_sharedMeshDelegateField;

		// Token: 0x04000668 RID: 1640
		private static readonly SkinnedMeshRenderer.set_sharedMeshDelegate set_sharedMeshDelegateField;

		// Token: 0x04000669 RID: 1641
		private static readonly SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate get_skinnedMotionVectorsDelegateField;

		// Token: 0x0400066A RID: 1642
		private static readonly SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate set_skinnedMotionVectorsDelegateField;

		// Token: 0x0400066B RID: 1643
		private static readonly SkinnedMeshRenderer.GetBlendShapeWeightDelegate GetBlendShapeWeightDelegateField;

		// Token: 0x0400066C RID: 1644
		private static readonly SkinnedMeshRenderer.SetBlendShapeWeightDelegate SetBlendShapeWeightDelegateField;

		// Token: 0x0400066D RID: 1645
		private static readonly SkinnedMeshRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400066E RID: 1646
		private static readonly SkinnedMeshRenderer.GetLocalAABB_InjectedDelegate GetLocalAABB_InjectedDelegateField;

		// Token: 0x0400066F RID: 1647
		private static readonly SkinnedMeshRenderer.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField;

		// Token: 0x02000606 RID: 1542
		// (Invoke) Token: 0x060029DB RID: 10715
		private delegate SkinQuality get_qualityDelegate(IntPtr @this);

		// Token: 0x02000607 RID: 1543
		// (Invoke) Token: 0x060029DD RID: 10717
		private delegate void set_qualityDelegate(IntPtr @this, SkinQuality value);

		// Token: 0x02000608 RID: 1544
		// (Invoke) Token: 0x060029DF RID: 10719
		private delegate bool get_updateWhenOffscreenDelegate(IntPtr @this);

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x060029E1 RID: 10721
		private delegate void set_updateWhenOffscreenDelegate(IntPtr @this, bool value);

		// Token: 0x0200060A RID: 1546
		// (Invoke) Token: 0x060029E3 RID: 10723
		private delegate bool get_forceMatrixRecalculationPerRenderDelegate(IntPtr @this);

		// Token: 0x0200060B RID: 1547
		// (Invoke) Token: 0x060029E5 RID: 10725
		private delegate void set_forceMatrixRecalculationPerRenderDelegate(IntPtr @this, bool value);

		// Token: 0x0200060C RID: 1548
		// (Invoke) Token: 0x060029E7 RID: 10727
		private delegate IntPtr get_rootBoneDelegate(IntPtr @this);

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x060029E9 RID: 10729
		private delegate void set_rootBoneDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x060029EB RID: 10731
		private delegate IntPtr get_bonesDelegate(IntPtr @this);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x060029ED RID: 10733
		private delegate void set_bonesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000610 RID: 1552
		// (Invoke) Token: 0x060029EF RID: 10735
		private delegate IntPtr get_sharedMeshDelegate(IntPtr @this);

		// Token: 0x02000611 RID: 1553
		// (Invoke) Token: 0x060029F1 RID: 10737
		private delegate void set_sharedMeshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000612 RID: 1554
		// (Invoke) Token: 0x060029F3 RID: 10739
		private delegate bool get_skinnedMotionVectorsDelegate(IntPtr @this);

		// Token: 0x02000613 RID: 1555
		// (Invoke) Token: 0x060029F5 RID: 10741
		private delegate void set_skinnedMotionVectorsDelegate(IntPtr @this, bool value);

		// Token: 0x02000614 RID: 1556
		// (Invoke) Token: 0x060029F7 RID: 10743
		private delegate float GetBlendShapeWeightDelegate(IntPtr @this, int index);

		// Token: 0x02000615 RID: 1557
		// (Invoke) Token: 0x060029F9 RID: 10745
		private delegate void SetBlendShapeWeightDelegate(IntPtr @this, int index, float value);

		// Token: 0x02000616 RID: 1558
		// (Invoke) Token: 0x060029FB RID: 10747
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, bool useScale);

		// Token: 0x02000617 RID: 1559
		// (Invoke) Token: 0x060029FD RID: 10749
		private delegate void GetLocalAABB_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000618 RID: 1560
		// (Invoke) Token: 0x060029FF RID: 10751
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr @this, IntPtr b);
	}
}
