using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class Collision2D : Object
	{
		// Token: 0x060001EA RID: 490 RVA: 0x00009518 File Offset: 0x00007718
		// Note: this type is marked as 'beforefieldinit'.
		static Collision2D()
		{
			Il2CppClassPointerStore<Collision2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collision2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision2D>.NativeClassPtr);
			Collision2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Collider");
			Collision2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherCollider");
			Collision2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Rigidbody");
			Collision2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherRigidbody");
			Collision2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_RelativeVelocity");
			Collision2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Enabled");
			Collision2D.NativeFieldInfoPtr_m_ContactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ContactCount");
			Collision2D.NativeFieldInfoPtr_m_ReusedContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ReusedContacts");
			Collision2D.NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_LegacyContacts");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002A84 File Offset: 0x00000C84
		public Collision2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000095FC File Offset: 0x000077FC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002A8D File Offset: 0x00000C8D
		public unsafe int m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00009624 File Offset: 0x00007824
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public unsafe int m_OtherCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000964C File Offset: 0x0000784C
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002AC3 File Offset: 0x00000CC3
		public unsafe int m_Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00009674 File Offset: 0x00007874
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002ADE File Offset: 0x00000CDE
		public unsafe int m_OtherRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000969C File Offset: 0x0000789C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public unsafe Vector2 m_RelativeVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000096C4 File Offset: 0x000078C4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe int m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000096EC File Offset: 0x000078EC
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002B2F File Offset: 0x00000D2F
		public unsafe int m_ContactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00009714 File Offset: 0x00007914
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002B4A File Offset: 0x00000D4A
		public unsafe Il2CppStructArray<ContactPoint2D> m_ReusedContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00009744 File Offset: 0x00007944
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002B69 File Offset: 0x00000D69
		public unsafe Il2CppStructArray<ContactPoint2D> m_LegacyContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00009774 File Offset: 0x00007974
		public Il2CppStructArray<ContactPoint2D> GetContacts_Internal()
		{
			return (this.m_LegacyContacts == null) ? this.m_ReusedContacts : this.m_LegacyContacts;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000979C File Offset: 0x0000799C
		public Collider2D collider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Collider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000097C0 File Offset: 0x000079C0
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000097E4 File Offset: 0x000079E4
		public Rigidbody2D rigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Rigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00009808 File Offset: 0x00007A08
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000982C File Offset: 0x00007A2C
		public Transform transform
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.transform : this.collider.transform;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00009864 File Offset: 0x00007A64
		public GameObject gameObject
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.gameObject : this.collider.gameObject;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000989C File Offset: 0x00007A9C
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000098B4 File Offset: 0x00007AB4
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002B88 File Offset: 0x00000D88
		public Il2CppStructArray<ContactPoint2D> contacts
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000098D0 File Offset: 0x00007AD0
		public int contactCount
		{
			get
			{
				return this.m_ContactCount;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000098E8 File Offset: 0x00007AE8
		public ContactPoint2D GetContact(int index)
		{
			bool flag = index < 0 || index >= this.m_ContactCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Cannot get contact at index {0}. There are {1} contact(s).", index, this.m_ContactCount));
			}
			return this.GetContacts_Internal()[index];
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009940 File Offset: 0x00007B40
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided array is NULL.");
			}
			int num = Mathf.Min(this.m_ContactCount, contacts.Length);
			Array.Copy(this.GetContacts_Internal(), contacts, num);
			return num;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00009988 File Offset: 0x00007B88
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided list is NULL.");
			}
			contacts.Clear();
			contacts.AddRange(this.GetContacts_Internal());
			return this.contactCount;
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_m_ContactCount;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_m_ReusedContacts;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyContacts;
	}
}
