using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct PhysicsScene
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00005F64 File Offset: 0x00004164
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsScene()
		{
			Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "PhysicsScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr);
			PhysicsScene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, "m_Handle");
			PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663310);
			PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663311);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663312);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663313);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663314);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663315);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663316);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663317);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663318);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663319);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663320);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663321);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663322);
			PhysicsScene.IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsValid_Internal_Injected");
			PhysicsScene.IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsEmpty_Internal_Injected");
			PhysicsScene.Query_CapsuleCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_CapsuleCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_CapsuleCast_Injected");
			PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected");
			PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected");
			PhysicsScene.Query_SphereCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_SphereCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_SphereCast_Injected");
			PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected");
			PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected");
			PhysicsScene.Query_BoxCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_BoxCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_BoxCast_Injected");
			PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected");
			PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006154 File Offset: 0x00004354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90402, XrefRangeEnd = 90412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006180 File Offset: 0x00004380
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000061B0 File Offset: 0x000043B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90412, XrefRangeEnd = 90415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000061F4 File Offset: 0x000043F4
		[CallerCount(0)]
		public unsafe bool Equals(PhysicsScene other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006234 File Offset: 0x00004434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90415, XrefRangeEnd = 90420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000062AC File Offset: 0x000044AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90420, XrefRangeEnd = 90422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006324 File Offset: 0x00004524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90422, XrefRangeEnd = 90427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000063A8 File Offset: 0x000045A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90427, XrefRangeEnd = 90429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000642C File Offset: 0x0000462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90429, XrefRangeEnd = 90435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000064B4 File Offset: 0x000046B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90435, XrefRangeEnd = 90437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000653C File Offset: 0x0000473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90437, XrefRangeEnd = 90439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000065B4 File Offset: 0x000047B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90439, XrefRangeEnd = 90441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006638 File Offset: 0x00004838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90441, XrefRangeEnd = 90443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002DC6 File Offset: 0x00000FC6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, ref this));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000066C0 File Offset: 0x000048C0
		public static bool operator ==(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle == rhs.m_Handle;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000066E0 File Offset: 0x000048E0
		public static bool operator !=(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle != rhs.m_Handle;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006704 File Offset: 0x00004904
		public bool IsValid()
		{
			return PhysicsScene.IsValid_Internal(this);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002DD8 File Offset: 0x00000FD8
		public static bool IsValid_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_Injected(ref physicsScene);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006724 File Offset: 0x00004924
		public bool IsEmpty()
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return PhysicsScene.IsEmpty_Internal(this);
			}
			throw new InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public static bool IsEmpty_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_Injected(ref physicsScene);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006758 File Offset: 0x00004958
		public void Simulate(float step)
		{
			bool flag = this.IsValid();
			if (flag)
			{
				bool flag2 = this == Physics.defaultPhysicsScene && Physics.autoSimulation;
				if (flag2)
				{
					Debug.LogWarning("PhysicsScene.Simulate(...) was called but auto simulation is active. You should disable auto simulation first before calling this function therefore the simulation was not run.");
				}
				else
				{
					Physics.Simulate_Internal(this, step);
				}
				return;
			}
			throw new InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000067B8 File Offset: 0x000049B8
		public static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_Injected(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000067DC File Offset: 0x000049DC
		public static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_CapsuleCast(physicsScene, point1, point2, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000682C File Offset: 0x00004A2C
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCast(this, point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006858 File Offset: 0x00004A58
		public static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000687C File Offset: 0x00004A7C
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_CapsuleCastNonAlloc(this, point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002DEA File Offset: 0x00000FEA
		public static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000068C0 File Offset: 0x00004AC0
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal(this, point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002DFE File Offset: 0x00000FFE
		public static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000068E8 File Offset: 0x00004AE8
		public static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_SphereCast(physicsScene, origin, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006934 File Offset: 0x00004B34
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCast(this, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002E14 File Offset: 0x00001014
		public static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_Injected(ref physicsScene, ref origin, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000695C File Offset: 0x00004B5C
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_SphereCastNonAlloc(this, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002E2A File Offset: 0x0000102A
		public static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_Injected(ref physicsScene, ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000069A0 File Offset: 0x00004BA0
		public int OverlapSphere(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal(this, position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000069C4 File Offset: 0x00004BC4
		public static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000069E8 File Offset: 0x00004BE8
		public static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_BoxCast(physicsScene, center, halfExtents, vector, orientation, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006A38 File Offset: 0x00004C38
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006A64 File Offset: 0x00004C64
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, Quaternion.identity, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002E3B File Offset: 0x0000103B
		public static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_Injected(ref physicsScene, ref center, ref halfExtents, results, ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006A94 File Offset: 0x00004C94
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006ABC File Offset: 0x00004CBC
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00006AE4 File Offset: 0x00004CE4
		public static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, raycastHits, ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00006B08 File Offset: 0x00004D08
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_BoxCastNonAlloc(this, center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006B4C File Offset: 0x00004D4C
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return this.BoxCast(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002E4F File Offset: 0x0000104F
		public static bool IsValid_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002E5C File Offset: 0x0000105C
		public static bool IsEmpty_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006B78 File Offset: 0x00004D78
		public static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_InjectedDelegateField(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002E69 File Offset: 0x00001069
		public static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006BCC File Offset: 0x00004DCC
		public static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002E84 File Offset: 0x00001084
		public static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006C18 File Offset: 0x00004E18
		public static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002E9D File Offset: 0x0000109D
		public static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Il2CppReferenceArray<Collider> results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, IL2CPP.Il2CppObjectBaseToPtr(results), ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006C40 File Offset: 0x00004E40
		public static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x040000C2 RID: 194
		private static readonly PhysicsScene.IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly PhysicsScene.IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly PhysicsScene.Query_CapsuleCast_InjectedDelegate Query_CapsuleCast_InjectedDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate Internal_CapsuleCastNonAlloc_InjectedDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate OverlapCapsuleNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly PhysicsScene.Query_SphereCast_InjectedDelegate Query_SphereCast_InjectedDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate Internal_SphereCastNonAlloc_InjectedDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate OverlapSphereNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly PhysicsScene.Query_BoxCast_InjectedDelegate Query_BoxCast_InjectedDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate OverlapBoxNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate Internal_BoxCastNonAlloc_InjectedDelegateField;

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000471 RID: 1137
		private delegate bool IsValid_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000473 RID: 1139
		private delegate bool IsEmpty_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000475 RID: 1141
		private delegate bool Query_CapsuleCast_InjectedDelegate(IntPtr physicsScene, IntPtr point1, IntPtr point2, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000477 RID: 1143
		private delegate int Internal_CapsuleCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000479 RID: 1145
		private delegate int OverlapCapsuleNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600047B RID: 1147
		private delegate bool Query_SphereCast_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x0600047D RID: 1149
		private delegate int Internal_SphereCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x0600047F RID: 1151
		private delegate int OverlapSphereNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000481 RID: 1153
		private delegate bool Query_BoxCast_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, IntPtr outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000483 RID: 1155
		private delegate int OverlapBoxNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr results, IntPtr orientation, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000485 RID: 1157
		private delegate int Internal_BoxCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr raycastHits, IntPtr orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);
	}
}
