using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020001EB RID: 491
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x000106E2 File Offset: 0x0000E8E2
		public void SetWidth(float start, float end)
		{
			this.startWidth = start;
			this.endWidth = end;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000106F5 File Offset: 0x0000E8F5
		public void SetColors(Color start, Color end)
		{
			this.startColor = start;
			this.endColor = end;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00010708 File Offset: 0x0000E908
		public void SetVertexCount(int count)
		{
			this.positionCount = count;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00063438 File Offset: 0x00061638
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00010713 File Offset: 0x0000E913
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
			set
			{
				this.positionCount = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0001071E File Offset: 0x0000E91E
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00010730 File Offset: 0x0000E930
		public float startWidth
		{
			get
			{
				return LineRenderer.get_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00010743 File Offset: 0x0000E943
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00010755 File Offset: 0x0000E955
		public float endWidth
		{
			get
			{
				return LineRenderer.get_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00010768 File Offset: 0x0000E968
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0001077A File Offset: 0x0000E97A
		public float widthMultiplier
		{
			get
			{
				return LineRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0001078D File Offset: 0x0000E98D
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0001079F File Offset: 0x0000E99F
		public int numCornerVertices
		{
			get
			{
				return LineRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000107B2 File Offset: 0x0000E9B2
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x000107C4 File Offset: 0x0000E9C4
		public int numCapVertices
		{
			get
			{
				return LineRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000107D7 File Offset: 0x0000E9D7
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x000107E9 File Offset: 0x0000E9E9
		public bool useWorldSpace
		{
			get
			{
				return LineRenderer.get_useWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_useWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x000107FC File Offset: 0x0000E9FC
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0001080E File Offset: 0x0000EA0E
		public bool loop
		{
			get
			{
				return LineRenderer.get_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00063450 File Offset: 0x00061650
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x00010821 File Offset: 0x0000EA21
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00063468 File Offset: 0x00061668
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0001082B File Offset: 0x0000EA2B
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00010835 File Offset: 0x0000EA35
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00010847 File Offset: 0x0000EA47
		public int positionCount
		{
			get
			{
				return LineRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0001085A File Offset: 0x0000EA5A
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00063480 File Offset: 0x00061680
		public Vector3 GetPosition(int index)
		{
			Vector3 vector;
			this.GetPosition_Injected(index, out vector);
			return vector;
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00010865 File Offset: 0x0000EA65
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00010877 File Offset: 0x0000EA77
		public float shadowBias
		{
			get
			{
				return LineRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0001088A File Offset: 0x0000EA8A
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0001089C File Offset: 0x0000EA9C
		public bool generateLightingData
		{
			get
			{
				return LineRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000108AF File Offset: 0x0000EAAF
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x000108C1 File Offset: 0x0000EAC1
		public LineTextureMode textureMode
		{
			get
			{
				return LineRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000108D4 File Offset: 0x0000EAD4
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x000108E6 File Offset: 0x0000EAE6
		public LineAlignment alignment
		{
			get
			{
				return LineRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000108F9 File Offset: 0x0000EAF9
		public void Simplify(float tolerance)
		{
			LineRenderer.SimplifyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tolerance);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0001090C File Offset: 0x0000EB0C
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0001091D File Offset: 0x0000EB1D
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			LineRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00063498 File Offset: 0x00061698
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0001093C File Offset: 0x0000EB3C
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000634B0 File Offset: 0x000616B0
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00010947 File Offset: 0x0000EB47
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

		// Token: 0x06001D8C RID: 7564 RVA: 0x000634C8 File Offset: 0x000616C8
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = LineRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00010952 File Offset: 0x0000EB52
		public void SetWidthCurve(AnimationCurve curve)
		{
			LineRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x000634F4 File Offset: 0x000616F4
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = LineRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0001096A File Offset: 0x0000EB6A
		public void SetColorGradient(Gradient curve)
		{
			LineRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00010982 File Offset: 0x0000EB82
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return LineRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0001099A File Offset: 0x0000EB9A
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			LineRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000109B2 File Offset: 0x0000EBB2
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00063520 File Offset: 0x00061720
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			LineRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000109E4 File Offset: 0x0000EBE4
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return LineRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000109F8 File Offset: 0x0000EBF8
		public void get_startColor_Injected(out Color ret)
		{
			LineRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00010A0B File Offset: 0x0000EC0B
		public void set_startColor_Injected(ref Color value)
		{
			LineRenderer.set_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00010A1E File Offset: 0x0000EC1E
		public void get_endColor_Injected(out Color ret)
		{
			LineRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00010A31 File Offset: 0x0000EC31
		public void set_endColor_Injected(ref Color value)
		{
			LineRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00010A44 File Offset: 0x0000EC44
		public void SetPosition_Injected(int index, ref Vector3 position)
		{
			LineRenderer.SetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref position);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00010A58 File Offset: 0x0000EC58
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			LineRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x0400171D RID: 5917
		private static readonly LineRenderer.get_startWidthDelegate get_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startWidthDelegate>("UnityEngine.LineRenderer::get_startWidth");

		// Token: 0x0400171E RID: 5918
		private static readonly LineRenderer.set_startWidthDelegate set_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_startWidthDelegate>("UnityEngine.LineRenderer::set_startWidth");

		// Token: 0x0400171F RID: 5919
		private static readonly LineRenderer.get_endWidthDelegate get_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endWidthDelegate>("UnityEngine.LineRenderer::get_endWidth");

		// Token: 0x04001720 RID: 5920
		private static readonly LineRenderer.set_endWidthDelegate set_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_endWidthDelegate>("UnityEngine.LineRenderer::set_endWidth");

		// Token: 0x04001721 RID: 5921
		private static readonly LineRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.get_widthMultiplierDelegate>("UnityEngine.LineRenderer::get_widthMultiplier");

		// Token: 0x04001722 RID: 5922
		private static readonly LineRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.set_widthMultiplierDelegate>("UnityEngine.LineRenderer::set_widthMultiplier");

		// Token: 0x04001723 RID: 5923
		private static readonly LineRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCornerVerticesDelegate>("UnityEngine.LineRenderer::get_numCornerVertices");

		// Token: 0x04001724 RID: 5924
		private static readonly LineRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCornerVerticesDelegate>("UnityEngine.LineRenderer::set_numCornerVertices");

		// Token: 0x04001725 RID: 5925
		private static readonly LineRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCapVerticesDelegate>("UnityEngine.LineRenderer::get_numCapVertices");

		// Token: 0x04001726 RID: 5926
		private static readonly LineRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCapVerticesDelegate>("UnityEngine.LineRenderer::set_numCapVertices");

		// Token: 0x04001727 RID: 5927
		private static readonly LineRenderer.get_useWorldSpaceDelegate get_useWorldSpaceDelegateField = IL2CPP.ResolveICall<LineRenderer.get_useWorldSpaceDelegate>("UnityEngine.LineRenderer::get_useWorldSpace");

		// Token: 0x04001728 RID: 5928
		private static readonly LineRenderer.set_useWorldSpaceDelegate set_useWorldSpaceDelegateField = IL2CPP.ResolveICall<LineRenderer.set_useWorldSpaceDelegate>("UnityEngine.LineRenderer::set_useWorldSpace");

		// Token: 0x04001729 RID: 5929
		private static readonly LineRenderer.get_loopDelegate get_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.get_loopDelegate>("UnityEngine.LineRenderer::get_loop");

		// Token: 0x0400172A RID: 5930
		private static readonly LineRenderer.set_loopDelegate set_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.set_loopDelegate>("UnityEngine.LineRenderer::set_loop");

		// Token: 0x0400172B RID: 5931
		private static readonly LineRenderer.get_positionCountDelegate get_positionCountDelegateField = IL2CPP.ResolveICall<LineRenderer.get_positionCountDelegate>("UnityEngine.LineRenderer::get_positionCount");

		// Token: 0x0400172C RID: 5932
		private static readonly LineRenderer.set_positionCountDelegate set_positionCountDelegateField = IL2CPP.ResolveICall<LineRenderer.set_positionCountDelegate>("UnityEngine.LineRenderer::set_positionCount");

		// Token: 0x0400172D RID: 5933
		private static readonly LineRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.get_shadowBiasDelegate>("UnityEngine.LineRenderer::get_shadowBias");

		// Token: 0x0400172E RID: 5934
		private static readonly LineRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.set_shadowBiasDelegate>("UnityEngine.LineRenderer::set_shadowBias");

		// Token: 0x0400172F RID: 5935
		private static readonly LineRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.get_generateLightingDataDelegate>("UnityEngine.LineRenderer::get_generateLightingData");

		// Token: 0x04001730 RID: 5936
		private static readonly LineRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.set_generateLightingDataDelegate>("UnityEngine.LineRenderer::set_generateLightingData");

		// Token: 0x04001731 RID: 5937
		private static readonly LineRenderer.get_textureModeDelegate get_textureModeDelegateField = IL2CPP.ResolveICall<LineRenderer.get_textureModeDelegate>("UnityEngine.LineRenderer::get_textureMode");

		// Token: 0x04001732 RID: 5938
		private static readonly LineRenderer.set_textureModeDelegate set_textureModeDelegateField = IL2CPP.ResolveICall<LineRenderer.set_textureModeDelegate>("UnityEngine.LineRenderer::set_textureMode");

		// Token: 0x04001733 RID: 5939
		private static readonly LineRenderer.get_alignmentDelegate get_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.get_alignmentDelegate>("UnityEngine.LineRenderer::get_alignment");

		// Token: 0x04001734 RID: 5940
		private static readonly LineRenderer.set_alignmentDelegate set_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.set_alignmentDelegate>("UnityEngine.LineRenderer::set_alignment");

		// Token: 0x04001735 RID: 5941
		private static readonly LineRenderer.SimplifyDelegate SimplifyDelegateField = IL2CPP.ResolveICall<LineRenderer.SimplifyDelegate>("UnityEngine.LineRenderer::Simplify");

		// Token: 0x04001736 RID: 5942
		private static readonly LineRenderer.BakeMeshDelegate BakeMeshDelegateField = IL2CPP.ResolveICall<LineRenderer.BakeMeshDelegate>("UnityEngine.LineRenderer::BakeMesh");

		// Token: 0x04001737 RID: 5943
		private static readonly LineRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetWidthCurveCopyDelegate>("UnityEngine.LineRenderer::GetWidthCurveCopy");

		// Token: 0x04001738 RID: 5944
		private static readonly LineRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField = IL2CPP.ResolveICall<LineRenderer.SetWidthCurveDelegate>("UnityEngine.LineRenderer::SetWidthCurve");

		// Token: 0x04001739 RID: 5945
		private static readonly LineRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetColorGradientCopyDelegate>("UnityEngine.LineRenderer::GetColorGradientCopy");

		// Token: 0x0400173A RID: 5946
		private static readonly LineRenderer.SetColorGradientDelegate SetColorGradientDelegateField = IL2CPP.ResolveICall<LineRenderer.SetColorGradientDelegate>("UnityEngine.LineRenderer::SetColorGradient");

		// Token: 0x0400173B RID: 5947
		private static readonly LineRenderer.GetPositionsDelegate GetPositionsDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsDelegate>("UnityEngine.LineRenderer::GetPositions");

		// Token: 0x0400173C RID: 5948
		private static readonly LineRenderer.SetPositionsDelegate SetPositionsDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPositionsDelegate>("UnityEngine.LineRenderer::SetPositions");

		// Token: 0x0400173D RID: 5949
		private static readonly LineRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::SetPositionsWithNativeContainer");

		// Token: 0x0400173E RID: 5950
		private static readonly LineRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::GetPositionsWithNativeContainer");

		// Token: 0x0400173F RID: 5951
		private static readonly LineRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startColor_InjectedDelegate>("UnityEngine.LineRenderer::get_startColor_Injected");

		// Token: 0x04001740 RID: 5952
		private static readonly LineRenderer.set_startColor_InjectedDelegate set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.set_startColor_InjectedDelegate>("UnityEngine.LineRenderer::set_startColor_Injected");

		// Token: 0x04001741 RID: 5953
		private static readonly LineRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endColor_InjectedDelegate>("UnityEngine.LineRenderer::get_endColor_Injected");

		// Token: 0x04001742 RID: 5954
		private static readonly LineRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.set_endColor_InjectedDelegate>("UnityEngine.LineRenderer::set_endColor_Injected");

		// Token: 0x04001743 RID: 5955
		private static readonly LineRenderer.SetPosition_InjectedDelegate SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPosition_InjectedDelegate>("UnityEngine.LineRenderer::SetPosition_Injected");

		// Token: 0x04001744 RID: 5956
		private static readonly LineRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPosition_InjectedDelegate>("UnityEngine.LineRenderer::GetPosition_Injected");

		// Token: 0x02000B37 RID: 2871
		// (Invoke) Token: 0x0600346E RID: 13422
		private delegate float get_startWidthDelegate(IntPtr @this);

		// Token: 0x02000B38 RID: 2872
		// (Invoke) Token: 0x06003470 RID: 13424
		private delegate void set_startWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000B39 RID: 2873
		// (Invoke) Token: 0x06003472 RID: 13426
		private delegate float get_endWidthDelegate(IntPtr @this);

		// Token: 0x02000B3A RID: 2874
		// (Invoke) Token: 0x06003474 RID: 13428
		private delegate void set_endWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000B3B RID: 2875
		// (Invoke) Token: 0x06003476 RID: 13430
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x02000B3C RID: 2876
		// (Invoke) Token: 0x06003478 RID: 13432
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x02000B3D RID: 2877
		// (Invoke) Token: 0x0600347A RID: 13434
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x02000B3E RID: 2878
		// (Invoke) Token: 0x0600347C RID: 13436
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000B3F RID: 2879
		// (Invoke) Token: 0x0600347E RID: 13438
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x02000B40 RID: 2880
		// (Invoke) Token: 0x06003480 RID: 13440
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000B41 RID: 2881
		// (Invoke) Token: 0x06003482 RID: 13442
		private delegate bool get_useWorldSpaceDelegate(IntPtr @this);

		// Token: 0x02000B42 RID: 2882
		// (Invoke) Token: 0x06003484 RID: 13444
		private delegate void set_useWorldSpaceDelegate(IntPtr @this, bool value);

		// Token: 0x02000B43 RID: 2883
		// (Invoke) Token: 0x06003486 RID: 13446
		private delegate bool get_loopDelegate(IntPtr @this);

		// Token: 0x02000B44 RID: 2884
		// (Invoke) Token: 0x06003488 RID: 13448
		private delegate void set_loopDelegate(IntPtr @this, bool value);

		// Token: 0x02000B45 RID: 2885
		// (Invoke) Token: 0x0600348A RID: 13450
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x02000B46 RID: 2886
		// (Invoke) Token: 0x0600348C RID: 13452
		private delegate void set_positionCountDelegate(IntPtr @this, int value);

		// Token: 0x02000B47 RID: 2887
		// (Invoke) Token: 0x0600348E RID: 13454
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x02000B48 RID: 2888
		// (Invoke) Token: 0x06003490 RID: 13456
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000B49 RID: 2889
		// (Invoke) Token: 0x06003492 RID: 13458
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x02000B4A RID: 2890
		// (Invoke) Token: 0x06003494 RID: 13460
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x02000B4B RID: 2891
		// (Invoke) Token: 0x06003496 RID: 13462
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x02000B4C RID: 2892
		// (Invoke) Token: 0x06003498 RID: 13464
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x02000B4D RID: 2893
		// (Invoke) Token: 0x0600349A RID: 13466
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000B4E RID: 2894
		// (Invoke) Token: 0x0600349C RID: 13468
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x02000B4F RID: 2895
		// (Invoke) Token: 0x0600349E RID: 13470
		private delegate void SimplifyDelegate(IntPtr @this, float tolerance);

		// Token: 0x02000B50 RID: 2896
		// (Invoke) Token: 0x060034A0 RID: 13472
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000B51 RID: 2897
		// (Invoke) Token: 0x060034A2 RID: 13474
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x02000B52 RID: 2898
		// (Invoke) Token: 0x060034A4 RID: 13476
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000B53 RID: 2899
		// (Invoke) Token: 0x060034A6 RID: 13478
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x02000B54 RID: 2900
		// (Invoke) Token: 0x060034A8 RID: 13480
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000B55 RID: 2901
		// (Invoke) Token: 0x060034AA RID: 13482
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x02000B56 RID: 2902
		// (Invoke) Token: 0x060034AC RID: 13484
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000B57 RID: 2903
		// (Invoke) Token: 0x060034AE RID: 13486
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x02000B58 RID: 2904
		// (Invoke) Token: 0x060034B0 RID: 13488
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000B59 RID: 2905
		// (Invoke) Token: 0x060034B2 RID: 13490
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B5A RID: 2906
		// (Invoke) Token: 0x060034B4 RID: 13492
		private delegate void set_startColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B5B RID: 2907
		// (Invoke) Token: 0x060034B6 RID: 13494
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B5C RID: 2908
		// (Invoke) Token: 0x060034B8 RID: 13496
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B5D RID: 2909
		// (Invoke) Token: 0x060034BA RID: 13498
		private delegate void SetPosition_InjectedDelegate(IntPtr @this, int index, IntPtr position);

		// Token: 0x02000B5E RID: 2910
		// (Invoke) Token: 0x060034BC RID: 13500
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);
	}
}
