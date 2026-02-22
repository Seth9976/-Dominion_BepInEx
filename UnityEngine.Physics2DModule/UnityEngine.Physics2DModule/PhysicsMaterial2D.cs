using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000030 RID: 48
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00004800 File Offset: 0x00002A00
		public static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name)
		{
			PhysicsMaterial2D.Create_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(scriptMaterial), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000482A File Offset: 0x00002A2A
		public float bounciness
		{
			get
			{
				return PhysicsMaterial2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000483D File Offset: 0x00002A3D
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000484F File Offset: 0x00002A4F
		public float friction
		{
			get
			{
				return PhysicsMaterial2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000279 RID: 633
		private static readonly PhysicsMaterial2D.Create_InternalDelegate Create_InternalDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.Create_InternalDelegate>("UnityEngine.PhysicsMaterial2D::Create_Internal");

		// Token: 0x0400027A RID: 634
		private static readonly PhysicsMaterial2D.get_bouncinessDelegate get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::get_bounciness");

		// Token: 0x0400027B RID: 635
		private static readonly PhysicsMaterial2D.set_bouncinessDelegate set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::set_bounciness");

		// Token: 0x0400027C RID: 636
		private static readonly PhysicsMaterial2D.get_frictionDelegate get_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_frictionDelegate>("UnityEngine.PhysicsMaterial2D::get_friction");

		// Token: 0x0400027D RID: 637
		private static readonly PhysicsMaterial2D.set_frictionDelegate set_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_frictionDelegate>("UnityEngine.PhysicsMaterial2D::set_friction");

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x060007D6 RID: 2006
		private delegate void Create_InternalDelegate(IntPtr scriptMaterial, IntPtr name);

		// Token: 0x02000207 RID: 519
		// (Invoke) Token: 0x060007D8 RID: 2008
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x02000208 RID: 520
		// (Invoke) Token: 0x060007DA RID: 2010
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x02000209 RID: 521
		// (Invoke) Token: 0x060007DC RID: 2012
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x0200020A RID: 522
		// (Invoke) Token: 0x060007DE RID: 2014
		private delegate void set_frictionDelegate(IntPtr @this, float value);
	}
}
