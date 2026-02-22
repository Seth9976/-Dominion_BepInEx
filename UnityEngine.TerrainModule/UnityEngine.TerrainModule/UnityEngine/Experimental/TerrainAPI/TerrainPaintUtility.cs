using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000015 RID: 21
	public static class TerrainPaintUtility
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00003221 File Offset: 0x00001421
		public static Material GetBuiltinPaintMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005D88 File Offset: 0x00003F88
		public static void GetBrushWorldSizeLimits(out float minBrushWorldSize, out float maxBrushWorldSize, float terrainTileWorldSize, int terrainTileTextureResolutionPixels, [Optional] int minBrushResolutionPixels, [Optional] int maxBrushResolutionPixels)
		{
			bool flag = terrainTileTextureResolutionPixels <= 0;
			if (flag)
			{
				minBrushWorldSize = terrainTileWorldSize;
				maxBrushWorldSize = terrainTileWorldSize;
			}
			else
			{
				float num = terrainTileWorldSize / (float)terrainTileTextureResolutionPixels;
				minBrushWorldSize = (float)minBrushResolutionPixels * num;
				float num2 = (float)Mathf.Min(maxBrushResolutionPixels, SystemInfo.maxTextureSize);
				maxBrushWorldSize = num2 * num;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005DCC File Offset: 0x00003FCC
		public static BrushTransform CalculateBrushTransform(Terrain terrain, Vector2 brushCenterTerrainUV, float brushSize, float brushRotationDegrees)
		{
			float num = brushRotationDegrees * 0.017453292f;
			float num2 = Mathf.Cos(num);
			float num3 = Mathf.Sin(num);
			Vector2 vector = new Vector2(num2, -num3) * brushSize;
			Vector2 vector2 = new Vector2(num3, num2) * brushSize;
			Vector3 size = terrain.terrainData.size;
			Vector2 vector3 = brushCenterTerrainUV * new Vector2(size.x, size.z);
			Vector2 vector4 = vector3 - 0.5f * vector - 0.5f * vector2;
			BrushTransform brushTransform = new BrushTransform(vector4, vector, vector2);
			return brushTransform;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005E70 File Offset: 0x00004070
		public static void BuildTransformPaintContextUVToPaintContextUV(PaintContext src, PaintContext dst, out Vector4 scaleOffset)
		{
			float num = ((float)src.pixelRect.xMin - 0.5f) * src.pixelSize.x;
			float num2 = ((float)src.pixelRect.yMin - 0.5f) * src.pixelSize.y;
			float num3 = (float)src.pixelRect.width * src.pixelSize.x;
			float num4 = (float)src.pixelRect.height * src.pixelSize.y;
			float num5 = ((float)dst.pixelRect.xMin - 0.5f) * dst.pixelSize.x;
			float num6 = ((float)dst.pixelRect.yMin - 0.5f) * dst.pixelSize.y;
			float num7 = (float)dst.pixelRect.width * dst.pixelSize.x;
			float num8 = (float)dst.pixelRect.height * dst.pixelSize.y;
			scaleOffset = new Vector4(num3 / num7, num4 / num8, (num - num5) / num7, (num2 - num6) / num8);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005FA4 File Offset: 0x000041A4
		public static void SetupTerrainToolMaterialProperties(PaintContext paintContext, BrushTransform brushXform, Material material)
		{
			float num = ((float)paintContext.pixelRect.xMin - 0.5f) * paintContext.pixelSize.x;
			float num2 = ((float)paintContext.pixelRect.yMin - 0.5f) * paintContext.pixelSize.y;
			float num3 = (float)paintContext.pixelRect.width * paintContext.pixelSize.x;
			float num4 = (float)paintContext.pixelRect.height * paintContext.pixelSize.y;
			Vector2 vector = num3 * brushXform.targetX;
			Vector2 vector2 = num4 * brushXform.targetY;
			Vector2 vector3 = brushXform.targetOrigin + num * brushXform.targetX + num2 * brushXform.targetY;
			material.SetVector("_PCUVToBrushUVScales", new Vector4(vector.x, vector.y, vector2.x, vector2.y));
			material.SetVector("_PCUVToBrushUVOffset", new Vector4(vector3.x, vector3.y, 0f, 0f));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000060D4 File Offset: 0x000042D4
		public static bool paintTextureUsesCopyTexture
		{
			get
			{
				return (SystemInfo.copyTextureSupport & (CopyTextureSupport)24) == (CopyTextureSupport)24;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000060F4 File Offset: 0x000042F4
		public static PaintContext InitializePaintContext(Terrain terrain, int targetWidth, int targetHeight, RenderTextureFormat pcFormat, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels, [Optional] bool texelPadding)
		{
			PaintContext paintContext = PaintContext.CreateFromBounds(terrain, boundsInTerrainSpace, targetWidth, targetHeight, extraBorderPixels, texelPadding);
			paintContext.CreateRenderTargets(pcFormat);
			return paintContext;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000322E File Offset: 0x0000142E
		public static void ReleaseContextResources(PaintContext ctx)
		{
			ctx.Cleanup(true);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006120 File Offset: 0x00004320
		public static PaintContext BeginPaintHeightmap(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels)
		{
			int heightmapResolution = terrain.terrainData.heightmapResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, heightmapResolution, heightmapResolution, Terrain.heightmapRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, true);
			paintContext.GatherHeightmap();
			return paintContext;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003239 File Offset: 0x00001439
		public static void EndPaintHeightmap(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterHeightmap(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006158 File Offset: 0x00004358
		public static PaintContext BeginPaintHoles(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels)
		{
			int holesResolution = terrain.terrainData.holesResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, holesResolution, holesResolution, Terrain.holesRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, false);
			paintContext.GatherHoles();
			return paintContext;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000324C File Offset: 0x0000144C
		public static void EndPaintHoles(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterHoles(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006190 File Offset: 0x00004390
		public static PaintContext CollectNormals(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels)
		{
			int heightmapResolution = terrain.terrainData.heightmapResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, heightmapResolution, heightmapResolution, Terrain.normalmapRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, true);
			paintContext.GatherNormals();
			return paintContext;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000061C8 File Offset: 0x000043C8
		public static PaintContext BeginPaintTexture(Terrain terrain, Rect boundsInTerrainSpace, TerrainLayer inputLayer, [Optional] int extraBorderPixels)
		{
			bool flag = inputLayer == null;
			PaintContext paintContext;
			if (flag)
			{
				paintContext = null;
			}
			else
			{
				int alphamapResolution = terrain.terrainData.alphamapResolution;
				PaintContext paintContext2 = TerrainPaintUtility.InitializePaintContext(terrain, alphamapResolution, alphamapResolution, RenderTextureFormat.R8, boundsInTerrainSpace, extraBorderPixels, true);
				paintContext2.GatherAlphamap(inputLayer, true);
				paintContext = paintContext2;
			}
			return paintContext;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000325F File Offset: 0x0000145F
		public static void EndPaintTexture(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterAlphamap(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003272 File Offset: 0x00001472
		public static Material GetBlitMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000327F File Offset: 0x0000147F
		public static Material GetHeightBlitMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000328C File Offset: 0x0000148C
		public static Material GetCopyTerrainLayerMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003299 File Offset: 0x00001499
		public static void DrawQuad(RectInt destinationPixels, RectInt sourcePixels, Texture sourceTexture)
		{
			TerrainPaintUtility.DrawQuad2(destinationPixels, sourcePixels, sourceTexture, sourcePixels, sourceTexture);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006210 File Offset: 0x00004410
		public static void DrawQuad2(RectInt destinationPixels, RectInt sourcePixels, Texture sourceTexture, RectInt sourcePixels2, Texture sourceTexture2)
		{
			bool flag = destinationPixels.width > 0 && destinationPixels.height > 0;
			if (flag)
			{
				Rect rect = new Rect((float)sourcePixels.x / (float)sourceTexture.width, (float)sourcePixels.y / (float)sourceTexture.height, (float)sourcePixels.width / (float)sourceTexture.width, (float)sourcePixels.height / (float)sourceTexture.height);
				Rect rect2 = new Rect((float)sourcePixels2.x / (float)sourceTexture2.width, (float)sourcePixels2.y / (float)sourceTexture2.height, (float)sourcePixels2.width / (float)sourceTexture2.width, (float)sourcePixels2.height / (float)sourceTexture2.height);
				GL.Begin(7);
				GL.Color(new Color(1f, 1f, 1f, 1f));
				GL.MultiTexCoord2(0, rect.x, rect.y);
				GL.MultiTexCoord2(1, rect2.x, rect2.y);
				GL.Vertex3((float)destinationPixels.x, (float)destinationPixels.y, 0f);
				GL.MultiTexCoord2(0, rect.x, rect.yMax);
				GL.MultiTexCoord2(1, rect2.x, rect2.yMax);
				GL.Vertex3((float)destinationPixels.x, (float)destinationPixels.yMax, 0f);
				GL.MultiTexCoord2(0, rect.xMax, rect.yMax);
				GL.MultiTexCoord2(1, rect2.xMax, rect2.yMax);
				GL.Vertex3((float)destinationPixels.xMax, (float)destinationPixels.yMax, 0f);
				GL.MultiTexCoord2(0, rect.xMax, rect.y);
				GL.MultiTexCoord2(1, rect2.xMax, rect2.y);
				GL.Vertex3((float)destinationPixels.xMax, (float)destinationPixels.y, 0f);
				GL.End();
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006410 File Offset: 0x00004610
		public static RectInt CalcPixelRectFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int textureWidth, int textureHeight, int extraBorderPixels, bool texelPadding)
		{
			float num = ((float)textureWidth - (texelPadding ? 1f : 0f)) / terrain.terrainData.size.x;
			float num2 = ((float)textureHeight - (texelPadding ? 1f : 0f)) / terrain.terrainData.size.z;
			int num3 = Mathf.FloorToInt(boundsInTerrainSpace.xMin * num) - extraBorderPixels;
			int num4 = Mathf.FloorToInt(boundsInTerrainSpace.yMin * num2) - extraBorderPixels;
			int num5 = Mathf.CeilToInt(boundsInTerrainSpace.xMax * num) + extraBorderPixels;
			int num6 = Mathf.CeilToInt(boundsInTerrainSpace.yMax * num2) + extraBorderPixels;
			return new RectInt(num3, num4, num5 - num3 + 1, num6 - num4 + 1);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000064CC File Offset: 0x000046CC
		public static Texture2D GetTerrainAlphaMapChecked(Terrain terrain, int mapIndex)
		{
			bool flag = mapIndex >= terrain.terrainData.alphamapTextureCount;
			if (flag)
			{
				throw new ArgumentException("Trying to access out-of-bounds terrain alphamap information.");
			}
			return terrain.terrainData.GetAlphamapTexture(mapIndex);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000032A7 File Offset: 0x000014A7
		public static int FindTerrainLayerIndex(Terrain terrain, TerrainLayer inputLayer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000032B4 File Offset: 0x000014B4
		public static int AddTerrainLayer(Terrain terrain, TerrainLayer inputLayer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020000D7 RID: 215
		public enum BuiltinPaintMaterialPasses
		{
			// Token: 0x0400011E RID: 286
			RaiseLowerHeight,
			// Token: 0x0400011F RID: 287
			StampHeight,
			// Token: 0x04000120 RID: 288
			SetHeights,
			// Token: 0x04000121 RID: 289
			SmoothHeights,
			// Token: 0x04000122 RID: 290
			PaintTexture,
			// Token: 0x04000123 RID: 291
			PaintHoles
		}
	}
}
