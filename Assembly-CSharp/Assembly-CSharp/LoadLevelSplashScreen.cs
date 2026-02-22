using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C5 RID: 197
public class LoadLevelSplashScreen : MonoBehaviour
{
	// Token: 0x06001793 RID: 6035 RVA: 0x00061398 File Offset: 0x0005F598
	// Note: this type is marked as 'beforefieldinit'.
	static LoadLevelSplashScreen()
	{
		Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LoadLevelSplashScreen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr);
		LoadLevelSplashScreen.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "_instance");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingScreenCanvasNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadingScreenCanvasNode");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadProgressBar");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadPercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadPercentageText");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_inGameNetworkDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_inGameNetworkDisconnect");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundBase");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundObjs");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundTitleTexts");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundDescTexts");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundTitleText");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_roundDescText");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadSequenceTotal");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadSequenceMultiplier");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_bShowNetworkDisconnectOnLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_bShowNetworkDisconnectOnLoadComplete");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_bIgnoreNextDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_bIgnoreNextDisconnect");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingSequenceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_loadingSequenceInfo");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_numLoadSequencesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_numLoadSequencesComplete");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_bMinimumLoadTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_bMinimumLoadTimeReached");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_bManualSceneActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_bManualSceneActivation");
		LoadLevelSplashScreen.NativeFieldInfoPtr_m_bLoadSequenceComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "m_bLoadSequenceComplete");
		LoadLevelSplashScreen.NativeMethodInfoPtr_get_instance_Public_Static_get_LoadLevelSplashScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665181);
		LoadLevelSplashScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665182);
		LoadLevelSplashScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665183);
		LoadLevelSplashScreen.NativeMethodInfoPtr_ResetProgressDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665184);
		LoadLevelSplashScreen.NativeMethodInfoPtr_BeginLoadingSequence_Public_Boolean_Int32_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665185);
		LoadLevelSplashScreen.NativeMethodInfoPtr_SetProgressDisplay_Public_Boolean_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665186);
		LoadLevelSplashScreen.NativeMethodInfoPtr_MarkLoadComplete_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665187);
		LoadLevelSplashScreen.NativeMethodInfoPtr_TriggerSceneActivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665188);
		LoadLevelSplashScreen.NativeMethodInfoPtr_ProcessMinimumLoadTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665189);
		LoadLevelSplashScreen.NativeMethodInfoPtr_ProcessLoadLevelAsync_Private_IEnumerator_AsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665190);
		LoadLevelSplashScreen.NativeMethodInfoPtr_LoadLevelAsync_Public_Boolean_String_Int32_Boolean_SequenceHandlerDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665191);
		LoadLevelSplashScreen.NativeMethodInfoPtr_GetNumLoadSequencesCompleted_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665192);
		LoadLevelSplashScreen.NativeMethodInfoPtr_SetRoundDisplay_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665193);
		LoadLevelSplashScreen.NativeMethodInfoPtr_IsLoadSequenceComplete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665194);
		LoadLevelSplashScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, 100665195);
	}

	// Token: 0x17000791 RID: 1937
	// (get) Token: 0x06001794 RID: 6036 RVA: 0x00061684 File Offset: 0x0005F884
	public unsafe static LoadLevelSplashScreen instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248494, XrefRangeEnd = 248498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_get_instance_Public_Static_get_LoadLevelSplashScreen_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr3) : null;
		}
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x000616B8 File Offset: 0x0005F8B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248498, XrefRangeEnd = 248523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x000616EC File Offset: 0x0005F8EC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x00061720 File Offset: 0x0005F920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248523, XrefRangeEnd = 248533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetProgressDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_ResetProgressDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00061754 File Offset: 0x0005F954
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 248554, RefRangeEnd = 248557, XrefRangeStart = 248533, XrefRangeEnd = 248554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BeginLoadingSequence(int numberOfLoads, bool bSupressLoadingScreen = false, float minimumLoadTime = 0f, bool bManualSceneActivation = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref numberOfLoads;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSupressLoadingScreen;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumLoadTime;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bManualSceneActivation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_BeginLoadingSequence_Public_Boolean_Int32_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x000617C8 File Offset: 0x0005F9C8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 248564, RefRangeEnd = 248566, XrefRangeStart = 248557, XrefRangeEnd = 248564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetProgressDisplay(float loadAmount, int sequenceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref loadAmount;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequenceIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_SetProgressDisplay_Public_Boolean_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00061820 File Offset: 0x0005FA20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 248568, RefRangeEnd = 248571, XrefRangeStart = 248566, XrefRangeEnd = 248568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MarkLoadComplete(int sequenceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sequenceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_MarkLoadComplete_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0006186C File Offset: 0x0005FA6C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 248571, RefRangeEnd = 248573, XrefRangeStart = 248571, XrefRangeEnd = 248571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerSceneActivation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_TriggerSceneActivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x000618A0 File Offset: 0x0005FAA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248573, XrefRangeEnd = 248577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessMinimumLoadTime(float minimumLoadTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minimumLoadTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_ProcessMinimumLoadTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x000618EC File Offset: 0x0005FAEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248577, XrefRangeEnd = 248581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessLoadLevelAsync(AsyncOperation asyncOp, int sequenceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOp);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequenceIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_ProcessLoadLevelAsync_Private_IEnumerator_AsyncOperation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x0006194C File Offset: 0x0005FB4C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 248592, RefRangeEnd = 248595, XrefRangeStart = 248581, XrefRangeEnd = 248592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadLevelAsync(string levelName, int sequenceIndex, bool bAdditive = false, LoadLevelSplashScreen.SequenceHandlerDelegate callBack = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(levelName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequenceIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAdditive;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_LoadLevelAsync_Public_Boolean_String_Int32_Boolean_SequenceHandlerDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000619C8 File Offset: 0x0005FBC8
	[CallerCount(0)]
	public unsafe uint GetNumLoadSequencesCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_GetNumLoadSequencesCompleted_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x00061A04 File Offset: 0x0005FC04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248595, XrefRangeEnd = 248608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRoundDisplay(bool bVisible, int roundNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_SetRoundDisplay_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x00061A50 File Offset: 0x0005FC50
	[CallerCount(0)]
	public unsafe bool IsLoadSequenceComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr_IsLoadSequenceComplete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x00061A8C File Offset: 0x0005FC8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248608, XrefRangeEnd = 248609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadLevelSplashScreen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x0000F2DF File Offset: 0x0000D4DF
	public LoadLevelSplashScreen(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00061AC8 File Offset: 0x0005FCC8
	// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
	public unsafe static LoadLevelSplashScreen _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LoadLevelSplashScreen.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LoadLevelSplashScreen.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00061AF0 File Offset: 0x0005FCF0
	// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0000F2FA File Offset: 0x0000D4FA
	public unsafe GameObject m_loadingScreenCanvasNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingScreenCanvasNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingScreenCanvasNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00061B20 File Offset: 0x0005FD20
	// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0000F319 File Offset: 0x0000D519
	public unsafe Image m_loadProgressBar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadProgressBar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadProgressBar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x060017AA RID: 6058 RVA: 0x00061B50 File Offset: 0x0005FD50
	// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000F338 File Offset: 0x0000D538
	public unsafe Text m_loadPercentageText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadPercentageText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadPercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x060017AC RID: 6060 RVA: 0x00061B80 File Offset: 0x0005FD80
	// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000F357 File Offset: 0x0000D557
	public unsafe GameObject m_inGameNetworkDisconnect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_inGameNetworkDisconnect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_inGameNetworkDisconnect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x060017AE RID: 6062 RVA: 0x00061BB0 File Offset: 0x0005FDB0
	// (set) Token: 0x060017AF RID: 6063 RVA: 0x0000F376 File Offset: 0x0000D576
	public unsafe GameObject m_roundBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00061BE0 File Offset: 0x0005FDE0
	// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0000F395 File Offset: 0x0000D595
	public unsafe Il2CppReferenceArray<GameObject> m_roundObjs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundObjs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00061C10 File Offset: 0x0005FE10
	// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
	public unsafe Il2CppStringArray m_roundTitleTexts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleTexts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00061C40 File Offset: 0x0005FE40
	// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000F3D3 File Offset: 0x0000D5D3
	public unsafe Il2CppStringArray m_roundDescTexts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescTexts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00061C70 File Offset: 0x0005FE70
	// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000F3F2 File Offset: 0x0000D5F2
	public unsafe Text m_roundTitleText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00061CA0 File Offset: 0x0005FEA0
	// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0000F411 File Offset: 0x0000D611
	public unsafe Text m_roundDescText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_roundDescText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000788 RID: 1928
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x00061CD0 File Offset: 0x0005FED0
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000F430 File Offset: 0x0000D630
	public unsafe int m_loadSequenceTotal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceTotal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceTotal)) = value;
		}
	}

	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x00061CF8 File Offset: 0x0005FEF8
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000F44B File Offset: 0x0000D64B
	public unsafe float m_loadSequenceMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadSequenceMultiplier)) = value;
		}
	}

	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x00061D20 File Offset: 0x0005FF20
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000F466 File Offset: 0x0000D666
	public unsafe bool m_bShowNetworkDisconnectOnLoadComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bShowNetworkDisconnectOnLoadComplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bShowNetworkDisconnectOnLoadComplete)) = value;
		}
	}

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00061D48 File Offset: 0x0005FF48
	// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000F481 File Offset: 0x0000D681
	public unsafe bool m_bIgnoreNextDisconnect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bIgnoreNextDisconnect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bIgnoreNextDisconnect)) = value;
		}
	}

	// Token: 0x1700078C RID: 1932
	// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00061D70 File Offset: 0x0005FF70
	// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000F49C File Offset: 0x0000D69C
	public unsafe Il2CppReferenceArray<LoadLevelSplashScreen.LoadInfo> m_loadingSequenceInfo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingSequenceInfo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoadLevelSplashScreen.LoadInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_loadingSequenceInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00061DA0 File Offset: 0x0005FFA0
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000F4BB File Offset: 0x0000D6BB
	public unsafe uint m_numLoadSequencesComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_numLoadSequencesComplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_numLoadSequencesComplete)) = value;
		}
	}

	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00061DC8 File Offset: 0x0005FFC8
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000F4D6 File Offset: 0x0000D6D6
	public unsafe bool m_bMinimumLoadTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bMinimumLoadTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bMinimumLoadTimeReached)) = value;
		}
	}

	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00061DF0 File Offset: 0x0005FFF0
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
	public unsafe bool m_bManualSceneActivation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bManualSceneActivation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bManualSceneActivation)) = value;
		}
	}

	// Token: 0x17000790 RID: 1936
	// (get) Token: 0x060017CA RID: 6090 RVA: 0x00061E18 File Offset: 0x00060018
	// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000F50C File Offset: 0x0000D70C
	public unsafe bool m_bLoadSequenceComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bLoadSequenceComplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.NativeFieldInfoPtr_m_bLoadSequenceComplete)) = value;
		}
	}

	// Token: 0x0400102E RID: 4142
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x0400102F RID: 4143
	private static readonly IntPtr NativeFieldInfoPtr_m_loadingScreenCanvasNode;

	// Token: 0x04001030 RID: 4144
	private static readonly IntPtr NativeFieldInfoPtr_m_loadProgressBar;

	// Token: 0x04001031 RID: 4145
	private static readonly IntPtr NativeFieldInfoPtr_m_loadPercentageText;

	// Token: 0x04001032 RID: 4146
	private static readonly IntPtr NativeFieldInfoPtr_m_inGameNetworkDisconnect;

	// Token: 0x04001033 RID: 4147
	private static readonly IntPtr NativeFieldInfoPtr_m_roundBase;

	// Token: 0x04001034 RID: 4148
	private static readonly IntPtr NativeFieldInfoPtr_m_roundObjs;

	// Token: 0x04001035 RID: 4149
	private static readonly IntPtr NativeFieldInfoPtr_m_roundTitleTexts;

	// Token: 0x04001036 RID: 4150
	private static readonly IntPtr NativeFieldInfoPtr_m_roundDescTexts;

	// Token: 0x04001037 RID: 4151
	private static readonly IntPtr NativeFieldInfoPtr_m_roundTitleText;

	// Token: 0x04001038 RID: 4152
	private static readonly IntPtr NativeFieldInfoPtr_m_roundDescText;

	// Token: 0x04001039 RID: 4153
	private static readonly IntPtr NativeFieldInfoPtr_m_loadSequenceTotal;

	// Token: 0x0400103A RID: 4154
	private static readonly IntPtr NativeFieldInfoPtr_m_loadSequenceMultiplier;

	// Token: 0x0400103B RID: 4155
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowNetworkDisconnectOnLoadComplete;

	// Token: 0x0400103C RID: 4156
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreNextDisconnect;

	// Token: 0x0400103D RID: 4157
	private static readonly IntPtr NativeFieldInfoPtr_m_loadingSequenceInfo;

	// Token: 0x0400103E RID: 4158
	private static readonly IntPtr NativeFieldInfoPtr_m_numLoadSequencesComplete;

	// Token: 0x0400103F RID: 4159
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinimumLoadTimeReached;

	// Token: 0x04001040 RID: 4160
	private static readonly IntPtr NativeFieldInfoPtr_m_bManualSceneActivation;

	// Token: 0x04001041 RID: 4161
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoadSequenceComplete;

	// Token: 0x04001042 RID: 4162
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_LoadLevelSplashScreen_0;

	// Token: 0x04001043 RID: 4163
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001044 RID: 4164
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04001045 RID: 4165
	private static readonly IntPtr NativeMethodInfoPtr_ResetProgressDisplay_Private_Void_0;

	// Token: 0x04001046 RID: 4166
	private static readonly IntPtr NativeMethodInfoPtr_BeginLoadingSequence_Public_Boolean_Int32_Boolean_Single_Boolean_0;

	// Token: 0x04001047 RID: 4167
	private static readonly IntPtr NativeMethodInfoPtr_SetProgressDisplay_Public_Boolean_Single_Int32_0;

	// Token: 0x04001048 RID: 4168
	private static readonly IntPtr NativeMethodInfoPtr_MarkLoadComplete_Public_Boolean_Int32_0;

	// Token: 0x04001049 RID: 4169
	private static readonly IntPtr NativeMethodInfoPtr_TriggerSceneActivation_Public_Void_0;

	// Token: 0x0400104A RID: 4170
	private static readonly IntPtr NativeMethodInfoPtr_ProcessMinimumLoadTime_Private_IEnumerator_Single_0;

	// Token: 0x0400104B RID: 4171
	private static readonly IntPtr NativeMethodInfoPtr_ProcessLoadLevelAsync_Private_IEnumerator_AsyncOperation_Int32_0;

	// Token: 0x0400104C RID: 4172
	private static readonly IntPtr NativeMethodInfoPtr_LoadLevelAsync_Public_Boolean_String_Int32_Boolean_SequenceHandlerDelegate_0;

	// Token: 0x0400104D RID: 4173
	private static readonly IntPtr NativeMethodInfoPtr_GetNumLoadSequencesCompleted_Public_UInt32_0;

	// Token: 0x0400104E RID: 4174
	private static readonly IntPtr NativeMethodInfoPtr_SetRoundDisplay_Public_Void_Boolean_Int32_0;

	// Token: 0x0400104F RID: 4175
	private static readonly IntPtr NativeMethodInfoPtr_IsLoadSequenceComplete_Public_Boolean_0;

	// Token: 0x04001050 RID: 4176
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001E0 RID: 480
	public sealed class SequenceHandlerDelegate : MulticastDelegate
	{
		// Token: 0x06002704 RID: 9988 RVA: 0x0008EBBC File Offset: 0x0008CDBC
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceHandlerDelegate()
		{
			Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "SequenceHandlerDelegate");
			LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr, 100666390);
			LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr, 100666391);
			LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr, 100666392);
			LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr, 100666393);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x0008EC30 File Offset: 0x0008CE30
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceHandlerDelegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLevelSplashScreen.SequenceHandlerDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x0008EC8C File Offset: 0x0008CE8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 84530, RefRangeEnd = 84546, XrefRangeStart = 84530, XrefRangeEnd = 84546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int sequenceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequenceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x0008ECCC File Offset: 0x0008CECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248468, XrefRangeEnd = 248472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int sequenceIndex, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequenceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0008ED3C File Offset: 0x0008CF3C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen.SequenceHandlerDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x0001813F File Offset: 0x0001633F
		public SequenceHandlerDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00018148 File Offset: 0x00016348
		public static implicit operator LoadLevelSplashScreen.SequenceHandlerDelegate(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<LoadLevelSplashScreen.SequenceHandlerDelegate>(A_0);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00018150 File Offset: 0x00016350
		public static LoadLevelSplashScreen.SequenceHandlerDelegate operator +(LoadLevelSplashScreen.SequenceHandlerDelegate A_0, LoadLevelSplashScreen.SequenceHandlerDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LoadLevelSplashScreen.SequenceHandlerDelegate>();
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0001815E File Offset: 0x0001635E
		public static LoadLevelSplashScreen.SequenceHandlerDelegate operator -(LoadLevelSplashScreen.SequenceHandlerDelegate A_0, LoadLevelSplashScreen.SequenceHandlerDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LoadLevelSplashScreen.SequenceHandlerDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001E1 RID: 481
	public sealed class LoadInfo : ValueType
	{
		// Token: 0x0600270D RID: 9997 RVA: 0x0008ED80 File Offset: 0x0008CF80
		// Note: this type is marked as 'beforefieldinit'.
		static LoadInfo()
		{
			Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "LoadInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr);
			LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_loadAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr, "loadAmount");
			LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_bLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr, "bLoadComplete");
			LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_m_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr, "m_callback");
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0001816F File Offset: 0x0001636F
		public LoadInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00018178 File Offset: 0x00016378
		public LoadInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLevelSplashScreen.LoadInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x0008EDE8 File Offset: 0x0008CFE8
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0001818A File Offset: 0x0001638A
		public unsafe float loadAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_loadAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_loadAmount)) = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0008EE10 File Offset: 0x0008D010
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x000181A5 File Offset: 0x000163A5
		public unsafe bool bLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_bLoadComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_bLoadComplete)) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0008EE38 File Offset: 0x0008D038
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x000181C0 File Offset: 0x000163C0
		public unsafe LoadLevelSplashScreen.SequenceHandlerDelegate m_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_m_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen.SequenceHandlerDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen.LoadInfo.NativeFieldInfoPtr_m_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_loadAmount;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_bLoadComplete;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_m_callback;
	}

	// Token: 0x020001E2 RID: 482
	[ObfuscatedName("LoadLevelSplashScreen+<ProcessMinimumLoadTime>d__31")]
	public sealed class _ProcessMinimumLoadTime_d__31 : global::Il2CppSystem.Object
	{
		// Token: 0x06002716 RID: 10006 RVA: 0x0008EE68 File Offset: 0x0008D068
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessMinimumLoadTime_d__31()
		{
			Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "<ProcessMinimumLoadTime>d__31");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "<>1__state");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "<>2__current");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "<>4__this");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr_minimumLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "minimumLoadTime");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "<accumulatedTime>5__2");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, "<previousTime>5__3");
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666394);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666395);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666396);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666397);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666398);
			LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr, 100666399);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0008EF84 File Offset: 0x0008D184
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessMinimumLoadTime_d__31(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0008EFCC File Offset: 0x0008D1CC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x0008F000 File Offset: 0x0008D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248472, XrefRangeEnd = 248480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0008F03C File Offset: 0x0008D23C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0008F07C File Offset: 0x0008D27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248480, XrefRangeEnd = 248485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x0008F0B0 File Offset: 0x0008D2B0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000181DF File Offset: 0x000163DF
		public _ProcessMinimumLoadTime_d__31(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x0008F0F0 File Offset: 0x0008D2F0
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x000181E8 File Offset: 0x000163E8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x0008F118 File Offset: 0x0008D318
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x00018203 File Offset: 0x00016403
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x0008F148 File Offset: 0x0008D348
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x00018222 File Offset: 0x00016422
		public unsafe LoadLevelSplashScreen __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x0008F178 File Offset: 0x0008D378
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00018241 File Offset: 0x00016441
		public unsafe float minimumLoadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr_minimumLoadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr_minimumLoadTime)) = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x0008F1A0 File Offset: 0x0008D3A0
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x0001825C File Offset: 0x0001645C
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x0008F1C8 File Offset: 0x0008D3C8
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x00018277 File Offset: 0x00016477
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessMinimumLoadTime_d__31.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_minimumLoadTime;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001E3 RID: 483
	[ObfuscatedName("LoadLevelSplashScreen+<ProcessLoadLevelAsync>d__32")]
	public sealed class _ProcessLoadLevelAsync_d__32 : global::Il2CppSystem.Object
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x0008F1F0 File Offset: 0x0008D3F0
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessLoadLevelAsync_d__32()
		{
			Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLevelSplashScreen>.NativeClassPtr, "<ProcessLoadLevelAsync>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, "<>1__state");
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, "<>2__current");
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, "<>4__this");
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_asyncOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, "asyncOp");
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_sequenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, "sequenceIndex");
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666400);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666401);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666402);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666403);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666404);
			LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr, 100666405);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0008F2F8 File Offset: 0x0008D4F8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessLoadLevelAsync_d__32(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0008F340 File Offset: 0x0008D540
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0008F374 File Offset: 0x0008D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248485, XrefRangeEnd = 248489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x0008F3B0 File Offset: 0x0008D5B0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0008F3F0 File Offset: 0x0008D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248489, XrefRangeEnd = 248494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x0008F424 File Offset: 0x0008D624
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00018292 File Offset: 0x00016492
		public _ProcessLoadLevelAsync_d__32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x0008F464 File Offset: 0x0008D664
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x0001829B File Offset: 0x0001649B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x0008F48C File Offset: 0x0008D68C
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x000182B6 File Offset: 0x000164B6
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x0008F4BC File Offset: 0x0008D6BC
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x000182D5 File Offset: 0x000164D5
		public unsafe LoadLevelSplashScreen __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x0008F4EC File Offset: 0x0008D6EC
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x000182F4 File Offset: 0x000164F4
		public unsafe AsyncOperation asyncOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_asyncOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_asyncOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x0008F51C File Offset: 0x0008D71C
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x00018313 File Offset: 0x00016513
		public unsafe int sequenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_sequenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLevelSplashScreen._ProcessLoadLevelAsync_d__32.NativeFieldInfoPtr_sequenceIndex)) = value;
			}
		}

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeFieldInfoPtr_asyncOp;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_sequenceIndex;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
