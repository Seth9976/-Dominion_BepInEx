using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public class Effector2D : Behaviour
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000041EC File Offset: 0x000023EC
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000041FE File Offset: 0x000023FE
		public bool useColliderMask
		{
			get
			{
				return Effector2D.get_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00004211 File Offset: 0x00002411
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00004223 File Offset: 0x00002423
		public int colliderMask
		{
			get
			{
				return Effector2D.get_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00004236 File Offset: 0x00002436
		public bool requiresCollider
		{
			get
			{
				return Effector2D.get_requiresColliderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00004248 File Offset: 0x00002448
		public bool designedForTrigger
		{
			get
			{
				return Effector2D.get_designedForTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000425A File Offset: 0x0000245A
		public bool designedForNonTrigger
		{
			get
			{
				return Effector2D.get_designedForNonTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly Effector2D.get_useColliderMaskDelegate get_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_useColliderMaskDelegate>("UnityEngine.Effector2D::get_useColliderMask");

		// Token: 0x04000227 RID: 551
		private static readonly Effector2D.set_useColliderMaskDelegate set_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_useColliderMaskDelegate>("UnityEngine.Effector2D::set_useColliderMask");

		// Token: 0x04000228 RID: 552
		private static readonly Effector2D.get_colliderMaskDelegate get_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_colliderMaskDelegate>("UnityEngine.Effector2D::get_colliderMask");

		// Token: 0x04000229 RID: 553
		private static readonly Effector2D.set_colliderMaskDelegate set_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_colliderMaskDelegate>("UnityEngine.Effector2D::set_colliderMask");

		// Token: 0x0400022A RID: 554
		private static readonly Effector2D.get_requiresColliderDelegate get_requiresColliderDelegateField = IL2CPP.ResolveICall<Effector2D.get_requiresColliderDelegate>("UnityEngine.Effector2D::get_requiresCollider");

		// Token: 0x0400022B RID: 555
		private static readonly Effector2D.get_designedForTriggerDelegate get_designedForTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForTriggerDelegate>("UnityEngine.Effector2D::get_designedForTrigger");

		// Token: 0x0400022C RID: 556
		private static readonly Effector2D.get_designedForNonTriggerDelegate get_designedForNonTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForNonTriggerDelegate>("UnityEngine.Effector2D::get_designedForNonTrigger");

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate bool get_useColliderMaskDelegate(IntPtr @this);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate void set_useColliderMaskDelegate(IntPtr @this, bool value);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate int get_colliderMaskDelegate(IntPtr @this);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate void set_colliderMaskDelegate(IntPtr @this, int value);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate bool get_requiresColliderDelegate(IntPtr @this);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate bool get_designedForTriggerDelegate(IntPtr @this);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate bool get_designedForNonTriggerDelegate(IntPtr @this);
	}
}
