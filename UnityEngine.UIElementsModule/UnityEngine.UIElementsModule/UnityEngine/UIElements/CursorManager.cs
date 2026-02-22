using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FA RID: 250
	public class CursorManager
	{
		// Token: 0x06000D81 RID: 3457 RVA: 0x000347FC File Offset: 0x000329FC
		public void SetCursor(Cursor cursor)
		{
			bool flag = cursor.texture != null;
			if (flag)
			{
				Cursor.SetCursor(cursor.texture, cursor.hotspot, CursorMode.Auto);
			}
			else
			{
				bool flag2 = cursor.defaultCursorId != 0;
				if (flag2)
				{
					Debug.LogWarning("Runtime cursors other than the default cursor need to be defined using a texture.");
				}
				this.ResetCursor();
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000088F7 File Offset: 0x00006AF7
		public void ResetCursor()
		{
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		}
	}
}
