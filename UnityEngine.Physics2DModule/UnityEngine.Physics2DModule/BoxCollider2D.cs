using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class BoxCollider2D : Collider2D
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000B12C File Offset: 0x0000932C
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000037F0 File Offset: 0x000019F0
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000037FA File Offset: 0x000019FA
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0000380C File Offset: 0x00001A0C
		public float edgeRadius
		{
			get
			{
				return BoxCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000381F File Offset: 0x00001A1F
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003831 File Offset: 0x00001A31
		public bool autoTiling
		{
			get
			{
				return BoxCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003844 File Offset: 0x00001A44
		public void get_size_Injected(out Vector2 ret)
		{
			BoxCollider2D.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003857 File Offset: 0x00001A57
		public void set_size_Injected(ref Vector2 value)
		{
			BoxCollider2D.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001A4 RID: 420
		private static readonly BoxCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::get_edgeRadius");

		// Token: 0x040001A5 RID: 421
		private static readonly BoxCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::set_edgeRadius");

		// Token: 0x040001A6 RID: 422
		private static readonly BoxCollider2D.get_autoTilingDelegate get_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_autoTilingDelegate>("UnityEngine.BoxCollider2D::get_autoTiling");

		// Token: 0x040001A7 RID: 423
		private static readonly BoxCollider2D.set_autoTilingDelegate set_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_autoTilingDelegate>("UnityEngine.BoxCollider2D::set_autoTiling");

		// Token: 0x040001A8 RID: 424
		private static readonly BoxCollider2D.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_size_InjectedDelegate>("UnityEngine.BoxCollider2D::get_size_Injected");

		// Token: 0x040001A9 RID: 425
		private static readonly BoxCollider2D.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_size_InjectedDelegate>("UnityEngine.BoxCollider2D::set_size_Injected");

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
