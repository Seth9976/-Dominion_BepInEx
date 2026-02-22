using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x020000DE RID: 222
	public class Transform : Component
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x0004ABFC File Offset: 0x00048DFC
		// Note: this type is marked as 'beforefieldinit'.
		static Transform()
		{
			Il2CppClassPointerStore<Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform>.NativeClassPtr);
			Transform.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664634);
			Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664635);
			Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664636);
			Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664637);
			Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664638);
			Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664639);
			Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664640);
			Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664641);
			Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664642);
			Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664643);
			Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664644);
			Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664645);
			Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664646);
			Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664647);
			Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664648);
			Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664649);
			Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664650);
			Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664651);
			Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664652);
			Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664653);
			Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664654);
			Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664655);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664656);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664657);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664658);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664659);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664660);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664661);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664662);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664663);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664664);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664665);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664666);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664667);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664668);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664669);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664670);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664671);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664672);
			Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664673);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664674);
			Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664675);
			Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664676);
			Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664677);
			Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664678);
			Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664679);
			Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664680);
			Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664681);
			Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664682);
			Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664683);
			Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664684);
			Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664685);
			Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664686);
			Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664687);
			Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664688);
			Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664689);
			Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664690);
			Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664691);
			Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664692);
			Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664693);
			Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664694);
			Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664695);
			Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664696);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664697);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664698);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664699);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664700);
			Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664701);
			Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664702);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664703);
			Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100664704);
			Transform.GetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.GetRotationOrderInternalDelegate>("UnityEngine.Transform::GetRotationOrderInternal");
			Transform.SetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.SetRotationOrderInternalDelegate>("UnityEngine.Transform::SetRotationOrderInternal");
			Transform.GetRootDelegateField = IL2CPP.ResolveICall<Transform.GetRootDelegate>("UnityEngine.Transform::GetRoot");
			Transform.DetachChildrenDelegateField = IL2CPP.ResolveICall<Transform.DetachChildrenDelegate>("UnityEngine.Transform::DetachChildren");
			Transform.MoveAfterSiblingDelegateField = IL2CPP.ResolveICall<Transform.MoveAfterSiblingDelegate>("UnityEngine.Transform::MoveAfterSibling");
			Transform.SendTransformChangedScaleDelegateField = IL2CPP.ResolveICall<Transform.SendTransformChangedScaleDelegate>("UnityEngine.Transform::SendTransformChangedScale");
			Transform.get_hasChangedDelegateField = IL2CPP.ResolveICall<Transform.get_hasChangedDelegate>("UnityEngine.Transform::get_hasChanged");
			Transform.GetChildCountDelegateField = IL2CPP.ResolveICall<Transform.GetChildCountDelegate>("UnityEngine.Transform::GetChildCount");
			Transform.internal_getHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCapacityDelegate>("UnityEngine.Transform::internal_getHierarchyCapacity");
			Transform.internal_setHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_setHierarchyCapacityDelegate>("UnityEngine.Transform::internal_setHierarchyCapacity");
			Transform.internal_getHierarchyCountDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCountDelegate>("UnityEngine.Transform::internal_getHierarchyCount");
			Transform.IsNonUniformScaleTransformDelegateField = IL2CPP.ResolveICall<Transform.IsNonUniformScaleTransformDelegate>("UnityEngine.Transform::IsNonUniformScaleTransform");
			Transform.GetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.GetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::GetLocalEulerAngles_Injected");
			Transform.SetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerAngles_Injected");
			Transform.SetLocalEulerHint_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerHint_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerHint_Injected");
			Transform.SetPositionAndRotation_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetPositionAndRotation_InjectedDelegate>("UnityEngine.Transform::SetPositionAndRotation_Injected");
			Transform.InverseTransformDirection_InjectedDelegateField = IL2CPP.ResolveICall<Transform.InverseTransformDirection_InjectedDelegate>("UnityEngine.Transform::InverseTransformDirection_Injected");
			Transform.TransformVector_InjectedDelegateField = IL2CPP.ResolveICall<Transform.TransformVector_InjectedDelegate>("UnityEngine.Transform::TransformVector_Injected");
			Transform.InverseTransformVector_InjectedDelegateField = IL2CPP.ResolveICall<Transform.InverseTransformVector_InjectedDelegate>("UnityEngine.Transform::InverseTransformVector_Injected");
			Transform.RotateAround_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAround_InjectedDelegate>("UnityEngine.Transform::RotateAround_Injected");
			Transform.RotateAroundLocal_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAroundLocal_InjectedDelegate>("UnityEngine.Transform::RotateAroundLocal_Injected");
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0004B2F4 File Offset: 0x000494F4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77781, XrefRangeEnd = 77782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0004B330 File Offset: 0x00049530
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0004B36C File Offset: 0x0004956C
		public unsafe Vector3 position
		{
			[CallerCount(211)]
			[CachedScanResults(RefRangeStart = 77837, RefRangeEnd = 78048, XrefRangeStart = 77835, XrefRangeEnd = 77837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 78050, RefRangeEnd = 78143, XrefRangeStart = 78048, XrefRangeEnd = 78050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0004B3AC File Offset: 0x000495AC
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0004B3E8 File Offset: 0x000495E8
		public unsafe Vector3 localPosition
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 78145, RefRangeEnd = 78192, XrefRangeStart = 78143, XrefRangeEnd = 78145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 78194, RefRangeEnd = 78242, XrefRangeStart = 78192, XrefRangeEnd = 78194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0004B428 File Offset: 0x00049628
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0004B464 File Offset: 0x00049664
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(86)]
			[CachedScanResults(RefRangeStart = 78245, RefRangeEnd = 78331, XrefRangeStart = 78242, XrefRangeEnd = 78245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 78334, RefRangeEnd = 78366, XrefRangeStart = 78331, XrefRangeEnd = 78334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0004B4A4 File Offset: 0x000496A4
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0004B4E0 File Offset: 0x000496E0
		public unsafe Vector3 localEulerAngles
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 78369, RefRangeEnd = 78378, XrefRangeStart = 78366, XrefRangeEnd = 78369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 78381, RefRangeEnd = 78389, XrefRangeStart = 78378, XrefRangeEnd = 78381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0004B520 File Offset: 0x00049720
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x0004B55C File Offset: 0x0004975C
		public unsafe Vector3 forward
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 78394, RefRangeEnd = 78397, XrefRangeStart = 78389, XrefRangeEnd = 78394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78400, RefRangeEnd = 78402, XrefRangeStart = 78397, XrefRangeEnd = 78400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0004B59C File Offset: 0x0004979C
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0004B5D8 File Offset: 0x000497D8
		public unsafe Quaternion rotation
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 78404, RefRangeEnd = 78436, XrefRangeStart = 78402, XrefRangeEnd = 78404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 78438, RefRangeEnd = 78461, XrefRangeStart = 78436, XrefRangeEnd = 78438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0004B618 File Offset: 0x00049818
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0004B654 File Offset: 0x00049854
		public unsafe Quaternion localRotation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78463, RefRangeEnd = 78477, XrefRangeStart = 78461, XrefRangeEnd = 78463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 78479, RefRangeEnd = 78504, XrefRangeStart = 78477, XrefRangeEnd = 78479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0004B694 File Offset: 0x00049894
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0004B6D0 File Offset: 0x000498D0
		public unsafe Vector3 localScale
		{
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 78506, RefRangeEnd = 78573, XrefRangeStart = 78504, XrefRangeEnd = 78506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 78575, RefRangeEnd = 78627, XrefRangeStart = 78573, XrefRangeEnd = 78575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0004B710 File Offset: 0x00049910
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0004B750 File Offset: 0x00049950
		public unsafe Transform parent
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 78629, RefRangeEnd = 78728, XrefRangeStart = 78627, XrefRangeEnd = 78629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 78738, RefRangeEnd = 78744, XrefRangeStart = 78728, XrefRangeEnd = 78738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0004B794 File Offset: 0x00049994
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x0004B7D4 File Offset: 0x000499D4
		public unsafe Transform parentInternal
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 78629, RefRangeEnd = 78728, XrefRangeStart = 78629, XrefRangeEnd = 78728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 78746, RefRangeEnd = 78772, XrefRangeStart = 78744, XrefRangeEnd = 78746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0004B818 File Offset: 0x00049A18
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 78629, RefRangeEnd = 78728, XrefRangeStart = 78629, XrefRangeEnd = 78728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0004B858 File Offset: 0x00049A58
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 78746, RefRangeEnd = 78772, XrefRangeStart = 78746, XrefRangeEnd = 78772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0004B89C File Offset: 0x00049A9C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 78774, RefRangeEnd = 78818, XrefRangeStart = 78772, XrefRangeEnd = 78774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent, bool worldPositionStays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0004B8EC File Offset: 0x00049AEC
		public unsafe Matrix4x4 worldToLocalMatrix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78820, RefRangeEnd = 78822, XrefRangeStart = 78818, XrefRangeEnd = 78820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0004B928 File Offset: 0x00049B28
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78822, XrefRangeEnd = 78824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0004B964 File Offset: 0x00049B64
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 78832, RefRangeEnd = 78841, XrefRangeStart = 78824, XrefRangeEnd = 78832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0004B9B0 File Offset: 0x00049BB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 78860, RefRangeEnd = 78868, XrefRangeStart = 78841, XrefRangeEnd = 78860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eulers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0004B9FC File Offset: 0x00049BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78868, XrefRangeEnd = 78874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eulers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0004BA3C File Offset: 0x00049C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78880, RefRangeEnd = 78881, XrefRangeStart = 78874, XrefRangeEnd = 78880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0004BA98 File Offset: 0x00049C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78881, XrefRangeEnd = 78883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78883, XrefRangeEnd = 78885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0004BB40 File Offset: 0x00049D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78885, XrefRangeEnd = 78890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0004BB8C File Offset: 0x00049D8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 78898, RefRangeEnd = 78902, XrefRangeStart = 78890, XrefRangeEnd = 78898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Transform target, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0004BBDC File Offset: 0x00049DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78912, RefRangeEnd = 78913, XrefRangeStart = 78902, XrefRangeEnd = 78912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0004BC20 File Offset: 0x00049E20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 78915, RefRangeEnd = 78919, XrefRangeStart = 78913, XrefRangeEnd = 78915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0004BC6C File Offset: 0x00049E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78919, XrefRangeEnd = 78921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78923, RefRangeEnd = 78924, XrefRangeStart = 78921, XrefRangeEnd = 78923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0004BD04 File Offset: 0x00049F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78926, RefRangeEnd = 78927, XrefRangeStart = 78924, XrefRangeEnd = 78926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0004BD6C File Offset: 0x00049F6C
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 78929, RefRangeEnd = 78987, XrefRangeStart = 78927, XrefRangeEnd = 78929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0004BDB8 File Offset: 0x00049FB8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 78989, RefRangeEnd = 79006, XrefRangeStart = 78987, XrefRangeEnd = 78989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0004BE04 File Offset: 0x0004A004
		public unsafe int childCount
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 79008, RefRangeEnd = 79077, XrefRangeStart = 79006, XrefRangeEnd = 79008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0004BE40 File Offset: 0x0004A040
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 79079, RefRangeEnd = 79096, XrefRangeStart = 79077, XrefRangeEnd = 79079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsFirstSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0004BE74 File Offset: 0x0004A074
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 79098, RefRangeEnd = 79108, XrefRangeStart = 79096, XrefRangeEnd = 79098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsLastSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0004BEA8 File Offset: 0x0004A0A8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 79110, RefRangeEnd = 79119, XrefRangeStart = 79108, XrefRangeEnd = 79110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0004BEE8 File Offset: 0x0004A0E8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 79121, RefRangeEnd = 79136, XrefRangeStart = 79119, XrefRangeEnd = 79121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSiblingIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0004BF24 File Offset: 0x0004A124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79136, XrefRangeEnd = 79138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActiveOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0004BF88 File Offset: 0x0004A188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79146, RefRangeEnd = 79149, XrefRangeStart = 79138, XrefRangeEnd = 79146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform Find(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0004BFD8 File Offset: 0x0004A1D8
		public unsafe Vector3 lossyScale
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 79151, RefRangeEnd = 79164, XrefRangeStart = 79149, XrefRangeEnd = 79151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0004C014 File Offset: 0x0004A214
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 79166, RefRangeEnd = 79170, XrefRangeStart = 79164, XrefRangeEnd = 79166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChildOf(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0000B579 File Offset: 0x00009779
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0004C064 File Offset: 0x0004A264
		public unsafe bool hasChanged
		{
			get
			{
				return Transform.get_hasChangedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79172, RefRangeEnd = 79173, XrefRangeStart = 79170, XrefRangeEnd = 79172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 79177, RefRangeEnd = 79200, XrefRangeStart = 79173, XrefRangeEnd = 79177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0004C0E4 File Offset: 0x0004A2E4
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 79202, RefRangeEnd = 79282, XrefRangeStart = 79200, XrefRangeEnd = 79202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0004C130 File Offset: 0x0004A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79282, XrefRangeEnd = 79284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0004C170 File Offset: 0x0004A370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79284, XrefRangeEnd = 79286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_position_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79286, XrefRangeEnd = 79288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localPosition_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0004C1F0 File Offset: 0x0004A3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79288, XrefRangeEnd = 79290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localPosition_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0004C230 File Offset: 0x0004A430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79290, XrefRangeEnd = 79292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0004C270 File Offset: 0x0004A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79292, XrefRangeEnd = 79294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0004C2B0 File Offset: 0x0004A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79294, XrefRangeEnd = 79296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localRotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79296, XrefRangeEnd = 79298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localRotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0004C330 File Offset: 0x0004A530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79298, XrefRangeEnd = 79300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0004C370 File Offset: 0x0004A570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79300, XrefRangeEnd = 79302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localScale_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79302, XrefRangeEnd = 79304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0004C3F0 File Offset: 0x0004A5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79304, XrefRangeEnd = 79306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0004C430 File Offset: 0x0004A630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79306, XrefRangeEnd = 79308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0004C47C File Offset: 0x0004A67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79308, XrefRangeEnd = 79310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0004C4C8 File Offset: 0x0004A6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79310, XrefRangeEnd = 79312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0004C514 File Offset: 0x0004A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79312, XrefRangeEnd = 79314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0004C560 File Offset: 0x0004A760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79314, XrefRangeEnd = 79316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0004C5AC File Offset: 0x0004A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79316, XrefRangeEnd = 79318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_lossyScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0000B44D File Offset: 0x0000964D
		public Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0004C5EC File Offset: 0x0004A7EC
		public Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			Vector3 vector;
			this.GetLocalEulerAngles_Injected(order, out vector);
			return vector;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0000B456 File Offset: 0x00009656
		public void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
			this.SetLocalEulerAngles_Injected(ref euler, order);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0000B461 File Offset: 0x00009661
		public void SetLocalEulerHint(Vector3 euler)
		{
			this.SetLocalEulerHint_Injected(ref euler);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0004C604 File Offset: 0x0004A804
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000B46B File Offset: 0x0000966B
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.right, value);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0004C628 File Offset: 0x0004A828
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x0000B480 File Offset: 0x00009680
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.up, value);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x0004C64C File Offset: 0x0004A84C
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x0000B495 File Offset: 0x00009695
		public RotationOrder rotationOrder
		{
			get
			{
				return (RotationOrder)this.GetRotationOrderInternal();
			}
			set
			{
				this.SetRotationOrderInternal(value);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0000B4A0 File Offset: 0x000096A0
		public int GetRotationOrderInternal()
		{
			return Transform.GetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0000B4B2 File Offset: 0x000096B2
		public void SetRotationOrderInternal(RotationOrder rotationOrder)
		{
			Transform.SetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), rotationOrder);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0000B4C5 File Offset: 0x000096C5
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			this.SetPositionAndRotation_Injected(ref position, ref rotation);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0000B4D1 File Offset: 0x000096D1
		public void Translate(Vector3 translation)
		{
			this.Translate(translation, Space.Self);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0000B4DD File Offset: 0x000096DD
		public void Translate(float x, float y, float z, Space relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0000B4F1 File Offset: 0x000096F1
		public void Translate(float x, float y, float z)
		{
			this.Translate(new Vector3(x, y, z), Space.Self);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0004C664 File Offset: 0x0004A864
		public void Translate(Vector3 translation, Transform relativeTo)
		{
			bool flag = relativeTo;
			if (flag)
			{
				this.position += relativeTo.TransformDirection(translation);
			}
			else
			{
				this.position += translation;
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0000B504 File Offset: 0x00009704
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0000B518 File Offset: 0x00009718
		public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
		{
			this.Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0004C6AC File Offset: 0x0004A8AC
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Vector3 vector = this.position;
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 vector2 = vector - point;
			vector2 = quaternion * vector2;
			vector = point + vector2;
			this.position = vector;
			this.RotateAroundInternal(axis, angle * 0.017453292f);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0000B52C File Offset: 0x0000972C
		public void LookAt(Vector3 worldPosition)
		{
			this.Internal_LookAt(worldPosition, Vector3.up);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			Vector3 vector;
			this.InverseTransformDirection_Injected(ref direction, out vector);
			return vector;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0004C710 File Offset: 0x0004A910
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return this.InverseTransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0004C730 File Offset: 0x0004A930
		public Vector3 TransformVector(Vector3 vector)
		{
			Vector3 vector2;
			this.TransformVector_Injected(ref vector, out vector2);
			return vector2;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0004C748 File Offset: 0x0004A948
		public Vector3 TransformVector(float x, float y, float z)
		{
			return this.TransformVector(new Vector3(x, y, z));
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0004C768 File Offset: 0x0004A968
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			Vector3 vector2;
			this.InverseTransformVector_Injected(ref vector, out vector2);
			return vector2;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0004C780 File Offset: 0x0004A980
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return this.InverseTransformVector(new Vector3(x, y, z));
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return this.TransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0004C7C0 File Offset: 0x0004A9C0
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return this.InverseTransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0004C7E0 File Offset: 0x0004A9E0
		public Transform root
		{
			get
			{
				return this.GetRoot();
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0004C7F8 File Offset: 0x0004A9F8
		public Transform GetRoot()
		{
			IntPtr intPtr = Transform.GetRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0000B53C File Offset: 0x0000973C
		public void DetachChildren()
		{
			Transform.DetachChildrenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0000B54E File Offset: 0x0000974E
		public void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty)
		{
			Transform.MoveAfterSiblingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), notifyEditorAndMarkDirty);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0000B567 File Offset: 0x00009767
		public void SendTransformChangedScale()
		{
			Transform.SendTransformChangedScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0004C824 File Offset: 0x0004AA24
		public Transform FindChild(string n)
		{
			return this.Find(n);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0000B58B File Offset: 0x0000978B
		public void RotateAround(Vector3 axis, float angle)
		{
			this.RotateAround_Injected(ref axis, angle);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0000B596 File Offset: 0x00009796
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
			this.RotateAroundLocal_Injected(ref axis, angle);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0000B5A1 File Offset: 0x000097A1
		public int GetChildCount()
		{
			return Transform.GetChildCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0004C840 File Offset: 0x0004AA40
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x0000B5B3 File Offset: 0x000097B3
		public int hierarchyCapacity
		{
			get
			{
				return this.internal_getHierarchyCapacity();
			}
			set
			{
				this.internal_setHierarchyCapacity(value);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0000B5BE File Offset: 0x000097BE
		public int internal_getHierarchyCapacity()
		{
			return Transform.internal_getHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0000B5D0 File Offset: 0x000097D0
		public void internal_setHierarchyCapacity(int value)
		{
			Transform.internal_setHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0004C858 File Offset: 0x0004AA58
		public int hierarchyCount
		{
			get
			{
				return this.internal_getHierarchyCount();
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0000B5E3 File Offset: 0x000097E3
		public int internal_getHierarchyCount()
		{
			return Transform.internal_getHierarchyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0000B5F5 File Offset: 0x000097F5
		public bool IsNonUniformScaleTransform()
		{
			return Transform.IsNonUniformScaleTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0000B607 File Offset: 0x00009807
		public void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret)
		{
			Transform.GetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), order, out ret);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0000B61B File Offset: 0x0000981B
		public void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order)
		{
			Transform.SetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler, order);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0000B62F File Offset: 0x0000982F
		public void SetLocalEulerHint_Injected(ref Vector3 euler)
		{
			Transform.SetLocalEulerHint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0000B642 File Offset: 0x00009842
		public void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			Transform.SetPositionAndRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0000B656 File Offset: 0x00009856
		public void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			Transform.InverseTransformDirection_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, out ret);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0000B66A File Offset: 0x0000986A
		public void TransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			Transform.TransformVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref vector, out ret);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0000B67E File Offset: 0x0000987E
		public void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			Transform.InverseTransformVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref vector, out ret);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0000B692 File Offset: 0x00009892
		public void RotateAround_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAround_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0000B6A6 File Offset: 0x000098A6
		public void RotateAroundLocal_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAroundLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_get_Vector3_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_Transform_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Private_Transform_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Transform_String_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly Transform.GetRotationOrderInternalDelegate GetRotationOrderInternalDelegateField;

		// Token: 0x04000EAD RID: 3757
		private static readonly Transform.SetRotationOrderInternalDelegate SetRotationOrderInternalDelegateField;

		// Token: 0x04000EAE RID: 3758
		private static readonly Transform.GetRootDelegate GetRootDelegateField;

		// Token: 0x04000EAF RID: 3759
		private static readonly Transform.DetachChildrenDelegate DetachChildrenDelegateField;

		// Token: 0x04000EB0 RID: 3760
		private static readonly Transform.MoveAfterSiblingDelegate MoveAfterSiblingDelegateField;

		// Token: 0x04000EB1 RID: 3761
		private static readonly Transform.SendTransformChangedScaleDelegate SendTransformChangedScaleDelegateField;

		// Token: 0x04000EB2 RID: 3762
		private static readonly Transform.get_hasChangedDelegate get_hasChangedDelegateField;

		// Token: 0x04000EB3 RID: 3763
		private static readonly Transform.GetChildCountDelegate GetChildCountDelegateField;

		// Token: 0x04000EB4 RID: 3764
		private static readonly Transform.internal_getHierarchyCapacityDelegate internal_getHierarchyCapacityDelegateField;

		// Token: 0x04000EB5 RID: 3765
		private static readonly Transform.internal_setHierarchyCapacityDelegate internal_setHierarchyCapacityDelegateField;

		// Token: 0x04000EB6 RID: 3766
		private static readonly Transform.internal_getHierarchyCountDelegate internal_getHierarchyCountDelegateField;

		// Token: 0x04000EB7 RID: 3767
		private static readonly Transform.IsNonUniformScaleTransformDelegate IsNonUniformScaleTransformDelegateField;

		// Token: 0x04000EB8 RID: 3768
		private static readonly Transform.GetLocalEulerAngles_InjectedDelegate GetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04000EB9 RID: 3769
		private static readonly Transform.SetLocalEulerAngles_InjectedDelegate SetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04000EBA RID: 3770
		private static readonly Transform.SetLocalEulerHint_InjectedDelegate SetLocalEulerHint_InjectedDelegateField;

		// Token: 0x04000EBB RID: 3771
		private static readonly Transform.SetPositionAndRotation_InjectedDelegate SetPositionAndRotation_InjectedDelegateField;

		// Token: 0x04000EBC RID: 3772
		private static readonly Transform.InverseTransformDirection_InjectedDelegate InverseTransformDirection_InjectedDelegateField;

		// Token: 0x04000EBD RID: 3773
		private static readonly Transform.TransformVector_InjectedDelegate TransformVector_InjectedDelegateField;

		// Token: 0x04000EBE RID: 3774
		private static readonly Transform.InverseTransformVector_InjectedDelegate InverseTransformVector_InjectedDelegateField;

		// Token: 0x04000EBF RID: 3775
		private static readonly Transform.RotateAround_InjectedDelegate RotateAround_InjectedDelegateField;

		// Token: 0x04000EC0 RID: 3776
		private static readonly Transform.RotateAroundLocal_InjectedDelegate RotateAroundLocal_InjectedDelegateField;

		// Token: 0x02000849 RID: 2121
		public class Enumerator : Object
		{
			// Token: 0x06002E3C RID: 11836 RVA: 0x0006CC74 File Offset: 0x0006AE74
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Transform>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr);
				Transform.Enumerator.NativeFieldInfoPtr_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "outer");
				Transform.Enumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "currentIndex");
				Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100664705);
				Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100664706);
				Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100664707);
				Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100664708);
			}

			// Token: 0x06002E3D RID: 11837 RVA: 0x0006CD18 File Offset: 0x0006AF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Transform outer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(outer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06002E3E RID: 11838 RVA: 0x0006CD64 File Offset: 0x0006AF64
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77776, XrefRangeEnd = 77779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E3F RID: 11839 RVA: 0x0006CDA4 File Offset: 0x0006AFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77779, XrefRangeEnd = 77781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E40 RID: 11840 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E41 RID: 11841 RVA: 0x00015538 File Offset: 0x00013738
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06002E42 RID: 11842 RVA: 0x0006CE14 File Offset: 0x0006B014
			// (set) Token: 0x06002E43 RID: 11843 RVA: 0x00015541 File Offset: 0x00013741
			public unsafe Transform outer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06002E44 RID: 11844 RVA: 0x0006CE44 File Offset: 0x0006B044
			// (set) Token: 0x06002E45 RID: 11845 RVA: 0x00015560 File Offset: 0x00013760
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04001CC0 RID: 7360
			private static readonly IntPtr NativeFieldInfoPtr_outer;

			// Token: 0x04001CC1 RID: 7361
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x04001CC2 RID: 7362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Transform_0;

			// Token: 0x04001CC3 RID: 7363
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CC4 RID: 7364
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CC5 RID: 7365
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200084A RID: 2122
		// (Invoke) Token: 0x06002E47 RID: 11847
		private delegate int GetRotationOrderInternalDelegate(IntPtr @this);

		// Token: 0x0200084B RID: 2123
		// (Invoke) Token: 0x06002E49 RID: 11849
		private delegate void SetRotationOrderInternalDelegate(IntPtr @this, RotationOrder rotationOrder);

		// Token: 0x0200084C RID: 2124
		// (Invoke) Token: 0x06002E4B RID: 11851
		private delegate IntPtr GetRootDelegate(IntPtr @this);

		// Token: 0x0200084D RID: 2125
		// (Invoke) Token: 0x06002E4D RID: 11853
		private delegate void DetachChildrenDelegate(IntPtr @this);

		// Token: 0x0200084E RID: 2126
		// (Invoke) Token: 0x06002E4F RID: 11855
		private delegate void MoveAfterSiblingDelegate(IntPtr @this, IntPtr transform, bool notifyEditorAndMarkDirty);

		// Token: 0x0200084F RID: 2127
		// (Invoke) Token: 0x06002E51 RID: 11857
		private delegate void SendTransformChangedScaleDelegate(IntPtr @this);

		// Token: 0x02000850 RID: 2128
		// (Invoke) Token: 0x06002E53 RID: 11859
		private delegate bool get_hasChangedDelegate(IntPtr @this);

		// Token: 0x02000851 RID: 2129
		// (Invoke) Token: 0x06002E55 RID: 11861
		private delegate int GetChildCountDelegate(IntPtr @this);

		// Token: 0x02000852 RID: 2130
		// (Invoke) Token: 0x06002E57 RID: 11863
		private delegate int internal_getHierarchyCapacityDelegate(IntPtr @this);

		// Token: 0x02000853 RID: 2131
		// (Invoke) Token: 0x06002E59 RID: 11865
		private delegate void internal_setHierarchyCapacityDelegate(IntPtr @this, int value);

		// Token: 0x02000854 RID: 2132
		// (Invoke) Token: 0x06002E5B RID: 11867
		private delegate int internal_getHierarchyCountDelegate(IntPtr @this);

		// Token: 0x02000855 RID: 2133
		// (Invoke) Token: 0x06002E5D RID: 11869
		private delegate bool IsNonUniformScaleTransformDelegate(IntPtr @this);

		// Token: 0x02000856 RID: 2134
		// (Invoke) Token: 0x06002E5F RID: 11871
		private delegate void GetLocalEulerAngles_InjectedDelegate(IntPtr @this, RotationOrder order, [Out] IntPtr ret);

		// Token: 0x02000857 RID: 2135
		// (Invoke) Token: 0x06002E61 RID: 11873
		private delegate void SetLocalEulerAngles_InjectedDelegate(IntPtr @this, IntPtr euler, RotationOrder order);

		// Token: 0x02000858 RID: 2136
		// (Invoke) Token: 0x06002E63 RID: 11875
		private delegate void SetLocalEulerHint_InjectedDelegate(IntPtr @this, IntPtr euler);

		// Token: 0x02000859 RID: 2137
		// (Invoke) Token: 0x06002E65 RID: 11877
		private delegate void SetPositionAndRotation_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x0200085A RID: 2138
		// (Invoke) Token: 0x06002E67 RID: 11879
		private delegate void InverseTransformDirection_InjectedDelegate(IntPtr @this, IntPtr direction, [Out] IntPtr ret);

		// Token: 0x0200085B RID: 2139
		// (Invoke) Token: 0x06002E69 RID: 11881
		private delegate void TransformVector_InjectedDelegate(IntPtr @this, IntPtr vector, [Out] IntPtr ret);

		// Token: 0x0200085C RID: 2140
		// (Invoke) Token: 0x06002E6B RID: 11883
		private delegate void InverseTransformVector_InjectedDelegate(IntPtr @this, IntPtr vector, [Out] IntPtr ret);

		// Token: 0x0200085D RID: 2141
		// (Invoke) Token: 0x06002E6D RID: 11885
		private delegate void RotateAround_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);

		// Token: 0x0200085E RID: 2142
		// (Invoke) Token: 0x06002E6F RID: 11887
		private delegate void RotateAroundLocal_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);
	}
}
