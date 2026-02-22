using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200007C RID: 124
public class AnimateObject : MonoBehaviour
{
	// Token: 0x06000F74 RID: 3956 RVA: 0x0004726C File Offset: 0x0004546C
	// Note: this type is marked as 'beforefieldinit'.
	static AnimateObject()
	{
		Il2CppClassPointerStore<AnimateObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimateObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr);
		AnimateObject.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimationManager");
		AnimateObject.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_Placeholder");
		AnimateObject.NativeFieldInfoPtr_m_CurrentScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_CurrentScale");
		AnimateObject.NativeFieldInfoPtr_m_TargetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_TargetScale");
		AnimateObject.NativeFieldInfoPtr_m_bIsAnimating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bIsAnimating");
		AnimateObject.NativeFieldInfoPtr_m_bAnimateToPlaceholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bAnimateToPlaceholder");
		AnimateObject.NativeFieldInfoPtr_m_AnimationDelayAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimationDelayAtStart");
		AnimateObject.NativeFieldInfoPtr_m_AnimationPauseAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimationPauseAtDestination");
		AnimateObject.NativeFieldInfoPtr_m_AnimateCurrentHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateCurrentHeight");
		AnimateObject.NativeFieldInfoPtr_m_AnimateTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateTargetHeight");
		AnimateObject.NativeFieldInfoPtr_m_bHasAdditionalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bHasAdditionalRotation");
		AnimateObject.NativeFieldInfoPtr_m_AnimateAdditionalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateAdditionalRotation");
		AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bAdjustPlaceholderLayoutWidth");
		AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bAdjustPlaceholderLayoutHeight");
		AnimateObject.NativeFieldInfoPtr_m_bReachedDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bReachedDestination");
		AnimateObject.NativeFieldInfoPtr_m_bDestroyAfterAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_bDestroyAfterAnimation");
		AnimateObject.NativeFieldInfoPtr_m_InternalRotationNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_InternalRotationNode");
		AnimateObject.NativeFieldInfoPtr_m_TargetInternalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_TargetInternalRotation");
		AnimateObject.NativeFieldInfoPtr_m_DontUpdateInternalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_DontUpdateInternalRotation");
		AnimateObject.NativeFieldInfoPtr_k_DefaultInternalRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_DefaultInternalRotationRate");
		AnimateObject.NativeFieldInfoPtr_m_DestinationLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_DestinationLocator");
		AnimateObject.NativeFieldInfoPtr_m_OnBeginAnimationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_OnBeginAnimationCallback");
		AnimateObject.NativeFieldInfoPtr_m_OnReachDestinationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_OnReachDestinationCallback");
		AnimateObject.NativeFieldInfoPtr_m_OnEndAnimationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_OnEndAnimationCallback");
		AnimateObject.NativeFieldInfoPtr_k_ScalePlaceholderByDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_ScalePlaceholderByDistance");
		AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_DefaultMovementRateXY");
		AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_DefaultMovementRateZ");
		AnimateObject.NativeFieldInfoPtr_k_DefaultRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_DefaultRotationRate");
		AnimateObject.NativeFieldInfoPtr_k_DefaultScaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "k_DefaultScaleRate");
		AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateMovementRateXY");
		AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateMovementRateZ");
		AnimateObject.NativeFieldInfoPtr_m_AnimateRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateRotationRate");
		AnimateObject.NativeFieldInfoPtr_m_AnimateScaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateScaleRate");
		AnimateObject.NativeFieldInfoPtr_m_AnimateInternalRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "m_AnimateInternalRotationRate");
		AnimateObject.NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664403);
		AnimateObject.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664404);
		AnimateObject.NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664405);
		AnimateObject.NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664406);
		AnimateObject.NativeMethodInfoPtr_AddOnReachDestinationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664407);
		AnimateObject.NativeMethodInfoPtr_RemoveOnReachDestinationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664408);
		AnimateObject.NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664409);
		AnimateObject.NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664410);
		AnimateObject.NativeMethodInfoPtr_ResetAnimationRates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664411);
		AnimateObject.NativeMethodInfoPtr_SetAnimateMovementRateXY_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664412);
		AnimateObject.NativeMethodInfoPtr_SetAnimateMovementRateZ_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664413);
		AnimateObject.NativeMethodInfoPtr_SetAnimateRotationRate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664414);
		AnimateObject.NativeMethodInfoPtr_SetAnimateScaleRate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664415);
		AnimateObject.NativeMethodInfoPtr_SetAnimateInternalRotationRate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664416);
		AnimateObject.NativeMethodInfoPtr_GetAnimateCurrentHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664417);
		AnimateObject.NativeMethodInfoPtr_GetAnimateTargetHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664418);
		AnimateObject.NativeMethodInfoPtr_SetAnimateCurrentHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664419);
		AnimateObject.NativeMethodInfoPtr_SetAnimateTargetHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664420);
		AnimateObject.NativeMethodInfoPtr_SetAnimateAdditionalRotation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664421);
		AnimateObject.NativeMethodInfoPtr_IsAnimating_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664422);
		AnimateObject.NativeMethodInfoPtr_SetAdjustPlaceholderLayoutWidth_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664423);
		AnimateObject.NativeMethodInfoPtr_SetAdjustPlaceholderLayoutHeight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664424);
		AnimateObject.NativeMethodInfoPtr_GetCurrentScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664425);
		AnimateObject.NativeMethodInfoPtr_SetCurrentScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664426);
		AnimateObject.NativeMethodInfoPtr_ResetCurrentScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664427);
		AnimateObject.NativeMethodInfoPtr_InheritCurrentScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664428);
		AnimateObject.NativeMethodInfoPtr_GetTargetScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664429);
		AnimateObject.NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664430);
		AnimateObject.NativeMethodInfoPtr_SetInternalRotationNode_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664431);
		AnimateObject.NativeMethodInfoPtr_SetTargetInternalRotation_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664432);
		AnimateObject.NativeMethodInfoPtr_IncrementDontUpdateInternalRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664433);
		AnimateObject.NativeMethodInfoPtr_DecrementDontUpdateInternalRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664434);
		AnimateObject.NativeMethodInfoPtr_SetAnimationPauseAtDestination_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664435);
		AnimateObject.NativeMethodInfoPtr_SetDestroyAfterAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664436);
		AnimateObject.NativeMethodInfoPtr_GetPlaceholder_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664437);
		AnimateObject.NativeMethodInfoPtr_ResetPlaceholderLayout_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664438);
		AnimateObject.NativeMethodInfoPtr_AssignPlaceholder_Private_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664439);
		AnimateObject.NativeMethodInfoPtr_DestroyPlaceholder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664440);
		AnimateObject.NativeMethodInfoPtr_StopAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664441);
		AnimateObject.NativeMethodInfoPtr_DestroyAnimation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664442);
		AnimateObject.NativeMethodInfoPtr_StartAnimation_Private_Void_Single_Single_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664443);
		AnimateObject.NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664444);
		AnimateObject.NativeMethodInfoPtr_StartAnimationToLocator_Public_Void_AnimationLocator_AnimationLocator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664445);
		AnimateObject.NativeMethodInfoPtr_PlaceOnAnimationLocator_Public_Void_AnimationLocator_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664446);
		AnimateObject.NativeMethodInfoPtr_UpdatePlaceholder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664447);
		AnimateObject.NativeMethodInfoPtr_UpdateAnimation_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664448);
		AnimateObject.NativeMethodInfoPtr_UpdateScale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664449);
		AnimateObject.NativeMethodInfoPtr_UpdateInternalRotation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664450);
		AnimateObject.NativeMethodInfoPtr_UpdateAnimate_Public_Virtual_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664451);
		AnimateObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, 100664452);
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x0004792C File Offset: 0x00045B2C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationManager GetAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationManager>(intPtr3) : null;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0004796C File Offset: 0x00045B6C
	[CallerCount(0)]
	public unsafe void SetAnimationManager(AnimationManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x000479B0 File Offset: 0x00045BB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240612, RefRangeEnd = 240614, XrefRangeStart = 240609, XrefRangeEnd = 240612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnBeginAnimationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x000479F4 File Offset: 0x00045BF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240614, XrefRangeEnd = 240617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnBeginAnimationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00047A38 File Offset: 0x00045C38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240620, RefRangeEnd = 240621, XrefRangeStart = 240617, XrefRangeEnd = 240620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnReachDestinationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_AddOnReachDestinationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00047A7C File Offset: 0x00045C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240621, XrefRangeEnd = 240624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnReachDestinationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_RemoveOnReachDestinationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00047AC0 File Offset: 0x00045CC0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 240627, RefRangeEnd = 240631, XrefRangeStart = 240624, XrefRangeEnd = 240627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnEndAnimationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00047B04 File Offset: 0x00045D04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240631, XrefRangeEnd = 240634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnEndAnimationCallback(AnimateObject.AnimationCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00047B48 File Offset: 0x00045D48
	[CallerCount(0)]
	public unsafe void ResetAnimationRates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_ResetAnimationRates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00047B7C File Offset: 0x00045D7C
	[CallerCount(0)]
	public unsafe void SetAnimateMovementRateXY(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateMovementRateXY_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00047BBC File Offset: 0x00045DBC
	[CallerCount(0)]
	public unsafe void SetAnimateMovementRateZ(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateMovementRateZ_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00047BFC File Offset: 0x00045DFC
	[CallerCount(0)]
	public unsafe void SetAnimateRotationRate(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateRotationRate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x00047C3C File Offset: 0x00045E3C
	[CallerCount(0)]
	public unsafe void SetAnimateScaleRate(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateScaleRate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00047C7C File Offset: 0x00045E7C
	[CallerCount(0)]
	public unsafe void SetAnimateInternalRotationRate(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateInternalRotationRate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00047CBC File Offset: 0x00045EBC
	[CallerCount(0)]
	public unsafe float GetAnimateCurrentHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetAnimateCurrentHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00047CF8 File Offset: 0x00045EF8
	[CallerCount(0)]
	public unsafe float GetAnimateTargetHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetAnimateTargetHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00047D34 File Offset: 0x00045F34
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88931, RefRangeEnd = 88932, XrefRangeStart = 88931, XrefRangeEnd = 88932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimateCurrentHeight(float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateCurrentHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00047D74 File Offset: 0x00045F74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88932, RefRangeEnd = 88933, XrefRangeStart = 88932, XrefRangeEnd = 88933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimateTargetHeight(float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateTargetHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00047DB4 File Offset: 0x00045FB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240634, XrefRangeEnd = 240635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimateAdditionalRotation(Vector3 rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimateAdditionalRotation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00047DF4 File Offset: 0x00045FF4
	[CallerCount(0)]
	public unsafe bool IsAnimating()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_IsAnimating_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00047E30 File Offset: 0x00046030
	[CallerCount(0)]
	public unsafe void SetAdjustPlaceholderLayoutWidth(bool bAdjust)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAdjust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAdjustPlaceholderLayoutWidth_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00047E70 File Offset: 0x00046070
	[CallerCount(0)]
	public unsafe void SetAdjustPlaceholderLayoutHeight(bool bAdjust)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAdjust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAdjustPlaceholderLayoutHeight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00047EB0 File Offset: 0x000460B0
	[CallerCount(0)]
	public unsafe float GetCurrentScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetCurrentScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00047EEC File Offset: 0x000460EC
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 240642, RefRangeEnd = 240657, XrefRangeStart = 240635, XrefRangeEnd = 240642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentScale(float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetCurrentScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00047F2C File Offset: 0x0004612C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240659, RefRangeEnd = 240661, XrefRangeStart = 240657, XrefRangeEnd = 240659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCurrentScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_ResetCurrentScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00047F60 File Offset: 0x00046160
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240661, XrefRangeEnd = 240667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InheritCurrentScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_InheritCurrentScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00047F94 File Offset: 0x00046194
	[CallerCount(0)]
	public unsafe float GetTargetScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetTargetScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00047FD0 File Offset: 0x000461D0
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 240672, RefRangeEnd = 240684, XrefRangeStart = 240667, XrefRangeEnd = 240672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTargetScale(float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00048010 File Offset: 0x00046210
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240690, RefRangeEnd = 240691, XrefRangeStart = 240684, XrefRangeEnd = 240690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInternalRotationNode(GameObject rotationNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotationNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetInternalRotationNode_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00048054 File Offset: 0x00046254
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240700, RefRangeEnd = 240701, XrefRangeStart = 240691, XrefRangeEnd = 240700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTargetInternalRotation(Vector3 rotation, bool bImmediate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rotation;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bImmediate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetTargetInternalRotation_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x000480A0 File Offset: 0x000462A0
	[CallerCount(0)]
	public unsafe void IncrementDontUpdateInternalRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_IncrementDontUpdateInternalRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x000480D4 File Offset: 0x000462D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240701, RefRangeEnd = 240702, XrefRangeStart = 240701, XrefRangeEnd = 240701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecrementDontUpdateInternalRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_DecrementDontUpdateInternalRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00048108 File Offset: 0x00046308
	[CallerCount(0)]
	public unsafe bool SetAnimationPauseAtDestination(float pause)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pause;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetAnimationPauseAtDestination_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00048154 File Offset: 0x00046354
	[CallerCount(0)]
	public unsafe void SetDestroyAfterAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_SetDestroyAfterAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00048188 File Offset: 0x00046388
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 240718, RefRangeEnd = 240722, XrefRangeStart = 240702, XrefRangeEnd = 240718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetPlaceholder(bool bCreateIfNeeded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bCreateIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_GetPlaceholder_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x000481D4 File Offset: 0x000463D4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 240738, RefRangeEnd = 240741, XrefRangeStart = 240722, XrefRangeEnd = 240738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPlaceholderLayout(float scaleMin = 1f, float scalePreferred = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scaleMin;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalePreferred;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_ResetPlaceholderLayout_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00048220 File Offset: 0x00046420
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240741, XrefRangeEnd = 240749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject AssignPlaceholder(GameObject placeholder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_AssignPlaceholder_Private_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00048270 File Offset: 0x00046470
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 240756, RefRangeEnd = 240760, XrefRangeStart = 240749, XrefRangeEnd = 240756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyPlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_DestroyPlaceholder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x000482A4 File Offset: 0x000464A4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 240767, RefRangeEnd = 240770, XrefRangeStart = 240760, XrefRangeEnd = 240767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_StopAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x000482D8 File Offset: 0x000464D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240777, RefRangeEnd = 240778, XrefRangeStart = 240770, XrefRangeEnd = 240777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DestroyAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_DestroyAnimation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00048314 File Offset: 0x00046514
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 240789, RefRangeEnd = 240792, XrefRangeStart = 240778, XrefRangeEnd = 240789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAnimation(float delayAtStart, float pauseAtDestination, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delayAtStart;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_StartAnimation_Private_Void_Single_Single_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00048388 File Offset: 0x00046588
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240814, RefRangeEnd = 240815, XrefRangeStart = 240792, XrefRangeEnd = 240814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAnimationToPlaceholder(GameObject placeholder, float delayAtStart = 0f, float pauseAtDestination = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Void_GameObject_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x000483E8 File Offset: 0x000465E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240815, XrefRangeEnd = 240816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAnimationToLocator(AnimationLocator destinationLocator, AnimationLocator sourceLocator, float delayAtStart = 0f, float pauseAtDestination = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_StartAnimationToLocator_Public_Void_AnimationLocator_AnimationLocator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00048458 File Offset: 0x00046658
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240856, RefRangeEnd = 240857, XrefRangeStart = 240816, XrefRangeEnd = 240856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceOnAnimationLocator(AnimationLocator destinationLocator, bool bSetPosition, bool bSetRotation, int setSiblingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSiblingIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_PlaceOnAnimationLocator_Public_Void_AnimationLocator_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x000484C4 File Offset: 0x000466C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240890, RefRangeEnd = 240891, XrefRangeStart = 240857, XrefRangeEnd = 240890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_UpdatePlaceholder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x000484F8 File Offset: 0x000466F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240891, XrefRangeEnd = 241001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateAnimation(float animationSpeedScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref animationSpeedScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_UpdateAnimation_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00048544 File Offset: 0x00046744
	[CallerCount(0)]
	public unsafe bool UpdateScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_UpdateScale_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00048580 File Offset: 0x00046780
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241019, RefRangeEnd = 241020, XrefRangeStart = 241001, XrefRangeEnd = 241019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateInternalRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr_UpdateInternalRotation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x000485BC File Offset: 0x000467BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241020, XrefRangeEnd = 241026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UpdateAnimate(float animationSpeedScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref animationSpeedScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateObject.NativeMethodInfoPtr_UpdateAnimate_Public_Virtual_New_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00048610 File Offset: 0x00046810
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241029, RefRangeEnd = 241031, XrefRangeStart = 241026, XrefRangeEnd = 241029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimateObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x0000AEC6 File Offset: 0x000090C6
	public AnimateObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0004864C File Offset: 0x0004684C
	// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0000AECF File Offset: 0x000090CF
	public unsafe AnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0004867C File Offset: 0x0004687C
	// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0000AEEE File Offset: 0x000090EE
	public unsafe GameObject m_Placeholder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_Placeholder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06000FAC RID: 4012 RVA: 0x000486AC File Offset: 0x000468AC
	// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0000AF0D File Offset: 0x0000910D
	public unsafe float m_CurrentScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_CurrentScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_CurrentScale)) = value;
		}
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06000FAE RID: 4014 RVA: 0x000486D4 File Offset: 0x000468D4
	// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0000AF28 File Offset: 0x00009128
	public unsafe float m_TargetScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_TargetScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_TargetScale)) = value;
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x000486FC File Offset: 0x000468FC
	// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0000AF43 File Offset: 0x00009143
	public unsafe bool m_bIsAnimating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bIsAnimating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bIsAnimating)) = value;
		}
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00048724 File Offset: 0x00046924
	// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0000AF5E File Offset: 0x0000915E
	public unsafe bool m_bAnimateToPlaceholder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAnimateToPlaceholder);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAnimateToPlaceholder)) = value;
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004874C File Offset: 0x0004694C
	// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0000AF79 File Offset: 0x00009179
	public unsafe float m_AnimationDelayAtStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationDelayAtStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationDelayAtStart)) = value;
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00048774 File Offset: 0x00046974
	// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0000AF94 File Offset: 0x00009194
	public unsafe float m_AnimationPauseAtDestination
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationPauseAtDestination);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimationPauseAtDestination)) = value;
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0004879C File Offset: 0x0004699C
	// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0000AFAF File Offset: 0x000091AF
	public unsafe float m_AnimateCurrentHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateCurrentHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateCurrentHeight)) = value;
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06000FBA RID: 4026 RVA: 0x000487C4 File Offset: 0x000469C4
	// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0000AFCA File Offset: 0x000091CA
	public unsafe float m_AnimateTargetHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateTargetHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateTargetHeight)) = value;
		}
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06000FBC RID: 4028 RVA: 0x000487EC File Offset: 0x000469EC
	// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0000AFE5 File Offset: 0x000091E5
	public unsafe bool m_bHasAdditionalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bHasAdditionalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bHasAdditionalRotation)) = value;
		}
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00048814 File Offset: 0x00046A14
	// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0000B000 File Offset: 0x00009200
	public unsafe Vector3 m_AnimateAdditionalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateAdditionalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateAdditionalRotation)) = value;
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0004883C File Offset: 0x00046A3C
	// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0000B01B File Offset: 0x0000921B
	public unsafe bool m_bAdjustPlaceholderLayoutWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutWidth)) = value;
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00048864 File Offset: 0x00046A64
	// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0000B036 File Offset: 0x00009236
	public unsafe bool m_bAdjustPlaceholderLayoutHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutHeight)) = value;
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0004888C File Offset: 0x00046A8C
	// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0000B051 File Offset: 0x00009251
	public unsafe bool m_bReachedDestination
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bReachedDestination);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bReachedDestination)) = value;
		}
	}

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000488B4 File Offset: 0x00046AB4
	// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0000B06C File Offset: 0x0000926C
	public unsafe bool m_bDestroyAfterAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bDestroyAfterAnimation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_bDestroyAfterAnimation)) = value;
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000488DC File Offset: 0x00046ADC
	// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0000B087 File Offset: 0x00009287
	public unsafe GameObject m_InternalRotationNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_InternalRotationNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_InternalRotationNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0004890C File Offset: 0x00046B0C
	// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0000B0A6 File Offset: 0x000092A6
	public unsafe Quaternion m_TargetInternalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_TargetInternalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_TargetInternalRotation)) = value;
		}
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00048934 File Offset: 0x00046B34
	// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0000B0C1 File Offset: 0x000092C1
	public unsafe int m_DontUpdateInternalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_DontUpdateInternalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_DontUpdateInternalRotation)) = value;
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0004895C File Offset: 0x00046B5C
	// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000B0DC File Offset: 0x000092DC
	public unsafe static float k_DefaultInternalRotationRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_DefaultInternalRotationRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_DefaultInternalRotationRate, (void*)(&value));
		}
	}

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00048978 File Offset: 0x00046B78
	// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0000B0EA File Offset: 0x000092EA
	public unsafe AnimationLocator m_DestinationLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_DestinationLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_DestinationLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000489A8 File Offset: 0x00046BA8
	// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0000B109 File Offset: 0x00009309
	public unsafe AnimateObject.AnimationCallback m_OnBeginAnimationCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnBeginAnimationCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject.AnimationCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnBeginAnimationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000489D8 File Offset: 0x00046BD8
	// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0000B128 File Offset: 0x00009328
	public unsafe AnimateObject.AnimationCallback m_OnReachDestinationCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnReachDestinationCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject.AnimationCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnReachDestinationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00048A08 File Offset: 0x00046C08
	// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0000B147 File Offset: 0x00009347
	public unsafe AnimateObject.AnimationCallback m_OnEndAnimationCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnEndAnimationCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject.AnimationCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_OnEndAnimationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00048A38 File Offset: 0x00046C38
	// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0000B166 File Offset: 0x00009366
	public unsafe static float k_ScalePlaceholderByDistance
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_ScalePlaceholderByDistance, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_ScalePlaceholderByDistance, (void*)(&value));
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00048A54 File Offset: 0x00046C54
	// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0000B174 File Offset: 0x00009374
	public unsafe static float k_DefaultMovementRateXY
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateXY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateXY, (void*)(&value));
		}
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00048A70 File Offset: 0x00046C70
	// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0000B182 File Offset: 0x00009382
	public unsafe static float k_DefaultMovementRateZ
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateZ, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_DefaultMovementRateZ, (void*)(&value));
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00048A8C File Offset: 0x00046C8C
	// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0000B190 File Offset: 0x00009390
	public unsafe static float k_DefaultRotationRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_DefaultRotationRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_DefaultRotationRate, (void*)(&value));
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00048AA8 File Offset: 0x00046CA8
	// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0000B19E File Offset: 0x0000939E
	public unsafe static float k_DefaultScaleRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AnimateObject.NativeFieldInfoPtr_k_DefaultScaleRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimateObject.NativeFieldInfoPtr_k_DefaultScaleRate, (void*)(&value));
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00048AC4 File Offset: 0x00046CC4
	// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0000B1AC File Offset: 0x000093AC
	public unsafe float m_AnimateMovementRateXY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateXY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateXY)) = value;
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00048AEC File Offset: 0x00046CEC
	// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000B1C7 File Offset: 0x000093C7
	public unsafe float m_AnimateMovementRateZ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateZ);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateMovementRateZ)) = value;
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00048B14 File Offset: 0x00046D14
	// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0000B1E2 File Offset: 0x000093E2
	public unsafe float m_AnimateRotationRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateRotationRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateRotationRate)) = value;
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00048B3C File Offset: 0x00046D3C
	// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0000B1FD File Offset: 0x000093FD
	public unsafe float m_AnimateScaleRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateScaleRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateScaleRate)) = value;
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00048B64 File Offset: 0x00046D64
	// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0000B218 File Offset: 0x00009418
	public unsafe float m_AnimateInternalRotationRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateInternalRotationRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateObject.NativeFieldInfoPtr_m_AnimateInternalRotationRate)) = value;
		}
	}

	// Token: 0x04000AD7 RID: 2775
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000AD8 RID: 2776
	private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

	// Token: 0x04000AD9 RID: 2777
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentScale;

	// Token: 0x04000ADA RID: 2778
	private static readonly IntPtr NativeFieldInfoPtr_m_TargetScale;

	// Token: 0x04000ADB RID: 2779
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsAnimating;

	// Token: 0x04000ADC RID: 2780
	private static readonly IntPtr NativeFieldInfoPtr_m_bAnimateToPlaceholder;

	// Token: 0x04000ADD RID: 2781
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationDelayAtStart;

	// Token: 0x04000ADE RID: 2782
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationPauseAtDestination;

	// Token: 0x04000ADF RID: 2783
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateCurrentHeight;

	// Token: 0x04000AE0 RID: 2784
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateTargetHeight;

	// Token: 0x04000AE1 RID: 2785
	private static readonly IntPtr NativeFieldInfoPtr_m_bHasAdditionalRotation;

	// Token: 0x04000AE2 RID: 2786
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateAdditionalRotation;

	// Token: 0x04000AE3 RID: 2787
	private static readonly IntPtr NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutWidth;

	// Token: 0x04000AE4 RID: 2788
	private static readonly IntPtr NativeFieldInfoPtr_m_bAdjustPlaceholderLayoutHeight;

	// Token: 0x04000AE5 RID: 2789
	private static readonly IntPtr NativeFieldInfoPtr_m_bReachedDestination;

	// Token: 0x04000AE6 RID: 2790
	private static readonly IntPtr NativeFieldInfoPtr_m_bDestroyAfterAnimation;

	// Token: 0x04000AE7 RID: 2791
	private static readonly IntPtr NativeFieldInfoPtr_m_InternalRotationNode;

	// Token: 0x04000AE8 RID: 2792
	private static readonly IntPtr NativeFieldInfoPtr_m_TargetInternalRotation;

	// Token: 0x04000AE9 RID: 2793
	private static readonly IntPtr NativeFieldInfoPtr_m_DontUpdateInternalRotation;

	// Token: 0x04000AEA RID: 2794
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultInternalRotationRate;

	// Token: 0x04000AEB RID: 2795
	private static readonly IntPtr NativeFieldInfoPtr_m_DestinationLocator;

	// Token: 0x04000AEC RID: 2796
	private static readonly IntPtr NativeFieldInfoPtr_m_OnBeginAnimationCallback;

	// Token: 0x04000AED RID: 2797
	private static readonly IntPtr NativeFieldInfoPtr_m_OnReachDestinationCallback;

	// Token: 0x04000AEE RID: 2798
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEndAnimationCallback;

	// Token: 0x04000AEF RID: 2799
	private static readonly IntPtr NativeFieldInfoPtr_k_ScalePlaceholderByDistance;

	// Token: 0x04000AF0 RID: 2800
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultMovementRateXY;

	// Token: 0x04000AF1 RID: 2801
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultMovementRateZ;

	// Token: 0x04000AF2 RID: 2802
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultRotationRate;

	// Token: 0x04000AF3 RID: 2803
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultScaleRate;

	// Token: 0x04000AF4 RID: 2804
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateMovementRateXY;

	// Token: 0x04000AF5 RID: 2805
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateMovementRateZ;

	// Token: 0x04000AF6 RID: 2806
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateRotationRate;

	// Token: 0x04000AF7 RID: 2807
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateScaleRate;

	// Token: 0x04000AF8 RID: 2808
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateInternalRotationRate;

	// Token: 0x04000AF9 RID: 2809
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0;

	// Token: 0x04000AFA RID: 2810
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0;

	// Token: 0x04000AFB RID: 2811
	private static readonly IntPtr NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000AFC RID: 2812
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000AFD RID: 2813
	private static readonly IntPtr NativeMethodInfoPtr_AddOnReachDestinationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000AFE RID: 2814
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnReachDestinationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000AFF RID: 2815
	private static readonly IntPtr NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000B00 RID: 2816
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationCallback_0;

	// Token: 0x04000B01 RID: 2817
	private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationRates_Public_Void_0;

	// Token: 0x04000B02 RID: 2818
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateMovementRateXY_Public_Void_Single_0;

	// Token: 0x04000B03 RID: 2819
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateMovementRateZ_Public_Void_Single_0;

	// Token: 0x04000B04 RID: 2820
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateRotationRate_Public_Void_Single_0;

	// Token: 0x04000B05 RID: 2821
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateScaleRate_Public_Void_Single_0;

	// Token: 0x04000B06 RID: 2822
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateInternalRotationRate_Public_Void_Single_0;

	// Token: 0x04000B07 RID: 2823
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimateCurrentHeight_Public_Single_0;

	// Token: 0x04000B08 RID: 2824
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimateTargetHeight_Public_Single_0;

	// Token: 0x04000B09 RID: 2825
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateCurrentHeight_Public_Void_Single_0;

	// Token: 0x04000B0A RID: 2826
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateTargetHeight_Public_Void_Single_0;

	// Token: 0x04000B0B RID: 2827
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimateAdditionalRotation_Public_Void_Vector3_0;

	// Token: 0x04000B0C RID: 2828
	private static readonly IntPtr NativeMethodInfoPtr_IsAnimating_Public_Boolean_0;

	// Token: 0x04000B0D RID: 2829
	private static readonly IntPtr NativeMethodInfoPtr_SetAdjustPlaceholderLayoutWidth_Public_Void_Boolean_0;

	// Token: 0x04000B0E RID: 2830
	private static readonly IntPtr NativeMethodInfoPtr_SetAdjustPlaceholderLayoutHeight_Public_Void_Boolean_0;

	// Token: 0x04000B0F RID: 2831
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentScale_Public_Single_0;

	// Token: 0x04000B10 RID: 2832
	private static readonly IntPtr NativeMethodInfoPtr_SetCurrentScale_Public_Void_Single_0;

	// Token: 0x04000B11 RID: 2833
	private static readonly IntPtr NativeMethodInfoPtr_ResetCurrentScale_Public_Void_0;

	// Token: 0x04000B12 RID: 2834
	private static readonly IntPtr NativeMethodInfoPtr_InheritCurrentScale_Public_Void_0;

	// Token: 0x04000B13 RID: 2835
	private static readonly IntPtr NativeMethodInfoPtr_GetTargetScale_Public_Single_0;

	// Token: 0x04000B14 RID: 2836
	private static readonly IntPtr NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0;

	// Token: 0x04000B15 RID: 2837
	private static readonly IntPtr NativeMethodInfoPtr_SetInternalRotationNode_Public_Void_GameObject_0;

	// Token: 0x04000B16 RID: 2838
	private static readonly IntPtr NativeMethodInfoPtr_SetTargetInternalRotation_Public_Void_Vector3_Boolean_0;

	// Token: 0x04000B17 RID: 2839
	private static readonly IntPtr NativeMethodInfoPtr_IncrementDontUpdateInternalRotation_Public_Void_0;

	// Token: 0x04000B18 RID: 2840
	private static readonly IntPtr NativeMethodInfoPtr_DecrementDontUpdateInternalRotation_Public_Void_0;

	// Token: 0x04000B19 RID: 2841
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationPauseAtDestination_Public_Boolean_Single_0;

	// Token: 0x04000B1A RID: 2842
	private static readonly IntPtr NativeMethodInfoPtr_SetDestroyAfterAnimation_Public_Void_0;

	// Token: 0x04000B1B RID: 2843
	private static readonly IntPtr NativeMethodInfoPtr_GetPlaceholder_Public_GameObject_Boolean_0;

	// Token: 0x04000B1C RID: 2844
	private static readonly IntPtr NativeMethodInfoPtr_ResetPlaceholderLayout_Public_Void_Single_Single_0;

	// Token: 0x04000B1D RID: 2845
	private static readonly IntPtr NativeMethodInfoPtr_AssignPlaceholder_Private_GameObject_GameObject_0;

	// Token: 0x04000B1E RID: 2846
	private static readonly IntPtr NativeMethodInfoPtr_DestroyPlaceholder_Public_Void_0;

	// Token: 0x04000B1F RID: 2847
	private static readonly IntPtr NativeMethodInfoPtr_StopAnimation_Private_Void_0;

	// Token: 0x04000B20 RID: 2848
	private static readonly IntPtr NativeMethodInfoPtr_DestroyAnimation_Public_Boolean_0;

	// Token: 0x04000B21 RID: 2849
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimation_Private_Void_Single_Single_AnimationLocator_AnimationLocator_0;

	// Token: 0x04000B22 RID: 2850
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Void_GameObject_Single_Single_0;

	// Token: 0x04000B23 RID: 2851
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimationToLocator_Public_Void_AnimationLocator_AnimationLocator_Single_Single_0;

	// Token: 0x04000B24 RID: 2852
	private static readonly IntPtr NativeMethodInfoPtr_PlaceOnAnimationLocator_Public_Void_AnimationLocator_Boolean_Boolean_Int32_0;

	// Token: 0x04000B25 RID: 2853
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlaceholder_Private_Void_0;

	// Token: 0x04000B26 RID: 2854
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Boolean_Single_0;

	// Token: 0x04000B27 RID: 2855
	private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Public_Boolean_0;

	// Token: 0x04000B28 RID: 2856
	private static readonly IntPtr NativeMethodInfoPtr_UpdateInternalRotation_Public_Boolean_0;

	// Token: 0x04000B29 RID: 2857
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimate_Public_Virtual_New_Boolean_Single_0;

	// Token: 0x04000B2A RID: 2858
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000190 RID: 400
	public sealed class AnimationCallback : MulticastDelegate
	{
		// Token: 0x0600245B RID: 9307 RVA: 0x000874F8 File Offset: 0x000856F8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationCallback()
		{
			Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimateObject>.NativeClassPtr, "AnimationCallback");
			AnimateObject.AnimationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr, 100666188);
			AnimateObject.AnimationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr, 100666189);
			AnimateObject.AnimationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_AnimationLocator_AnimationLocator_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr, 100666190);
			AnimateObject.AnimationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr, 100666191);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0008756C File Offset: 0x0008576C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateObject.AnimationCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.AnimationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x000875C8 File Offset: 0x000857C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 240602, RefRangeEnd = 240608, XrefRangeStart = 240583, XrefRangeEnd = 240602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.AnimationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00087630 File Offset: 0x00085830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240608, XrefRangeEnd = 240609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.AnimationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_AnimationLocator_AnimationLocator_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x000876CC File Offset: 0x000858CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateObject.AnimationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x000169F3 File Offset: 0x00014BF3
		public AnimationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x000169FC File Offset: 0x00014BFC
		public static implicit operator AnimateObject.AnimationCallback(Action<AnimateObject, AnimationLocator, AnimationLocator> A_0)
		{
			return DelegateSupport.ConvertDelegate<AnimateObject.AnimationCallback>(A_0);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00016A04 File Offset: 0x00014C04
		public static AnimateObject.AnimationCallback operator +(AnimateObject.AnimationCallback A_0, AnimateObject.AnimationCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AnimateObject.AnimationCallback>();
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00016A12 File Offset: 0x00014C12
		public static AnimateObject.AnimationCallback operator -(AnimateObject.AnimationCallback A_0, AnimateObject.AnimationCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AnimateObject.AnimationCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_AnimationLocator_AnimationLocator_AsyncCallback_Object_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
