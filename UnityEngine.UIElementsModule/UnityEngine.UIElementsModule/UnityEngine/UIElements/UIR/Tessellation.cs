using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001BC RID: 444
	public static class Tessellation
	{
		// Token: 0x06001203 RID: 4611 RVA: 0x0003904C File Offset: 0x0003724C
		public static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			Vector2 vector = rect.position + radius;
			Rect zero = Rect.zero;
			bool flag = radius == Vector2.zero;
			if (flag)
			{
				Tessellation.TessellateQuad(rect, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
			}
			else
			{
				Tessellation.TessellateFilledFan(Tessellation.TessellationType.Content, vector, radius, 0f, 0f, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				bool flag2 = radius.x < rect.width;
				if (flag2)
				{
					zero = new Rect(rect.x + radius.x, rect.y, rect.width - radius.x, rect.height);
					Tessellation.TessellateQuad(zero, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				}
				bool flag3 = radius.y < rect.height;
				if (flag3)
				{
					zero = new Rect(rect.x, rect.y + radius.y, (radius.x < rect.width) ? radius.x : rect.width, rect.height - radius.y);
					Tessellation.TessellateQuad(zero, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				}
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0000B9F6 File Offset: 0x00009BF6
		public static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000391A8 File Offset: 0x000373A8
		public static Vector2 IntersectEllipseWithLine(float a, float b, Vector2 dir)
		{
			Debug.Assert(dir.x > 0f || dir.y > 0f);
			bool flag = a < Mathf.Epsilon || b < Mathf.Epsilon;
			Vector2 vector;
			if (flag)
			{
				vector = new Vector2(0f, 0f);
			}
			else
			{
				bool flag2 = (double)dir.y < 0.001 * (double)dir.x;
				if (flag2)
				{
					vector = new Vector2(a, 0f);
				}
				else
				{
					bool flag3 = (double)dir.x < 0.001 * (double)dir.y;
					if (flag3)
					{
						vector = new Vector2(0f, b);
					}
					else
					{
						float num = dir.y / dir.x;
						float num2 = b / a;
						float num3 = b * (num2 + num - Mathf.Sqrt(2f * num * num2)) / (num * num + num2 * num2);
						float num4 = num * num3;
						vector = new Vector2(num3, num4);
					}
				}
			}
			return vector;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000392A8 File Offset: 0x000374A8
		public static float GetCenteredEllipseLineIntersectionTheta(float a, float b, Vector2 dir)
		{
			return Mathf.Atan2(dir.y * a, dir.x * b);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000392D0 File Offset: 0x000374D0
		public static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			Vector2 vector = p3 - p2;
			Vector2 vector2 = p2 - p0;
			Vector2 vector3 = p1 - p0;
			float num = vector.x * vector3.y - vector3.x * vector.y;
			bool flag = Mathf.Approximately(num, 0f);
			Vector2 vector4;
			if (flag)
			{
				vector4 = new Vector2(float.NaN, float.NaN);
			}
			else
			{
				float num2 = vector.x * vector2.y - vector2.x * vector.y;
				float num3 = num2 / num;
				Vector2 vector5 = p0 + vector3 * num3;
				vector4 = vector5;
			}
			return vector4;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0000BA03 File Offset: 0x00009C03
		public static int LooseCompare(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000BA10 File Offset: 0x00009C10
		public static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort refVertexCount, ref ushort refIndexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0000BA1D File Offset: 0x00009C1D
		public static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000BA2A File Offset: 0x00009C2A
		public static void TessellateQuad(Rect rect, float miterOffset, float leftWidth, float topWidth, Tessellation.TessellationType tessellationType, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0000BA37 File Offset: 0x00009C37
		public static void TessellateFilledFan(Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000BA44 File Offset: 0x00009C44
		public static void TessellateFilledFan(Tessellation.TessellationType tessellationType, Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0000BA51 File Offset: 0x00009C51
		public static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0000BA5E File Offset: 0x00009C5E
		public static void TessellateBorderedFan(Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000296 RID: 662
		public enum TessellationType
		{
			// Token: 0x04000927 RID: 2343
			EdgeHorizontal,
			// Token: 0x04000928 RID: 2344
			EdgeVertical,
			// Token: 0x04000929 RID: 2345
			EdgeCorner,
			// Token: 0x0400092A RID: 2346
			Content
		}
	}
}
