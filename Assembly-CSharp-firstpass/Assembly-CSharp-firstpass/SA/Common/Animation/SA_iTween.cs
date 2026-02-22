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

namespace SA.Common.Animation
{
	// Token: 0x0200031D RID: 797
	public class SA_iTween : MonoBehaviour
	{
		// Token: 0x06002DC7 RID: 11719 RVA: 0x000C3010 File Offset: 0x000C1210
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iTween()
		{
			Il2CppClassPointerStore<SA_iTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Animation", "SA_iTween");
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
			SA_iTween.NativeMethodInfoPtr_Init_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669277);
			SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669278);
			SA_iTween.NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669279);
			SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669280);
			SA_iTween.NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669281);
			SA_iTween.NativeMethodInfoPtr_ValueTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669282);
			SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669283);
			SA_iTween.NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669284);
			SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669285);
			SA_iTween.NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669286);
			SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669287);
			SA_iTween.NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669288);
			SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669289);
			SA_iTween.NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669290);
			SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669291);
			SA_iTween.NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669292);
			SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669293);
			SA_iTween.NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669294);
			SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669295);
			SA_iTween.NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669296);
			SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669297);
			SA_iTween.NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669298);
			SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669299);
			SA_iTween.NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669300);
			SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669301);
			SA_iTween.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669302);
			SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669303);
			SA_iTween.NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669304);
			SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669305);
			SA_iTween.NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669306);
			SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669307);
			SA_iTween.NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669308);
			SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669309);
			SA_iTween.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669310);
			SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669311);
			SA_iTween.NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669312);
			SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669313);
			SA_iTween.NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669314);
			SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669315);
			SA_iTween.NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669316);
			SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669317);
			SA_iTween.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669318);
			SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669319);
			SA_iTween.NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669320);
			SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669321);
			SA_iTween.NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669322);
			SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669323);
			SA_iTween.NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669324);
			SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669325);
			SA_iTween.NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669326);
			SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669327);
			SA_iTween.NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669328);
			SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669329);
			SA_iTween.NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669330);
			SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669331);
			SA_iTween.NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669332);
			SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669333);
			SA_iTween.NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669334);
			SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669335);
			SA_iTween.NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669336);
			SA_iTween.NativeMethodInfoPtr_GenerateTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669337);
			SA_iTween.NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669338);
			SA_iTween.NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669339);
			SA_iTween.NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669340);
			SA_iTween.NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669341);
			SA_iTween.NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669342);
			SA_iTween.NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669343);
			SA_iTween.NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669344);
			SA_iTween.NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669345);
			SA_iTween.NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669346);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669347);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669348);
			SA_iTween.NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669349);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669350);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669351);
			SA_iTween.NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669352);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669353);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669354);
			SA_iTween.NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669355);
			SA_iTween.NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669356);
			SA_iTween.NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669357);
			SA_iTween.NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669358);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669359);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669360);
			SA_iTween.NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669361);
			SA_iTween.NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669362);
			SA_iTween.NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669363);
			SA_iTween.NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669364);
			SA_iTween.NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669365);
			SA_iTween.NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669366);
			SA_iTween.NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669367);
			SA_iTween.NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669368);
			SA_iTween.NativeMethodInfoPtr_ApplyStabTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669369);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669370);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669371);
			SA_iTween.NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669372);
			SA_iTween.NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669373);
			SA_iTween.NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669374);
			SA_iTween.NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669375);
			SA_iTween.NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669376);
			SA_iTween.NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669377);
			SA_iTween.NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669378);
			SA_iTween.NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669379);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669380);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669381);
			SA_iTween.NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669382);
			SA_iTween.NativeMethodInfoPtr_TweenDelay_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669383);
			SA_iTween.NativeMethodInfoPtr_TweenStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669384);
			SA_iTween.NativeMethodInfoPtr_TweenRestart_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669385);
			SA_iTween.NativeMethodInfoPtr_TweenUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669386);
			SA_iTween.NativeMethodInfoPtr_TweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669387);
			SA_iTween.NativeMethodInfoPtr_TweenLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669388);
			SA_iTween.NativeMethodInfoPtr_RectUpdate_Public_Static_Rect_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669389);
			SA_iTween.NativeMethodInfoPtr_Vector3Update_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669390);
			SA_iTween.NativeMethodInfoPtr_Vector2Update_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669391);
			SA_iTween.NativeMethodInfoPtr_FloatUpdate_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669392);
			SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669393);
			SA_iTween.NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669394);
			SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669395);
			SA_iTween.NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669396);
			SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669397);
			SA_iTween.NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669398);
			SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669399);
			SA_iTween.NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669400);
			SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669401);
			SA_iTween.NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669402);
			SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669403);
			SA_iTween.NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669404);
			SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669405);
			SA_iTween.NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669406);
			SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669407);
			SA_iTween.NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669408);
			SA_iTween.NativeMethodInfoPtr_CameraTexture_Public_Static_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669409);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669410);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669411);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669412);
			SA_iTween.NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669413);
			SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669414);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669415);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669416);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669417);
			SA_iTween.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669418);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669419);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669420);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669421);
			SA_iTween.NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669422);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669423);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669424);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669425);
			SA_iTween.NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669426);
			SA_iTween.NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669427);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669428);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669429);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669430);
			SA_iTween.NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669431);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669432);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669433);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669434);
			SA_iTween.NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669435);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669436);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669437);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669438);
			SA_iTween.NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669439);
			SA_iTween.NativeMethodInfoPtr_CameraFadeDepth_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669440);
			SA_iTween.NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669441);
			SA_iTween.NativeMethodInfoPtr_CameraFadeSwap_Public_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669442);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669443);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669444);
			SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669445);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669446);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669447);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669448);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669449);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669450);
			SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669451);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669452);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669453);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669454);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669455);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669456);
			SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669457);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669458);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669459);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669460);
			SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669461);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669462);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669463);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669464);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669465);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669466);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669467);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669468);
			SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669469);
			SA_iTween.NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669470);
			SA_iTween.NativeMethodInfoPtr_Hash_Public_Static_Hashtable_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669471);
			SA_iTween.NativeMethodInfoPtr__ctor_Private_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669472);
			SA_iTween.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669473);
			SA_iTween.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669474);
			SA_iTween.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669475);
			SA_iTween.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669476);
			SA_iTween.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669477);
			SA_iTween.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669478);
			SA_iTween.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669479);
			SA_iTween.NativeMethodInfoPtr_DrawLineHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669480);
			SA_iTween.NativeMethodInfoPtr_DrawPathHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669481);
			SA_iTween.NativeMethodInfoPtr_PathControlPointGenerator_Private_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669482);
			SA_iTween.NativeMethodInfoPtr_Interp_Private_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669483);
			SA_iTween.NativeMethodInfoPtr_Launch_Private_Static_Void_GameObject_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669484);
			SA_iTween.NativeMethodInfoPtr_CleanArgs_Private_Static_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669485);
			SA_iTween.NativeMethodInfoPtr_GenerateID_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669486);
			SA_iTween.NativeMethodInfoPtr_RetrieveArgs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669487);
			SA_iTween.NativeMethodInfoPtr_GetEasingFunction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669488);
			SA_iTween.NativeMethodInfoPtr_UpdatePercentage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669489);
			SA_iTween.NativeMethodInfoPtr_CallBack_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669490);
			SA_iTween.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669491);
			SA_iTween.NativeMethodInfoPtr_ConflictCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669492);
			SA_iTween.NativeMethodInfoPtr_EnableKinematic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669493);
			SA_iTween.NativeMethodInfoPtr_DisableKinematic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669494);
			SA_iTween.NativeMethodInfoPtr_ResumeDelay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669495);
			SA_iTween.NativeMethodInfoPtr_linear_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669496);
			SA_iTween.NativeMethodInfoPtr_clerp_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669497);
			SA_iTween.NativeMethodInfoPtr_spring_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669498);
			SA_iTween.NativeMethodInfoPtr_easeInQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669499);
			SA_iTween.NativeMethodInfoPtr_easeOutQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669500);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuad_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669501);
			SA_iTween.NativeMethodInfoPtr_easeInCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669502);
			SA_iTween.NativeMethodInfoPtr_easeOutCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669503);
			SA_iTween.NativeMethodInfoPtr_easeInOutCubic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669504);
			SA_iTween.NativeMethodInfoPtr_easeInQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669505);
			SA_iTween.NativeMethodInfoPtr_easeOutQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669506);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuart_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669507);
			SA_iTween.NativeMethodInfoPtr_easeInQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669508);
			SA_iTween.NativeMethodInfoPtr_easeOutQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669509);
			SA_iTween.NativeMethodInfoPtr_easeInOutQuint_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669510);
			SA_iTween.NativeMethodInfoPtr_easeInSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669511);
			SA_iTween.NativeMethodInfoPtr_easeOutSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669512);
			SA_iTween.NativeMethodInfoPtr_easeInOutSine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669513);
			SA_iTween.NativeMethodInfoPtr_easeInExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669514);
			SA_iTween.NativeMethodInfoPtr_easeOutExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669515);
			SA_iTween.NativeMethodInfoPtr_easeInOutExpo_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669516);
			SA_iTween.NativeMethodInfoPtr_easeInCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669517);
			SA_iTween.NativeMethodInfoPtr_easeOutCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669518);
			SA_iTween.NativeMethodInfoPtr_easeInOutCirc_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669519);
			SA_iTween.NativeMethodInfoPtr_easeInBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669520);
			SA_iTween.NativeMethodInfoPtr_easeOutBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669521);
			SA_iTween.NativeMethodInfoPtr_easeInOutBounce_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669522);
			SA_iTween.NativeMethodInfoPtr_easeInBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669523);
			SA_iTween.NativeMethodInfoPtr_easeOutBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669524);
			SA_iTween.NativeMethodInfoPtr_easeInOutBack_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669525);
			SA_iTween.NativeMethodInfoPtr_punch_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669526);
			SA_iTween.NativeMethodInfoPtr_easeInElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669527);
			SA_iTween.NativeMethodInfoPtr_easeOutElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669528);
			SA_iTween.NativeMethodInfoPtr_easeInOutElastic_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, 100669529);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000C46FC File Offset: 0x000C28FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213198, XrefRangeEnd = 213203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000C4734 File Offset: 0x000C2934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213203, XrefRangeEnd = 213252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCA RID: 11722 RVA: 0x000C4774 File Offset: 0x000C2974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213252, XrefRangeEnd = 213270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCB RID: 11723 RVA: 0x000C47AC File Offset: 0x000C29AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213270, XrefRangeEnd = 213319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCC RID: 11724 RVA: 0x000C47EC File Offset: 0x000C29EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213319, XrefRangeEnd = 213337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCD RID: 11725 RVA: 0x000C4824 File Offset: 0x000C2A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213337, XrefRangeEnd = 213407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCE RID: 11726 RVA: 0x000C486C File Offset: 0x000C2A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213407, XrefRangeEnd = 213433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DCF RID: 11727 RVA: 0x000C48C0 File Offset: 0x000C2AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213433, XrefRangeEnd = 213437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000C4908 File Offset: 0x000C2B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213437, XrefRangeEnd = 213463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000C495C File Offset: 0x000C2B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213463, XrefRangeEnd = 213467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000C49A4 File Offset: 0x000C2BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213467, XrefRangeEnd = 213491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000C49F8 File Offset: 0x000C2BF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213629, RefRangeEnd = 213634, XrefRangeStart = 213491, XrefRangeEnd = 213629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000C4A40 File Offset: 0x000C2C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213634, XrefRangeEnd = 213658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000C4A94 File Offset: 0x000C2C94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213721, RefRangeEnd = 213726, XrefRangeStart = 213658, XrefRangeEnd = 213721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000C4ADC File Offset: 0x000C2CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213726, XrefRangeEnd = 213756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD7 RID: 11735 RVA: 0x000C4B3C File Offset: 0x000C2D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213785, RefRangeEnd = 213786, XrefRangeStart = 213756, XrefRangeEnd = 213785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000C4B84 File Offset: 0x000C2D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213786, XrefRangeEnd = 213836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000C4BE4 File Offset: 0x000C2DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213836, XrefRangeEnd = 213858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDA RID: 11738 RVA: 0x000C4C2C File Offset: 0x000C2E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213858, XrefRangeEnd = 213887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDB RID: 11739 RVA: 0x000C4C84 File Offset: 0x000C2E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213887, XrefRangeEnd = 213897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDC RID: 11740 RVA: 0x000C4CCC File Offset: 0x000C2ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213897, XrefRangeEnd = 213921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDD RID: 11741 RVA: 0x000C4D20 File Offset: 0x000C2F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214008, RefRangeEnd = 214009, XrefRangeStart = 213921, XrefRangeEnd = 214008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDE RID: 11742 RVA: 0x000C4D68 File Offset: 0x000C2F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214009, XrefRangeEnd = 214033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DDF RID: 11743 RVA: 0x000C4DBC File Offset: 0x000C2FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214080, RefRangeEnd = 214081, XrefRangeStart = 214033, XrefRangeEnd = 214080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000C4E04 File Offset: 0x000C3004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214081, XrefRangeEnd = 214105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000C4E58 File Offset: 0x000C3058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214158, RefRangeEnd = 214162, XrefRangeStart = 214105, XrefRangeEnd = 214158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000C4EA0 File Offset: 0x000C30A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214162, XrefRangeEnd = 214186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000C4EF4 File Offset: 0x000C30F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214339, RefRangeEnd = 214340, XrefRangeStart = 214186, XrefRangeEnd = 214339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000C4F3C File Offset: 0x000C313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214340, XrefRangeEnd = 214376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000C4F90 File Offset: 0x000C3190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214376, XrefRangeEnd = 214390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000C4FD8 File Offset: 0x000C31D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214426, RefRangeEnd = 214427, XrefRangeStart = 214390, XrefRangeEnd = 214426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000C502C File Offset: 0x000C322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214427, XrefRangeEnd = 214441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE8 RID: 11752 RVA: 0x000C5074 File Offset: 0x000C3274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214441, XrefRangeEnd = 214465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000C50C8 File Offset: 0x000C32C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214517, RefRangeEnd = 214519, XrefRangeStart = 214465, XrefRangeEnd = 214517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DEA RID: 11754 RVA: 0x000C5110 File Offset: 0x000C3310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214519, XrefRangeEnd = 214543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DEB RID: 11755 RVA: 0x000C5164 File Offset: 0x000C3364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214608, RefRangeEnd = 214609, XrefRangeStart = 214543, XrefRangeEnd = 214608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DEC RID: 11756 RVA: 0x000C51AC File Offset: 0x000C33AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214609, XrefRangeEnd = 214645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DED RID: 11757 RVA: 0x000C5200 File Offset: 0x000C3400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214645, XrefRangeEnd = 214659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DEE RID: 11758 RVA: 0x000C5248 File Offset: 0x000C3448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214659, XrefRangeEnd = 214695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DEF RID: 11759 RVA: 0x000C529C File Offset: 0x000C349C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214695, XrefRangeEnd = 214709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000C52E4 File Offset: 0x000C34E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214709, XrefRangeEnd = 214733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000C5338 File Offset: 0x000C3538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214786, RefRangeEnd = 214787, XrefRangeStart = 214733, XrefRangeEnd = 214786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000C5380 File Offset: 0x000C3580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214787, XrefRangeEnd = 214811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000C53D4 File Offset: 0x000C35D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214892, RefRangeEnd = 214893, XrefRangeStart = 214811, XrefRangeEnd = 214892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000C541C File Offset: 0x000C361C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214893, XrefRangeEnd = 214929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000C5470 File Offset: 0x000C3670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214929, XrefRangeEnd = 214943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000C54B8 File Offset: 0x000C36B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214943, XrefRangeEnd = 214979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000C550C File Offset: 0x000C370C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214979, XrefRangeEnd = 214993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF8 RID: 11768 RVA: 0x000C5554 File Offset: 0x000C3754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214993, XrefRangeEnd = 215029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000C55A8 File Offset: 0x000C37A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215029, XrefRangeEnd = 215043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFA RID: 11770 RVA: 0x000C55F0 File Offset: 0x000C37F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215043, XrefRangeEnd = 215079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFB RID: 11771 RVA: 0x000C5644 File Offset: 0x000C3844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215079, XrefRangeEnd = 215093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFC RID: 11772 RVA: 0x000C568C File Offset: 0x000C388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215093, XrefRangeEnd = 215129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFD RID: 11773 RVA: 0x000C56E0 File Offset: 0x000C38E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215129, XrefRangeEnd = 215143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x000C5728 File Offset: 0x000C3928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215143, XrefRangeEnd = 215184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002DFF RID: 11775 RVA: 0x000C577C File Offset: 0x000C397C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215184, XrefRangeEnd = 215202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E00 RID: 11776 RVA: 0x000C57C4 File Offset: 0x000C39C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215202, XrefRangeEnd = 215243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E01 RID: 11777 RVA: 0x000C5818 File Offset: 0x000C3A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215243, XrefRangeEnd = 215261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E02 RID: 11778 RVA: 0x000C5860 File Offset: 0x000C3A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215261, XrefRangeEnd = 215302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E03 RID: 11779 RVA: 0x000C58B4 File Offset: 0x000C3AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215302, XrefRangeEnd = 215320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E04 RID: 11780 RVA: 0x000C58FC File Offset: 0x000C3AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215552, RefRangeEnd = 215553, XrefRangeStart = 215320, XrefRangeEnd = 215552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000C5930 File Offset: 0x000C3B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215553, XrefRangeEnd = 215565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRectTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000C5964 File Offset: 0x000C3B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215577, RefRangeEnd = 215578, XrefRangeStart = 215565, XrefRangeEnd = 215577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateColorTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000C5998 File Offset: 0x000C3B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215600, RefRangeEnd = 215601, XrefRangeStart = 215578, XrefRangeEnd = 215600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateVector3Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000C59CC File Offset: 0x000C3BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215623, RefRangeEnd = 215624, XrefRangeStart = 215601, XrefRangeEnd = 215623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateVector2Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000C5A00 File Offset: 0x000C3C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215644, RefRangeEnd = 215645, XrefRangeStart = 215624, XrefRangeEnd = 215644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateFloatTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000C5A34 File Offset: 0x000C3C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215743, RefRangeEnd = 215744, XrefRangeStart = 215645, XrefRangeEnd = 215743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateColorToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000C5A68 File Offset: 0x000C3C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215783, RefRangeEnd = 215784, XrefRangeStart = 215744, XrefRangeEnd = 215783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateAudioToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000C5A9C File Offset: 0x000C3C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215830, RefRangeEnd = 215831, XrefRangeStart = 215784, XrefRangeEnd = 215830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateStabTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000C5AD0 File Offset: 0x000C3CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215927, RefRangeEnd = 215928, XrefRangeStart = 215831, XrefRangeEnd = 215927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateLookToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000C5B04 File Offset: 0x000C3D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216010, RefRangeEnd = 216011, XrefRangeStart = 215928, XrefRangeEnd = 216010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveToPathTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000C5B38 File Offset: 0x000C3D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216081, RefRangeEnd = 216082, XrefRangeStart = 216011, XrefRangeEnd = 216081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000C5B6C File Offset: 0x000C3D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216132, RefRangeEnd = 216133, XrefRangeStart = 216082, XrefRangeEnd = 216132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMoveByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x000C5BA0 File Offset: 0x000C3DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216191, RefRangeEnd = 216192, XrefRangeStart = 216133, XrefRangeEnd = 216191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000C5BD4 File Offset: 0x000C3DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216228, RefRangeEnd = 216229, XrefRangeStart = 216192, XrefRangeEnd = 216228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000C5C08 File Offset: 0x000C3E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216265, RefRangeEnd = 216266, XrefRangeStart = 216229, XrefRangeEnd = 216265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateScaleAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000C5C3C File Offset: 0x000C3E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216331, RefRangeEnd = 216332, XrefRangeStart = 216266, XrefRangeEnd = 216331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000C5C70 File Offset: 0x000C3E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216368, RefRangeEnd = 216369, XrefRangeStart = 216332, XrefRangeEnd = 216368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000C5CA4 File Offset: 0x000C3EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216405, RefRangeEnd = 216406, XrefRangeStart = 216369, XrefRangeEnd = 216405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRotateByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000C5CD8 File Offset: 0x000C3ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216430, RefRangeEnd = 216431, XrefRangeStart = 216406, XrefRangeEnd = 216430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakePositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000C5D0C File Offset: 0x000C3F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216454, RefRangeEnd = 216455, XrefRangeStart = 216431, XrefRangeEnd = 216454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakeScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000C5D40 File Offset: 0x000C3F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216478, RefRangeEnd = 216479, XrefRangeStart = 216455, XrefRangeEnd = 216478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateShakeRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000C5D74 File Offset: 0x000C3F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216504, RefRangeEnd = 216505, XrefRangeStart = 216479, XrefRangeEnd = 216504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchPositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000C5DA8 File Offset: 0x000C3FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216529, RefRangeEnd = 216530, XrefRangeStart = 216505, XrefRangeEnd = 216529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000C5DDC File Offset: 0x000C3FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216554, RefRangeEnd = 216555, XrefRangeStart = 216530, XrefRangeEnd = 216554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratePunchScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000C5E10 File Offset: 0x000C4010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216555, XrefRangeEnd = 216579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRectTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000C5E44 File Offset: 0x000C4044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216579, XrefRangeEnd = 216591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000C5E78 File Offset: 0x000C4078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216591, XrefRangeEnd = 216602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVector3Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000C5EAC File Offset: 0x000C40AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216602, XrefRangeEnd = 216612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVector2Targets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000C5EE0 File Offset: 0x000C40E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216612, XrefRangeEnd = 216621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFloatTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000C5F14 File Offset: 0x000C4114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216621, XrefRangeEnd = 216667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000C5F48 File Offset: 0x000C4148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000C5F7C File Offset: 0x000C417C
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

		// Token: 0x06002E25 RID: 11813 RVA: 0x000C5FB0 File Offset: 0x000C41B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216667, XrefRangeEnd = 216708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveToPathTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000C5FE4 File Offset: 0x000C41E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216708, XrefRangeEnd = 216724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000C6018 File Offset: 0x000C4218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216724, XrefRangeEnd = 216742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMoveByTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000C604C File Offset: 0x000C424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyScaleToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000C6080 File Offset: 0x000C4280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLookToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000C60B4 File Offset: 0x000C42B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216742, XrefRangeEnd = 216763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotateToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000C60E8 File Offset: 0x000C42E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216763, XrefRangeEnd = 216775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotateAddTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000C611C File Offset: 0x000C431C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216775, XrefRangeEnd = 216803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakePositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000C6150 File Offset: 0x000C4350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakeScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x000C6184 File Offset: 0x000C4384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216803, XrefRangeEnd = 216817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShakeRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000C61B8 File Offset: 0x000C43B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216817, XrefRangeEnd = 216844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchPositionTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000C61EC File Offset: 0x000C43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216844, XrefRangeEnd = 216865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchRotationTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000C6220 File Offset: 0x000C4420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPunchScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000C6254 File Offset: 0x000C4454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216865, XrefRangeEnd = 216869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E33 RID: 11827 RVA: 0x000C6294 File Offset: 0x000C4494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216869, XrefRangeEnd = 216900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000C62C8 File Offset: 0x000C44C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216900, XrefRangeEnd = 216904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E35 RID: 11829 RVA: 0x000C6308 File Offset: 0x000C4508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216912, RefRangeEnd = 216914, XrefRangeStart = 216904, XrefRangeEnd = 216912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x000C633C File Offset: 0x000C453C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216933, RefRangeEnd = 216937, XrefRangeStart = 216914, XrefRangeEnd = 216933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000C6370 File Offset: 0x000C4570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216937, XrefRangeEnd = 216942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_TweenLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000C63A4 File Offset: 0x000C45A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216942, XrefRangeEnd = 216958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E39 RID: 11833 RVA: 0x000C6400 File Offset: 0x000C4600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3A RID: 11834 RVA: 0x000C645C File Offset: 0x000C465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3B RID: 11835 RVA: 0x000C64B8 File Offset: 0x000C46B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3C RID: 11836 RVA: 0x000C6514 File Offset: 0x000C4714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216958, XrefRangeEnd = 216967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3D RID: 11837 RVA: 0x000C655C File Offset: 0x000C475C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216967, XrefRangeEnd = 216997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3E RID: 11838 RVA: 0x000C65B0 File Offset: 0x000C47B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217109, RefRangeEnd = 217113, XrefRangeStart = 216997, XrefRangeEnd = 217109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E3F RID: 11839 RVA: 0x000C65F8 File Offset: 0x000C47F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217113, XrefRangeEnd = 217137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E40 RID: 11840 RVA: 0x000C664C File Offset: 0x000C484C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217176, RefRangeEnd = 217177, XrefRangeStart = 217137, XrefRangeEnd = 217176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E41 RID: 11841 RVA: 0x000C6694 File Offset: 0x000C4894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217177, XrefRangeEnd = 217207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E42 RID: 11842 RVA: 0x000C66F4 File Offset: 0x000C48F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217294, RefRangeEnd = 217295, XrefRangeStart = 217207, XrefRangeEnd = 217294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E43 RID: 11843 RVA: 0x000C673C File Offset: 0x000C493C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217295, XrefRangeEnd = 217319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E44 RID: 11844 RVA: 0x000C6790 File Offset: 0x000C4990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217390, RefRangeEnd = 217391, XrefRangeStart = 217319, XrefRangeEnd = 217390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E45 RID: 11845 RVA: 0x000C67D8 File Offset: 0x000C49D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217391, XrefRangeEnd = 217415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E46 RID: 11846 RVA: 0x000C682C File Offset: 0x000C4A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217529, RefRangeEnd = 217530, XrefRangeStart = 217415, XrefRangeEnd = 217529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E47 RID: 11847 RVA: 0x000C6874 File Offset: 0x000C4A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217530, XrefRangeEnd = 217554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E48 RID: 11848 RVA: 0x000C68C8 File Offset: 0x000C4AC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217604, RefRangeEnd = 217607, XrefRangeStart = 217554, XrefRangeEnd = 217604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E49 RID: 11849 RVA: 0x000C6910 File Offset: 0x000C4B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217607, XrefRangeEnd = 217631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4A RID: 11850 RVA: 0x000C6964 File Offset: 0x000C4B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217631, XrefRangeEnd = 217645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4B RID: 11851 RVA: 0x000C69A8 File Offset: 0x000C4BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217645, XrefRangeEnd = 217654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4C RID: 11852 RVA: 0x000C69EC File Offset: 0x000C4BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217654, XrefRangeEnd = 217668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4D RID: 11853 RVA: 0x000C6A2C File Offset: 0x000C4C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217668, XrefRangeEnd = 217675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4E RID: 11854 RVA: 0x000C6A84 File Offset: 0x000C4C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217675, XrefRangeEnd = 217681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E4F RID: 11855 RVA: 0x000C6ADC File Offset: 0x000C4CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217681, XrefRangeEnd = 217693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E50 RID: 11856 RVA: 0x000C6B34 File Offset: 0x000C4D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217693, XrefRangeEnd = 217704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E51 RID: 11857 RVA: 0x000C6B8C File Offset: 0x000C4D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217704, XrefRangeEnd = 217714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E52 RID: 11858 RVA: 0x000C6BDC File Offset: 0x000C4DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217714, XrefRangeEnd = 217724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E53 RID: 11859 RVA: 0x000C6C14 File Offset: 0x000C4E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217724, XrefRangeEnd = 217730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E54 RID: 11860 RVA: 0x000C6C58 File Offset: 0x000C4E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217730, XrefRangeEnd = 217745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E55 RID: 11861 RVA: 0x000C6C90 File Offset: 0x000C4E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217745, XrefRangeEnd = 217756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E56 RID: 11862 RVA: 0x000C6CD4 File Offset: 0x000C4ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217756, XrefRangeEnd = 217766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E57 RID: 11863 RVA: 0x000C6D0C File Offset: 0x000C4F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217766, XrefRangeEnd = 217772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E58 RID: 11864 RVA: 0x000C6D50 File Offset: 0x000C4F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217772, XrefRangeEnd = 217787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E59 RID: 11865 RVA: 0x000C6D88 File Offset: 0x000C4F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217787, XrefRangeEnd = 217798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5A RID: 11866 RVA: 0x000C6DCC File Offset: 0x000C4FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217798, XrefRangeEnd = 217808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5B RID: 11867 RVA: 0x000C6E04 File Offset: 0x000C5004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217808, XrefRangeEnd = 217814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5C RID: 11868 RVA: 0x000C6E48 File Offset: 0x000C5048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217814, XrefRangeEnd = 217829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5D RID: 11869 RVA: 0x000C6E80 File Offset: 0x000C5080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217829, XrefRangeEnd = 217840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5E RID: 11870 RVA: 0x000C6EC4 File Offset: 0x000C50C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217840, XrefRangeEnd = 217845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E5F RID: 11871 RVA: 0x000C6F14 File Offset: 0x000C5114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217845, XrefRangeEnd = 217855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E60 RID: 11872 RVA: 0x000C6F4C File Offset: 0x000C514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217855, XrefRangeEnd = 217861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E61 RID: 11873 RVA: 0x000C6F90 File Offset: 0x000C5190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217861, XrefRangeEnd = 217876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E62 RID: 11874 RVA: 0x000C6FC8 File Offset: 0x000C51C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217876, XrefRangeEnd = 217887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E63 RID: 11875 RVA: 0x000C700C File Offset: 0x000C520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217887, XrefRangeEnd = 217897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E64 RID: 11876 RVA: 0x000C7044 File Offset: 0x000C5244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217897, XrefRangeEnd = 217903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E65 RID: 11877 RVA: 0x000C7088 File Offset: 0x000C5288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217903, XrefRangeEnd = 217918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E66 RID: 11878 RVA: 0x000C70C0 File Offset: 0x000C52C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217918, XrefRangeEnd = 217929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E67 RID: 11879 RVA: 0x000C7104 File Offset: 0x000C5304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217929, XrefRangeEnd = 217939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E68 RID: 11880 RVA: 0x000C713C File Offset: 0x000C533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217939, XrefRangeEnd = 217945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E69 RID: 11881 RVA: 0x000C7180 File Offset: 0x000C5380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217945, XrefRangeEnd = 217960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E6A RID: 11882 RVA: 0x000C71B8 File Offset: 0x000C53B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217960, XrefRangeEnd = 217971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E6B RID: 11883 RVA: 0x000C71FC File Offset: 0x000C53FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217971, XrefRangeEnd = 217990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E6C RID: 11884 RVA: 0x000C7230 File Offset: 0x000C5430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217990, XrefRangeEnd = 218004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraFadeDestroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000C7258 File Offset: 0x000C5458
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

		// Token: 0x06002E6E RID: 11886 RVA: 0x000C7290 File Offset: 0x000C5490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218004, XrefRangeEnd = 218025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E6F RID: 11887 RVA: 0x000C72E4 File Offset: 0x000C54E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218025, XrefRangeEnd = 218050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E70 RID: 11888 RVA: 0x000C7328 File Offset: 0x000C5528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218050, XrefRangeEnd = 218075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CameraFadeAdd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000C735C File Offset: 0x000C555C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218082, RefRangeEnd = 218084, XrefRangeStart = 218075, XrefRangeEnd = 218082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E72 RID: 11890 RVA: 0x000C7394 File Offset: 0x000C5594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218108, RefRangeEnd = 218109, XrefRangeStart = 218084, XrefRangeEnd = 218108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E73 RID: 11891 RVA: 0x000C73D8 File Offset: 0x000C55D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218121, RefRangeEnd = 218122, XrefRangeStart = 218109, XrefRangeEnd = 218121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E74 RID: 11892 RVA: 0x000C7420 File Offset: 0x000C5620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218157, RefRangeEnd = 218158, XrefRangeStart = 218122, XrefRangeEnd = 218157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E75 RID: 11893 RVA: 0x000C7478 File Offset: 0x000C5678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218158, XrefRangeEnd = 218174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Resume_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000C74A0 File Offset: 0x000C56A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218174, XrefRangeEnd = 218198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E77 RID: 11895 RVA: 0x000C74D8 File Offset: 0x000C56D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218209, RefRangeEnd = 218211, XrefRangeStart = 218198, XrefRangeEnd = 218209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E78 RID: 11896 RVA: 0x000C7510 File Offset: 0x000C5710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218235, RefRangeEnd = 218236, XrefRangeStart = 218211, XrefRangeEnd = 218235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E79 RID: 11897 RVA: 0x000C7554 File Offset: 0x000C5754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218252, RefRangeEnd = 218253, XrefRangeStart = 218236, XrefRangeEnd = 218252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E7A RID: 11898 RVA: 0x000C759C File Offset: 0x000C579C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218292, RefRangeEnd = 218293, XrefRangeStart = 218253, XrefRangeEnd = 218292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E7B RID: 11899 RVA: 0x000C75F4 File Offset: 0x000C57F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218293, XrefRangeEnd = 218309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Pause_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000C761C File Offset: 0x000C581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218309, XrefRangeEnd = 218333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E7D RID: 11901 RVA: 0x000C7654 File Offset: 0x000C5854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218333, XrefRangeEnd = 218338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Count_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000C7684 File Offset: 0x000C5884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218338, XrefRangeEnd = 218360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E7F RID: 11903 RVA: 0x000C76C8 File Offset: 0x000C58C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218360, XrefRangeEnd = 218363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E80 RID: 11904 RVA: 0x000C770C File Offset: 0x000C590C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218363, XrefRangeEnd = 218374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E81 RID: 11905 RVA: 0x000C7760 File Offset: 0x000C5960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218374, XrefRangeEnd = 218397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Stop_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000C7788 File Offset: 0x000C5988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218397, XrefRangeEnd = 218421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E83 RID: 11907 RVA: 0x000C77C0 File Offset: 0x000C59C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218421, XrefRangeEnd = 218445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E84 RID: 11908 RVA: 0x000C77F8 File Offset: 0x000C59F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218452, RefRangeEnd = 218455, XrefRangeStart = 218445, XrefRangeEnd = 218452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E85 RID: 11909 RVA: 0x000C7830 File Offset: 0x000C5A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218479, RefRangeEnd = 218480, XrefRangeStart = 218455, XrefRangeEnd = 218479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E86 RID: 11910 RVA: 0x000C7874 File Offset: 0x000C5A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218492, RefRangeEnd = 218493, XrefRangeStart = 218480, XrefRangeEnd = 218492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E87 RID: 11911 RVA: 0x000C78BC File Offset: 0x000C5ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218501, RefRangeEnd = 218502, XrefRangeStart = 218493, XrefRangeEnd = 218501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x000C7904 File Offset: 0x000C5B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218537, RefRangeEnd = 218538, XrefRangeStart = 218502, XrefRangeEnd = 218537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E89 RID: 11913 RVA: 0x000C795C File Offset: 0x000C5B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218569, RefRangeEnd = 218570, XrefRangeStart = 218538, XrefRangeEnd = 218569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E8A RID: 11914 RVA: 0x000C79B4 File Offset: 0x000C5BB4
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 218577, RefRangeEnd = 218617, XrefRangeStart = 218570, XrefRangeEnd = 218577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E8B RID: 11915 RVA: 0x000C7A08 File Offset: 0x000C5C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E8C RID: 11916 RVA: 0x000C7A54 File Offset: 0x000C5C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218617, XrefRangeEnd = 218620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000C7A88 File Offset: 0x000C5C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218620, XrefRangeEnd = 218624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E8E RID: 11918 RVA: 0x000C7AC8 File Offset: 0x000C5CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218624, XrefRangeEnd = 218627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000C7AFC File Offset: 0x000C5CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218627, XrefRangeEnd = 218630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000C7B30 File Offset: 0x000C5D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218630, XrefRangeEnd = 218646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000C7B64 File Offset: 0x000C5D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218646, XrefRangeEnd = 218649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000C7B98 File Offset: 0x000C5D98
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

		// Token: 0x06002E93 RID: 11923 RVA: 0x000C7BCC File Offset: 0x000C5DCC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 218665, RefRangeEnd = 218677, XrefRangeStart = 218649, XrefRangeEnd = 218665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x000C7C24 File Offset: 0x000C5E24
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 218700, RefRangeEnd = 218712, XrefRangeStart = 218677, XrefRangeEnd = 218700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E95 RID: 11925 RVA: 0x000C7C7C File Offset: 0x000C5E7C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 218723, RefRangeEnd = 218733, XrefRangeStart = 218712, XrefRangeEnd = 218723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E96 RID: 11926 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 106681, RefRangeEnd = 106709, XrefRangeStart = 106681, XrefRangeEnd = 106709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E97 RID: 11927 RVA: 0x000C7D10 File Offset: 0x000C5F10
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 218757, RefRangeEnd = 218795, XrefRangeStart = 218733, XrefRangeEnd = 218757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E98 RID: 11928 RVA: 0x000C7D58 File Offset: 0x000C5F58
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 218873, RefRangeEnd = 218919, XrefRangeStart = 218795, XrefRangeEnd = 218873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E99 RID: 11929 RVA: 0x000C7D9C File Offset: 0x000C5F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218919, XrefRangeEnd = 218924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GenerateID_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x000C7DC8 File Offset: 0x000C5FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219169, RefRangeEnd = 219170, XrefRangeStart = 218924, XrefRangeEnd = 219169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RetrieveArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_RetrieveArgs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000C7DFC File Offset: 0x000C5FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219331, RefRangeEnd = 219332, XrefRangeStart = 219170, XrefRangeEnd = 219331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEasingFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_GetEasingFunction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000C7E30 File Offset: 0x000C6030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_UpdatePercentage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000C7E64 File Offset: 0x000C6064
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219363, RefRangeEnd = 219367, XrefRangeStart = 219332, XrefRangeEnd = 219363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002E9E RID: 11934 RVA: 0x000C7EA8 File Offset: 0x000C60A8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 219395, RefRangeEnd = 219409, XrefRangeStart = 219367, XrefRangeEnd = 219395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000C7EDC File Offset: 0x000C60DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219445, RefRangeEnd = 219446, XrefRangeStart = 219409, XrefRangeEnd = 219445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConflictCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ConflictCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000C7F10 File Offset: 0x000C6110
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

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000C7F44 File Offset: 0x000C6144
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

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000C7F78 File Offset: 0x000C6178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219446, XrefRangeEnd = 219449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween.NativeMethodInfoPtr_ResumeDelay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000C7FAC File Offset: 0x000C61AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000C8014 File Offset: 0x000C6214
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

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000C807C File Offset: 0x000C627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000C80E4 File Offset: 0x000C62E4
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

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000C814C File Offset: 0x000C634C
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

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000C81B4 File Offset: 0x000C63B4
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

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000C821C File Offset: 0x000C641C
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

		// Token: 0x06002EAA RID: 11946 RVA: 0x000C8284 File Offset: 0x000C6484
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

		// Token: 0x06002EAB RID: 11947 RVA: 0x000C82EC File Offset: 0x000C64EC
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

		// Token: 0x06002EAC RID: 11948 RVA: 0x000C8354 File Offset: 0x000C6554
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

		// Token: 0x06002EAD RID: 11949 RVA: 0x000C83BC File Offset: 0x000C65BC
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

		// Token: 0x06002EAE RID: 11950 RVA: 0x000C8424 File Offset: 0x000C6624
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

		// Token: 0x06002EAF RID: 11951 RVA: 0x000C848C File Offset: 0x000C668C
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

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000C84F4 File Offset: 0x000C66F4
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

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000C855C File Offset: 0x000C675C
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

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000C85C4 File Offset: 0x000C67C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000C862C File Offset: 0x000C682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000C8694 File Offset: 0x000C6894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000C86FC File Offset: 0x000C68FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000C8764 File Offset: 0x000C6964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000C87CC File Offset: 0x000C69CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x000C8834 File Offset: 0x000C6A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000C889C File Offset: 0x000C6A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EBA RID: 11962 RVA: 0x000C8904 File Offset: 0x000C6B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EBB RID: 11963 RVA: 0x000C896C File Offset: 0x000C6B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EBC RID: 11964 RVA: 0x000C89D4 File Offset: 0x000C6BD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 107451, RefRangeEnd = 107457, XrefRangeStart = 107451, XrefRangeEnd = 107457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EBD RID: 11965 RVA: 0x000C8A3C File Offset: 0x000C6C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EBE RID: 11966 RVA: 0x000C8AA4 File Offset: 0x000C6CA4
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

		// Token: 0x06002EBF RID: 11967 RVA: 0x000C8B0C File Offset: 0x000C6D0C
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

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000C8B74 File Offset: 0x000C6D74
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

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000C8BDC File Offset: 0x000C6DDC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 107463, RefRangeEnd = 107499, XrefRangeStart = 107463, XrefRangeEnd = 107499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000C8C34 File Offset: 0x000C6E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000C8C9C File Offset: 0x000C6E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000C8D04 File Offset: 0x000C6F04
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

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00011BE7 File Offset: 0x0000FDE7
		public static Hashtable Hash(params global::Il2CppSystem.Object[] args)
		{
			return SA_iTween.Hash(new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		public SA_iTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x000C8D6C File Offset: 0x000C6F6C
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00011BFD File Offset: 0x0000FDFD
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

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x000C8D94 File Offset: 0x000C6F94
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00011C0F File Offset: 0x0000FE0F
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x000C8DBC File Offset: 0x000C6FBC
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x00011C21 File Offset: 0x0000FE21
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x000C8DE4 File Offset: 0x000C6FE4
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x00011C40 File Offset: 0x0000FE40
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x000C8E0C File Offset: 0x000C700C
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00011C5F File Offset: 0x0000FE5F
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

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x000C8E34 File Offset: 0x000C7034
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00011C7E File Offset: 0x0000FE7E
		public unsafe EaseType easeType
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

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x000C8E5C File Offset: 0x000C705C
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00011C99 File Offset: 0x0000FE99
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x000C8E84 File Offset: 0x000C7084
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x00011CB4 File Offset: 0x0000FEB4
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

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x000C8EAC File Offset: 0x000C70AC
		// (set) Token: 0x06002ED8 RID: 11992 RVA: 0x00011CCF File Offset: 0x0000FECF
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

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x000C8ED4 File Offset: 0x000C70D4
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00011CEA File Offset: 0x0000FEEA
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

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000C8EFC File Offset: 0x000C70FC
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00011D05 File Offset: 0x0000FF05
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000C8F24 File Offset: 0x000C7124
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00011D20 File Offset: 0x0000FF20
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

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000C8F4C File Offset: 0x000C714C
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00011D3F File Offset: 0x0000FF3F
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x000C8F74 File Offset: 0x000C7174
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00011D5A File Offset: 0x0000FF5A
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

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000C8F9C File Offset: 0x000C719C
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00011D75 File Offset: 0x0000FF75
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

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000C8FC4 File Offset: 0x000C71C4
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00011D90 File Offset: 0x0000FF90
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x000C8FEC File Offset: 0x000C71EC
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00011DAB File Offset: 0x0000FFAB
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

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000C9014 File Offset: 0x000C7214
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00011DC6 File Offset: 0x0000FFC6
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

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x000C903C File Offset: 0x000C723C
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00011DE1 File Offset: 0x0000FFE1
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

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x000C9064 File Offset: 0x000C7264
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00011DFC File Offset: 0x0000FFFC
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

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000C908C File Offset: 0x000C728C
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x00011E17 File Offset: 0x00010017
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

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x000C90B4 File Offset: 0x000C72B4
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x00011E32 File Offset: 0x00010032
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

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000C90E4 File Offset: 0x000C72E4
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x00011E51 File Offset: 0x00010051
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

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x000C910C File Offset: 0x000C730C
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x00011E6C File Offset: 0x0001006C
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

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x000C913C File Offset: 0x000C733C
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00011E8B File Offset: 0x0001008B
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

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x000C916C File Offset: 0x000C736C
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00011EAA File Offset: 0x000100AA
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x000C919C File Offset: 0x000C739C
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00011EC9 File Offset: 0x000100C9
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

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x000C91CC File Offset: 0x000C73CC
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00011EE8 File Offset: 0x000100E8
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

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000C91FC File Offset: 0x000C73FC
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00011F07 File Offset: 0x00010107
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x000C922C File Offset: 0x000C742C
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00011F26 File Offset: 0x00010126
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

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x000C925C File Offset: 0x000C745C
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x00011F45 File Offset: 0x00010145
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

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x000C928C File Offset: 0x000C748C
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x00011F64 File Offset: 0x00010164
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

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x000C92BC File Offset: 0x000C74BC
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00011F83 File Offset: 0x00010183
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

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000C92E4 File Offset: 0x000C74E4
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x00011F9E File Offset: 0x0001019E
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

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000C930C File Offset: 0x000C750C
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00011FB9 File Offset: 0x000101B9
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

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000C9334 File Offset: 0x000C7534
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x00011FD4 File Offset: 0x000101D4
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

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000C935C File Offset: 0x000C755C
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00011FEF File Offset: 0x000101EF
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

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000C9384 File Offset: 0x000C7584
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x0001200A File Offset: 0x0001020A
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

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeFieldInfoPtr_tweens;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeFieldInfoPtr_cameraFade;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeFieldInfoPtr_easeType;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeFieldInfoPtr_loopType;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeFieldInfoPtr_isRunning;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeFieldInfoPtr_isPaused;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeFieldInfoPtr_runningTime;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeFieldInfoPtr_percentage;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeFieldInfoPtr_delayStarted;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeFieldInfoPtr_kinematic;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeFieldInfoPtr_isLocal;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeFieldInfoPtr_wasPaused;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeFieldInfoPtr_physics;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeFieldInfoPtr_tweenArguments;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeFieldInfoPtr_space;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeFieldInfoPtr_ease;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeFieldInfoPtr_apply;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeFieldInfoPtr_audioSource;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeFieldInfoPtr_vector3s;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeFieldInfoPtr_vector2s;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeFieldInfoPtr_rects;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeFieldInfoPtr_preUpdate;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeFieldInfoPtr_postUpdate;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeFieldInfoPtr_namedcolorvalue;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeFieldInfoPtr_lastRealTime;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeFieldInfoPtr_useRealTime;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeFieldInfoPtr_thisTransform;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_GameObject_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Single_Single_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeFrom_Public_Static_Void_Hashtable_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Single_Single_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeTo_Public_Static_Void_Hashtable_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_ValueTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_FadeFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_ColorFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeMethodInfoPtr_ColorTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeMethodInfoPtr_AudioFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeMethodInfoPtr_AudioTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_AudioClip_Single_0;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_Stab_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr_LookFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_LookTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeMethodInfoPtr_MoveFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr_MoveAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr_MoveBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_ScaleFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_ScaleAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr_ScaleBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr_RotateFrom_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeMethodInfoPtr_RotateAdd_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeMethodInfoPtr_RotateBy_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_ShakePosition_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_ShakeScale_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_ShakeRotation_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_PunchPosition_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_PunchRotation_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_PunchScale_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTargets_Private_Void_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRectTargets_Private_Void_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColorTargets_Private_Void_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr_GenerateVector3Targets_Private_Void_0;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_GenerateVector2Targets_Private_Void_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFloatTargets_Private_Void_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColorToTargets_Private_Void_0;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAudioToTargets_Private_Void_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStabTargets_Private_Void_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr_GenerateLookToTargets_Private_Void_0;

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveToPathTargets_Private_Void_0;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveToTargets_Private_Void_0;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMoveByTargets_Private_Void_0;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleToTargets_Private_Void_0;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleByTargets_Private_Void_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_GenerateScaleAddTargets_Private_Void_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateToTargets_Private_Void_0;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateAddTargets_Private_Void_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRotateByTargets_Private_Void_0;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakePositionTargets_Private_Void_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakeScaleTargets_Private_Void_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShakeRotationTargets_Private_Void_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchPositionTargets_Private_Void_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchRotationTargets_Private_Void_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePunchScaleTargets_Private_Void_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRectTargets_Private_Void_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTargets_Private_Void_0;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVector3Targets_Private_Void_0;

		// Token: 0x04002C3C RID: 11324
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVector2Targets_Private_Void_0;

		// Token: 0x04002C3D RID: 11325
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFloatTargets_Private_Void_0;

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorToTargets_Private_Void_0;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioToTargets_Private_Void_0;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStabTargets_Private_Void_0;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveToPathTargets_Private_Void_0;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveToTargets_Private_Void_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoveByTargets_Private_Void_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScaleToTargets_Private_Void_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLookToTargets_Private_Void_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotateToTargets_Private_Void_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotateAddTargets_Private_Void_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakePositionTargets_Private_Void_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakeScaleTargets_Private_Void_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShakeRotationTargets_Private_Void_0;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchPositionTargets_Private_Void_0;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchRotationTargets_Private_Void_0;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPunchScaleTargets_Private_Void_0;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeMethodInfoPtr_TweenDelay_Private_IEnumerator_0;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeMethodInfoPtr_TweenStart_Private_Void_0;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_TweenRestart_Private_IEnumerator_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_TweenUpdate_Private_Void_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_TweenComplete_Private_Void_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_TweenLoop_Private_Void_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_RectUpdate_Public_Static_Rect_Rect_Rect_Single_0;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_Vector3Update_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeMethodInfoPtr_Vector2Update_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeMethodInfoPtr_FloatUpdate_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeMethodInfoPtr_FadeUpdate_Public_Static_Void_GameObject_Single_Single_0;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeMethodInfoPtr_ColorUpdate_Public_Static_Void_GameObject_Color_Single_0;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeMethodInfoPtr_AudioUpdate_Public_Static_Void_GameObject_Single_Single_Single_0;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeMethodInfoPtr_RotateUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeMethodInfoPtr_ScaleUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeMethodInfoPtr_MoveUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_LookUpdate_Public_Static_Void_GameObject_Vector3_Single_0;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_CameraTexture_Public_Static_Texture2D_Color_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_GameObject_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeMethodInfoPtr_PutOnPath_Public_Static_Void_Transform_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_PointOnPath_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathGizmos_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppStructArray_1_Vector3_Color_0;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHandles_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeDepth_Public_Static_Void_Int32_0;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeDestroy_Public_Static_Void_0;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeSwap_Public_Static_Void_Texture2D_0;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_Int32_0;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_Texture2D_0;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeMethodInfoPtr_CameraFadeAdd_Public_Static_GameObject_0;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_0;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_0;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_0;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_String_0;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_0;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_0;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_0;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_String_0;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_0;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_String_0;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_GameObject_String_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_String_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_String_0;

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_0;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_Boolean_0;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_0;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_0;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeMethodInfoPtr_StopByName_Public_Static_Void_GameObject_String_Boolean_0;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_Hashtable_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Hashtable_0;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_DrawPathHelper_Private_Static_Void_Il2CppStructArray_1_Vector3_Color_String_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_PathControlPointGenerator_Private_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Private_Static_Vector3_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_Launch_Private_Static_Void_GameObject_Hashtable_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_CleanArgs_Private_Static_Hashtable_Hashtable_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_GenerateID_Private_Static_String_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveArgs_Private_Void_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_GetEasingFunction_Private_Void_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePercentage_Private_Void_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_CallBack_Private_Void_String_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_ConflictCheck_Private_Void_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_EnableKinematic_Private_Void_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_DisableKinematic_Private_Void_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_ResumeDelay_Private_Void_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_linear_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_clerp_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_spring_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuad_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_easeInCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeMethodInfoPtr_easeOutCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutCubic_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuart_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeMethodInfoPtr_easeInQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_easeOutQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuint_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_easeInSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_easeOutSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutSine_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_easeInExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_easeOutExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutExpo_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_easeInCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_easeOutCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutCirc_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_easeInBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_easeOutBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutBounce_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_easeInBack_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_easeOutBack_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutBack_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_punch_Private_Single_Single_Single_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_easeInElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_easeOutElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_easeInOutElastic_Private_Single_Single_Single_Single_0;

		// Token: 0x020003D4 RID: 980
		public sealed class EasingFunction : MulticastDelegate
		{
			// Token: 0x060038C4 RID: 14532 RVA: 0x000E6BF4 File Offset: 0x000E4DF4
			// Note: this type is marked as 'beforefieldinit'.
			static EasingFunction()
			{
				Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "EasingFunction");
				SA_iTween.EasingFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100670471);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100670472);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100670473);
				SA_iTween.EasingFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.EasingFunction>.NativeClassPtr, 100670474);
			}

			// Token: 0x060038C5 RID: 14533 RVA: 0x000E6C68 File Offset: 0x000E4E68
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

			// Token: 0x060038C6 RID: 14534 RVA: 0x000E6CC4 File Offset: 0x000E4EC4
			[CallerCount(80)]
			[CachedScanResults(RefRangeStart = 100967, RefRangeEnd = 101047, XrefRangeStart = 100967, XrefRangeEnd = 101047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038C7 RID: 14535 RVA: 0x000E6D2C File Offset: 0x000E4F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213136, XrefRangeEnd = 213144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038C8 RID: 14536 RVA: 0x000E6DBC File Offset: 0x000E4FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038C9 RID: 14537 RVA: 0x00015FDE File Offset: 0x000141DE
			public EasingFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060038CA RID: 14538 RVA: 0x00015FE7 File Offset: 0x000141E7
			public static implicit operator SA_iTween.EasingFunction(Func<float, float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<SA_iTween.EasingFunction>(A_0);
			}

			// Token: 0x060038CB RID: 14539 RVA: 0x00015FEF File Offset: 0x000141EF
			public static SA_iTween.EasingFunction operator +(SA_iTween.EasingFunction A_0, SA_iTween.EasingFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SA_iTween.EasingFunction>();
			}

			// Token: 0x060038CC RID: 14540 RVA: 0x00015FFD File Offset: 0x000141FD
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

			// Token: 0x04003321 RID: 13089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003322 RID: 13090
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_0;

			// Token: 0x04003323 RID: 13091
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_AsyncCallback_Object_0;

			// Token: 0x04003324 RID: 13092
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x020003D5 RID: 981
		public sealed class ApplyTween : MulticastDelegate
		{
			// Token: 0x060038CD RID: 14541 RVA: 0x000E6E0C File Offset: 0x000E500C
			// Note: this type is marked as 'beforefieldinit'.
			static ApplyTween()
			{
				Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "ApplyTween");
				SA_iTween.ApplyTween.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100670475);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100670476);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100670477);
				SA_iTween.ApplyTween.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.ApplyTween>.NativeClassPtr, 100670478);
			}

			// Token: 0x060038CE RID: 14542 RVA: 0x000E6E80 File Offset: 0x000E5080
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

			// Token: 0x060038CF RID: 14543 RVA: 0x000E6EDC File Offset: 0x000E50DC
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

			// Token: 0x060038D0 RID: 14544 RVA: 0x000E6F10 File Offset: 0x000E5110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038D1 RID: 14545 RVA: 0x000E6F74 File Offset: 0x000E5174
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

			// Token: 0x060038D2 RID: 14546 RVA: 0x0001600E File Offset: 0x0001420E
			public ApplyTween(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060038D3 RID: 14547 RVA: 0x00016017 File Offset: 0x00014217
			public static implicit operator SA_iTween.ApplyTween(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<SA_iTween.ApplyTween>(A_0);
			}

			// Token: 0x060038D4 RID: 14548 RVA: 0x0001601F File Offset: 0x0001421F
			public static SA_iTween.ApplyTween operator +(SA_iTween.ApplyTween A_0, SA_iTween.ApplyTween A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SA_iTween.ApplyTween>();
			}

			// Token: 0x060038D5 RID: 14549 RVA: 0x0001602D File Offset: 0x0001422D
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

			// Token: 0x04003325 RID: 13093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003326 RID: 13094
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003327 RID: 13095
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003328 RID: 13096
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003D6 RID: 982
		public enum LoopType
		{
			// Token: 0x0400332A RID: 13098
			none,
			// Token: 0x0400332B RID: 13099
			loop,
			// Token: 0x0400332C RID: 13100
			pingPong
		}

		// Token: 0x020003D7 RID: 983
		public enum NamedValueColor
		{
			// Token: 0x0400332E RID: 13102
			_Color,
			// Token: 0x0400332F RID: 13103
			_SpecColor,
			// Token: 0x04003330 RID: 13104
			_Emission,
			// Token: 0x04003331 RID: 13105
			_ReflectColor
		}

		// Token: 0x020003D8 RID: 984
		public static class Defaults : global::Il2CppSystem.Object
		{
			// Token: 0x060038D6 RID: 14550 RVA: 0x000E6FB8 File Offset: 0x000E51B8
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

			// Token: 0x060038D7 RID: 14551 RVA: 0x0001603E File Offset: 0x0001423E
			public Defaults(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x060038D8 RID: 14552 RVA: 0x000E7124 File Offset: 0x000E5324
			// (set) Token: 0x060038D9 RID: 14553 RVA: 0x00016047 File Offset: 0x00014247
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

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x060038DA RID: 14554 RVA: 0x000E7140 File Offset: 0x000E5340
			// (set) Token: 0x060038DB RID: 14555 RVA: 0x00016055 File Offset: 0x00014255
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

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x060038DC RID: 14556 RVA: 0x000E715C File Offset: 0x000E535C
			// (set) Token: 0x060038DD RID: 14557 RVA: 0x00016063 File Offset: 0x00014263
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

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x060038DE RID: 14558 RVA: 0x000E7178 File Offset: 0x000E5378
			// (set) Token: 0x060038DF RID: 14559 RVA: 0x00016071 File Offset: 0x00014271
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

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x060038E0 RID: 14560 RVA: 0x000E7194 File Offset: 0x000E5394
			// (set) Token: 0x060038E1 RID: 14561 RVA: 0x0001607F File Offset: 0x0001427F
			public unsafe static EaseType easeType
			{
				get
				{
					EaseType easeType;
					IL2CPP.il2cpp_field_static_get_value(SA_iTween.Defaults.NativeFieldInfoPtr_easeType, (void*)(&easeType));
					return easeType;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_iTween.Defaults.NativeFieldInfoPtr_easeType, (void*)(&value));
				}
			}

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x060038E2 RID: 14562 RVA: 0x000E71B0 File Offset: 0x000E53B0
			// (set) Token: 0x060038E3 RID: 14563 RVA: 0x0001608D File Offset: 0x0001428D
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

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x060038E4 RID: 14564 RVA: 0x000E71CC File Offset: 0x000E53CC
			// (set) Token: 0x060038E5 RID: 14565 RVA: 0x0001609B File Offset: 0x0001429B
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

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x060038E6 RID: 14566 RVA: 0x000E71E8 File Offset: 0x000E53E8
			// (set) Token: 0x060038E7 RID: 14567 RVA: 0x000160A9 File Offset: 0x000142A9
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

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x060038E8 RID: 14568 RVA: 0x000E7204 File Offset: 0x000E5404
			// (set) Token: 0x060038E9 RID: 14569 RVA: 0x000160B7 File Offset: 0x000142B7
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

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x060038EA RID: 14570 RVA: 0x000E7220 File Offset: 0x000E5420
			// (set) Token: 0x060038EB RID: 14571 RVA: 0x000160C5 File Offset: 0x000142C5
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

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x060038EC RID: 14572 RVA: 0x000E723C File Offset: 0x000E543C
			// (set) Token: 0x060038ED RID: 14573 RVA: 0x000160D3 File Offset: 0x000142D3
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

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x060038EE RID: 14574 RVA: 0x000E7258 File Offset: 0x000E5458
			// (set) Token: 0x060038EF RID: 14575 RVA: 0x000160E1 File Offset: 0x000142E1
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

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x060038F0 RID: 14576 RVA: 0x000E7274 File Offset: 0x000E5474
			// (set) Token: 0x060038F1 RID: 14577 RVA: 0x000160EF File Offset: 0x000142EF
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

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x060038F2 RID: 14578 RVA: 0x000E7290 File Offset: 0x000E5490
			// (set) Token: 0x060038F3 RID: 14579 RVA: 0x000160FD File Offset: 0x000142FD
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

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x060038F4 RID: 14580 RVA: 0x000E72AC File Offset: 0x000E54AC
			// (set) Token: 0x060038F5 RID: 14581 RVA: 0x0001610B File Offset: 0x0001430B
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

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x060038F6 RID: 14582 RVA: 0x000E72C8 File Offset: 0x000E54C8
			// (set) Token: 0x060038F7 RID: 14583 RVA: 0x00016119 File Offset: 0x00014319
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

			// Token: 0x04003332 RID: 13106
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04003333 RID: 13107
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04003334 RID: 13108
			private static readonly IntPtr NativeFieldInfoPtr_namedColorValue;

			// Token: 0x04003335 RID: 13109
			private static readonly IntPtr NativeFieldInfoPtr_loopType;

			// Token: 0x04003336 RID: 13110
			private static readonly IntPtr NativeFieldInfoPtr_easeType;

			// Token: 0x04003337 RID: 13111
			private static readonly IntPtr NativeFieldInfoPtr_lookSpeed;

			// Token: 0x04003338 RID: 13112
			private static readonly IntPtr NativeFieldInfoPtr_isLocal;

			// Token: 0x04003339 RID: 13113
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x0400333A RID: 13114
			private static readonly IntPtr NativeFieldInfoPtr_orientToPath;

			// Token: 0x0400333B RID: 13115
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400333C RID: 13116
			private static readonly IntPtr NativeFieldInfoPtr_updateTimePercentage;

			// Token: 0x0400333D RID: 13117
			private static readonly IntPtr NativeFieldInfoPtr_updateTime;

			// Token: 0x0400333E RID: 13118
			private static readonly IntPtr NativeFieldInfoPtr_cameraFadeDepth;

			// Token: 0x0400333F RID: 13119
			private static readonly IntPtr NativeFieldInfoPtr_lookAhead;

			// Token: 0x04003340 RID: 13120
			private static readonly IntPtr NativeFieldInfoPtr_useRealTime;

			// Token: 0x04003341 RID: 13121
			private static readonly IntPtr NativeFieldInfoPtr_up;
		}

		// Token: 0x020003D9 RID: 985
		public class CRSpline : global::Il2CppSystem.Object
		{
			// Token: 0x060038F8 RID: 14584 RVA: 0x000E72E4 File Offset: 0x000E54E4
			// Note: this type is marked as 'beforefieldinit'.
			static CRSpline()
			{
				Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "CRSpline");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr);
				SA_iTween.CRSpline.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, "pts");
				SA_iTween.CRSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, 100670480);
				SA_iTween.CRSpline.NativeMethodInfoPtr_Interp_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween.CRSpline>.NativeClassPtr, 100670481);
			}

			// Token: 0x060038F9 RID: 14585 RVA: 0x000E734C File Offset: 0x000E554C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 213169, RefRangeEnd = 213170, XrefRangeStart = 213144, XrefRangeEnd = 213169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038FA RID: 14586 RVA: 0x000E73A4 File Offset: 0x000E55A4
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 101067, RefRangeEnd = 101073, XrefRangeStart = 101067, XrefRangeEnd = 101073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060038FB RID: 14587 RVA: 0x00016127 File Offset: 0x00014327
			public CRSpline(params Vector3[] pts)
				: this(new Il2CppStructArray<Vector3>(pts))
			{
			}

			// Token: 0x060038FC RID: 14588 RVA: 0x00016135 File Offset: 0x00014335
			public CRSpline(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x060038FD RID: 14589 RVA: 0x000E73F0 File Offset: 0x000E55F0
			// (set) Token: 0x060038FE RID: 14590 RVA: 0x0001613E File Offset: 0x0001433E
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

			// Token: 0x04003342 RID: 13122
			private static readonly IntPtr NativeFieldInfoPtr_pts;

			// Token: 0x04003343 RID: 13123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;

			// Token: 0x04003344 RID: 13124
			private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Vector3_Single_0;
		}

		// Token: 0x020003DA RID: 986
		[ObfuscatedName("SA.Common.Animation.SA_iTween+<TweenDelay>d__149")]
		public sealed class _TweenDelay_d__149 : global::Il2CppSystem.Object
		{
			// Token: 0x060038FF RID: 14591 RVA: 0x000E7420 File Offset: 0x000E5620
			// Note: this type is marked as 'beforefieldinit'.
			static _TweenDelay_d__149()
			{
				Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<TweenDelay>d__149");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr);
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>1__state");
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>2__current");
				SA_iTween._TweenDelay_d__149.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, "<>4__this");
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670482);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670483);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670484);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670485);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670486);
				SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenDelay_d__149>.NativeClassPtr, 100670487);
			}

			// Token: 0x06003900 RID: 14592 RVA: 0x000E7500 File Offset: 0x000E5700
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

			// Token: 0x06003901 RID: 14593 RVA: 0x000E7548 File Offset: 0x000E5748
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

			// Token: 0x06003902 RID: 14594 RVA: 0x000E757C File Offset: 0x000E577C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213170, XrefRangeEnd = 213175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x06003903 RID: 14595 RVA: 0x000E75B8 File Offset: 0x000E57B8
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

			// Token: 0x06003904 RID: 14596 RVA: 0x000E75F8 File Offset: 0x000E57F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213175, XrefRangeEnd = 213180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenDelay_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x06003905 RID: 14597 RVA: 0x000E762C File Offset: 0x000E582C
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

			// Token: 0x06003906 RID: 14598 RVA: 0x0001615D File Offset: 0x0001435D
			public _TweenDelay_d__149(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x06003907 RID: 14599 RVA: 0x000E766C File Offset: 0x000E586C
			// (set) Token: 0x06003908 RID: 14600 RVA: 0x00016166 File Offset: 0x00014366
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

			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x06003909 RID: 14601 RVA: 0x000E7694 File Offset: 0x000E5894
			// (set) Token: 0x0600390A RID: 14602 RVA: 0x00016181 File Offset: 0x00014381
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

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x0600390B RID: 14603 RVA: 0x000E76C4 File Offset: 0x000E58C4
			// (set) Token: 0x0600390C RID: 14604 RVA: 0x000161A0 File Offset: 0x000143A0
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

			// Token: 0x04003345 RID: 13125
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003346 RID: 13126
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003347 RID: 13127
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003348 RID: 13128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003349 RID: 13129
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400334A RID: 13130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400334B RID: 13131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400334C RID: 13132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400334D RID: 13133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003DB RID: 987
		[ObfuscatedName("SA.Common.Animation.SA_iTween+<TweenRestart>d__151")]
		public sealed class _TweenRestart_d__151 : global::Il2CppSystem.Object
		{
			// Token: 0x0600390D RID: 14605 RVA: 0x000E76F4 File Offset: 0x000E58F4
			// Note: this type is marked as 'beforefieldinit'.
			static _TweenRestart_d__151()
			{
				Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<TweenRestart>d__151");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr);
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>1__state");
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>2__current");
				SA_iTween._TweenRestart_d__151.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, "<>4__this");
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670488);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670489);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670490);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670491);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670492);
				SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._TweenRestart_d__151>.NativeClassPtr, 100670493);
			}

			// Token: 0x0600390E RID: 14606 RVA: 0x000E77D4 File Offset: 0x000E59D4
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

			// Token: 0x0600390F RID: 14607 RVA: 0x000E781C File Offset: 0x000E5A1C
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

			// Token: 0x06003910 RID: 14608 RVA: 0x000E7850 File Offset: 0x000E5A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213180, XrefRangeEnd = 213185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06003911 RID: 14609 RVA: 0x000E788C File Offset: 0x000E5A8C
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

			// Token: 0x06003912 RID: 14610 RVA: 0x000E78CC File Offset: 0x000E5ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213185, XrefRangeEnd = 213190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._TweenRestart_d__151.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06003913 RID: 14611 RVA: 0x000E7900 File Offset: 0x000E5B00
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

			// Token: 0x06003914 RID: 14612 RVA: 0x000161BF File Offset: 0x000143BF
			public _TweenRestart_d__151(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06003915 RID: 14613 RVA: 0x000E7940 File Offset: 0x000E5B40
			// (set) Token: 0x06003916 RID: 14614 RVA: 0x000161C8 File Offset: 0x000143C8
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

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06003917 RID: 14615 RVA: 0x000E7968 File Offset: 0x000E5B68
			// (set) Token: 0x06003918 RID: 14616 RVA: 0x000161E3 File Offset: 0x000143E3
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

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06003919 RID: 14617 RVA: 0x000E7998 File Offset: 0x000E5B98
			// (set) Token: 0x0600391A RID: 14618 RVA: 0x00016202 File Offset: 0x00014402
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

			// Token: 0x0400334E RID: 13134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400334F RID: 13135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003350 RID: 13136
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003351 RID: 13137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003352 RID: 13138
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003353 RID: 13139
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003354 RID: 13140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003355 RID: 13141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003356 RID: 13142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003DC RID: 988
		[ObfuscatedName("SA.Common.Animation.SA_iTween+<Start>d__240")]
		public sealed class _Start_d__240 : global::Il2CppSystem.Object
		{
			// Token: 0x0600391B RID: 14619 RVA: 0x000E79C8 File Offset: 0x000E5BC8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__240()
			{
				Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_iTween>.NativeClassPtr, "<Start>d__240");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr);
				SA_iTween._Start_d__240.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>1__state");
				SA_iTween._Start_d__240.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>2__current");
				SA_iTween._Start_d__240.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, "<>4__this");
				SA_iTween._Start_d__240.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670494);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670495);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670496);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670497);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670498);
				SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iTween._Start_d__240>.NativeClassPtr, 100670499);
			}

			// Token: 0x0600391C RID: 14620 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
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

			// Token: 0x0600391D RID: 14621 RVA: 0x000E7AF0 File Offset: 0x000E5CF0
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

			// Token: 0x0600391E RID: 14622 RVA: 0x000E7B24 File Offset: 0x000E5D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213190, XrefRangeEnd = 213193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x0600391F RID: 14623 RVA: 0x000E7B60 File Offset: 0x000E5D60
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

			// Token: 0x06003920 RID: 14624 RVA: 0x000E7BA0 File Offset: 0x000E5DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213193, XrefRangeEnd = 213198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_iTween._Start_d__240.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06003921 RID: 14625 RVA: 0x000E7BD4 File Offset: 0x000E5DD4
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

			// Token: 0x06003922 RID: 14626 RVA: 0x00016221 File Offset: 0x00014421
			public _Start_d__240(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06003923 RID: 14627 RVA: 0x000E7C14 File Offset: 0x000E5E14
			// (set) Token: 0x06003924 RID: 14628 RVA: 0x0001622A File Offset: 0x0001442A
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

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06003925 RID: 14629 RVA: 0x000E7C3C File Offset: 0x000E5E3C
			// (set) Token: 0x06003926 RID: 14630 RVA: 0x00016245 File Offset: 0x00014445
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

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06003927 RID: 14631 RVA: 0x000E7C6C File Offset: 0x000E5E6C
			// (set) Token: 0x06003928 RID: 14632 RVA: 0x00016264 File Offset: 0x00014464
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

			// Token: 0x04003357 RID: 13143
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003358 RID: 13144
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003359 RID: 13145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400335A RID: 13146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400335B RID: 13147
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400335C RID: 13148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400335D RID: 13149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400335E RID: 13150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400335F RID: 13151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
