using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002F RID: 47
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000C27C File Offset: 0x0000A47C
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000477B File Offset: 0x0000297B
		public Vector2 force
		{
			get
			{
				Vector2 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000C294 File Offset: 0x0000A494
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00004785 File Offset: 0x00002985
		public Vector2 relativeForce
		{
			get
			{
				Vector2 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000478F File Offset: 0x0000298F
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000047A1 File Offset: 0x000029A1
		public float torque
		{
			get
			{
				return ConstantForce2D.get_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConstantForce2D.set_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000047B4 File Offset: 0x000029B4
		public void get_force_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000047C7 File Offset: 0x000029C7
		public void set_force_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000047DA File Offset: 0x000029DA
		public void get_relativeForce_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000047ED File Offset: 0x000029ED
		public void set_relativeForce_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000273 RID: 627
		private static readonly ConstantForce2D.get_torqueDelegate get_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_torqueDelegate>("UnityEngine.ConstantForce2D::get_torque");

		// Token: 0x04000274 RID: 628
		private static readonly ConstantForce2D.set_torqueDelegate set_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_torqueDelegate>("UnityEngine.ConstantForce2D::set_torque");

		// Token: 0x04000275 RID: 629
		private static readonly ConstantForce2D.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_force_InjectedDelegate>("UnityEngine.ConstantForce2D::get_force_Injected");

		// Token: 0x04000276 RID: 630
		private static readonly ConstantForce2D.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_force_InjectedDelegate>("UnityEngine.ConstantForce2D::set_force_Injected");

		// Token: 0x04000277 RID: 631
		private static readonly ConstantForce2D.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::get_relativeForce_Injected");

		// Token: 0x04000278 RID: 632
		private static readonly ConstantForce2D.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::set_relativeForce_Injected");

		// Token: 0x02000200 RID: 512
		// (Invoke) Token: 0x060007CA RID: 1994
		private delegate float get_torqueDelegate(IntPtr @this);

		// Token: 0x02000201 RID: 513
		// (Invoke) Token: 0x060007CC RID: 1996
		private delegate void set_torqueDelegate(IntPtr @this, float value);

		// Token: 0x02000202 RID: 514
		// (Invoke) Token: 0x060007CE RID: 1998
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000203 RID: 515
		// (Invoke) Token: 0x060007D0 RID: 2000
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x060007D2 RID: 2002
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x060007D4 RID: 2004
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
