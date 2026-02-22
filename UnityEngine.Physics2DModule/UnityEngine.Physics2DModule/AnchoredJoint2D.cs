using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class AnchoredJoint2D : Joint2D
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000B7F0 File Offset: 0x000099F0
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003B7C File Offset: 0x00001D7C
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000B808 File Offset: 0x00009A08
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003B86 File Offset: 0x00001D86
		public Vector2 connectedAnchor
		{
			get
			{
				Vector2 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_connectedAnchor_Injected(ref value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00003B90 File Offset: 0x00001D90
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003BA2 File Offset: 0x00001DA2
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public void get_anchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public void set_anchor_Injected(ref Vector2 value)
		{
			AnchoredJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003BDB File Offset: 0x00001DDB
		public void get_connectedAnchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003BEE File Offset: 0x00001DEE
		public void set_connectedAnchor_Injected(ref Vector2 value)
		{
			AnchoredJoint2D.set_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001D3 RID: 467
		private static readonly AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::get_autoConfigureConnectedAnchor");

		// Token: 0x040001D4 RID: 468
		private static readonly AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor");

		// Token: 0x040001D5 RID: 469
		private static readonly AnchoredJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_anchor_Injected");

		// Token: 0x040001D6 RID: 470
		private static readonly AnchoredJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_anchor_Injected");

		// Token: 0x040001D7 RID: 471
		private static readonly AnchoredJoint2D.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_connectedAnchor_Injected");

		// Token: 0x040001D8 RID: 472
		private static readonly AnchoredJoint2D.set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_connectedAnchor_Injected");

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate void set_connectedAnchor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
