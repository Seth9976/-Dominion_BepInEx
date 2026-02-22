using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public sealed class GUIGridSizer : GUILayoutEntry
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x00016DF4 File Offset: 0x00014FF4
		public static Rect GetRect(Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			Rect rect = new Rect(0f, 0f, 0f, 0f);
			EventType type = Event.current.type;
			EventType eventType = type;
			if (eventType != EventType.Layout)
			{
				if (eventType == EventType.Used)
				{
					return GUILayoutEntry.kDummyRect;
				}
				rect = GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIGridSizer(contents, xCount, style, options));
			}
			return rect;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00004A59 File Offset: 0x00002C59
		public int rows
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
