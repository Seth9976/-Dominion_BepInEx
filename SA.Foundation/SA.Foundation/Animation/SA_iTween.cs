using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Foundation.Animation
{
	// Token: 0x0200003A RID: 58
	public class SA_iTween : MonoBehaviour
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000AC20 File Offset: 0x00008E20
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iTween()
		{
			Il2CppClassPointerStore<SA_iTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Animation", "SA_iTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr);
			SA_iTween.NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "tweens");
			SA_iTween.NativeFieldInfoPtr_cameraFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "cameraFade");
			SA_iTween.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "id");
			SA_iTween.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "type");
			SA_iTween.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "method");
			SA_iTween.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "easeType");
			SA_iTween.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "time");
			SA_iTween.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "delay");
			SA_iTween.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "loopType");
			SA_iTween.NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "isRunning");
			SA_iTween.NativeFieldInfoPtr_isPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "isPaused");
			SA_iTween.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "_name");
			SA_iTween.NativeFieldInfoPtr_runningTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "runningTime");
			SA_iTween.NativeFieldInfoPtr_percentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "percentage");
			SA_iTween.NativeFieldInfoPtr_delayStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "delayStarted");
			SA_iTween.NativeFieldInfoPtr_kinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "kinematic");
			SA_iTween.NativeFieldInfoPtr_isLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "isLocal");
			SA_iTween.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "loop");
			SA_iTween.NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "reverse");
			SA_iTween.NativeFieldInfoPtr_wasPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "wasPaused");
			SA_iTween.NativeFieldInfoPtr_physics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "physics");
			SA_iTween.NativeFieldInfoPtr_tweenArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "tweenArguments");
			SA_iTween.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "space");
			SA_iTween.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "ease");
			SA_iTween.NativeFieldInfoPtr_apply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "apply");
			SA_iTween.NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "audioSource");
			SA_iTween.NativeFieldInfoPtr_vector3s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "vector3s");
			SA_iTween.NativeFieldInfoPtr_vector2s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "vector2s");
			SA_iTween.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "colors");
			SA_iTween.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "floats");
			SA_iTween.NativeFieldInfoPtr_rects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "rects");
			SA_iTween.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "path");
			SA_iTween.NativeFieldInfoPtr_preUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "preUpdate");
			SA_iTween.NativeFieldInfoPtr_postUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "postUpdate");
			SA_iTween.NativeFieldInfoPtr_namedcolorvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "namedcolorvalue");
			SA_iTween.NativeFieldInfoPtr_lastRealTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "lastRealTime");
			SA_iTween.NativeFieldInfoPtr_useRealTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "useRealTime");
			SA_iTween.NativeFieldInfoPtr_thisTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "thisTransform");
			SA_iTween.NativeMethodInfoPtr_Init_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663572);
			SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663573);
			SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663574);
			SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663575);
			SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663576);
			SA_iTween.NativeMethodInfoPtr_ValueTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663577);
			SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663578);
			SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663579);
			SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663580);
			SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663581);
			SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663582);
			SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663583);
			SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663584);
			SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663585);
			SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663586);
			SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663587);
			SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663588);
			SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663589);
			SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663590);
			SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663591);
			SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663592);
			SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663593);
			SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663594);
			SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663595);
			SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663596);
			SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663597);
			SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663598);
			SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663599);
			SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663600);
			SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663601);
			SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663602);
			SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663603);
			SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663604);
			SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663605);
			SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663606);
			SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663607);
			SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663608);
			SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663609);
			SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663610);
			SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663611);
			SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663612);
			SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663613);
			SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663614);
			SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663615);
			SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663616);
			SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663617);
			SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663618);
			SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663619);
			SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663620);
			SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663621);
			SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663622);
			SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663623);
			SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663624);
			SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663625);
			SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663626);
			SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663627);
			SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663628);
			SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663629);
			SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663630);
			SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663631);
			SA_iTween.NativeMethodInfoPtr_GenerateTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663632);
			SA_iTween.NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663633);
			SA_iTween.NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663634);
			SA_iTween.NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663635);
			SA_iTween.NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663636);
			SA_iTween.NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663637);
			SA_iTween.NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663638);
			SA_iTween.NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663639);
			SA_iTween.NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663640);
			SA_iTween.NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663641);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663642);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663643);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663644);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663645);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663646);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663647);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663648);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663649);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663650);
			SA_iTween.NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663651);
			SA_iTween.NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663652);
			SA_iTween.NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663653);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663654);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663655);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663656);
			SA_iTween.NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663657);
			SA_iTween.NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663658);
			SA_iTween.NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663659);
			SA_iTween.NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663660);
			SA_iTween.NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663661);
			SA_iTween.NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663662);
			SA_iTween.NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663663);
			SA_iTween.NativeMethodInfoPtr_ApplyStabTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663664);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663665);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663666);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663667);
			SA_iTween.NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663668);
			SA_iTween.NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663669);
			SA_iTween.NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663670);
			SA_iTween.NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663671);
			SA_iTween.NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663672);
			SA_iTween.NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663673);
			SA_iTween.NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663674);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663675);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663676);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663677);
			SA_iTween.NativeMethodInfoPtr_TweenDelay_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663678);
			SA_iTween.NativeMethodInfoPtr_TweenStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663679);
			SA_iTween.NativeMethodInfoPtr_TweenRestart_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663680);
			SA_iTween.NativeMethodInfoPtr_TweenUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663681);
			SA_iTween.NativeMethodInfoPtr_TweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663682);
			SA_iTween.NativeMethodInfoPtr_TweenLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663683);
			SA_iTween.NativeMethodInfoPtr_RectUpdate_Public_Static_Rect_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663684);
			SA_iTween.NativeMethodInfoPtr_Vector3Update_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663685);
			SA_iTween.NativeMethodInfoPtr_Vector2Update_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663686);
			SA_iTween.NativeMethodInfoPtr_FloatUpdate_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663687);
			SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663688);
			SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663689);
			SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663690);
			SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663691);
			SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663692);
			SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663693);
			SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663694);
			SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663695);
			SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663696);
			SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663697);
			SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663698);
			SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663699);
			SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663700);
			SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663701);
			SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663702);
			SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663703);
			SA_iTween.NativeMethodInfoPtr_CameraTexture_Public_Static_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663704);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663705);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663706);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663707);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663708);
			SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663709);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663710);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663711);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663712);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663713);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663714);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663715);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663716);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663717);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663718);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663719);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663720);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663721);
			SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663722);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663723);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663724);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663725);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663726);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663727);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663728);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663729);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663730);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663731);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663732);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663733);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663734);
			SA_iTween.NativeMethodInfoPtr_CameraFadeDepth_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663735);
			SA_iTween.NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663736);
			SA_iTween.NativeMethodInfoPtr_CameraFadeSwap_Public_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663737);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663738);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663739);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663740);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663741);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663742);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663743);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663744);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663745);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663746);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663747);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663748);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663749);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663750);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663751);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663752);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663753);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663754);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663755);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663756);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663757);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663758);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663759);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663760);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663761);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663762);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663763);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663764);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663765);
			SA_iTween.NativeMethodInfoPtr_Hash_Public_Static_Hashtable_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663766);
			SA_iTween.NativeMethodInfoPtr__ctor_Private_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663767);
			SA_iTween.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663768);
			SA_iTween.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663769);
			SA_iTween.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663770);
			SA_iTween.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663771);
			SA_iTween.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663772);
			SA_iTween.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663773);
			SA_iTween.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663774);
			SA_iTween.NativeMethodInfoPtr_DrawLineHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663775);
			SA_iTween.NativeMethodInfoPtr_DrawPathHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663776);
			SA_iTween.NativeMethodInfoPtr_PathControlPointGenerator_Private_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663777);
			SA_iTween.NativeMethodInfoPtr_Interp_Private_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663778);
			SA_iTween.NativeMethodInfoPtr_Launch_Private_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663779);
			SA_iTween.NativeMethodInfoPtr_CleanArgs_Private_Static_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663780);
			SA_iTween.NativeMethodInfoPtr_GenerateID_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663781);
			SA_iTween.NativeMethodInfoPtr_RetrieveArgs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663782);
			SA_iTween.NativeMethodInfoPtr_GetEasingFunction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663783);
			SA_iTween.NativeMethodInfoPtr_UpdatePercentage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663784);
			SA_iTween.NativeMethodInfoPtr_CallBack_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663785);
			SA_iTween.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663786);
			SA_iTween.NativeMethodInfoPtr_ConflictCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663787);
			SA_iTween.NativeMethodInfoPtr_EnableKinematic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663788);
			SA_iTween.NativeMethodInfoPtr_DisableKinematic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663789);
			SA_iTween.NativeMethodInfoPtr_ResumeDelay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663790);
			SA_iTween.NativeMethodInfoPtr_linear_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663791);
			SA_iTween.NativeMethodInfoPtr_clerp_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663792);
			SA_iTween.NativeMethodInfoPtr_spring_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663793);
			SA_iTween.NativeMethodInfoPtr_easeInQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663794);
			SA_iTween.NativeMethodInfoPtr_easeOutQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663795);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663796);
			SA_iTween.NativeMethodInfoPtr_easeInCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663797);
			SA_iTween.NativeMethodInfoPtr_easeOutCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663798);
			SA_iTween.NativeMethodInfoPtr_easeInOutCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663799);
			SA_iTween.NativeMethodInfoPtr_easeInQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663800);
			SA_iTween.NativeMethodInfoPtr_easeOutQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663801);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663802);
			SA_iTween.NativeMethodInfoPtr_easeInQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663803);
			SA_iTween.NativeMethodInfoPtr_easeOutQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663804);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663805);
			SA_iTween.NativeMethodInfoPtr_easeInSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663806);
			SA_iTween.NativeMethodInfoPtr_easeOutSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663807);
			SA_iTween.NativeMethodInfoPtr_easeInOutSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663808);
			SA_iTween.NativeMethodInfoPtr_easeInExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663809);
			SA_iTween.NativeMethodInfoPtr_easeOutExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663810);
			SA_iTween.NativeMethodInfoPtr_easeInOutExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663811);
			SA_iTween.NativeMethodInfoPtr_easeInCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663812);
			SA_iTween.NativeMethodInfoPtr_easeOutCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663813);
			SA_iTween.NativeMethodInfoPtr_easeInOutCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663814);
			SA_iTween.NativeMethodInfoPtr_easeInBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663815);
			SA_iTween.NativeMethodInfoPtr_easeOutBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663816);
			SA_iTween.NativeMethodInfoPtr_easeInOutBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663817);
			SA_iTween.NativeMethodInfoPtr_easeInBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663818);
			SA_iTween.NativeMethodInfoPtr_easeOutBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663819);
			SA_iTween.NativeMethodInfoPtr_easeInOutBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663820);
			SA_iTween.NativeMethodInfoPtr_punch_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663821);
			SA_iTween.NativeMethodInfoPtr_easeInElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663822);
			SA_iTween.NativeMethodInfoPtr_easeOutElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663823);
			SA_iTween.NativeMethodInfoPtr_easeInOutElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100663824);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000C30C File Offset: 0x0000A50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101101, XrefRangeEnd = 101106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init(GameObject target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Init_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000C344 File Offset: 0x0000A544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101106, XrefRangeEnd = 101155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeFrom(float amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000C384 File Offset: 0x0000A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101155, XrefRangeEnd = 101173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeFrom(Hashtable args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101173, XrefRangeEnd = 101222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeTo(float amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101222, XrefRangeEnd = 101240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeTo(Hashtable args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000C434 File Offset: 0x0000A634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101240, XrefRangeEnd = 101310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValueTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ValueTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000C47C File Offset: 0x0000A67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101310, XrefRangeEnd = 101336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeFrom(GameObject target, float alpha, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101336, XrefRangeEnd = 101340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000C518 File Offset: 0x0000A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101340, XrefRangeEnd = 101366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeTo(GameObject target, float alpha, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000C56C File Offset: 0x0000A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101366, XrefRangeEnd = 101370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101370, XrefRangeEnd = 101394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorFrom(GameObject target, Color color, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000C608 File Offset: 0x0000A808
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 101532, RefRangeEnd = 101537, XrefRangeStart = 101394, XrefRangeEnd = 101532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000C650 File Offset: 0x0000A850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101537, XrefRangeEnd = 101561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorTo(GameObject target, Color color, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 101624, RefRangeEnd = 101629, XrefRangeStart = 101561, XrefRangeEnd = 101624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101629, XrefRangeEnd = 101659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioFrom(GameObject target, float volume, float pitch, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000C74C File Offset: 0x0000A94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101688, RefRangeEnd = 101689, XrefRangeStart = 101659, XrefRangeEnd = 101688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000C794 File Offset: 0x0000A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101689, XrefRangeEnd = 101739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioTo(GameObject target, float volume, float pitch, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101739, XrefRangeEnd = 101761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000C83C File Offset: 0x0000AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101761, XrefRangeEnd = 101790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stab(GameObject target, AudioClip audioclip, float delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audioclip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_AudioClip_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000C894 File Offset: 0x0000AA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101790, XrefRangeEnd = 101800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stab(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000C8DC File Offset: 0x0000AADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101800, XrefRangeEnd = 101824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookFrom(GameObject target, Vector3 looktarget, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looktarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000C930 File Offset: 0x0000AB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101911, RefRangeEnd = 101912, XrefRangeStart = 101824, XrefRangeEnd = 101911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000C978 File Offset: 0x0000AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101912, XrefRangeEnd = 101936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookTo(GameObject target, Vector3 looktarget, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looktarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101983, RefRangeEnd = 101984, XrefRangeStart = 101936, XrefRangeEnd = 101983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000CA14 File Offset: 0x0000AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101984, XrefRangeEnd = 102008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveTo(GameObject target, Vector3 position, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102061, RefRangeEnd = 102065, XrefRangeStart = 102008, XrefRangeEnd = 102061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102065, XrefRangeEnd = 102089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveFrom(GameObject target, Vector3 position, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000CB04 File Offset: 0x0000AD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102242, RefRangeEnd = 102243, XrefRangeStart = 102089, XrefRangeEnd = 102242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102243, XrefRangeEnd = 102279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveAdd(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102279, XrefRangeEnd = 102293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveAdd(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102329, RefRangeEnd = 102330, XrefRangeStart = 102293, XrefRangeEnd = 102329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveBy(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102330, XrefRangeEnd = 102344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveBy(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000CC84 File Offset: 0x0000AE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102344, XrefRangeEnd = 102368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleTo(GameObject target, Vector3 scale, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102420, RefRangeEnd = 102422, XrefRangeStart = 102368, XrefRangeEnd = 102420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102422, XrefRangeEnd = 102446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleFrom(GameObject target, Vector3 scale, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000CD74 File Offset: 0x0000AF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102511, RefRangeEnd = 102512, XrefRangeStart = 102446, XrefRangeEnd = 102511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102512, XrefRangeEnd = 102548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleAdd(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000CE10 File Offset: 0x0000B010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102548, XrefRangeEnd = 102562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleAdd(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000CE58 File Offset: 0x0000B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102562, XrefRangeEnd = 102598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleBy(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102598, XrefRangeEnd = 102612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleBy(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102612, XrefRangeEnd = 102636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateTo(GameObject target, Vector3 rotation, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000CF48 File Offset: 0x0000B148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102689, RefRangeEnd = 102691, XrefRangeStart = 102636, XrefRangeEnd = 102689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateTo(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000CF90 File Offset: 0x0000B190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102691, XrefRangeEnd = 102715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateFrom(GameObject target, Vector3 rotation, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102796, RefRangeEnd = 102797, XrefRangeStart = 102715, XrefRangeEnd = 102796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateFrom(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000D02C File Offset: 0x0000B22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102797, XrefRangeEnd = 102833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateAdd(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000D080 File Offset: 0x0000B280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102833, XrefRangeEnd = 102847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateAdd(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102847, XrefRangeEnd = 102883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateBy(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000D11C File Offset: 0x0000B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102883, XrefRangeEnd = 102897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateBy(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000D164 File Offset: 0x0000B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102897, XrefRangeEnd = 102933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakePosition(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102933, XrefRangeEnd = 102947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakePosition(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000D200 File Offset: 0x0000B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102947, XrefRangeEnd = 102983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakeScale(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000D254 File Offset: 0x0000B454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102983, XrefRangeEnd = 102997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakeScale(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000D29C File Offset: 0x0000B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102997, XrefRangeEnd = 103033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakeRotation(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103033, XrefRangeEnd = 103047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakeRotation(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000D338 File Offset: 0x0000B538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103047, XrefRangeEnd = 103088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchPosition(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000D38C File Offset: 0x0000B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103088, XrefRangeEnd = 103106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchPosition(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103106, XrefRangeEnd = 103147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchRotation(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000D428 File Offset: 0x0000B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103147, XrefRangeEnd = 103165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchRotation(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000D470 File Offset: 0x0000B670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103165, XrefRangeEnd = 103206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchScale(GameObject target, Vector3 amount, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103206, XrefRangeEnd = 103224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PunchScale(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000D50C File Offset: 0x0000B70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103457, RefRangeEnd = 103458, XrefRangeStart = 103224, XrefRangeEnd = 103457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000D540 File Offset: 0x0000B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103458, XrefRangeEnd = 103470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRectTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000D574 File Offset: 0x0000B774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103482, RefRangeEnd = 103483, XrefRangeStart = 103470, XrefRangeEnd = 103482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateColorTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103505, RefRangeEnd = 103506, XrefRangeStart = 103483, XrefRangeEnd = 103505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateVector3Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103528, RefRangeEnd = 103529, XrefRangeStart = 103506, XrefRangeEnd = 103528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateVector2Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D610 File Offset: 0x0000B810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103549, RefRangeEnd = 103550, XrefRangeStart = 103529, XrefRangeEnd = 103549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateFloatTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000D644 File Offset: 0x0000B844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103648, RefRangeEnd = 103649, XrefRangeStart = 103550, XrefRangeEnd = 103648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateColorToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000D678 File Offset: 0x0000B878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103688, RefRangeEnd = 103689, XrefRangeStart = 103649, XrefRangeEnd = 103688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateAudioToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103735, RefRangeEnd = 103736, XrefRangeStart = 103689, XrefRangeEnd = 103735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateStabTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103832, RefRangeEnd = 103833, XrefRangeStart = 103736, XrefRangeEnd = 103832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateLookToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D714 File Offset: 0x0000B914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103915, RefRangeEnd = 103916, XrefRangeStart = 103833, XrefRangeEnd = 103915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveToPathTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D748 File Offset: 0x0000B948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103986, RefRangeEnd = 103987, XrefRangeStart = 103916, XrefRangeEnd = 103986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D77C File Offset: 0x0000B97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104037, RefRangeEnd = 104038, XrefRangeStart = 103987, XrefRangeEnd = 104037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104096, RefRangeEnd = 104097, XrefRangeStart = 104038, XrefRangeEnd = 104096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104133, RefRangeEnd = 104134, XrefRangeStart = 104097, XrefRangeEnd = 104133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D818 File Offset: 0x0000BA18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104170, RefRangeEnd = 104171, XrefRangeStart = 104134, XrefRangeEnd = 104170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000D84C File Offset: 0x0000BA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104236, RefRangeEnd = 104237, XrefRangeStart = 104171, XrefRangeEnd = 104236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D880 File Offset: 0x0000BA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104273, RefRangeEnd = 104274, XrefRangeStart = 104237, XrefRangeEnd = 104273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104310, RefRangeEnd = 104311, XrefRangeStart = 104274, XrefRangeEnd = 104310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104335, RefRangeEnd = 104336, XrefRangeStart = 104311, XrefRangeEnd = 104335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakePositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D91C File Offset: 0x0000BB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104359, RefRangeEnd = 104360, XrefRangeStart = 104336, XrefRangeEnd = 104359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakeScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D950 File Offset: 0x0000BB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104383, RefRangeEnd = 104384, XrefRangeStart = 104360, XrefRangeEnd = 104383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakeRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D984 File Offset: 0x0000BB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104409, RefRangeEnd = 104410, XrefRangeStart = 104384, XrefRangeEnd = 104409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchPositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104434, RefRangeEnd = 104435, XrefRangeStart = 104410, XrefRangeEnd = 104434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104459, RefRangeEnd = 104460, XrefRangeStart = 104435, XrefRangeEnd = 104459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000DA20 File Offset: 0x0000BC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104460, XrefRangeEnd = 104484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRectTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000DA54 File Offset: 0x0000BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104484, XrefRangeEnd = 104496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104496, XrefRangeEnd = 104507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVector3Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000DABC File Offset: 0x0000BCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104507, XrefRangeEnd = 104517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVector2Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104517, XrefRangeEnd = 104526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFloatTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000DB24 File Offset: 0x0000BD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104526, XrefRangeEnd = 104572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000DB58 File Offset: 0x0000BD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104572, XrefRangeEnd = 104578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStabTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyStabTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104578, XrefRangeEnd = 104619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveToPathTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104619, XrefRangeEnd = 104635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000DC28 File Offset: 0x0000BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104635, XrefRangeEnd = 104653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104653, XrefRangeEnd = 104658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyScaleToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000DC90 File Offset: 0x0000BE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104658, XrefRangeEnd = 104663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLookToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104663, XrefRangeEnd = 104684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotateToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104684, XrefRangeEnd = 104696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotateAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104696, XrefRangeEnd = 104724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakePositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000DD60 File Offset: 0x0000BF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104724, XrefRangeEnd = 104731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakeScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000DD94 File Offset: 0x0000BF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104731, XrefRangeEnd = 104745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakeRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000DDC8 File Offset: 0x0000BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104745, XrefRangeEnd = 104772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchPositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104772, XrefRangeEnd = 104793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000DE30 File Offset: 0x0000C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104793, XrefRangeEnd = 104806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000DE64 File Offset: 0x0000C064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104806, XrefRangeEnd = 104810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TweenDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenDelay_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104810, XrefRangeEnd = 104841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104841, XrefRangeEnd = 104845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TweenRestart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenRestart_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000DF18 File Offset: 0x0000C118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104853, RefRangeEnd = 104855, XrefRangeStart = 104845, XrefRangeEnd = 104853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000DF4C File Offset: 0x0000C14C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 104874, RefRangeEnd = 104878, XrefRangeStart = 104855, XrefRangeEnd = 104874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000DF80 File Offset: 0x0000C180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104878, XrefRangeEnd = 104883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104883, XrefRangeEnd = 104899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RectUpdate_Public_Static_Rect_Rect_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000E010 File Offset: 0x0000C210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104899, XrefRangeEnd = 104900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Vector3Update_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000E06C File Offset: 0x0000C26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104900, XrefRangeEnd = 104901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Vector2Update_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104901, XrefRangeEnd = 104902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FloatUpdate(float currentValue, float targetValue, float speed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FloatUpdate_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000E124 File Offset: 0x0000C324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104902, XrefRangeEnd = 104911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000E16C File Offset: 0x0000C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104911, XrefRangeEnd = 104941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeUpdate(GameObject target, float alpha, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105053, RefRangeEnd = 105057, XrefRangeStart = 104941, XrefRangeEnd = 105053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000E208 File Offset: 0x0000C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105057, XrefRangeEnd = 105081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ColorUpdate(GameObject target, Color color, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000E25C File Offset: 0x0000C45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105120, RefRangeEnd = 105121, XrefRangeStart = 105081, XrefRangeEnd = 105120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105121, XrefRangeEnd = 105151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AudioUpdate(GameObject target, float volume, float pitch, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000E304 File Offset: 0x0000C504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105238, RefRangeEnd = 105239, XrefRangeStart = 105151, XrefRangeEnd = 105238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000E34C File Offset: 0x0000C54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105239, XrefRangeEnd = 105263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateUpdate(GameObject target, Vector3 rotation, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105334, RefRangeEnd = 105335, XrefRangeStart = 105263, XrefRangeEnd = 105334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105335, XrefRangeEnd = 105359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleUpdate(GameObject target, Vector3 scale, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000E43C File Offset: 0x0000C63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105473, RefRangeEnd = 105474, XrefRangeStart = 105359, XrefRangeEnd = 105473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000E484 File Offset: 0x0000C684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105474, XrefRangeEnd = 105498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveUpdate(GameObject target, Vector3 position, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105548, RefRangeEnd = 105551, XrefRangeStart = 105498, XrefRangeEnd = 105548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookUpdate(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000E520 File Offset: 0x0000C720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105551, XrefRangeEnd = 105575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookUpdate(GameObject target, Vector3 looktarget, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looktarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000E574 File Offset: 0x0000C774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105575, XrefRangeEnd = 105589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PathLength(Il2CppReferenceArray<Transform> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105589, XrefRangeEnd = 105598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PathLength(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105598, XrefRangeEnd = 105612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D CameraTexture(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraTexture_Public_Static_Texture2D_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000E63C File Offset: 0x0000C83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105612, XrefRangeEnd = 105619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutOnPath(GameObject target, Il2CppStructArray<Vector3> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000E694 File Offset: 0x0000C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105619, XrefRangeEnd = 105625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutOnPath(Transform target, Il2CppStructArray<Vector3> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105625, XrefRangeEnd = 105637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutOnPath(GameObject target, Il2CppReferenceArray<Transform> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppReferenceArray_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000E744 File Offset: 0x0000C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105637, XrefRangeEnd = 105648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutOnPath(Transform target, Il2CppReferenceArray<Transform> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppReferenceArray_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000E79C File Offset: 0x0000C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105648, XrefRangeEnd = 105658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 PointOnPath(Il2CppReferenceArray<Transform> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppReferenceArray_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105658, XrefRangeEnd = 105668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Il2CppStructArray<Vector3> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000E824 File Offset: 0x0000CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105668, XrefRangeEnd = 105674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Il2CppStructArray<Vector3> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000E868 File Offset: 0x0000CA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105674, XrefRangeEnd = 105689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Il2CppReferenceArray<Transform> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105689, XrefRangeEnd = 105700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Il2CppReferenceArray<Transform> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105700, XrefRangeEnd = 105710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineGizmos(Il2CppStructArray<Vector3> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000E91C File Offset: 0x0000CB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105710, XrefRangeEnd = 105716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineGizmos(Il2CppStructArray<Vector3> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000E960 File Offset: 0x0000CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105716, XrefRangeEnd = 105731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineGizmos(Il2CppReferenceArray<Transform> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000E998 File Offset: 0x0000CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105731, XrefRangeEnd = 105742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineGizmos(Il2CppReferenceArray<Transform> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105742, XrefRangeEnd = 105752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineHandles(Il2CppStructArray<Vector3> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000EA14 File Offset: 0x0000CC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105752, XrefRangeEnd = 105758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineHandles(Il2CppStructArray<Vector3> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000EA58 File Offset: 0x0000CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105758, XrefRangeEnd = 105773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineHandles(Il2CppReferenceArray<Transform> line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105773, XrefRangeEnd = 105784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineHandles(Il2CppReferenceArray<Transform> line, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105784, XrefRangeEnd = 105789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 PointOnPath(Il2CppStructArray<Vector3> path, float percent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000EB24 File Offset: 0x0000CD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105789, XrefRangeEnd = 105799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105799, XrefRangeEnd = 105805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(Il2CppStructArray<Vector3> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105805, XrefRangeEnd = 105820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(Il2CppReferenceArray<Transform> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105820, XrefRangeEnd = 105831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(Il2CppReferenceArray<Transform> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105831, XrefRangeEnd = 105841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathGizmos(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000EC54 File Offset: 0x0000CE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105841, XrefRangeEnd = 105847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathGizmos(Il2CppStructArray<Vector3> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000EC98 File Offset: 0x0000CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105847, XrefRangeEnd = 105862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathGizmos(Il2CppReferenceArray<Transform> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105862, XrefRangeEnd = 105873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathGizmos(Il2CppReferenceArray<Transform> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000ED14 File Offset: 0x0000CF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105873, XrefRangeEnd = 105883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathHandles(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000ED4C File Offset: 0x0000CF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105883, XrefRangeEnd = 105889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathHandles(Il2CppStructArray<Vector3> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105889, XrefRangeEnd = 105904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathHandles(Il2CppReferenceArray<Transform> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105904, XrefRangeEnd = 105915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathHandles(Il2CppReferenceArray<Transform> path, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000EE0C File Offset: 0x0000D00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105915, XrefRangeEnd = 105934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeDepth(int depth)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeDepth_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000EE40 File Offset: 0x0000D040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105934, XrefRangeEnd = 105948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeDestroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000EE68 File Offset: 0x0000D068
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeSwap(Texture2D texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeSwap_Public_Static_Void_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105948, XrefRangeEnd = 105969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CameraFadeAdd(Texture2D texture, int depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105969, XrefRangeEnd = 105994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CameraFadeAdd(Texture2D texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000EF38 File Offset: 0x0000D138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105994, XrefRangeEnd = 106019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CameraFadeAdd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000EF6C File Offset: 0x0000D16C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106026, RefRangeEnd = 106028, XrefRangeStart = 106019, XrefRangeEnd = 106026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(GameObject target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106052, RefRangeEnd = 106053, XrefRangeStart = 106028, XrefRangeEnd = 106052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(GameObject target, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106065, RefRangeEnd = 106066, XrefRangeStart = 106053, XrefRangeEnd = 106065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(GameObject target, string type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000F030 File Offset: 0x0000D230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106101, RefRangeEnd = 106102, XrefRangeStart = 106066, XrefRangeEnd = 106101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(GameObject target, string type, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000F088 File Offset: 0x0000D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106102, XrefRangeEnd = 106118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106118, XrefRangeEnd = 106142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106153, RefRangeEnd = 106155, XrefRangeStart = 106142, XrefRangeEnd = 106153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(GameObject target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000F120 File Offset: 0x0000D320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106179, RefRangeEnd = 106180, XrefRangeStart = 106155, XrefRangeEnd = 106179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(GameObject target, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000F164 File Offset: 0x0000D364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106196, RefRangeEnd = 106197, XrefRangeStart = 106180, XrefRangeEnd = 106196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(GameObject target, string type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106236, RefRangeEnd = 106237, XrefRangeStart = 106197, XrefRangeEnd = 106236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(GameObject target, string type, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000F204 File Offset: 0x0000D404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106237, XrefRangeEnd = 106253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000F22C File Offset: 0x0000D42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106253, XrefRangeEnd = 106277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000F264 File Offset: 0x0000D464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106277, XrefRangeEnd = 106282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000F294 File Offset: 0x0000D494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106282, XrefRangeEnd = 106304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106304, XrefRangeEnd = 106307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(GameObject target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000F31C File Offset: 0x0000D51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106307, XrefRangeEnd = 106318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(GameObject target, string type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000F370 File Offset: 0x0000D570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106318, XrefRangeEnd = 106341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000F398 File Offset: 0x0000D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106341, XrefRangeEnd = 106365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000F3D0 File Offset: 0x0000D5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106365, XrefRangeEnd = 106389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopByName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000F408 File Offset: 0x0000D608
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106396, RefRangeEnd = 106399, XrefRangeStart = 106389, XrefRangeEnd = 106396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(GameObject target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000F440 File Offset: 0x0000D640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106423, RefRangeEnd = 106424, XrefRangeStart = 106399, XrefRangeEnd = 106423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(GameObject target, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000F484 File Offset: 0x0000D684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106436, RefRangeEnd = 106437, XrefRangeStart = 106424, XrefRangeEnd = 106436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(GameObject target, string type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106445, RefRangeEnd = 106446, XrefRangeStart = 106437, XrefRangeEnd = 106445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopByName(GameObject target, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000F514 File Offset: 0x0000D714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106481, RefRangeEnd = 106482, XrefRangeStart = 106446, XrefRangeEnd = 106481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(GameObject target, string type, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000F56C File Offset: 0x0000D76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106513, RefRangeEnd = 106514, XrefRangeStart = 106482, XrefRangeEnd = 106513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopByName(GameObject target, string name, bool includechildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includechildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 106521, RefRangeEnd = 106562, XrefRangeStart = 106514, XrefRangeEnd = 106521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable Hash([Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Hash_Public_Static_Hashtable_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000F618 File Offset: 0x0000D818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106562, XrefRangeEnd = 106563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_iTween(Hashtable h)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr__ctor_Private_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000F664 File Offset: 0x0000D864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106563, XrefRangeEnd = 106566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000F698 File Offset: 0x0000D898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106566, XrefRangeEnd = 106570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106570, XrefRangeEnd = 106573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000F70C File Offset: 0x0000D90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106573, XrefRangeEnd = 106576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000F740 File Offset: 0x0000D940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106576, XrefRangeEnd = 106592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000F774 File Offset: 0x0000D974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106592, XrefRangeEnd = 106595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 106611, RefRangeEnd = 106623, XrefRangeStart = 106595, XrefRangeEnd = 106611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineHelper(Il2CppStructArray<Vector3> line, Color color, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawLineHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000F834 File Offset: 0x0000DA34
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 106646, RefRangeEnd = 106658, XrefRangeStart = 106623, XrefRangeEnd = 106646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPathHelper(Il2CppStructArray<Vector3> path, Color color, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DrawPathHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000F88C File Offset: 0x0000DA8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 106669, RefRangeEnd = 106679, XrefRangeStart = 106658, XrefRangeEnd = 106669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> PathControlPointGenerator(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_PathControlPointGenerator_Private_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 106681, RefRangeEnd = 106709, XrefRangeStart = 106679, XrefRangeEnd = 106681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Interp(Il2CppStructArray<Vector3> pts, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Interp_Private_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000F920 File Offset: 0x0000DB20
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 106733, RefRangeEnd = 106771, XrefRangeStart = 106709, XrefRangeEnd = 106733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Launch(GameObject target, Hashtable args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Launch_Private_Static_Void_GameObject_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000F968 File Offset: 0x0000DB68
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 106849, RefRangeEnd = 106895, XrefRangeStart = 106771, XrefRangeEnd = 106849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable CleanArgs(Hashtable args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CleanArgs_Private_Static_Hashtable_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000F9AC File Offset: 0x0000DBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106895, XrefRangeEnd = 106900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateID_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107145, RefRangeEnd = 107146, XrefRangeStart = 106900, XrefRangeEnd = 107145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RetrieveArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RetrieveArgs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107307, RefRangeEnd = 107308, XrefRangeStart = 107146, XrefRangeEnd = 107307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEasingFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GetEasingFunction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000FA40 File Offset: 0x0000DC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107308, XrefRangeEnd = 107312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_UpdatePercentage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000FA74 File Offset: 0x0000DC74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 107343, RefRangeEnd = 107347, XrefRangeStart = 107312, XrefRangeEnd = 107343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallBack(string callbackType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(callbackType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CallBack_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 107375, RefRangeEnd = 107389, XrefRangeStart = 107347, XrefRangeEnd = 107375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107425, RefRangeEnd = 107426, XrefRangeStart = 107389, XrefRangeEnd = 107425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConflictCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ConflictCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000FB20 File Offset: 0x0000DD20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKinematic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_EnableKinematic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000FB54 File Offset: 0x0000DD54
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKinematic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_DisableKinematic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107426, XrefRangeEnd = 107429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ResumeDelay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107429, XrefRangeEnd = 107430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float linear(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_linear_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000FC24 File Offset: 0x0000DE24
		[CallerCount(0)]
		public unsafe float clerp(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_clerp_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107430, XrefRangeEnd = 107433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float spring(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_spring_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		[CallerCount(0)]
		public unsafe float easeInQuad(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInQuad_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		[CallerCount(0)]
		public unsafe float easeOutQuad(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutQuad_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		[CallerCount(0)]
		public unsafe float easeInOutQuad(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutQuad_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000FE2C File Offset: 0x0000E02C
		[CallerCount(0)]
		public unsafe float easeInCubic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInCubic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000FE94 File Offset: 0x0000E094
		[CallerCount(0)]
		public unsafe float easeOutCubic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutCubic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000FEFC File Offset: 0x0000E0FC
		[CallerCount(0)]
		public unsafe float easeInOutCubic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutCubic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000FF64 File Offset: 0x0000E164
		[CallerCount(0)]
		public unsafe float easeInQuart(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInQuart_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		[CallerCount(0)]
		public unsafe float easeOutQuart(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutQuart_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010034 File Offset: 0x0000E234
		[CallerCount(0)]
		public unsafe float easeInOutQuart(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutQuart_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001009C File Offset: 0x0000E29C
		[CallerCount(0)]
		public unsafe float easeInQuint(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInQuint_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00010104 File Offset: 0x0000E304
		[CallerCount(0)]
		public unsafe float easeOutQuint(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutQuint_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001016C File Offset: 0x0000E36C
		[CallerCount(0)]
		public unsafe float easeInOutQuint(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutQuint_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000101D4 File Offset: 0x0000E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107433, XrefRangeEnd = 107434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInSine(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInSine_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001023C File Offset: 0x0000E43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107434, XrefRangeEnd = 107435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeOutSine(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutSine_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000102A4 File Offset: 0x0000E4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107435, XrefRangeEnd = 107436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInOutSine(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutSine_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001030C File Offset: 0x0000E50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107436, XrefRangeEnd = 107437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInExpo(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInExpo_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00010374 File Offset: 0x0000E574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107437, XrefRangeEnd = 107438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeOutExpo(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutExpo_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000103DC File Offset: 0x0000E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107438, XrefRangeEnd = 107441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInOutExpo(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutExpo_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00010444 File Offset: 0x0000E644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107441, XrefRangeEnd = 107443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInCirc(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInCirc_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000104AC File Offset: 0x0000E6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107443, XrefRangeEnd = 107445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeOutCirc(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutCirc_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00010514 File Offset: 0x0000E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107445, XrefRangeEnd = 107450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInOutCirc(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutCirc_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001057C File Offset: 0x0000E77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107450, XrefRangeEnd = 107451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInBounce(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInBounce_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000105E4 File Offset: 0x0000E7E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 107451, RefRangeEnd = 107457, XrefRangeStart = 107451, XrefRangeEnd = 107451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeOutBounce(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutBounce_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001064C File Offset: 0x0000E84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107457, XrefRangeEnd = 107460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInOutBounce(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutBounce_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000106B4 File Offset: 0x0000E8B4
		[CallerCount(0)]
		public unsafe float easeInBack(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInBack_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001071C File Offset: 0x0000E91C
		[CallerCount(0)]
		public unsafe float easeOutBack(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutBack_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00010784 File Offset: 0x0000E984
		[CallerCount(0)]
		public unsafe float easeInOutBack(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutBack_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000107EC File Offset: 0x0000E9EC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 107463, RefRangeEnd = 107499, XrefRangeStart = 107460, XrefRangeEnd = 107463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float punch(float amplitude, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amplitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_punch_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00010844 File Offset: 0x0000EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107499, XrefRangeEnd = 107502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeInElastic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInElastic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000108AC File Offset: 0x0000EAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107502, XrefRangeEnd = 107505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float easeOutElastic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeOutElastic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00010914 File Offset: 0x0000EB14
		[CallerCount(0)]
		public unsafe float easeInOutElastic(float start, float end, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_easeInOutElastic_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000026F4 File Offset: 0x000008F4
		public static Hashtable Hash(params global::Il2CppSystem.Object[] args)
		{
			return SA_iTween.Hash(new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002701 File Offset: 0x00000901
		public SA_iTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001097C File Offset: 0x0000EB7C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000270A File Offset: 0x0000090A
		public unsafe static List<Hashtable> tweens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_iTween.NativeFieldInfoPtr_tweens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Hashtable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_iTween.NativeFieldInfoPtr_tweens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000109A4 File Offset: 0x0000EBA4
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000271C File Offset: 0x0000091C
		public unsafe static GameObject cameraFade
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_iTween.NativeFieldInfoPtr_cameraFade, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_iTween.NativeFieldInfoPtr_cameraFade, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000109CC File Offset: 0x0000EBCC
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000272E File Offset: 0x0000092E
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000109F4 File Offset: 0x0000EBF4
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000274D File Offset: 0x0000094D
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00010A1C File Offset: 0x0000EC1C
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000276C File Offset: 0x0000096C
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00010A44 File Offset: 0x0000EC44
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe SA_EaseType easeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_easeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_easeType)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00010A6C File Offset: 0x0000EC6C
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00010A94 File Offset: 0x0000EC94
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000027C1 File Offset: 0x000009C1
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00010ABC File Offset: 0x0000ECBC
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe SA_iTween.LoopType loopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_loopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_loopType)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000027F7 File Offset: 0x000009F7
		public unsafe bool isRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isRunning)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00010B0C File Offset: 0x0000ED0C
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00002812 File Offset: 0x00000A12
		public unsafe bool isPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isPaused)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00010B34 File Offset: 0x0000ED34
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000282D File Offset: 0x00000A2D
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00010B5C File Offset: 0x0000ED5C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000284C File Offset: 0x00000A4C
		public unsafe float runningTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_runningTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_runningTime)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00010B84 File Offset: 0x0000ED84
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002867 File Offset: 0x00000A67
		public unsafe float percentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_percentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_percentage)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00010BAC File Offset: 0x0000EDAC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002882 File Offset: 0x00000A82
		public unsafe float delayStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_delayStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_delayStarted)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000289D File Offset: 0x00000A9D
		public unsafe bool kinematic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_kinematic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_kinematic)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00010BFC File Offset: 0x0000EDFC
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000028B8 File Offset: 0x00000AB8
		public unsafe bool isLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_isLocal)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00010C24 File Offset: 0x0000EE24
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000028D3 File Offset: 0x00000AD3
		public unsafe bool loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_loop)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00010C4C File Offset: 0x0000EE4C
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe bool reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_reverse)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00010C74 File Offset: 0x0000EE74
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002909 File Offset: 0x00000B09
		public unsafe bool wasPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_wasPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_wasPaused)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00010C9C File Offset: 0x0000EE9C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002924 File Offset: 0x00000B24
		public unsafe bool physics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_physics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_physics)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000293F File Offset: 0x00000B3F
		public unsafe Hashtable tweenArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_tweenArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_tweenArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000295E File Offset: 0x00000B5E
		public unsafe Space space
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_space);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_space)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00010D1C File Offset: 0x0000EF1C
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00002979 File Offset: 0x00000B79
		public unsafe SA_iTween.EasingFunction ease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_ease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween.EasingFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_ease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00010D4C File Offset: 0x0000EF4C
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00002998 File Offset: 0x00000B98
		public unsafe SA_iTween.ApplyTween apply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_apply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween.ApplyTween>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_apply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00010D7C File Offset: 0x0000EF7C
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000029B7 File Offset: 0x00000BB7
		public unsafe AudioSource audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00010DAC File Offset: 0x0000EFAC
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000029D6 File Offset: 0x00000BD6
		public unsafe Il2CppStructArray<Vector3> vector3s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_vector3s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_vector3s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00010DDC File Offset: 0x0000EFDC
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000029F5 File Offset: 0x00000BF5
		public unsafe Il2CppStructArray<Vector2> vector2s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_vector2s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_vector2s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00010E0C File Offset: 0x0000F00C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00002A14 File Offset: 0x00000C14
		public unsafe Il2CppObjectBase colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00010E3C File Offset: 0x0000F03C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002A33 File Offset: 0x00000C33
		public unsafe Il2CppStructArray<float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00010E6C File Offset: 0x0000F06C
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00002A52 File Offset: 0x00000C52
		public unsafe Il2CppStructArray<Rect> rects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_rects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_rects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00010E9C File Offset: 0x0000F09C
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00002A71 File Offset: 0x00000C71
		public unsafe SA_iTween.CRSpline path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween.CRSpline>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00010ECC File Offset: 0x0000F0CC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00002A90 File Offset: 0x00000C90
		public unsafe Vector3 preUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_preUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_preUpdate)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe Vector3 postUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_postUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_postUpdate)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00010F1C File Offset: 0x0000F11C
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public unsafe SA_iTween.NamedValueColor namedcolorvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_namedcolorvalue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_namedcolorvalue)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00010F44 File Offset: 0x0000F144
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public unsafe float lastRealTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_lastRealTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_lastRealTime)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00010F6C File Offset: 0x0000F16C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00002AFC File Offset: 0x00000CFC
		public unsafe bool useRealTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_useRealTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_useRealTime)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00010F94 File Offset: 0x0000F194
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00002B17 File Offset: 0x00000D17
		public unsafe Transform thisTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_thisTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.NativeFieldInfoPtr_thisTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_tweens;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_cameraFade;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_easeType;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_loopType;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_isRunning;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_isPaused;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_runningTime;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_percentage;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_delayStarted;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_kinematic;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_isLocal;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_wasPaused;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_physics;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_tweenArguments;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_space;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_ease;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_apply;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_audioSource;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_vector3s;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_vector2s;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_rects;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_preUpdate;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_postUpdate;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_namedcolorvalue;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_lastRealTime;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_useRealTime;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_thisTransform;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_GameObject_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Single_Single_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Hashtable_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Single_Single_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Hashtable_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_ValueTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_AudioClip_Single_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTargets_Private_Void_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStabTargets_Private_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_TweenDelay_Private_IEnumerator_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_TweenStart_Private_Void_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_TweenRestart_Private_IEnumerator_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_TweenUpdate_Private_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_TweenComplete_Private_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_TweenLoop_Private_Void_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_RectUpdate_Public_Static_Rect_Rect_Rect_Single_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Vector3Update_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_Vector2Update_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_FloatUpdate_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_CameraTexture_Public_Static_Texture2D_Color_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeDepth_Public_Static_Void_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeSwap_Public_Static_Void_Texture2D_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_String_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_String_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_String_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_String_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_Hashtable_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Hashtable_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_PathControlPointGenerator_Private_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Private_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_Launch_Private_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_CleanArgs_Private_Static_Hashtable_Hashtable_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GenerateID_Private_Static_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveArgs_Private_Void_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_GetEasingFunction_Private_Void_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePercentage_Private_Void_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_CallBack_Private_Void_String_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_ConflictCheck_Private_Void_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_EnableKinematic_Private_Void_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_DisableKinematic_Private_Void_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_ResumeDelay_Private_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_linear_Private_Single_Single_Single_Single_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_clerp_Private_Single_Single_Single_Single_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_spring_Private_Single_Single_Single_Single_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_easeInCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_easeOutCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_easeInSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_easeOutSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_easeInExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_easeOutExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_easeInCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_easeOutCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_easeInBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_easeOutBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_easeInBack_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_easeOutBack_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutBack_Private_Single_Single_Single_Single_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_punch_Private_Single_Single_Single_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_easeInElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_easeOutElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x02000052 RID: 82
		public sealed class EasingFunction : MulticastDelegate
		{
			// Token: 0x06000409 RID: 1033 RVA: 0x00013AA0 File Offset: 0x00011CA0
			// Note: this type is marked as 'beforefieldinit'.
			static EasingFunction()
			{
				Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "EasingFunction");
				SA_iTween.EasingFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100663899);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100663900);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100663901);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100663902);
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00013B14 File Offset: 0x00011D14
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EasingFunction(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.EasingFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00013B70 File Offset: 0x00011D70
			[CallerCount(80)]
			[CachedScanResults(RefRangeStart = 100967, RefRangeEnd = 101047, XrefRangeStart = 100963, XrefRangeEnd = 100967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Invoke(float start, float end, float Value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.EasingFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00013BD8 File Offset: 0x00011DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101047, XrefRangeEnd = 101055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float start, float end, float Value, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Value;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.EasingFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00013C68 File Offset: 0x00011E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101055, XrefRangeEnd = 101057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.EasingFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x000031FE File Offset: 0x000013FE
			public EasingFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00003207 File Offset: 0x00001407
			public static implicit operator SA_iTween.EasingFunction(Func<float, float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<SA_iTween.EasingFunction>(A_0);
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000320F File Offset: 0x0000140F
			public static SA_iTween.EasingFunction operator +(SA_iTween.EasingFunction A_0, SA_iTween.EasingFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SA_iTween.EasingFunction>();
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0000321D File Offset: 0x0000141D
			public static SA_iTween.EasingFunction operator -(SA_iTween.EasingFunction A_0, SA_iTween.EasingFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SA_iTween.EasingFunction>();
				}
				return delegate2;
			}

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_0;

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_AsyncCallback_Object_0;

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x02000053 RID: 83
		public sealed class ApplyTween : MulticastDelegate
		{
			// Token: 0x06000412 RID: 1042 RVA: 0x00013CB8 File Offset: 0x00011EB8
			// Note: this type is marked as 'beforefieldinit'.
			static ApplyTween()
			{
				Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "ApplyTween");
				SA_iTween.ApplyTween.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100663903);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100663904);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100663905);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100663906);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00013D2C File Offset: 0x00011F2C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ApplyTween(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.ApplyTween.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00013D88 File Offset: 0x00011F88
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.ApplyTween.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00013DBC File Offset: 0x00011FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101057, XrefRangeEnd = 101058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.ApplyTween.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00013E20 File Offset: 0x00012020
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.ApplyTween.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x0000322E File Offset: 0x0000142E
			public ApplyTween(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x00003237 File Offset: 0x00001437
			public static implicit operator SA_iTween.ApplyTween(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<SA_iTween.ApplyTween>(A_0);
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x0000323F File Offset: 0x0000143F
			public static SA_iTween.ApplyTween operator +(SA_iTween.ApplyTween A_0, SA_iTween.ApplyTween A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SA_iTween.ApplyTween>();
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0000324D File Offset: 0x0000144D
			public static SA_iTween.ApplyTween operator -(SA_iTween.ApplyTween A_0, SA_iTween.ApplyTween A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SA_iTween.ApplyTween>();
				}
				return delegate2;
			}

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000054 RID: 84
		public enum LoopType
		{
			// Token: 0x0400031E RID: 798
			none,
			// Token: 0x0400031F RID: 799
			loop,
			// Token: 0x04000320 RID: 800
			pingPong
		}

		// Token: 0x02000055 RID: 85
		public enum NamedValueColor
		{
			// Token: 0x04000322 RID: 802
			_Color,
			// Token: 0x04000323 RID: 803
			_SpecColor,
			// Token: 0x04000324 RID: 804
			_Emission,
			// Token: 0x04000325 RID: 805
			_ReflectColor
		}

		// Token: 0x02000056 RID: 86
		public static class Defaults : global::Il2CppSystem.Object
		{
			// Token: 0x0600041B RID: 1051 RVA: 0x00013E64 File Offset: 0x00012064
			// Note: this type is marked as 'beforefieldinit'.
			static Defaults()
			{
				Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "Defaults");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr);
				SA_iTween.Defaults.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "time");
				SA_iTween.Defaults.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "delay");
				SA_iTween.Defaults.NativeFieldInfoPtr_namedColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "namedColorValue");
				SA_iTween.Defaults.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "loopType");
				SA_iTween.Defaults.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "easeType");
				SA_iTween.Defaults.NativeFieldInfoPtr_lookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "lookSpeed");
				SA_iTween.Defaults.NativeFieldInfoPtr_isLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "isLocal");
				SA_iTween.Defaults.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "space");
				SA_iTween.Defaults.NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "orientToPath");
				SA_iTween.Defaults.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "color");
				SA_iTween.Defaults.NativeFieldInfoPtr_updateTimePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "updateTimePercentage");
				SA_iTween.Defaults.NativeFieldInfoPtr_updateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "updateTime");
				SA_iTween.Defaults.NativeFieldInfoPtr_cameraFadeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "cameraFadeDepth");
				SA_iTween.Defaults.NativeFieldInfoPtr_lookAhead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "lookAhead");
				SA_iTween.Defaults.NativeFieldInfoPtr_useRealTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "useRealTime");
				SA_iTween.Defaults.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.Defaults>.NativeClassPtr, "up");
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x0000325E File Offset: 0x0000145E
			public Defaults(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600041D RID: 1053 RVA: 0x00013FD0 File Offset: 0x000121D0
			// (set) Token: 0x0600041E RID: 1054 RVA: 0x00003267 File Offset: 0x00001467
			public unsafe static float time
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_time, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_time, (void*)(&value));
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x00013FEC File Offset: 0x000121EC
			// (set) Token: 0x06000420 RID: 1056 RVA: 0x00003275 File Offset: 0x00001475
			public unsafe static float delay
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_delay, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_delay, (void*)(&value));
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x00014008 File Offset: 0x00012208
			// (set) Token: 0x06000422 RID: 1058 RVA: 0x00003283 File Offset: 0x00001483
			public unsafe static SA_iTween.NamedValueColor namedColorValue
			{
				get
				{
					SA_iTween.NamedValueColor namedValueColor;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_namedColorValue, (void*)(&namedValueColor));
					return namedValueColor;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_namedColorValue, (void*)(&value));
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000423 RID: 1059 RVA: 0x00014024 File Offset: 0x00012224
			// (set) Token: 0x06000424 RID: 1060 RVA: 0x00003291 File Offset: 0x00001491
			public unsafe static SA_iTween.LoopType loopType
			{
				get
				{
					SA_iTween.LoopType loopType;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_loopType, (void*)(&loopType));
					return loopType;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_loopType, (void*)(&value));
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000425 RID: 1061 RVA: 0x00014040 File Offset: 0x00012240
			// (set) Token: 0x06000426 RID: 1062 RVA: 0x0000329F File Offset: 0x0000149F
			public unsafe static SA_EaseType easeType
			{
				get
				{
					SA_EaseType sa_EaseType;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_easeType, (void*)(&sa_EaseType));
					return sa_EaseType;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_easeType, (void*)(&value));
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001405C File Offset: 0x0001225C
			// (set) Token: 0x06000428 RID: 1064 RVA: 0x000032AD File Offset: 0x000014AD
			public unsafe static float lookSpeed
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_lookSpeed, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_lookSpeed, (void*)(&value));
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x06000429 RID: 1065 RVA: 0x00014078 File Offset: 0x00012278
			// (set) Token: 0x0600042A RID: 1066 RVA: 0x000032BB File Offset: 0x000014BB
			public unsafe static bool isLocal
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_isLocal, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_isLocal, (void*)(&value));
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x00014094 File Offset: 0x00012294
			// (set) Token: 0x0600042C RID: 1068 RVA: 0x000032C9 File Offset: 0x000014C9
			public unsafe static Space space
			{
				get
				{
					Space space;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_space, (void*)(&space));
					return space;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_space, (void*)(&value));
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x000140B0 File Offset: 0x000122B0
			// (set) Token: 0x0600042E RID: 1070 RVA: 0x000032D7 File Offset: 0x000014D7
			public unsafe static bool orientToPath
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_orientToPath, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_orientToPath, (void*)(&value));
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x000140CC File Offset: 0x000122CC
			// (set) Token: 0x06000430 RID: 1072 RVA: 0x000032E5 File Offset: 0x000014E5
			public unsafe static Color color
			{
				get
				{
					Color color;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_color, (void*)(&color));
					return color;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_color, (void*)(&value));
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000431 RID: 1073 RVA: 0x000140E8 File Offset: 0x000122E8
			// (set) Token: 0x06000432 RID: 1074 RVA: 0x000032F3 File Offset: 0x000014F3
			public unsafe static float updateTimePercentage
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_updateTimePercentage, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_updateTimePercentage, (void*)(&value));
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x00014104 File Offset: 0x00012304
			// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003301 File Offset: 0x00001501
			public unsafe static float updateTime
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_updateTime, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_updateTime, (void*)(&value));
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x00014120 File Offset: 0x00012320
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x0000330F File Offset: 0x0000150F
			public unsafe static int cameraFadeDepth
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_cameraFadeDepth, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_cameraFadeDepth, (void*)(&value));
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001413C File Offset: 0x0001233C
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000331D File Offset: 0x0000151D
			public unsafe static float lookAhead
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_lookAhead, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_lookAhead, (void*)(&value));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00014158 File Offset: 0x00012358
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000332B File Offset: 0x0000152B
			public unsafe static bool useRealTime
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_useRealTime, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_useRealTime, (void*)(&value));
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00014174 File Offset: 0x00012374
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003339 File Offset: 0x00001539
			public unsafe static Vector3 up
			{
				get
				{
					Vector3 vector;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_up, (void*)(&vector));
					return vector;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_up, (void*)(&value));
				}
			}

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeFieldInfoPtr_namedColorValue;

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeFieldInfoPtr_loopType;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeFieldInfoPtr_easeType;

			// Token: 0x0400032B RID: 811
			private static readonly IntPtr NativeFieldInfoPtr_lookSpeed;

			// Token: 0x0400032C RID: 812
			private static readonly IntPtr NativeFieldInfoPtr_isLocal;

			// Token: 0x0400032D RID: 813
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x0400032E RID: 814
			private static readonly IntPtr NativeFieldInfoPtr_orientToPath;

			// Token: 0x0400032F RID: 815
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeFieldInfoPtr_updateTimePercentage;

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeFieldInfoPtr_updateTime;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeFieldInfoPtr_cameraFadeDepth;

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeFieldInfoPtr_lookAhead;

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeFieldInfoPtr_useRealTime;

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeFieldInfoPtr_up;
		}

		// Token: 0x02000057 RID: 87
		public class CRSpline : global::Il2CppSystem.Object
		{
			// Token: 0x0600043D RID: 1085 RVA: 0x00014190 File Offset: 0x00012390
			// Note: this type is marked as 'beforefieldinit'.
			static CRSpline()
			{
				Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "CRSpline");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr);
				SA_iTween.CRSpline.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, "pts");
				SA_iTween.CRSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, 100663908);
				SA_iTween.CRSpline.NativeMethodInfoPtr_Interp_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, 100663909);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x000141F8 File Offset: 0x000123F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101064, RefRangeEnd = 101065, XrefRangeStart = 101058, XrefRangeEnd = 101064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CRSpline([Optional] Il2CppStructArray<Vector3> pts)
			{
				if (pts == null)
				{
					pts = new Il2CppStructArray<Vector3>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr));
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.CRSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00014250 File Offset: 0x00012450
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 101067, RefRangeEnd = 101073, XrefRangeStart = 101065, XrefRangeEnd = 101067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 Interp(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.CRSpline.NativeMethodInfoPtr_Interp_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00003347 File Offset: 0x00001547
			public CRSpline(params Vector3[] pts)
				: this(new Il2CppStructArray<Vector3>(pts))
			{
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00003355 File Offset: 0x00001555
			public CRSpline(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001429C File Offset: 0x0001249C
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000335E File Offset: 0x0000155E
			public unsafe Il2CppStructArray<Vector3> pts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.CRSpline.NativeFieldInfoPtr_pts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween.CRSpline.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeFieldInfoPtr_pts;

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Vector3_Single_0;
		}

		// Token: 0x02000058 RID: 88
		[ObfuscatedName("SA.Foundation.Animation.SA_iTween+<TweenDelay>d__149")]
		public sealed class _TweenDelay_d__149 : global::Il2CppSystem.Object
		{
			// Token: 0x06000444 RID: 1092 RVA: 0x000142CC File Offset: 0x000124CC
			// Note: this type is marked as 'beforefieldinit'.
			static _TweenDelay_d__149()
			{
				Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<TweenDelay>d__149");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr);
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>1__state");
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>2__current");
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>4__this");
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663910);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663911);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663912);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663913);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663914);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100663915);
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x000143AC File Offset: 0x000125AC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TweenDelay_d__149(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x000143F4 File Offset: 0x000125F4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00014428 File Offset: 0x00012628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101073, XrefRangeEnd = 101078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x00014464 File Offset: 0x00012664
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000144A4 File Offset: 0x000126A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101078, XrefRangeEnd = 101083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x000144D8 File Offset: 0x000126D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x0000337D File Offset: 0x0000157D
			public _TweenDelay_d__149(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00014518 File Offset: 0x00012718
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003386 File Offset: 0x00001586
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00014540 File Offset: 0x00012740
			// (set) Token: 0x0600044F RID: 1103 RVA: 0x000033A1 File Offset: 0x000015A1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00014570 File Offset: 0x00012770
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x000033C0 File Offset: 0x000015C0
			public unsafe SA_iTween __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400033C RID: 828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("SA.Foundation.Animation.SA_iTween+<TweenRestart>d__151")]
		public sealed class _TweenRestart_d__151 : global::Il2CppSystem.Object
		{
			// Token: 0x06000452 RID: 1106 RVA: 0x000145A0 File Offset: 0x000127A0
			// Note: this type is marked as 'beforefieldinit'.
			static _TweenRestart_d__151()
			{
				Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<TweenRestart>d__151");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr);
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>1__state");
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>2__current");
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>4__this");
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663916);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663917);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663918);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663919);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663920);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100663921);
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x00014680 File Offset: 0x00012880
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TweenRestart_d__151(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x000146C8 File Offset: 0x000128C8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x000146FC File Offset: 0x000128FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101083, XrefRangeEnd = 101088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00014738 File Offset: 0x00012938
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00014778 File Offset: 0x00012978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101088, XrefRangeEnd = 101093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x000147AC File Offset: 0x000129AC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x000033DF File Offset: 0x000015DF
			public _TweenRestart_d__151(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x000147EC File Offset: 0x000129EC
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x000033E8 File Offset: 0x000015E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x00014814 File Offset: 0x00012A14
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003403 File Offset: 0x00001603
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00014844 File Offset: 0x00012A44
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003422 File Offset: 0x00001622
			public unsafe SA_iTween __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("SA.Foundation.Animation.SA_iTween+<Start>d__240")]
		public sealed class _Start_d__240 : global::Il2CppSystem.Object
		{
			// Token: 0x06000460 RID: 1120 RVA: 0x00014874 File Offset: 0x00012A74
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__240()
			{
				Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<Start>d__240");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr);
				SA_iTween._Start_d__240.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>1__state");
				SA_iTween._Start_d__240.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>2__current");
				SA_iTween._Start_d__240.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>4__this");
				SA_iTween._Start_d__240.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663922);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663923);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663924);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663925);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663926);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100663927);
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00014954 File Offset: 0x00012B54
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__240(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x0001499C File Offset: 0x00012B9C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x000149D0 File Offset: 0x00012BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101093, XrefRangeEnd = 101096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x00014A0C File Offset: 0x00012C0C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00014A4C File Offset: 0x00012C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101096, XrefRangeEnd = 101101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x00014A80 File Offset: 0x00012C80
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00003441 File Offset: 0x00001641
			public _Start_d__240(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x00014AC0 File Offset: 0x00012CC0
			// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000344A File Offset: 0x0000164A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x0600046A RID: 1130 RVA: 0x00014AE8 File Offset: 0x00012CE8
			// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003465 File Offset: 0x00001665
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014B18 File Offset: 0x00012D18
			// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003484 File Offset: 0x00001684
			public unsafe SA_iTween __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_iTween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_iTween._Start_d__240.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
