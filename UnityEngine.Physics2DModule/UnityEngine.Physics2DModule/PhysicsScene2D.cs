using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[StructLayout(2)]
	public struct PhysicsScene2D
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004864 File Offset: 0x00002A64
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsScene2D()
		{
			Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PhysicsScene2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr);
			PhysicsScene2D.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, "m_Handle");
			PhysicsScene2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663297);
			PhysicsScene2D.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663298);
			PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663299);
			PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663300);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663301);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663302);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663303);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663304);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663305);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663306);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663307);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663308);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663309);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663310);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663311);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663312);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663313);
			PhysicsScene2D.IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsValid_Internal_Injected");
			PhysicsScene2D.IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsEmpty_Internal_Injected");
			PhysicsScene2D.Linecast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.Linecast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::Linecast_Internal_Injected");
			PhysicsScene2D.LinecastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.LinecastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastArray_Internal_Injected");
			PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastNonAllocList_Internal_Injected");
			PhysicsScene2D.CircleCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CircleCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCast_Internal_Injected");
			PhysicsScene2D.CircleCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CircleCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCastArray_Internal_Injected");
			PhysicsScene2D.CircleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CircleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCastList_Internal_Injected");
			PhysicsScene2D.BoxCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCast_Internal_Injected");
			PhysicsScene2D.BoxCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastArray_Internal_Injected");
			PhysicsScene2D.BoxCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastList_Internal_Injected");
			PhysicsScene2D.CapsuleCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCast_Internal_Injected");
			PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastArray_Internal_Injected");
			PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastList_Internal_Injected");
			PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::GetRayIntersection_Internal_Injected");
			PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::GetRayIntersectionList_Internal_Injected");
			PhysicsScene2D.OverlapPoint_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapPoint_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPoint_Internal_Injected");
			PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointArray_Internal_Injected");
			PhysicsScene2D.OverlapPointList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapPointList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointList_Internal_Injected");
			PhysicsScene2D.OverlapCircle_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCircle_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircle_Internal_Injected");
			PhysicsScene2D.OverlapCircleArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCircleArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircleArray_Internal_Injected");
			PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircleList_Internal_Injected");
			PhysicsScene2D.OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapBox_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBox_Internal_Injected");
			PhysicsScene2D.OverlapBoxArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapBoxArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBoxArray_Internal_Injected");
			PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBoxList_Internal_Injected");
			PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsule_Internal_Injected");
			PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleArray_Internal_Injected");
			PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleList_Internal_Injected");
			PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderArray_Internal_Injected");
			PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderList_Internal_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88663, XrefRangeEnd = 88673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00004BEC File Offset: 0x00002DEC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00004C1C File Offset: 0x00002E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88673, XrefRangeEnd = 88676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(0)]
		public unsafe bool Equals(PhysicsScene2D other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88679, RefRangeEnd = 88680, XrefRangeStart = 88676, XrefRangeEnd = 88679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00004D08 File Offset: 0x00002F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88680, XrefRangeEnd = 88682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00004D70 File Offset: 0x00002F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88682, XrefRangeEnd = 88684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88684, XrefRangeEnd = 88686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00004E64 File Offset: 0x00003064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88686, XrefRangeEnd = 88688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00004EEC File Offset: 0x000030EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88688, XrefRangeEnd = 88690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004F68 File Offset: 0x00003168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88690, XrefRangeEnd = 88692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004FF0 File Offset: 0x000031F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88692, XrefRangeEnd = 88696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRayIntersection(Ray ray, float distance, Il2CppStructArray<RaycastHit2D> results, int layerMask = -5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000505C File Offset: 0x0000325C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88696, XrefRangeEnd = 88698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000050E4 File Offset: 0x000032E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88698, XrefRangeEnd = 88700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00005160 File Offset: 0x00003360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88700, XrefRangeEnd = 88702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000051EC File Offset: 0x000033EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88702, XrefRangeEnd = 88704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005278 File Offset: 0x00003478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88704, XrefRangeEnd = 88706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, ref this));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005300 File Offset: 0x00003500
		public static bool operator ==(PhysicsScene2D lhs, PhysicsScene2D rhs)
		{
			return lhs.m_Handle == rhs.m_Handle;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005320 File Offset: 0x00003520
		public static bool operator !=(PhysicsScene2D lhs, PhysicsScene2D rhs)
		{
			return lhs.m_Handle != rhs.m_Handle;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005344 File Offset: 0x00003544
		public bool IsValid()
		{
			return PhysicsScene2D.IsValid_Internal(this);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002062 File Offset: 0x00000262
		public static bool IsValid_Internal(PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsValid_Internal_Injected(ref physicsScene);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005364 File Offset: 0x00003564
		public bool IsEmpty()
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return PhysicsScene2D.IsEmpty_Internal(this);
			}
			throw new InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000206B File Offset: 0x0000026B
		public static bool IsEmpty_Internal(PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsEmpty_Internal_Injected(ref physicsScene);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005398 File Offset: 0x00003598
		public bool Simulate(float step)
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return Physics2D.Simulate_Internal(this, step);
			}
			throw new InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000053CC File Offset: 0x000035CC
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.Linecast_Internal(this, start, end, contactFilter2D);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005400 File Offset: 0x00003600
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.Linecast_Internal(this, start, end, contactFilter);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005420 File Offset: 0x00003620
		public static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.Linecast_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005440 File Offset: 0x00003640
		public int Linecast(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.LinecastArray_Internal(this, start, end, contactFilter2D, results);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005474 File Offset: 0x00003674
		public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal(this, start, end, contactFilter, results);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002074 File Offset: 0x00000274
		public static int LinecastArray_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, results);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005498 File Offset: 0x00003698
		public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal(this, start, end, contactFilter, results);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002085 File Offset: 0x00000285
		public static int LinecastNonAllocList_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, results);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000054BC File Offset: 0x000036BC
		public int Raycast(Vector2 origin, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.RaycastArray_Internal(this, origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000054F4 File Offset: 0x000036F4
		public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CircleCast_Internal(this, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000552C File Offset: 0x0000372C
		public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.CircleCast_Internal(this, origin, radius, direction, distance, contactFilter);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005550 File Offset: 0x00003750
		public static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.CircleCast_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005570 File Offset: 0x00003770
		public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CircleCastArray_Internal(this, origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000055A8 File Offset: 0x000037A8
		public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastArray_Internal(this, origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002096 File Offset: 0x00000296
		public static int CircleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastArray_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000055D0 File Offset: 0x000037D0
		public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal(this, origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020AA File Offset: 0x000002AA
		public static int CircleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000055F8 File Offset: 0x000037F8
		public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005630 File Offset: 0x00003830
		public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005658 File Offset: 0x00003858
		public static RaycastHit2D BoxCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.BoxCast_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000567C File Offset: 0x0000387C
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000056B8 File Offset: 0x000038B8
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020BE File Offset: 0x000002BE
		public static int BoxCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000056E0 File Offset: 0x000038E0
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020D4 File Offset: 0x000002D4
		public static int BoxCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005708 File Offset: 0x00003908
		public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005744 File Offset: 0x00003944
		public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000576C File Offset: 0x0000396C
		public static RaycastHit2D CapsuleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.CapsuleCast_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005790 File Offset: 0x00003990
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000057CC File Offset: 0x000039CC
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000057F8 File Offset: 0x000039F8
		public static int CapsuleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000581C File Offset: 0x00003A1C
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005848 File Offset: 0x00003A48
		public static int CapsuleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000586C File Offset: 0x00003A6C
		public RaycastHit2D GetRayIntersection(Ray ray, float distance, [Optional] int layerMask)
		{
			return PhysicsScene2D.GetRayIntersection_Internal(this, ray.origin, ray.direction, distance, layerMask);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000589C File Offset: 0x00003A9C
		public static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.GetRayIntersection_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, layerMask, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020EA File Offset: 0x000002EA
		public static int GetRayIntersectionList_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.GetRayIntersectionList_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, layerMask, results);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000058BC File Offset: 0x00003ABC
		public Collider2D OverlapPoint(Vector2 point, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapPoint_Internal(this, point, contactFilter2D);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000058EC File Offset: 0x00003AEC
		public Collider2D OverlapPoint(Vector2 point, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapPoint_Internal(this, point, contactFilter);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020FC File Offset: 0x000002FC
		public static Collider2D OverlapPoint_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapPoint_Internal_Injected(ref physicsScene, ref point, ref contactFilter);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000590C File Offset: 0x00003B0C
		public int OverlapPoint(Vector2 point, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapPointArray_Internal(this, point, contactFilter2D, results);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005940 File Offset: 0x00003B40
		public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal(this, point, contactFilter, results);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002109 File Offset: 0x00000309
		public static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005960 File Offset: 0x00003B60
		public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal(this, point, contactFilter, results);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002117 File Offset: 0x00000317
		public static int OverlapPointList_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005980 File Offset: 0x00003B80
		public Collider2D OverlapCircle(Vector2 point, float radius, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCircle_Internal(this, point, radius, contactFilter2D);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000059B4 File Offset: 0x00003BB4
		public Collider2D OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCircle_Internal(this, point, radius, contactFilter);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002125 File Offset: 0x00000325
		public static Collider2D OverlapCircle_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCircle_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000059D4 File Offset: 0x00003BD4
		public int OverlapCircle(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCircleArray_Internal(this, point, radius, contactFilter2D, results);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005A08 File Offset: 0x00003C08
		public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleArray_Internal(this, point, radius, contactFilter, results);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002133 File Offset: 0x00000333
		public static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleArray_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter, results);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005A2C File Offset: 0x00003C2C
		public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal(this, point, radius, contactFilter, results);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002143 File Offset: 0x00000343
		public static int OverlapCircleList_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter, results);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005A50 File Offset: 0x00003C50
		public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapBox_Internal(this, point, size, angle, contactFilter2D);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005A84 File Offset: 0x00003C84
		public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapBox_Internal(this, point, size, angle, contactFilter);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002153 File Offset: 0x00000353
		public static Collider2D OverlapBox_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapBox_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public int OverlapBox(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapBoxArray_Internal(this, point, size, angle, contactFilter2D, results);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxArray_Internal(this, point, size, angle, contactFilter, results);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002163 File Offset: 0x00000363
		public static int OverlapBoxArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxArray_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter, results);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005B04 File Offset: 0x00003D04
		public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal(this, point, size, angle, contactFilter, results);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002175 File Offset: 0x00000375
		public static int OverlapBoxList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter, results);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005B28 File Offset: 0x00003D28
		public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005B54 File Offset: 0x00003D54
		public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005B70 File Offset: 0x00003D70
		public Collider2D OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return this.OverlapBox(vector, vector2, 0f, contactFilter);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public int OverlapArea(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005C00 File Offset: 0x00003E00
		public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter, results);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005C20 File Offset: 0x00003E20
		public int OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return this.OverlapBox(vector, vector2, 0f, contactFilter, results);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005C80 File Offset: 0x00003E80
		public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapAreaToBoxList_Internal(pointA, pointB, contactFilter, results);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005CA0 File Offset: 0x00003EA0
		public int OverlapAreaToBoxList_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return this.OverlapBox(vector, vector2, 0f, contactFilter, results);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005D00 File Offset: 0x00003F00
		public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005D38 File Offset: 0x00003F38
		public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002187 File Offset: 0x00000387
		public static Collider2D OverlapCapsule_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCapsule_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005D5C File Offset: 0x00003F5C
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005D94 File Offset: 0x00003F94
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002199 File Offset: 0x00000399
		public static int OverlapCapsuleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005DBC File Offset: 0x00003FBC
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal(this, point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000021AD File Offset: 0x000003AD
		public static int OverlapCapsuleList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public static int OverlapCollider(Collider2D collider, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapColliderArray_Internal(collider, contactFilter2D, results);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005E10 File Offset: 0x00004010
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal(collider, contactFilter, results);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000021C1 File Offset: 0x000003C1
		public static int OverlapColliderArray_Internal(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005E2C File Offset: 0x0000402C
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal(collider, contactFilter, results);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000021CC File Offset: 0x000003CC
		public static int OverlapColliderList_Internal(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000021D7 File Offset: 0x000003D7
		public static bool IsValid_Internal_Injected(ref PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsValid_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000021E4 File Offset: 0x000003E4
		public static bool IsEmpty_Internal_Injected(ref PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsEmpty_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000021F1 File Offset: 0x000003F1
		public static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.Linecast_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, out ret);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002203 File Offset: 0x00000403
		public static int LinecastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000221A File Offset: 0x0000041A
		public static int LinecastNonAllocList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002231 File Offset: 0x00000431
		public static void CircleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.CircleCast_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, out ret);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002247 File Offset: 0x00000447
		public static int CircleCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastArray_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002262 File Offset: 0x00000462
		public static int CircleCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005E48 File Offset: 0x00004048
		public static void BoxCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.BoxCast_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out ret);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005E6C File Offset: 0x0000406C
		public static int BoxCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005E94 File Offset: 0x00004094
		public static int BoxCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005EBC File Offset: 0x000040BC
		public static void CapsuleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.CapsuleCast_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out ret);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005EE4 File Offset: 0x000040E4
		public static int CapsuleCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005F10 File Offset: 0x00004110
		public static int CapsuleCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000227D File Offset: 0x0000047D
		public static void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret)
		{
			PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, layerMask, out ret);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002291 File Offset: 0x00000491
		public static int GetRayIntersectionList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, layerMask, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005F3C File Offset: 0x0000413C
		public static Collider2D OverlapPoint_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = PhysicsScene2D.OverlapPoint_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000022AA File Offset: 0x000004AA
		public static int OverlapPointArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022BF File Offset: 0x000004BF
		public static int OverlapPointList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005F68 File Offset: 0x00004168
		public static Collider2D OverlapCircle_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = PhysicsScene2D.OverlapCircle_Internal_InjectedDelegateField(ref physicsScene, ref point, radius, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000022D4 File Offset: 0x000004D4
		public static int OverlapCircleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleArray_Internal_InjectedDelegateField(ref physicsScene, ref point, radius, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000022EB File Offset: 0x000004EB
		public static int OverlapCircleList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegateField(ref physicsScene, ref point, radius, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005F94 File Offset: 0x00004194
		public static Collider2D OverlapBox_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = PhysicsScene2D.OverlapBox_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002302 File Offset: 0x00000502
		public static int OverlapBoxArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxArray_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000231B File Offset: 0x0000051B
		public static int OverlapBoxList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005FC0 File Offset: 0x000041C0
		public static Collider2D OverlapCapsule_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002334 File Offset: 0x00000534
		public static int OverlapCapsuleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000234F File Offset: 0x0000054F
		public static int OverlapCapsuleList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000236A File Offset: 0x0000056A
		public static int OverlapColliderArray_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002383 File Offset: 0x00000583
		public static int OverlapColliderList_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000013 RID: 19
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x04000014 RID: 20
		private static readonly PhysicsScene2D.IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly PhysicsScene2D.IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly PhysicsScene2D.Linecast_Internal_InjectedDelegate Linecast_Internal_InjectedDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly PhysicsScene2D.LinecastArray_Internal_InjectedDelegate LinecastArray_Internal_InjectedDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegate LinecastNonAllocList_Internal_InjectedDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly PhysicsScene2D.CircleCast_Internal_InjectedDelegate CircleCast_Internal_InjectedDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly PhysicsScene2D.CircleCastArray_Internal_InjectedDelegate CircleCastArray_Internal_InjectedDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly PhysicsScene2D.CircleCastList_Internal_InjectedDelegate CircleCastList_Internal_InjectedDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly PhysicsScene2D.BoxCast_Internal_InjectedDelegate BoxCast_Internal_InjectedDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly PhysicsScene2D.BoxCastArray_Internal_InjectedDelegate BoxCastArray_Internal_InjectedDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly PhysicsScene2D.BoxCastList_Internal_InjectedDelegate BoxCastList_Internal_InjectedDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly PhysicsScene2D.CapsuleCast_Internal_InjectedDelegate CapsuleCast_Internal_InjectedDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegate CapsuleCastArray_Internal_InjectedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegate CapsuleCastList_Internal_InjectedDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegate GetRayIntersection_Internal_InjectedDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegate GetRayIntersectionList_Internal_InjectedDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly PhysicsScene2D.OverlapPoint_Internal_InjectedDelegate OverlapPoint_Internal_InjectedDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegate OverlapPointArray_Internal_InjectedDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly PhysicsScene2D.OverlapPointList_Internal_InjectedDelegate OverlapPointList_Internal_InjectedDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly PhysicsScene2D.OverlapCircle_Internal_InjectedDelegate OverlapCircle_Internal_InjectedDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly PhysicsScene2D.OverlapCircleArray_Internal_InjectedDelegate OverlapCircleArray_Internal_InjectedDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegate OverlapCircleList_Internal_InjectedDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly PhysicsScene2D.OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly PhysicsScene2D.OverlapBoxArray_Internal_InjectedDelegate OverlapBoxArray_Internal_InjectedDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegate OverlapBoxList_Internal_InjectedDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegate OverlapCapsuleArray_Internal_InjectedDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegate OverlapCapsuleList_Internal_InjectedDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegate OverlapColliderArray_Internal_InjectedDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegate OverlapColliderList_Internal_InjectedDelegateField;

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000430 RID: 1072
		private delegate bool IsValid_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000432 RID: 1074
		private delegate bool IsEmpty_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000434 RID: 1076
		private delegate void Linecast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000436 RID: 1078
		private delegate int LinecastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000438 RID: 1080
		private delegate int LinecastNonAllocList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600043A RID: 1082
		private delegate void CircleCast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600043C RID: 1084
		private delegate int CircleCastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600043E RID: 1086
		private delegate int CircleCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000440 RID: 1088
		private delegate void BoxCast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000442 RID: 1090
		private delegate int BoxCastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000444 RID: 1092
		private delegate int BoxCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000446 RID: 1094
		private delegate void CapsuleCast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000448 RID: 1096
		private delegate int CapsuleCastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x0600044A RID: 1098
		private delegate int CapsuleCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600044C RID: 1100
		private delegate void GetRayIntersection_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, int layerMask, [Out] IntPtr ret);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600044E RID: 1102
		private delegate int GetRayIntersectionList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, int layerMask, IntPtr results);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000450 RID: 1104
		private delegate IntPtr OverlapPoint_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000452 RID: 1106
		private delegate int OverlapPointArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000454 RID: 1108
		private delegate int OverlapPointList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000456 RID: 1110
		private delegate IntPtr OverlapCircle_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, float radius, IntPtr contactFilter);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000458 RID: 1112
		private delegate int OverlapCircleArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, float radius, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600045A RID: 1114
		private delegate int OverlapCircleList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, float radius, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600045C RID: 1116
		private delegate IntPtr OverlapBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, float angle, IntPtr contactFilter);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600045E RID: 1118
		private delegate int OverlapBoxArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000460 RID: 1120
		private delegate int OverlapBoxList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000462 RID: 1122
		private delegate IntPtr OverlapCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000464 RID: 1124
		private delegate int OverlapCapsuleArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000466 RID: 1126
		private delegate int OverlapCapsuleList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000468 RID: 1128
		private delegate int OverlapColliderArray_Internal_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x0600046A RID: 1130
		private delegate int OverlapColliderList_Internal_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);
	}
}
