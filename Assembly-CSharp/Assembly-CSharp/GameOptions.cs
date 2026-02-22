using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000032 RID: 50
[StructLayout(2)]
public struct GameOptions
{
	// Token: 0x06000942 RID: 2370 RVA: 0x000350EC File Offset: 0x000332EC
	// Note: this type is marked as 'beforefieldinit'.
	static GameOptions()
	{
		Il2CppClassPointerStore<GameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptions>.NativeClassPtr);
		GameOptions.NativeFieldInfoPtr_m_GameOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "m_GameOption");
		GameOptions.NativeFieldInfoPtr_m_OptionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "m_OptionCount");
		GameOptions.NativeFieldInfoPtr_m_OptionPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "m_OptionPrompt");
		GameOptions.NativeFieldInfoPtr_s_bNewGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "s_bNewGameOptions");
		GameOptions.NativeMethodInfoPtr_OnGameOptionsEndList_Public_Static_Void_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663913);
		GameOptions.NativeMethodInfoPtr_Update_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663914);
		GameOptions.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663915);
		GameOptions.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663916);
		GameOptions.NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663917);
		GameOptions.NativeMethodInfoPtr_SelectOption_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663918);
		GameOptions.NativeMethodInfoPtr_SelectOptionWithData_Public_Static_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663919);
		GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceID_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663920);
		GameOptions.NativeMethodInfoPtr_SelectOptionByHint_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663921);
		GameOptions.NativeMethodInfoPtr_SelectOptionByHintAndOptionText_Public_Static_Boolean_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663922);
		GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceIDAndHint_Public_Static_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663923);
		GameOptions.NativeMethodInfoPtr_SelectOptionByHintWithData_Public_Static_Boolean_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663924);
		GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceIDAndHintWithData_Public_Static_Boolean_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663925);
		GameOptions.NativeMethodInfoPtr_GetInstanceIDFromHint_Public_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663926);
		GameOptions.NativeMethodInfoPtr_GetOptionPromptFromHint_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663927);
		GameOptions.NativeMethodInfoPtr_GetOptionPromptFromIDAndHint_Public_Static_String_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663928);
		GameOptions.NativeMethodInfoPtr_IsSelectableHint_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663929);
		GameOptions.NativeMethodInfoPtr_IsSelectableHintWithOptionText_Public_Static_Boolean_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663930);
		GameOptions.NativeMethodInfoPtr_IsSelectableInstanceID_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663931);
		GameOptions.NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663932);
		GameOptions.NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663933);
		GameOptions.NativeMethodInfoPtr_GetSelectableIndex_Public_Static_Int32_UInt16_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663934);
		GameOptions.NativeMethodInfoPtr_GetSelectionHintForOptionIndex_Public_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663935);
		GameOptions.NativeMethodInfoPtr_GetSelectionHints_Public_Static_List_1_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663936);
		GameOptions.NativeMethodInfoPtr_GetSelectionIDsForHint_Public_Static_List_1_UInt16_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663937);
		GameOptions.NativeMethodInfoPtr_IsOptionIndexHidden_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663938);
		GameOptions.NativeMethodInfoPtr_UnhideAllOptions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663939);
		GameOptions.NativeMethodInfoPtr_HideAllOptions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663940);
		GameOptions.NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663941);
		GameOptions.NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_List_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663942);
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000353C4 File Offset: 0x000335C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235440, XrefRangeEnd = 235475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnGameOptionsEndList(int playerID, IntPtr pOptionPrompt, int numOptions, IntPtr pGameOptions)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOptionPrompt;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numOptions;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pGameOptions;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_OnGameOptionsEndList_Public_Static_Void_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00035420 File Offset: 0x00033620
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235477, RefRangeEnd = 235478, XrefRangeStart = 235475, XrefRangeEnd = 235477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Update()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_Update_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00035450 File Offset: 0x00033650
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235489, RefRangeEnd = 235490, XrefRangeStart = 235478, XrefRangeEnd = 235489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00035478 File Offset: 0x00033678
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235496, RefRangeEnd = 235497, XrefRangeStart = 235490, XrefRangeEnd = 235496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_Reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x000354A0 File Offset: 0x000336A0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235504, RefRangeEnd = 235506, XrefRangeStart = 235497, XrefRangeEnd = 235504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResendGameOptionsList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x000354C8 File Offset: 0x000336C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235506, XrefRangeEnd = 235521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectOption(int optionIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOption_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000354FC File Offset: 0x000336FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235521, XrefRangeEnd = 235536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectOptionWithData(int optionIndex, uint selectionData)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionWithData_Public_Static_Void_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0003553C File Offset: 0x0003373C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235536, XrefRangeEnd = 235538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByInstanceID(ushort instanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceID_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x0003557C File Offset: 0x0003377C
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 235540, RefRangeEnd = 235549, XrefRangeStart = 235538, XrefRangeEnd = 235540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByHint(ushort selectionHint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByHint_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x000355BC File Offset: 0x000337BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235549, XrefRangeEnd = 235553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByHintAndOptionText(ushort selectionHint, string optionText)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(optionText);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByHintAndOptionText_Public_Static_Boolean_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0003560C File Offset: 0x0003380C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 235555, RefRangeEnd = 235562, XrefRangeStart = 235553, XrefRangeEnd = 235555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByInstanceIDAndHint(ushort instanceID, ushort selectionHint)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionHint;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceIDAndHint_Public_Static_Boolean_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00035658 File Offset: 0x00033858
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235564, RefRangeEnd = 235566, XrefRangeStart = 235562, XrefRangeEnd = 235564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByHintWithData(ushort selectionHint, uint selectionData)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByHintWithData_Public_Static_Boolean_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x000356A4 File Offset: 0x000338A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235566, XrefRangeEnd = 235568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectOptionByInstanceIDAndHintWithData(ushort instanceID, ushort selectionHint, uint selectionData)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionHint;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_SelectOptionByInstanceIDAndHintWithData_Public_Static_Boolean_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00035700 File Offset: 0x00033900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235568, XrefRangeEnd = 235570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort GetInstanceIDFromHint(ushort hint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetInstanceIDFromHint_Public_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00035740 File Offset: 0x00033940
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235570, XrefRangeEnd = 235574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOptionPromptFromHint(ushort hint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetOptionPromptFromHint_Public_Static_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00035778 File Offset: 0x00033978
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235574, XrefRangeEnd = 235578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOptionPromptFromIDAndHint(ushort selectionID, ushort selectionHint)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionHint;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetOptionPromptFromIDAndHint_Public_Static_String_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000357C0 File Offset: 0x000339C0
	[CallerCount(56)]
	[CachedScanResults(RefRangeStart = 235580, RefRangeEnd = 235636, XrefRangeStart = 235578, XrefRangeEnd = 235580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSelectableHint(ushort hint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsSelectableHint_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00035800 File Offset: 0x00033A00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235636, XrefRangeEnd = 235640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSelectableHintWithOptionText(ushort hint, string optionText)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(optionText);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsSelectableHintWithOptionText_Public_Static_Boolean_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00035850 File Offset: 0x00033A50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235642, RefRangeEnd = 235643, XrefRangeStart = 235640, XrefRangeEnd = 235642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSelectableInstanceID(ushort instanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsSelectableInstanceID_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00035890 File Offset: 0x00033A90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235643, XrefRangeEnd = 235645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSelectableInstanceIDWithHint(ushort instanceID, ushort hint)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x000358DC File Offset: 0x00033ADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235645, XrefRangeEnd = 235647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSelectableInstanceIDWithHint(ushort instanceID, ushort hint, ref int isHidden)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isHidden;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00035938 File Offset: 0x00033B38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235647, XrefRangeEnd = 235649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSelectableIndex(ushort instanceID, ushort hint, bool bAllowHidden = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowHidden;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetSelectableIndex_Public_Static_Int32_UInt16_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00035994 File Offset: 0x00033B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235649, XrefRangeEnd = 235651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort GetSelectionHintForOptionIndex(int optionIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetSelectionHintForOptionIndex_Public_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x000359D4 File Offset: 0x00033BD4
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 235663, RefRangeEnd = 235674, XrefRangeStart = 235651, XrefRangeEnd = 235663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ushort> GetSelectionHints(ushort instanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetSelectionHints_Public_Static_List_1_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr3) : null;
		}
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00035A14 File Offset: 0x00033C14
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 235686, RefRangeEnd = 235694, XrefRangeStart = 235674, XrefRangeEnd = 235686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ushort> GetSelectionIDsForHint(ushort hint, bool bAllowHidden = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowHidden;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_GetSelectionIDsForHint_Public_Static_List_1_UInt16_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr3) : null;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00035A64 File Offset: 0x00033C64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235694, XrefRangeEnd = 235696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOptionIndexHidden(int optionIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_IsOptionIndexHidden_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00035AA4 File Offset: 0x00033CA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235696, XrefRangeEnd = 235699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnhideAllOptions()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_UnhideAllOptions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00035ACC File Offset: 0x00033CCC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235702, RefRangeEnd = 235703, XrefRangeStart = 235699, XrefRangeEnd = 235702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAllOptions()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_HideAllOptions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00035AF4 File Offset: 0x00033CF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235703, XrefRangeEnd = 235707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAllOtherOptions(ushort selectionHint, ushort selectionID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00035B34 File Offset: 0x00033D34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235707, XrefRangeEnd = 235714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAllOtherOptions(ushort selectionHint, List<ushort> selectionIDList)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionIDList);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_List_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00007C36 File Offset: 0x00005E36
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, ref this));
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06000962 RID: 2402 RVA: 0x00035B78 File Offset: 0x00033D78
	// (set) Token: 0x06000963 RID: 2403 RVA: 0x00007C48 File Offset: 0x00005E48
	public unsafe static Il2CppReferenceArray<GameOption> m_GameOption
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameOptions.NativeFieldInfoPtr_m_GameOption, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameOption>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameOptions.NativeFieldInfoPtr_m_GameOption, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06000964 RID: 2404 RVA: 0x00035BA0 File Offset: 0x00033DA0
	// (set) Token: 0x06000965 RID: 2405 RVA: 0x00007C5A File Offset: 0x00005E5A
	public unsafe static int m_OptionCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(GameOptions.NativeFieldInfoPtr_m_OptionCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameOptions.NativeFieldInfoPtr_m_OptionCount, (void*)(&value));
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x06000966 RID: 2406 RVA: 0x00035BBC File Offset: 0x00033DBC
	// (set) Token: 0x06000967 RID: 2407 RVA: 0x00007C68 File Offset: 0x00005E68
	public unsafe static string m_OptionPrompt
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameOptions.NativeFieldInfoPtr_m_OptionPrompt, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameOptions.NativeFieldInfoPtr_m_OptionPrompt, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x06000968 RID: 2408 RVA: 0x00035BDC File Offset: 0x00033DDC
	// (set) Token: 0x06000969 RID: 2409 RVA: 0x00007C7A File Offset: 0x00005E7A
	public unsafe static bool s_bNewGameOptions
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(GameOptions.NativeFieldInfoPtr_s_bNewGameOptions, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameOptions.NativeFieldInfoPtr_s_bNewGameOptions, (void*)(&value));
		}
	}

	// Token: 0x040005BA RID: 1466
	private static readonly IntPtr NativeFieldInfoPtr_m_GameOption;

	// Token: 0x040005BB RID: 1467
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionCount;

	// Token: 0x040005BC RID: 1468
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionPrompt;

	// Token: 0x040005BD RID: 1469
	private static readonly IntPtr NativeFieldInfoPtr_s_bNewGameOptions;

	// Token: 0x040005BE RID: 1470
	private static readonly IntPtr NativeMethodInfoPtr_OnGameOptionsEndList_Public_Static_Void_Int32_IntPtr_Int32_IntPtr_0;

	// Token: 0x040005BF RID: 1471
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Static_Boolean_0;

	// Token: 0x040005C0 RID: 1472
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	// Token: 0x040005C1 RID: 1473
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;

	// Token: 0x040005C2 RID: 1474
	private static readonly IntPtr NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0;

	// Token: 0x040005C3 RID: 1475
	private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Static_Void_Int32_0;

	// Token: 0x040005C4 RID: 1476
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionWithData_Public_Static_Void_Int32_UInt32_0;

	// Token: 0x040005C5 RID: 1477
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByInstanceID_Public_Static_Boolean_UInt16_0;

	// Token: 0x040005C6 RID: 1478
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByHint_Public_Static_Boolean_UInt16_0;

	// Token: 0x040005C7 RID: 1479
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByHintAndOptionText_Public_Static_Boolean_UInt16_String_0;

	// Token: 0x040005C8 RID: 1480
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByInstanceIDAndHint_Public_Static_Boolean_UInt16_UInt16_0;

	// Token: 0x040005C9 RID: 1481
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByHintWithData_Public_Static_Boolean_UInt16_UInt32_0;

	// Token: 0x040005CA RID: 1482
	private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByInstanceIDAndHintWithData_Public_Static_Boolean_UInt16_UInt16_UInt32_0;

	// Token: 0x040005CB RID: 1483
	private static readonly IntPtr NativeMethodInfoPtr_GetInstanceIDFromHint_Public_Static_UInt16_UInt16_0;

	// Token: 0x040005CC RID: 1484
	private static readonly IntPtr NativeMethodInfoPtr_GetOptionPromptFromHint_Public_Static_String_UInt16_0;

	// Token: 0x040005CD RID: 1485
	private static readonly IntPtr NativeMethodInfoPtr_GetOptionPromptFromIDAndHint_Public_Static_String_UInt16_UInt16_0;

	// Token: 0x040005CE RID: 1486
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectableHint_Public_Static_Boolean_UInt16_0;

	// Token: 0x040005CF RID: 1487
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectableHintWithOptionText_Public_Static_Boolean_UInt16_String_0;

	// Token: 0x040005D0 RID: 1488
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectableInstanceID_Public_Static_Boolean_UInt16_0;

	// Token: 0x040005D1 RID: 1489
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_0;

	// Token: 0x040005D2 RID: 1490
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectableInstanceIDWithHint_Public_Static_Boolean_UInt16_UInt16_byref_Int32_0;

	// Token: 0x040005D3 RID: 1491
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectableIndex_Public_Static_Int32_UInt16_UInt16_Boolean_0;

	// Token: 0x040005D4 RID: 1492
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHintForOptionIndex_Public_Static_UInt16_Int32_0;

	// Token: 0x040005D5 RID: 1493
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHints_Public_Static_List_1_UInt16_UInt16_0;

	// Token: 0x040005D6 RID: 1494
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectionIDsForHint_Public_Static_List_1_UInt16_UInt16_Boolean_0;

	// Token: 0x040005D7 RID: 1495
	private static readonly IntPtr NativeMethodInfoPtr_IsOptionIndexHidden_Public_Static_Boolean_Int32_0;

	// Token: 0x040005D8 RID: 1496
	private static readonly IntPtr NativeMethodInfoPtr_UnhideAllOptions_Public_Static_Void_0;

	// Token: 0x040005D9 RID: 1497
	private static readonly IntPtr NativeMethodInfoPtr_HideAllOptions_Public_Static_Void_0;

	// Token: 0x040005DA RID: 1498
	private static readonly IntPtr NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_UInt16_0;

	// Token: 0x040005DB RID: 1499
	private static readonly IntPtr NativeMethodInfoPtr_HideAllOtherOptions_Public_Static_Void_UInt16_List_1_UInt16_0;

	// Token: 0x0200017A RID: 378
	public sealed class GameOptionsNotifierDelegate : MulticastDelegate
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x00084BE4 File Offset: 0x00082DE4
		// Note: this type is marked as 'beforefieldinit'.
		static GameOptionsNotifierDelegate()
		{
			Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "GameOptionsNotifierDelegate");
			GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr, 100666112);
			GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr, 100666113);
			GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GameOption_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr, 100666114);
			GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr, 100666115);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00084C58 File Offset: 0x00082E58
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameOptionsNotifierDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptions.GameOptionsNotifierDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00084CB4 File Offset: 0x00082EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235427, XrefRangeEnd = 235433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(GameOption option, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(option));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameOption_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00084D0C File Offset: 0x00082F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235433, XrefRangeEnd = 235440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(GameOption option, bool bEnable, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(option));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GameOption_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00084D94 File Offset: 0x00082F94
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptions.GameOptionsNotifierDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0001632C File Offset: 0x0001452C
		public GameOptionsNotifierDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00016335 File Offset: 0x00014535
		public static implicit operator GameOptions.GameOptionsNotifierDelegate(Action<GameOption, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<GameOptions.GameOptionsNotifierDelegate>(A_0);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0001633D File Offset: 0x0001453D
		public static GameOptions.GameOptionsNotifierDelegate operator +(GameOptions.GameOptionsNotifierDelegate A_0, GameOptions.GameOptionsNotifierDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GameOptions.GameOptionsNotifierDelegate>();
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0001634B File Offset: 0x0001454B
		public static GameOptions.GameOptionsNotifierDelegate operator -(GameOptions.GameOptionsNotifierDelegate A_0, GameOptions.GameOptionsNotifierDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GameOptions.GameOptionsNotifierDelegate>();
			}
			return delegate2;
		}

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameOption_Boolean_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GameOption_Boolean_AsyncCallback_Object_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
