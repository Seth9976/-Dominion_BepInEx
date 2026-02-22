using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020001E3 RID: 483
	public static class Lerp
	{
		// Token: 0x06001326 RID: 4902 RVA: 0x0003AB64 File Offset: 0x00038D64
		public static float Interpolate(float start, float end, float ratio)
		{
			return Mathf.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0003AB80 File Offset: 0x00038D80
		public static int Interpolate(int start, int end, float ratio)
		{
			return Mathf.RoundToInt(Mathf.LerpUnclamped((float)start, (float)end, ratio));
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0003ABA4 File Offset: 0x00038DA4
		public static Rect Interpolate(Rect r1, Rect r2, float ratio)
		{
			return new Rect(Mathf.LerpUnclamped(r1.x, r2.x, ratio), Mathf.LerpUnclamped(r1.y, r2.y, ratio), Mathf.LerpUnclamped(r1.width, r2.width, ratio), Mathf.LerpUnclamped(r1.height, r2.height, ratio));
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0003AC0C File Offset: 0x00038E0C
		public static Color Interpolate(Color start, Color end, float ratio)
		{
			return Color.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0003AC28 File Offset: 0x00038E28
		public static Vector2 Interpolate(Vector2 start, Vector2 end, float ratio)
		{
			return Vector2.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0003AC44 File Offset: 0x00038E44
		public static Vector3 Interpolate(Vector3 start, Vector3 end, float ratio)
		{
			return Vector3.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0003AC60 File Offset: 0x00038E60
		public static Quaternion Interpolate(Quaternion start, Quaternion end, float ratio)
		{
			return Quaternion.SlerpUnclamped(start, end, ratio);
		}
	}
}
