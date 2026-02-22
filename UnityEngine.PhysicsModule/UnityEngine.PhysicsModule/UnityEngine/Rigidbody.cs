using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class Rigidbody : Component
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004E1C File Offset: 0x0000301C
		// Note: this type is marked as 'beforefieldinit'.
		static Rigidbody()
		{
			Il2CppClassPointerStore<Rigidbody>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Rigidbody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663303);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663304);
			Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663305);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663306);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663307);
			Rigidbody.get_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_dragDelegate>("UnityEngine.Rigidbody::get_drag");
			Rigidbody.set_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_dragDelegate>("UnityEngine.Rigidbody::set_drag");
			Rigidbody.get_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularDragDelegate>("UnityEngine.Rigidbody::get_angularDrag");
			Rigidbody.set_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_angularDragDelegate>("UnityEngine.Rigidbody::set_angularDrag");
			Rigidbody.get_massDelegateField = IL2CPP.ResolveICall<Rigidbody.get_massDelegate>("UnityEngine.Rigidbody::get_mass");
			Rigidbody.set_massDelegateField = IL2CPP.ResolveICall<Rigidbody.set_massDelegate>("UnityEngine.Rigidbody::set_mass");
			Rigidbody.SetDensityDelegateField = IL2CPP.ResolveICall<Rigidbody.SetDensityDelegate>("UnityEngine.Rigidbody::SetDensity");
			Rigidbody.get_useGravityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_useGravityDelegate>("UnityEngine.Rigidbody::get_useGravity");
			Rigidbody.set_useGravityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_useGravityDelegate>("UnityEngine.Rigidbody::set_useGravity");
			Rigidbody.get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::get_maxDepenetrationVelocity");
			Rigidbody.set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::set_maxDepenetrationVelocity");
			Rigidbody.get_isKinematicDelegateField = IL2CPP.ResolveICall<Rigidbody.get_isKinematicDelegate>("UnityEngine.Rigidbody::get_isKinematic");
			Rigidbody.set_isKinematicDelegateField = IL2CPP.ResolveICall<Rigidbody.set_isKinematicDelegate>("UnityEngine.Rigidbody::set_isKinematic");
			Rigidbody.get_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_freezeRotationDelegate>("UnityEngine.Rigidbody::get_freezeRotation");
			Rigidbody.set_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_freezeRotationDelegate>("UnityEngine.Rigidbody::set_freezeRotation");
			Rigidbody.get_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_constraintsDelegate>("UnityEngine.Rigidbody::get_constraints");
			Rigidbody.set_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_constraintsDelegate>("UnityEngine.Rigidbody::set_constraints");
			Rigidbody.get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.get_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::get_collisionDetectionMode");
			Rigidbody.set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.set_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::set_collisionDetectionMode");
			Rigidbody.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_detectCollisionsDelegate>("UnityEngine.Rigidbody::get_detectCollisions");
			Rigidbody.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_detectCollisionsDelegate>("UnityEngine.Rigidbody::set_detectCollisions");
			Rigidbody.get_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_interpolationDelegate>("UnityEngine.Rigidbody::get_interpolation");
			Rigidbody.set_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_interpolationDelegate>("UnityEngine.Rigidbody::set_interpolation");
			Rigidbody.get_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverIterationsDelegate>("UnityEngine.Rigidbody::get_solverIterations");
			Rigidbody.set_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverIterationsDelegate>("UnityEngine.Rigidbody::set_solverIterations");
			Rigidbody.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.get_sleepThresholdDelegate>("UnityEngine.Rigidbody::get_sleepThreshold");
			Rigidbody.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.set_sleepThresholdDelegate>("UnityEngine.Rigidbody::set_sleepThreshold");
			Rigidbody.get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::get_maxAngularVelocity");
			Rigidbody.set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::set_maxAngularVelocity");
			Rigidbody.SleepDelegateField = IL2CPP.ResolveICall<Rigidbody.SleepDelegate>("UnityEngine.Rigidbody::Sleep");
			Rigidbody.IsSleepingDelegateField = IL2CPP.ResolveICall<Rigidbody.IsSleepingDelegate>("UnityEngine.Rigidbody::IsSleeping");
			Rigidbody.WakeUpDelegateField = IL2CPP.ResolveICall<Rigidbody.WakeUpDelegate>("UnityEngine.Rigidbody::WakeUp");
			Rigidbody.ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetCenterOfMassDelegate>("UnityEngine.Rigidbody::ResetCenterOfMass");
			Rigidbody.ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetInertiaTensorDelegate>("UnityEngine.Rigidbody::ResetInertiaTensor");
			Rigidbody.get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::get_solverVelocityIterations");
			Rigidbody.set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::set_solverVelocityIterations");
			Rigidbody.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_velocity_InjectedDelegate>("UnityEngine.Rigidbody::get_velocity_Injected");
			Rigidbody.set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_velocity_InjectedDelegate>("UnityEngine.Rigidbody::set_velocity_Injected");
			Rigidbody.get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_angularVelocity_Injected");
			Rigidbody.set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_angularVelocity_Injected");
			Rigidbody.get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_centerOfMass_Injected");
			Rigidbody.set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::set_centerOfMass_Injected");
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_worldCenterOfMass_Injected");
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensorRotation_Injected");
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensorRotation_Injected");
			Rigidbody.get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensor_Injected");
			Rigidbody.set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensor_Injected");
			Rigidbody.get_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_position_InjectedDelegate>("UnityEngine.Rigidbody::get_position_Injected");
			Rigidbody.set_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_position_InjectedDelegate>("UnityEngine.Rigidbody::set_position_Injected");
			Rigidbody.get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_rotation_InjectedDelegate>("UnityEngine.Rigidbody::get_rotation_Injected");
			Rigidbody.set_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_rotation_InjectedDelegate>("UnityEngine.Rigidbody::set_rotation_Injected");
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetRelativePointVelocity_Injected");
			Rigidbody.GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetPointVelocity_Injected");
			Rigidbody.AddForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddForce_InjectedDelegate>("UnityEngine.Rigidbody::AddForce_Injected");
			Rigidbody.AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeForce_Injected");
			Rigidbody.AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddTorque_Injected");
			Rigidbody.AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeTorque_Injected");
			Rigidbody.AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody::AddForceAtPosition_Injected");
			Rigidbody.AddExplosionForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddExplosionForce_InjectedDelegate>("UnityEngine.Rigidbody::AddExplosionForce_Injected");
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Rigidbody::Internal_ClosestPointOnBounds_Injected");
			Rigidbody.SweepTest_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.SweepTest_InjectedDelegate>("UnityEngine.Rigidbody::SweepTest_Injected");
			Rigidbody.Internal_SweepTestAll_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_SweepTestAll_InjectedDelegate>("UnityEngine.Rigidbody::Internal_SweepTestAll_Injected");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005254 File Offset: 0x00003454
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 90368, RefRangeEnd = 90380, XrefRangeStart = 90366, XrefRangeEnd = 90368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005294 File Offset: 0x00003494
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 90382, RefRangeEnd = 90392, XrefRangeStart = 90380, XrefRangeEnd = 90382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000052D4 File Offset: 0x000034D4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005310 File Offset: 0x00003510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90392, XrefRangeEnd = 90394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition_Injected(ref Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005350 File Offset: 0x00003550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90394, XrefRangeEnd = 90396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation_Injected(ref Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002269 File Offset: 0x00000469
		public Rigidbody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005390 File Offset: 0x00003590
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002272 File Offset: 0x00000472
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000053A8 File Offset: 0x000035A8
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000227C File Offset: 0x0000047C
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_angularVelocity_Injected(ref value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002286 File Offset: 0x00000486
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002298 File Offset: 0x00000498
		public float drag
		{
			get
			{
				return Rigidbody.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000022AB File Offset: 0x000004AB
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000022BD File Offset: 0x000004BD
		public float angularDrag
		{
			get
			{
				return Rigidbody.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000022E2 File Offset: 0x000004E2
		public float mass
		{
			get
			{
				return Rigidbody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000022F5 File Offset: 0x000004F5
		public void SetDensity(float density)
		{
			Rigidbody.SetDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), density);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002308 File Offset: 0x00000508
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000231A File Offset: 0x0000051A
		public bool useGravity
		{
			get
			{
				return Rigidbody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000232D File Offset: 0x0000052D
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000233F File Offset: 0x0000053F
		public float maxDepenetrationVelocity
		{
			get
			{
				return Rigidbody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002352 File Offset: 0x00000552
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002364 File Offset: 0x00000564
		public bool isKinematic
		{
			get
			{
				return Rigidbody.get_isKinematicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_isKinematicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002377 File Offset: 0x00000577
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002389 File Offset: 0x00000589
		public bool freezeRotation
		{
			get
			{
				return Rigidbody.get_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000023AE File Offset: 0x000005AE
		public RigidbodyConstraints constraints
		{
			get
			{
				return Rigidbody.get_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000023C1 File Offset: 0x000005C1
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000023D3 File Offset: 0x000005D3
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return Rigidbody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000053C0 File Offset: 0x000035C0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000023E6 File Offset: 0x000005E6
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000053D8 File Offset: 0x000035D8
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000053F0 File Offset: 0x000035F0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000023F0 File Offset: 0x000005F0
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005408 File Offset: 0x00003608
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000023FA File Offset: 0x000005FA
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002404 File Offset: 0x00000604
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002416 File Offset: 0x00000616
		public bool detectCollisions
		{
			get
			{
				return Rigidbody.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005420 File Offset: 0x00003620
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002429 File Offset: 0x00000629
		public Vector3 position
		{
			get
			{
				Vector3 vector;
				this.get_position_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005438 File Offset: 0x00003638
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002433 File Offset: 0x00000633
		public Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				this.get_rotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_rotation_Injected(ref value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000243D File Offset: 0x0000063D
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000244F File Offset: 0x0000064F
		public RigidbodyInterpolation interpolation
		{
			get
			{
				return Rigidbody.get_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002462 File Offset: 0x00000662
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002474 File Offset: 0x00000674
		public int solverIterations
		{
			get
			{
				return Rigidbody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002487 File Offset: 0x00000687
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002499 File Offset: 0x00000699
		public float sleepThreshold
		{
			get
			{
				return Rigidbody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000024AC File Offset: 0x000006AC
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000024BE File Offset: 0x000006BE
		public float maxAngularVelocity
		{
			get
			{
				return Rigidbody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000024D1 File Offset: 0x000006D1
		public void Sleep()
		{
			Rigidbody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000024E3 File Offset: 0x000006E3
		public bool IsSleeping()
		{
			return Rigidbody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024F5 File Offset: 0x000006F5
		public void WakeUp()
		{
			Rigidbody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002507 File Offset: 0x00000707
		public void ResetCenterOfMass()
		{
			Rigidbody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002519 File Offset: 0x00000719
		public void ResetInertiaTensor()
		{
			Rigidbody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005450 File Offset: 0x00003650
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005468 File Offset: 0x00003668
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000252B File Offset: 0x0000072B
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000253D File Offset: 0x0000073D
		public int solverVelocityIterations
		{
			get
			{
				return Rigidbody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002550 File Offset: 0x00000750
		public void AddForce(Vector3 force, ForceMode mode)
		{
			this.AddForce_Injected(ref force, mode);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000255B File Offset: 0x0000075B
		public void AddForce(Vector3 force)
		{
			this.AddForce(force, ForceMode.Force);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002567 File Offset: 0x00000767
		public void AddForce(float x, float y, float z, ForceMode mode)
		{
			this.AddForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000257B File Offset: 0x0000077B
		public void AddForce(float x, float y, float z)
		{
			this.AddForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000258E File Offset: 0x0000078E
		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
			this.AddRelativeForce_Injected(ref force, mode);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002599 File Offset: 0x00000799
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce(force, ForceMode.Force);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000025A5 File Offset: 0x000007A5
		public void AddRelativeForce(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000025B9 File Offset: 0x000007B9
		public void AddRelativeForce(float x, float y, float z)
		{
			this.AddRelativeForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000025CC File Offset: 0x000007CC
		public void AddTorque(Vector3 torque, ForceMode mode)
		{
			this.AddTorque_Injected(ref torque, mode);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000025D7 File Offset: 0x000007D7
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque(torque, ForceMode.Force);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000025E3 File Offset: 0x000007E3
		public void AddTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025F7 File Offset: 0x000007F7
		public void AddTorque(float x, float y, float z)
		{
			this.AddTorque(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000260A File Offset: 0x0000080A
		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
			this.AddRelativeTorque_Injected(ref torque, mode);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002615 File Offset: 0x00000815
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque(torque, ForceMode.Force);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002621 File Offset: 0x00000821
		public void AddRelativeTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002635 File Offset: 0x00000835
		public void AddRelativeTorque(float x, float y, float z)
		{
			this.AddRelativeTorque(x, y, z, ForceMode.Force);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002643 File Offset: 0x00000843
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002650 File Offset: 0x00000850
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition(force, position, ForceMode.Force);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000265D File Offset: 0x0000085D
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			this.AddExplosionForce_Injected(explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000266D File Offset: 0x0000086D
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier, ForceMode.Force);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000267D File Offset: 0x0000087D
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, 0f, ForceMode.Force);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002690 File Offset: 0x00000890
		public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005480 File Offset: 0x00003680
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			float num = 0f;
			Vector3 zero = Vector3.zero;
			this.Internal_ClosestPointOnBounds(position, ref zero, ref num);
			return zero;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000054AC File Offset: 0x000036AC
		public RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.SweepTest_Injected(ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000054C8 File Offset: 0x000036C8
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			bool flag3;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				bool flag2 = false;
				hitInfo = this.SweepTest(vector, maxDistance, queryTriggerInteraction, ref flag2);
				flag3 = flag2;
			}
			else
			{
				hitInfo = default(RaycastHit);
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000551C File Offset: 0x0000371C
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return this.SweepTest(direction, out hitInfo, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005538 File Offset: 0x00003738
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
		{
			return this.SweepTest(direction, out hitInfo, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000269C File Offset: 0x0000089C
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			return this.Internal_SweepTestAll_Injected(ref direction, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026A8 File Offset: 0x000008A8
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005558 File Offset: 0x00003758
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance)
		{
			return this.SweepTestAll(direction, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005574 File Offset: 0x00003774
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction)
		{
			return this.SweepTestAll(direction, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005594 File Offset: 0x00003794
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000026B5 File Offset: 0x000008B5
		public float sleepVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000055AC File Offset: 0x000037AC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000026B8 File Offset: 0x000008B8
		public float sleepAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000026BB File Offset: 0x000008BB
		public void SetMaxAngularVelocity(float a)
		{
			this.maxAngularVelocity = a;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000055C4 File Offset: 0x000037C4
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000026C6 File Offset: 0x000008C6
		public bool useConeFriction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000026C9 File Offset: 0x000008C9
		public int solverIterationCount
		{
			get
			{
				return this.solverIterations;
			}
			set
			{
				this.solverIterations = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000055F0 File Offset: 0x000037F0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000026D4 File Offset: 0x000008D4
		public int solverVelocityIterationCount
		{
			get
			{
				return this.solverVelocityIterations;
			}
			set
			{
				this.solverVelocityIterations = value;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000026DF File Offset: 0x000008DF
		public void get_velocity_Injected(out Vector3 ret)
		{
			Rigidbody.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000026F2 File Offset: 0x000008F2
		public void set_velocity_Injected(ref Vector3 value)
		{
			Rigidbody.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002705 File Offset: 0x00000905
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			Rigidbody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002718 File Offset: 0x00000918
		public void set_angularVelocity_Injected(ref Vector3 value)
		{
			Rigidbody.set_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000272B File Offset: 0x0000092B
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000273E File Offset: 0x0000093E
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			Rigidbody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002751 File Offset: 0x00000951
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002764 File Offset: 0x00000964
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002777 File Offset: 0x00000977
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000278A File Offset: 0x0000098A
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			Rigidbody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000279D File Offset: 0x0000099D
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			Rigidbody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000027B0 File Offset: 0x000009B0
		public void get_position_Injected(out Vector3 ret)
		{
			Rigidbody.get_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000027C3 File Offset: 0x000009C3
		public void set_position_Injected(ref Vector3 value)
		{
			Rigidbody.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000027D6 File Offset: 0x000009D6
		public void get_rotation_Injected(out Quaternion ret)
		{
			Rigidbody.get_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000027E9 File Offset: 0x000009E9
		public void set_rotation_Injected(ref Quaternion value)
		{
			Rigidbody.set_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000027FC File Offset: 0x000009FC
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002810 File Offset: 0x00000A10
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			Rigidbody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002824 File Offset: 0x00000A24
		public void AddForce_Injected(ref Vector3 force, ForceMode mode)
		{
			Rigidbody.AddForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002838 File Offset: 0x00000A38
		public void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode)
		{
			Rigidbody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000284C File Offset: 0x00000A4C
		public void AddTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002860 File Offset: 0x00000A60
		public void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002874 File Offset: 0x00000A74
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode)
		{
			Rigidbody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002889 File Offset: 0x00000A89
		public void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			Rigidbody.AddExplosionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000028A2 File Offset: 0x00000AA2
		public void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref outPos, ref distance);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000028B7 File Offset: 0x00000AB7
		public void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret)
		{
			Rigidbody.SweepTest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out ret);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005608 File Offset: 0x00003808
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Rigidbody.Internal_SweepTestAll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400002B RID: 43
		private static readonly Rigidbody.get_dragDelegate get_dragDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Rigidbody.set_dragDelegate set_dragDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Rigidbody.get_angularDragDelegate get_angularDragDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Rigidbody.set_angularDragDelegate set_angularDragDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Rigidbody.get_massDelegate get_massDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Rigidbody.set_massDelegate set_massDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Rigidbody.SetDensityDelegate SetDensityDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Rigidbody.get_useGravityDelegate get_useGravityDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Rigidbody.set_useGravityDelegate set_useGravityDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Rigidbody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Rigidbody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Rigidbody.get_isKinematicDelegate get_isKinematicDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Rigidbody.set_isKinematicDelegate set_isKinematicDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Rigidbody.get_freezeRotationDelegate get_freezeRotationDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Rigidbody.set_freezeRotationDelegate set_freezeRotationDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Rigidbody.get_constraintsDelegate get_constraintsDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Rigidbody.set_constraintsDelegate set_constraintsDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Rigidbody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Rigidbody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Rigidbody.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Rigidbody.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Rigidbody.get_interpolationDelegate get_interpolationDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Rigidbody.set_interpolationDelegate set_interpolationDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Rigidbody.get_solverIterationsDelegate get_solverIterationsDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Rigidbody.set_solverIterationsDelegate set_solverIterationsDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Rigidbody.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Rigidbody.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Rigidbody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Rigidbody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Rigidbody.SleepDelegate SleepDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Rigidbody.IsSleepingDelegate IsSleepingDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Rigidbody.WakeUpDelegate WakeUpDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Rigidbody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Rigidbody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Rigidbody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Rigidbody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Rigidbody.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Rigidbody.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Rigidbody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly Rigidbody.set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly Rigidbody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly Rigidbody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly Rigidbody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly Rigidbody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Rigidbody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Rigidbody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Rigidbody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Rigidbody.get_position_InjectedDelegate get_position_InjectedDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Rigidbody.set_position_InjectedDelegate set_position_InjectedDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Rigidbody.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Rigidbody.set_rotation_InjectedDelegate set_rotation_InjectedDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Rigidbody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Rigidbody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Rigidbody.AddForce_InjectedDelegate AddForce_InjectedDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Rigidbody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Rigidbody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Rigidbody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Rigidbody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Rigidbody.AddExplosionForce_InjectedDelegate AddExplosionForce_InjectedDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Rigidbody.SweepTest_InjectedDelegate SweepTest_InjectedDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Rigidbody.Internal_SweepTestAll_InjectedDelegate Internal_SweepTestAll_InjectedDelegateField;

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000379 RID: 889
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600037B RID: 891
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600037D RID: 893
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600037F RID: 895
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000381 RID: 897
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000383 RID: 899
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000385 RID: 901
		private delegate void SetDensityDelegate(IntPtr @this, float density);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000387 RID: 903
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000389 RID: 905
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600038B RID: 907
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600038D RID: 909
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600038F RID: 911
		private delegate bool get_isKinematicDelegate(IntPtr @this);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000391 RID: 913
		private delegate void set_isKinematicDelegate(IntPtr @this, bool value);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000393 RID: 915
		private delegate bool get_freezeRotationDelegate(IntPtr @this);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000395 RID: 917
		private delegate void set_freezeRotationDelegate(IntPtr @this, bool value);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000397 RID: 919
		private delegate RigidbodyConstraints get_constraintsDelegate(IntPtr @this);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000399 RID: 921
		private delegate void set_constraintsDelegate(IntPtr @this, RigidbodyConstraints value);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600039B RID: 923
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600039D RID: 925
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600039F RID: 927
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060003A1 RID: 929
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060003A3 RID: 931
		private delegate RigidbodyInterpolation get_interpolationDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060003A5 RID: 933
		private delegate void set_interpolationDelegate(IntPtr @this, RigidbodyInterpolation value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060003A7 RID: 935
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060003A9 RID: 937
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060003AB RID: 939
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060003AD RID: 941
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060003AF RID: 943
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060003B1 RID: 945
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060003B3 RID: 947
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060003B5 RID: 949
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060003B7 RID: 951
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060003B9 RID: 953
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060003BB RID: 955
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060003BD RID: 957
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060003BF RID: 959
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060003C1 RID: 961
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060003C3 RID: 963
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060003C5 RID: 965
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060003C7 RID: 967
		private delegate void set_angularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060003C9 RID: 969
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060003CB RID: 971
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060003CD RID: 973
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060003CF RID: 975
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060003D1 RID: 977
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060003D3 RID: 979
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060003D5 RID: 981
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060003D7 RID: 983
		private delegate void get_position_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060003D9 RID: 985
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060003DB RID: 987
		private delegate void get_rotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060003DD RID: 989
		private delegate void set_rotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060003DF RID: 991
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060003E1 RID: 993
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060003E3 RID: 995
		private delegate void AddForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060003E5 RID: 997
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060003E7 RID: 999
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060003E9 RID: 1001
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060003EB RID: 1003
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode mode);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060003ED RID: 1005
		private delegate void AddExplosionForce_InjectedDelegate(IntPtr @this, float explosionForce, IntPtr explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060003EF RID: 1007
		private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr outPos, IntPtr distance);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060003F1 RID: 1009
		private delegate void SweepTest_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, IntPtr hasHit, [Out] IntPtr ret);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060003F3 RID: 1011
		private delegate IntPtr Internal_SweepTestAll_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);
	}
}
