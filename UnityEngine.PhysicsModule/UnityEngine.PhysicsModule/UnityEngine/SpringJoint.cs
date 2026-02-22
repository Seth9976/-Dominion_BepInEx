using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public class SpringJoint : Joint
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00003E4C File Offset: 0x0000204C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00003E5E File Offset: 0x0000205E
		public float spring
		{
			get
			{
				return SpringJoint.get_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00003E71 File Offset: 0x00002071
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003E83 File Offset: 0x00002083
		public float damper
		{
			get
			{
				return SpringJoint.get_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00003E96 File Offset: 0x00002096
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00003EA8 File Offset: 0x000020A8
		public float minDistance
		{
			get
			{
				return SpringJoint.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00003EBB File Offset: 0x000020BB
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003ECD File Offset: 0x000020CD
		public float maxDistance
		{
			get
			{
				return SpringJoint.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00003EE0 File Offset: 0x000020E0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003EF2 File Offset: 0x000020F2
		public float tolerance
		{
			get
			{
				return SpringJoint.get_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001FF RID: 511
		private static readonly SpringJoint.get_springDelegate get_springDelegateField = IL2CPP.ResolveICall<SpringJoint.get_springDelegate>("UnityEngine.SpringJoint::get_spring");

		// Token: 0x04000200 RID: 512
		private static readonly SpringJoint.set_springDelegate set_springDelegateField = IL2CPP.ResolveICall<SpringJoint.set_springDelegate>("UnityEngine.SpringJoint::set_spring");

		// Token: 0x04000201 RID: 513
		private static readonly SpringJoint.get_damperDelegate get_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.get_damperDelegate>("UnityEngine.SpringJoint::get_damper");

		// Token: 0x04000202 RID: 514
		private static readonly SpringJoint.set_damperDelegate set_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.set_damperDelegate>("UnityEngine.SpringJoint::set_damper");

		// Token: 0x04000203 RID: 515
		private static readonly SpringJoint.get_minDistanceDelegate get_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_minDistanceDelegate>("UnityEngine.SpringJoint::get_minDistance");

		// Token: 0x04000204 RID: 516
		private static readonly SpringJoint.set_minDistanceDelegate set_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_minDistanceDelegate>("UnityEngine.SpringJoint::set_minDistance");

		// Token: 0x04000205 RID: 517
		private static readonly SpringJoint.get_maxDistanceDelegate get_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_maxDistanceDelegate>("UnityEngine.SpringJoint::get_maxDistance");

		// Token: 0x04000206 RID: 518
		private static readonly SpringJoint.set_maxDistanceDelegate set_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_maxDistanceDelegate>("UnityEngine.SpringJoint::set_maxDistance");

		// Token: 0x04000207 RID: 519
		private static readonly SpringJoint.get_toleranceDelegate get_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_toleranceDelegate>("UnityEngine.SpringJoint::get_tolerance");

		// Token: 0x04000208 RID: 520
		private static readonly SpringJoint.set_toleranceDelegate set_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_toleranceDelegate>("UnityEngine.SpringJoint::set_tolerance");

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x06000613 RID: 1555
		private delegate float get_springDelegate(IntPtr @this);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x06000615 RID: 1557
		private delegate void set_springDelegate(IntPtr @this, float value);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x06000617 RID: 1559
		private delegate float get_damperDelegate(IntPtr @this);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x06000619 RID: 1561
		private delegate void set_damperDelegate(IntPtr @this, float value);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x0600061B RID: 1563
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x0600061D RID: 1565
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x0600061F RID: 1567
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x06000621 RID: 1569
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x06000623 RID: 1571
		private delegate float get_toleranceDelegate(IntPtr @this);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x06000625 RID: 1573
		private delegate void set_toleranceDelegate(IntPtr @this, float value);
	}
}
