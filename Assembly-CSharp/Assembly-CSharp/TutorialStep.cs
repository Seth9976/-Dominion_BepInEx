using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000042 RID: 66
public class TutorialStep : Object
{
	// Token: 0x06000B48 RID: 2888 RVA: 0x0003B39C File Offset: 0x0003959C
	// Note: this type is marked as 'beforefieldinit'.
	static TutorialStep()
	{
		Il2CppClassPointerStore<TutorialStep>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialStep");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr);
		TutorialStep.NativeFieldInfoPtr_HideTutorialButtonCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "HideTutorialButtonCheck");
		TutorialStep.NativeFieldInfoPtr_ShowButtonUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "ShowButtonUndo");
		TutorialStep.NativeFieldInfoPtr_ShowButtonEndTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "ShowButtonEndTurn");
		TutorialStep.NativeFieldInfoPtr_DismissCurrentPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "DismissCurrentPopup");
		TutorialStep.NativeFieldInfoPtr_HidePopupButtonCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "HidePopupButtonCancel");
		TutorialStep.NativeFieldInfoPtr_HidePopupButtonCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "HidePopupButtonCheck");
		TutorialStep.NativeFieldInfoPtr_WaitForAIOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAIOptions");
		TutorialStep.NativeFieldInfoPtr_WaitForAIAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAIAction");
		TutorialStep.NativeFieldInfoPtr_WaitForAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAnimation");
		TutorialStep.NativeFieldInfoPtr_WaitForEndOfGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForEndOfGame");
		TutorialStep.NativeFieldInfoPtr_WaitForAvailableOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAvailableOptions");
		TutorialStep.NativeFieldInfoPtr_WaitForAnimationBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAnimationBegin");
		TutorialStep.NativeFieldInfoPtr_WaitForAnimationEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForAnimationEnd");
		TutorialStep.NativeFieldInfoPtr_PauseSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "PauseSimulation");
		TutorialStep.NativeFieldInfoPtr_MagnifyCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "MagnifyCard");
		TutorialStep.NativeFieldInfoPtr_UnmagnifyCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "UnmagnifyCard");
		TutorialStep.NativeFieldInfoPtr_WaitForMagnify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForMagnify");
		TutorialStep.NativeFieldInfoPtr_WaitForUnmagnify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "WaitForUnmagnify");
		TutorialStep.NativeFieldInfoPtr_m_StepType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_StepType");
		TutorialStep.NativeFieldInfoPtr_m_StepFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_StepFlags");
		TutorialStep.NativeFieldInfoPtr_m_SelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_SelectionHint");
		TutorialStep.NativeFieldInfoPtr_m_SelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_SelectionID");
		TutorialStep.NativeFieldInfoPtr_m_SelectionOptionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_SelectionOptionalData");
		TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_SelectionInstanceType");
		TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_SelectionInstanceName");
		TutorialStep.NativeFieldInfoPtr_m_TutorialText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_TutorialText");
		TutorialStep.NativeFieldInfoPtr_m_TutorialPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_TutorialPrompt");
		TutorialStep.NativeFieldInfoPtr_m_TutorialPanelLayoutIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_TutorialPanelLayoutIndex");
		TutorialStep.NativeFieldInfoPtr_m_AutoAnimateRegionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_AutoAnimateRegionMap");
		TutorialStep.NativeFieldInfoPtr_m_Callouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, "m_Callouts");
		TutorialStep.NativeMethodInfoPtr__ctor_Public_Void_TutorialStepType_UInt32_UInt16_UInt16_UInt32_Int32_String_String_String_Int32_Int32_Il2CppReferenceArray_1_TutorialCallout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, 100664086);
		TutorialStep.NativeMethodInfoPtr_IsWaitForAIOptions_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, 100664087);
		TutorialStep.NativeMethodInfoPtr_IsWaitForAIAction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, 100664088);
		TutorialStep.NativeMethodInfoPtr_GetSelectionID_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr, 100664089);
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0003B674 File Offset: 0x00039874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237506, XrefRangeEnd = 237507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialStep(TutorialStepType step_type, uint step_flags, ushort selection_hint, ushort selection_id, uint selectionOptionalData, int selection_instance_type, string selection_instance_name, string tutorialText, string tutorialPrompt, int tutorialPanelLayoutIndex, int autoAnimateRegionMap, Il2CppReferenceArray<TutorialCallout> callouts = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialStep>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref step_type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref step_flags;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selection_hint;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selection_id;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionOptionalData;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selection_instance_type;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(selection_instance_name);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tutorialText);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tutorialPrompt);
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialPanelLayoutIndex;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoAnimateRegionMap;
		ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callouts);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialStep.NativeMethodInfoPtr__ctor_Public_Void_TutorialStepType_UInt32_UInt16_UInt16_UInt32_Int32_String_String_String_Int32_Int32_Il2CppReferenceArray_1_TutorialCallout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003B770 File Offset: 0x00039970
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237507, RefRangeEnd = 237509, XrefRangeStart = 237507, XrefRangeEnd = 237507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWaitForAIOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialStep.NativeMethodInfoPtr_IsWaitForAIOptions_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0003B7AC File Offset: 0x000399AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237509, RefRangeEnd = 237510, XrefRangeStart = 237509, XrefRangeEnd = 237509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWaitForAIAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialStep.NativeMethodInfoPtr_IsWaitForAIAction_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0003B7E8 File Offset: 0x000399E8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237510, RefRangeEnd = 237512, XrefRangeStart = 237510, XrefRangeEnd = 237510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetSelectionID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialStep.NativeMethodInfoPtr_GetSelectionID_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00008E91 File Offset: 0x00007091
	public TutorialStep(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0003B824 File Offset: 0x00039A24
	// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00008E9A File Offset: 0x0000709A
	public unsafe static uint HideTutorialButtonCheck
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_HideTutorialButtonCheck, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_HideTutorialButtonCheck, (void*)(&value));
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0003B840 File Offset: 0x00039A40
	// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00008EA8 File Offset: 0x000070A8
	public unsafe static uint ShowButtonUndo
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_ShowButtonUndo, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_ShowButtonUndo, (void*)(&value));
		}
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0003B85C File Offset: 0x00039A5C
	// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00008EB6 File Offset: 0x000070B6
	public unsafe static uint ShowButtonEndTurn
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_ShowButtonEndTurn, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_ShowButtonEndTurn, (void*)(&value));
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0003B878 File Offset: 0x00039A78
	// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00008EC4 File Offset: 0x000070C4
	public unsafe static uint DismissCurrentPopup
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_DismissCurrentPopup, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_DismissCurrentPopup, (void*)(&value));
		}
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003B894 File Offset: 0x00039A94
	// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00008ED2 File Offset: 0x000070D2
	public unsafe static uint HidePopupButtonCancel
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_HidePopupButtonCancel, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_HidePopupButtonCancel, (void*)(&value));
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0003B8B0 File Offset: 0x00039AB0
	// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00008EE0 File Offset: 0x000070E0
	public unsafe static uint HidePopupButtonCheck
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_HidePopupButtonCheck, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_HidePopupButtonCheck, (void*)(&value));
		}
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0003B8CC File Offset: 0x00039ACC
	// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00008EEE File Offset: 0x000070EE
	public unsafe static uint WaitForAIOptions
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAIOptions, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAIOptions, (void*)(&value));
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0003B8E8 File Offset: 0x00039AE8
	// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00008EFC File Offset: 0x000070FC
	public unsafe static uint WaitForAIAction
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAIAction, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAIAction, (void*)(&value));
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0003B904 File Offset: 0x00039B04
	// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00008F0A File Offset: 0x0000710A
	public unsafe static uint WaitForAnimation
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimation, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimation, (void*)(&value));
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0003B920 File Offset: 0x00039B20
	// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00008F18 File Offset: 0x00007118
	public unsafe static uint WaitForEndOfGame
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForEndOfGame, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForEndOfGame, (void*)(&value));
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003B93C File Offset: 0x00039B3C
	// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00008F26 File Offset: 0x00007126
	public unsafe static uint WaitForAvailableOptions
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAvailableOptions, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAvailableOptions, (void*)(&value));
		}
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0003B958 File Offset: 0x00039B58
	// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00008F34 File Offset: 0x00007134
	public unsafe static uint WaitForAnimationBegin
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimationBegin, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimationBegin, (void*)(&value));
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0003B974 File Offset: 0x00039B74
	// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00008F42 File Offset: 0x00007142
	public unsafe static uint WaitForAnimationEnd
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimationEnd, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForAnimationEnd, (void*)(&value));
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003B990 File Offset: 0x00039B90
	// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00008F50 File Offset: 0x00007150
	public unsafe static uint PauseSimulation
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_PauseSimulation, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_PauseSimulation, (void*)(&value));
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0003B9AC File Offset: 0x00039BAC
	// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00008F5E File Offset: 0x0000715E
	public unsafe static uint MagnifyCard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_MagnifyCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_MagnifyCard, (void*)(&value));
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0003B9C8 File Offset: 0x00039BC8
	// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00008F6C File Offset: 0x0000716C
	public unsafe static uint UnmagnifyCard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_UnmagnifyCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_UnmagnifyCard, (void*)(&value));
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0003B9E4 File Offset: 0x00039BE4
	// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00008F7A File Offset: 0x0000717A
	public unsafe static uint WaitForMagnify
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForMagnify, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForMagnify, (void*)(&value));
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0003BA00 File Offset: 0x00039C00
	// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00008F88 File Offset: 0x00007188
	public unsafe static uint WaitForUnmagnify
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(TutorialStep.NativeFieldInfoPtr_WaitForUnmagnify, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialStep.NativeFieldInfoPtr_WaitForUnmagnify, (void*)(&value));
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0003BA1C File Offset: 0x00039C1C
	// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00008F96 File Offset: 0x00007196
	public unsafe TutorialStepType m_StepType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_StepType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_StepType)) = value;
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0003BA44 File Offset: 0x00039C44
	// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00008FB1 File Offset: 0x000071B1
	public unsafe uint m_StepFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_StepFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_StepFlags)) = value;
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0003BA6C File Offset: 0x00039C6C
	// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00008FCC File Offset: 0x000071CC
	public unsafe ushort m_SelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionHint)) = value;
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0003BA94 File Offset: 0x00039C94
	// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00008FE7 File Offset: 0x000071E7
	public unsafe ushort m_SelectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionID)) = value;
		}
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0003BABC File Offset: 0x00039CBC
	// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00009002 File Offset: 0x00007202
	public unsafe uint m_SelectionOptionalData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionOptionalData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionOptionalData)) = value;
		}
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0003BAE4 File Offset: 0x00039CE4
	// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0000901D File Offset: 0x0000721D
	public unsafe int m_SelectionInstanceType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceType)) = value;
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0003BB0C File Offset: 0x00039D0C
	// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00009038 File Offset: 0x00007238
	public unsafe string m_SelectionInstanceName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_SelectionInstanceName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0003BB34 File Offset: 0x00039D34
	// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00009057 File Offset: 0x00007257
	public unsafe string m_TutorialText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialText);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialText), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0003BB5C File Offset: 0x00039D5C
	// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00009076 File Offset: 0x00007276
	public unsafe string m_TutorialPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialPrompt);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialPrompt), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0003BB84 File Offset: 0x00039D84
	// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00009095 File Offset: 0x00007295
	public unsafe int m_TutorialPanelLayoutIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialPanelLayoutIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_TutorialPanelLayoutIndex)) = value;
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0003BBAC File Offset: 0x00039DAC
	// (set) Token: 0x06000B87 RID: 2951 RVA: 0x000090B0 File Offset: 0x000072B0
	public unsafe int m_AutoAnimateRegionMap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_AutoAnimateRegionMap);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_AutoAnimateRegionMap)) = value;
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0003BBD4 File Offset: 0x00039DD4
	// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000090CB File Offset: 0x000072CB
	public unsafe Il2CppReferenceArray<TutorialCallout> m_Callouts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_Callouts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialCallout>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialStep.NativeFieldInfoPtr_m_Callouts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400070E RID: 1806
	private static readonly IntPtr NativeFieldInfoPtr_HideTutorialButtonCheck;

	// Token: 0x0400070F RID: 1807
	private static readonly IntPtr NativeFieldInfoPtr_ShowButtonUndo;

	// Token: 0x04000710 RID: 1808
	private static readonly IntPtr NativeFieldInfoPtr_ShowButtonEndTurn;

	// Token: 0x04000711 RID: 1809
	private static readonly IntPtr NativeFieldInfoPtr_DismissCurrentPopup;

	// Token: 0x04000712 RID: 1810
	private static readonly IntPtr NativeFieldInfoPtr_HidePopupButtonCancel;

	// Token: 0x04000713 RID: 1811
	private static readonly IntPtr NativeFieldInfoPtr_HidePopupButtonCheck;

	// Token: 0x04000714 RID: 1812
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAIOptions;

	// Token: 0x04000715 RID: 1813
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAIAction;

	// Token: 0x04000716 RID: 1814
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimation;

	// Token: 0x04000717 RID: 1815
	private static readonly IntPtr NativeFieldInfoPtr_WaitForEndOfGame;

	// Token: 0x04000718 RID: 1816
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAvailableOptions;

	// Token: 0x04000719 RID: 1817
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimationBegin;

	// Token: 0x0400071A RID: 1818
	private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimationEnd;

	// Token: 0x0400071B RID: 1819
	private static readonly IntPtr NativeFieldInfoPtr_PauseSimulation;

	// Token: 0x0400071C RID: 1820
	private static readonly IntPtr NativeFieldInfoPtr_MagnifyCard;

	// Token: 0x0400071D RID: 1821
	private static readonly IntPtr NativeFieldInfoPtr_UnmagnifyCard;

	// Token: 0x0400071E RID: 1822
	private static readonly IntPtr NativeFieldInfoPtr_WaitForMagnify;

	// Token: 0x0400071F RID: 1823
	private static readonly IntPtr NativeFieldInfoPtr_WaitForUnmagnify;

	// Token: 0x04000720 RID: 1824
	private static readonly IntPtr NativeFieldInfoPtr_m_StepType;

	// Token: 0x04000721 RID: 1825
	private static readonly IntPtr NativeFieldInfoPtr_m_StepFlags;

	// Token: 0x04000722 RID: 1826
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionHint;

	// Token: 0x04000723 RID: 1827
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionID;

	// Token: 0x04000724 RID: 1828
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionOptionalData;

	// Token: 0x04000725 RID: 1829
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionInstanceType;

	// Token: 0x04000726 RID: 1830
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionInstanceName;

	// Token: 0x04000727 RID: 1831
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialText;

	// Token: 0x04000728 RID: 1832
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPrompt;

	// Token: 0x04000729 RID: 1833
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelLayoutIndex;

	// Token: 0x0400072A RID: 1834
	private static readonly IntPtr NativeFieldInfoPtr_m_AutoAnimateRegionMap;

	// Token: 0x0400072B RID: 1835
	private static readonly IntPtr NativeFieldInfoPtr_m_Callouts;

	// Token: 0x0400072C RID: 1836
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TutorialStepType_UInt32_UInt16_UInt16_UInt32_Int32_String_String_String_Int32_Int32_Il2CppReferenceArray_1_TutorialCallout_0;

	// Token: 0x0400072D RID: 1837
	private static readonly IntPtr NativeMethodInfoPtr_IsWaitForAIOptions_Public_Boolean_0;

	// Token: 0x0400072E RID: 1838
	private static readonly IntPtr NativeMethodInfoPtr_IsWaitForAIAction_Public_Boolean_0;

	// Token: 0x0400072F RID: 1839
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectionID_Public_UInt16_0;
}
