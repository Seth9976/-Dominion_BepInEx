using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class PolygonCollider2D : Collider2D
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000386A File Offset: 0x00001A6A
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000387C File Offset: 0x00001A7C
		public bool autoTiling
		{
			get
			{
				return PolygonCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000388F File Offset: 0x00001A8F
		public int GetTotalPointCount()
		{
			return PolygonCollider2D.GetTotalPointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000038A1 File Offset: 0x00001AA1
		public Il2CppStructArray<Vector2> points
		{
			get
			{
				IntPtr intPtr = PolygonCollider2D.get_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				PolygonCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000038B9 File Offset: 0x00001AB9
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000038CB File Offset: 0x00001ACB
		public int pathCount
		{
			get
			{
				return PolygonCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000B234 File Offset: 0x00009434
		public Il2CppStructArray<Vector2> GetPath(int index)
		{
			bool flag = index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist.", index));
			}
			bool flag2 = index < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist; negative path index is invalid.", index));
			}
			return this.GetPath_Internal(index);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000B294 File Offset: 0x00009494
		public Il2CppStructArray<Vector2> GetPath_Internal(int index)
		{
			IntPtr intPtr = PolygonCollider2D.GetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B2C4 File Offset: 0x000094C4
		public void SetPath(int index, Il2CppStructArray<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPath_Internal(index, points);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000038DE File Offset: 0x00001ADE
		public void SetPath_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			PolygonCollider2D.SetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B2FC File Offset: 0x000094FC
		public int GetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathList_Internal(index, points);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000038F7 File Offset: 0x00001AF7
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return PolygonCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000B368 File Offset: 0x00009568
		public void SetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPathList_Internal(index, points);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003910 File Offset: 0x00001B10
		public void SetPathList_Internal(int index, List<Vector2> points)
		{
			PolygonCollider2D.SetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003929 File Offset: 0x00001B29
		public void CreatePrimitive(int sides)
		{
			this.CreatePrimitive(sides, Vector2.one, Vector2.zero);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000393E File Offset: 0x00001B3E
		public void CreatePrimitive(int sides, Vector2 scale)
		{
			this.CreatePrimitive(sides, scale, Vector2.zero);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset)
		{
			bool flag = sides < 3;
			if (flag)
			{
				Debug.LogWarning("Cannot create a 2D polygon primitive collider with less than two sides.", this);
			}
			else
			{
				bool flag2 = scale.x <= 0f || scale.y <= 0f;
				if (flag2)
				{
					Debug.LogWarning("Cannot create a 2D polygon primitive collider with an axis scale less than or equal to zero.", this);
				}
				else
				{
					this.CreatePrimitive_Internal(sides, scale, offset, true);
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000394F File Offset: 0x00001B4F
		public void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh)
		{
			this.CreatePrimitive_Internal_Injected(sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000395E File Offset: 0x00001B5E
		public void CreatePrimitive_Internal_Injected(int sides, ref Vector2 scale, ref Vector2 offset, bool autoRefresh)
		{
			PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x040001AA RID: 426
		private static readonly PolygonCollider2D.get_autoTilingDelegate get_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_autoTilingDelegate>("UnityEngine.PolygonCollider2D::get_autoTiling");

		// Token: 0x040001AB RID: 427
		private static readonly PolygonCollider2D.set_autoTilingDelegate set_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_autoTilingDelegate>("UnityEngine.PolygonCollider2D::set_autoTiling");

		// Token: 0x040001AC RID: 428
		private static readonly PolygonCollider2D.GetTotalPointCountDelegate GetTotalPointCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetTotalPointCountDelegate>("UnityEngine.PolygonCollider2D::GetTotalPointCount");

		// Token: 0x040001AD RID: 429
		private static readonly PolygonCollider2D.get_pointsDelegate get_pointsDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_pointsDelegate>("UnityEngine.PolygonCollider2D::get_points");

		// Token: 0x040001AE RID: 430
		private static readonly PolygonCollider2D.set_pointsDelegate set_pointsDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pointsDelegate>("UnityEngine.PolygonCollider2D::set_points");

		// Token: 0x040001AF RID: 431
		private static readonly PolygonCollider2D.get_pathCountDelegate get_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_pathCountDelegate>("UnityEngine.PolygonCollider2D::get_pathCount");

		// Token: 0x040001B0 RID: 432
		private static readonly PolygonCollider2D.set_pathCountDelegate set_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pathCountDelegate>("UnityEngine.PolygonCollider2D::set_pathCount");

		// Token: 0x040001B1 RID: 433
		private static readonly PolygonCollider2D.GetPath_InternalDelegate GetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPath_Internal");

		// Token: 0x040001B2 RID: 434
		private static readonly PolygonCollider2D.SetPath_InternalDelegate SetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPath_Internal");

		// Token: 0x040001B3 RID: 435
		private static readonly PolygonCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPathList_Internal");

		// Token: 0x040001B4 RID: 436
		private static readonly PolygonCollider2D.SetPathList_InternalDelegate SetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPathList_Internal");

		// Token: 0x040001B5 RID: 437
		private static readonly PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate CreatePrimitive_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected");

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate int GetTotalPointCountDelegate(IntPtr @this);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate IntPtr get_pointsDelegate(IntPtr @this);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate void set_pathCountDelegate(IntPtr @this, int value);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate IntPtr GetPath_InternalDelegate(IntPtr @this, int index);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000648 RID: 1608
		private delegate void SetPath_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x0600064A RID: 1610
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x0600064C RID: 1612
		private delegate void SetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x0600064E RID: 1614
		private delegate void CreatePrimitive_Internal_InjectedDelegate(IntPtr @this, int sides, IntPtr scale, IntPtr offset, bool autoRefresh);
	}
}
