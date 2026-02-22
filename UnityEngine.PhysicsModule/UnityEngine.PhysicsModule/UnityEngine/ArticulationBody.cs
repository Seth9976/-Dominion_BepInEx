using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class ArticulationBody : Behaviour
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00003291 File Offset: 0x00001491
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000032A3 File Offset: 0x000014A3
		public ArticulationJointType jointType
		{
			get
			{
				return ArticulationBody.get_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00009688 File Offset: 0x00007888
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000032B6 File Offset: 0x000014B6
		public Vector3 anchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_anchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchorPosition_Injected(ref value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000096A0 File Offset: 0x000078A0
		// (set) Token: 0x06000268 RID: 616 RVA: 0x000032C0 File Offset: 0x000014C0
		public Vector3 parentAnchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_parentAnchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_parentAnchorPosition_Injected(ref value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000096B8 File Offset: 0x000078B8
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000032CA File Offset: 0x000014CA
		public Quaternion anchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_anchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_anchorRotation_Injected(ref value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000096D0 File Offset: 0x000078D0
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000032D4 File Offset: 0x000014D4
		public Quaternion parentAnchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_parentAnchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_parentAnchorRotation_Injected(ref value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000032DE File Offset: 0x000014DE
		public bool isRoot
		{
			get
			{
				return ArticulationBody.get_isRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000032F0 File Offset: 0x000014F0
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00003302 File Offset: 0x00001502
		public bool computeParentAnchor
		{
			get
			{
				return ArticulationBody.get_computeParentAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_computeParentAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00003315 File Offset: 0x00001515
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00003327 File Offset: 0x00001527
		public ArticulationDofLock linearLockX
		{
			get
			{
				return ArticulationBody.get_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000333A File Offset: 0x0000153A
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000334C File Offset: 0x0000154C
		public ArticulationDofLock linearLockY
		{
			get
			{
				return ArticulationBody.get_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000335F File Offset: 0x0000155F
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00003371 File Offset: 0x00001571
		public ArticulationDofLock linearLockZ
		{
			get
			{
				return ArticulationBody.get_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003384 File Offset: 0x00001584
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00003396 File Offset: 0x00001596
		public ArticulationDofLock swingYLock
		{
			get
			{
				return ArticulationBody.get_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000033A9 File Offset: 0x000015A9
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000033BB File Offset: 0x000015BB
		public ArticulationDofLock swingZLock
		{
			get
			{
				return ArticulationBody.get_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000033CE File Offset: 0x000015CE
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000033E0 File Offset: 0x000015E0
		public ArticulationDofLock twistLock
		{
			get
			{
				return ArticulationBody.get_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000033F3 File Offset: 0x000015F3
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003405 File Offset: 0x00001605
		public bool immovable
		{
			get
			{
				return ArticulationBody.get_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003418 File Offset: 0x00001618
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000342A File Offset: 0x0000162A
		public bool useGravity
		{
			get
			{
				return ArticulationBody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000343D File Offset: 0x0000163D
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000344F File Offset: 0x0000164F
		public float linearDamping
		{
			get
			{
				return ArticulationBody.get_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00003462 File Offset: 0x00001662
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003474 File Offset: 0x00001674
		public float angularDamping
		{
			get
			{
				return ArticulationBody.get_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00003487 File Offset: 0x00001687
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00003499 File Offset: 0x00001699
		public float jointFriction
		{
			get
			{
				return ArticulationBody.get_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000034AC File Offset: 0x000016AC
		public void AddForce(Vector3 force)
		{
			this.AddForce_Injected(ref force);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000034B6 File Offset: 0x000016B6
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce_Injected(ref force);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000034C0 File Offset: 0x000016C0
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque_Injected(ref torque);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000034CA File Offset: 0x000016CA
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque_Injected(ref torque);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000034D4 File Offset: 0x000016D4
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition_Injected(ref force, ref position);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000096E8 File Offset: 0x000078E8
		// (set) Token: 0x0600028C RID: 652 RVA: 0x000034E0 File Offset: 0x000016E0
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00009700 File Offset: 0x00007900
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000034EA File Offset: 0x000016EA
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_angularVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000034F4 File Offset: 0x000016F4
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00003506 File Offset: 0x00001706
		public float mass
		{
			get
			{
				return ArticulationBody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00009718 File Offset: 0x00007918
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00003519 File Offset: 0x00001719
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00009730 File Offset: 0x00007930
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00009748 File Offset: 0x00007948
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003523 File Offset: 0x00001723
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00009760 File Offset: 0x00007960
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000352D File Offset: 0x0000172D
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003537 File Offset: 0x00001737
		public void ResetCenterOfMass()
		{
			ArticulationBody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003549 File Offset: 0x00001749
		public void ResetInertiaTensor()
		{
			ArticulationBody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000355B File Offset: 0x0000175B
		public void Sleep()
		{
			ArticulationBody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000356D File Offset: 0x0000176D
		public bool IsSleeping()
		{
			return ArticulationBody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000357F File Offset: 0x0000177F
		public void WakeUp()
		{
			ArticulationBody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00003591 File Offset: 0x00001791
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000035A3 File Offset: 0x000017A3
		public float sleepThreshold
		{
			get
			{
				return ArticulationBody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000035B6 File Offset: 0x000017B6
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000035C8 File Offset: 0x000017C8
		public int solverIterations
		{
			get
			{
				return ArticulationBody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000035DB File Offset: 0x000017DB
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000035ED File Offset: 0x000017ED
		public int solverVelocityIterations
		{
			get
			{
				return ArticulationBody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00003600 File Offset: 0x00001800
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003612 File Offset: 0x00001812
		public float maxAngularVelocity
		{
			get
			{
				return ArticulationBody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00003625 File Offset: 0x00001825
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003637 File Offset: 0x00001837
		public float maxLinearVelocity
		{
			get
			{
				return ArticulationBody.get_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000364A File Offset: 0x0000184A
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000365C File Offset: 0x0000185C
		public float maxJointVelocity
		{
			get
			{
				return ArticulationBody.get_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000366F File Offset: 0x0000186F
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00003681 File Offset: 0x00001881
		public float maxDepenetrationVelocity
		{
			get
			{
				return ArticulationBody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00003694 File Offset: 0x00001894
		public int dofCount
		{
			get
			{
				return ArticulationBody.get_dofCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000036A6 File Offset: 0x000018A6
		public int index
		{
			get
			{
				return ArticulationBody.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000036B8 File Offset: 0x000018B8
		public void TeleportRoot(Vector3 position, Quaternion rotation)
		{
			this.TeleportRoot_Injected(ref position, ref rotation);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00009778 File Offset: 0x00007978
		public Vector3 GetClosestPoint(Vector3 point)
		{
			Vector3 vector;
			this.GetClosestPoint_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009790 File Offset: 0x00007990
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000097A8 File Offset: 0x000079A8
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000036C4 File Offset: 0x000018C4
		public int GetJointPositions(List<float> positions)
		{
			return ArticulationBody.GetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000036DC File Offset: 0x000018DC
		public void SetJointPositions(List<float> positions)
		{
			ArticulationBody.SetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000036F4 File Offset: 0x000018F4
		public int GetJointVelocities(List<float> velocities)
		{
			return ArticulationBody.GetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000370C File Offset: 0x0000190C
		public void SetJointVelocities(List<float> velocities)
		{
			ArticulationBody.SetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003724 File Offset: 0x00001924
		public int GetJointAccelerations(List<float> accelerations)
		{
			return ArticulationBody.GetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000373C File Offset: 0x0000193C
		public void SetJointAccelerations(List<float> accelerations)
		{
			ArticulationBody.SetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003754 File Offset: 0x00001954
		public int GetJointForces(List<float> forces)
		{
			return ArticulationBody.GetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000376C File Offset: 0x0000196C
		public void SetJointForces(List<float> forces)
		{
			ArticulationBody.SetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003784 File Offset: 0x00001984
		public int GetDriveTargets(List<float> targets)
		{
			return ArticulationBody.GetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000379C File Offset: 0x0000199C
		public void SetDriveTargets(List<float> targets)
		{
			ArticulationBody.SetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000037B4 File Offset: 0x000019B4
		public int GetDriveTargetVelocities(List<float> targetVelocities)
		{
			return ArticulationBody.GetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000037CC File Offset: 0x000019CC
		public void SetDriveTargetVelocities(List<float> targetVelocities)
		{
			ArticulationBody.SetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000037E4 File Offset: 0x000019E4
		public int GetDofStartIndices(List<int> dofStartIndices)
		{
			return ArticulationBody.GetDofStartIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dofStartIndices));
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000037FC File Offset: 0x000019FC
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000380E File Offset: 0x00001A0E
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return ArticulationBody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000097C0 File Offset: 0x000079C0
		public void SnapAnchorToClosestContact()
		{
			bool flag = !base.transform.parent;
			if (!flag)
			{
				ArticulationBody articulationBody = base.transform.parent.GetComponentInParent<ArticulationBody>();
				while (articulationBody && !articulationBody.enabled)
				{
					articulationBody = articulationBody.transform.parent.GetComponentInParent<ArticulationBody>();
				}
				bool flag2 = !articulationBody;
				if (!flag2)
				{
					Vector3 worldCenterOfMass = articulationBody.worldCenterOfMass;
					Vector3 closestPoint = this.GetClosestPoint(worldCenterOfMass);
					this.anchorPosition = base.transform.InverseTransformPoint(closestPoint);
					this.anchorRotation = Quaternion.FromToRotation(Vector3.right, base.transform.InverseTransformDirection(worldCenterOfMass - closestPoint).normalized);
				}
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003821 File Offset: 0x00001A21
		public void get_anchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003834 File Offset: 0x00001A34
		public void set_anchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003847 File Offset: 0x00001A47
		public void get_parentAnchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000385A File Offset: 0x00001A5A
		public void set_parentAnchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000386D File Offset: 0x00001A6D
		public void get_anchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003880 File Offset: 0x00001A80
		public void set_anchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003893 File Offset: 0x00001A93
		public void get_parentAnchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000038A6 File Offset: 0x00001AA6
		public void set_parentAnchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000038B9 File Offset: 0x00001AB9
		public void AddForce_Injected(ref Vector3 force)
		{
			ArticulationBody.AddForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000038CC File Offset: 0x00001ACC
		public void AddRelativeForce_Injected(ref Vector3 force)
		{
			ArticulationBody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000038DF File Offset: 0x00001ADF
		public void AddTorque_Injected(ref Vector3 torque)
		{
			ArticulationBody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000038F2 File Offset: 0x00001AF2
		public void AddRelativeTorque_Injected(ref Vector3 torque)
		{
			ArticulationBody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003905 File Offset: 0x00001B05
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position)
		{
			ArticulationBody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003919 File Offset: 0x00001B19
		public void get_velocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000392C File Offset: 0x00001B2C
		public void set_velocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000393F File Offset: 0x00001B3F
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003952 File Offset: 0x00001B52
		public void set_angularVelocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003965 File Offset: 0x00001B65
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003978 File Offset: 0x00001B78
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			ArticulationBody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000398B File Offset: 0x00001B8B
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000399E File Offset: 0x00001B9E
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			ArticulationBody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000039B1 File Offset: 0x00001BB1
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			ArticulationBody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000039C4 File Offset: 0x00001BC4
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000039D7 File Offset: 0x00001BD7
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000039EA File Offset: 0x00001BEA
		public void TeleportRoot_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			ArticulationBody.TeleportRoot_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000039FE File Offset: 0x00001BFE
		public void GetClosestPoint_Injected(ref Vector3 point, out Vector3 ret)
		{
			ArticulationBody.GetClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003A12 File Offset: 0x00001C12
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			ArticulationBody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003A26 File Offset: 0x00001C26
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			ArticulationBody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x0400016E RID: 366
		private static readonly ArticulationBody.get_jointTypeDelegate get_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointTypeDelegate>("UnityEngine.ArticulationBody::get_jointType");

		// Token: 0x0400016F RID: 367
		private static readonly ArticulationBody.set_jointTypeDelegate set_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointTypeDelegate>("UnityEngine.ArticulationBody::set_jointType");

		// Token: 0x04000170 RID: 368
		private static readonly ArticulationBody.get_isRootDelegate get_isRootDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_isRootDelegate>("UnityEngine.ArticulationBody::get_isRoot");

		// Token: 0x04000171 RID: 369
		private static readonly ArticulationBody.get_computeParentAnchorDelegate get_computeParentAnchorDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_computeParentAnchorDelegate>("UnityEngine.ArticulationBody::get_computeParentAnchor");

		// Token: 0x04000172 RID: 370
		private static readonly ArticulationBody.set_computeParentAnchorDelegate set_computeParentAnchorDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_computeParentAnchorDelegate>("UnityEngine.ArticulationBody::set_computeParentAnchor");

		// Token: 0x04000173 RID: 371
		private static readonly ArticulationBody.get_linearLockXDelegate get_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockXDelegate>("UnityEngine.ArticulationBody::get_linearLockX");

		// Token: 0x04000174 RID: 372
		private static readonly ArticulationBody.set_linearLockXDelegate set_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockXDelegate>("UnityEngine.ArticulationBody::set_linearLockX");

		// Token: 0x04000175 RID: 373
		private static readonly ArticulationBody.get_linearLockYDelegate get_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockYDelegate>("UnityEngine.ArticulationBody::get_linearLockY");

		// Token: 0x04000176 RID: 374
		private static readonly ArticulationBody.set_linearLockYDelegate set_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockYDelegate>("UnityEngine.ArticulationBody::set_linearLockY");

		// Token: 0x04000177 RID: 375
		private static readonly ArticulationBody.get_linearLockZDelegate get_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockZDelegate>("UnityEngine.ArticulationBody::get_linearLockZ");

		// Token: 0x04000178 RID: 376
		private static readonly ArticulationBody.set_linearLockZDelegate set_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockZDelegate>("UnityEngine.ArticulationBody::set_linearLockZ");

		// Token: 0x04000179 RID: 377
		private static readonly ArticulationBody.get_swingYLockDelegate get_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingYLockDelegate>("UnityEngine.ArticulationBody::get_swingYLock");

		// Token: 0x0400017A RID: 378
		private static readonly ArticulationBody.set_swingYLockDelegate set_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingYLockDelegate>("UnityEngine.ArticulationBody::set_swingYLock");

		// Token: 0x0400017B RID: 379
		private static readonly ArticulationBody.get_swingZLockDelegate get_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingZLockDelegate>("UnityEngine.ArticulationBody::get_swingZLock");

		// Token: 0x0400017C RID: 380
		private static readonly ArticulationBody.set_swingZLockDelegate set_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingZLockDelegate>("UnityEngine.ArticulationBody::set_swingZLock");

		// Token: 0x0400017D RID: 381
		private static readonly ArticulationBody.get_twistLockDelegate get_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_twistLockDelegate>("UnityEngine.ArticulationBody::get_twistLock");

		// Token: 0x0400017E RID: 382
		private static readonly ArticulationBody.set_twistLockDelegate set_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_twistLockDelegate>("UnityEngine.ArticulationBody::set_twistLock");

		// Token: 0x0400017F RID: 383
		private static readonly ArticulationBody.get_immovableDelegate get_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_immovableDelegate>("UnityEngine.ArticulationBody::get_immovable");

		// Token: 0x04000180 RID: 384
		private static readonly ArticulationBody.set_immovableDelegate set_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_immovableDelegate>("UnityEngine.ArticulationBody::set_immovable");

		// Token: 0x04000181 RID: 385
		private static readonly ArticulationBody.get_useGravityDelegate get_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_useGravityDelegate>("UnityEngine.ArticulationBody::get_useGravity");

		// Token: 0x04000182 RID: 386
		private static readonly ArticulationBody.set_useGravityDelegate set_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_useGravityDelegate>("UnityEngine.ArticulationBody::set_useGravity");

		// Token: 0x04000183 RID: 387
		private static readonly ArticulationBody.get_linearDampingDelegate get_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearDampingDelegate>("UnityEngine.ArticulationBody::get_linearDamping");

		// Token: 0x04000184 RID: 388
		private static readonly ArticulationBody.set_linearDampingDelegate set_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearDampingDelegate>("UnityEngine.ArticulationBody::set_linearDamping");

		// Token: 0x04000185 RID: 389
		private static readonly ArticulationBody.get_angularDampingDelegate get_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularDampingDelegate>("UnityEngine.ArticulationBody::get_angularDamping");

		// Token: 0x04000186 RID: 390
		private static readonly ArticulationBody.set_angularDampingDelegate set_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularDampingDelegate>("UnityEngine.ArticulationBody::set_angularDamping");

		// Token: 0x04000187 RID: 391
		private static readonly ArticulationBody.get_jointFrictionDelegate get_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointFrictionDelegate>("UnityEngine.ArticulationBody::get_jointFriction");

		// Token: 0x04000188 RID: 392
		private static readonly ArticulationBody.set_jointFrictionDelegate set_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointFrictionDelegate>("UnityEngine.ArticulationBody::set_jointFriction");

		// Token: 0x04000189 RID: 393
		private static readonly ArticulationBody.get_massDelegate get_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_massDelegate>("UnityEngine.ArticulationBody::get_mass");

		// Token: 0x0400018A RID: 394
		private static readonly ArticulationBody.set_massDelegate set_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_massDelegate>("UnityEngine.ArticulationBody::set_mass");

		// Token: 0x0400018B RID: 395
		private static readonly ArticulationBody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetCenterOfMassDelegate>("UnityEngine.ArticulationBody::ResetCenterOfMass");

		// Token: 0x0400018C RID: 396
		private static readonly ArticulationBody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetInertiaTensorDelegate>("UnityEngine.ArticulationBody::ResetInertiaTensor");

		// Token: 0x0400018D RID: 397
		private static readonly ArticulationBody.SleepDelegate SleepDelegateField = IL2CPP.ResolveICall<ArticulationBody.SleepDelegate>("UnityEngine.ArticulationBody::Sleep");

		// Token: 0x0400018E RID: 398
		private static readonly ArticulationBody.IsSleepingDelegate IsSleepingDelegateField = IL2CPP.ResolveICall<ArticulationBody.IsSleepingDelegate>("UnityEngine.ArticulationBody::IsSleeping");

		// Token: 0x0400018F RID: 399
		private static readonly ArticulationBody.WakeUpDelegate WakeUpDelegateField = IL2CPP.ResolveICall<ArticulationBody.WakeUpDelegate>("UnityEngine.ArticulationBody::WakeUp");

		// Token: 0x04000190 RID: 400
		private static readonly ArticulationBody.get_sleepThresholdDelegate get_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_sleepThresholdDelegate>("UnityEngine.ArticulationBody::get_sleepThreshold");

		// Token: 0x04000191 RID: 401
		private static readonly ArticulationBody.set_sleepThresholdDelegate set_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_sleepThresholdDelegate>("UnityEngine.ArticulationBody::set_sleepThreshold");

		// Token: 0x04000192 RID: 402
		private static readonly ArticulationBody.get_solverIterationsDelegate get_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverIterationsDelegate>("UnityEngine.ArticulationBody::get_solverIterations");

		// Token: 0x04000193 RID: 403
		private static readonly ArticulationBody.set_solverIterationsDelegate set_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverIterationsDelegate>("UnityEngine.ArticulationBody::set_solverIterations");

		// Token: 0x04000194 RID: 404
		private static readonly ArticulationBody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::get_solverVelocityIterations");

		// Token: 0x04000195 RID: 405
		private static readonly ArticulationBody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::set_solverVelocityIterations");

		// Token: 0x04000196 RID: 406
		private static readonly ArticulationBody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::get_maxAngularVelocity");

		// Token: 0x04000197 RID: 407
		private static readonly ArticulationBody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::set_maxAngularVelocity");

		// Token: 0x04000198 RID: 408
		private static readonly ArticulationBody.get_maxLinearVelocityDelegate get_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::get_maxLinearVelocity");

		// Token: 0x04000199 RID: 409
		private static readonly ArticulationBody.set_maxLinearVelocityDelegate set_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::set_maxLinearVelocity");

		// Token: 0x0400019A RID: 410
		private static readonly ArticulationBody.get_maxJointVelocityDelegate get_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::get_maxJointVelocity");

		// Token: 0x0400019B RID: 411
		private static readonly ArticulationBody.set_maxJointVelocityDelegate set_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::set_maxJointVelocity");

		// Token: 0x0400019C RID: 412
		private static readonly ArticulationBody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::get_maxDepenetrationVelocity");

		// Token: 0x0400019D RID: 413
		private static readonly ArticulationBody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::set_maxDepenetrationVelocity");

		// Token: 0x0400019E RID: 414
		private static readonly ArticulationBody.get_dofCountDelegate get_dofCountDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_dofCountDelegate>("UnityEngine.ArticulationBody::get_dofCount");

		// Token: 0x0400019F RID: 415
		private static readonly ArticulationBody.get_indexDelegate get_indexDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_indexDelegate>("UnityEngine.ArticulationBody::get_index");

		// Token: 0x040001A0 RID: 416
		private static readonly ArticulationBody.GetJointPositionsDelegate GetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointPositionsDelegate>("UnityEngine.ArticulationBody::GetJointPositions");

		// Token: 0x040001A1 RID: 417
		private static readonly ArticulationBody.SetJointPositionsDelegate SetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointPositionsDelegate>("UnityEngine.ArticulationBody::SetJointPositions");

		// Token: 0x040001A2 RID: 418
		private static readonly ArticulationBody.GetJointVelocitiesDelegate GetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::GetJointVelocities");

		// Token: 0x040001A3 RID: 419
		private static readonly ArticulationBody.SetJointVelocitiesDelegate SetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::SetJointVelocities");

		// Token: 0x040001A4 RID: 420
		private static readonly ArticulationBody.GetJointAccelerationsDelegate GetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::GetJointAccelerations");

		// Token: 0x040001A5 RID: 421
		private static readonly ArticulationBody.SetJointAccelerationsDelegate SetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::SetJointAccelerations");

		// Token: 0x040001A6 RID: 422
		private static readonly ArticulationBody.GetJointForcesDelegate GetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointForcesDelegate>("UnityEngine.ArticulationBody::GetJointForces");

		// Token: 0x040001A7 RID: 423
		private static readonly ArticulationBody.SetJointForcesDelegate SetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointForcesDelegate>("UnityEngine.ArticulationBody::SetJointForces");

		// Token: 0x040001A8 RID: 424
		private static readonly ArticulationBody.GetDriveTargetsDelegate GetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetsDelegate>("UnityEngine.ArticulationBody::GetDriveTargets");

		// Token: 0x040001A9 RID: 425
		private static readonly ArticulationBody.SetDriveTargetsDelegate SetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetsDelegate>("UnityEngine.ArticulationBody::SetDriveTargets");

		// Token: 0x040001AA RID: 426
		private static readonly ArticulationBody.GetDriveTargetVelocitiesDelegate GetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::GetDriveTargetVelocities");

		// Token: 0x040001AB RID: 427
		private static readonly ArticulationBody.SetDriveTargetVelocitiesDelegate SetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocities");

		// Token: 0x040001AC RID: 428
		private static readonly ArticulationBody.GetDofStartIndicesDelegate GetDofStartIndicesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDofStartIndicesDelegate>("UnityEngine.ArticulationBody::GetDofStartIndices");

		// Token: 0x040001AD RID: 429
		private static readonly ArticulationBody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::get_collisionDetectionMode");

		// Token: 0x040001AE RID: 430
		private static readonly ArticulationBody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::set_collisionDetectionMode");

		// Token: 0x040001AF RID: 431
		private static readonly ArticulationBody.get_anchorPosition_InjectedDelegate get_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorPosition_Injected");

		// Token: 0x040001B0 RID: 432
		private static readonly ArticulationBody.set_anchorPosition_InjectedDelegate set_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorPosition_Injected");

		// Token: 0x040001B1 RID: 433
		private static readonly ArticulationBody.get_parentAnchorPosition_InjectedDelegate get_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorPosition_Injected");

		// Token: 0x040001B2 RID: 434
		private static readonly ArticulationBody.set_parentAnchorPosition_InjectedDelegate set_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorPosition_Injected");

		// Token: 0x040001B3 RID: 435
		private static readonly ArticulationBody.get_anchorRotation_InjectedDelegate get_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorRotation_Injected");

		// Token: 0x040001B4 RID: 436
		private static readonly ArticulationBody.set_anchorRotation_InjectedDelegate set_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorRotation_Injected");

		// Token: 0x040001B5 RID: 437
		private static readonly ArticulationBody.get_parentAnchorRotation_InjectedDelegate get_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorRotation_Injected");

		// Token: 0x040001B6 RID: 438
		private static readonly ArticulationBody.set_parentAnchorRotation_InjectedDelegate set_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorRotation_Injected");

		// Token: 0x040001B7 RID: 439
		private static readonly ArticulationBody.AddForce_InjectedDelegate AddForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddForce_Injected");

		// Token: 0x040001B8 RID: 440
		private static readonly ArticulationBody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeForce_Injected");

		// Token: 0x040001B9 RID: 441
		private static readonly ArticulationBody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddTorque_Injected");

		// Token: 0x040001BA RID: 442
		private static readonly ArticulationBody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeTorque_Injected");

		// Token: 0x040001BB RID: 443
		private static readonly ArticulationBody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForceAtPosition_InjectedDelegate>("UnityEngine.ArticulationBody::AddForceAtPosition_Injected");

		// Token: 0x040001BC RID: 444
		private static readonly ArticulationBody.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_velocity_Injected");

		// Token: 0x040001BD RID: 445
		private static readonly ArticulationBody.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_velocity_Injected");

		// Token: 0x040001BE RID: 446
		private static readonly ArticulationBody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_angularVelocity_Injected");

		// Token: 0x040001BF RID: 447
		private static readonly ArticulationBody.set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_angularVelocity_Injected");

		// Token: 0x040001C0 RID: 448
		private static readonly ArticulationBody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_centerOfMass_Injected");

		// Token: 0x040001C1 RID: 449
		private static readonly ArticulationBody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::set_centerOfMass_Injected");

		// Token: 0x040001C2 RID: 450
		private static readonly ArticulationBody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_worldCenterOfMass_Injected");

		// Token: 0x040001C3 RID: 451
		private static readonly ArticulationBody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensor_Injected");

		// Token: 0x040001C4 RID: 452
		private static readonly ArticulationBody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensor_Injected");

		// Token: 0x040001C5 RID: 453
		private static readonly ArticulationBody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensorRotation_Injected");

		// Token: 0x040001C6 RID: 454
		private static readonly ArticulationBody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensorRotation_Injected");

		// Token: 0x040001C7 RID: 455
		private static readonly ArticulationBody.TeleportRoot_InjectedDelegate TeleportRoot_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.TeleportRoot_InjectedDelegate>("UnityEngine.ArticulationBody::TeleportRoot_Injected");

		// Token: 0x040001C8 RID: 456
		private static readonly ArticulationBody.GetClosestPoint_InjectedDelegate GetClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetClosestPoint_InjectedDelegate>("UnityEngine.ArticulationBody::GetClosestPoint_Injected");

		// Token: 0x040001C9 RID: 457
		private static readonly ArticulationBody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetRelativePointVelocity_Injected");

		// Token: 0x040001CA RID: 458
		private static readonly ArticulationBody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetPointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetPointVelocity_Injected");

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060004F1 RID: 1265
		private delegate ArticulationJointType get_jointTypeDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060004F3 RID: 1267
		private delegate void set_jointTypeDelegate(IntPtr @this, ArticulationJointType value);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060004F5 RID: 1269
		private delegate bool get_isRootDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060004F7 RID: 1271
		private delegate bool get_computeParentAnchorDelegate(IntPtr @this);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060004F9 RID: 1273
		private delegate void set_computeParentAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060004FB RID: 1275
		private delegate ArticulationDofLock get_linearLockXDelegate(IntPtr @this);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060004FD RID: 1277
		private delegate void set_linearLockXDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060004FF RID: 1279
		private delegate ArticulationDofLock get_linearLockYDelegate(IntPtr @this);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x06000501 RID: 1281
		private delegate void set_linearLockYDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x06000503 RID: 1283
		private delegate ArticulationDofLock get_linearLockZDelegate(IntPtr @this);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x06000505 RID: 1285
		private delegate void set_linearLockZDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x06000507 RID: 1287
		private delegate ArticulationDofLock get_swingYLockDelegate(IntPtr @this);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000509 RID: 1289
		private delegate void set_swingYLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x0600050B RID: 1291
		private delegate ArticulationDofLock get_swingZLockDelegate(IntPtr @this);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x0600050D RID: 1293
		private delegate void set_swingZLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x0600050F RID: 1295
		private delegate ArticulationDofLock get_twistLockDelegate(IntPtr @this);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000511 RID: 1297
		private delegate void set_twistLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000513 RID: 1299
		private delegate bool get_immovableDelegate(IntPtr @this);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000515 RID: 1301
		private delegate void set_immovableDelegate(IntPtr @this, bool value);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000517 RID: 1303
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000519 RID: 1305
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x0600051B RID: 1307
		private delegate float get_linearDampingDelegate(IntPtr @this);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x0600051D RID: 1309
		private delegate void set_linearDampingDelegate(IntPtr @this, float value);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x0600051F RID: 1311
		private delegate float get_angularDampingDelegate(IntPtr @this);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000521 RID: 1313
		private delegate void set_angularDampingDelegate(IntPtr @this, float value);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000523 RID: 1315
		private delegate float get_jointFrictionDelegate(IntPtr @this);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x06000525 RID: 1317
		private delegate void set_jointFrictionDelegate(IntPtr @this, float value);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000527 RID: 1319
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000529 RID: 1321
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x0600052B RID: 1323
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x0600052D RID: 1325
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x0600052F RID: 1327
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x06000531 RID: 1329
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x06000533 RID: 1331
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x06000535 RID: 1333
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x06000537 RID: 1335
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x06000539 RID: 1337
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x0600053B RID: 1339
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x0600053D RID: 1341
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x0600053F RID: 1343
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x06000541 RID: 1345
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x06000543 RID: 1347
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x06000545 RID: 1349
		private delegate float get_maxLinearVelocityDelegate(IntPtr @this);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x06000547 RID: 1351
		private delegate void set_maxLinearVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000549 RID: 1353
		private delegate float get_maxJointVelocityDelegate(IntPtr @this);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x0600054B RID: 1355
		private delegate void set_maxJointVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x0600054D RID: 1357
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x0600054F RID: 1359
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000551 RID: 1361
		private delegate int get_dofCountDelegate(IntPtr @this);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x06000553 RID: 1363
		private delegate int get_indexDelegate(IntPtr @this);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x06000555 RID: 1365
		private delegate int GetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x06000557 RID: 1367
		private delegate void SetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000559 RID: 1369
		private delegate int GetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x0600055B RID: 1371
		private delegate void SetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x0600055D RID: 1373
		private delegate int GetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x0600055F RID: 1375
		private delegate void SetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000561 RID: 1377
		private delegate int GetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x06000563 RID: 1379
		private delegate void SetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x06000565 RID: 1381
		private delegate int GetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x06000567 RID: 1383
		private delegate void SetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000569 RID: 1385
		private delegate int GetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x0600056B RID: 1387
		private delegate void SetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x0600056D RID: 1389
		private delegate int GetDofStartIndicesDelegate(IntPtr @this, IntPtr dofStartIndices);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x0600056F RID: 1391
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000571 RID: 1393
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x06000573 RID: 1395
		private delegate void get_anchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x06000575 RID: 1397
		private delegate void set_anchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000577 RID: 1399
		private delegate void get_parentAnchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000579 RID: 1401
		private delegate void set_parentAnchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x0600057B RID: 1403
		private delegate void get_anchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x0600057D RID: 1405
		private delegate void set_anchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x0600057F RID: 1407
		private delegate void get_parentAnchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000581 RID: 1409
		private delegate void set_parentAnchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000583 RID: 1411
		private delegate void AddForce_InjectedDelegate(IntPtr @this, IntPtr force);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000585 RID: 1413
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000587 RID: 1415
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x06000589 RID: 1417
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600058B RID: 1419
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x0600058D RID: 1421
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x0600058F RID: 1423
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000591 RID: 1425
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000593 RID: 1427
		private delegate void set_angularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000595 RID: 1429
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000597 RID: 1431
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000599 RID: 1433
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600059B RID: 1435
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600059D RID: 1437
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x0600059F RID: 1439
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x060005A1 RID: 1441
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x060005A3 RID: 1443
		private delegate void TeleportRoot_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x060005A5 RID: 1445
		private delegate void GetClosestPoint_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x060005A7 RID: 1447
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x060005A9 RID: 1449
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);
	}
}
