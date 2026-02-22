using System;

namespace UnityEngine.TextCore
{
	// Token: 0x02000037 RID: 55
	public static class TextUtilities
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000339F File Offset: 0x0000159F
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000076B4 File Offset: 0x000058B4
		public static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			Vector3 vector = b - a;
			Vector3 vector2 = m - a;
			Vector3 vector3 = c - b;
			Vector3 vector4 = m - b;
			float num = Vector3.Dot(vector, vector2);
			float num2 = Vector3.Dot(vector3, vector4);
			return 0f <= num && num <= Vector3.Dot(vector, vector) && 0f <= num2 && num2 <= Vector3.Dot(vector3, vector3);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007728 File Offset: 0x00005928
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			worldPoint = Vector3.zero;
			Ray ray = cam.ScreenPointToRay(screenPoint);
			float num;
			bool flag = !new Plane(transform.rotation * Vector3.back, transform.position).Raycast(ray, out num);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				worldPoint = ray.GetPoint(num);
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000033AC File Offset: 0x000015AC
		public static bool IntersectLinePlane(TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00007798 File Offset: 0x00005998
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			Vector3 vector = b - a;
			Vector3 vector2 = a - point;
			float num = Vector3.Dot(vector, vector2);
			bool flag = num > 0f;
			float num2;
			if (flag)
			{
				num2 = Vector3.Dot(vector2, vector2);
			}
			else
			{
				Vector3 vector3 = point - b;
				bool flag2 = Vector3.Dot(vector, vector3) > 0f;
				if (flag2)
				{
					num2 = Vector3.Dot(vector3, vector3);
				}
				else
				{
					Vector3 vector4 = vector2 - vector * (num / Vector3.Dot(vector, vector));
					num2 = Vector3.Dot(vector4, vector4);
				}
			}
			return num2;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007824 File Offset: 0x00005A24
		public static char ToLowerFast(char c)
		{
			bool flag = (int)c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1;
			char c2;
			if (flag)
			{
				c2 = c;
			}
			else
			{
				c2 = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".get_Chars((int)c);
			}
			return c2;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00007858 File Offset: 0x00005A58
		public static char ToUpperFast(char c)
		{
			bool flag = (int)c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".Length - 1;
			char c2;
			if (flag)
			{
				c2 = c;
			}
			else
			{
				c2 = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".get_Chars((int)c);
			}
			return c2;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000788C File Offset: 0x00005A8C
		public static uint ToUpperASCIIFast(uint c)
		{
			bool flag = (ulong)c > (ulong)((long)("-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".Length - 1));
			uint num;
			if (flag)
			{
				num = c;
			}
			else
			{
				num = (uint)"-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".get_Chars((int)c);
			}
			return num;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000078C4 File Offset: 0x00005AC4
		public static uint ToLowerASCIIFast(uint c)
		{
			bool flag = (ulong)c > (ulong)((long)("-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1));
			uint num;
			if (flag)
			{
				num = c;
			}
			else
			{
				num = (uint)"-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".get_Chars((int)c);
			}
			return num;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000078FC File Offset: 0x00005AFC
		public static int GetHashCodeCaseSensitive(string s)
		{
			int num = 0;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((num << 5) + num) ^ (int)s.get_Chars(i);
			}
			return num;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00007934 File Offset: 0x00005B34
		public static int GetHashCodeCaseInSensitive(string s)
		{
			int num = 0;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((num << 5) + num) ^ (int)TextUtilities.ToUpperASCIIFast((uint)s.get_Chars(i));
			}
			return num;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007974 File Offset: 0x00005B74
		public static uint GetSimpleHashCodeLowercase(string s)
		{
			uint num = 5381U;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((num << 5) + num) ^ (uint)TextUtilities.ToLowerFast(s.get_Chars(i));
			}
			return num;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static int HexToInt(char hex)
		{
			switch (hex)
			{
			case '0':
				return 0;
			case '1':
				return 1;
			case '2':
				return 2;
			case '3':
				return 3;
			case '4':
				return 4;
			case '5':
				return 5;
			case '6':
				return 6;
			case '7':
				return 7;
			case '8':
				return 8;
			case '9':
				return 9;
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				break;
			case 'A':
				return 10;
			case 'B':
				return 11;
			case 'C':
				return 12;
			case 'D':
				return 13;
			case 'E':
				return 14;
			case 'F':
				return 15;
			default:
				switch (hex)
				{
				case 'a':
					return 10;
				case 'b':
					return 11;
				case 'c':
					return 12;
				case 'd':
					return 13;
				case 'e':
					return 14;
				case 'f':
					return 15;
				}
				break;
			}
			return 15;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007AC0 File Offset: 0x00005CC0
		public static int StringHexToInt(string s)
		{
			int num = 0;
			for (int i = 0; i < s.Length; i++)
			{
				num += TextUtilities.HexToInt(s.get_Chars(i)) * (int)Mathf.Pow(16f, (float)(s.Length - 1 - i));
			}
			return num;
		}

		// Token: 0x04000235 RID: 565
		public const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		// Token: 0x04000236 RID: 566
		public const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		// Token: 0x02000069 RID: 105
		public struct LineSegment
		{
		}
	}
}
