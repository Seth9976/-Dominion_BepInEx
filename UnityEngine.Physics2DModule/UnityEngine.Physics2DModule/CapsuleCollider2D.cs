using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public sealed class CapsuleCollider2D : Collider2D
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000AF44 File Offset: 0x00009144
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000364E File Offset: 0x0000184E
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000366A File Offset: 0x0000186A
		public CapsuleDirection2D direction
		{
			get
			{
				return CapsuleCollider2D.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider2D.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000367D File Offset: 0x0000187D
		public void get_size_Injected(out Vector2 ret)
		{
			CapsuleCollider2D.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003690 File Offset: 0x00001890
		public void set_size_Injected(ref Vector2 value)
		{
			CapsuleCollider2D.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400018F RID: 399
		private static readonly CapsuleCollider2D.get_directionDelegate get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_directionDelegate>("UnityEngine.CapsuleCollider2D::get_direction");

		// Token: 0x04000190 RID: 400
		private static readonly CapsuleCollider2D.set_directionDelegate set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_directionDelegate>("UnityEngine.CapsuleCollider2D::set_direction");

		// Token: 0x04000191 RID: 401
		private static readonly CapsuleCollider2D.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::get_size_Injected");

		// Token: 0x04000192 RID: 402
		private static readonly CapsuleCollider2D.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::set_size_Injected");

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate CapsuleDirection2D get_directionDelegate(IntPtr @this);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate void set_directionDelegate(IntPtr @this, CapsuleDirection2D value);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
