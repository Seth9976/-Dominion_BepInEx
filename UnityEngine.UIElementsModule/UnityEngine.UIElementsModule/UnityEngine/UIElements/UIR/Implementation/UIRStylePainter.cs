using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020001CB RID: 459
	public class UIRStylePainter
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x0000BE47 File Offset: 0x0000A047
		public MeshWriteData GetPooledMeshWriteData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0000BE54 File Offset: 0x0000A054
		public MeshGenerationContext meshGenerationContext
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0000BE61 File Offset: 0x0000A061
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x0000BE6E File Offset: 0x0000A06E
		public VisualElement currentElement
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0000BE7B File Offset: 0x0000A07B
		public UIRenderDevice device
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0000BE88 File Offset: 0x0000A088
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0000BE95 File Offset: 0x0000A095
		public int totalVertices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0000BEA2 File Offset: 0x0000A0A2
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0000BEAF File Offset: 0x0000A0AF
		public int totalIndices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000BEC9 File Offset: 0x0000A0C9
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000BED6 File Offset: 0x0000A0D6
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
		public void Begin(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0000BF02 File Offset: 0x0000A102
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0000BF0F File Offset: 0x0000A10F
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000396C4 File Offset: 0x000378C4
		public VisualElement visualElement
		{
			get
			{
				return this.currentElement;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000BF29 File Offset: 0x0000A129
		public void DrawVisualElementBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000BF36 File Offset: 0x0000A136
		public void DrawVisualElementBorder()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000BF43 File Offset: 0x0000A143
		public void ApplyVisualElementClipping()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000BF50 File Offset: 0x0000A150
		public Il2CppStructArray<ushort> AdjustSpriteWinding(Sprite sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0000BF5D File Offset: 0x0000A15D
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000BF6A File Offset: 0x0000A16A
		public void ValidateMeshWriteData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0000BF77 File Offset: 0x0000A177
		public void GenerateStencilClipEntryForRoundedRectBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000BF84 File Offset: 0x0000A184
		public void GenerateStencilClipEntryForSVGBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
