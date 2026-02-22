using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class Collider2D : Behaviour
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000A77C File Offset: 0x0000897C
		// Note: this type is marked as 'beforefieldinit'.
		static Collider2D()
		{
			Il2CppClassPointerStore<Collider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider2D>.NativeClassPtr);
			Collider2D.get_densityDelegateField = IL2CPP.ResolveICall<Collider2D.get_densityDelegate>("UnityEngine.Collider2D::get_density");
			Collider2D.set_densityDelegateField = IL2CPP.ResolveICall<Collider2D.set_densityDelegate>("UnityEngine.Collider2D::set_density");
			Collider2D.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider2D.get_isTriggerDelegate>("UnityEngine.Collider2D::get_isTrigger");
			Collider2D.set_isTriggerDelegateField = IL2CPP.ResolveICall<Collider2D.set_isTriggerDelegate>("UnityEngine.Collider2D::set_isTrigger");
			Collider2D.get_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByEffectorDelegate>("UnityEngine.Collider2D::get_usedByEffector");
			Collider2D.set_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByEffectorDelegate>("UnityEngine.Collider2D::set_usedByEffector");
			Collider2D.get_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByCompositeDelegate>("UnityEngine.Collider2D::get_usedByComposite");
			Collider2D.set_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByCompositeDelegate>("UnityEngine.Collider2D::set_usedByComposite");
			Collider2D.get_compositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeDelegate>("UnityEngine.Collider2D::get_composite");
			Collider2D.get_attachedRigidbodyDelegateField = IL2CPP.ResolveICall<Collider2D.get_attachedRigidbodyDelegate>("UnityEngine.Collider2D::get_attachedRigidbody");
			Collider2D.get_shapeCountDelegateField = IL2CPP.ResolveICall<Collider2D.get_shapeCountDelegate>("UnityEngine.Collider2D::get_shapeCount");
			Collider2D.CreateMeshDelegateField = IL2CPP.ResolveICall<Collider2D.CreateMeshDelegate>("UnityEngine.Collider2D::CreateMesh");
			Collider2D.GetShapeHashDelegateField = IL2CPP.ResolveICall<Collider2D.GetShapeHashDelegate>("UnityEngine.Collider2D::GetShapeHash");
			Collider2D.get_errorStateDelegateField = IL2CPP.ResolveICall<Collider2D.get_errorStateDelegate>("UnityEngine.Collider2D::get_errorState");
			Collider2D.get_compositeCapableDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeCapableDelegate>("UnityEngine.Collider2D::get_compositeCapable");
			Collider2D.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.get_sharedMaterialDelegate>("UnityEngine.Collider2D::get_sharedMaterial");
			Collider2D.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.set_sharedMaterialDelegate>("UnityEngine.Collider2D::set_sharedMaterial");
			Collider2D.get_frictionDelegateField = IL2CPP.ResolveICall<Collider2D.get_frictionDelegate>("UnityEngine.Collider2D::get_friction");
			Collider2D.get_bouncinessDelegateField = IL2CPP.ResolveICall<Collider2D.get_bouncinessDelegate>("UnityEngine.Collider2D::get_bounciness");
			Collider2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingDelegate>("UnityEngine.Collider2D::IsTouching");
			Collider2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingLayersDelegate>("UnityEngine.Collider2D::IsTouchingLayers");
			Collider2D.get_offset_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_offset_InjectedDelegate>("UnityEngine.Collider2D::get_offset_Injected");
			Collider2D.set_offset_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_offset_InjectedDelegate>("UnityEngine.Collider2D::set_offset_Injected");
			Collider2D.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_bounds_InjectedDelegate>("UnityEngine.Collider2D::get_bounds_Injected");
			Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected");
			Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected");
			Collider2D.OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.OverlapPoint_InjectedDelegate>("UnityEngine.Collider2D::OverlapPoint_Injected");
			Collider2D.CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastArray_Internal_Injected");
			Collider2D.CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastList_Internal_Injected");
			Collider2D.RaycastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastArray_Internal_Injected");
			Collider2D.RaycastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastList_Internal_Injected");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000330B File Offset: 0x0000150B
		public Collider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00003326 File Offset: 0x00001526
		public float density
		{
			get
			{
				return Collider2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00003339 File Offset: 0x00001539
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000334B File Offset: 0x0000154B
		public bool isTrigger
		{
			get
			{
				return Collider2D.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000335E File Offset: 0x0000155E
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00003370 File Offset: 0x00001570
		public bool usedByEffector
		{
			get
			{
				return Collider2D.get_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00003383 File Offset: 0x00001583
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00003395 File Offset: 0x00001595
		public bool usedByComposite
		{
			get
			{
				return Collider2D.get_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000A980 File Offset: 0x00008B80
		public CompositeCollider2D composite
		{
			get
			{
				IntPtr intPtr = Collider2D.get_compositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeCollider2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000A9AC File Offset: 0x00008BAC
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000033A8 File Offset: 0x000015A8
		public Vector2 offset
		{
			get
			{
				Vector2 vector;
				this.get_offset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_offset_Injected(ref value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		public Rigidbody2D attachedRigidbody
		{
			get
			{
				IntPtr intPtr = Collider2D.get_attachedRigidbodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000033B2 File Offset: 0x000015B2
		public int shapeCount
		{
			get
			{
				return Collider2D.get_shapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation)
		{
			IntPtr intPtr = Collider2D.CreateMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), useBodyPosition, useBodyRotation);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000033C4 File Offset: 0x000015C4
		public uint GetShapeHash()
		{
			return Collider2D.GetShapeHashDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000AA20 File Offset: 0x00008C20
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000033D6 File Offset: 0x000015D6
		public ColliderErrorState2D errorState
		{
			get
			{
				return Collider2D.get_errorStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000033E8 File Offset: 0x000015E8
		public bool compositeCapable
		{
			get
			{
				return Collider2D.get_compositeCapableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000AA38 File Offset: 0x00008C38
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000033FA File Offset: 0x000015FA
		public PhysicsMaterial2D sharedMaterial
		{
			get
			{
				IntPtr intPtr = Collider2D.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				Collider2D.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00003412 File Offset: 0x00001612
		public float friction
		{
			get
			{
				return Collider2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003424 File Offset: 0x00001624
		public float bounciness
		{
			get
			{
				return Collider2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003436 File Offset: 0x00001636
		public bool IsTouching(Collider2D collider)
		{
			return Collider2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider));
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000AA64 File Offset: 0x00008C64
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter(collider, contactFilter);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000344E File Offset: 0x0000164E
		public bool IsTouching_OtherColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Injected(collider, ref contactFilter);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000AA80 File Offset: 0x00008C80
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter(contactFilter);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003459 File Offset: 0x00001659
		public bool IsTouching_AnyColliderWithFilter(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Injected(ref contactFilter);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public bool IsTouchingLayers()
		{
			return this.IsTouchingLayers(-1);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003463 File Offset: 0x00001663
		public bool IsTouchingLayers(int layerMask)
		{
			return Collider2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerMask);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003476 File Offset: 0x00001676
		public bool OverlapPoint(Vector2 point)
		{
			return this.OverlapPoint_Injected(ref point);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public int OverlapCollider(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000AB18 File Offset: 0x00008D18
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000AB40 File Offset: 0x00008D40
		public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000AB78 File Offset: 0x00008D78
		public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		public int GetContacts(List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000AC00 File Offset: 0x00008E00
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, true, results);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000AC54 File Offset: 0x00008E54
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, true, results);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter, true, results);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000AD18 File Offset: 0x00008F18
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, true, results);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000AD38 File Offset: 0x00008F38
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003480 File Offset: 0x00001680
		public int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000AD58 File Offset: 0x00008F58
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
		{
			return this.CastList_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003491 File Offset: 0x00001691
		public int CastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return this.CastList_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000AD78 File Offset: 0x00008F78
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, results);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000AE0C File Offset: 0x0000900C
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000AE38 File Offset: 0x00009038
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000AE60 File Offset: 0x00009060
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000AE80 File Offset: 0x00009080
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.RaycastArray_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000034A2 File Offset: 0x000016A2
		public int RaycastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return this.RaycastList_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000034B1 File Offset: 0x000016B1
		public int RaycastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return this.RaycastList_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public Vector2 ClosestPoint(Vector2 position)
		{
			return Physics2D.ClosestPoint(position, this);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000034C0 File Offset: 0x000016C0
		public void get_offset_Injected(out Vector2 ret)
		{
			Collider2D.get_offset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000034D3 File Offset: 0x000016D3
		public void set_offset_Injected(ref Vector2 value)
		{
			Collider2D.set_offset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000034E6 File Offset: 0x000016E6
		public void get_bounds_Injected(out Bounds ret)
		{
			Collider2D.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000034F9 File Offset: 0x000016F9
		public bool IsTouching_OtherColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003512 File Offset: 0x00001712
		public bool IsTouching_AnyColliderWithFilter_Injected(ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003525 File Offset: 0x00001725
		public bool OverlapPoint_Injected(ref Vector2 point)
		{
			return Collider2D.OverlapPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003538 File Offset: 0x00001738
		public int CastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.CastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003556 File Offset: 0x00001756
		public int CastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return Collider2D.CastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003574 File Offset: 0x00001774
		public int RaycastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.RaycastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003590 File Offset: 0x00001790
		public int RaycastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Collider2D.RaycastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0400013C RID: 316
		private static readonly Collider2D.get_densityDelegate get_densityDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly Collider2D.set_densityDelegate set_densityDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly Collider2D.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x0400013F RID: 319
		private static readonly Collider2D.set_isTriggerDelegate set_isTriggerDelegateField;

		// Token: 0x04000140 RID: 320
		private static readonly Collider2D.get_usedByEffectorDelegate get_usedByEffectorDelegateField;

		// Token: 0x04000141 RID: 321
		private static readonly Collider2D.set_usedByEffectorDelegate set_usedByEffectorDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly Collider2D.get_usedByCompositeDelegate get_usedByCompositeDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly Collider2D.set_usedByCompositeDelegate set_usedByCompositeDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly Collider2D.get_compositeDelegate get_compositeDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly Collider2D.get_attachedRigidbodyDelegate get_attachedRigidbodyDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly Collider2D.get_shapeCountDelegate get_shapeCountDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly Collider2D.CreateMeshDelegate CreateMeshDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly Collider2D.GetShapeHashDelegate GetShapeHashDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly Collider2D.get_errorStateDelegate get_errorStateDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly Collider2D.get_compositeCapableDelegate get_compositeCapableDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly Collider2D.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly Collider2D.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x0400014D RID: 333
		private static readonly Collider2D.get_frictionDelegate get_frictionDelegateField;

		// Token: 0x0400014E RID: 334
		private static readonly Collider2D.get_bouncinessDelegate get_bouncinessDelegateField;

		// Token: 0x0400014F RID: 335
		private static readonly Collider2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x04000150 RID: 336
		private static readonly Collider2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x04000151 RID: 337
		private static readonly Collider2D.get_offset_InjectedDelegate get_offset_InjectedDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly Collider2D.set_offset_InjectedDelegate set_offset_InjectedDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly Collider2D.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate IsTouching_OtherColliderWithFilter_InjectedDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate IsTouching_AnyColliderWithFilter_InjectedDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Collider2D.OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Collider2D.CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Collider2D.CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Collider2D.RaycastArray_Internal_InjectedDelegate RaycastArray_Internal_InjectedDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly Collider2D.RaycastList_Internal_InjectedDelegate RaycastList_Internal_InjectedDelegateField;

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate void set_isTriggerDelegate(IntPtr @this, bool value);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate bool get_usedByEffectorDelegate(IntPtr @this);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate void set_usedByEffectorDelegate(IntPtr @this, bool value);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate bool get_usedByCompositeDelegate(IntPtr @this);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate void set_usedByCompositeDelegate(IntPtr @this, bool value);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate IntPtr get_compositeDelegate(IntPtr @this);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate IntPtr get_attachedRigidbodyDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate int get_shapeCountDelegate(IntPtr @this);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate IntPtr CreateMeshDelegate(IntPtr @this, bool useBodyPosition, bool useBodyRotation);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate uint GetShapeHashDelegate(IntPtr @this);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate ColliderErrorState2D get_errorStateDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate bool get_compositeCapableDelegate(IntPtr @this);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate bool IsTouchingDelegate(IntPtr @this, IntPtr collider);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate bool IsTouchingLayersDelegate(IntPtr @this, int layerMask);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate void get_offset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate void set_offset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate bool IsTouching_OtherColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr collider, IntPtr contactFilter);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate bool IsTouching_AnyColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr contactFilter);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate bool OverlapPoint_InjectedDelegate(IntPtr @this, IntPtr point);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate int CastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate int CastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate int RaycastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate int RaycastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);
	}
}
