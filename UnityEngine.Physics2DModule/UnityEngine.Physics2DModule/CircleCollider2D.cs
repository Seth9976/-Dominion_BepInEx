using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public sealed class CircleCollider2D : Collider2D
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000035EB File Offset: 0x000017EB
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000035FD File Offset: 0x000017FD
		public float radius
		{
			get
			{
				return CircleCollider2D.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CircleCollider2D.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly CircleCollider2D.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<CircleCollider2D.get_radiusDelegate>("UnityEngine.CircleCollider2D::get_radius");

		// Token: 0x0400018E RID: 398
		private static readonly CircleCollider2D.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<CircleCollider2D.set_radiusDelegate>("UnityEngine.CircleCollider2D::set_radius");

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate void set_radiusDelegate(IntPtr @this, float value);
	}
}
