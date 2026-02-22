using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class CapsuleCollider : Collider
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00005BBC File Offset: 0x00003DBC
		// Note: this type is marked as 'beforefieldinit'.
		static CapsuleCollider()
		{
			Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CapsuleCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr);
			CapsuleCollider.get_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_radiusDelegate>("UnityEngine.CapsuleCollider::get_radius");
			CapsuleCollider.set_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_radiusDelegate>("UnityEngine.CapsuleCollider::set_radius");
			CapsuleCollider.get_heightDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_heightDelegate>("UnityEngine.CapsuleCollider::get_height");
			CapsuleCollider.set_heightDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_heightDelegate>("UnityEngine.CapsuleCollider::set_height");
			CapsuleCollider.get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_directionDelegate>("UnityEngine.CapsuleCollider::get_direction");
			CapsuleCollider.set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_directionDelegate>("UnityEngine.CapsuleCollider::set_direction");
			CapsuleCollider.get_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_center_InjectedDelegate>("UnityEngine.CapsuleCollider::get_center_Injected");
			CapsuleCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_center_InjectedDelegate>("UnityEngine.CapsuleCollider::set_center_Injected");
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.GetGlobalExtents_InjectedDelegate>("UnityEngine.CapsuleCollider::GetGlobalExtents_Injected");
			CapsuleCollider.CalculateTransform_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.CalculateTransform_InjectedDelegate>("UnityEngine.CapsuleCollider::CalculateTransform_Injected");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002C0A File Offset: 0x00000E0A
		public CapsuleCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00005C84 File Offset: 0x00003E84
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002C13 File Offset: 0x00000E13
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002C1D File Offset: 0x00000E1D
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002C2F File Offset: 0x00000E2F
		public float radius
		{
			get
			{
				return CapsuleCollider.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002C42 File Offset: 0x00000E42
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002C54 File Offset: 0x00000E54
		public float height
		{
			get
			{
				return CapsuleCollider.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002C67 File Offset: 0x00000E67
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002C79 File Offset: 0x00000E79
		public int direction
		{
			get
			{
				return CapsuleCollider.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005C9C File Offset: 0x00003E9C
		public Vector2 GetGlobalExtents()
		{
			Vector2 vector;
			this.GetGlobalExtents_Injected(out vector);
			return vector;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005CB4 File Offset: 0x00003EB4
		public Matrix4x4 CalculateTransform()
		{
			Matrix4x4 matrix4x;
			this.CalculateTransform_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002C8C File Offset: 0x00000E8C
		public void get_center_Injected(out Vector3 ret)
		{
			CapsuleCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002C9F File Offset: 0x00000E9F
		public void set_center_Injected(ref Vector3 value)
		{
			CapsuleCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002CB2 File Offset: 0x00000EB2
		public void GetGlobalExtents_Injected(out Vector2 ret)
		{
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public void CalculateTransform_Injected(out Matrix4x4 ret)
		{
			CapsuleCollider.CalculateTransform_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000096 RID: 150
		private static readonly CapsuleCollider.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly CapsuleCollider.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly CapsuleCollider.get_heightDelegate get_heightDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly CapsuleCollider.set_heightDelegate set_heightDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly CapsuleCollider.get_directionDelegate get_directionDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly CapsuleCollider.set_directionDelegate set_directionDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly CapsuleCollider.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly CapsuleCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly CapsuleCollider.GetGlobalExtents_InjectedDelegate GetGlobalExtents_InjectedDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly CapsuleCollider.CalculateTransform_InjectedDelegate CalculateTransform_InjectedDelegateField;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x0600044B RID: 1099
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x0600044D RID: 1101
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600044F RID: 1103
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000451 RID: 1105
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000453 RID: 1107
		private delegate int get_directionDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000455 RID: 1109
		private delegate void set_directionDelegate(IntPtr @this, int value);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000457 RID: 1111
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000459 RID: 1113
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600045B RID: 1115
		private delegate void GetGlobalExtents_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600045D RID: 1117
		private delegate void CalculateTransform_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
