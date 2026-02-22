using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public class Joint2D : Behaviour
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000B700 File Offset: 0x00009900
		public Rigidbody2D attachedRigidbody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_attachedRigidbodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000B72C File Offset: 0x0000992C
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003AA9 File Offset: 0x00001CA9
		public Rigidbody2D connectedBody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				Joint2D.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00003AC1 File Offset: 0x00001CC1
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public bool enableCollision
		{
			get
			{
				return Joint2D.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00003AE6 File Offset: 0x00001CE6
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public float breakForce
		{
			get
			{
				return Joint2D.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00003B0B File Offset: 0x00001D0B
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003B1D File Offset: 0x00001D1D
		public float breakTorque
		{
			get
			{
				return Joint2D.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000B758 File Offset: 0x00009958
		public Vector2 reactionForce
		{
			get
			{
				Vector2 vector;
				this.get_reactionForce_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00003B30 File Offset: 0x00001D30
		public float reactionTorque
		{
			get
			{
				return Joint2D.get_reactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B770 File Offset: 0x00009970
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			this.GetReactionForce_Injected(timeStep, out vector);
			return vector;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003B42 File Offset: 0x00001D42
		public float GetReactionTorque(float timeStep)
		{
			return Joint2D.GetReactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003B55 File Offset: 0x00001D55
		public void get_reactionForce_Injected(out Vector2 ret)
		{
			Joint2D.get_reactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003B68 File Offset: 0x00001D68
		public void GetReactionForce_Injected(float timeStep, out Vector2 ret)
		{
			Joint2D.GetReactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep, out ret);
		}

		// Token: 0x040001C6 RID: 454
		private static readonly Joint2D.get_attachedRigidbodyDelegate get_attachedRigidbodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_attachedRigidbodyDelegate>("UnityEngine.Joint2D::get_attachedRigidbody");

		// Token: 0x040001C7 RID: 455
		private static readonly Joint2D.get_connectedBodyDelegate get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_connectedBodyDelegate>("UnityEngine.Joint2D::get_connectedBody");

		// Token: 0x040001C8 RID: 456
		private static readonly Joint2D.set_connectedBodyDelegate set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.set_connectedBodyDelegate>("UnityEngine.Joint2D::set_connectedBody");

		// Token: 0x040001C9 RID: 457
		private static readonly Joint2D.get_enableCollisionDelegate get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.get_enableCollisionDelegate>("UnityEngine.Joint2D::get_enableCollision");

		// Token: 0x040001CA RID: 458
		private static readonly Joint2D.set_enableCollisionDelegate set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.set_enableCollisionDelegate>("UnityEngine.Joint2D::set_enableCollision");

		// Token: 0x040001CB RID: 459
		private static readonly Joint2D.get_breakForceDelegate get_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakForceDelegate>("UnityEngine.Joint2D::get_breakForce");

		// Token: 0x040001CC RID: 460
		private static readonly Joint2D.set_breakForceDelegate set_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakForceDelegate>("UnityEngine.Joint2D::set_breakForce");

		// Token: 0x040001CD RID: 461
		private static readonly Joint2D.get_breakTorqueDelegate get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakTorqueDelegate>("UnityEngine.Joint2D::get_breakTorque");

		// Token: 0x040001CE RID: 462
		private static readonly Joint2D.set_breakTorqueDelegate set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakTorqueDelegate>("UnityEngine.Joint2D::set_breakTorque");

		// Token: 0x040001CF RID: 463
		private static readonly Joint2D.get_reactionTorqueDelegate get_reactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionTorqueDelegate>("UnityEngine.Joint2D::get_reactionTorque");

		// Token: 0x040001D0 RID: 464
		private static readonly Joint2D.GetReactionTorqueDelegate GetReactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionTorqueDelegate>("UnityEngine.Joint2D::GetReactionTorque");

		// Token: 0x040001D1 RID: 465
		private static readonly Joint2D.get_reactionForce_InjectedDelegate get_reactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionForce_InjectedDelegate>("UnityEngine.Joint2D::get_reactionForce_Injected");

		// Token: 0x040001D2 RID: 466
		private static readonly Joint2D.GetReactionForce_InjectedDelegate GetReactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionForce_InjectedDelegate>("UnityEngine.Joint2D::GetReactionForce_Injected");

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x06000670 RID: 1648
		private delegate IntPtr get_attachedRigidbodyDelegate(IntPtr @this);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x06000672 RID: 1650
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06000674 RID: 1652
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x06000676 RID: 1654
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x06000678 RID: 1656
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x0600067A RID: 1658
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x0600067C RID: 1660
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x0600067E RID: 1662
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x06000680 RID: 1664
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x06000682 RID: 1666
		private delegate float get_reactionTorqueDelegate(IntPtr @this);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x06000684 RID: 1668
		private delegate float GetReactionTorqueDelegate(IntPtr @this, float timeStep);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000686 RID: 1670
		private delegate void get_reactionForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000688 RID: 1672
		private delegate void GetReactionForce_InjectedDelegate(IntPtr @this, float timeStep, [Out] IntPtr ret);
	}
}
