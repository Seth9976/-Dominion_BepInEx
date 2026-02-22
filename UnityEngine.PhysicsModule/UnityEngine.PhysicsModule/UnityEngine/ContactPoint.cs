using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[StructLayout(2)]
	public struct ContactPoint
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00005E10 File Offset: 0x00004010
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint()
		{
			Il2CppClassPointerStore<ContactPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr);
			ContactPoint.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Point");
			ContactPoint.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Normal");
			ContactPoint.NativeFieldInfoPtr_m_ThisColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_ThisColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_OtherColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_OtherColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Separation");
			ContactPoint.GetColliderByInstanceIDDelegateField = IL2CPP.ResolveICall<ContactPoint.GetColliderByInstanceIDDelegate>("UnityEngine.ContactPoint::GetColliderByInstanceID");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005EB4 File Offset: 0x000040B4
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00005ECC File Offset: 0x000040CC
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005EE4 File Offset: 0x000040E4
		public Collider thisCollider
		{
			get
			{
				return ContactPoint.GetColliderByInstanceID(this.m_ThisColliderInstanceID);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00005F04 File Offset: 0x00004104
		public Collider otherCollider
		{
			get
			{
				return ContactPoint.GetColliderByInstanceID(this.m_OtherColliderInstanceID);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00005F24 File Offset: 0x00004124
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005F3C File Offset: 0x0000413C
		public static Collider GetColliderByInstanceID(int instanceID)
		{
			IntPtr intPtr = ContactPoint.GetColliderByInstanceIDDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisColliderInstanceID;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherColliderInstanceID;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x040000AD RID: 173
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x040000AE RID: 174
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x040000AF RID: 175
		[FieldOffset(24)]
		public int m_ThisColliderInstanceID;

		// Token: 0x040000B0 RID: 176
		[FieldOffset(28)]
		public int m_OtherColliderInstanceID;

		// Token: 0x040000B1 RID: 177
		[FieldOffset(32)]
		public float m_Separation;

		// Token: 0x040000B2 RID: 178
		private static readonly ContactPoint.GetColliderByInstanceIDDelegate GetColliderByInstanceIDDelegateField;

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x0600046F RID: 1135
		private delegate IntPtr GetColliderByInstanceIDDelegate(int instanceID);
	}
}
