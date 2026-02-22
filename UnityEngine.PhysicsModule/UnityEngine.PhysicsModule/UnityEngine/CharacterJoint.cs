using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public class CharacterJoint : Joint
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00009ED0 File Offset: 0x000080D0
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003F05 File Offset: 0x00002105
		public Vector3 swingAxis
		{
			get
			{
				Vector3 vector;
				this.get_swingAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_swingAxis_Injected(ref value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00003F0F File Offset: 0x0000210F
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003F21 File Offset: 0x00002121
		public bool enableProjection
		{
			get
			{
				return CharacterJoint.get_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00003F34 File Offset: 0x00002134
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003F46 File Offset: 0x00002146
		public float projectionDistance
		{
			get
			{
				return CharacterJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00003F59 File Offset: 0x00002159
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00003F6B File Offset: 0x0000216B
		public float projectionAngle
		{
			get
			{
				return CharacterJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003F7E File Offset: 0x0000217E
		public void get_swingAxis_Injected(out Vector3 ret)
		{
			CharacterJoint.get_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003F91 File Offset: 0x00002191
		public void set_swingAxis_Injected(ref Vector3 value)
		{
			CharacterJoint.set_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000209 RID: 521
		private static readonly CharacterJoint.get_enableProjectionDelegate get_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_enableProjectionDelegate>("UnityEngine.CharacterJoint::get_enableProjection");

		// Token: 0x0400020A RID: 522
		private static readonly CharacterJoint.set_enableProjectionDelegate set_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_enableProjectionDelegate>("UnityEngine.CharacterJoint::set_enableProjection");

		// Token: 0x0400020B RID: 523
		private static readonly CharacterJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionDistanceDelegate>("UnityEngine.CharacterJoint::get_projectionDistance");

		// Token: 0x0400020C RID: 524
		private static readonly CharacterJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionDistanceDelegate>("UnityEngine.CharacterJoint::set_projectionDistance");

		// Token: 0x0400020D RID: 525
		private static readonly CharacterJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionAngleDelegate>("UnityEngine.CharacterJoint::get_projectionAngle");

		// Token: 0x0400020E RID: 526
		private static readonly CharacterJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionAngleDelegate>("UnityEngine.CharacterJoint::set_projectionAngle");

		// Token: 0x0400020F RID: 527
		private static readonly CharacterJoint.get_swingAxis_InjectedDelegate get_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::get_swingAxis_Injected");

		// Token: 0x04000210 RID: 528
		private static readonly CharacterJoint.set_swingAxis_InjectedDelegate set_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::set_swingAxis_Injected");

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x06000627 RID: 1575
		private delegate bool get_enableProjectionDelegate(IntPtr @this);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x06000629 RID: 1577
		private delegate void set_enableProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x0600062B RID: 1579
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x0600062D RID: 1581
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x0600062F RID: 1583
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x06000631 RID: 1585
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x06000633 RID: 1587
		private delegate void get_swingAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x06000635 RID: 1589
		private delegate void set_swingAxis_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
