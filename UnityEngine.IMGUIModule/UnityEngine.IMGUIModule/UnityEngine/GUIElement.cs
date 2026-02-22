using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public sealed class GUIElement
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00004A01 File Offset: 0x00002C01
		public static void FeatureRemoved()
		{
			throw new Exception("GUIElement has been removed from Unity.");
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00016CCC File Offset: 0x00014ECC
		public bool HitTest(Vector3 screenPosition)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00016CE8 File Offset: 0x00014EE8
		public bool HitTest(Vector3 screenPosition, Camera camera)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00016D04 File Offset: 0x00014F04
		public Rect GetScreenRect(Camera camera)
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00016D38 File Offset: 0x00014F38
		public Rect GetScreenRect()
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}
	}
}
