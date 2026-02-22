using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000014 RID: 20
	public class PaintContext
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000030AE File Offset: 0x000012AE
		public Terrain originTerrain
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000030BB File Offset: 0x000012BB
		public RectInt pixelRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000030C8 File Offset: 0x000012C8
		public int targetTextureWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000030D5 File Offset: 0x000012D5
		public int targetTextureHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000030E2 File Offset: 0x000012E2
		public Vector2 pixelSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000030EF File Offset: 0x000012EF
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000030FC File Offset: 0x000012FC
		public RenderTexture sourceRenderTexture
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003109 File Offset: 0x00001309
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00003116 File Offset: 0x00001316
		public RenderTexture destinationRenderTexture
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00003123 File Offset: 0x00001323
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00003130 File Offset: 0x00001330
		public RenderTexture oldRenderTexture
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000313D File Offset: 0x0000133D
		public int terrainCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000314A File Offset: 0x0000134A
		public Terrain GetTerrain(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003157 File Offset: 0x00001357
		public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003164 File Offset: 0x00001364
		public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003171 File Offset: 0x00001371
		public float heightWorldSpaceMin
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000317E File Offset: 0x0000137E
		public float heightWorldSpaceSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000318B File Offset: 0x0000138B
		public static float kNormalizedHeightScale
		{
			get
			{
				return 0.4999771f;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005C80 File Offset: 0x00003E80
		public static PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, [Optional] int extraBorderPixels, [Optional] bool texelPadding)
		{
			return new PaintContext(terrain, TerrainPaintUtility.CalcPixelRectFromBounds(terrain, boundsInTerrainSpace, inputTextureWidth, inputTextureHeight, extraBorderPixels, texelPadding), inputTextureWidth, inputTextureHeight, texelPadding);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003192 File Offset: 0x00001392
		public void FindTerrainTilesUnlimited(bool texelPadding)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005CAC File Offset: 0x00003EAC
		public void CreateRenderTargets(RenderTextureFormat colorFormat)
		{
			this.sourceRenderTexture = RenderTexture.GetTemporary(this.pixelRect.width, this.pixelRect.height, 0, colorFormat, RenderTextureReadWrite.Linear);
			this.destinationRenderTexture = RenderTexture.GetTemporary(this.pixelRect.width, this.pixelRect.height, 0, colorFormat, RenderTextureReadWrite.Linear);
			this.sourceRenderTexture.wrapMode = TextureWrapMode.Clamp;
			this.sourceRenderTexture.filterMode = FilterMode.Point;
			this.oldRenderTexture = RenderTexture.active;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005D38 File Offset: 0x00003F38
		public void Cleanup([Optional] bool restoreRenderTexture)
		{
			if (restoreRenderTexture)
			{
				RenderTexture.active = this.oldRenderTexture;
			}
			RenderTexture.ReleaseTemporary(this.sourceRenderTexture);
			RenderTexture.ReleaseTemporary(this.destinationRenderTexture);
			this.sourceRenderTexture = null;
			this.destinationRenderTexture = null;
			this.oldRenderTexture = null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000319F File Offset: 0x0000139F
		public void GatherHeightmap()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000031AC File Offset: 0x000013AC
		public void ScatterHeightmap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000031B9 File Offset: 0x000013B9
		public void GatherHoles()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000031C6 File Offset: 0x000013C6
		public void ScatterHoles(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000031D3 File Offset: 0x000013D3
		public void GatherNormals()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000031E0 File Offset: 0x000013E0
		public PaintContext.SplatmapUserData GetTerrainLayerUserData(PaintContext.ITerrainInfo context, [Optional] TerrainLayer terrainLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000031ED File Offset: 0x000013ED
		public void GatherAlphamap(TerrainLayer inputLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000031FA File Offset: 0x000013FA
		public void ScatterAlphamap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003207 File Offset: 0x00001407
		public static void OnTerrainPainted(PaintContext.ITerrainInfo tile, PaintContext.ToolAction action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003214 File Offset: 0x00001414
		public static void ApplyDelayedActions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020000CC RID: 204
		public interface ITerrainInfo
		{
		}

		// Token: 0x020000CD RID: 205
		public class TerrainTile
		{
		}

		// Token: 0x020000CE RID: 206
		public class SplatmapUserData
		{
		}

		// Token: 0x020000CF RID: 207
		public enum ToolAction
		{
			// Token: 0x04000118 RID: 280
			None,
			// Token: 0x04000119 RID: 281
			PaintHeightmap,
			// Token: 0x0400011A RID: 282
			PaintTexture,
			// Token: 0x0400011B RID: 283
			PaintHoles = 4,
			// Token: 0x0400011C RID: 284
			AddTerrainLayer = 8
		}

		// Token: 0x020000D0 RID: 208
		public sealed class <>c__DisplayClass50_0
		{
		}

		// Token: 0x020000D1 RID: 209
		public sealed class <>c__DisplayClass57_0
		{
		}

		// Token: 0x020000D2 RID: 210
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020000D3 RID: 211
		public sealed class <>c__DisplayClass58_0
		{
		}

		// Token: 0x020000D4 RID: 212
		public sealed class <>c__DisplayClass60_0
		{
		}

		// Token: 0x020000D5 RID: 213
		public sealed class <>c__DisplayClass63_0
		{
		}

		// Token: 0x020000D6 RID: 214
		public sealed class <>c__DisplayClass64_0
		{
		}
	}
}
