using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public class Physics : Object
	{
		// Token: 0x0600017C RID: 380 RVA: 0x00006C6C File Offset: 0x00004E6C
		// Note: this type is marked as 'beforefieldinit'.
		static Physics()
		{
			Il2CppClassPointerStore<Physics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Physics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics>.NativeClassPtr);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663323);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663324);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663325);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663326);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663327);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663328);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663329);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663330);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663331);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663332);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663333);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663334);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663335);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663336);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663337);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663338);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663339);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663340);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663341);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663342);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663343);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663344);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663345);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663346);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663347);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663348);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663349);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663350);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663351);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663352);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663353);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663354);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663355);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663356);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663357);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663358);
			Physics.get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.get_defaultContactOffsetDelegate>("UnityEngine.Physics::get_defaultContactOffset");
			Physics.set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.set_defaultContactOffsetDelegate>("UnityEngine.Physics::set_defaultContactOffset");
			Physics.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_sleepThresholdDelegate>("UnityEngine.Physics::get_sleepThreshold");
			Physics.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_sleepThresholdDelegate>("UnityEngine.Physics::set_sleepThreshold");
			Physics.get_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitTriggersDelegate>("UnityEngine.Physics::get_queriesHitTriggers");
			Physics.set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitTriggersDelegate>("UnityEngine.Physics::set_queriesHitTriggers");
			Physics.get_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitBackfacesDelegate>("UnityEngine.Physics::get_queriesHitBackfaces");
			Physics.set_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitBackfacesDelegate>("UnityEngine.Physics::set_queriesHitBackfaces");
			Physics.get_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_bounceThresholdDelegate>("UnityEngine.Physics::get_bounceThreshold");
			Physics.set_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_bounceThresholdDelegate>("UnityEngine.Physics::set_bounceThreshold");
			Physics.get_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::get_defaultMaxDepenetrationVelocity");
			Physics.set_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::set_defaultMaxDepenetrationVelocity");
			Physics.get_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverIterationsDelegate>("UnityEngine.Physics::get_defaultSolverIterations");
			Physics.set_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverIterationsDelegate>("UnityEngine.Physics::set_defaultSolverIterations");
			Physics.get_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::get_defaultSolverVelocityIterations");
			Physics.set_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::set_defaultSolverVelocityIterations");
			Physics.get_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::get_defaultMaxAngularSpeed");
			Physics.set_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::set_defaultMaxAngularSpeed");
			Physics.IgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreCollisionDelegate>("UnityEngine.Physics::IgnoreCollision");
			Physics.IgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreLayerCollisionDelegate>("UnityEngine.Physics::IgnoreLayerCollision");
			Physics.GetIgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreLayerCollisionDelegate>("UnityEngine.Physics::GetIgnoreLayerCollision");
			Physics.GetIgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreCollisionDelegate>("UnityEngine.Physics::GetIgnoreCollision");
			Physics.get_autoSimulationDelegateField = IL2CPP.ResolveICall<Physics.get_autoSimulationDelegate>("UnityEngine.Physics::get_autoSimulation");
			Physics.set_autoSimulationDelegateField = IL2CPP.ResolveICall<Physics.set_autoSimulationDelegate>("UnityEngine.Physics::set_autoSimulation");
			Physics.SyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.SyncTransformsDelegate>("UnityEngine.Physics::SyncTransforms");
			Physics.get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.get_autoSyncTransformsDelegate>("UnityEngine.Physics::get_autoSyncTransforms");
			Physics.set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.set_autoSyncTransformsDelegate>("UnityEngine.Physics::set_autoSyncTransforms");
			Physics.get_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.get_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::get_reuseCollisionCallbacks");
			Physics.set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::set_reuseCollisionCallbacks");
			Physics.get_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionDistanceDelegate>("UnityEngine.Physics::get_interCollisionDistance");
			Physics.set_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionDistanceDelegate>("UnityEngine.Physics::set_interCollisionDistance");
			Physics.get_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionStiffnessDelegate>("UnityEngine.Physics::get_interCollisionStiffness");
			Physics.set_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionStiffnessDelegate>("UnityEngine.Physics::set_interCollisionStiffness");
			Physics.get_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::get_interCollisionSettingsToggle");
			Physics.set_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::set_interCollisionSettingsToggle");
			Physics.BakeMeshDelegateField = IL2CPP.ResolveICall<Physics.BakeMeshDelegate>("UnityEngine.Physics::BakeMesh");
			Physics.get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_gravity_InjectedDelegate>("UnityEngine.Physics::get_gravity_Injected");
			Physics.set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_gravity_InjectedDelegate>("UnityEngine.Physics::set_gravity_Injected");
			Physics.Query_CapsuleCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_CapsuleCastAll_InjectedDelegate>("UnityEngine.Physics::Query_CapsuleCastAll_Injected");
			Physics.Query_SphereCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_SphereCastAll_InjectedDelegate>("UnityEngine.Physics::Query_SphereCastAll_Injected");
			Physics.OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapCapsule_Internal_Injected");
			Physics.OverlapSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapSphere_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapSphere_Internal_Injected");
			Physics.Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Simulate_Internal_InjectedDelegate>("UnityEngine.Physics::Simulate_Internal_Injected");
			Physics.Query_ComputePenetration_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ComputePenetration_InjectedDelegate>("UnityEngine.Physics::Query_ComputePenetration_Injected");
			Physics.Query_ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ClosestPoint_InjectedDelegate>("UnityEngine.Physics::Query_ClosestPoint_Injected");
			Physics.get_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_clothGravity_InjectedDelegate>("UnityEngine.Physics::get_clothGravity_Injected");
			Physics.set_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_clothGravity_InjectedDelegate>("UnityEngine.Physics::set_clothGravity_Injected");
			Physics.CheckSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckSphere_Internal_InjectedDelegate>("UnityEngine.Physics::CheckSphere_Internal_Injected");
			Physics.CheckCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::CheckCapsule_Internal_Injected");
			Physics.CheckBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckBox_Internal_InjectedDelegate>("UnityEngine.Physics::CheckBox_Internal_Injected");
			Physics.OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapBox_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapBox_Internal_Injected");
			Physics.Internal_BoxCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_BoxCastAll_InjectedDelegate>("UnityEngine.Physics::Internal_BoxCastAll_Injected");
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate>("UnityEngine.Physics::Internal_RebuildBroadphaseRegions_Injected");
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00007288 File Offset: 0x00005488
		public unsafe static PhysicsScene defaultPhysicsScene
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90443, XrefRangeEnd = 90445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000072B8 File Offset: 0x000054B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90445, XrefRangeEnd = 90452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007330 File Offset: 0x00005530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90452, XrefRangeEnd = 90459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007398 File Offset: 0x00005598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90459, XrefRangeEnd = 90466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000073F4 File Offset: 0x000055F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90466, XrefRangeEnd = 90473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007440 File Offset: 0x00005640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90473, XrefRangeEnd = 90480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000074C4 File Offset: 0x000056C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90480, XrefRangeEnd = 90487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000753C File Offset: 0x0000573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90487, XrefRangeEnd = 90494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000075A4 File Offset: 0x000057A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90494, XrefRangeEnd = 90501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007600 File Offset: 0x00005800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90501, XrefRangeEnd = 90510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007668 File Offset: 0x00005868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90510, XrefRangeEnd = 90519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000076C4 File Offset: 0x000058C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90519, XrefRangeEnd = 90528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007710 File Offset: 0x00005910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90528, XrefRangeEnd = 90537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007750 File Offset: 0x00005950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90537, XrefRangeEnd = 90546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000077C8 File Offset: 0x000059C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90555, RefRangeEnd = 90556, XrefRangeStart = 90546, XrefRangeEnd = 90555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007830 File Offset: 0x00005A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90565, RefRangeEnd = 90566, XrefRangeStart = 90556, XrefRangeEnd = 90565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000788C File Offset: 0x00005A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90566, XrefRangeEnd = 90575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000078D8 File Offset: 0x00005AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90575, XrefRangeEnd = 90577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007950 File Offset: 0x00005B50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 90587, RefRangeEnd = 90594, XrefRangeStart = 90577, XrefRangeEnd = 90587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000079C8 File Offset: 0x00005BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90594, XrefRangeEnd = 90595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00007A34 File Offset: 0x00005C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90595, XrefRangeEnd = 90596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007A90 File Offset: 0x00005C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90596, XrefRangeEnd = 90597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007AE0 File Offset: 0x00005CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90597, XrefRangeEnd = 90600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007B4C File Offset: 0x00005D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90600, XrefRangeEnd = 90603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90603, XrefRangeEnd = 90606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007BF8 File Offset: 0x00005DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90606, XrefRangeEnd = 90609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007C38 File Offset: 0x00005E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90609, XrefRangeEnd = 90619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007CB4 File Offset: 0x00005EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90619, XrefRangeEnd = 90629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007D20 File Offset: 0x00005F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90629, XrefRangeEnd = 90639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007D80 File Offset: 0x00005F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90639, XrefRangeEnd = 90649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90649, XrefRangeEnd = 90657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007E58 File Offset: 0x00006058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90657, XrefRangeEnd = 90665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007ED4 File Offset: 0x000060D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90665, XrefRangeEnd = 90673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007F40 File Offset: 0x00006140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90673, XrefRangeEnd = 90681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007FA0 File Offset: 0x000061A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90681, XrefRangeEnd = 90683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultPhysicsScene_Injected(out PhysicsScene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007FD4 File Offset: 0x000061D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90683, XrefRangeEnd = 90685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002EB8 File Offset: 0x000010B8
		public Physics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000804C File Offset: 0x0000624C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002EC1 File Offset: 0x000010C1
		public static Vector3 gravity
		{
			get
			{
				Vector3 vector;
				Physics.get_gravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002ECA File Offset: 0x000010CA
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002ED6 File Offset: 0x000010D6
		public static float defaultContactOffset
		{
			get
			{
				return Physics.get_defaultContactOffsetDelegateField();
			}
			set
			{
				Physics.set_defaultContactOffsetDelegateField(value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002EE3 File Offset: 0x000010E3
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002EEF File Offset: 0x000010EF
		public static float sleepThreshold
		{
			get
			{
				return Physics.get_sleepThresholdDelegateField();
			}
			set
			{
				Physics.set_sleepThresholdDelegateField(value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002EFC File Offset: 0x000010FC
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002F08 File Offset: 0x00001108
		public static bool queriesHitTriggers
		{
			get
			{
				return Physics.get_queriesHitTriggersDelegateField();
			}
			set
			{
				Physics.set_queriesHitTriggersDelegateField(value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002F15 File Offset: 0x00001115
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002F21 File Offset: 0x00001121
		public static bool queriesHitBackfaces
		{
			get
			{
				return Physics.get_queriesHitBackfacesDelegateField();
			}
			set
			{
				Physics.set_queriesHitBackfacesDelegateField(value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00002F2E File Offset: 0x0000112E
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002F3A File Offset: 0x0000113A
		public static float bounceThreshold
		{
			get
			{
				return Physics.get_bounceThresholdDelegateField();
			}
			set
			{
				Physics.set_bounceThresholdDelegateField(value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002F47 File Offset: 0x00001147
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002F53 File Offset: 0x00001153
		public static float defaultMaxDepenetrationVelocity
		{
			get
			{
				return Physics.get_defaultMaxDepenetrationVelocityDelegateField();
			}
			set
			{
				Physics.set_defaultMaxDepenetrationVelocityDelegateField(value);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002F60 File Offset: 0x00001160
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002F6C File Offset: 0x0000116C
		public static int defaultSolverIterations
		{
			get
			{
				return Physics.get_defaultSolverIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverIterationsDelegateField(value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002F79 File Offset: 0x00001179
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002F85 File Offset: 0x00001185
		public static int defaultSolverVelocityIterations
		{
			get
			{
				return Physics.get_defaultSolverVelocityIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverVelocityIterationsDelegateField(value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002F92 File Offset: 0x00001192
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002F9E File Offset: 0x0000119E
		public static float defaultMaxAngularSpeed
		{
			get
			{
				return Physics.get_defaultMaxAngularSpeedDelegateField();
			}
			set
			{
				Physics.set_defaultMaxAngularSpeedDelegateField(value);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002FAB File Offset: 0x000011AB
		public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore)
		{
			Physics.IgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ignore);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002FC4 File Offset: 0x000011C4
		public static void IgnoreCollision(Collider collider1, Collider collider2)
		{
			Physics.IgnoreCollision(collider1, collider2, true);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002FD0 File Offset: 0x000011D0
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
		{
			Physics.IgnoreLayerCollisionDelegateField(layer1, layer2, ignore);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002FDF File Offset: 0x000011DF
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			Physics.IgnoreLayerCollision(layer1, layer2, true);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002FEB File Offset: 0x000011EB
		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			return Physics.GetIgnoreLayerCollisionDelegateField(layer1, layer2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002FF9 File Offset: 0x000011F9
		public static bool GetIgnoreCollision(Collider collider1, Collider collider2)
		{
			return Physics.GetIgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008064 File Offset: 0x00006264
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008098 File Offset: 0x00006298
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
		{
			return Physics.Linecast(start, end, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000080B4 File Offset: 0x000062B4
		public static bool Linecast(Vector3 start, Vector3 end)
		{
			return Physics.Linecast(start, end, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000080D0 File Offset: 0x000062D0
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, out hitInfo, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008104 File Offset: 0x00006304
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
		{
			return Physics.Linecast(start, end, out hitInfo, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008120 File Offset: 0x00006320
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
		{
			return Physics.Linecast(start, end, out hitInfo, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008140 File Offset: 0x00006340
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000816C File Offset: 0x0000636C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000818C File Offset: 0x0000638C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000081AC File Offset: 0x000063AC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000081D0 File Offset: 0x000063D0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000081FC File Offset: 0x000063FC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008220 File Offset: 0x00006420
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008244 File Offset: 0x00006444
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000826C File Offset: 0x0000646C
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008298 File Offset: 0x00006498
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000082B8 File Offset: 0x000064B8
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000082D8 File Offset: 0x000064D8
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000082FC File Offset: 0x000064FC
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.SphereCast(ray.origin, radius, ray.direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00008328 File Offset: 0x00006528
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00008344 File Offset: 0x00006544
		public static bool SphereCast(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008364 File Offset: 0x00006564
		public static bool SphereCast(Ray ray, float radius)
		{
			return Physics.SphereCast(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008388 File Offset: 0x00006588
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCast(ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000083B4 File Offset: 0x000065B4
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000083D4 File Offset: 0x000065D4
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000083F4 File Offset: 0x000065F4
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008418 File Offset: 0x00006618
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out raycastHit, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008444 File Offset: 0x00006644
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00008464 File Offset: 0x00006664
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00008484 File Offset: 0x00006684
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000084A8 File Offset: 0x000066A8
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCast(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000084D0 File Offset: 0x000066D0
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000084FC File Offset: 0x000066FC
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008520 File Offset: 0x00006720
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00008544 File Offset: 0x00006744
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000856C File Offset: 0x0000676C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003011 File Offset: 0x00001211
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_CapsuleCastAll_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003027 File Offset: 0x00001227
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00008594 File Offset: 0x00006794
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000085B4 File Offset: 0x000067B4
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000085D4 File Offset: 0x000067D4
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00003034 File Offset: 0x00001234
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_SphereCastAll_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003048 File Offset: 0x00001248
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000085F8 File Offset: 0x000067F8
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008618 File Offset: 0x00006818
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008638 File Offset: 0x00006838
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction)
		{
			return Physics.SphereCastAll(origin, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000865C File Offset: 0x0000685C
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastAll(ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008688 File Offset: 0x00006888
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000086A4 File Offset: 0x000068A4
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000086C4 File Offset: 0x000068C4
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius)
		{
			return Physics.SphereCastAll(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003055 File Offset: 0x00001255
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000086E8 File Offset: 0x000068E8
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal(Physics.defaultPhysicsScene, point0, point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000870C File Offset: 0x0000690C
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask)
		{
			return Physics.OverlapCapsule(point0, point1, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008728 File Offset: 0x00006928
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius)
		{
			return Physics.OverlapCapsule(point0, point1, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003067 File Offset: 0x00001267
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00008744 File Offset: 0x00006944
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008764 File Offset: 0x00006964
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.OverlapSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008780 File Offset: 0x00006980
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius)
		{
			return Physics.OverlapSphere(position, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00003076 File Offset: 0x00001276
		public static void Simulate_Internal(PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_Injected(ref physicsScene, step);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000879C File Offset: 0x0000699C
		public static void Simulate(float step)
		{
			bool autoSimulation = Physics.autoSimulation;
			if (autoSimulation)
			{
				Debug.LogWarning("Physics.Simulate(...) was called but auto simulation is active. You should disable auto simulation first before calling this function therefore the simulation was not run.");
			}
			else
			{
				Physics.Simulate_Internal(Physics.defaultPhysicsScene, step);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00003080 File Offset: 0x00001280
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000308C File Offset: 0x0000128C
		public static bool autoSimulation
		{
			get
			{
				return Physics.get_autoSimulationDelegateField();
			}
			set
			{
				Physics.set_autoSimulationDelegateField(value);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00003099 File Offset: 0x00001299
		public static void SyncTransforms()
		{
			Physics.SyncTransformsDelegateField();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000030A5 File Offset: 0x000012A5
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000030B1 File Offset: 0x000012B1
		public static bool autoSyncTransforms
		{
			get
			{
				return Physics.get_autoSyncTransformsDelegateField();
			}
			set
			{
				Physics.set_autoSyncTransformsDelegateField(value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000030BE File Offset: 0x000012BE
		// (set) Token: 0x060001FE RID: 510 RVA: 0x000030CA File Offset: 0x000012CA
		public static bool reuseCollisionCallbacks
		{
			get
			{
				return Physics.get_reuseCollisionCallbacksDelegateField();
			}
			set
			{
				Physics.set_reuseCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000030D7 File Offset: 0x000012D7
		public static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_Injected(colliderA, ref positionA, ref rotationA, colliderB, ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000087D0 File Offset: 0x000069D0
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
		{
			direction = Vector3.zero;
			distance = 0f;
			return Physics.Query_ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, ref direction, ref distance);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008808 File Offset: 0x00006A08
		public static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point)
		{
			Vector3 vector;
			Physics.Query_ClosestPoint_Injected(collider, ref position, ref rotation, ref point, out vector);
			return vector;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008824 File Offset: 0x00006A24
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation)
		{
			return Physics.Query_ClosestPoint(collider, position, rotation, point);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000030F8 File Offset: 0x000012F8
		public static float interCollisionDistance
		{
			get
			{
				return Physics.get_interCollisionDistanceDelegateField();
			}
			set
			{
				Physics.set_interCollisionDistanceDelegateField(value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00003105 File Offset: 0x00001305
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00003111 File Offset: 0x00001311
		public static float interCollisionStiffness
		{
			get
			{
				return Physics.get_interCollisionStiffnessDelegateField();
			}
			set
			{
				Physics.set_interCollisionStiffnessDelegateField(value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000311E File Offset: 0x0000131E
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000312A File Offset: 0x0000132A
		public static bool interCollisionSettingsToggle
		{
			get
			{
				return Physics.get_interCollisionSettingsToggleDelegateField();
			}
			set
			{
				Physics.set_interCollisionSettingsToggleDelegateField(value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00008840 File Offset: 0x00006A40
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00003137 File Offset: 0x00001337
		public static Vector3 clothGravity
		{
			get
			{
				Vector3 vector;
				Physics.get_clothGravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_clothGravity_Injected(ref value);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008858 File Offset: 0x00006A58
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008880 File Offset: 0x00006A80
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000889C File Offset: 0x00006A9C
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003140 File Offset: 0x00001340
		public static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000088B8 File Offset: 0x00006AB8
		public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000088D8 File Offset: 0x00006AD8
		public static bool CheckSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.CheckSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000088F4 File Offset: 0x00006AF4
		public static bool CheckSphere(Vector3 position, float radius)
		{
			return Physics.CheckSphere(position, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008910 File Offset: 0x00006B10
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000893C File Offset: 0x00006B3C
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00008960 File Offset: 0x00006B60
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008984 File Offset: 0x00006B84
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000089AC File Offset: 0x00006BAC
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000089D8 File Offset: 0x00006BD8
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000089F8 File Offset: 0x00006BF8
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008A18 File Offset: 0x00006C18
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008A3C File Offset: 0x00006C3C
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastNonAlloc(ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008A68 File Offset: 0x00006C68
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008A88 File Offset: 0x00006C88
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008AA8 File Offset: 0x00006CA8
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000314F File Offset: 0x0000134F
		public static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_Injected(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00008ACC File Offset: 0x00006CCC
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal(Physics.defaultPhysicsScene, start, end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask)
		{
			return Physics.CheckCapsule(start, end, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008B0C File Offset: 0x00006D0C
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
		{
			return Physics.CheckCapsule(start, end, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003161 File Offset: 0x00001361
		public static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008B2C File Offset: 0x00006D2C
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00008B50 File Offset: 0x00006D50
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.CheckBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00008B6C File Offset: 0x00006D6C
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.CheckBox(center, halfExtents, orientation, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008B8C File Offset: 0x00006D8C
		public static bool CheckBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.CheckBox(center, halfExtents, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003174 File Offset: 0x00001374
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008BB0 File Offset: 0x00006DB0
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008BD4 File Offset: 0x00006DD4
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008BF0 File Offset: 0x00006DF0
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00008C0C File Offset: 0x00006E0C
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.OverlapBox(center, halfExtents, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00008C2C File Offset: 0x00006E2C
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapBox(center, halfExtents, results, orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008C54 File Offset: 0x00006E54
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008C74 File Offset: 0x00006E74
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00008C94 File Offset: 0x00006E94
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00008CB8 File Offset: 0x00006EB8
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00008CE4 File Offset: 0x00006EE4
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00008D0C File Offset: 0x00006F0C
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00008D30 File Offset: 0x00006F30
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008D54 File Offset: 0x00006F54
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003187 File Offset: 0x00001387
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_BoxCastAll_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000319E File Offset: 0x0000139E
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00008D7C File Offset: 0x00006F7C
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00008D9C File Offset: 0x00006F9C
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00008DBC File Offset: 0x00006FBC
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00008E08 File Offset: 0x00007008
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00008E30 File Offset: 0x00007030
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00008E50 File Offset: 0x00007050
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000031AB File Offset: 0x000013AB
		public static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_Injected(ref bounds, subdivisions);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008E70 File Offset: 0x00007070
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions)
		{
			bool flag = subdivisions < 1 || subdivisions > 16;
			if (flag)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the subdivisions to be greater than zero and less than 17.");
			}
			bool flag2 = worldBounds.extents.x <= 0f || worldBounds.extents.y <= 0f || worldBounds.extents.z <= 0f;
			if (flag2)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the world bounds to be non-empty, and have positive extents.");
			}
			Physics.Internal_RebuildBroadphaseRegions(worldBounds, subdivisions);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000031B5 File Offset: 0x000013B5
		public static void BakeMesh(int meshID, bool convex)
		{
			Physics.BakeMeshDelegateField(meshID, convex);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00008EF4 File Offset: 0x000070F4
		// (set) Token: 0x06000242 RID: 578 RVA: 0x000031C3 File Offset: 0x000013C3
		public static float minPenetrationForPenalty
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000031C6 File Offset: 0x000013C6
		public static float bounceTreshold
		{
			get
			{
				return Physics.bounceThreshold;
			}
			set
			{
				Physics.bounceThreshold = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00008F24 File Offset: 0x00007124
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000031D0 File Offset: 0x000013D0
		public static float sleepVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00008F3C File Offset: 0x0000713C
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000031D3 File Offset: 0x000013D3
		public static float sleepAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00008F54 File Offset: 0x00007154
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000031D6 File Offset: 0x000013D6
		public static float maxAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00008F6C File Offset: 0x0000716C
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000031D9 File Offset: 0x000013D9
		public static int solverIterationCount
		{
			get
			{
				return Physics.defaultSolverIterations;
			}
			set
			{
				Physics.defaultSolverIterations = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00008F84 File Offset: 0x00007184
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000031E3 File Offset: 0x000013E3
		public static int solverVelocityIterationCount
		{
			get
			{
				return Physics.defaultSolverVelocityIterations;
			}
			set
			{
				Physics.defaultSolverVelocityIterations = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00008F9C File Offset: 0x0000719C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000031ED File Offset: 0x000013ED
		public static float penetrationPenaltyForce
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000031F0 File Offset: 0x000013F0
		public static void get_gravity_Injected(out Vector3 ret)
		{
			Physics.get_gravity_InjectedDelegateField(out ret);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000031FD File Offset: 0x000013FD
		public static void set_gravity_Injected(ref Vector3 value)
		{
			Physics.set_gravity_InjectedDelegateField(ref value);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00008FB4 File Offset: 0x000071B4
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_CapsuleCastAll_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00008FE8 File Offset: 0x000071E8
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_SphereCastAll_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009018 File Offset: 0x00007218
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapCapsule_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009048 File Offset: 0x00007248
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000320A File Offset: 0x0000140A
		public static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_InjectedDelegateField(ref physicsScene, step);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009074 File Offset: 0x00007274
		public static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(colliderA), ref positionA, ref rotationA, IL2CPP.Il2CppObjectBaseToPtr(colliderB), ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00003218 File Offset: 0x00001418
		public static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret)
		{
			Physics.Query_ClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref position, ref rotation, ref point, out ret);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000322F File Offset: 0x0000142F
		public static void get_clothGravity_Injected(out Vector3 ret)
		{
			Physics.get_clothGravity_InjectedDelegateField(out ret);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000323C File Offset: 0x0000143C
		public static void set_clothGravity_Injected(ref Vector3 value)
		{
			Physics.set_clothGravity_InjectedDelegateField(ref value);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003249 File Offset: 0x00001449
		public static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000325B File Offset: 0x0000145B
		public static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000326F File Offset: 0x0000146F
		public static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000090A4 File Offset: 0x000072A4
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000090D4 File Offset: 0x000072D4
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Internal_BoxCastAll_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003283 File Offset: 0x00001483
		public static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField(ref bounds, subdivisions);
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F1 RID: 241
		public const float k_MaxFloatMinusEpsilon = 3.4028233E+38f;

		// Token: 0x040000F2 RID: 242
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x040000F3 RID: 243
		public const int DefaultRaycastLayers = -5;

		// Token: 0x040000F4 RID: 244
		public const int AllLayers = -1;

		// Token: 0x040000F5 RID: 245
		public const int kIgnoreRaycastLayer = 4;

		// Token: 0x040000F6 RID: 246
		public const int kDefaultRaycastLayers = -5;

		// Token: 0x040000F7 RID: 247
		public const int kAllLayers = -1;

		// Token: 0x040000F8 RID: 248
		private static readonly Physics.get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly Physics.set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly Physics.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly Physics.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly Physics.get_queriesHitTriggersDelegate get_queriesHitTriggersDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly Physics.set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly Physics.get_queriesHitBackfacesDelegate get_queriesHitBackfacesDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly Physics.set_queriesHitBackfacesDelegate set_queriesHitBackfacesDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly Physics.get_bounceThresholdDelegate get_bounceThresholdDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly Physics.set_bounceThresholdDelegate set_bounceThresholdDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly Physics.get_defaultMaxDepenetrationVelocityDelegate get_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly Physics.set_defaultMaxDepenetrationVelocityDelegate set_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly Physics.get_defaultSolverIterationsDelegate get_defaultSolverIterationsDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly Physics.set_defaultSolverIterationsDelegate set_defaultSolverIterationsDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly Physics.get_defaultSolverVelocityIterationsDelegate get_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly Physics.set_defaultSolverVelocityIterationsDelegate set_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly Physics.get_defaultMaxAngularSpeedDelegate get_defaultMaxAngularSpeedDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly Physics.set_defaultMaxAngularSpeedDelegate set_defaultMaxAngularSpeedDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly Physics.IgnoreCollisionDelegate IgnoreCollisionDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly Physics.IgnoreLayerCollisionDelegate IgnoreLayerCollisionDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly Physics.GetIgnoreLayerCollisionDelegate GetIgnoreLayerCollisionDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly Physics.GetIgnoreCollisionDelegate GetIgnoreCollisionDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly Physics.get_autoSimulationDelegate get_autoSimulationDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly Physics.set_autoSimulationDelegate set_autoSimulationDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly Physics.SyncTransformsDelegate SyncTransformsDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly Physics.get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly Physics.set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly Physics.get_reuseCollisionCallbacksDelegate get_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly Physics.set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly Physics.get_interCollisionDistanceDelegate get_interCollisionDistanceDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly Physics.set_interCollisionDistanceDelegate set_interCollisionDistanceDelegateField;

		// Token: 0x04000117 RID: 279
		private static readonly Physics.get_interCollisionStiffnessDelegate get_interCollisionStiffnessDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly Physics.set_interCollisionStiffnessDelegate set_interCollisionStiffnessDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly Physics.get_interCollisionSettingsToggleDelegate get_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly Physics.set_interCollisionSettingsToggleDelegate set_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly Physics.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly Physics.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

		// Token: 0x0400011D RID: 285
		private static readonly Physics.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

		// Token: 0x0400011E RID: 286
		private static readonly Physics.Query_CapsuleCastAll_InjectedDelegate Query_CapsuleCastAll_InjectedDelegateField;

		// Token: 0x0400011F RID: 287
		private static readonly Physics.Query_SphereCastAll_InjectedDelegate Query_SphereCastAll_InjectedDelegateField;

		// Token: 0x04000120 RID: 288
		private static readonly Physics.OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly Physics.OverlapSphere_Internal_InjectedDelegate OverlapSphere_Internal_InjectedDelegateField;

		// Token: 0x04000122 RID: 290
		private static readonly Physics.Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

		// Token: 0x04000123 RID: 291
		private static readonly Physics.Query_ComputePenetration_InjectedDelegate Query_ComputePenetration_InjectedDelegateField;

		// Token: 0x04000124 RID: 292
		private static readonly Physics.Query_ClosestPoint_InjectedDelegate Query_ClosestPoint_InjectedDelegateField;

		// Token: 0x04000125 RID: 293
		private static readonly Physics.get_clothGravity_InjectedDelegate get_clothGravity_InjectedDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly Physics.set_clothGravity_InjectedDelegate set_clothGravity_InjectedDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly Physics.CheckSphere_Internal_InjectedDelegate CheckSphere_Internal_InjectedDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly Physics.CheckCapsule_Internal_InjectedDelegate CheckCapsule_Internal_InjectedDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly Physics.CheckBox_Internal_InjectedDelegate CheckBox_Internal_InjectedDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly Physics.OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly Physics.Internal_BoxCastAll_InjectedDelegate Internal_BoxCastAll_InjectedDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate Internal_RebuildBroadphaseRegions_InjectedDelegateField;

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000487 RID: 1159
		private delegate float get_defaultContactOffsetDelegate();

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000489 RID: 1161
		private delegate void set_defaultContactOffsetDelegate(float value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600048B RID: 1163
		private delegate float get_sleepThresholdDelegate();

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x0600048D RID: 1165
		private delegate void set_sleepThresholdDelegate(float value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600048F RID: 1167
		private delegate bool get_queriesHitTriggersDelegate();

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000491 RID: 1169
		private delegate void set_queriesHitTriggersDelegate(bool value);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000493 RID: 1171
		private delegate bool get_queriesHitBackfacesDelegate();

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000495 RID: 1173
		private delegate void set_queriesHitBackfacesDelegate(bool value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000497 RID: 1175
		private delegate float get_bounceThresholdDelegate();

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000499 RID: 1177
		private delegate void set_bounceThresholdDelegate(float value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x0600049B RID: 1179
		private delegate float get_defaultMaxDepenetrationVelocityDelegate();

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x0600049D RID: 1181
		private delegate void set_defaultMaxDepenetrationVelocityDelegate(float value);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x0600049F RID: 1183
		private delegate int get_defaultSolverIterationsDelegate();

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060004A1 RID: 1185
		private delegate void set_defaultSolverIterationsDelegate(int value);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x060004A3 RID: 1187
		private delegate int get_defaultSolverVelocityIterationsDelegate();

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x060004A5 RID: 1189
		private delegate void set_defaultSolverVelocityIterationsDelegate(int value);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x060004A7 RID: 1191
		private delegate float get_defaultMaxAngularSpeedDelegate();

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x060004A9 RID: 1193
		private delegate void set_defaultMaxAngularSpeedDelegate(float value);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x060004AB RID: 1195
		private delegate void IgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2, bool ignore);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x060004AD RID: 1197
		private delegate void IgnoreLayerCollisionDelegate(int layer1, int layer2, bool ignore);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x060004AF RID: 1199
		private delegate bool GetIgnoreLayerCollisionDelegate(int layer1, int layer2);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x060004B1 RID: 1201
		private delegate bool GetIgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x060004B3 RID: 1203
		private delegate bool get_autoSimulationDelegate();

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x060004B5 RID: 1205
		private delegate void set_autoSimulationDelegate(bool value);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x060004B7 RID: 1207
		private delegate void SyncTransformsDelegate();

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x060004B9 RID: 1209
		private delegate bool get_autoSyncTransformsDelegate();

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x060004BB RID: 1211
		private delegate void set_autoSyncTransformsDelegate(bool value);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x060004BD RID: 1213
		private delegate bool get_reuseCollisionCallbacksDelegate();

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x060004BF RID: 1215
		private delegate void set_reuseCollisionCallbacksDelegate(bool value);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x060004C1 RID: 1217
		private delegate float get_interCollisionDistanceDelegate();

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x060004C3 RID: 1219
		private delegate void set_interCollisionDistanceDelegate(float value);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x060004C5 RID: 1221
		private delegate float get_interCollisionStiffnessDelegate();

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x060004C7 RID: 1223
		private delegate void set_interCollisionStiffnessDelegate(float value);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x060004C9 RID: 1225
		private delegate bool get_interCollisionSettingsToggleDelegate();

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x060004CB RID: 1227
		private delegate void set_interCollisionSettingsToggleDelegate(bool value);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x060004CD RID: 1229
		private delegate void BakeMeshDelegate(int meshID, bool convex);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x060004CF RID: 1231
		private delegate void get_gravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x060004D1 RID: 1233
		private delegate void set_gravity_InjectedDelegate(IntPtr value);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060004D3 RID: 1235
		private delegate IntPtr Query_CapsuleCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x060004D5 RID: 1237
		private delegate IntPtr Query_SphereCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060004D7 RID: 1239
		private delegate IntPtr OverlapCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x060004D9 RID: 1241
		private delegate IntPtr OverlapSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060004DB RID: 1243
		private delegate void Simulate_Internal_InjectedDelegate(IntPtr physicsScene, float step);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060004DD RID: 1245
		private delegate bool Query_ComputePenetration_InjectedDelegate(IntPtr colliderA, IntPtr positionA, IntPtr rotationA, IntPtr colliderB, IntPtr positionB, IntPtr rotationB, IntPtr direction, IntPtr distance);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060004DF RID: 1247
		private delegate void Query_ClosestPoint_InjectedDelegate(IntPtr collider, IntPtr position, IntPtr rotation, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x060004E1 RID: 1249
		private delegate void get_clothGravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x060004E3 RID: 1251
		private delegate void set_clothGravity_InjectedDelegate(IntPtr value);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060004E5 RID: 1253
		private delegate bool CheckSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060004E7 RID: 1255
		private delegate bool CheckCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060004E9 RID: 1257
		private delegate bool CheckBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060004EB RID: 1259
		private delegate IntPtr OverlapBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060004ED RID: 1261
		private delegate IntPtr Internal_BoxCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060004EF RID: 1263
		private delegate void Internal_RebuildBroadphaseRegions_InjectedDelegate(IntPtr bounds, int subdivisions);
	}
}
