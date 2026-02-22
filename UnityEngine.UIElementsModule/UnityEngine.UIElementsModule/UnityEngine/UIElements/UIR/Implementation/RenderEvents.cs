using System;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020001CA RID: 458
	public static class RenderEvents
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x0000BD84 File Offset: 0x00009F84
		public static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0000BD91 File Offset: 0x00009F91
		public static Vector4 GetClipRectIDClipInfo(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0000BD9E File Offset: 0x00009F9E
		public static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0000BDAB File Offset: 0x00009FAB
		public static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		public static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000BDC5 File Offset: 0x00009FC5
		public static bool IsElementHierarchyHidden(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00039400 File Offset: 0x00037600
		public static bool IsElementSelfHidden(VisualElement ve)
		{
			return ve.resolvedStyle.visibility == Visibility.Hidden;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00039420 File Offset: 0x00037620
		public static VisualElement GetLastDeepestChild(VisualElement ve)
		{
			VisualElement.Hierarchy hierarchy = ve.hierarchy;
			for (int i = hierarchy.childCount; i > 0; i = hierarchy.childCount)
			{
				hierarchy = ve.hierarchy;
				ve = hierarchy[i - 1];
				hierarchy = ve.hierarchy;
			}
			return ve;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00039470 File Offset: 0x00037670
		public static VisualElement GetNextDepthFirst(VisualElement ve)
		{
			VisualElement.Hierarchy hierarchy = ve.hierarchy;
			for (VisualElement visualElement = hierarchy.parent; visualElement != null; visualElement = hierarchy.parent)
			{
				hierarchy = visualElement.hierarchy;
				int num = hierarchy.IndexOf(ve);
				hierarchy = visualElement.hierarchy;
				int childCount = hierarchy.childCount;
				bool flag = num < childCount - 1;
				if (flag)
				{
					hierarchy = visualElement.hierarchy;
					return hierarchy[num + 1];
				}
				ve = visualElement;
				hierarchy = visualElement.hierarchy;
			}
			return null;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000394F4 File Offset: 0x000376F4
		public static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child)
		{
			for (;;)
			{
				VisualElement.Hierarchy hierarchy = child.hierarchy;
				if (hierarchy.parent == null)
				{
					goto Block_2;
				}
				hierarchy = child.hierarchy;
				bool flag = hierarchy.parent == ve;
				if (flag)
				{
					break;
				}
				hierarchy = child.hierarchy;
				child = hierarchy.parent;
			}
			return true;
			Block_2:
			return false;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0000BDD2 File Offset: 0x00009FD2
		public static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0003954C File Offset: 0x0003774C
		public static bool NeedsTransformID(VisualElement ve)
		{
			return (ve.renderHints & RenderHints.GroupTransform) == RenderHints.None && (ve.renderHints & RenderHints.BoneTransform) == RenderHints.BoneTransform;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00039578 File Offset: 0x00037778
		public static bool TransformIDHasChanged(Alloc before, Alloc after)
		{
			bool flag = before.size == 0U && after.size == 0U;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = before.size != after.size || before.start != after.start;
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0000BDDF File Offset: 0x00009FDF
		public static Material CreateBlitShader(float colorConversion)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public static Material GetBlitMaterial(VisualElement.RenderTargetMode mode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0000BDF9 File Offset: 0x00009FF9
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000395D4 File Offset: 0x000377D4
		public static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font)
		{
			RenderChainCommand renderChainCommand = renderChain.AllocCommand();
			renderChainCommand.type = CommandType.Draw;
			RenderChainCommand renderChainCommand2 = renderChainCommand;
			State state = null;
			state.material = material;
			state.texture = texture;
			state.font = font;
			renderChainCommand2.state = state;
			renderChainCommand.mesh = mesh;
			renderChainCommand.indexOffset = indexOffset;
			renderChainCommand.indexCount = indexCount;
			renderChainCommand.owner = ve;
			RenderEvents.InjectCommandInBetween(renderChain, renderChainCommand, ref cmdPrev, ref cmdNext);
			return renderChainCommand;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00039648 File Offset: 0x00037848
		public static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font)
		{
			RenderChainCommand renderChainCommand = renderChain.AllocCommand();
			renderChainCommand.type = CommandType.Draw;
			renderChainCommand.closing = true;
			RenderChainCommand renderChainCommand2 = renderChainCommand;
			State state = null;
			state.material = material;
			state.texture = texture;
			state.font = font;
			renderChainCommand2.state = state;
			renderChainCommand.mesh = mesh;
			renderChainCommand.indexOffset = indexOffset;
			renderChainCommand.indexCount = indexCount;
			renderChainCommand.owner = ve;
			RenderEvents.InjectClosingCommandInBetween(renderChain, renderChainCommand, ref cmdPrev, ref cmdNext);
			return renderChainCommand;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0000BE06 File Offset: 0x0000A006
		public static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000BE13 File Offset: 0x0000A013
		public static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0000BE20 File Offset: 0x0000A020
		public static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0000BE2D File Offset: 0x0000A02D
		public static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0000BE3A File Offset: 0x0000A03A
		public static void ResetCommands(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
