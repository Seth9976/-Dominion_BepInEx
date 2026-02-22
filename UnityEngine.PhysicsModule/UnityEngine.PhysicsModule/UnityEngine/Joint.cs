using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public class Joint : Component
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00009C24 File Offset: 0x00007E24
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00003BE2 File Offset: 0x00001DE2
		public Rigidbody connectedBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00009C50 File Offset: 0x00007E50
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003BFA File Offset: 0x00001DFA
		public ArticulationBody connectedArticulationBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00009C7C File Offset: 0x00007E7C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003C12 File Offset: 0x00001E12
		public Vector3 axis
		{
			get
			{
				Vector3 vector;
				this.get_axis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_axis_Injected(ref value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00009C94 File Offset: 0x00007E94
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00003C1C File Offset: 0x00001E1C
		public Vector3 anchor
		{
			get
			{
				Vector3 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00009CAC File Offset: 0x00007EAC
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003C26 File Offset: 0x00001E26
		public Vector3 connectedAnchor
		{
			get
			{
				Vector3 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_connectedAnchor_Injected(ref value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003C42 File Offset: 0x00001E42
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return Joint.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00003C55 File Offset: 0x00001E55
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003C67 File Offset: 0x00001E67
		public float breakForce
		{
			get
			{
				return Joint.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00003C7A File Offset: 0x00001E7A
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003C8C File Offset: 0x00001E8C
		public float breakTorque
		{
			get
			{
				return Joint.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003C9F File Offset: 0x00001E9F
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public bool enableCollision
		{
			get
			{
				return Joint.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003CC4 File Offset: 0x00001EC4
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public bool enablePreprocessing
		{
			get
			{
				return Joint.get_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00003CE9 File Offset: 0x00001EE9
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003CFB File Offset: 0x00001EFB
		public float massScale
		{
			get
			{
				return Joint.get_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00003D0E File Offset: 0x00001F0E
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003D20 File Offset: 0x00001F20
		public float connectedMassScale
		{
			get
			{
				return Joint.get_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003D33 File Offset: 0x00001F33
		public void GetCurrentForces(ref Vector3 linearForce, ref Vector3 angularForce)
		{
			Joint.GetCurrentForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref linearForce, ref angularForce);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public Vector3 currentForce
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public Vector3 currentTorque
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero2;
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003D47 File Offset: 0x00001F47
		public void get_axis_Injected(out Vector3 ret)
		{
			Joint.get_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003D5A File Offset: 0x00001F5A
		public void set_axis_Injected(ref Vector3 value)
		{
			Joint.set_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003D6D File Offset: 0x00001F6D
		public void get_anchor_Injected(out Vector3 ret)
		{
			Joint.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003D80 File Offset: 0x00001F80
		public void set_anchor_Injected(ref Vector3 value)
		{
			Joint.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003D93 File Offset: 0x00001F93
		public void get_connectedAnchor_Injected(out Vector3 ret)
		{
			Joint.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003DA6 File Offset: 0x00001FA6
		public void set_connectedAnchor_Injected(ref Vector3 value)
		{
			Joint.set_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001DE RID: 478
		private static readonly Joint.get_connectedBodyDelegate get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedBodyDelegate>("UnityEngine.Joint::get_connectedBody");

		// Token: 0x040001DF RID: 479
		private static readonly Joint.set_connectedBodyDelegate set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedBodyDelegate>("UnityEngine.Joint::set_connectedBody");

		// Token: 0x040001E0 RID: 480
		private static readonly Joint.get_connectedArticulationBodyDelegate get_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedArticulationBodyDelegate>("UnityEngine.Joint::get_connectedArticulationBody");

		// Token: 0x040001E1 RID: 481
		private static readonly Joint.set_connectedArticulationBodyDelegate set_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedArticulationBodyDelegate>("UnityEngine.Joint::set_connectedArticulationBody");

		// Token: 0x040001E2 RID: 482
		private static readonly Joint.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::get_autoConfigureConnectedAnchor");

		// Token: 0x040001E3 RID: 483
		private static readonly Joint.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::set_autoConfigureConnectedAnchor");

		// Token: 0x040001E4 RID: 484
		private static readonly Joint.get_breakForceDelegate get_breakForceDelegateField = IL2CPP.ResolveICall<Joint.get_breakForceDelegate>("UnityEngine.Joint::get_breakForce");

		// Token: 0x040001E5 RID: 485
		private static readonly Joint.set_breakForceDelegate set_breakForceDelegateField = IL2CPP.ResolveICall<Joint.set_breakForceDelegate>("UnityEngine.Joint::set_breakForce");

		// Token: 0x040001E6 RID: 486
		private static readonly Joint.get_breakTorqueDelegate get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.get_breakTorqueDelegate>("UnityEngine.Joint::get_breakTorque");

		// Token: 0x040001E7 RID: 487
		private static readonly Joint.set_breakTorqueDelegate set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.set_breakTorqueDelegate>("UnityEngine.Joint::set_breakTorque");

		// Token: 0x040001E8 RID: 488
		private static readonly Joint.get_enableCollisionDelegate get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.get_enableCollisionDelegate>("UnityEngine.Joint::get_enableCollision");

		// Token: 0x040001E9 RID: 489
		private static readonly Joint.set_enableCollisionDelegate set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.set_enableCollisionDelegate>("UnityEngine.Joint::set_enableCollision");

		// Token: 0x040001EA RID: 490
		private static readonly Joint.get_enablePreprocessingDelegate get_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.get_enablePreprocessingDelegate>("UnityEngine.Joint::get_enablePreprocessing");

		// Token: 0x040001EB RID: 491
		private static readonly Joint.set_enablePreprocessingDelegate set_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.set_enablePreprocessingDelegate>("UnityEngine.Joint::set_enablePreprocessing");

		// Token: 0x040001EC RID: 492
		private static readonly Joint.get_massScaleDelegate get_massScaleDelegateField = IL2CPP.ResolveICall<Joint.get_massScaleDelegate>("UnityEngine.Joint::get_massScale");

		// Token: 0x040001ED RID: 493
		private static readonly Joint.set_massScaleDelegate set_massScaleDelegateField = IL2CPP.ResolveICall<Joint.set_massScaleDelegate>("UnityEngine.Joint::set_massScale");

		// Token: 0x040001EE RID: 494
		private static readonly Joint.get_connectedMassScaleDelegate get_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.get_connectedMassScaleDelegate>("UnityEngine.Joint::get_connectedMassScale");

		// Token: 0x040001EF RID: 495
		private static readonly Joint.set_connectedMassScaleDelegate set_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.set_connectedMassScaleDelegate>("UnityEngine.Joint::set_connectedMassScale");

		// Token: 0x040001F0 RID: 496
		private static readonly Joint.GetCurrentForcesDelegate GetCurrentForcesDelegateField = IL2CPP.ResolveICall<Joint.GetCurrentForcesDelegate>("UnityEngine.Joint::GetCurrentForces");

		// Token: 0x040001F1 RID: 497
		private static readonly Joint.get_axis_InjectedDelegate get_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_axis_InjectedDelegate>("UnityEngine.Joint::get_axis_Injected");

		// Token: 0x040001F2 RID: 498
		private static readonly Joint.set_axis_InjectedDelegate set_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_axis_InjectedDelegate>("UnityEngine.Joint::set_axis_Injected");

		// Token: 0x040001F3 RID: 499
		private static readonly Joint.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_anchor_InjectedDelegate>("UnityEngine.Joint::get_anchor_Injected");

		// Token: 0x040001F4 RID: 500
		private static readonly Joint.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_anchor_InjectedDelegate>("UnityEngine.Joint::set_anchor_Injected");

		// Token: 0x040001F5 RID: 501
		private static readonly Joint.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::get_connectedAnchor_Injected");

		// Token: 0x040001F6 RID: 502
		private static readonly Joint.set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::set_connectedAnchor_Injected");

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x060005D1 RID: 1489
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x060005D3 RID: 1491
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x060005D5 RID: 1493
		private delegate IntPtr get_connectedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x060005D7 RID: 1495
		private delegate void set_connectedArticulationBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x060005D9 RID: 1497
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x060005DB RID: 1499
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x060005DD RID: 1501
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x060005DF RID: 1503
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x060005E1 RID: 1505
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x060005E3 RID: 1507
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x060005E5 RID: 1509
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x060005E7 RID: 1511
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x060005E9 RID: 1513
		private delegate bool get_enablePreprocessingDelegate(IntPtr @this);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x060005EB RID: 1515
		private delegate void set_enablePreprocessingDelegate(IntPtr @this, bool value);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060005ED RID: 1517
		private delegate float get_massScaleDelegate(IntPtr @this);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060005EF RID: 1519
		private delegate void set_massScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060005F1 RID: 1521
		private delegate float get_connectedMassScaleDelegate(IntPtr @this);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060005F3 RID: 1523
		private delegate void set_connectedMassScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060005F5 RID: 1525
		private delegate void GetCurrentForcesDelegate(IntPtr @this, IntPtr linearForce, IntPtr angularForce);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060005F7 RID: 1527
		private delegate void get_axis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060005F9 RID: 1529
		private delegate void set_axis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060005FB RID: 1531
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060005FD RID: 1533
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060005FF RID: 1535
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06000601 RID: 1537
		private delegate void set_connectedAnchor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
