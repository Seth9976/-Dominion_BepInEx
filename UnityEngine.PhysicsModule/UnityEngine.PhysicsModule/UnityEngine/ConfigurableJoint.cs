using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	public class ConfigurableJoint : Joint
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000A0F4 File Offset: 0x000082F4
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003FA4 File Offset: 0x000021A4
		public Vector3 secondaryAxis
		{
			get
			{
				Vector3 vector;
				this.get_secondaryAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_secondaryAxis_Injected(ref value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00003FAE File Offset: 0x000021AE
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003FC0 File Offset: 0x000021C0
		public ConfigurableJointMotion xMotion
		{
			get
			{
				return ConfigurableJoint.get_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00003FD3 File Offset: 0x000021D3
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003FE5 File Offset: 0x000021E5
		public ConfigurableJointMotion yMotion
		{
			get
			{
				return ConfigurableJoint.get_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00003FF8 File Offset: 0x000021F8
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000400A File Offset: 0x0000220A
		public ConfigurableJointMotion zMotion
		{
			get
			{
				return ConfigurableJoint.get_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000401D File Offset: 0x0000221D
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000402F File Offset: 0x0000222F
		public ConfigurableJointMotion angularXMotion
		{
			get
			{
				return ConfigurableJoint.get_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00004042 File Offset: 0x00002242
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00004054 File Offset: 0x00002254
		public ConfigurableJointMotion angularYMotion
		{
			get
			{
				return ConfigurableJoint.get_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00004067 File Offset: 0x00002267
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00004079 File Offset: 0x00002279
		public ConfigurableJointMotion angularZMotion
		{
			get
			{
				return ConfigurableJoint.get_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000A10C File Offset: 0x0000830C
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000408C File Offset: 0x0000228C
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.get_targetPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetPosition_Injected(ref value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000A124 File Offset: 0x00008324
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00004096 File Offset: 0x00002296
		public Vector3 targetVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000A13C File Offset: 0x0000833C
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000040A0 File Offset: 0x000022A0
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_targetRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_targetRotation_Injected(ref value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000A154 File Offset: 0x00008354
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000040AA File Offset: 0x000022AA
		public Vector3 targetAngularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetAngularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetAngularVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000040B4 File Offset: 0x000022B4
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000040C6 File Offset: 0x000022C6
		public RotationDriveMode rotationDriveMode
		{
			get
			{
				return ConfigurableJoint.get_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000040D9 File Offset: 0x000022D9
		// (set) Token: 0x0600035F RID: 863 RVA: 0x000040EB File Offset: 0x000022EB
		public JointProjectionMode projectionMode
		{
			get
			{
				return ConfigurableJoint.get_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000040FE File Offset: 0x000022FE
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00004110 File Offset: 0x00002310
		public float projectionDistance
		{
			get
			{
				return ConfigurableJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00004123 File Offset: 0x00002323
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00004135 File Offset: 0x00002335
		public float projectionAngle
		{
			get
			{
				return ConfigurableJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00004148 File Offset: 0x00002348
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0000415A File Offset: 0x0000235A
		public bool configuredInWorldSpace
		{
			get
			{
				return ConfigurableJoint.get_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000416D File Offset: 0x0000236D
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000417F File Offset: 0x0000237F
		public bool swapBodies
		{
			get
			{
				return ConfigurableJoint.get_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00004192 File Offset: 0x00002392
		public void get_secondaryAxis_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000041A5 File Offset: 0x000023A5
		public void set_secondaryAxis_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000041B8 File Offset: 0x000023B8
		public void get_targetPosition_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000041CB File Offset: 0x000023CB
		public void set_targetPosition_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000041DE File Offset: 0x000023DE
		public void get_targetVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000041F1 File Offset: 0x000023F1
		public void set_targetVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00004204 File Offset: 0x00002404
		public void get_targetRotation_Injected(out Quaternion ret)
		{
			ConfigurableJoint.get_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00004217 File Offset: 0x00002417
		public void set_targetRotation_Injected(ref Quaternion value)
		{
			ConfigurableJoint.set_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000422A File Offset: 0x0000242A
		public void get_targetAngularVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000423D File Offset: 0x0000243D
		public void set_targetAngularVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000211 RID: 529
		private static readonly ConfigurableJoint.get_xMotionDelegate get_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_xMotionDelegate>("UnityEngine.ConfigurableJoint::get_xMotion");

		// Token: 0x04000212 RID: 530
		private static readonly ConfigurableJoint.set_xMotionDelegate set_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_xMotionDelegate>("UnityEngine.ConfigurableJoint::set_xMotion");

		// Token: 0x04000213 RID: 531
		private static readonly ConfigurableJoint.get_yMotionDelegate get_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_yMotionDelegate>("UnityEngine.ConfigurableJoint::get_yMotion");

		// Token: 0x04000214 RID: 532
		private static readonly ConfigurableJoint.set_yMotionDelegate set_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_yMotionDelegate>("UnityEngine.ConfigurableJoint::set_yMotion");

		// Token: 0x04000215 RID: 533
		private static readonly ConfigurableJoint.get_zMotionDelegate get_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_zMotionDelegate>("UnityEngine.ConfigurableJoint::get_zMotion");

		// Token: 0x04000216 RID: 534
		private static readonly ConfigurableJoint.set_zMotionDelegate set_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_zMotionDelegate>("UnityEngine.ConfigurableJoint::set_zMotion");

		// Token: 0x04000217 RID: 535
		private static readonly ConfigurableJoint.get_angularXMotionDelegate get_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularXMotion");

		// Token: 0x04000218 RID: 536
		private static readonly ConfigurableJoint.set_angularXMotionDelegate set_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularXMotion");

		// Token: 0x04000219 RID: 537
		private static readonly ConfigurableJoint.get_angularYMotionDelegate get_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularYMotion");

		// Token: 0x0400021A RID: 538
		private static readonly ConfigurableJoint.set_angularYMotionDelegate set_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularYMotion");

		// Token: 0x0400021B RID: 539
		private static readonly ConfigurableJoint.get_angularZMotionDelegate get_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularZMotion");

		// Token: 0x0400021C RID: 540
		private static readonly ConfigurableJoint.set_angularZMotionDelegate set_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularZMotion");

		// Token: 0x0400021D RID: 541
		private static readonly ConfigurableJoint.get_rotationDriveModeDelegate get_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::get_rotationDriveMode");

		// Token: 0x0400021E RID: 542
		private static readonly ConfigurableJoint.set_rotationDriveModeDelegate set_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::set_rotationDriveMode");

		// Token: 0x0400021F RID: 543
		private static readonly ConfigurableJoint.get_projectionModeDelegate get_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionModeDelegate>("UnityEngine.ConfigurableJoint::get_projectionMode");

		// Token: 0x04000220 RID: 544
		private static readonly ConfigurableJoint.set_projectionModeDelegate set_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionModeDelegate>("UnityEngine.ConfigurableJoint::set_projectionMode");

		// Token: 0x04000221 RID: 545
		private static readonly ConfigurableJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::get_projectionDistance");

		// Token: 0x04000222 RID: 546
		private static readonly ConfigurableJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::set_projectionDistance");

		// Token: 0x04000223 RID: 547
		private static readonly ConfigurableJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::get_projectionAngle");

		// Token: 0x04000224 RID: 548
		private static readonly ConfigurableJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::set_projectionAngle");

		// Token: 0x04000225 RID: 549
		private static readonly ConfigurableJoint.get_configuredInWorldSpaceDelegate get_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::get_configuredInWorldSpace");

		// Token: 0x04000226 RID: 550
		private static readonly ConfigurableJoint.set_configuredInWorldSpaceDelegate set_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::set_configuredInWorldSpace");

		// Token: 0x04000227 RID: 551
		private static readonly ConfigurableJoint.get_swapBodiesDelegate get_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::get_swapBodies");

		// Token: 0x04000228 RID: 552
		private static readonly ConfigurableJoint.set_swapBodiesDelegate set_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::set_swapBodies");

		// Token: 0x04000229 RID: 553
		private static readonly ConfigurableJoint.get_secondaryAxis_InjectedDelegate get_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_secondaryAxis_Injected");

		// Token: 0x0400022A RID: 554
		private static readonly ConfigurableJoint.set_secondaryAxis_InjectedDelegate set_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_secondaryAxis_Injected");

		// Token: 0x0400022B RID: 555
		private static readonly ConfigurableJoint.get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetPosition_Injected");

		// Token: 0x0400022C RID: 556
		private static readonly ConfigurableJoint.set_targetPosition_InjectedDelegate set_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetPosition_Injected");

		// Token: 0x0400022D RID: 557
		private static readonly ConfigurableJoint.get_targetVelocity_InjectedDelegate get_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetVelocity_Injected");

		// Token: 0x0400022E RID: 558
		private static readonly ConfigurableJoint.set_targetVelocity_InjectedDelegate set_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetVelocity_Injected");

		// Token: 0x0400022F RID: 559
		private static readonly ConfigurableJoint.get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetRotation_Injected");

		// Token: 0x04000230 RID: 560
		private static readonly ConfigurableJoint.set_targetRotation_InjectedDelegate set_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetRotation_Injected");

		// Token: 0x04000231 RID: 561
		private static readonly ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate get_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetAngularVelocity_Injected");

		// Token: 0x04000232 RID: 562
		private static readonly ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate set_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetAngularVelocity_Injected");

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x06000637 RID: 1591
		private delegate ConfigurableJointMotion get_xMotionDelegate(IntPtr @this);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x06000639 RID: 1593
		private delegate void set_xMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x0600063B RID: 1595
		private delegate ConfigurableJointMotion get_yMotionDelegate(IntPtr @this);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x0600063D RID: 1597
		private delegate void set_yMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x0600063F RID: 1599
		private delegate ConfigurableJointMotion get_zMotionDelegate(IntPtr @this);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x06000641 RID: 1601
		private delegate void set_zMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06000643 RID: 1603
		private delegate ConfigurableJointMotion get_angularXMotionDelegate(IntPtr @this);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x06000645 RID: 1605
		private delegate void set_angularXMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x06000647 RID: 1607
		private delegate ConfigurableJointMotion get_angularYMotionDelegate(IntPtr @this);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x06000649 RID: 1609
		private delegate void set_angularYMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x0600064B RID: 1611
		private delegate ConfigurableJointMotion get_angularZMotionDelegate(IntPtr @this);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x0600064D RID: 1613
		private delegate void set_angularZMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x0600064F RID: 1615
		private delegate RotationDriveMode get_rotationDriveModeDelegate(IntPtr @this);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000651 RID: 1617
		private delegate void set_rotationDriveModeDelegate(IntPtr @this, RotationDriveMode value);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000653 RID: 1619
		private delegate JointProjectionMode get_projectionModeDelegate(IntPtr @this);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000655 RID: 1621
		private delegate void set_projectionModeDelegate(IntPtr @this, JointProjectionMode value);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x06000657 RID: 1623
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x06000659 RID: 1625
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x0600065B RID: 1627
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x0600065D RID: 1629
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x0600065F RID: 1631
		private delegate bool get_configuredInWorldSpaceDelegate(IntPtr @this);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000661 RID: 1633
		private delegate void set_configuredInWorldSpaceDelegate(IntPtr @this, bool value);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000663 RID: 1635
		private delegate bool get_swapBodiesDelegate(IntPtr @this);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000665 RID: 1637
		private delegate void set_swapBodiesDelegate(IntPtr @this, bool value);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x06000667 RID: 1639
		private delegate void get_secondaryAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x06000669 RID: 1641
		private delegate void set_secondaryAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x0600066B RID: 1643
		private delegate void get_targetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x0600066D RID: 1645
		private delegate void set_targetPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x0600066F RID: 1647
		private delegate void get_targetVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000671 RID: 1649
		private delegate void set_targetVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000673 RID: 1651
		private delegate void get_targetRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000675 RID: 1653
		private delegate void set_targetRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000677 RID: 1655
		private delegate void get_targetAngularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x06000679 RID: 1657
		private delegate void set_targetAngularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
