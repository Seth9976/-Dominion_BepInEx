using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000044 RID: 68
public class Tutorial : Object
{
	// Token: 0x06000B95 RID: 2965 RVA: 0x0003BDE4 File Offset: 0x00039FE4
	// Note: this type is marked as 'beforefieldinit'.
	static Tutorial()
	{
		Il2CppClassPointerStore<Tutorial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Tutorial");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tutorial>.NativeClassPtr);
		Tutorial.NativeFieldInfoPtr_m_CurrentTutorialSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, "m_CurrentTutorialSteps");
		Tutorial.NativeFieldInfoPtr_s_CurrentTutorialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, "s_CurrentTutorialIndex");
		Tutorial.NativeFieldInfoPtr_m_TutorialPanelLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, "m_TutorialPanelLayouts");
		Tutorial.NativeFieldInfoPtr_m_TutorialSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, "m_TutorialSteps");
		Tutorial.NativeFieldInfoPtr_m_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, "m_CurrentStep");
		Tutorial.NativeMethodInfoPtr_IsCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664091);
		Tutorial.NativeMethodInfoPtr_GetCurrentStepNumber_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664092);
		Tutorial.NativeMethodInfoPtr_GetCurrentStep_Public_TutorialStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664093);
		Tutorial.NativeMethodInfoPtr_GetPreviousStep_Public_TutorialStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664094);
		Tutorial.NativeMethodInfoPtr_GenerateCurrentStepName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664095);
		Tutorial.NativeMethodInfoPtr_GetTutorialPanelLayout_Public_TutorialPanelLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664096);
		Tutorial.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664097);
		Tutorial.NativeMethodInfoPtr_Advance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664098);
		Tutorial.NativeMethodInfoPtr_Backup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664099);
		Tutorial.NativeMethodInfoPtr_UpdateGameOptions_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664100);
		Tutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tutorial>.NativeClassPtr, 100664101);
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0003BF54 File Offset: 0x0003A154
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 237513, RefRangeEnd = 237523, XrefRangeStart = 237513, XrefRangeEnd = 237513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_IsCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0003BF90 File Offset: 0x0003A190
	[CallerCount(0)]
	public unsafe int GetCurrentStepNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_GetCurrentStepNumber_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x0003BFCC File Offset: 0x0003A1CC
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 237523, RefRangeEnd = 237536, XrefRangeStart = 237523, XrefRangeEnd = 237523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialStep GetCurrentStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_GetCurrentStep_Public_TutorialStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialStep>(intPtr3) : null;
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0003C00C File Offset: 0x0003A20C
	[CallerCount(0)]
	public unsafe TutorialStep GetPreviousStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_GetPreviousStep_Public_TutorialStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialStep>(intPtr3) : null;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0003C04C File Offset: 0x0003A24C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237536, XrefRangeEnd = 237563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateCurrentStepName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_GenerateCurrentStepName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0003C084 File Offset: 0x0003A284
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237569, RefRangeEnd = 237570, XrefRangeStart = 237563, XrefRangeEnd = 237569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialPanelLayout GetTutorialPanelLayout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_GetTutorialPanelLayout_Public_TutorialPanelLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialPanelLayout>(intPtr3) : null;
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237576, RefRangeEnd = 237578, XrefRangeStart = 237570, XrefRangeEnd = 237576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0003C0F8 File Offset: 0x0003A2F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237578, RefRangeEnd = 237580, XrefRangeStart = 237578, XrefRangeEnd = 237578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Advance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_Advance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0003C12C File Offset: 0x0003A32C
	[CallerCount(0)]
	public unsafe void Backup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_Backup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x0003C160 File Offset: 0x0003A360
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237590, RefRangeEnd = 237591, XrefRangeStart = 237580, XrefRangeEnd = 237590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGameOptions(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr_UpdateGameOptions_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Tutorial()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tutorial>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0000915F File Offset: 0x0000735F
	public Tutorial(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003C1E0 File Offset: 0x0003A3E0
	// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00009168 File Offset: 0x00007368
	public unsafe static Il2CppReferenceArray<TutorialStep> m_CurrentTutorialSteps
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Tutorial.NativeFieldInfoPtr_m_CurrentTutorialSteps, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialStep>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Tutorial.NativeFieldInfoPtr_m_CurrentTutorialSteps, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0003C208 File Offset: 0x0003A408
	// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0000917A File Offset: 0x0000737A
	public unsafe static int s_CurrentTutorialIndex
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Tutorial.NativeFieldInfoPtr_s_CurrentTutorialIndex, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Tutorial.NativeFieldInfoPtr_s_CurrentTutorialIndex, (void*)(&value));
		}
	}

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0003C224 File Offset: 0x0003A424
	// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00009188 File Offset: 0x00007388
	public unsafe static Il2CppReferenceArray<TutorialPanelLayout> m_TutorialPanelLayouts
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Tutorial.NativeFieldInfoPtr_m_TutorialPanelLayouts, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialPanelLayout>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Tutorial.NativeFieldInfoPtr_m_TutorialPanelLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003C24C File Offset: 0x0003A44C
	// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0000919A File Offset: 0x0000739A
	public unsafe Il2CppReferenceArray<TutorialStep> m_TutorialSteps
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tutorial.NativeFieldInfoPtr_m_TutorialSteps);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialStep>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tutorial.NativeFieldInfoPtr_m_TutorialSteps), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003C27C File Offset: 0x0003A47C
	// (set) Token: 0x06000BAB RID: 2987 RVA: 0x000091B9 File Offset: 0x000073B9
	public unsafe int m_CurrentStep
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tutorial.NativeFieldInfoPtr_m_CurrentStep);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tutorial.NativeFieldInfoPtr_m_CurrentStep)) = value;
		}
	}

	// Token: 0x04000735 RID: 1845
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTutorialSteps;

	// Token: 0x04000736 RID: 1846
	private static readonly IntPtr NativeFieldInfoPtr_s_CurrentTutorialIndex;

	// Token: 0x04000737 RID: 1847
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelLayouts;

	// Token: 0x04000738 RID: 1848
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialSteps;

	// Token: 0x04000739 RID: 1849
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentStep;

	// Token: 0x0400073A RID: 1850
	private static readonly IntPtr NativeMethodInfoPtr_IsCompleted_Public_Boolean_0;

	// Token: 0x0400073B RID: 1851
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentStepNumber_Public_Int32_0;

	// Token: 0x0400073C RID: 1852
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentStep_Public_TutorialStep_0;

	// Token: 0x0400073D RID: 1853
	private static readonly IntPtr NativeMethodInfoPtr_GetPreviousStep_Public_TutorialStep_0;

	// Token: 0x0400073E RID: 1854
	private static readonly IntPtr NativeMethodInfoPtr_GenerateCurrentStepName_Public_String_0;

	// Token: 0x0400073F RID: 1855
	private static readonly IntPtr NativeMethodInfoPtr_GetTutorialPanelLayout_Public_TutorialPanelLayout_0;

	// Token: 0x04000740 RID: 1856
	private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	// Token: 0x04000741 RID: 1857
	private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Void_0;

	// Token: 0x04000742 RID: 1858
	private static readonly IntPtr NativeMethodInfoPtr_Backup_Public_Void_0;

	// Token: 0x04000743 RID: 1859
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGameOptions_Public_Void_AscensionCardManager_0;

	// Token: 0x04000744 RID: 1860
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
