using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001B6 RID: 438
	public static class MeshBuilder
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x00038B8C File Offset: 0x00036D8C
		public static Vertex ConvertTextVertexToUIRVertex(TextVertex textVertex, Vector2 offset)
		{
			return new Vertex
			{
				position = new Vector3(textVertex.position.x + offset.x, textVertex.position.y + offset.y, 0f),
				uv = textVertex.uv0,
				tint = textVertex.color,
				flags = new Color32(1, 0, 0, 0)
			};
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0000B6ED File Offset: 0x000098ED
		public static int LimitTextVertices(int vertexCount, [Optional] bool logTruncation)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000B6FA File Offset: 0x000098FA
		public unsafe static void RectClipTriangle(Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00038C08 File Offset: 0x00036E08
		public unsafe static Vector3 GetVertexBaryCentricCoordinates(Vertex* vt, float x, float y)
		{
			float num = vt[1].position.x - vt->position.x;
			float num2 = vt[1].position.y - vt->position.y;
			float num3 = vt[2].position.x - vt->position.x;
			float num4 = vt[2].position.y - vt->position.y;
			float num5 = x - vt->position.x;
			float num6 = y - vt->position.y;
			float num7 = num * num + num2 * num2;
			float num8 = num * num3 + num2 * num4;
			float num9 = num3 * num3 + num4 * num4;
			float num10 = num5 * num + num6 * num2;
			float num11 = num5 * num3 + num6 * num4;
			float num12 = num7 * num9 - num8 * num8;
			Vector3 vector;
			vector.y = (num9 * num10 - num8 * num11) / num12;
			vector.z = (num7 * num11 - num8 * num10) / num12;
			vector.x = 1f - vector.y - vector.z;
			return vector;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00038D44 File Offset: 0x00036F44
		public unsafe static Vertex InterpolateVertexInTriangle(Vertex* vt, float x, float y, Vector3 uvw)
		{
			Vertex vertex = *vt;
			vertex.position.x = x;
			vertex.position.y = y;
			vertex.tint = vt->tint * uvw.x + vt[1].tint * uvw.y + vt[2].tint * uvw.z;
			vertex.uv = vt->uv * uvw.x + vt[1].uv * uvw.y + vt[2].uv * uvw.z;
			return vertex;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00038E38 File Offset: 0x00037038
		public unsafe static Vertex InterpolateVertexInTriangleEdge(Vertex* vt, int e0, int e1, float t)
		{
			Vertex vertex = *vt;
			vertex.position.x = vt[e0].position.x + t * (vt[e1].position.x - vt[e0].position.x);
			vertex.position.y = vt[e0].position.y + t * (vt[e1].position.y - vt[e0].position.y);
			vertex.tint = Color.LerpUnclamped(vt[e0].tint, vt[e1].tint, t);
			vertex.uv = Vector2.LerpUnclamped(vt[e0].uv, vt[e1].uv, t);
			return vertex;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00038F5C File Offset: 0x0003715C
		public static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
		{
			float num = (ax - dx) * (by - dy) - (ay - dy) * (bx - dx);
			float num2 = (ax - cx) * (by - cy) - (ay - cy) * (bx - cx);
			bool flag = num * num2 >= 0f;
			float num3;
			if (flag)
			{
				num3 = float.MaxValue;
			}
			else
			{
				float num4 = (cx - ax) * (dy - ay) - (cy - ay) * (dx - ax);
				float num5 = num4 + num2 - num;
				bool flag2 = num4 * num5 >= 0f;
				if (flag2)
				{
					num3 = float.MaxValue;
				}
				else
				{
					num3 = num4 / (num4 - num5);
				}
			}
			return num3;
		}
	}
}
