using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public sealed class CompositeCollider2D : Collider2D
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00003975 File Offset: 0x00001B75
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003987 File Offset: 0x00001B87
		public CompositeCollider2D.GeometryType geometryType
		{
			get
			{
				return CompositeCollider2D.get_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000399A File Offset: 0x00001B9A
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000039AC File Offset: 0x00001BAC
		public CompositeCollider2D.GenerationType generationType
		{
			get
			{
				return CompositeCollider2D.get_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000039BF File Offset: 0x00001BBF
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000039D1 File Offset: 0x00001BD1
		public float vertexDistance
		{
			get
			{
				return CompositeCollider2D.get_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000039E4 File Offset: 0x00001BE4
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000039F6 File Offset: 0x00001BF6
		public float edgeRadius
		{
			get
			{
				return CompositeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00003A09 File Offset: 0x00001C09
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003A1B File Offset: 0x00001C1B
		public float offsetDistance
		{
			get
			{
				return CompositeCollider2D.get_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003A2E File Offset: 0x00001C2E
		public void GenerateGeometry()
		{
			CompositeCollider2D.GenerateGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000B504 File Offset: 0x00009704
		public int GetPathPointCount(int index)
		{
			int num = this.pathCount - 1;
			bool flag = index < 0 || index > num;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, num));
			}
			return this.GetPathPointCount_Internal(index);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003A40 File Offset: 0x00001C40
		public int GetPathPointCount_Internal(int index)
		{
			return CompositeCollider2D.GetPathPointCount_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00003A53 File Offset: 0x00001C53
		public int pathCount
		{
			get
			{
				return CompositeCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00003A65 File Offset: 0x00001C65
		public int pointCount
		{
			get
			{
				return CompositeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000B558 File Offset: 0x00009758
		public int GetPath(int index, Il2CppStructArray<Vector2> points)
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
			return this.GetPathArray_Internal(index, points);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003A77 File Offset: 0x00001C77
		public int GetPathArray_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			return CompositeCollider2D.GetPathArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000B5C4 File Offset: 0x000097C4
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

		// Token: 0x06000352 RID: 850 RVA: 0x00003A90 File Offset: 0x00001C90
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return CompositeCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x040001B6 RID: 438
		private static readonly CompositeCollider2D.get_geometryTypeDelegate get_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::get_geometryType");

		// Token: 0x040001B7 RID: 439
		private static readonly CompositeCollider2D.set_geometryTypeDelegate set_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::set_geometryType");

		// Token: 0x040001B8 RID: 440
		private static readonly CompositeCollider2D.get_generationTypeDelegate get_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_generationTypeDelegate>("UnityEngine.CompositeCollider2D::get_generationType");

		// Token: 0x040001B9 RID: 441
		private static readonly CompositeCollider2D.set_generationTypeDelegate set_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_generationTypeDelegate>("UnityEngine.CompositeCollider2D::set_generationType");

		// Token: 0x040001BA RID: 442
		private static readonly CompositeCollider2D.get_vertexDistanceDelegate get_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::get_vertexDistance");

		// Token: 0x040001BB RID: 443
		private static readonly CompositeCollider2D.set_vertexDistanceDelegate set_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::set_vertexDistance");

		// Token: 0x040001BC RID: 444
		private static readonly CompositeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::get_edgeRadius");

		// Token: 0x040001BD RID: 445
		private static readonly CompositeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::set_edgeRadius");

		// Token: 0x040001BE RID: 446
		private static readonly CompositeCollider2D.get_offsetDistanceDelegate get_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::get_offsetDistance");

		// Token: 0x040001BF RID: 447
		private static readonly CompositeCollider2D.set_offsetDistanceDelegate set_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::set_offsetDistance");

		// Token: 0x040001C0 RID: 448
		private static readonly CompositeCollider2D.GenerateGeometryDelegate GenerateGeometryDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GenerateGeometryDelegate>("UnityEngine.CompositeCollider2D::GenerateGeometry");

		// Token: 0x040001C1 RID: 449
		private static readonly CompositeCollider2D.GetPathPointCount_InternalDelegate GetPathPointCount_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathPointCount_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathPointCount_Internal");

		// Token: 0x040001C2 RID: 450
		private static readonly CompositeCollider2D.get_pathCountDelegate get_pathCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pathCountDelegate>("UnityEngine.CompositeCollider2D::get_pathCount");

		// Token: 0x040001C3 RID: 451
		private static readonly CompositeCollider2D.get_pointCountDelegate get_pointCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pointCountDelegate>("UnityEngine.CompositeCollider2D::get_pointCount");

		// Token: 0x040001C4 RID: 452
		private static readonly CompositeCollider2D.GetPathArray_InternalDelegate GetPathArray_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathArray_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathArray_Internal");

		// Token: 0x040001C5 RID: 453
		private static readonly CompositeCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathList_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathList_Internal");

		// Token: 0x02000141 RID: 321
		public enum GeometryType
		{
			// Token: 0x0400027F RID: 639
			Outlines,
			// Token: 0x04000280 RID: 640
			Polygons
		}

		// Token: 0x02000142 RID: 322
		public enum GenerationType
		{
			// Token: 0x04000282 RID: 642
			Synchronous,
			// Token: 0x04000283 RID: 643
			Manual
		}

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x06000650 RID: 1616
		private delegate CompositeCollider2D.GeometryType get_geometryTypeDelegate(IntPtr @this);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x06000652 RID: 1618
		private delegate void set_geometryTypeDelegate(IntPtr @this, CompositeCollider2D.GeometryType value);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000654 RID: 1620
		private delegate CompositeCollider2D.GenerationType get_generationTypeDelegate(IntPtr @this);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000656 RID: 1622
		private delegate void set_generationTypeDelegate(IntPtr @this, CompositeCollider2D.GenerationType value);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000658 RID: 1624
		private delegate float get_vertexDistanceDelegate(IntPtr @this);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x0600065A RID: 1626
		private delegate void set_vertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x0600065C RID: 1628
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600065E RID: 1630
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x06000660 RID: 1632
		private delegate float get_offsetDistanceDelegate(IntPtr @this);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x06000662 RID: 1634
		private delegate void set_offsetDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000664 RID: 1636
		private delegate void GenerateGeometryDelegate(IntPtr @this);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000666 RID: 1638
		private delegate int GetPathPointCount_InternalDelegate(IntPtr @this, int index);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000668 RID: 1640
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x0600066A RID: 1642
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x0600066C RID: 1644
		private delegate int GetPathArray_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600066E RID: 1646
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);
	}
}
