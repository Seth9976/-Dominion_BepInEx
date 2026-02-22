using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AB RID: 171
public class ScreenManager : MonoBehaviour
{
	// Token: 0x060013E6 RID: 5094 RVA: 0x000563F4 File Offset: 0x000545F4
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenManager()
	{
		Il2CppClassPointerStore<ScreenManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScreenManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr);
		ScreenManager.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "_instance");
		ScreenManager.NativeFieldInfoPtr_s_shortFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "s_shortFilename");
		ScreenManager.NativeFieldInfoPtr_s_fullFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "s_fullFilename");
		ScreenManager.NativeFieldInfoPtr_s_onStartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "s_onStartScreen");
		ScreenManager.NativeFieldInfoPtr_m_loadingScreenRootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_loadingScreenRootNode");
		ScreenManager.NativeFieldInfoPtr_m_startGameAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_startGameAudio");
		ScreenManager.NativeFieldInfoPtr_m_audioHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_audioHandler");
		ScreenManager.NativeFieldInfoPtr_m_delayBeforeSetInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_delayBeforeSetInactive");
		ScreenManager.NativeFieldInfoPtr_m_firstSceneToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_firstSceneToShow");
		ScreenManager.NativeFieldInfoPtr_m_animatorBooleanVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_animatorBooleanVariableName");
		ScreenManager.NativeFieldInfoPtr_m_ClosedStateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_ClosedStateName");
		ScreenManager.NativeFieldInfoPtr_m_OpenStateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_OpenStateName");
		ScreenManager.NativeFieldInfoPtr_m_FrontEndSceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_FrontEndSceneName");
		ScreenManager.NativeFieldInfoPtr_m_FrontEndBackgroundSceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_FrontEndBackgroundSceneName");
		ScreenManager.NativeFieldInfoPtr_m_InGameSceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_InGameSceneName");
		ScreenManager.NativeFieldInfoPtr_m_InGameBackgroundSceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_InGameBackgroundSceneName");
		ScreenManager.NativeFieldInfoPtr_m_AudioHandlerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_AudioHandlerPath");
		ScreenManager.NativeFieldInfoPtr_m_AudioStartGameObjectPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_AudioStartGameObjectPath");
		ScreenManager.NativeFieldInfoPtr_m_inputBlockerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_inputBlockerImage");
		ScreenManager.NativeFieldInfoPtr_m_inputBlockerRaycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_inputBlockerRaycaster");
		ScreenManager.NativeFieldInfoPtr_m_screenNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_screenNames");
		ScreenManager.NativeFieldInfoPtr_m_screenStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_screenStack");
		ScreenManager.NativeFieldInfoPtr_m_loadLevelSplashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_loadLevelSplashScreen");
		ScreenManager.NativeFieldInfoPtr_m_bCanTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_bCanTransition");
		ScreenManager.NativeFieldInfoPtr_m_OpenParameterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_OpenParameterId");
		ScreenManager.NativeFieldInfoPtr_m_lastSceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "m_lastSceneName");
		ScreenManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664885);
		ScreenManager.NativeMethodInfoPtr_ValidInstance_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664886);
		ScreenManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664887);
		ScreenManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664888);
		ScreenManager.NativeMethodInfoPtr_CanTransition_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664889);
		ScreenManager.NativeMethodInfoPtr_Register_Public_Void_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664890);
		ScreenManager.NativeMethodInfoPtr_UnRegister_Public_Void_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664891);
		ScreenManager.NativeMethodInfoPtr_GetScene_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664892);
		ScreenManager.NativeMethodInfoPtr_DisableStaticButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664893);
		ScreenManager.NativeMethodInfoPtr_EnableStaticButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664894);
		ScreenManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664895);
		ScreenManager.NativeMethodInfoPtr_FindFirstEnabledSelectable_Private_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664896);
		ScreenManager.NativeMethodInfoPtr_CheckLastScene_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664897);
		ScreenManager.NativeMethodInfoPtr_GetIsSceneInStack_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664898);
		ScreenManager.NativeMethodInfoPtr_PushScene_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664899);
		ScreenManager.NativeMethodInfoPtr_PopScene_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664900);
		ScreenManager.NativeMethodInfoPtr_PopScene2_Private_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664901);
		ScreenManager.NativeMethodInfoPtr_WaitForAnimationBeforeSwitchingScreen_Private_IEnumerator_ScreenSwitchDelayType_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664902);
		ScreenManager.NativeMethodInfoPtr_CheckForAudioHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664903);
		ScreenManager.NativeMethodInfoPtr_UI_PushScene_Private_Void_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664904);
		ScreenManager.NativeMethodInfoPtr_UI_PopScene_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664905);
		ScreenManager.NativeMethodInfoPtr_ClearStack_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664906);
		ScreenManager.NativeMethodInfoPtr_GoToScene_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664907);
		ScreenManager.NativeMethodInfoPtr_EnterScene_Private_Void_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664908);
		ScreenManager.NativeMethodInfoPtr_EnterScene2_Private_Void_RegisterMenu_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664909);
		ScreenManager.NativeMethodInfoPtr_EnablePanelDelayed_Private_IEnumerator_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664910);
		ScreenManager.NativeMethodInfoPtr_ExitScene_Private_Boolean_RegisterMenu_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664911);
		ScreenManager.NativeMethodInfoPtr_ExitScene2_Private_Boolean_RegisterMenu_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664912);
		ScreenManager.NativeMethodInfoPtr_DelayedClose_Private_IEnumerator_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664913);
		ScreenManager.NativeMethodInfoPtr_DelayedInteractable_Private_IEnumerator_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664914);
		ScreenManager.NativeMethodInfoPtr_DisablePanelDelayed_Private_IEnumerator_RegisterMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664915);
		ScreenManager.NativeMethodInfoPtr_SetSelected_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664916);
		ScreenManager.NativeMethodInfoPtr_LoadIntoGameScreen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664917);
		ScreenManager.NativeMethodInfoPtr_GoToFrontEndScreens_Public_Void_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664918);
		ScreenManager.NativeMethodInfoPtr_HandleFrontEndSequenceComplete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664919);
		ScreenManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, 100664920);
	}

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000568FC File Offset: 0x00054AFC
	public unsafe static ScreenManager instance
	{
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 245082, RefRangeEnd = 245162, XrefRangeStart = 245048, XrefRangeEnd = 245082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr3) : null;
		}
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00056930 File Offset: 0x00054B30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245170, RefRangeEnd = 245171, XrefRangeStart = 245162, XrefRangeEnd = 245170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ValidInstance()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_ValidInstance_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00056960 File Offset: 0x00054B60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245171, XrefRangeEnd = 245193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00056994 File Offset: 0x00054B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245193, XrefRangeEnd = 245212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x000569C8 File Offset: 0x00054BC8
	[CallerCount(0)]
	public unsafe bool CanTransition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_CanTransition_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00056A04 File Offset: 0x00054C04
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245232, RefRangeEnd = 245234, XrefRangeStart = 245212, XrefRangeEnd = 245232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Register(RegisterMenu rm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_Register_Public_Void_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00056A48 File Offset: 0x00054C48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245247, RefRangeEnd = 245248, XrefRangeStart = 245234, XrefRangeEnd = 245247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegister(RegisterMenu rm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_UnRegister_Public_Void_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00056A8C File Offset: 0x00054C8C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 245262, RefRangeEnd = 245274, XrefRangeStart = 245248, XrefRangeEnd = 245262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetScene(string sceneName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_GetScene_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00056ADC File Offset: 0x00054CDC
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 245283, RefRangeEnd = 245289, XrefRangeStart = 245274, XrefRangeEnd = 245283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableStaticButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_DisableStaticButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00056B10 File Offset: 0x00054D10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245289, XrefRangeEnd = 245298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableStaticButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_EnableStaticButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00056B44 File Offset: 0x00054D44
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00056B78 File Offset: 0x00054D78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245298, XrefRangeEnd = 245303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindFirstEnabledSelectable(GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_FindFirstEnabledSelectable_Private_Static_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00056BBC File Offset: 0x00054DBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245303, XrefRangeEnd = 245305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckLastScene(string newScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_CheckLastScene_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00056C00 File Offset: 0x00054E00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245330, RefRangeEnd = 245331, XrefRangeStart = 245305, XrefRangeEnd = 245330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsSceneInStack(string newScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_GetIsSceneInStack_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00056C50 File Offset: 0x00054E50
	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 245361, RefRangeEnd = 245381, XrefRangeStart = 245331, XrefRangeEnd = 245361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushScene(string scnName, string navName = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scnName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(navName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_PushScene_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00056CA4 File Offset: 0x00054EA4
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 245382, RefRangeEnd = 245387, XrefRangeStart = 245381, XrefRangeEnd = 245382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopScene(string navName = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(navName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_PopScene_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00056CE8 File Offset: 0x00054EE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245418, RefRangeEnd = 245419, XrefRangeStart = 245387, XrefRangeEnd = 245418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopScene2(bool bClearingStack, bool bSkipAnims = false, string navName = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bClearingStack;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSkipAnims;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(navName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_PopScene2_Private_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00056D48 File Offset: 0x00054F48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245423, RefRangeEnd = 245424, XrefRangeStart = 245419, XrefRangeEnd = 245423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator WaitForAnimationBeforeSwitchingScreen(ScreenManager.ScreenSwitchDelayType waitType, RegisterMenu nextScn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref waitType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextScn);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_WaitForAnimationBeforeSwitchingScreen_Private_IEnumerator_ScreenSwitchDelayType_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00056DA8 File Offset: 0x00054FA8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245435, RefRangeEnd = 245437, XrefRangeStart = 245424, XrefRangeEnd = 245435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForAudioHandler()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_CheckForAudioHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x00056DDC File Offset: 0x00054FDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245437, XrefRangeEnd = 245445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UI_PushScene(RegisterMenu newScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_UI_PushScene_Private_Void_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00056E20 File Offset: 0x00055020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245445, XrefRangeEnd = 245457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UI_PopScene(bool bClearingStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bClearingStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_UI_PopScene_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x00056E60 File Offset: 0x00055060
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245503, RefRangeEnd = 245505, XrefRangeStart = 245457, XrefRangeEnd = 245503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearStack(bool bSkipAnims)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSkipAnims;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_ClearStack_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00056EA0 File Offset: 0x000550A0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 245520, RefRangeEnd = 245524, XrefRangeStart = 245505, XrefRangeEnd = 245520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToScene(string scnName, bool bSkipAnims = true, string navName = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scnName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSkipAnims;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(navName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_GoToScene_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x00056F04 File Offset: 0x00055104
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245524, XrefRangeEnd = 245525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterScene(RegisterMenu newScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_EnterScene_Private_Void_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00056F48 File Offset: 0x00055148
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245543, RefRangeEnd = 245545, XrefRangeStart = 245525, XrefRangeEnd = 245543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterScene2(RegisterMenu newScene, bool bClearingStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newScene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bClearingStack;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_EnterScene2_Private_Void_RegisterMenu_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x00056F98 File Offset: 0x00055198
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245545, XrefRangeEnd = 245549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator EnablePanelDelayed(RegisterMenu anim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_EnablePanelDelayed_Private_IEnumerator_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x00056FE8 File Offset: 0x000551E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245549, XrefRangeEnd = 245550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExitScene(RegisterMenu oldScene, bool isNewSceneAPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldScene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNewSceneAPopup;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_ExitScene_Private_Boolean_RegisterMenu_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00057044 File Offset: 0x00055244
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 245555, RefRangeEnd = 245559, XrefRangeStart = 245550, XrefRangeEnd = 245555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExitScene2(RegisterMenu oldScene, bool isNewSceneAPopup, bool bClearingStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldScene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNewSceneAPopup;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bClearingStack;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_ExitScene2_Private_Boolean_RegisterMenu_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x000570B0 File Offset: 0x000552B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245559, XrefRangeEnd = 245563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayedClose(RegisterMenu closeScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(closeScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_DelayedClose_Private_IEnumerator_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00057100 File Offset: 0x00055300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245563, XrefRangeEnd = 245567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayedInteractable(RegisterMenu newMenu)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newMenu);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_DelayedInteractable_Private_IEnumerator_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00057150 File Offset: 0x00055350
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245571, RefRangeEnd = 245573, XrefRangeStart = 245567, XrefRangeEnd = 245571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DisablePanelDelayed(RegisterMenu anim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_DisablePanelDelayed_Private_IEnumerator_RegisterMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x000571A0 File Offset: 0x000553A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245573, XrefRangeEnd = 245579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelected(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_SetSelected_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x000571E4 File Offset: 0x000553E4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 245611, RefRangeEnd = 245617, XrefRangeStart = 245579, XrefRangeEnd = 245611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadIntoGameScreen(int roundNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref roundNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_LoadIntoGameScreen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00057224 File Offset: 0x00055424
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 245629, RefRangeEnd = 245636, XrefRangeStart = 245617, XrefRangeEnd = 245629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToFrontEndScreens(bool bSupressLoadingScreen = false, float minLoadTime = 0f, bool bManualSceneActivation = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSupressLoadingScreen;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minLoadTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bManualSceneActivation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_GoToFrontEndScreens_Public_Void_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00057280 File Offset: 0x00055480
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245636, XrefRangeEnd = 245643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleFrontEndSequenceComplete(int sequenceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sequenceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr_HandleFrontEndSequenceComplete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x000572C0 File Offset: 0x000554C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245643, XrefRangeEnd = 245665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x0000CFFD File Offset: 0x0000B1FD
	public ScreenManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x0600140C RID: 5132 RVA: 0x000572FC File Offset: 0x000554FC
	// (set) Token: 0x0600140D RID: 5133 RVA: 0x0000D006 File Offset: 0x0000B206
	public unsafe static ScreenManager _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenManager.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenManager.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x0600140E RID: 5134 RVA: 0x00057324 File Offset: 0x00055524
	// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000D018 File Offset: 0x0000B218
	public unsafe static string s_shortFilename
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenManager.NativeFieldInfoPtr_s_shortFilename, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenManager.NativeFieldInfoPtr_s_shortFilename, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x06001410 RID: 5136 RVA: 0x00057344 File Offset: 0x00055544
	// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000D02A File Offset: 0x0000B22A
	public unsafe static string s_fullFilename
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenManager.NativeFieldInfoPtr_s_fullFilename, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenManager.NativeFieldInfoPtr_s_fullFilename, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x06001412 RID: 5138 RVA: 0x00057364 File Offset: 0x00055564
	// (set) Token: 0x06001413 RID: 5139 RVA: 0x0000D03C File Offset: 0x0000B23C
	public unsafe static string s_onStartScreen
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenManager.NativeFieldInfoPtr_s_onStartScreen, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenManager.NativeFieldInfoPtr_s_onStartScreen, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x06001414 RID: 5140 RVA: 0x00057384 File Offset: 0x00055584
	// (set) Token: 0x06001415 RID: 5141 RVA: 0x0000D04E File Offset: 0x0000B24E
	public unsafe GameObject m_loadingScreenRootNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_loadingScreenRootNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_loadingScreenRootNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x06001416 RID: 5142 RVA: 0x000573B4 File Offset: 0x000555B4
	// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000D06D File Offset: 0x0000B26D
	public unsafe AudioSource m_startGameAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_startGameAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_startGameAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x06001418 RID: 5144 RVA: 0x000573E4 File Offset: 0x000555E4
	// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000D08C File Offset: 0x0000B28C
	public unsafe AudioSettingsHandler m_audioHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_audioHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettingsHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_audioHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x0600141A RID: 5146 RVA: 0x00057414 File Offset: 0x00055614
	// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000D0AB File Offset: 0x0000B2AB
	public unsafe float m_delayBeforeSetInactive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_delayBeforeSetInactive);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_delayBeforeSetInactive)) = value;
		}
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x0600141C RID: 5148 RVA: 0x0005743C File Offset: 0x0005563C
	// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
	public unsafe string m_firstSceneToShow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_firstSceneToShow);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_firstSceneToShow), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x0600141E RID: 5150 RVA: 0x00057464 File Offset: 0x00055664
	// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000D0E5 File Offset: 0x0000B2E5
	public unsafe string m_animatorBooleanVariableName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_animatorBooleanVariableName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_animatorBooleanVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x06001420 RID: 5152 RVA: 0x0005748C File Offset: 0x0005568C
	// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000D104 File Offset: 0x0000B304
	public unsafe string m_ClosedStateName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_ClosedStateName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_ClosedStateName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06001422 RID: 5154 RVA: 0x000574B4 File Offset: 0x000556B4
	// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000D123 File Offset: 0x0000B323
	public unsafe string m_OpenStateName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_OpenStateName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_OpenStateName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x06001424 RID: 5156 RVA: 0x000574DC File Offset: 0x000556DC
	// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000D142 File Offset: 0x0000B342
	public unsafe string m_FrontEndSceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_FrontEndSceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_FrontEndSceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x06001426 RID: 5158 RVA: 0x00057504 File Offset: 0x00055704
	// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000D161 File Offset: 0x0000B361
	public unsafe string m_FrontEndBackgroundSceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_FrontEndBackgroundSceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_FrontEndBackgroundSceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005752C File Offset: 0x0005572C
	// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000D180 File Offset: 0x0000B380
	public unsafe string m_InGameSceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_InGameSceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_InGameSceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x0600142A RID: 5162 RVA: 0x00057554 File Offset: 0x00055754
	// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000D19F File Offset: 0x0000B39F
	public unsafe string m_InGameBackgroundSceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_InGameBackgroundSceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_InGameBackgroundSceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x0600142C RID: 5164 RVA: 0x0005757C File Offset: 0x0005577C
	// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000D1BE File Offset: 0x0000B3BE
	public unsafe string m_AudioHandlerPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_AudioHandlerPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_AudioHandlerPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x0600142E RID: 5166 RVA: 0x000575A4 File Offset: 0x000557A4
	// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000D1DD File Offset: 0x0000B3DD
	public unsafe string m_AudioStartGameObjectPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_AudioStartGameObjectPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_AudioStartGameObjectPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x06001430 RID: 5168 RVA: 0x000575CC File Offset: 0x000557CC
	// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000D1FC File Offset: 0x0000B3FC
	public unsafe Image m_inputBlockerImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_inputBlockerImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_inputBlockerImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x06001432 RID: 5170 RVA: 0x000575FC File Offset: 0x000557FC
	// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000D21B File Offset: 0x0000B41B
	public unsafe GraphicRaycaster m_inputBlockerRaycaster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_inputBlockerRaycaster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_inputBlockerRaycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x06001434 RID: 5172 RVA: 0x0005762C File Offset: 0x0005582C
	// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000D23A File Offset: 0x0000B43A
	public unsafe Dictionary<string, RegisterMenu> m_screenNames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_screenNames);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, RegisterMenu>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_screenNames), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06001436 RID: 5174 RVA: 0x0005765C File Offset: 0x0005585C
	// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000D259 File Offset: 0x0000B459
	public unsafe Stack<RegisterMenu> m_screenStack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_screenStack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<RegisterMenu>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_screenStack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x06001438 RID: 5176 RVA: 0x0005768C File Offset: 0x0005588C
	// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000D278 File Offset: 0x0000B478
	public unsafe LoadLevelSplashScreen m_loadLevelSplashScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_loadLevelSplashScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_loadLevelSplashScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x0600143A RID: 5178 RVA: 0x000576BC File Offset: 0x000558BC
	// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000D297 File Offset: 0x0000B497
	public unsafe bool m_bCanTransition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_bCanTransition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_bCanTransition)) = value;
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x0600143C RID: 5180 RVA: 0x000576E4 File Offset: 0x000558E4
	// (set) Token: 0x0600143D RID: 5181 RVA: 0x0000D2B2 File Offset: 0x0000B4B2
	public unsafe int m_OpenParameterId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_OpenParameterId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_OpenParameterId)) = value;
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x0600143E RID: 5182 RVA: 0x0005770C File Offset: 0x0005590C
	// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000D2CD File Offset: 0x0000B4CD
	public unsafe string m_lastSceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_lastSceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager.NativeFieldInfoPtr_m_lastSceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000DE0 RID: 3552
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000DE1 RID: 3553
	private static readonly IntPtr NativeFieldInfoPtr_s_shortFilename;

	// Token: 0x04000DE2 RID: 3554
	private static readonly IntPtr NativeFieldInfoPtr_s_fullFilename;

	// Token: 0x04000DE3 RID: 3555
	private static readonly IntPtr NativeFieldInfoPtr_s_onStartScreen;

	// Token: 0x04000DE4 RID: 3556
	private static readonly IntPtr NativeFieldInfoPtr_m_loadingScreenRootNode;

	// Token: 0x04000DE5 RID: 3557
	private static readonly IntPtr NativeFieldInfoPtr_m_startGameAudio;

	// Token: 0x04000DE6 RID: 3558
	private static readonly IntPtr NativeFieldInfoPtr_m_audioHandler;

	// Token: 0x04000DE7 RID: 3559
	private static readonly IntPtr NativeFieldInfoPtr_m_delayBeforeSetInactive;

	// Token: 0x04000DE8 RID: 3560
	private static readonly IntPtr NativeFieldInfoPtr_m_firstSceneToShow;

	// Token: 0x04000DE9 RID: 3561
	private static readonly IntPtr NativeFieldInfoPtr_m_animatorBooleanVariableName;

	// Token: 0x04000DEA RID: 3562
	private static readonly IntPtr NativeFieldInfoPtr_m_ClosedStateName;

	// Token: 0x04000DEB RID: 3563
	private static readonly IntPtr NativeFieldInfoPtr_m_OpenStateName;

	// Token: 0x04000DEC RID: 3564
	private static readonly IntPtr NativeFieldInfoPtr_m_FrontEndSceneName;

	// Token: 0x04000DED RID: 3565
	private static readonly IntPtr NativeFieldInfoPtr_m_FrontEndBackgroundSceneName;

	// Token: 0x04000DEE RID: 3566
	private static readonly IntPtr NativeFieldInfoPtr_m_InGameSceneName;

	// Token: 0x04000DEF RID: 3567
	private static readonly IntPtr NativeFieldInfoPtr_m_InGameBackgroundSceneName;

	// Token: 0x04000DF0 RID: 3568
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioHandlerPath;

	// Token: 0x04000DF1 RID: 3569
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioStartGameObjectPath;

	// Token: 0x04000DF2 RID: 3570
	private static readonly IntPtr NativeFieldInfoPtr_m_inputBlockerImage;

	// Token: 0x04000DF3 RID: 3571
	private static readonly IntPtr NativeFieldInfoPtr_m_inputBlockerRaycaster;

	// Token: 0x04000DF4 RID: 3572
	private static readonly IntPtr NativeFieldInfoPtr_m_screenNames;

	// Token: 0x04000DF5 RID: 3573
	private static readonly IntPtr NativeFieldInfoPtr_m_screenStack;

	// Token: 0x04000DF6 RID: 3574
	private static readonly IntPtr NativeFieldInfoPtr_m_loadLevelSplashScreen;

	// Token: 0x04000DF7 RID: 3575
	private static readonly IntPtr NativeFieldInfoPtr_m_bCanTransition;

	// Token: 0x04000DF8 RID: 3576
	private static readonly IntPtr NativeFieldInfoPtr_m_OpenParameterId;

	// Token: 0x04000DF9 RID: 3577
	private static readonly IntPtr NativeFieldInfoPtr_m_lastSceneName;

	// Token: 0x04000DFA RID: 3578
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenManager_0;

	// Token: 0x04000DFB RID: 3579
	private static readonly IntPtr NativeMethodInfoPtr_ValidInstance_Public_Static_Boolean_0;

	// Token: 0x04000DFC RID: 3580
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DFD RID: 3581
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000DFE RID: 3582
	private static readonly IntPtr NativeMethodInfoPtr_CanTransition_Public_Boolean_0;

	// Token: 0x04000DFF RID: 3583
	private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_RegisterMenu_0;

	// Token: 0x04000E00 RID: 3584
	private static readonly IntPtr NativeMethodInfoPtr_UnRegister_Public_Void_RegisterMenu_0;

	// Token: 0x04000E01 RID: 3585
	private static readonly IntPtr NativeMethodInfoPtr_GetScene_Public_GameObject_String_0;

	// Token: 0x04000E02 RID: 3586
	private static readonly IntPtr NativeMethodInfoPtr_DisableStaticButtons_Private_Void_0;

	// Token: 0x04000E03 RID: 3587
	private static readonly IntPtr NativeMethodInfoPtr_EnableStaticButtons_Private_Void_0;

	// Token: 0x04000E04 RID: 3588
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000E05 RID: 3589
	private static readonly IntPtr NativeMethodInfoPtr_FindFirstEnabledSelectable_Private_Static_GameObject_GameObject_0;

	// Token: 0x04000E06 RID: 3590
	private static readonly IntPtr NativeMethodInfoPtr_CheckLastScene_Private_Void_String_0;

	// Token: 0x04000E07 RID: 3591
	private static readonly IntPtr NativeMethodInfoPtr_GetIsSceneInStack_Public_Boolean_String_0;

	// Token: 0x04000E08 RID: 3592
	private static readonly IntPtr NativeMethodInfoPtr_PushScene_Public_Void_String_String_0;

	// Token: 0x04000E09 RID: 3593
	private static readonly IntPtr NativeMethodInfoPtr_PopScene_Public_Void_String_0;

	// Token: 0x04000E0A RID: 3594
	private static readonly IntPtr NativeMethodInfoPtr_PopScene2_Private_Void_Boolean_Boolean_String_0;

	// Token: 0x04000E0B RID: 3595
	private static readonly IntPtr NativeMethodInfoPtr_WaitForAnimationBeforeSwitchingScreen_Private_IEnumerator_ScreenSwitchDelayType_RegisterMenu_0;

	// Token: 0x04000E0C RID: 3596
	private static readonly IntPtr NativeMethodInfoPtr_CheckForAudioHandler_Private_Void_0;

	// Token: 0x04000E0D RID: 3597
	private static readonly IntPtr NativeMethodInfoPtr_UI_PushScene_Private_Void_RegisterMenu_0;

	// Token: 0x04000E0E RID: 3598
	private static readonly IntPtr NativeMethodInfoPtr_UI_PopScene_Private_Void_Boolean_0;

	// Token: 0x04000E0F RID: 3599
	private static readonly IntPtr NativeMethodInfoPtr_ClearStack_Private_Void_Boolean_0;

	// Token: 0x04000E10 RID: 3600
	private static readonly IntPtr NativeMethodInfoPtr_GoToScene_Public_Void_String_Boolean_String_0;

	// Token: 0x04000E11 RID: 3601
	private static readonly IntPtr NativeMethodInfoPtr_EnterScene_Private_Void_RegisterMenu_0;

	// Token: 0x04000E12 RID: 3602
	private static readonly IntPtr NativeMethodInfoPtr_EnterScene2_Private_Void_RegisterMenu_Boolean_0;

	// Token: 0x04000E13 RID: 3603
	private static readonly IntPtr NativeMethodInfoPtr_EnablePanelDelayed_Private_IEnumerator_RegisterMenu_0;

	// Token: 0x04000E14 RID: 3604
	private static readonly IntPtr NativeMethodInfoPtr_ExitScene_Private_Boolean_RegisterMenu_Boolean_0;

	// Token: 0x04000E15 RID: 3605
	private static readonly IntPtr NativeMethodInfoPtr_ExitScene2_Private_Boolean_RegisterMenu_Boolean_Boolean_0;

	// Token: 0x04000E16 RID: 3606
	private static readonly IntPtr NativeMethodInfoPtr_DelayedClose_Private_IEnumerator_RegisterMenu_0;

	// Token: 0x04000E17 RID: 3607
	private static readonly IntPtr NativeMethodInfoPtr_DelayedInteractable_Private_IEnumerator_RegisterMenu_0;

	// Token: 0x04000E18 RID: 3608
	private static readonly IntPtr NativeMethodInfoPtr_DisablePanelDelayed_Private_IEnumerator_RegisterMenu_0;

	// Token: 0x04000E19 RID: 3609
	private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Private_Void_GameObject_0;

	// Token: 0x04000E1A RID: 3610
	private static readonly IntPtr NativeMethodInfoPtr_LoadIntoGameScreen_Public_Void_Int32_0;

	// Token: 0x04000E1B RID: 3611
	private static readonly IntPtr NativeMethodInfoPtr_GoToFrontEndScreens_Public_Void_Boolean_Single_Boolean_0;

	// Token: 0x04000E1C RID: 3612
	private static readonly IntPtr NativeMethodInfoPtr_HandleFrontEndSequenceComplete_Public_Void_Int32_0;

	// Token: 0x04000E1D RID: 3613
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001AF RID: 431
	public enum ScreenSwitchDelayType
	{
		// Token: 0x040019D9 RID: 6617
		WaitForAnimationBeforePush,
		// Token: 0x040019DA RID: 6618
		WaitForAnimationBeforePop
	}

	// Token: 0x020001B0 RID: 432
	[ObfuscatedName("ScreenManager+<WaitForAnimationBeforeSwitchingScreen>d__45")]
	public sealed class _WaitForAnimationBeforeSwitchingScreen_d__45 : global::Il2CppSystem.Object
	{
		// Token: 0x0600255F RID: 9567 RVA: 0x00089EFC File Offset: 0x000880FC
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitForAnimationBeforeSwitchingScreen_d__45()
		{
			Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "<WaitForAnimationBeforeSwitchingScreen>d__45");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, "<>1__state");
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, "<>2__current");
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, "<>4__this");
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_waitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, "waitType");
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_nextScn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, "nextScn");
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666246);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666247);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666248);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666249);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666250);
			ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr, 100666251);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0008A004 File Offset: 0x00088204
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WaitForAnimationBeforeSwitchingScreen_d__45(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0008A04C File Offset: 0x0008824C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0008A080 File Offset: 0x00088280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244991, XrefRangeEnd = 244996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0008A0BC File Offset: 0x000882BC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0008A0FC File Offset: 0x000882FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244996, XrefRangeEnd = 245001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0008A130 File Offset: 0x00088330
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000173AA File Offset: 0x000155AA
		public _WaitForAnimationBeforeSwitchingScreen_d__45(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0008A170 File Offset: 0x00088370
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x000173B3 File Offset: 0x000155B3
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0008A198 File Offset: 0x00088398
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x000173CE File Offset: 0x000155CE
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0008A1C8 File Offset: 0x000883C8
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x000173ED File Offset: 0x000155ED
		public unsafe ScreenManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0008A1F8 File Offset: 0x000883F8
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0001740C File Offset: 0x0001560C
		public unsafe ScreenManager.ScreenSwitchDelayType waitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_waitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_waitType)) = value;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0008A220 File Offset: 0x00088420
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x00017427 File Offset: 0x00015627
		public unsafe RegisterMenu nextScn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_nextScn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._WaitForAnimationBeforeSwitchingScreen_d__45.NativeFieldInfoPtr_nextScn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeFieldInfoPtr_waitType;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeFieldInfoPtr_nextScn;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001B1 RID: 433
	[ObfuscatedName("ScreenManager+<EnablePanelDelayed>d__53")]
	public sealed class _EnablePanelDelayed_d__53 : global::Il2CppSystem.Object
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x0008A250 File Offset: 0x00088450
		// Note: this type is marked as 'beforefieldinit'.
		static _EnablePanelDelayed_d__53()
		{
			Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "<EnablePanelDelayed>d__53");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr);
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "<>1__state");
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "<>2__current");
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "anim");
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "<>4__this");
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__openStateReached_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "<openStateReached>5__2");
			ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__wantToOpen_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, "<wantToOpen>5__3");
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666252);
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666253);
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666254);
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666255);
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666256);
			ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr, 100666257);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0008A36C File Offset: 0x0008856C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _EnablePanelDelayed_d__53(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager._EnablePanelDelayed_d__53>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0008A3B4 File Offset: 0x000885B4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0008A3E8 File Offset: 0x000885E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245001, XrefRangeEnd = 245011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x0008A424 File Offset: 0x00088624
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0008A464 File Offset: 0x00088664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245011, XrefRangeEnd = 245016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0008A498 File Offset: 0x00088698
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._EnablePanelDelayed_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00017446 File Offset: 0x00015646
		public _EnablePanelDelayed_d__53(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x0008A4D8 File Offset: 0x000886D8
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x0001744F File Offset: 0x0001564F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0008A500 File Offset: 0x00088700
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x0001746A File Offset: 0x0001566A
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0008A530 File Offset: 0x00088730
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x00017489 File Offset: 0x00015689
		public unsafe RegisterMenu anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x0008A560 File Offset: 0x00088760
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x000174A8 File Offset: 0x000156A8
		public unsafe ScreenManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x0008A590 File Offset: 0x00088790
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x000174C7 File Offset: 0x000156C7
		public unsafe bool _openStateReached_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__openStateReached_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__openStateReached_5__2)) = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x0008A5B8 File Offset: 0x000887B8
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x000174E2 File Offset: 0x000156E2
		public unsafe bool _wantToOpen_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__wantToOpen_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._EnablePanelDelayed_d__53.NativeFieldInfoPtr__wantToOpen_5__3)) = value;
			}
		}

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr__openStateReached_5__2;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr__wantToOpen_5__3;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001B2 RID: 434
	[ObfuscatedName("ScreenManager+<DelayedClose>d__56")]
	public sealed class _DelayedClose_d__56 : global::Il2CppSystem.Object
	{
		// Token: 0x06002585 RID: 9605 RVA: 0x0008A5E0 File Offset: 0x000887E0
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayedClose_d__56()
		{
			Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "<DelayedClose>d__56");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr);
			ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, "<>1__state");
			ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, "<>2__current");
			ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, "<>4__this");
			ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr_closeScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, "closeScene");
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666258);
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666259);
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666260);
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666261);
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666262);
			ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr, 100666263);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0008A6D4 File Offset: 0x000888D4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayedClose_d__56(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager._DelayedClose_d__56>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0008A71C File Offset: 0x0008891C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0008A750 File Offset: 0x00088950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245016, XrefRangeEnd = 245020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0008A78C File Offset: 0x0008898C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0008A7CC File Offset: 0x000889CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245020, XrefRangeEnd = 245025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x0008A800 File Offset: 0x00088A00
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedClose_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000174FD File Offset: 0x000156FD
		public _DelayedClose_d__56(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x0008A840 File Offset: 0x00088A40
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00017506 File Offset: 0x00015706
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x0008A868 File Offset: 0x00088A68
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00017521 File Offset: 0x00015721
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x0008A898 File Offset: 0x00088A98
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00017540 File Offset: 0x00015740
		public unsafe ScreenManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x0001755F File Offset: 0x0001575F
		public unsafe RegisterMenu closeScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr_closeScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedClose_d__56.NativeFieldInfoPtr_closeScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr_closeScene;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001B3 RID: 435
	[ObfuscatedName("ScreenManager+<DelayedInteractable>d__57")]
	public sealed class _DelayedInteractable_d__57 : global::Il2CppSystem.Object
	{
		// Token: 0x06002595 RID: 9621 RVA: 0x0008A8F8 File Offset: 0x00088AF8
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayedInteractable_d__57()
		{
			Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "<DelayedInteractable>d__57");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr);
			ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, "<>1__state");
			ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, "<>2__current");
			ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, "<>4__this");
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666264);
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666265);
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666266);
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666267);
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666268);
			ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr, 100666269);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0008A9D8 File Offset: 0x00088BD8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayedInteractable_d__57(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager._DelayedInteractable_d__57>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0008AA20 File Offset: 0x00088C20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0008AA54 File Offset: 0x00088C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245025, XrefRangeEnd = 245029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x0008AA90 File Offset: 0x00088C90
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0008AAD0 File Offset: 0x00088CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245029, XrefRangeEnd = 245034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0008AB04 File Offset: 0x00088D04
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DelayedInteractable_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0001757E File Offset: 0x0001577E
		public _DelayedInteractable_d__57(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x0008AB44 File Offset: 0x00088D44
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x00017587 File Offset: 0x00015787
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0008AB6C File Offset: 0x00088D6C
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x000175A2 File Offset: 0x000157A2
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x0008AB9C File Offset: 0x00088D9C
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x000175C1 File Offset: 0x000157C1
		public unsafe ScreenManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DelayedInteractable_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001B4 RID: 436
	[ObfuscatedName("ScreenManager+<DisablePanelDelayed>d__58")]
	public sealed class _DisablePanelDelayed_d__58 : global::Il2CppSystem.Object
	{
		// Token: 0x060025A3 RID: 9635 RVA: 0x0008ABCC File Offset: 0x00088DCC
		// Note: this type is marked as 'beforefieldinit'.
		static _DisablePanelDelayed_d__58()
		{
			Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenManager>.NativeClassPtr, "<DisablePanelDelayed>d__58");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr);
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "<>1__state");
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "<>2__current");
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "anim");
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "<>4__this");
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__closedStateReached_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "<closedStateReached>5__2");
			ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__wantToClose_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, "<wantToClose>5__3");
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666270);
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666271);
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666272);
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666273);
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666274);
			ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr, 100666275);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0008ACE8 File Offset: 0x00088EE8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DisablePanelDelayed_d__58(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenManager._DisablePanelDelayed_d__58>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0008AD30 File Offset: 0x00088F30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0008AD64 File Offset: 0x00088F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245034, XrefRangeEnd = 245043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0008ADA0 File Offset: 0x00088FA0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0008ADE0 File Offset: 0x00088FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245043, XrefRangeEnd = 245048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x0008AE14 File Offset: 0x00089014
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenManager._DisablePanelDelayed_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000175E0 File Offset: 0x000157E0
		public _DisablePanelDelayed_d__58(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x0008AE54 File Offset: 0x00089054
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x000175E9 File Offset: 0x000157E9
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x0008AE7C File Offset: 0x0008907C
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x00017604 File Offset: 0x00015804
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0008AEAC File Offset: 0x000890AC
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x00017623 File Offset: 0x00015823
		public unsafe RegisterMenu anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0008AEDC File Offset: 0x000890DC
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00017642 File Offset: 0x00015842
		public unsafe ScreenManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0008AF0C File Offset: 0x0008910C
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00017661 File Offset: 0x00015861
		public unsafe bool _closedStateReached_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__closedStateReached_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__closedStateReached_5__2)) = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0008AF34 File Offset: 0x00089134
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x0001767C File Offset: 0x0001587C
		public unsafe bool _wantToClose_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__wantToClose_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenManager._DisablePanelDelayed_d__58.NativeFieldInfoPtr__wantToClose_5__3)) = value;
			}
		}

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeFieldInfoPtr__closedStateReached_5__2;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr__wantToClose_5__3;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
