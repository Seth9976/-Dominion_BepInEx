using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public class ConstantForce : Behaviour
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00009A40 File Offset: 0x00007C40
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00003B22 File Offset: 0x00001D22
		public Vector3 force
		{
			get
			{
				Vector3 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00009A58 File Offset: 0x00007C58
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00003B2C File Offset: 0x00001D2C
		public Vector3 relativeForce
		{
			get
			{
				Vector3 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00009A70 File Offset: 0x00007C70
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003B36 File Offset: 0x00001D36
		public Vector3 torque
		{
			get
			{
				Vector3 vector;
				this.get_torque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_torque_Injected(ref value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00009A88 File Offset: 0x00007C88
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003B40 File Offset: 0x00001D40
		public Vector3 relativeTorque
		{
			get
			{
				Vector3 vector;
				this.get_relativeTorque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeTorque_Injected(ref value);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003B4A File Offset: 0x00001D4A
		public void get_force_Injected(out Vector3 ret)
		{
			ConstantForce.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003B5D File Offset: 0x00001D5D
		public void set_force_Injected(ref Vector3 value)
		{
			ConstantForce.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003B70 File Offset: 0x00001D70
		public void get_relativeForce_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003B83 File Offset: 0x00001D83
		public void set_relativeForce_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003B96 File Offset: 0x00001D96
		public void get_torque_Injected(out Vector3 ret)
		{
			ConstantForce.get_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003BA9 File Offset: 0x00001DA9
		public void set_torque_Injected(ref Vector3 value)
		{
			ConstantForce.set_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003BBC File Offset: 0x00001DBC
		public void get_relativeTorque_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003BCF File Offset: 0x00001DCF
		public void set_relativeTorque_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001D6 RID: 470
		private static readonly ConstantForce.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_force_InjectedDelegate>("UnityEngine.ConstantForce::get_force_Injected");

		// Token: 0x040001D7 RID: 471
		private static readonly ConstantForce.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_force_InjectedDelegate>("UnityEngine.ConstantForce::set_force_Injected");

		// Token: 0x040001D8 RID: 472
		private static readonly ConstantForce.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeForce_Injected");

		// Token: 0x040001D9 RID: 473
		private static readonly ConstantForce.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeForce_Injected");

		// Token: 0x040001DA RID: 474
		private static readonly ConstantForce.get_torque_InjectedDelegate get_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_torque_InjectedDelegate>("UnityEngine.ConstantForce::get_torque_Injected");

		// Token: 0x040001DB RID: 475
		private static readonly ConstantForce.set_torque_InjectedDelegate set_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_torque_InjectedDelegate>("UnityEngine.ConstantForce::set_torque_Injected");

		// Token: 0x040001DC RID: 476
		private static readonly ConstantForce.get_relativeTorque_InjectedDelegate get_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeTorque_Injected");

		// Token: 0x040001DD RID: 477
		private static readonly ConstantForce.set_relativeTorque_InjectedDelegate set_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeTorque_Injected");

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x060005C1 RID: 1473
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x060005C3 RID: 1475
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x060005C5 RID: 1477
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x060005C7 RID: 1479
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x060005C9 RID: 1481
		private delegate void get_torque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x060005CB RID: 1483
		private delegate void set_torque_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x060005CD RID: 1485
		private delegate void get_relativeTorque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x060005CF RID: 1487
		private delegate void set_relativeTorque_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
