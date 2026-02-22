using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000C RID: 12
	public sealed class TilemapCollider2D : Collider2D
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000295C File Offset: 0x00000B5C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000296E File Offset: 0x00000B6E
		public uint maximumTileChangeCount
		{
			get
			{
				return TilemapCollider2D.get_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002981 File Offset: 0x00000B81
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002993 File Offset: 0x00000B93
		public float extrusionFactor
		{
			get
			{
				return TilemapCollider2D.get_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000029A6 File Offset: 0x00000BA6
		public bool hasTilemapChanges
		{
			get
			{
				return TilemapCollider2D.get_hasTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000029B8 File Offset: 0x00000BB8
		public void ProcessTilemapChanges()
		{
			TilemapCollider2D.ProcessTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400007D RID: 125
		private static readonly TilemapCollider2D.get_maximumTileChangeCountDelegate get_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_maximumTileChangeCount");

		// Token: 0x0400007E RID: 126
		private static readonly TilemapCollider2D.set_maximumTileChangeCountDelegate set_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_maximumTileChangeCount");

		// Token: 0x0400007F RID: 127
		private static readonly TilemapCollider2D.get_extrusionFactorDelegate get_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_extrusionFactor");

		// Token: 0x04000080 RID: 128
		private static readonly TilemapCollider2D.set_extrusionFactorDelegate set_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_extrusionFactor");

		// Token: 0x04000081 RID: 129
		private static readonly TilemapCollider2D.get_hasTilemapChangesDelegate get_hasTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_hasTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_hasTilemapChanges");

		// Token: 0x04000082 RID: 130
		private static readonly TilemapCollider2D.ProcessTilemapChangesDelegate ProcessTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.ProcessTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::ProcessTilemapChanges");

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate uint get_maximumTileChangeCountDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void set_maximumTileChangeCountDelegate(IntPtr @this, uint value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate float get_extrusionFactorDelegate(IntPtr @this);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void set_extrusionFactorDelegate(IntPtr @this, float value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool get_hasTilemapChangesDelegate(IntPtr @this);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate void ProcessTilemapChangesDelegate(IntPtr @this);
	}
}
