using System;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000013 RID: 19
	public struct BrushTransform
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000307E File Offset: 0x0000127E
		public Vector2 brushOrigin
		{
			get
			{
				return this.<brushOrigin>k__BackingField;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003086 File Offset: 0x00001286
		public Vector2 brushU
		{
			get
			{
				return this.<brushU>k__BackingField;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000308E File Offset: 0x0000128E
		public Vector2 brushV
		{
			get
			{
				return this.<brushV>k__BackingField;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00003096 File Offset: 0x00001296
		public Vector2 targetOrigin
		{
			get
			{
				return this.<targetOrigin>k__BackingField;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000309E File Offset: 0x0000129E
		public Vector2 targetX
		{
			get
			{
				return this.<targetX>k__BackingField;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000030A6 File Offset: 0x000012A6
		public Vector2 targetY
		{
			get
			{
				return this.<targetY>k__BackingField;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005A98 File Offset: 0x00003C98
		public Rect GetBrushXYBounds()
		{
			Vector2 vector = this.brushOrigin + this.brushU;
			Vector2 vector2 = this.brushOrigin + this.brushV;
			Vector2 vector3 = this.brushOrigin + this.brushU + this.brushV;
			float num = Mathf.Min(Mathf.Min(this.brushOrigin.x, vector.x), Mathf.Min(vector2.x, vector3.x));
			float num2 = Mathf.Max(Mathf.Max(this.brushOrigin.x, vector.x), Mathf.Max(vector2.x, vector3.x));
			float num3 = Mathf.Min(Mathf.Min(this.brushOrigin.y, vector.y), Mathf.Min(vector2.y, vector3.y));
			float num4 = Mathf.Max(Mathf.Max(this.brushOrigin.y, vector.y), Mathf.Max(vector2.y, vector3.y));
			return Rect.MinMaxRect(num, num3, num2, num4);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public static BrushTransform FromRect(Rect brushRect)
		{
			Vector2 min = brushRect.min;
			Vector2 vector = new Vector2(brushRect.width, 0f);
			Vector2 vector2 = new Vector2(0f, brushRect.height);
			return new BrushTransform(min, vector, vector2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public Vector2 ToBrushUV(Vector2 targetXY)
		{
			return targetXY.x * this.targetX + targetXY.y * this.targetY + this.targetOrigin;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005C3C File Offset: 0x00003E3C
		public Vector2 FromBrushUV(Vector2 brushUV)
		{
			return brushUV.x * this.brushU + brushUV.y * this.brushV + this.brushOrigin;
		}

		// Token: 0x040000EC RID: 236
		public readonly Vector2 <brushOrigin>k__BackingField;

		// Token: 0x040000ED RID: 237
		public readonly Vector2 <brushU>k__BackingField;

		// Token: 0x040000EE RID: 238
		public readonly Vector2 <brushV>k__BackingField;

		// Token: 0x040000EF RID: 239
		public readonly Vector2 <targetOrigin>k__BackingField;

		// Token: 0x040000F0 RID: 240
		public readonly Vector2 <targetX>k__BackingField;

		// Token: 0x040000F1 RID: 241
		public readonly Vector2 <targetY>k__BackingField;
	}
}
