using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class ControllerColliderHit : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004270 File Offset: 0x00002470
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerColliderHit()
		{
			Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ControllerColliderHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr);
			ControllerColliderHit.NativeFieldInfoPtr_m_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Controller");
			ControllerColliderHit.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Collider");
			ControllerColliderHit.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Point");
			ControllerColliderHit.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Normal");
			ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveDirection");
			ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveLength");
			ControllerColliderHit.NativeFieldInfoPtr_m_Push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Push");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public ControllerColliderHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000432C File Offset: 0x0000252C
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe CharacterController m_Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000435C File Offset: 0x0000255C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe Collider m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000438C File Offset: 0x0000258C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002097 File Offset: 0x00000297
		public unsafe Vector3 m_Point
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Point);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Point)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000043B4 File Offset: 0x000025B4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe Vector3 m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Normal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Normal)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000043DC File Offset: 0x000025DC
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020CD File Offset: 0x000002CD
		public unsafe Vector3 m_MoveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004404 File Offset: 0x00002604
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		public unsafe float m_MoveLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000442C File Offset: 0x0000262C
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002103 File Offset: 0x00000303
		public unsafe int m_Push
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Push);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Push)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00004454 File Offset: 0x00002654
		public CharacterController controller
		{
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000446C File Offset: 0x0000266C
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00004484 File Offset: 0x00002684
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Collider.attachedRigidbody;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000044A4 File Offset: 0x000026A4
		public GameObject gameObject
		{
			get
			{
				return this.m_Collider.gameObject;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000044C4 File Offset: 0x000026C4
		public Transform transform
		{
			get
			{
				return this.m_Collider.transform;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000044E4 File Offset: 0x000026E4
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000044FC File Offset: 0x000026FC
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004514 File Offset: 0x00002714
		public Vector3 moveDirection
		{
			get
			{
				return this.m_MoveDirection;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000452C File Offset: 0x0000272C
		public float moveLength
		{
			get
			{
				return this.m_MoveLength;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00004544 File Offset: 0x00002744
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000211E File Offset: 0x0000031E
		public bool push
		{
			get
			{
				return this.m_Push != 0;
			}
			set
			{
				this.m_Push = (value ? 1 : 0);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Controller;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveDirection;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveLength;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_Push;
	}
}
