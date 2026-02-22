using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class TerrainExtensions
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000055A0 File Offset: 0x000037A0
		public static void UpdateGIMaterials(Terrain terrain)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect(0f, 0f, 1f, 1f));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000055F0 File Offset: 0x000037F0
		public static void UpdateGIMaterials(Terrain terrain, int x, int y, int width, int height)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			float num = (float)terrain.terrainData.alphamapWidth;
			float num2 = (float)terrain.terrainData.alphamapHeight;
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002B8E File Offset: 0x00000D8E
		public static void UpdateGIMaterialsForTerrain(int terrainInstanceID, Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_Injected(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002B98 File Offset: 0x00000D98
		public static void UpdateGIMaterialsForTerrain_Injected(int terrainInstanceID, ref Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegateField(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x040000C4 RID: 196
		private static readonly TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate UpdateGIMaterialsForTerrain_InjectedDelegateField = IL2CPP.ResolveICall<TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate>("UnityEngine.TerrainExtensions::UpdateGIMaterialsForTerrain_Injected");

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x060002F6 RID: 758
		private delegate void UpdateGIMaterialsForTerrain_InjectedDelegate(int terrainInstanceID, IntPtr uvBounds);
	}
}
