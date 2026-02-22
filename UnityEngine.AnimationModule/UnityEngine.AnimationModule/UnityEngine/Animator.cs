using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class Animator : Behaviour
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00006F8C File Offset: 0x0000518C
		// Note: this type is marked as 'beforefieldinit'.
		static Animator()
		{
			Il2CppClassPointerStore<Animator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Animator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animator>.NativeClassPtr);
			Animator.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663314);
			Animator.NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663315);
			Animator.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663316);
			Animator.NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663317);
			Animator.NativeMethodInfoPtr_SetInteger_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663318);
			Animator.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663319);
			Animator.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663320);
			Animator.NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663321);
			Animator.NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663322);
			Animator.NativeMethodInfoPtr_IsInTransition_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663323);
			Animator.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663324);
			Animator.NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663325);
			Animator.NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663326);
			Animator.NativeMethodInfoPtr_SetBoolString_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663327);
			Animator.NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663328);
			Animator.NativeMethodInfoPtr_GetBoolID_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663329);
			Animator.NativeMethodInfoPtr_SetIntegerString_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663330);
			Animator.NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663331);
			Animator.NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663332);
			Animator.get_isOptimizableDelegateField = IL2CPP.ResolveICall<Animator.get_isOptimizableDelegate>("UnityEngine.Animator::get_isOptimizable");
			Animator.get_isHumanDelegateField = IL2CPP.ResolveICall<Animator.get_isHumanDelegate>("UnityEngine.Animator::get_isHuman");
			Animator.get_hasRootMotionDelegateField = IL2CPP.ResolveICall<Animator.get_hasRootMotionDelegate>("UnityEngine.Animator::get_hasRootMotion");
			Animator.get_isRootPositionOrRotationControlledByCurvesDelegateField = IL2CPP.ResolveICall<Animator.get_isRootPositionOrRotationControlledByCurvesDelegate>("UnityEngine.Animator::get_isRootPositionOrRotationControlledByCurves");
			Animator.get_humanScaleDelegateField = IL2CPP.ResolveICall<Animator.get_humanScaleDelegate>("UnityEngine.Animator::get_humanScale");
			Animator.get_applyRootMotionDelegateField = IL2CPP.ResolveICall<Animator.get_applyRootMotionDelegate>("UnityEngine.Animator::get_applyRootMotion");
			Animator.set_applyRootMotionDelegateField = IL2CPP.ResolveICall<Animator.set_applyRootMotionDelegate>("UnityEngine.Animator::set_applyRootMotion");
			Animator.get_linearVelocityBlendingDelegateField = IL2CPP.ResolveICall<Animator.get_linearVelocityBlendingDelegate>("UnityEngine.Animator::get_linearVelocityBlending");
			Animator.set_linearVelocityBlendingDelegateField = IL2CPP.ResolveICall<Animator.set_linearVelocityBlendingDelegate>("UnityEngine.Animator::set_linearVelocityBlending");
			Animator.get_updateModeDelegateField = IL2CPP.ResolveICall<Animator.get_updateModeDelegate>("UnityEngine.Animator::get_updateMode");
			Animator.set_updateModeDelegateField = IL2CPP.ResolveICall<Animator.set_updateModeDelegate>("UnityEngine.Animator::set_updateMode");
			Animator.get_hasTransformHierarchyDelegateField = IL2CPP.ResolveICall<Animator.get_hasTransformHierarchyDelegate>("UnityEngine.Animator::get_hasTransformHierarchy");
			Animator.get_allowConstantClipSamplingOptimizationDelegateField = IL2CPP.ResolveICall<Animator.get_allowConstantClipSamplingOptimizationDelegate>("UnityEngine.Animator::get_allowConstantClipSamplingOptimization");
			Animator.set_allowConstantClipSamplingOptimizationDelegateField = IL2CPP.ResolveICall<Animator.set_allowConstantClipSamplingOptimizationDelegate>("UnityEngine.Animator::set_allowConstantClipSamplingOptimization");
			Animator.get_gravityWeightDelegateField = IL2CPP.ResolveICall<Animator.get_gravityWeightDelegate>("UnityEngine.Animator::get_gravityWeight");
			Animator.GetGoalWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.GetGoalWeightPositionDelegate>("UnityEngine.Animator::GetGoalWeightPosition");
			Animator.SetGoalWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.SetGoalWeightPositionDelegate>("UnityEngine.Animator::SetGoalWeightPosition");
			Animator.GetGoalWeightRotationDelegateField = IL2CPP.ResolveICall<Animator.GetGoalWeightRotationDelegate>("UnityEngine.Animator::GetGoalWeightRotation");
			Animator.SetGoalWeightRotationDelegateField = IL2CPP.ResolveICall<Animator.SetGoalWeightRotationDelegate>("UnityEngine.Animator::SetGoalWeightRotation");
			Animator.GetHintWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.GetHintWeightPositionDelegate>("UnityEngine.Animator::GetHintWeightPosition");
			Animator.SetHintWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.SetHintWeightPositionDelegate>("UnityEngine.Animator::SetHintWeightPosition");
			Animator.SetLookAtWeightInternalDelegateField = IL2CPP.ResolveICall<Animator.SetLookAtWeightInternalDelegate>("UnityEngine.Animator::SetLookAtWeightInternal");
			Animator.GetBehaviourDelegateField = IL2CPP.ResolveICall<Animator.GetBehaviourDelegate>("UnityEngine.Animator::GetBehaviour");
			Animator.InternalGetBehavioursDelegateField = IL2CPP.ResolveICall<Animator.InternalGetBehavioursDelegate>("UnityEngine.Animator::InternalGetBehaviours");
			Animator.InternalGetBehavioursByKeyDelegateField = IL2CPP.ResolveICall<Animator.InternalGetBehavioursByKeyDelegate>("UnityEngine.Animator::InternalGetBehavioursByKey");
			Animator.get_stabilizeFeetDelegateField = IL2CPP.ResolveICall<Animator.get_stabilizeFeetDelegate>("UnityEngine.Animator::get_stabilizeFeet");
			Animator.set_stabilizeFeetDelegateField = IL2CPP.ResolveICall<Animator.set_stabilizeFeetDelegate>("UnityEngine.Animator::set_stabilizeFeet");
			Animator.get_layerCountDelegateField = IL2CPP.ResolveICall<Animator.get_layerCountDelegate>("UnityEngine.Animator::get_layerCount");
			Animator.GetLayerNameDelegateField = IL2CPP.ResolveICall<Animator.GetLayerNameDelegate>("UnityEngine.Animator::GetLayerName");
			Animator.GetLayerIndexDelegateField = IL2CPP.ResolveICall<Animator.GetLayerIndexDelegate>("UnityEngine.Animator::GetLayerIndex");
			Animator.GetLayerWeightDelegateField = IL2CPP.ResolveICall<Animator.GetLayerWeightDelegate>("UnityEngine.Animator::GetLayerWeight");
			Animator.SetLayerWeightDelegateField = IL2CPP.ResolveICall<Animator.SetLayerWeightDelegate>("UnityEngine.Animator::SetLayerWeight");
			Animator.GetAnimatorTransitionInfoDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorTransitionInfoDelegate>("UnityEngine.Animator::GetAnimatorTransitionInfo");
			Animator.GetAnimatorClipInfoCountDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorClipInfoCountDelegate>("UnityEngine.Animator::GetAnimatorClipInfoCount");
			Animator.GetCurrentAnimatorClipInfoDelegateField = IL2CPP.ResolveICall<Animator.GetCurrentAnimatorClipInfoDelegate>("UnityEngine.Animator::GetCurrentAnimatorClipInfo");
			Animator.GetNextAnimatorClipInfoDelegateField = IL2CPP.ResolveICall<Animator.GetNextAnimatorClipInfoDelegate>("UnityEngine.Animator::GetNextAnimatorClipInfo");
			Animator.GetAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorClipInfoInternalDelegate>("UnityEngine.Animator::GetAnimatorClipInfoInternal");
			Animator.get_parametersDelegateField = IL2CPP.ResolveICall<Animator.get_parametersDelegate>("UnityEngine.Animator::get_parameters");
			Animator.get_parameterCountDelegateField = IL2CPP.ResolveICall<Animator.get_parameterCountDelegate>("UnityEngine.Animator::get_parameterCount");
			Animator.get_feetPivotActiveDelegateField = IL2CPP.ResolveICall<Animator.get_feetPivotActiveDelegate>("UnityEngine.Animator::get_feetPivotActive");
			Animator.set_feetPivotActiveDelegateField = IL2CPP.ResolveICall<Animator.set_feetPivotActiveDelegate>("UnityEngine.Animator::set_feetPivotActive");
			Animator.get_pivotWeightDelegateField = IL2CPP.ResolveICall<Animator.get_pivotWeightDelegate>("UnityEngine.Animator::get_pivotWeight");
			Animator.InterruptMatchTargetDelegateField = IL2CPP.ResolveICall<Animator.InterruptMatchTargetDelegate>("UnityEngine.Animator::InterruptMatchTarget");
			Animator.get_isMatchingTargetDelegateField = IL2CPP.ResolveICall<Animator.get_isMatchingTargetDelegate>("UnityEngine.Animator::get_isMatchingTarget");
			Animator.get_speedDelegateField = IL2CPP.ResolveICall<Animator.get_speedDelegate>("UnityEngine.Animator::get_speed");
			Animator.set_speedDelegateField = IL2CPP.ResolveICall<Animator.set_speedDelegate>("UnityEngine.Animator::set_speed");
			Animator.CrossFadeInFixedTimeDelegateField = IL2CPP.ResolveICall<Animator.CrossFadeInFixedTimeDelegate>("UnityEngine.Animator::CrossFadeInFixedTime");
			Animator.WriteDefaultValuesDelegateField = IL2CPP.ResolveICall<Animator.WriteDefaultValuesDelegate>("UnityEngine.Animator::WriteDefaultValues");
			Animator.CrossFadeDelegateField = IL2CPP.ResolveICall<Animator.CrossFadeDelegate>("UnityEngine.Animator::CrossFade");
			Animator.PlayInFixedTimeDelegateField = IL2CPP.ResolveICall<Animator.PlayInFixedTimeDelegate>("UnityEngine.Animator::PlayInFixedTime");
			Animator.PlayDelegateField = IL2CPP.ResolveICall<Animator.PlayDelegate>("UnityEngine.Animator::Play");
			Animator.SetTargetDelegateField = IL2CPP.ResolveICall<Animator.SetTargetDelegate>("UnityEngine.Animator::SetTarget");
			Animator.IsBoneTransformDelegateField = IL2CPP.ResolveICall<Animator.IsBoneTransformDelegate>("UnityEngine.Animator::IsBoneTransform");
			Animator.get_avatarRootDelegateField = IL2CPP.ResolveICall<Animator.get_avatarRootDelegate>("UnityEngine.Animator::get_avatarRoot");
			Animator.GetBoneTransformInternalDelegateField = IL2CPP.ResolveICall<Animator.GetBoneTransformInternalDelegate>("UnityEngine.Animator::GetBoneTransformInternal");
			Animator.get_cullingModeDelegateField = IL2CPP.ResolveICall<Animator.get_cullingModeDelegate>("UnityEngine.Animator::get_cullingMode");
			Animator.set_cullingModeDelegateField = IL2CPP.ResolveICall<Animator.set_cullingModeDelegate>("UnityEngine.Animator::set_cullingMode");
			Animator.StartPlaybackDelegateField = IL2CPP.ResolveICall<Animator.StartPlaybackDelegate>("UnityEngine.Animator::StartPlayback");
			Animator.StopPlaybackDelegateField = IL2CPP.ResolveICall<Animator.StopPlaybackDelegate>("UnityEngine.Animator::StopPlayback");
			Animator.get_playbackTimeDelegateField = IL2CPP.ResolveICall<Animator.get_playbackTimeDelegate>("UnityEngine.Animator::get_playbackTime");
			Animator.set_playbackTimeDelegateField = IL2CPP.ResolveICall<Animator.set_playbackTimeDelegate>("UnityEngine.Animator::set_playbackTime");
			Animator.StartRecordingDelegateField = IL2CPP.ResolveICall<Animator.StartRecordingDelegate>("UnityEngine.Animator::StartRecording");
			Animator.StopRecordingDelegateField = IL2CPP.ResolveICall<Animator.StopRecordingDelegate>("UnityEngine.Animator::StopRecording");
			Animator.GetRecorderStartTimeDelegateField = IL2CPP.ResolveICall<Animator.GetRecorderStartTimeDelegate>("UnityEngine.Animator::GetRecorderStartTime");
			Animator.GetRecorderStopTimeDelegateField = IL2CPP.ResolveICall<Animator.GetRecorderStopTimeDelegate>("UnityEngine.Animator::GetRecorderStopTime");
			Animator.get_recorderModeDelegateField = IL2CPP.ResolveICall<Animator.get_recorderModeDelegate>("UnityEngine.Animator::get_recorderMode");
			Animator.get_runtimeAnimatorControllerDelegateField = IL2CPP.ResolveICall<Animator.get_runtimeAnimatorControllerDelegate>("UnityEngine.Animator::get_runtimeAnimatorController");
			Animator.ClearInternalControllerPlayableDelegateField = IL2CPP.ResolveICall<Animator.ClearInternalControllerPlayableDelegate>("UnityEngine.Animator::ClearInternalControllerPlayable");
			Animator.HasStateDelegateField = IL2CPP.ResolveICall<Animator.HasStateDelegate>("UnityEngine.Animator::HasState");
			Animator.get_avatarDelegateField = IL2CPP.ResolveICall<Animator.get_avatarDelegate>("UnityEngine.Animator::get_avatar");
			Animator.set_avatarDelegateField = IL2CPP.ResolveICall<Animator.set_avatarDelegate>("UnityEngine.Animator::set_avatar");
			Animator.GetStatsDelegateField = IL2CPP.ResolveICall<Animator.GetStatsDelegate>("UnityEngine.Animator::GetStats");
			Animator.GetCurrentGraphDelegateField = IL2CPP.ResolveICall<Animator.GetCurrentGraphDelegate>("UnityEngine.Animator::GetCurrentGraph");
			Animator.IsInIKPassDelegateField = IL2CPP.ResolveICall<Animator.IsInIKPassDelegate>("UnityEngine.Animator::IsInIKPass");
			Animator.SetFloatStringDelegateField = IL2CPP.ResolveICall<Animator.SetFloatStringDelegate>("UnityEngine.Animator::SetFloatString");
			Animator.SetFloatIDDelegateField = IL2CPP.ResolveICall<Animator.SetFloatIDDelegate>("UnityEngine.Animator::SetFloatID");
			Animator.GetFloatStringDelegateField = IL2CPP.ResolveICall<Animator.GetFloatStringDelegate>("UnityEngine.Animator::GetFloatString");
			Animator.GetFloatIDDelegateField = IL2CPP.ResolveICall<Animator.GetFloatIDDelegate>("UnityEngine.Animator::GetFloatID");
			Animator.GetBoolStringDelegateField = IL2CPP.ResolveICall<Animator.GetBoolStringDelegate>("UnityEngine.Animator::GetBoolString");
			Animator.SetIntegerIDDelegateField = IL2CPP.ResolveICall<Animator.SetIntegerIDDelegate>("UnityEngine.Animator::SetIntegerID");
			Animator.GetIntegerStringDelegateField = IL2CPP.ResolveICall<Animator.GetIntegerStringDelegate>("UnityEngine.Animator::GetIntegerString");
			Animator.GetIntegerIDDelegateField = IL2CPP.ResolveICall<Animator.GetIntegerIDDelegate>("UnityEngine.Animator::GetIntegerID");
			Animator.SetTriggerIDDelegateField = IL2CPP.ResolveICall<Animator.SetTriggerIDDelegate>("UnityEngine.Animator::SetTriggerID");
			Animator.ResetTriggerIDDelegateField = IL2CPP.ResolveICall<Animator.ResetTriggerIDDelegate>("UnityEngine.Animator::ResetTriggerID");
			Animator.IsParameterControlledByCurveStringDelegateField = IL2CPP.ResolveICall<Animator.IsParameterControlledByCurveStringDelegate>("UnityEngine.Animator::IsParameterControlledByCurveString");
			Animator.IsParameterControlledByCurveIDDelegateField = IL2CPP.ResolveICall<Animator.IsParameterControlledByCurveIDDelegate>("UnityEngine.Animator::IsParameterControlledByCurveID");
			Animator.SetFloatStringDampDelegateField = IL2CPP.ResolveICall<Animator.SetFloatStringDampDelegate>("UnityEngine.Animator::SetFloatStringDamp");
			Animator.SetFloatIDDampDelegateField = IL2CPP.ResolveICall<Animator.SetFloatIDDampDelegate>("UnityEngine.Animator::SetFloatIDDamp");
			Animator.get_layersAffectMassCenterDelegateField = IL2CPP.ResolveICall<Animator.get_layersAffectMassCenterDelegate>("UnityEngine.Animator::get_layersAffectMassCenter");
			Animator.set_layersAffectMassCenterDelegateField = IL2CPP.ResolveICall<Animator.set_layersAffectMassCenterDelegate>("UnityEngine.Animator::set_layersAffectMassCenter");
			Animator.get_leftFeetBottomHeightDelegateField = IL2CPP.ResolveICall<Animator.get_leftFeetBottomHeightDelegate>("UnityEngine.Animator::get_leftFeetBottomHeight");
			Animator.get_rightFeetBottomHeightDelegateField = IL2CPP.ResolveICall<Animator.get_rightFeetBottomHeightDelegate>("UnityEngine.Animator::get_rightFeetBottomHeight");
			Animator.get_supportsOnAnimatorMoveDelegateField = IL2CPP.ResolveICall<Animator.get_supportsOnAnimatorMoveDelegate>("UnityEngine.Animator::get_supportsOnAnimatorMove");
			Animator.OnUpdateModeChangedDelegateField = IL2CPP.ResolveICall<Animator.OnUpdateModeChangedDelegate>("UnityEngine.Animator::OnUpdateModeChanged");
			Animator.OnCullingModeChangedDelegateField = IL2CPP.ResolveICall<Animator.OnCullingModeChangedDelegate>("UnityEngine.Animator::OnCullingModeChanged");
			Animator.WriteDefaultPoseDelegateField = IL2CPP.ResolveICall<Animator.WriteDefaultPoseDelegate>("UnityEngine.Animator::WriteDefaultPose");
			Animator.UpdateDelegateField = IL2CPP.ResolveICall<Animator.UpdateDelegate>("UnityEngine.Animator::Update");
			Animator.RebindDelegateField = IL2CPP.ResolveICall<Animator.RebindDelegate>("UnityEngine.Animator::Rebind");
			Animator.ApplyBuiltinRootMotionDelegateField = IL2CPP.ResolveICall<Animator.ApplyBuiltinRootMotionDelegate>("UnityEngine.Animator::ApplyBuiltinRootMotion");
			Animator.EvaluateControllerDelegateField = IL2CPP.ResolveICall<Animator.EvaluateControllerDelegate>("UnityEngine.Animator::EvaluateController");
			Animator.GetAnimatorStateNameDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorStateNameDelegate>("UnityEngine.Animator::GetAnimatorStateName");
			Animator.ResolveHashDelegateField = IL2CPP.ResolveICall<Animator.ResolveHashDelegate>("UnityEngine.Animator::ResolveHash");
			Animator.get_logWarningsDelegateField = IL2CPP.ResolveICall<Animator.get_logWarningsDelegate>("UnityEngine.Animator::get_logWarnings");
			Animator.set_logWarningsDelegateField = IL2CPP.ResolveICall<Animator.set_logWarningsDelegate>("UnityEngine.Animator::set_logWarnings");
			Animator.get_fireEventsDelegateField = IL2CPP.ResolveICall<Animator.get_fireEventsDelegate>("UnityEngine.Animator::get_fireEvents");
			Animator.set_fireEventsDelegateField = IL2CPP.ResolveICall<Animator.set_fireEventsDelegate>("UnityEngine.Animator::set_fireEvents");
			Animator.get_keepAnimatorControllerStateOnDisableDelegateField = IL2CPP.ResolveICall<Animator.get_keepAnimatorControllerStateOnDisableDelegate>("UnityEngine.Animator::get_keepAnimatorControllerStateOnDisable");
			Animator.set_keepAnimatorControllerStateOnDisableDelegateField = IL2CPP.ResolveICall<Animator.set_keepAnimatorControllerStateOnDisableDelegate>("UnityEngine.Animator::set_keepAnimatorControllerStateOnDisable");
			Animator.get_deltaPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_deltaPosition_InjectedDelegate>("UnityEngine.Animator::get_deltaPosition_Injected");
			Animator.get_deltaRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_deltaRotation_InjectedDelegate>("UnityEngine.Animator::get_deltaRotation_Injected");
			Animator.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_velocity_InjectedDelegate>("UnityEngine.Animator::get_velocity_Injected");
			Animator.get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_angularVelocity_InjectedDelegate>("UnityEngine.Animator::get_angularVelocity_Injected");
			Animator.get_rootPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_rootPosition_InjectedDelegate>("UnityEngine.Animator::get_rootPosition_Injected");
			Animator.set_rootPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_rootPosition_InjectedDelegate>("UnityEngine.Animator::set_rootPosition_Injected");
			Animator.get_rootRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_rootRotation_InjectedDelegate>("UnityEngine.Animator::get_rootRotation_Injected");
			Animator.set_rootRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_rootRotation_InjectedDelegate>("UnityEngine.Animator::set_rootRotation_Injected");
			Animator.get_bodyPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_bodyPositionInternal_InjectedDelegate>("UnityEngine.Animator::get_bodyPositionInternal_Injected");
			Animator.set_bodyPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_bodyPositionInternal_InjectedDelegate>("UnityEngine.Animator::set_bodyPositionInternal_Injected");
			Animator.get_bodyRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_bodyRotationInternal_InjectedDelegate>("UnityEngine.Animator::get_bodyRotationInternal_Injected");
			Animator.set_bodyRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_bodyRotationInternal_InjectedDelegate>("UnityEngine.Animator::set_bodyRotationInternal_Injected");
			Animator.GetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetGoalPosition_InjectedDelegate>("UnityEngine.Animator::GetGoalPosition_Injected");
			Animator.SetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetGoalPosition_InjectedDelegate>("UnityEngine.Animator::SetGoalPosition_Injected");
			Animator.GetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetGoalRotation_InjectedDelegate>("UnityEngine.Animator::GetGoalRotation_Injected");
			Animator.SetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetGoalRotation_InjectedDelegate>("UnityEngine.Animator::SetGoalRotation_Injected");
			Animator.GetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetHintPosition_InjectedDelegate>("UnityEngine.Animator::GetHintPosition_Injected");
			Animator.SetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetHintPosition_InjectedDelegate>("UnityEngine.Animator::SetHintPosition_Injected");
			Animator.SetLookAtPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetLookAtPositionInternal_InjectedDelegate>("UnityEngine.Animator::SetLookAtPositionInternal_Injected");
			Animator.SetBoneLocalRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetBoneLocalRotationInternal_InjectedDelegate>("UnityEngine.Animator::SetBoneLocalRotationInternal_Injected");
			Animator.get_pivotPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_pivotPosition_InjectedDelegate>("UnityEngine.Animator::get_pivotPosition_Injected");
			Animator.get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_targetPosition_InjectedDelegate>("UnityEngine.Animator::get_targetPosition_Injected");
			Animator.get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_targetRotation_InjectedDelegate>("UnityEngine.Animator::get_targetRotation_Injected");
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000078E8 File Offset: 0x00005AE8
		public unsafe bool isInitialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89910, RefRangeEnd = 89911, XrefRangeStart = 89908, XrefRangeEnd = 89910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007924 File Offset: 0x00005B24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89913, RefRangeEnd = 89915, XrefRangeStart = 89911, XrefRangeEnd = 89913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007970 File Offset: 0x00005B70
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 89917, RefRangeEnd = 89928, XrefRangeStart = 89915, XrefRangeEnd = 89917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000079C0 File Offset: 0x00005BC0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 89930, RefRangeEnd = 89943, XrefRangeStart = 89928, XrefRangeEnd = 89930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(int id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007A0C File Offset: 0x00005C0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89945, RefRangeEnd = 89949, XrefRangeStart = 89943, XrefRangeEnd = 89945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteger(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetInteger_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007A5C File Offset: 0x00005C5C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 89951, RefRangeEnd = 89961, XrefRangeStart = 89949, XrefRangeEnd = 89951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 89963, RefRangeEnd = 89968, XrefRangeStart = 89961, XrefRangeEnd = 89963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89968, XrefRangeEnd = 89970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateInfoIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007B40 File Offset: 0x00005D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89972, RefRangeEnd = 89974, XrefRangeStart = 89970, XrefRangeEnd = 89972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007B8C File Offset: 0x00005D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89976, RefRangeEnd = 89978, XrefRangeStart = 89974, XrefRangeEnd = 89976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInTransition(int layerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_IsInTransition_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00008800 File Offset: 0x00006A00
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00007BD8 File Offset: 0x00005DD8
		public unsafe RuntimeAnimatorController runtimeAnimatorController
		{
			get
			{
				IntPtr intPtr = Animator.get_runtimeAnimatorControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89980, RefRangeEnd = 89983, XrefRangeStart = 89978, XrefRangeEnd = 89980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00007C1C File Offset: 0x00005E1C
		public unsafe bool hasBoundPlayables
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89985, RefRangeEnd = 89986, XrefRangeStart = 89983, XrefRangeEnd = 89985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007C58 File Offset: 0x00005E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89988, RefRangeEnd = 89989, XrefRangeStart = 89986, XrefRangeEnd = 89988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToHash(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007C9C File Offset: 0x00005E9C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 89917, RefRangeEnd = 89928, XrefRangeStart = 89917, XrefRangeEnd = 89928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoolString(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBoolString_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007CEC File Offset: 0x00005EEC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 89930, RefRangeEnd = 89943, XrefRangeStart = 89930, XrefRangeEnd = 89943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoolID(int id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007D38 File Offset: 0x00005F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89913, RefRangeEnd = 89915, XrefRangeStart = 89913, XrefRangeEnd = 89915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetBoolID_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89945, RefRangeEnd = 89949, XrefRangeStart = 89945, XrefRangeEnd = 89949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntegerString(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetIntegerString_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007DD4 File Offset: 0x00005FD4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 89951, RefRangeEnd = 89961, XrefRangeStart = 89951, XrefRangeEnd = 89961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriggerString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007E18 File Offset: 0x00006018
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 89963, RefRangeEnd = 89968, XrefRangeStart = 89963, XrefRangeEnd = 89968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTriggerString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002630 File Offset: 0x00000830
		public Animator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002639 File Offset: 0x00000839
		public bool isOptimizable
		{
			get
			{
				return Animator.get_isOptimizableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000264B File Offset: 0x0000084B
		public bool isHuman
		{
			get
			{
				return Animator.get_isHumanDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000265D File Offset: 0x0000085D
		public bool hasRootMotion
		{
			get
			{
				return Animator.get_hasRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000266F File Offset: 0x0000086F
		public bool isRootPositionOrRotationControlledByCurves
		{
			get
			{
				return Animator.get_isRootPositionOrRotationControlledByCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002681 File Offset: 0x00000881
		public float humanScale
		{
			get
			{
				return Animator.get_humanScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007E5C File Offset: 0x0000605C
		public float GetFloat(string name)
		{
			return this.GetFloatString(name);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007E78 File Offset: 0x00006078
		public float GetFloat(int id)
		{
			return this.GetFloatID(id);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002693 File Offset: 0x00000893
		public void SetFloat(string name, float value)
		{
			this.SetFloatString(name, value);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000269F File Offset: 0x0000089F
		public void SetFloat(string name, float value, float dampTime, float deltaTime)
		{
			this.SetFloatStringDamp(name, value, dampTime, deltaTime);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000026AE File Offset: 0x000008AE
		public void SetFloat(int id, float value)
		{
			this.SetFloatID(id, value);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000026BA File Offset: 0x000008BA
		public void SetFloat(int id, float value, float dampTime, float deltaTime)
		{
			this.SetFloatIDDamp(id, value, dampTime, deltaTime);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007E94 File Offset: 0x00006094
		public bool GetBool(string name)
		{
			return this.GetBoolString(name);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007EB0 File Offset: 0x000060B0
		public int GetInteger(string name)
		{
			return this.GetIntegerString(name);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00007ECC File Offset: 0x000060CC
		public int GetInteger(int id)
		{
			return this.GetIntegerID(id);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000026C9 File Offset: 0x000008C9
		public void SetInteger(int id, int value)
		{
			this.SetIntegerID(id, value);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000026D5 File Offset: 0x000008D5
		public void SetTrigger(int id)
		{
			this.SetTriggerID(id);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000026E0 File Offset: 0x000008E0
		public void ResetTrigger(int id)
		{
			this.ResetTriggerID(id);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00007EE8 File Offset: 0x000060E8
		public bool IsParameterControlledByCurve(string name)
		{
			return this.IsParameterControlledByCurveString(name);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007F04 File Offset: 0x00006104
		public bool IsParameterControlledByCurve(int id)
		{
			return this.IsParameterControlledByCurveID(id);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00007F20 File Offset: 0x00006120
		public Vector3 deltaPosition
		{
			get
			{
				Vector3 vector;
				this.get_deltaPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00007F38 File Offset: 0x00006138
		public Quaternion deltaRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_deltaRotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007F50 File Offset: 0x00006150
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007F68 File Offset: 0x00006168
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00007F80 File Offset: 0x00006180
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000026EB File Offset: 0x000008EB
		public Vector3 rootPosition
		{
			get
			{
				Vector3 vector;
				this.get_rootPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rootPosition_Injected(ref value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00007F98 File Offset: 0x00006198
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000026F5 File Offset: 0x000008F5
		public Quaternion rootRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_rootRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_rootRotation_Injected(ref value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000026FF File Offset: 0x000008FF
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002711 File Offset: 0x00000911
		public bool applyRootMotion
		{
			get
			{
				return Animator.get_applyRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_applyRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002724 File Offset: 0x00000924
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002736 File Offset: 0x00000936
		public bool linearVelocityBlending
		{
			get
			{
				return Animator.get_linearVelocityBlendingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_linearVelocityBlendingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00007FB0 File Offset: 0x000061B0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002749 File Offset: 0x00000949
		public bool animatePhysics
		{
			get
			{
				return this.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
			set
			{
				this.updateMode = (value ? AnimatorUpdateMode.AnimatePhysics : AnimatorUpdateMode.Normal);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000275A File Offset: 0x0000095A
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000276C File Offset: 0x0000096C
		public AnimatorUpdateMode updateMode
		{
			get
			{
				return Animator.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000277F File Offset: 0x0000097F
		public bool hasTransformHierarchy
		{
			get
			{
				return Animator.get_hasTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002791 File Offset: 0x00000991
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000027A3 File Offset: 0x000009A3
		public bool allowConstantClipSamplingOptimization
		{
			get
			{
				return Animator.get_allowConstantClipSamplingOptimizationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_allowConstantClipSamplingOptimizationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000027B6 File Offset: 0x000009B6
		public float gravityWeight
		{
			get
			{
				return Animator.get_gravityWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007FCC File Offset: 0x000061CC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000027C8 File Offset: 0x000009C8
		public Vector3 bodyPosition
		{
			get
			{
				this.CheckIfInIKPass();
				return this.bodyPositionInternal;
			}
			set
			{
				this.CheckIfInIKPass();
				this.bodyPositionInternal = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00007FEC File Offset: 0x000061EC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000027DA File Offset: 0x000009DA
		public Vector3 bodyPositionInternal
		{
			get
			{
				Vector3 vector;
				this.get_bodyPositionInternal_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_bodyPositionInternal_Injected(ref value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008004 File Offset: 0x00006204
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000027E4 File Offset: 0x000009E4
		public Quaternion bodyRotation
		{
			get
			{
				this.CheckIfInIKPass();
				return this.bodyRotationInternal;
			}
			set
			{
				this.CheckIfInIKPass();
				this.bodyRotationInternal = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008024 File Offset: 0x00006224
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000027F6 File Offset: 0x000009F6
		public Quaternion bodyRotationInternal
		{
			get
			{
				Quaternion quaternion;
				this.get_bodyRotationInternal_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_bodyRotationInternal_Injected(ref value);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000803C File Offset: 0x0000623C
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalPosition(goal);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000805C File Offset: 0x0000625C
		public Vector3 GetGoalPosition(AvatarIKGoal goal)
		{
			Vector3 vector;
			this.GetGoalPosition_Injected(goal, out vector);
			return vector;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002800 File Offset: 0x00000A00
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.CheckIfInIKPass();
			this.SetGoalPosition(goal, goalPosition);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002813 File Offset: 0x00000A13
		public void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.SetGoalPosition_Injected(goal, ref goalPosition);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008074 File Offset: 0x00006274
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalRotation(goal);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008094 File Offset: 0x00006294
		public Quaternion GetGoalRotation(AvatarIKGoal goal)
		{
			Quaternion quaternion;
			this.GetGoalRotation_Injected(goal, out quaternion);
			return quaternion;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000281E File Offset: 0x00000A1E
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.CheckIfInIKPass();
			this.SetGoalRotation(goal, goalRotation);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002831 File Offset: 0x00000A31
		public void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.SetGoalRotation_Injected(goal, ref goalRotation);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000080AC File Offset: 0x000062AC
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalWeightPosition(goal);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000283C File Offset: 0x00000A3C
		public float GetGoalWeightPosition(AvatarIKGoal goal)
		{
			return Animator.GetGoalWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000284F File Offset: 0x00000A4F
		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetGoalWeightPosition(goal, value);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002862 File Offset: 0x00000A62
		public void SetGoalWeightPosition(AvatarIKGoal goal, float value)
		{
			Animator.SetGoalWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, value);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000080CC File Offset: 0x000062CC
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalWeightRotation(goal);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002876 File Offset: 0x00000A76
		public float GetGoalWeightRotation(AvatarIKGoal goal)
		{
			return Animator.GetGoalWeightRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002889 File Offset: 0x00000A89
		public void SetIKRotationWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetGoalWeightRotation(goal, value);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000289C File Offset: 0x00000A9C
		public void SetGoalWeightRotation(AvatarIKGoal goal, float value)
		{
			Animator.SetGoalWeightRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, value);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000080EC File Offset: 0x000062EC
		public Vector3 GetIKHintPosition(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintPosition(hint);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000810C File Offset: 0x0000630C
		public Vector3 GetHintPosition(AvatarIKHint hint)
		{
			Vector3 vector;
			this.GetHintPosition_Injected(hint, out vector);
			return vector;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000028B0 File Offset: 0x00000AB0
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.CheckIfInIKPass();
			this.SetHintPosition(hint, hintPosition);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000028C3 File Offset: 0x00000AC3
		public void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.SetHintPosition_Injected(hint, ref hintPosition);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008124 File Offset: 0x00006324
		public float GetIKHintPositionWeight(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintWeightPosition(hint);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000028CE File Offset: 0x00000ACE
		public float GetHintWeightPosition(AvatarIKHint hint)
		{
			return Animator.GetHintWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000028E1 File Offset: 0x00000AE1
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
		{
			this.CheckIfInIKPass();
			this.SetHintWeightPosition(hint, value);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000028F4 File Offset: 0x00000AF4
		public void SetHintWeightPosition(AvatarIKHint hint, float value)
		{
			Animator.SetHintWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, value);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002908 File Offset: 0x00000B08
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.CheckIfInIKPass();
			this.SetLookAtPositionInternal(lookAtPosition);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000291A File Offset: 0x00000B1A
		public void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
			this.SetLookAtPositionInternal_Injected(ref lookAtPosition);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002924 File Offset: 0x00000B24
		public void SetLookAtWeight(float weight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, 0f, 1f, 0f, 0.5f);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000294A File Offset: 0x00000B4A
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, 1f, 0f, 0.5f);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000296C File Offset: 0x00000B6C
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, 0f, 0.5f);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000298A File Offset: 0x00000B8A
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, 0.5f);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000029A5 File Offset: 0x00000BA5
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000029BD File Offset: 0x00000BBD
		public void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			Animator.SetLookAtWeightInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000029D6 File Offset: 0x00000BD6
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
		{
			this.CheckIfInIKPass();
			this.SetBoneLocalRotationInternal(HumanTrait.GetBoneIndexFromMono((int)humanBoneId), rotation);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000029EE File Offset: 0x00000BEE
		public void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation)
		{
			this.SetBoneLocalRotationInternal_Injected(humanBoneId, ref rotation);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008144 File Offset: 0x00006344
		public ScriptableObject GetBehaviour(Type type)
		{
			IntPtr intPtr = Animator.GetBehaviourDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008178 File Offset: 0x00006378
		public T GetBehaviour<T>() where T : StateMachineBehaviour
		{
			return this.GetBehaviour(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())).TryCast<T>().Cast<T>();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000029F9 File Offset: 0x00000BF9
		public static Il2CppArrayBase<T> ConvertStateMachineBehaviour<T>(Il2CppReferenceArray<ScriptableObject> rawObjects) where T : StateMachineBehaviour
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000081A4 File Offset: 0x000063A4
		public Il2CppArrayBase<T> GetBehaviours<T>() where T : StateMachineBehaviour
		{
			return Animator.ConvertStateMachineBehaviour<T>(this.InternalGetBehaviours(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000081CC File Offset: 0x000063CC
		public Il2CppReferenceArray<ScriptableObject> InternalGetBehaviours(Type type)
		{
			IntPtr intPtr = Animator.InternalGetBehavioursDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008200 File Offset: 0x00006400
		public Il2CppReferenceArray<StateMachineBehaviour> GetBehaviours(int fullPathHash, int layerIndex)
		{
			return this.InternalGetBehavioursByKey(fullPathHash, layerIndex, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<StateMachineBehaviour>())).TryCast<Il2CppReferenceArray<StateMachineBehaviour>>();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000822C File Offset: 0x0000642C
		public Il2CppReferenceArray<ScriptableObject> InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type)
		{
			IntPtr intPtr = Animator.InternalGetBehavioursByKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fullPathHash, layerIndex, IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002A06 File Offset: 0x00000C06
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002A18 File Offset: 0x00000C18
		public bool stabilizeFeet
		{
			get
			{
				return Animator.get_stabilizeFeetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_stabilizeFeetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002A2B File Offset: 0x00000C2B
		public int layerCount
		{
			get
			{
				return Animator.get_layerCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008260 File Offset: 0x00006460
		public string GetLayerName(int layerIndex)
		{
			IntPtr intPtr = Animator.GetLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002A3D File Offset: 0x00000C3D
		public int GetLayerIndex(string layerName)
		{
			return Animator.GetLayerIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002A55 File Offset: 0x00000C55
		public float GetLayerWeight(int layerIndex)
		{
			return Animator.GetLayerWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002A68 File Offset: 0x00000C68
		public void SetLayerWeight(int layerIndex, float weight)
		{
			Animator.SetLayerWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, weight);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008288 File Offset: 0x00006488
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			this.GetAnimatorStateInfo(layerIndex, StateInfoIndex.NextState, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002A7C File Offset: 0x00000C7C
		public void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info)
		{
			Animator.GetAnimatorTransitionInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, out info);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000082A8 File Offset: 0x000064A8
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			this.GetAnimatorTransitionInfo(layerIndex, out animatorTransitionInfo);
			return animatorTransitionInfo;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002A90 File Offset: 0x00000C90
		public int GetAnimatorClipInfoCount(int layerIndex, bool current)
		{
			return Animator.GetAnimatorClipInfoCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, current);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000082C8 File Offset: 0x000064C8
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return this.GetAnimatorClipInfoCount(layerIndex, true);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000082E4 File Offset: 0x000064E4
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return this.GetAnimatorClipInfoCount(layerIndex, false);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008300 File Offset: 0x00006500
		public Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfo(int layerIndex)
		{
			IntPtr intPtr = Animator.GetCurrentAnimatorClipInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008330 File Offset: 0x00006530
		public Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfo(int layerIndex)
		{
			IntPtr intPtr = Animator.GetNextAnimatorClipInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008360 File Offset: 0x00006560
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, true, clips);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, Object clips)
		{
			Animator.GetAnimatorClipInfoInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, isCurrent, IL2CPP.Il2CppObjectBaseToPtr(clips));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000838C File Offset: 0x0000658C
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, false, clips);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000083B8 File Offset: 0x000065B8
		public Il2CppReferenceArray<AnimatorControllerParameter> parameters
		{
			get
			{
				IntPtr intPtr = Animator.get_parametersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimatorControllerParameter>>(intPtr2) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002ABE File Offset: 0x00000CBE
		public int parameterCount
		{
			get
			{
				return Animator.get_parameterCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public AnimatorControllerParameter GetParameter(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002ADD File Offset: 0x00000CDD
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002AEF File Offset: 0x00000CEF
		public float feetPivotActive
		{
			get
			{
				return Animator.get_feetPivotActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_feetPivotActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002B02 File Offset: 0x00000D02
		public float pivotWeight
		{
			get
			{
				return Animator.get_pivotWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000083E4 File Offset: 0x000065E4
		public Vector3 pivotPosition
		{
			get
			{
				Vector3 vector;
				this.get_pivotPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002B14 File Offset: 0x00000D14
		public void InterruptMatchTarget()
		{
			this.InterruptMatchTarget(true);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002B1F File Offset: 0x00000D1F
		public void InterruptMatchTarget(bool completeMatch)
		{
			Animator.InterruptMatchTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), completeMatch);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002B32 File Offset: 0x00000D32
		public bool isMatchingTarget
		{
			get
			{
				return Animator.get_isMatchingTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002B44 File Offset: 0x00000D44
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002B56 File Offset: 0x00000D56
		public float speed
		{
			get
			{
				return Animator.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002B69 File Offset: 0x00000D69
		public void ForceStateNormalizedTime(float normalizedTime)
		{
			this.Play(0, 0, normalizedTime);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000083FC File Offset: 0x000065FC
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration)
		{
			float num = 0f;
			float num2 = 0f;
			int num3 = -1;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, num3, num2, num);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000842C File Offset: 0x0000662C
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer)
		{
			float num = 0f;
			float num2 = 0f;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, num2, num);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008458 File Offset: 0x00006658
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, num);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002B76 File Offset: 0x00000D76
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
		{
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008480 File Offset: 0x00006680
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, num);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000084A4 File Offset: 0x000066A4
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer)
		{
			float num = 0f;
			float num2 = 0f;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, num2, num);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000084CC File Offset: 0x000066CC
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration)
		{
			float num = 0f;
			float num2 = 0f;
			int num3 = -1;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, num3, num2, num);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002B8C File Offset: 0x00000D8C
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
		{
			Animator.CrossFadeInFixedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public void WriteDefaultValues()
		{
			Animator.WriteDefaultValuesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000084F4 File Offset: 0x000066F4
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
		{
			float num = 0f;
			this.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, num);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008518 File Offset: 0x00006718
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateName, normalizedTransitionDuration, layer, negativeInfinity, num);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008540 File Offset: 0x00006740
		public void CrossFade(string stateName, float normalizedTransitionDuration)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			int num2 = -1;
			this.CrossFade(stateName, normalizedTransitionDuration, num2, negativeInfinity, num);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
		{
			this.CrossFade(Animator.StringToHash(stateName), normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002BCD File Offset: 0x00000DCD
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
		{
			Animator.CrossFadeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008568 File Offset: 0x00006768
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
		{
			float num = 0f;
			this.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, num);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000858C File Offset: 0x0000678C
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateHashName, normalizedTransitionDuration, layer, negativeInfinity, num);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000085B4 File Offset: 0x000067B4
		public void CrossFade(int stateHashName, float normalizedTransitionDuration)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			int num2 = -1;
			this.CrossFade(stateHashName, normalizedTransitionDuration, num2, negativeInfinity, num);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000085DC File Offset: 0x000067DC
		public void PlayInFixedTime(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000085FC File Offset: 0x000067FC
		public void PlayInFixedTime(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateName, num, negativeInfinity);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002BE6 File Offset: 0x00000DE6
		public void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			this.PlayInFixedTime(Animator.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
		{
			Animator.PlayInFixedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateNameHash, layer, fixedTime);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000861C File Offset: 0x0000681C
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000863C File Offset: 0x0000683C
		public void PlayInFixedTime(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateNameHash, num, negativeInfinity);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000865C File Offset: 0x0000685C
		public void Play(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000867C File Offset: 0x0000687C
		public void Play(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.Play(stateName, num, negativeInfinity);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002C0D File Offset: 0x00000E0D
		public void Play(string stateName, int layer, float normalizedTime)
		{
			this.Play(Animator.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002C1F File Offset: 0x00000E1F
		public void Play(int stateNameHash, int layer, float normalizedTime)
		{
			Animator.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000869C File Offset: 0x0000689C
		public void Play(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000086BC File Offset: 0x000068BC
		public void Play(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.Play(stateNameHash, num, negativeInfinity);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002C34 File Offset: 0x00000E34
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)
		{
			Animator.SetTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), targetIndex, targetNormalizedTime);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000086DC File Offset: 0x000068DC
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.get_targetPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000086F4 File Offset: 0x000068F4
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_targetRotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000870C File Offset: 0x0000690C
		public bool IsControlled(Transform transform)
		{
			return false;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002C48 File Offset: 0x00000E48
		public bool IsBoneTransform(Transform transform)
		{
			return Animator.IsBoneTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00008720 File Offset: 0x00006920
		public Transform avatarRoot
		{
			get
			{
				IntPtr intPtr = Animator.get_avatarRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000874C File Offset: 0x0000694C
		public Transform GetBoneTransform(HumanBodyBones humanBoneId)
		{
			bool flag = humanBoneId < HumanBodyBones.Hips || humanBoneId >= HumanBodyBones.LastBone;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Concat("humanBoneId must be between 0 and ", HumanBodyBones.LastBone.ToString()));
			}
			return this.GetBoneTransformInternal(HumanTrait.GetBoneIndexFromMono((int)humanBoneId));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000087A0 File Offset: 0x000069A0
		public Transform GetBoneTransformInternal(int humanBoneId)
		{
			IntPtr intPtr = Animator.GetBoneTransformInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanBoneId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002C60 File Offset: 0x00000E60
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002C72 File Offset: 0x00000E72
		public AnimatorCullingMode cullingMode
		{
			get
			{
				return Animator.get_cullingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_cullingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002C85 File Offset: 0x00000E85
		public void StartPlayback()
		{
			Animator.StartPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002C97 File Offset: 0x00000E97
		public void StopPlayback()
		{
			Animator.StopPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002CA9 File Offset: 0x00000EA9
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002CBB File Offset: 0x00000EBB
		public float playbackTime
		{
			get
			{
				return Animator.get_playbackTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_playbackTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002CCE File Offset: 0x00000ECE
		public void StartRecording(int frameCount)
		{
			Animator.StartRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frameCount);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002CE1 File Offset: 0x00000EE1
		public void StopRecording()
		{
			Animator.StopRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000087D0 File Offset: 0x000069D0
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public float recorderStartTime
		{
			get
			{
				return this.GetRecorderStartTime();
			}
			set
			{
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002CF6 File Offset: 0x00000EF6
		public float GetRecorderStartTime()
		{
			return Animator.GetRecorderStartTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000087E8 File Offset: 0x000069E8
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002D08 File Offset: 0x00000F08
		public float recorderStopTime
		{
			get
			{
				return this.GetRecorderStopTime();
			}
			set
			{
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002D0B File Offset: 0x00000F0B
		public float GetRecorderStopTime()
		{
			return Animator.GetRecorderStopTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002D1D File Offset: 0x00000F1D
		public AnimatorRecorderMode recorderMode
		{
			get
			{
				return Animator.get_recorderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002D2F File Offset: 0x00000F2F
		public void ClearInternalControllerPlayable()
		{
			Animator.ClearInternalControllerPlayableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002D41 File Offset: 0x00000F41
		public bool HasState(int layerIndex, int stateID)
		{
			return Animator.HasStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, stateID);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000882C File Offset: 0x00006A2C
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002D55 File Offset: 0x00000F55
		public Avatar avatar
		{
			get
			{
				IntPtr intPtr = Animator.get_avatarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				Animator.set_avatarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008858 File Offset: 0x00006A58
		public string GetStats()
		{
			IntPtr intPtr = Animator.GetStatsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000887C File Offset: 0x00006A7C
		public PlayableGraph playableGraph
		{
			get
			{
				PlayableGraph playableGraph = default(PlayableGraph);
				this.GetCurrentGraph(ref playableGraph);
				return playableGraph;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002D6D File Offset: 0x00000F6D
		public void GetCurrentGraph(ref PlayableGraph graph)
		{
			Animator.GetCurrentGraphDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref graph);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000088A0 File Offset: 0x00006AA0
		public void CheckIfInIKPass()
		{
			bool flag = this.logWarnings && !this.IsInIKPass();
			if (flag)
			{
				Debug.LogWarning("Setting and getting Body Position/Rotation, IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002D80 File Offset: 0x00000F80
		public bool IsInIKPass()
		{
			return Animator.IsInIKPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002D92 File Offset: 0x00000F92
		public void SetFloatString(string name, float value)
		{
			Animator.SetFloatStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002DAB File Offset: 0x00000FAB
		public void SetFloatID(int id, float value)
		{
			Animator.SetFloatIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002DBF File Offset: 0x00000FBF
		public float GetFloatString(string name)
		{
			return Animator.GetFloatStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public float GetFloatID(int id)
		{
			return Animator.GetFloatIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002DEA File Offset: 0x00000FEA
		public bool GetBoolString(string name)
		{
			return Animator.GetBoolStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002E02 File Offset: 0x00001002
		public void SetIntegerID(int id, int value)
		{
			Animator.SetIntegerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002E16 File Offset: 0x00001016
		public int GetIntegerString(string name)
		{
			return Animator.GetIntegerStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002E2E File Offset: 0x0000102E
		public int GetIntegerID(int id)
		{
			return Animator.GetIntegerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002E41 File Offset: 0x00001041
		public void SetTriggerID(int id)
		{
			Animator.SetTriggerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002E54 File Offset: 0x00001054
		public void ResetTriggerID(int id)
		{
			Animator.ResetTriggerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002E67 File Offset: 0x00001067
		public bool IsParameterControlledByCurveString(string name)
		{
			return Animator.IsParameterControlledByCurveStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002E7F File Offset: 0x0000107F
		public bool IsParameterControlledByCurveID(int id)
		{
			return Animator.IsParameterControlledByCurveIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002E92 File Offset: 0x00001092
		public void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime)
		{
			Animator.SetFloatStringDampDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value, dampTime, deltaTime);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002EAE File Offset: 0x000010AE
		public void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime)
		{
			Animator.SetFloatIDDampDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value, dampTime, deltaTime);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002EC5 File Offset: 0x000010C5
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002ED7 File Offset: 0x000010D7
		public bool layersAffectMassCenter
		{
			get
			{
				return Animator.get_layersAffectMassCenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_layersAffectMassCenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002EEA File Offset: 0x000010EA
		public float leftFeetBottomHeight
		{
			get
			{
				return Animator.get_leftFeetBottomHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002EFC File Offset: 0x000010FC
		public float rightFeetBottomHeight
		{
			get
			{
				return Animator.get_rightFeetBottomHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002F0E File Offset: 0x0000110E
		public bool supportsOnAnimatorMove
		{
			get
			{
				return Animator.get_supportsOnAnimatorMoveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002F20 File Offset: 0x00001120
		public void OnUpdateModeChanged()
		{
			Animator.OnUpdateModeChangedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002F32 File Offset: 0x00001132
		public void OnCullingModeChanged()
		{
			Animator.OnCullingModeChangedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002F44 File Offset: 0x00001144
		public void WriteDefaultPose()
		{
			Animator.WriteDefaultPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002F56 File Offset: 0x00001156
		public void Update(float deltaTime)
		{
			Animator.UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), deltaTime);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002F69 File Offset: 0x00001169
		public void Rebind()
		{
			this.Rebind(true);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002F74 File Offset: 0x00001174
		public void Rebind(bool writeDefaultValues)
		{
			Animator.RebindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), writeDefaultValues);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002F87 File Offset: 0x00001187
		public void ApplyBuiltinRootMotion()
		{
			Animator.ApplyBuiltinRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002F99 File Offset: 0x00001199
		public void EvaluateController()
		{
			this.EvaluateController(0f);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002FA8 File Offset: 0x000011A8
		public void EvaluateController(float deltaTime)
		{
			Animator.EvaluateControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), deltaTime);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000088D4 File Offset: 0x00006AD4
		public string GetCurrentStateName(int layerIndex)
		{
			return this.GetAnimatorStateName(layerIndex, true);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000088F0 File Offset: 0x00006AF0
		public string GetNextStateName(int layerIndex)
		{
			return this.GetAnimatorStateName(layerIndex, false);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000890C File Offset: 0x00006B0C
		public string GetAnimatorStateName(int layerIndex, bool current)
		{
			IntPtr intPtr = Animator.GetAnimatorStateNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, current);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008934 File Offset: 0x00006B34
		public string ResolveHash(int hash)
		{
			IntPtr intPtr = Animator.ResolveHashDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hash);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002FBB File Offset: 0x000011BB
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002FCD File Offset: 0x000011CD
		public bool logWarnings
		{
			get
			{
				return Animator.get_logWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_logWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002FE0 File Offset: 0x000011E0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002FF2 File Offset: 0x000011F2
		public bool fireEvents
		{
			get
			{
				return Animator.get_fireEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_fireEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00003005 File Offset: 0x00001205
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00003017 File Offset: 0x00001217
		public bool keepAnimatorControllerStateOnDisable
		{
			get
			{
				return Animator.get_keepAnimatorControllerStateOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_keepAnimatorControllerStateOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000895C File Offset: 0x00006B5C
		public Vector3 GetVector(string name)
		{
			return Vector3.zero;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008974 File Offset: 0x00006B74
		public Vector3 GetVector(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000302A File Offset: 0x0000122A
		public void SetVector(string name, Vector3 value)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000302D File Offset: 0x0000122D
		public void SetVector(int id, Vector3 value)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000898C File Offset: 0x00006B8C
		public Quaternion GetQuaternion(string name)
		{
			return Quaternion.identity;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000089A4 File Offset: 0x00006BA4
		public Quaternion GetQuaternion(int id)
		{
			return Quaternion.identity;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003030 File Offset: 0x00001230
		public void SetQuaternion(string name, Quaternion value)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003033 File Offset: 0x00001233
		public void SetQuaternion(int id, Quaternion value)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003036 File Offset: 0x00001236
		public void get_deltaPosition_Injected(out Vector3 ret)
		{
			Animator.get_deltaPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003049 File Offset: 0x00001249
		public void get_deltaRotation_Injected(out Quaternion ret)
		{
			Animator.get_deltaRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000305C File Offset: 0x0000125C
		public void get_velocity_Injected(out Vector3 ret)
		{
			Animator.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000306F File Offset: 0x0000126F
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			Animator.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003082 File Offset: 0x00001282
		public void get_rootPosition_Injected(out Vector3 ret)
		{
			Animator.get_rootPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003095 File Offset: 0x00001295
		public void set_rootPosition_Injected(ref Vector3 value)
		{
			Animator.set_rootPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000030A8 File Offset: 0x000012A8
		public void get_rootRotation_Injected(out Quaternion ret)
		{
			Animator.get_rootRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000030BB File Offset: 0x000012BB
		public void set_rootRotation_Injected(ref Quaternion value)
		{
			Animator.set_rootRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000030CE File Offset: 0x000012CE
		public void get_bodyPositionInternal_Injected(out Vector3 ret)
		{
			Animator.get_bodyPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000030E1 File Offset: 0x000012E1
		public void set_bodyPositionInternal_Injected(ref Vector3 value)
		{
			Animator.set_bodyPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000030F4 File Offset: 0x000012F4
		public void get_bodyRotationInternal_Injected(out Quaternion ret)
		{
			Animator.get_bodyRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003107 File Offset: 0x00001307
		public void set_bodyRotationInternal_Injected(ref Quaternion value)
		{
			Animator.set_bodyRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000311A File Offset: 0x0000131A
		public void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret)
		{
			Animator.GetGoalPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, out ret);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000312E File Offset: 0x0000132E
		public void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition)
		{
			Animator.SetGoalPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, ref goalPosition);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003142 File Offset: 0x00001342
		public void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret)
		{
			Animator.GetGoalRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, out ret);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003156 File Offset: 0x00001356
		public void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation)
		{
			Animator.SetGoalRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, ref goalRotation);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000316A File Offset: 0x0000136A
		public void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret)
		{
			Animator.GetHintPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, out ret);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000317E File Offset: 0x0000137E
		public void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition)
		{
			Animator.SetHintPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, ref hintPosition);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003192 File Offset: 0x00001392
		public void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition)
		{
			Animator.SetLookAtPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref lookAtPosition);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000031A5 File Offset: 0x000013A5
		public void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation)
		{
			Animator.SetBoneLocalRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanBoneId, ref rotation);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000031B9 File Offset: 0x000013B9
		public void get_pivotPosition_Injected(out Vector3 ret)
		{
			Animator.get_pivotPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000031CC File Offset: 0x000013CC
		public void get_targetPosition_Injected(out Vector3 ret)
		{
			Animator.get_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000031DF File Offset: 0x000013DF
		public void get_targetRotation_Injected(out Quaternion ret)
		{
			Animator.get_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_String_Int32_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_IsInTransition_Public_Boolean_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_SetBoolString_Private_Void_String_Boolean_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolID_Private_Boolean_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_SetIntegerString_Private_Void_String_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly Animator.get_isOptimizableDelegate get_isOptimizableDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Animator.get_isHumanDelegate get_isHumanDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Animator.get_hasRootMotionDelegate get_hasRootMotionDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Animator.get_isRootPositionOrRotationControlledByCurvesDelegate get_isRootPositionOrRotationControlledByCurvesDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Animator.get_humanScaleDelegate get_humanScaleDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Animator.get_applyRootMotionDelegate get_applyRootMotionDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Animator.set_applyRootMotionDelegate set_applyRootMotionDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Animator.get_linearVelocityBlendingDelegate get_linearVelocityBlendingDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Animator.set_linearVelocityBlendingDelegate set_linearVelocityBlendingDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Animator.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly Animator.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly Animator.get_hasTransformHierarchyDelegate get_hasTransformHierarchyDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly Animator.get_allowConstantClipSamplingOptimizationDelegate get_allowConstantClipSamplingOptimizationDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly Animator.set_allowConstantClipSamplingOptimizationDelegate set_allowConstantClipSamplingOptimizationDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly Animator.get_gravityWeightDelegate get_gravityWeightDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly Animator.GetGoalWeightPositionDelegate GetGoalWeightPositionDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly Animator.SetGoalWeightPositionDelegate SetGoalWeightPositionDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly Animator.GetGoalWeightRotationDelegate GetGoalWeightRotationDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly Animator.SetGoalWeightRotationDelegate SetGoalWeightRotationDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly Animator.GetHintWeightPositionDelegate GetHintWeightPositionDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly Animator.SetHintWeightPositionDelegate SetHintWeightPositionDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly Animator.SetLookAtWeightInternalDelegate SetLookAtWeightInternalDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly Animator.GetBehaviourDelegate GetBehaviourDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly Animator.InternalGetBehavioursDelegate InternalGetBehavioursDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly Animator.InternalGetBehavioursByKeyDelegate InternalGetBehavioursByKeyDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly Animator.get_stabilizeFeetDelegate get_stabilizeFeetDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly Animator.set_stabilizeFeetDelegate set_stabilizeFeetDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly Animator.get_layerCountDelegate get_layerCountDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly Animator.GetLayerNameDelegate GetLayerNameDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly Animator.GetLayerIndexDelegate GetLayerIndexDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly Animator.GetLayerWeightDelegate GetLayerWeightDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly Animator.SetLayerWeightDelegate SetLayerWeightDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly Animator.GetAnimatorTransitionInfoDelegate GetAnimatorTransitionInfoDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly Animator.GetAnimatorClipInfoCountDelegate GetAnimatorClipInfoCountDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly Animator.GetCurrentAnimatorClipInfoDelegate GetCurrentAnimatorClipInfoDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly Animator.GetNextAnimatorClipInfoDelegate GetNextAnimatorClipInfoDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly Animator.GetAnimatorClipInfoInternalDelegate GetAnimatorClipInfoInternalDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly Animator.get_parametersDelegate get_parametersDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly Animator.get_parameterCountDelegate get_parameterCountDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly Animator.get_feetPivotActiveDelegate get_feetPivotActiveDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly Animator.set_feetPivotActiveDelegate set_feetPivotActiveDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly Animator.get_pivotWeightDelegate get_pivotWeightDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly Animator.InterruptMatchTargetDelegate InterruptMatchTargetDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly Animator.get_isMatchingTargetDelegate get_isMatchingTargetDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly Animator.get_speedDelegate get_speedDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly Animator.set_speedDelegate set_speedDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly Animator.CrossFadeInFixedTimeDelegate CrossFadeInFixedTimeDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly Animator.WriteDefaultValuesDelegate WriteDefaultValuesDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly Animator.CrossFadeDelegate CrossFadeDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly Animator.PlayInFixedTimeDelegate PlayInFixedTimeDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly Animator.PlayDelegate PlayDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly Animator.SetTargetDelegate SetTargetDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly Animator.IsBoneTransformDelegate IsBoneTransformDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly Animator.get_avatarRootDelegate get_avatarRootDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly Animator.GetBoneTransformInternalDelegate GetBoneTransformInternalDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly Animator.get_cullingModeDelegate get_cullingModeDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly Animator.set_cullingModeDelegate set_cullingModeDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly Animator.StartPlaybackDelegate StartPlaybackDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly Animator.StopPlaybackDelegate StopPlaybackDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly Animator.get_playbackTimeDelegate get_playbackTimeDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly Animator.set_playbackTimeDelegate set_playbackTimeDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly Animator.StartRecordingDelegate StartRecordingDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly Animator.StopRecordingDelegate StopRecordingDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly Animator.GetRecorderStartTimeDelegate GetRecorderStartTimeDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly Animator.GetRecorderStopTimeDelegate GetRecorderStopTimeDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly Animator.get_recorderModeDelegate get_recorderModeDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly Animator.get_runtimeAnimatorControllerDelegate get_runtimeAnimatorControllerDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly Animator.ClearInternalControllerPlayableDelegate ClearInternalControllerPlayableDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly Animator.HasStateDelegate HasStateDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly Animator.get_avatarDelegate get_avatarDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly Animator.set_avatarDelegate set_avatarDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly Animator.GetStatsDelegate GetStatsDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly Animator.GetCurrentGraphDelegate GetCurrentGraphDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly Animator.IsInIKPassDelegate IsInIKPassDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly Animator.SetFloatStringDelegate SetFloatStringDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly Animator.SetFloatIDDelegate SetFloatIDDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly Animator.GetFloatStringDelegate GetFloatStringDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly Animator.GetFloatIDDelegate GetFloatIDDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly Animator.GetBoolStringDelegate GetBoolStringDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly Animator.SetIntegerIDDelegate SetIntegerIDDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly Animator.GetIntegerStringDelegate GetIntegerStringDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly Animator.GetIntegerIDDelegate GetIntegerIDDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly Animator.SetTriggerIDDelegate SetTriggerIDDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly Animator.ResetTriggerIDDelegate ResetTriggerIDDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly Animator.IsParameterControlledByCurveStringDelegate IsParameterControlledByCurveStringDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly Animator.IsParameterControlledByCurveIDDelegate IsParameterControlledByCurveIDDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly Animator.SetFloatStringDampDelegate SetFloatStringDampDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly Animator.SetFloatIDDampDelegate SetFloatIDDampDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly Animator.get_layersAffectMassCenterDelegate get_layersAffectMassCenterDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly Animator.set_layersAffectMassCenterDelegate set_layersAffectMassCenterDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly Animator.get_leftFeetBottomHeightDelegate get_leftFeetBottomHeightDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly Animator.get_rightFeetBottomHeightDelegate get_rightFeetBottomHeightDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly Animator.get_supportsOnAnimatorMoveDelegate get_supportsOnAnimatorMoveDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly Animator.OnUpdateModeChangedDelegate OnUpdateModeChangedDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly Animator.OnCullingModeChangedDelegate OnCullingModeChangedDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly Animator.WriteDefaultPoseDelegate WriteDefaultPoseDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly Animator.UpdateDelegate UpdateDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly Animator.RebindDelegate RebindDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly Animator.ApplyBuiltinRootMotionDelegate ApplyBuiltinRootMotionDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly Animator.EvaluateControllerDelegate EvaluateControllerDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly Animator.GetAnimatorStateNameDelegate GetAnimatorStateNameDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly Animator.ResolveHashDelegate ResolveHashDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly Animator.get_logWarningsDelegate get_logWarningsDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly Animator.set_logWarningsDelegate set_logWarningsDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly Animator.get_fireEventsDelegate get_fireEventsDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly Animator.set_fireEventsDelegate set_fireEventsDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly Animator.get_keepAnimatorControllerStateOnDisableDelegate get_keepAnimatorControllerStateOnDisableDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly Animator.set_keepAnimatorControllerStateOnDisableDelegate set_keepAnimatorControllerStateOnDisableDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly Animator.get_deltaPosition_InjectedDelegate get_deltaPosition_InjectedDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly Animator.get_deltaRotation_InjectedDelegate get_deltaRotation_InjectedDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly Animator.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly Animator.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly Animator.get_rootPosition_InjectedDelegate get_rootPosition_InjectedDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly Animator.set_rootPosition_InjectedDelegate set_rootPosition_InjectedDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly Animator.get_rootRotation_InjectedDelegate get_rootRotation_InjectedDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly Animator.set_rootRotation_InjectedDelegate set_rootRotation_InjectedDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly Animator.get_bodyPositionInternal_InjectedDelegate get_bodyPositionInternal_InjectedDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly Animator.set_bodyPositionInternal_InjectedDelegate set_bodyPositionInternal_InjectedDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly Animator.get_bodyRotationInternal_InjectedDelegate get_bodyRotationInternal_InjectedDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly Animator.set_bodyRotationInternal_InjectedDelegate set_bodyRotationInternal_InjectedDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly Animator.GetGoalPosition_InjectedDelegate GetGoalPosition_InjectedDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly Animator.SetGoalPosition_InjectedDelegate SetGoalPosition_InjectedDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly Animator.GetGoalRotation_InjectedDelegate GetGoalRotation_InjectedDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly Animator.SetGoalRotation_InjectedDelegate SetGoalRotation_InjectedDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly Animator.GetHintPosition_InjectedDelegate GetHintPosition_InjectedDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly Animator.SetHintPosition_InjectedDelegate SetHintPosition_InjectedDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly Animator.SetLookAtPositionInternal_InjectedDelegate SetLookAtPositionInternal_InjectedDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly Animator.SetBoneLocalRotationInternal_InjectedDelegate SetBoneLocalRotationInternal_InjectedDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly Animator.get_pivotPosition_InjectedDelegate get_pivotPosition_InjectedDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly Animator.get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly Animator.get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField;

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060005C3 RID: 1475
		private delegate bool get_isOptimizableDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060005C5 RID: 1477
		private delegate bool get_isHumanDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060005C7 RID: 1479
		private delegate bool get_hasRootMotionDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060005C9 RID: 1481
		private delegate bool get_isRootPositionOrRotationControlledByCurvesDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060005CB RID: 1483
		private delegate float get_humanScaleDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060005CD RID: 1485
		private delegate bool get_applyRootMotionDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060005CF RID: 1487
		private delegate void set_applyRootMotionDelegate(IntPtr @this, bool value);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060005D1 RID: 1489
		private delegate bool get_linearVelocityBlendingDelegate(IntPtr @this);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060005D3 RID: 1491
		private delegate void set_linearVelocityBlendingDelegate(IntPtr @this, bool value);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060005D5 RID: 1493
		private delegate AnimatorUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060005D7 RID: 1495
		private delegate void set_updateModeDelegate(IntPtr @this, AnimatorUpdateMode value);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060005D9 RID: 1497
		private delegate bool get_hasTransformHierarchyDelegate(IntPtr @this);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060005DB RID: 1499
		private delegate bool get_allowConstantClipSamplingOptimizationDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060005DD RID: 1501
		private delegate void set_allowConstantClipSamplingOptimizationDelegate(IntPtr @this, bool value);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060005DF RID: 1503
		private delegate float get_gravityWeightDelegate(IntPtr @this);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060005E1 RID: 1505
		private delegate float GetGoalWeightPositionDelegate(IntPtr @this, AvatarIKGoal goal);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060005E3 RID: 1507
		private delegate void SetGoalWeightPositionDelegate(IntPtr @this, AvatarIKGoal goal, float value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060005E5 RID: 1509
		private delegate float GetGoalWeightRotationDelegate(IntPtr @this, AvatarIKGoal goal);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060005E7 RID: 1511
		private delegate void SetGoalWeightRotationDelegate(IntPtr @this, AvatarIKGoal goal, float value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060005E9 RID: 1513
		private delegate float GetHintWeightPositionDelegate(IntPtr @this, AvatarIKHint hint);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x060005EB RID: 1515
		private delegate void SetHintWeightPositionDelegate(IntPtr @this, AvatarIKHint hint, float value);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x060005ED RID: 1517
		private delegate void SetLookAtWeightInternalDelegate(IntPtr @this, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x060005EF RID: 1519
		private delegate IntPtr GetBehaviourDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x060005F1 RID: 1521
		private delegate IntPtr InternalGetBehavioursDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x060005F3 RID: 1523
		private delegate IntPtr InternalGetBehavioursByKeyDelegate(IntPtr @this, int fullPathHash, int layerIndex, IntPtr type);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x060005F5 RID: 1525
		private delegate bool get_stabilizeFeetDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x060005F7 RID: 1527
		private delegate void set_stabilizeFeetDelegate(IntPtr @this, bool value);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x060005F9 RID: 1529
		private delegate int get_layerCountDelegate(IntPtr @this);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x060005FB RID: 1531
		private delegate IntPtr GetLayerNameDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x060005FD RID: 1533
		private delegate int GetLayerIndexDelegate(IntPtr @this, IntPtr layerName);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x060005FF RID: 1535
		private delegate float GetLayerWeightDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000601 RID: 1537
		private delegate void SetLayerWeightDelegate(IntPtr @this, int layerIndex, float weight);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000603 RID: 1539
		private delegate void GetAnimatorTransitionInfoDelegate(IntPtr @this, int layerIndex, [Out] IntPtr info);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000605 RID: 1541
		private delegate int GetAnimatorClipInfoCountDelegate(IntPtr @this, int layerIndex, bool current);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000607 RID: 1543
		private delegate IntPtr GetCurrentAnimatorClipInfoDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000609 RID: 1545
		private delegate IntPtr GetNextAnimatorClipInfoDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600060B RID: 1547
		private delegate void GetAnimatorClipInfoInternalDelegate(IntPtr @this, int layerIndex, bool isCurrent, IntPtr clips);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x0600060D RID: 1549
		private delegate IntPtr get_parametersDelegate(IntPtr @this);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600060F RID: 1551
		private delegate int get_parameterCountDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000611 RID: 1553
		private delegate float get_feetPivotActiveDelegate(IntPtr @this);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000613 RID: 1555
		private delegate void set_feetPivotActiveDelegate(IntPtr @this, float value);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000615 RID: 1557
		private delegate float get_pivotWeightDelegate(IntPtr @this);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000617 RID: 1559
		private delegate void InterruptMatchTargetDelegate(IntPtr @this, bool completeMatch);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000619 RID: 1561
		private delegate bool get_isMatchingTargetDelegate(IntPtr @this);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x0600061B RID: 1563
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x0600061D RID: 1565
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x0600061F RID: 1567
		private delegate void CrossFadeInFixedTimeDelegate(IntPtr @this, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000621 RID: 1569
		private delegate void WriteDefaultValuesDelegate(IntPtr @this);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x06000623 RID: 1571
		private delegate void CrossFadeDelegate(IntPtr @this, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x06000625 RID: 1573
		private delegate void PlayInFixedTimeDelegate(IntPtr @this, int stateNameHash, int layer, float fixedTime);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000627 RID: 1575
		private delegate void PlayDelegate(IntPtr @this, int stateNameHash, int layer, float normalizedTime);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000629 RID: 1577
		private delegate void SetTargetDelegate(IntPtr @this, AvatarTarget targetIndex, float targetNormalizedTime);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x0600062B RID: 1579
		private delegate bool IsBoneTransformDelegate(IntPtr @this, IntPtr transform);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x0600062D RID: 1581
		private delegate IntPtr get_avatarRootDelegate(IntPtr @this);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600062F RID: 1583
		private delegate IntPtr GetBoneTransformInternalDelegate(IntPtr @this, int humanBoneId);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06000631 RID: 1585
		private delegate AnimatorCullingMode get_cullingModeDelegate(IntPtr @this);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000633 RID: 1587
		private delegate void set_cullingModeDelegate(IntPtr @this, AnimatorCullingMode value);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x06000635 RID: 1589
		private delegate void StartPlaybackDelegate(IntPtr @this);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000637 RID: 1591
		private delegate void StopPlaybackDelegate(IntPtr @this);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000639 RID: 1593
		private delegate float get_playbackTimeDelegate(IntPtr @this);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x0600063B RID: 1595
		private delegate void set_playbackTimeDelegate(IntPtr @this, float value);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x0600063D RID: 1597
		private delegate void StartRecordingDelegate(IntPtr @this, int frameCount);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x0600063F RID: 1599
		private delegate void StopRecordingDelegate(IntPtr @this);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x06000641 RID: 1601
		private delegate float GetRecorderStartTimeDelegate(IntPtr @this);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x06000643 RID: 1603
		private delegate float GetRecorderStopTimeDelegate(IntPtr @this);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x06000645 RID: 1605
		private delegate AnimatorRecorderMode get_recorderModeDelegate(IntPtr @this);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000647 RID: 1607
		private delegate IntPtr get_runtimeAnimatorControllerDelegate(IntPtr @this);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000649 RID: 1609
		private delegate void ClearInternalControllerPlayableDelegate(IntPtr @this);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x0600064B RID: 1611
		private delegate bool HasStateDelegate(IntPtr @this, int layerIndex, int stateID);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x0600064D RID: 1613
		private delegate IntPtr get_avatarDelegate(IntPtr @this);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x0600064F RID: 1615
		private delegate void set_avatarDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x06000651 RID: 1617
		private delegate IntPtr GetStatsDelegate(IntPtr @this);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000653 RID: 1619
		private delegate void GetCurrentGraphDelegate(IntPtr @this, IntPtr graph);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000655 RID: 1621
		private delegate bool IsInIKPassDelegate(IntPtr @this);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000657 RID: 1623
		private delegate void SetFloatStringDelegate(IntPtr @this, IntPtr name, float value);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000659 RID: 1625
		private delegate void SetFloatIDDelegate(IntPtr @this, int id, float value);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x0600065B RID: 1627
		private delegate float GetFloatStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x0600065D RID: 1629
		private delegate float GetFloatIDDelegate(IntPtr @this, int id);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x0600065F RID: 1631
		private delegate bool GetBoolStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x06000661 RID: 1633
		private delegate void SetIntegerIDDelegate(IntPtr @this, int id, int value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x06000663 RID: 1635
		private delegate int GetIntegerStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x06000665 RID: 1637
		private delegate int GetIntegerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x06000667 RID: 1639
		private delegate void SetTriggerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x06000669 RID: 1641
		private delegate void ResetTriggerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x0600066B RID: 1643
		private delegate bool IsParameterControlledByCurveStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x0600066D RID: 1645
		private delegate bool IsParameterControlledByCurveIDDelegate(IntPtr @this, int id);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x0600066F RID: 1647
		private delegate void SetFloatStringDampDelegate(IntPtr @this, IntPtr name, float value, float dampTime, float deltaTime);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x06000671 RID: 1649
		private delegate void SetFloatIDDampDelegate(IntPtr @this, int id, float value, float dampTime, float deltaTime);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x06000673 RID: 1651
		private delegate bool get_layersAffectMassCenterDelegate(IntPtr @this);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x06000675 RID: 1653
		private delegate void set_layersAffectMassCenterDelegate(IntPtr @this, bool value);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x06000677 RID: 1655
		private delegate float get_leftFeetBottomHeightDelegate(IntPtr @this);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x06000679 RID: 1657
		private delegate float get_rightFeetBottomHeightDelegate(IntPtr @this);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x0600067B RID: 1659
		private delegate bool get_supportsOnAnimatorMoveDelegate(IntPtr @this);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x0600067D RID: 1661
		private delegate void OnUpdateModeChangedDelegate(IntPtr @this);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x0600067F RID: 1663
		private delegate void OnCullingModeChangedDelegate(IntPtr @this);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x06000681 RID: 1665
		private delegate void WriteDefaultPoseDelegate(IntPtr @this);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x06000683 RID: 1667
		private delegate void UpdateDelegate(IntPtr @this, float deltaTime);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000685 RID: 1669
		private delegate void RebindDelegate(IntPtr @this, bool writeDefaultValues);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x06000687 RID: 1671
		private delegate void ApplyBuiltinRootMotionDelegate(IntPtr @this);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x06000689 RID: 1673
		private delegate void EvaluateControllerDelegate(IntPtr @this, float deltaTime);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x0600068B RID: 1675
		private delegate IntPtr GetAnimatorStateNameDelegate(IntPtr @this, int layerIndex, bool current);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x0600068D RID: 1677
		private delegate IntPtr ResolveHashDelegate(IntPtr @this, int hash);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x0600068F RID: 1679
		private delegate bool get_logWarningsDelegate(IntPtr @this);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000691 RID: 1681
		private delegate void set_logWarningsDelegate(IntPtr @this, bool value);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000693 RID: 1683
		private delegate bool get_fireEventsDelegate(IntPtr @this);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000695 RID: 1685
		private delegate void set_fireEventsDelegate(IntPtr @this, bool value);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000697 RID: 1687
		private delegate bool get_keepAnimatorControllerStateOnDisableDelegate(IntPtr @this);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000699 RID: 1689
		private delegate void set_keepAnimatorControllerStateOnDisableDelegate(IntPtr @this, bool value);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x0600069B RID: 1691
		private delegate void get_deltaPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x0600069D RID: 1693
		private delegate void get_deltaRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x0600069F RID: 1695
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060006A1 RID: 1697
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060006A3 RID: 1699
		private delegate void get_rootPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060006A5 RID: 1701
		private delegate void set_rootPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060006A7 RID: 1703
		private delegate void get_rootRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060006A9 RID: 1705
		private delegate void set_rootRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060006AB RID: 1707
		private delegate void get_bodyPositionInternal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060006AD RID: 1709
		private delegate void set_bodyPositionInternal_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060006AF RID: 1711
		private delegate void get_bodyRotationInternal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060006B1 RID: 1713
		private delegate void set_bodyRotationInternal_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060006B3 RID: 1715
		private delegate void GetGoalPosition_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, [Out] IntPtr ret);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060006B5 RID: 1717
		private delegate void SetGoalPosition_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, IntPtr goalPosition);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060006B7 RID: 1719
		private delegate void GetGoalRotation_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, [Out] IntPtr ret);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060006B9 RID: 1721
		private delegate void SetGoalRotation_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, IntPtr goalRotation);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060006BB RID: 1723
		private delegate void GetHintPosition_InjectedDelegate(IntPtr @this, AvatarIKHint hint, [Out] IntPtr ret);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060006BD RID: 1725
		private delegate void SetHintPosition_InjectedDelegate(IntPtr @this, AvatarIKHint hint, IntPtr hintPosition);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060006BF RID: 1727
		private delegate void SetLookAtPositionInternal_InjectedDelegate(IntPtr @this, IntPtr lookAtPosition);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060006C1 RID: 1729
		private delegate void SetBoneLocalRotationInternal_InjectedDelegate(IntPtr @this, int humanBoneId, IntPtr rotation);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060006C3 RID: 1731
		private delegate void get_pivotPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x060006C5 RID: 1733
		private delegate void get_targetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x060006C7 RID: 1735
		private delegate void get_targetRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
