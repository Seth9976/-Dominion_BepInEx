using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public sealed class EdgeCollider2D : Collider2D
	{
		// Token: 0x0600030C RID: 780 RVA: 0x000036A3 File Offset: 0x000018A3
		public void Reset()
		{
			EdgeCollider2D.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000036B5 File Offset: 0x000018B5
		// (set) Token: 0x0600030E RID: 782 RVA: 0x000036C7 File Offset: 0x000018C7
		public float edgeRadius
		{
			get
			{
				return EdgeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000036DA File Offset: 0x000018DA
		public int edgeCount
		{
			get
			{
				return EdgeCollider2D.get_edgeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000036EC File Offset: 0x000018EC
		public int pointCount
		{
			get
			{
				return EdgeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000B068 File Offset: 0x00009268
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000036FE File Offset: 0x000018FE
		public Il2CppStructArray<Vector2> points
		{
			get
			{
				IntPtr intPtr = EdgeCollider2D.get_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				EdgeCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003716 File Offset: 0x00001916
		public int GetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.GetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000372E File Offset: 0x0000192E
		public bool SetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.SetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003746 File Offset: 0x00001946
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003758 File Offset: 0x00001958
		public bool useAdjacentStartPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000376B File Offset: 0x0000196B
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000377D File Offset: 0x0000197D
		public bool useAdjacentEndPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000B094 File Offset: 0x00009294
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003790 File Offset: 0x00001990
		public Vector2 adjacentStartPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentStartPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentStartPoint_Injected(ref value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000B0AC File Offset: 0x000092AC
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000379A File Offset: 0x0000199A
		public Vector2 adjacentEndPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentEndPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentEndPoint_Injected(ref value);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000037A4 File Offset: 0x000019A4
		public void get_adjacentStartPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000037B7 File Offset: 0x000019B7
		public void set_adjacentStartPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000037CA File Offset: 0x000019CA
		public void get_adjacentEndPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000037DD File Offset: 0x000019DD
		public void set_adjacentEndPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000193 RID: 403
		private static readonly EdgeCollider2D.ResetDelegate ResetDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.ResetDelegate>("UnityEngine.EdgeCollider2D::Reset");

		// Token: 0x04000194 RID: 404
		private static readonly EdgeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::get_edgeRadius");

		// Token: 0x04000195 RID: 405
		private static readonly EdgeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::set_edgeRadius");

		// Token: 0x04000196 RID: 406
		private static readonly EdgeCollider2D.get_edgeCountDelegate get_edgeCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeCountDelegate>("UnityEngine.EdgeCollider2D::get_edgeCount");

		// Token: 0x04000197 RID: 407
		private static readonly EdgeCollider2D.get_pointCountDelegate get_pointCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointCountDelegate>("UnityEngine.EdgeCollider2D::get_pointCount");

		// Token: 0x04000198 RID: 408
		private static readonly EdgeCollider2D.get_pointsDelegate get_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointsDelegate>("UnityEngine.EdgeCollider2D::get_points");

		// Token: 0x04000199 RID: 409
		private static readonly EdgeCollider2D.set_pointsDelegate set_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_pointsDelegate>("UnityEngine.EdgeCollider2D::set_points");

		// Token: 0x0400019A RID: 410
		private static readonly EdgeCollider2D.GetPointsDelegate GetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.GetPointsDelegate>("UnityEngine.EdgeCollider2D::GetPoints");

		// Token: 0x0400019B RID: 411
		private static readonly EdgeCollider2D.SetPointsDelegate SetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.SetPointsDelegate>("UnityEngine.EdgeCollider2D::SetPoints");

		// Token: 0x0400019C RID: 412
		private static readonly EdgeCollider2D.get_useAdjacentStartPointDelegate get_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint");

		// Token: 0x0400019D RID: 413
		private static readonly EdgeCollider2D.set_useAdjacentStartPointDelegate set_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint");

		// Token: 0x0400019E RID: 414
		private static readonly EdgeCollider2D.get_useAdjacentEndPointDelegate get_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint");

		// Token: 0x0400019F RID: 415
		private static readonly EdgeCollider2D.set_useAdjacentEndPointDelegate set_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint");

		// Token: 0x040001A0 RID: 416
		private static readonly EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate get_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected");

		// Token: 0x040001A1 RID: 417
		private static readonly EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate set_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected");

		// Token: 0x040001A2 RID: 418
		private static readonly EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate get_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected");

		// Token: 0x040001A3 RID: 419
		private static readonly EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate set_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected");

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate int get_edgeCountDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate IntPtr get_pointsDelegate(IntPtr @this);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate int GetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate bool SetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate bool get_useAdjacentStartPointDelegate(IntPtr @this);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate void set_useAdjacentStartPointDelegate(IntPtr @this, bool value);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate bool get_useAdjacentEndPointDelegate(IntPtr @this);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate void set_useAdjacentEndPointDelegate(IntPtr @this, bool value);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate void get_adjacentStartPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate void set_adjacentStartPoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate void get_adjacentEndPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate void set_adjacentEndPoint_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
