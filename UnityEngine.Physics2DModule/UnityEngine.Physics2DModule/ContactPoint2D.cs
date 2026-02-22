using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct ContactPoint2D
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000099C8 File Offset: 0x00007BC8
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint2D()
		{
			Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactPoint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr);
			ContactPoint2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Point");
			ContactPoint2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Normal");
			ContactPoint2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_RelativeVelocity");
			ContactPoint2D.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Separation");
			ContactPoint2D.NativeFieldInfoPtr_m_NormalImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_NormalImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_TangentImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_TangentImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Collider");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherCollider");
			ContactPoint2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Rigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherRigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Enabled");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002B95 File Offset: 0x00000D95
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, ref this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00009AEC File Offset: 0x00007CEC
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00009B04 File Offset: 0x00007D04
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00009B1C File Offset: 0x00007D1C
		public float normalImpulse
		{
			get
			{
				return this.m_NormalImpulse;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00009B34 File Offset: 0x00007D34
		public float tangentImpulse
		{
			get
			{
				return this.m_TangentImpulse;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00009B4C File Offset: 0x00007D4C
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00009B64 File Offset: 0x00007D64
		public Collider2D collider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Collider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00009B88 File Offset: 0x00007D88
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00009BAC File Offset: 0x00007DAC
		public Rigidbody2D rigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Rigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00009BD0 File Offset: 0x00007DD0
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalImpulse;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_m_TangentImpulse;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040000D4 RID: 212
		[FieldOffset(0)]
		public Vector2 m_Point;

		// Token: 0x040000D5 RID: 213
		[FieldOffset(8)]
		public Vector2 m_Normal;

		// Token: 0x040000D6 RID: 214
		[FieldOffset(16)]
		public Vector2 m_RelativeVelocity;

		// Token: 0x040000D7 RID: 215
		[FieldOffset(24)]
		public float m_Separation;

		// Token: 0x040000D8 RID: 216
		[FieldOffset(28)]
		public float m_NormalImpulse;

		// Token: 0x040000D9 RID: 217
		[FieldOffset(32)]
		public float m_TangentImpulse;

		// Token: 0x040000DA RID: 218
		[FieldOffset(36)]
		public int m_Collider;

		// Token: 0x040000DB RID: 219
		[FieldOffset(40)]
		public int m_OtherCollider;

		// Token: 0x040000DC RID: 220
		[FieldOffset(44)]
		public int m_Rigidbody;

		// Token: 0x040000DD RID: 221
		[FieldOffset(48)]
		public int m_OtherRigidbody;

		// Token: 0x040000DE RID: 222
		[FieldOffset(52)]
		public int m_Enabled;
	}
}
