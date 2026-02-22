using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class SpriteMask : Renderer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00000262
		public int frontSortingLayerID
		{
			get
			{
				return SpriteMask.get_frontSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_frontSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002087 File Offset: 0x00000287
		public int frontSortingOrder
		{
			get
			{
				return SpriteMask.get_frontSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_frontSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020AC File Offset: 0x000002AC
		public int backSortingLayerID
		{
			get
			{
				return SpriteMask.get_backSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_backSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020BF File Offset: 0x000002BF
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020D1 File Offset: 0x000002D1
		public int backSortingOrder
		{
			get
			{
				return SpriteMask.get_backSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_backSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020F6 File Offset: 0x000002F6
		public float alphaCutoff
		{
			get
			{
				return SpriteMask.get_alphaCutoffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_alphaCutoffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000228C File Offset: 0x0000048C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002109 File Offset: 0x00000309
		public Sprite sprite
		{
			get
			{
				IntPtr intPtr = SpriteMask.get_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				SpriteMask.set_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002121 File Offset: 0x00000321
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002133 File Offset: 0x00000333
		public bool isCustomRangeActive
		{
			get
			{
				return SpriteMask.get_isCustomRangeActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_isCustomRangeActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002146 File Offset: 0x00000346
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002158 File Offset: 0x00000358
		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return SpriteMask.get_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022B8 File Offset: 0x000004B8
		public Bounds GetSpriteBounds()
		{
			Bounds bounds;
			this.GetSpriteBounds_Injected(out bounds);
			return bounds;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000216B File Offset: 0x0000036B
		public void GetSpriteBounds_Injected(out Bounds ret)
		{
			SpriteMask.GetSpriteBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly SpriteMask.get_frontSortingLayerIDDelegate get_frontSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.get_frontSortingLayerIDDelegate>("UnityEngine.SpriteMask::get_frontSortingLayerID");

		// Token: 0x04000002 RID: 2
		private static readonly SpriteMask.set_frontSortingLayerIDDelegate set_frontSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.set_frontSortingLayerIDDelegate>("UnityEngine.SpriteMask::set_frontSortingLayerID");

		// Token: 0x04000003 RID: 3
		private static readonly SpriteMask.get_frontSortingOrderDelegate get_frontSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.get_frontSortingOrderDelegate>("UnityEngine.SpriteMask::get_frontSortingOrder");

		// Token: 0x04000004 RID: 4
		private static readonly SpriteMask.set_frontSortingOrderDelegate set_frontSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.set_frontSortingOrderDelegate>("UnityEngine.SpriteMask::set_frontSortingOrder");

		// Token: 0x04000005 RID: 5
		private static readonly SpriteMask.get_backSortingLayerIDDelegate get_backSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.get_backSortingLayerIDDelegate>("UnityEngine.SpriteMask::get_backSortingLayerID");

		// Token: 0x04000006 RID: 6
		private static readonly SpriteMask.set_backSortingLayerIDDelegate set_backSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.set_backSortingLayerIDDelegate>("UnityEngine.SpriteMask::set_backSortingLayerID");

		// Token: 0x04000007 RID: 7
		private static readonly SpriteMask.get_backSortingOrderDelegate get_backSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.get_backSortingOrderDelegate>("UnityEngine.SpriteMask::get_backSortingOrder");

		// Token: 0x04000008 RID: 8
		private static readonly SpriteMask.set_backSortingOrderDelegate set_backSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.set_backSortingOrderDelegate>("UnityEngine.SpriteMask::set_backSortingOrder");

		// Token: 0x04000009 RID: 9
		private static readonly SpriteMask.get_alphaCutoffDelegate get_alphaCutoffDelegateField = IL2CPP.ResolveICall<SpriteMask.get_alphaCutoffDelegate>("UnityEngine.SpriteMask::get_alphaCutoff");

		// Token: 0x0400000A RID: 10
		private static readonly SpriteMask.set_alphaCutoffDelegate set_alphaCutoffDelegateField = IL2CPP.ResolveICall<SpriteMask.set_alphaCutoffDelegate>("UnityEngine.SpriteMask::set_alphaCutoff");

		// Token: 0x0400000B RID: 11
		private static readonly SpriteMask.get_spriteDelegate get_spriteDelegateField = IL2CPP.ResolveICall<SpriteMask.get_spriteDelegate>("UnityEngine.SpriteMask::get_sprite");

		// Token: 0x0400000C RID: 12
		private static readonly SpriteMask.set_spriteDelegate set_spriteDelegateField = IL2CPP.ResolveICall<SpriteMask.set_spriteDelegate>("UnityEngine.SpriteMask::set_sprite");

		// Token: 0x0400000D RID: 13
		private static readonly SpriteMask.get_isCustomRangeActiveDelegate get_isCustomRangeActiveDelegateField = IL2CPP.ResolveICall<SpriteMask.get_isCustomRangeActiveDelegate>("UnityEngine.SpriteMask::get_isCustomRangeActive");

		// Token: 0x0400000E RID: 14
		private static readonly SpriteMask.set_isCustomRangeActiveDelegate set_isCustomRangeActiveDelegateField = IL2CPP.ResolveICall<SpriteMask.set_isCustomRangeActiveDelegate>("UnityEngine.SpriteMask::set_isCustomRangeActive");

		// Token: 0x0400000F RID: 15
		private static readonly SpriteMask.get_spriteSortPointDelegate get_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteMask.get_spriteSortPointDelegate>("UnityEngine.SpriteMask::get_spriteSortPoint");

		// Token: 0x04000010 RID: 16
		private static readonly SpriteMask.set_spriteSortPointDelegate set_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteMask.set_spriteSortPointDelegate>("UnityEngine.SpriteMask::set_spriteSortPoint");

		// Token: 0x04000011 RID: 17
		private static readonly SpriteMask.GetSpriteBounds_InjectedDelegate GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<SpriteMask.GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteMask::GetSpriteBounds_Injected");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000015 RID: 21
		private delegate int get_frontSortingLayerIDDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate void set_frontSortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate int get_frontSortingOrderDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate void set_frontSortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate int get_backSortingLayerIDDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate void set_backSortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000021 RID: 33
		private delegate int get_backSortingOrderDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000023 RID: 35
		private delegate void set_backSortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate float get_alphaCutoffDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000027 RID: 39
		private delegate void set_alphaCutoffDelegate(IntPtr @this, float value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000029 RID: 41
		private delegate IntPtr get_spriteDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002B RID: 43
		private delegate void set_spriteDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate bool get_isCustomRangeActiveDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600002F RID: 47
		private delegate void set_isCustomRangeActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate SpriteSortPoint get_spriteSortPointDelegate(IntPtr @this);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000033 RID: 51
		private delegate void set_spriteSortPointDelegate(IntPtr @this, SpriteSortPoint value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate void GetSpriteBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
