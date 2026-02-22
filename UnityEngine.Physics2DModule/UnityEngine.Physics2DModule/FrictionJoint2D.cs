using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public sealed class FrictionJoint2D : AnchoredJoint2D
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00003D42 File Offset: 0x00001F42
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003D54 File Offset: 0x00001F54
		public float maxForce
		{
			get
			{
				return FrictionJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00003D67 File Offset: 0x00001F67
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003D79 File Offset: 0x00001F79
		public float maxTorque
		{
			get
			{
				return FrictionJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001E7 RID: 487
		private static readonly FrictionJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxForceDelegate>("UnityEngine.FrictionJoint2D::get_maxForce");

		// Token: 0x040001E8 RID: 488
		private static readonly FrictionJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxForceDelegate>("UnityEngine.FrictionJoint2D::set_maxForce");

		// Token: 0x040001E9 RID: 489
		private static readonly FrictionJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::get_maxTorque");

		// Token: 0x040001EA RID: 490
		private static readonly FrictionJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::set_maxTorque");

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x060006B2 RID: 1714
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x060006B4 RID: 1716
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060006B6 RID: 1718
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x060006B8 RID: 1720
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);
	}
}
