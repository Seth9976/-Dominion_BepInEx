using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020001EA RID: 490
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000630BC File Offset: 0x000612BC
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000102F7 File Offset: 0x0000E4F7
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00010309 File Offset: 0x0000E509
		public float time
		{
			get
			{
				return TrailRenderer.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0001031C File Offset: 0x0000E51C
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0001032E File Offset: 0x0000E52E
		public float startWidth
		{
			get
			{
				return TrailRenderer.get_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00010341 File Offset: 0x0000E541
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00010353 File Offset: 0x0000E553
		public float endWidth
		{
			get
			{
				return TrailRenderer.get_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00010366 File Offset: 0x0000E566
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00010378 File Offset: 0x0000E578
		public float widthMultiplier
		{
			get
			{
				return TrailRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0001038B File Offset: 0x0000E58B
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0001039D File Offset: 0x0000E59D
		public bool autodestruct
		{
			get
			{
				return TrailRenderer.get_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000103B0 File Offset: 0x0000E5B0
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x000103C2 File Offset: 0x0000E5C2
		public bool emitting
		{
			get
			{
				return TrailRenderer.get_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x000103D5 File Offset: 0x0000E5D5
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x000103E7 File Offset: 0x0000E5E7
		public int numCornerVertices
		{
			get
			{
				return TrailRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x000103FA File Offset: 0x0000E5FA
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x0001040C File Offset: 0x0000E60C
		public int numCapVertices
		{
			get
			{
				return TrailRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0001041F File Offset: 0x0000E61F
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00010431 File Offset: 0x0000E631
		public float minVertexDistance
		{
			get
			{
				return TrailRenderer.get_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x000630D4 File Offset: 0x000612D4
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00010444 File Offset: 0x0000E644
		public Color startColor
		{
			get
			{
				Color color;
				this.get_startColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_startColor_Injected(ref value);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000630EC File Offset: 0x000612EC
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0001044E File Offset: 0x0000E64E
		public Color endColor
		{
			get
			{
				Color color;
				this.get_endColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_endColor_Injected(ref value);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00010458 File Offset: 0x0000E658
		public int positionCount
		{
			get
			{
				return TrailRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0001046A File Offset: 0x0000E66A
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00063104 File Offset: 0x00061304
		public Vector3 GetPosition(int index)
		{
			Vector3 vector;
			this.GetPosition_Injected(index, out vector);
			return vector;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00010475 File Offset: 0x0000E675
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00010487 File Offset: 0x0000E687
		public float shadowBias
		{
			get
			{
				return TrailRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0001049A File Offset: 0x0000E69A
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x000104AC File Offset: 0x0000E6AC
		public bool generateLightingData
		{
			get
			{
				return TrailRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x000104BF File Offset: 0x0000E6BF
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x000104D1 File Offset: 0x0000E6D1
		public LineTextureMode textureMode
		{
			get
			{
				return TrailRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x000104E4 File Offset: 0x0000E6E4
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x000104F6 File Offset: 0x0000E6F6
		public LineAlignment alignment
		{
			get
			{
				return TrailRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00010509 File Offset: 0x0000E709
		public void Clear()
		{
			TrailRenderer.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0001051B File Offset: 0x0000E71B
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0001052C File Offset: 0x0000E72C
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			TrailRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0006311C File Offset: 0x0006131C
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0001054B File Offset: 0x0000E74B
		public AnimationCurve widthCurve
		{
			get
			{
				return this.GetWidthCurveCopy();
			}
			set
			{
				this.SetWidthCurve(value);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00063134 File Offset: 0x00061334
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00010556 File Offset: 0x0000E756
		public Gradient colorGradient
		{
			get
			{
				return this.GetColorGradientCopy();
			}
			set
			{
				this.SetColorGradient(value);
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0006314C File Offset: 0x0006134C
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = TrailRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00010561 File Offset: 0x0000E761
		public void SetWidthCurve(AnimationCurve curve)
		{
			TrailRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00063178 File Offset: 0x00061378
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = TrailRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00010579 File Offset: 0x0000E779
		public void SetColorGradient(Gradient curve)
		{
			TrailRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00010591 File Offset: 0x0000E791
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000105A9 File Offset: 0x0000E7A9
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000105C1 File Offset: 0x0000E7C1
		public void AddPosition(Vector3 position)
		{
			this.AddPosition_Injected(ref position);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000105CB File Offset: 0x0000E7CB
		public void AddPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.AddPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000105E3 File Offset: 0x0000E7E3
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000631A4 File Offset: 0x000613A4
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00010601 File Offset: 0x0000E801
		public void AddPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0001061F File Offset: 0x0000E81F
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			TrailRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00010633 File Offset: 0x0000E833
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00010647 File Offset: 0x0000E847
		public void AddPositionsWithNativeContainer(IntPtr positions, int length)
		{
			TrailRenderer.AddPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0001065B File Offset: 0x0000E85B
		public void get_startColor_Injected(out Color ret)
		{
			TrailRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0001066E File Offset: 0x0000E86E
		public void set_startColor_Injected(ref Color value)
		{
			TrailRenderer.set_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00010681 File Offset: 0x0000E881
		public void get_endColor_Injected(out Color ret)
		{
			TrailRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00010694 File Offset: 0x0000E894
		public void set_endColor_Injected(ref Color value)
		{
			TrailRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000106A7 File Offset: 0x0000E8A7
		public void SetPosition_Injected(int index, ref Vector3 position)
		{
			TrailRenderer.SetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref position);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000106BB File Offset: 0x0000E8BB
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			TrailRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000106CF File Offset: 0x0000E8CF
		public void AddPosition_Injected(ref Vector3 position)
		{
			TrailRenderer.AddPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x040016EF RID: 5871
		private static readonly TrailRenderer.get_timeDelegate get_timeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_timeDelegate>("UnityEngine.TrailRenderer::get_time");

		// Token: 0x040016F0 RID: 5872
		private static readonly TrailRenderer.set_timeDelegate set_timeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_timeDelegate>("UnityEngine.TrailRenderer::set_time");

		// Token: 0x040016F1 RID: 5873
		private static readonly TrailRenderer.get_startWidthDelegate get_startWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_startWidthDelegate>("UnityEngine.TrailRenderer::get_startWidth");

		// Token: 0x040016F2 RID: 5874
		private static readonly TrailRenderer.set_startWidthDelegate set_startWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_startWidthDelegate>("UnityEngine.TrailRenderer::set_startWidth");

		// Token: 0x040016F3 RID: 5875
		private static readonly TrailRenderer.get_endWidthDelegate get_endWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endWidthDelegate>("UnityEngine.TrailRenderer::get_endWidth");

		// Token: 0x040016F4 RID: 5876
		private static readonly TrailRenderer.set_endWidthDelegate set_endWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endWidthDelegate>("UnityEngine.TrailRenderer::set_endWidth");

		// Token: 0x040016F5 RID: 5877
		private static readonly TrailRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_widthMultiplierDelegate>("UnityEngine.TrailRenderer::get_widthMultiplier");

		// Token: 0x040016F6 RID: 5878
		private static readonly TrailRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_widthMultiplierDelegate>("UnityEngine.TrailRenderer::set_widthMultiplier");

		// Token: 0x040016F7 RID: 5879
		private static readonly TrailRenderer.get_autodestructDelegate get_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_autodestructDelegate>("UnityEngine.TrailRenderer::get_autodestruct");

		// Token: 0x040016F8 RID: 5880
		private static readonly TrailRenderer.set_autodestructDelegate set_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_autodestructDelegate>("UnityEngine.TrailRenderer::set_autodestruct");

		// Token: 0x040016F9 RID: 5881
		private static readonly TrailRenderer.get_emittingDelegate get_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_emittingDelegate>("UnityEngine.TrailRenderer::get_emitting");

		// Token: 0x040016FA RID: 5882
		private static readonly TrailRenderer.set_emittingDelegate set_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_emittingDelegate>("UnityEngine.TrailRenderer::set_emitting");

		// Token: 0x040016FB RID: 5883
		private static readonly TrailRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::get_numCornerVertices");

		// Token: 0x040016FC RID: 5884
		private static readonly TrailRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::set_numCornerVertices");

		// Token: 0x040016FD RID: 5885
		private static readonly TrailRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCapVerticesDelegate>("UnityEngine.TrailRenderer::get_numCapVertices");

		// Token: 0x040016FE RID: 5886
		private static readonly TrailRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCapVerticesDelegate>("UnityEngine.TrailRenderer::set_numCapVertices");

		// Token: 0x040016FF RID: 5887
		private static readonly TrailRenderer.get_minVertexDistanceDelegate get_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::get_minVertexDistance");

		// Token: 0x04001700 RID: 5888
		private static readonly TrailRenderer.set_minVertexDistanceDelegate set_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::set_minVertexDistance");

		// Token: 0x04001701 RID: 5889
		private static readonly TrailRenderer.get_positionCountDelegate get_positionCountDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_positionCountDelegate>("UnityEngine.TrailRenderer::get_positionCount");

		// Token: 0x04001702 RID: 5890
		private static readonly TrailRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_shadowBiasDelegate>("UnityEngine.TrailRenderer::get_shadowBias");

		// Token: 0x04001703 RID: 5891
		private static readonly TrailRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_shadowBiasDelegate>("UnityEngine.TrailRenderer::set_shadowBias");

		// Token: 0x04001704 RID: 5892
		private static readonly TrailRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_generateLightingDataDelegate>("UnityEngine.TrailRenderer::get_generateLightingData");

		// Token: 0x04001705 RID: 5893
		private static readonly TrailRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_generateLightingDataDelegate>("UnityEngine.TrailRenderer::set_generateLightingData");

		// Token: 0x04001706 RID: 5894
		private static readonly TrailRenderer.get_textureModeDelegate get_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureModeDelegate>("UnityEngine.TrailRenderer::get_textureMode");

		// Token: 0x04001707 RID: 5895
		private static readonly TrailRenderer.set_textureModeDelegate set_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureModeDelegate>("UnityEngine.TrailRenderer::set_textureMode");

		// Token: 0x04001708 RID: 5896
		private static readonly TrailRenderer.get_alignmentDelegate get_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_alignmentDelegate>("UnityEngine.TrailRenderer::get_alignment");

		// Token: 0x04001709 RID: 5897
		private static readonly TrailRenderer.set_alignmentDelegate set_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_alignmentDelegate>("UnityEngine.TrailRenderer::set_alignment");

		// Token: 0x0400170A RID: 5898
		private static readonly TrailRenderer.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<TrailRenderer.ClearDelegate>("UnityEngine.TrailRenderer::Clear");

		// Token: 0x0400170B RID: 5899
		private static readonly TrailRenderer.BakeMeshDelegate BakeMeshDelegateField = IL2CPP.ResolveICall<TrailRenderer.BakeMeshDelegate>("UnityEngine.TrailRenderer::BakeMesh");

		// Token: 0x0400170C RID: 5900
		private static readonly TrailRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetWidthCurveCopyDelegate>("UnityEngine.TrailRenderer::GetWidthCurveCopy");

		// Token: 0x0400170D RID: 5901
		private static readonly TrailRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetWidthCurveDelegate>("UnityEngine.TrailRenderer::SetWidthCurve");

		// Token: 0x0400170E RID: 5902
		private static readonly TrailRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetColorGradientCopyDelegate>("UnityEngine.TrailRenderer::GetColorGradientCopy");

		// Token: 0x0400170F RID: 5903
		private static readonly TrailRenderer.SetColorGradientDelegate SetColorGradientDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetColorGradientDelegate>("UnityEngine.TrailRenderer::SetColorGradient");

		// Token: 0x04001710 RID: 5904
		private static readonly TrailRenderer.GetPositionsDelegate GetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsDelegate>("UnityEngine.TrailRenderer::GetPositions");

		// Token: 0x04001711 RID: 5905
		private static readonly TrailRenderer.SetPositionsDelegate SetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsDelegate>("UnityEngine.TrailRenderer::SetPositions");

		// Token: 0x04001712 RID: 5906
		private static readonly TrailRenderer.AddPositionsDelegate AddPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsDelegate>("UnityEngine.TrailRenderer::AddPositions");

		// Token: 0x04001713 RID: 5907
		private static readonly TrailRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::SetPositionsWithNativeContainer");

		// Token: 0x04001714 RID: 5908
		private static readonly TrailRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetPositionsWithNativeContainer");

		// Token: 0x04001715 RID: 5909
		private static readonly TrailRenderer.AddPositionsWithNativeContainerDelegate AddPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::AddPositionsWithNativeContainer");

		// Token: 0x04001716 RID: 5910
		private static readonly TrailRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_startColor_Injected");

		// Token: 0x04001717 RID: 5911
		private static readonly TrailRenderer.set_startColor_InjectedDelegate set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_startColor_Injected");

		// Token: 0x04001718 RID: 5912
		private static readonly TrailRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_endColor_Injected");

		// Token: 0x04001719 RID: 5913
		private static readonly TrailRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_endColor_Injected");

		// Token: 0x0400171A RID: 5914
		private static readonly TrailRenderer.SetPosition_InjectedDelegate SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::SetPosition_Injected");

		// Token: 0x0400171B RID: 5915
		private static readonly TrailRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::GetPosition_Injected");

		// Token: 0x0400171C RID: 5916
		private static readonly TrailRenderer.AddPosition_InjectedDelegate AddPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPosition_InjectedDelegate>("UnityEngine.TrailRenderer::AddPosition_Injected");

		// Token: 0x02000B09 RID: 2825
		// (Invoke) Token: 0x06003412 RID: 13330
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000B0A RID: 2826
		// (Invoke) Token: 0x06003414 RID: 13332
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000B0B RID: 2827
		// (Invoke) Token: 0x06003416 RID: 13334
		private delegate float get_startWidthDelegate(IntPtr @this);

		// Token: 0x02000B0C RID: 2828
		// (Invoke) Token: 0x06003418 RID: 13336
		private delegate void set_startWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000B0D RID: 2829
		// (Invoke) Token: 0x0600341A RID: 13338
		private delegate float get_endWidthDelegate(IntPtr @this);

		// Token: 0x02000B0E RID: 2830
		// (Invoke) Token: 0x0600341C RID: 13340
		private delegate void set_endWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000B0F RID: 2831
		// (Invoke) Token: 0x0600341E RID: 13342
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x02000B10 RID: 2832
		// (Invoke) Token: 0x06003420 RID: 13344
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x02000B11 RID: 2833
		// (Invoke) Token: 0x06003422 RID: 13346
		private delegate bool get_autodestructDelegate(IntPtr @this);

		// Token: 0x02000B12 RID: 2834
		// (Invoke) Token: 0x06003424 RID: 13348
		private delegate void set_autodestructDelegate(IntPtr @this, bool value);

		// Token: 0x02000B13 RID: 2835
		// (Invoke) Token: 0x06003426 RID: 13350
		private delegate bool get_emittingDelegate(IntPtr @this);

		// Token: 0x02000B14 RID: 2836
		// (Invoke) Token: 0x06003428 RID: 13352
		private delegate void set_emittingDelegate(IntPtr @this, bool value);

		// Token: 0x02000B15 RID: 2837
		// (Invoke) Token: 0x0600342A RID: 13354
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x02000B16 RID: 2838
		// (Invoke) Token: 0x0600342C RID: 13356
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000B17 RID: 2839
		// (Invoke) Token: 0x0600342E RID: 13358
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x02000B18 RID: 2840
		// (Invoke) Token: 0x06003430 RID: 13360
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000B19 RID: 2841
		// (Invoke) Token: 0x06003432 RID: 13362
		private delegate float get_minVertexDistanceDelegate(IntPtr @this);

		// Token: 0x02000B1A RID: 2842
		// (Invoke) Token: 0x06003434 RID: 13364
		private delegate void set_minVertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000B1B RID: 2843
		// (Invoke) Token: 0x06003436 RID: 13366
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x02000B1C RID: 2844
		// (Invoke) Token: 0x06003438 RID: 13368
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x02000B1D RID: 2845
		// (Invoke) Token: 0x0600343A RID: 13370
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000B1E RID: 2846
		// (Invoke) Token: 0x0600343C RID: 13372
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x02000B1F RID: 2847
		// (Invoke) Token: 0x0600343E RID: 13374
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x02000B20 RID: 2848
		// (Invoke) Token: 0x06003440 RID: 13376
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x02000B21 RID: 2849
		// (Invoke) Token: 0x06003442 RID: 13378
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x02000B22 RID: 2850
		// (Invoke) Token: 0x06003444 RID: 13380
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000B23 RID: 2851
		// (Invoke) Token: 0x06003446 RID: 13382
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x02000B24 RID: 2852
		// (Invoke) Token: 0x06003448 RID: 13384
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000B25 RID: 2853
		// (Invoke) Token: 0x0600344A RID: 13386
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000B26 RID: 2854
		// (Invoke) Token: 0x0600344C RID: 13388
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x02000B27 RID: 2855
		// (Invoke) Token: 0x0600344E RID: 13390
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000B28 RID: 2856
		// (Invoke) Token: 0x06003450 RID: 13392
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x02000B29 RID: 2857
		// (Invoke) Token: 0x06003452 RID: 13394
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000B2A RID: 2858
		// (Invoke) Token: 0x06003454 RID: 13396
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x02000B2B RID: 2859
		// (Invoke) Token: 0x06003456 RID: 13398
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000B2C RID: 2860
		// (Invoke) Token: 0x06003458 RID: 13400
		private delegate void AddPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000B2D RID: 2861
		// (Invoke) Token: 0x0600345A RID: 13402
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x02000B2E RID: 2862
		// (Invoke) Token: 0x0600345C RID: 13404
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000B2F RID: 2863
		// (Invoke) Token: 0x0600345E RID: 13406
		private delegate void AddPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000B30 RID: 2864
		// (Invoke) Token: 0x06003460 RID: 13408
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B31 RID: 2865
		// (Invoke) Token: 0x06003462 RID: 13410
		private delegate void set_startColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B32 RID: 2866
		// (Invoke) Token: 0x06003464 RID: 13412
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B33 RID: 2867
		// (Invoke) Token: 0x06003466 RID: 13414
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B34 RID: 2868
		// (Invoke) Token: 0x06003468 RID: 13416
		private delegate void SetPosition_InjectedDelegate(IntPtr @this, int index, IntPtr position);

		// Token: 0x02000B35 RID: 2869
		// (Invoke) Token: 0x0600346A RID: 13418
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x02000B36 RID: 2870
		// (Invoke) Token: 0x0600346C RID: 13420
		private delegate void AddPosition_InjectedDelegate(IntPtr @this, IntPtr position);
	}
}
