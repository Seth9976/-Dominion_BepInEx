using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class SphereCollider : Collider
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00005D8C File Offset: 0x00003F8C
		// Note: this type is marked as 'beforefieldinit'.
		static SphereCollider()
		{
			Il2CppClassPointerStore<SphereCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "SphereCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereCollider>.NativeClassPtr);
			SphereCollider.get_radiusDelegateField = IL2CPP.ResolveICall<SphereCollider.get_radiusDelegate>("UnityEngine.SphereCollider::get_radius");
			SphereCollider.set_radiusDelegateField = IL2CPP.ResolveICall<SphereCollider.set_radiusDelegate>("UnityEngine.SphereCollider::set_radius");
			SphereCollider.get_center_InjectedDelegateField = IL2CPP.ResolveICall<SphereCollider.get_center_InjectedDelegate>("UnityEngine.SphereCollider::get_center_Injected");
			SphereCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<SphereCollider.set_center_InjectedDelegate>("UnityEngine.SphereCollider::set_center_Injected");
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002D56 File Offset: 0x00000F56
		public SphereCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00005DF8 File Offset: 0x00003FF8
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002D5F File Offset: 0x00000F5F
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002D69 File Offset: 0x00000F69
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002D7B File Offset: 0x00000F7B
		public float radius
		{
			get
			{
				return SphereCollider.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SphereCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002D8E File Offset: 0x00000F8E
		public void get_center_Injected(out Vector3 ret)
		{
			SphereCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public void set_center_Injected(ref Vector3 value)
		{
			SphereCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000A4 RID: 164
		private static readonly SphereCollider.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly SphereCollider.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly SphereCollider.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly SphereCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000467 RID: 1127
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000469 RID: 1129
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x0600046B RID: 1131
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x0600046D RID: 1133
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
