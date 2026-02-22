using System;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public abstract class GridBrushBase : ScriptableObject
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002938 File Offset: 0x00000B38
		public virtual void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000293B File Offset: 0x00000B3B
		public virtual void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004578 File Offset: 0x00002778
		public virtual void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Paint(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000045F8 File Offset: 0x000027F8
		public virtual void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Erase(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000293E File Offset: 0x00000B3E
		public virtual void Select(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002941 File Offset: 0x00000B41
		public virtual void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002944 File Offset: 0x00000B44
		public virtual void Rotate(GridBrushBase.RotationDirection direction, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002947 File Offset: 0x00000B47
		public virtual void Flip(GridBrushBase.FlipAxis flip, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000294A File Offset: 0x00000B4A
		public virtual void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000294D File Offset: 0x00000B4D
		public virtual void Move(GridLayout gridLayout, GameObject brushTarget, BoundsInt from, BoundsInt to)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002950 File Offset: 0x00000B50
		public virtual void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002953 File Offset: 0x00000B53
		public virtual void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002956 File Offset: 0x00000B56
		public virtual void ChangeZPosition(int change)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002959 File Offset: 0x00000B59
		public virtual void ResetZPosition()
		{
		}

		// Token: 0x02000053 RID: 83
		public enum Tool
		{
			// Token: 0x0400009B RID: 155
			Select,
			// Token: 0x0400009C RID: 156
			Move,
			// Token: 0x0400009D RID: 157
			Paint,
			// Token: 0x0400009E RID: 158
			Box,
			// Token: 0x0400009F RID: 159
			Pick,
			// Token: 0x040000A0 RID: 160
			Erase,
			// Token: 0x040000A1 RID: 161
			FloodFill
		}

		// Token: 0x02000054 RID: 84
		public enum RotationDirection
		{
			// Token: 0x040000A3 RID: 163
			Clockwise,
			// Token: 0x040000A4 RID: 164
			CounterClockwise
		}

		// Token: 0x02000055 RID: 85
		public enum FlipAxis
		{
			// Token: 0x040000A6 RID: 166
			X,
			// Token: 0x040000A7 RID: 167
			Y
		}
	}
}
