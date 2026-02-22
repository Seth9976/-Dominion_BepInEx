using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000217 RID: 535
	public sealed class LineUtility
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x00064A2C File Offset: 0x00062C2C
		public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep3D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00064A6C File Offset: 0x00062C6C
		public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints3D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00064AAC File Offset: 0x00062CAC
		public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep2D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00064AEC File Offset: 0x00062CEC
		public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints2D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0001184A File Offset: 0x0000FA4A
		public static void GeneratePointsToKeep3D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00011863 File Offset: 0x0000FA63
		public static void GeneratePointsToKeep2D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0001187C File Offset: 0x0000FA7C
		public static void GenerateSimplifiedPoints3D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00011895 File Offset: 0x0000FA95
		public static void GenerateSimplifiedPoints2D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x04001851 RID: 6225
		private static readonly LineUtility.GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");

		// Token: 0x04001852 RID: 6226
		private static readonly LineUtility.GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");

		// Token: 0x04001853 RID: 6227
		private static readonly LineUtility.GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");

		// Token: 0x04001854 RID: 6228
		private static readonly LineUtility.GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

		// Token: 0x02000BDA RID: 3034
		// (Invoke) Token: 0x060035A6 RID: 13734
		private delegate void GeneratePointsToKeep3DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000BDB RID: 3035
		// (Invoke) Token: 0x060035A8 RID: 13736
		private delegate void GeneratePointsToKeep2DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000BDC RID: 3036
		// (Invoke) Token: 0x060035AA RID: 13738
		private delegate void GenerateSimplifiedPoints3DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);

		// Token: 0x02000BDD RID: 3037
		// (Invoke) Token: 0x060035AC RID: 13740
		private delegate void GenerateSimplifiedPoints2DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);
	}
}
