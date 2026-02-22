using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003D RID: 61
public class Popup_EndGame : PopupBase
{
	// Token: 0x06000AEA RID: 2794 RVA: 0x0003A424 File Offset: 0x00038624
	// Note: this type is marked as 'beforefieldinit'.
	static Popup_EndGame()
	{
		Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Popup_EndGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr);
		Popup_EndGame.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "k_maxDataSize");
		Popup_EndGame.NativeFieldInfoPtr_m_breakdownNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_breakdownNodes");
		Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_selectedPlayerName");
		Popup_EndGame.NativeFieldInfoPtr_m_cardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_cardLocator");
		Popup_EndGame.NativeFieldInfoPtr_m_magnifyUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_magnifyUI");
		Popup_EndGame.NativeFieldInfoPtr_m_magnifyPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_magnifyPanel");
		Popup_EndGame.NativeFieldInfoPtr_m_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_scrollRect");
		Popup_EndGame.NativeFieldInfoPtr_m_scrollRectContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_scrollRectContent");
		Popup_EndGame.NativeFieldInfoPtr_m_rematchButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_rematchButton");
		Popup_EndGame.NativeFieldInfoPtr_m_rematchButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_rematchButtonText");
		Popup_EndGame.NativeFieldInfoPtr_m_endGameButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_endGameButtonText");
		Popup_EndGame.NativeFieldInfoPtr_m_LocalPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_LocalPlayerIndex");
		Popup_EndGame.NativeFieldInfoPtr_m_numPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_numPlayers");
		Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_selectedPlayerIndex");
		Popup_EndGame.NativeFieldInfoPtr_m_localPlayerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_localPlayerScore");
		Popup_EndGame.NativeFieldInfoPtr_m_bForfeit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_bForfeit");
		Popup_EndGame.NativeFieldInfoPtr_m_bLocalPlayerWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_bLocalPlayerWon");
		Popup_EndGame.NativeFieldInfoPtr_m_bEndGameHasStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_bEndGameHasStarted");
		Popup_EndGame.NativeFieldInfoPtr_m_winnerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_winnerIDs");
		Popup_EndGame.NativeFieldInfoPtr_m_cardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_cardManager");
		Popup_EndGame.NativeFieldInfoPtr_m_AscensionGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_AscensionGame");
		Popup_EndGame.NativeFieldInfoPtr_m_dataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_dataBuffer");
		Popup_EndGame.NativeFieldInfoPtr_m_hDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_hDataBuffer");
		Popup_EndGame.NativeFieldInfoPtr_m_bufPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "m_bufPtr");
		Popup_EndGame.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664066);
		Popup_EndGame.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664067);
		Popup_EndGame.NativeMethodInfoPtr_SetForfeit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664068);
		Popup_EndGame.NativeMethodInfoPtr_SetEndGameText_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664069);
		Popup_EndGame.NativeMethodInfoPtr_StartEndGameSequence_Public_Void_AscensionCardManager_AscensionGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664070);
		Popup_EndGame.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664071);
		Popup_EndGame.NativeMethodInfoPtr_GetEndGameHasStarted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664072);
		Popup_EndGame.NativeMethodInfoPtr_SetMagnifyOverride_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664073);
		Popup_EndGame.NativeMethodInfoPtr_PopulateBreakdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664074);
		Popup_EndGame.NativeMethodInfoPtr_SelectPlayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664075);
		Popup_EndGame.NativeMethodInfoPtr_OnGameOverButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664076);
		Popup_EndGame.NativeMethodInfoPtr_OnRematchButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664077);
		Popup_EndGame.NativeMethodInfoPtr_HandleAchievements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664078);
		Popup_EndGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, 100664079);
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x0003A74C File Offset: 0x0003894C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237232, RefRangeEnd = 237235, XrefRangeStart = 237214, XrefRangeEnd = 237232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0003A780 File Offset: 0x00038980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237235, XrefRangeEnd = 237265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0003A7B4 File Offset: 0x000389B4
	[CallerCount(0)]
	public unsafe void SetForfeit(bool bLocalPlayerWon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bLocalPlayerWon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_SetForfeit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0003A7F4 File Offset: 0x000389F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237273, RefRangeEnd = 237274, XrefRangeStart = 237265, XrefRangeEnd = 237273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEndGameText(bool bLoadedIntoCompletedGame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bLoadedIntoCompletedGame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_SetEndGameText_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0003A834 File Offset: 0x00038A34
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237292, RefRangeEnd = 237295, XrefRangeStart = 237274, XrefRangeEnd = 237292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartEndGameSequence(AscensionCardManager cardManager, AscensionGame ascensionGame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardManager);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ascensionGame);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_StartEndGameSequence_Public_Void_AscensionCardManager_AscensionGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0003A888 File Offset: 0x00038A88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237295, XrefRangeEnd = 237299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleSoakTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0003A8C8 File Offset: 0x00038AC8
	[CallerCount(0)]
	public unsafe bool GetEndGameHasStarted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_GetEndGameHasStarted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0003A904 File Offset: 0x00038B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237299, XrefRangeEnd = 237307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMagnifyOverride(bool bUseOverride)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUseOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_SetMagnifyOverride_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0003A944 File Offset: 0x00038B44
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237362, RefRangeEnd = 237363, XrefRangeStart = 237307, XrefRangeEnd = 237362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateBreakdown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_PopulateBreakdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0003A978 File Offset: 0x00038B78
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237416, RefRangeEnd = 237417, XrefRangeStart = 237363, XrefRangeEnd = 237416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectPlayer(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_SelectPlayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0003A9B8 File Offset: 0x00038BB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237417, XrefRangeEnd = 237453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameOverButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_OnGameOverButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0003A9EC File Offset: 0x00038BEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237453, XrefRangeEnd = 237475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRematchButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_OnRematchButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0003AA20 File Offset: 0x00038C20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237487, RefRangeEnd = 237489, XrefRangeStart = 237475, XrefRangeEnd = 237487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr_HandleAchievements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x0003AA54 File Offset: 0x00038C54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237489, XrefRangeEnd = 237490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Popup_EndGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00008AB3 File Offset: 0x00006CB3
	public Popup_EndGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0003AA90 File Offset: 0x00038C90
	// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00008ABC File Offset: 0x00006CBC
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Popup_EndGame.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Popup_EndGame.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0003AAAC File Offset: 0x00038CAC
	// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00008ACA File Offset: 0x00006CCA
	public unsafe Il2CppReferenceArray<Popup_EndGame.PlayerScoreBreakdown> m_breakdownNodes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_breakdownNodes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Popup_EndGame.PlayerScoreBreakdown>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_breakdownNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0003AADC File Offset: 0x00038CDC
	// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00008AE9 File Offset: 0x00006CE9
	public unsafe TextMeshProUGUI m_selectedPlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0003AB0C File Offset: 0x00038D0C
	// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00008B08 File Offset: 0x00006D08
	public unsafe AscensionAnimationLocator m_cardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_cardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_cardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003AB3C File Offset: 0x00038D3C
	// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00008B27 File Offset: 0x00006D27
	public unsafe GameObject m_magnifyUI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_magnifyUI);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_magnifyUI), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003AB6C File Offset: 0x00038D6C
	// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00008B46 File Offset: 0x00006D46
	public unsafe GameObject m_magnifyPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_magnifyPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_magnifyPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003AB9C File Offset: 0x00038D9C
	// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00008B65 File Offset: 0x00006D65
	public unsafe ScrollRect m_scrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_scrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0003ABCC File Offset: 0x00038DCC
	// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00008B84 File Offset: 0x00006D84
	public unsafe GameObject m_scrollRectContent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_scrollRectContent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_scrollRectContent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003ABFC File Offset: 0x00038DFC
	// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00008BA3 File Offset: 0x00006DA3
	public unsafe GameObject m_rematchButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_rematchButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_rematchButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003AC2C File Offset: 0x00038E2C
	// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00008BC2 File Offset: 0x00006DC2
	public unsafe TextMeshProUGUI m_rematchButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_rematchButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_rematchButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0003AC5C File Offset: 0x00038E5C
	// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00008BE1 File Offset: 0x00006DE1
	public unsafe TextMeshProUGUI m_endGameButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_endGameButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_endGameButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0003AC8C File Offset: 0x00038E8C
	// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00008C00 File Offset: 0x00006E00
	public unsafe int m_LocalPlayerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_LocalPlayerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_LocalPlayerIndex)) = value;
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0003ACB4 File Offset: 0x00038EB4
	// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00008C1B File Offset: 0x00006E1B
	public unsafe int m_numPlayers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_numPlayers);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_numPlayers)) = value;
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0003ACDC File Offset: 0x00038EDC
	// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00008C36 File Offset: 0x00006E36
	public unsafe int m_selectedPlayerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_selectedPlayerIndex)) = value;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0003AD04 File Offset: 0x00038F04
	// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00008C51 File Offset: 0x00006E51
	public unsafe int m_localPlayerScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_localPlayerScore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_localPlayerScore)) = value;
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0003AD2C File Offset: 0x00038F2C
	// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00008C6C File Offset: 0x00006E6C
	public unsafe bool m_bForfeit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bForfeit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bForfeit)) = value;
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0003AD54 File Offset: 0x00038F54
	// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00008C87 File Offset: 0x00006E87
	public unsafe bool m_bLocalPlayerWon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bLocalPlayerWon);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bLocalPlayerWon)) = value;
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0003AD7C File Offset: 0x00038F7C
	// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00008CA2 File Offset: 0x00006EA2
	public unsafe bool m_bEndGameHasStarted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bEndGameHasStarted);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bEndGameHasStarted)) = value;
		}
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0003ADA4 File Offset: 0x00038FA4
	// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00008CBD File Offset: 0x00006EBD
	public unsafe List<int> m_winnerIDs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_winnerIDs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_winnerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003ADD4 File Offset: 0x00038FD4
	// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00008CDC File Offset: 0x00006EDC
	public unsafe AscensionCardManager m_cardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_cardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_cardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0003AE04 File Offset: 0x00039004
	// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00008CFB File Offset: 0x00006EFB
	public unsafe AscensionGame m_AscensionGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_AscensionGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_AscensionGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0003AE34 File Offset: 0x00039034
	// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00008D1A File Offset: 0x00006F1A
	public unsafe Il2CppStructArray<byte> m_dataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_dataBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_dataBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0003AE64 File Offset: 0x00039064
	// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00008D39 File Offset: 0x00006F39
	public unsafe GCHandle m_hDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_hDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_hDataBuffer)) = value;
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0003AE8C File Offset: 0x0003908C
	// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00008D54 File Offset: 0x00006F54
	public unsafe IntPtr m_bufPtr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bufPtr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.NativeFieldInfoPtr_m_bufPtr)) = value;
		}
	}

	// Token: 0x040006CF RID: 1743
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x040006D0 RID: 1744
	private static readonly IntPtr NativeFieldInfoPtr_m_breakdownNodes;

	// Token: 0x040006D1 RID: 1745
	private static readonly IntPtr NativeFieldInfoPtr_m_selectedPlayerName;

	// Token: 0x040006D2 RID: 1746
	private static readonly IntPtr NativeFieldInfoPtr_m_cardLocator;

	// Token: 0x040006D3 RID: 1747
	private static readonly IntPtr NativeFieldInfoPtr_m_magnifyUI;

	// Token: 0x040006D4 RID: 1748
	private static readonly IntPtr NativeFieldInfoPtr_m_magnifyPanel;

	// Token: 0x040006D5 RID: 1749
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRect;

	// Token: 0x040006D6 RID: 1750
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRectContent;

	// Token: 0x040006D7 RID: 1751
	private static readonly IntPtr NativeFieldInfoPtr_m_rematchButton;

	// Token: 0x040006D8 RID: 1752
	private static readonly IntPtr NativeFieldInfoPtr_m_rematchButtonText;

	// Token: 0x040006D9 RID: 1753
	private static readonly IntPtr NativeFieldInfoPtr_m_endGameButtonText;

	// Token: 0x040006DA RID: 1754
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerIndex;

	// Token: 0x040006DB RID: 1755
	private static readonly IntPtr NativeFieldInfoPtr_m_numPlayers;

	// Token: 0x040006DC RID: 1756
	private static readonly IntPtr NativeFieldInfoPtr_m_selectedPlayerIndex;

	// Token: 0x040006DD RID: 1757
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerScore;

	// Token: 0x040006DE RID: 1758
	private static readonly IntPtr NativeFieldInfoPtr_m_bForfeit;

	// Token: 0x040006DF RID: 1759
	private static readonly IntPtr NativeFieldInfoPtr_m_bLocalPlayerWon;

	// Token: 0x040006E0 RID: 1760
	private static readonly IntPtr NativeFieldInfoPtr_m_bEndGameHasStarted;

	// Token: 0x040006E1 RID: 1761
	private static readonly IntPtr NativeFieldInfoPtr_m_winnerIDs;

	// Token: 0x040006E2 RID: 1762
	private static readonly IntPtr NativeFieldInfoPtr_m_cardManager;

	// Token: 0x040006E3 RID: 1763
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionGame;

	// Token: 0x040006E4 RID: 1764
	private static readonly IntPtr NativeFieldInfoPtr_m_dataBuffer;

	// Token: 0x040006E5 RID: 1765
	private static readonly IntPtr NativeFieldInfoPtr_m_hDataBuffer;

	// Token: 0x040006E6 RID: 1766
	private static readonly IntPtr NativeFieldInfoPtr_m_bufPtr;

	// Token: 0x040006E7 RID: 1767
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040006E8 RID: 1768
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040006E9 RID: 1769
	private static readonly IntPtr NativeMethodInfoPtr_SetForfeit_Public_Void_Boolean_0;

	// Token: 0x040006EA RID: 1770
	private static readonly IntPtr NativeMethodInfoPtr_SetEndGameText_Public_Void_Boolean_0;

	// Token: 0x040006EB RID: 1771
	private static readonly IntPtr NativeMethodInfoPtr_StartEndGameSequence_Public_Void_AscensionCardManager_AscensionGame_0;

	// Token: 0x040006EC RID: 1772
	private static readonly IntPtr NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0;

	// Token: 0x040006ED RID: 1773
	private static readonly IntPtr NativeMethodInfoPtr_GetEndGameHasStarted_Public_Boolean_0;

	// Token: 0x040006EE RID: 1774
	private static readonly IntPtr NativeMethodInfoPtr_SetMagnifyOverride_Public_Void_Boolean_0;

	// Token: 0x040006EF RID: 1775
	private static readonly IntPtr NativeMethodInfoPtr_PopulateBreakdown_Public_Void_0;

	// Token: 0x040006F0 RID: 1776
	private static readonly IntPtr NativeMethodInfoPtr_SelectPlayer_Public_Void_Int32_0;

	// Token: 0x040006F1 RID: 1777
	private static readonly IntPtr NativeMethodInfoPtr_OnGameOverButtonPressed_Public_Void_0;

	// Token: 0x040006F2 RID: 1778
	private static readonly IntPtr NativeMethodInfoPtr_OnRematchButtonPressed_Public_Void_0;

	// Token: 0x040006F3 RID: 1779
	private static readonly IntPtr NativeMethodInfoPtr_HandleAchievements_Private_Void_0;

	// Token: 0x040006F4 RID: 1780
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200017F RID: 383
	[Serializable]
	public sealed class PlayerScoreBreakdown : ValueType
	{
		// Token: 0x060023BD RID: 9149 RVA: 0x00085834 File Offset: 0x00083A34
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerScoreBreakdown()
		{
			Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "PlayerScoreBreakdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr);
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_baseNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "baseNode");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "name");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "avatar");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_finalVp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "finalVp");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_tokenVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "tokenVP");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "cardVP");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_winnerGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "winnerGlow");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardLimbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "cardLimbo");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_playerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "playerID");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "score");
			Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr, "cards");
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000164B2 File Offset: 0x000146B2
		public PlayerScoreBreakdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000164BB File Offset: 0x000146BB
		public PlayerScoreBreakdown()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_EndGame.PlayerScoreBreakdown>.NativeClassPtr))
		{
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x0008593C File Offset: 0x00083B3C
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x000164CD File Offset: 0x000146CD
		public unsafe GameObject baseNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_baseNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_baseNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0008596C File Offset: 0x00083B6C
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x000164EC File Offset: 0x000146EC
		public unsafe TextMeshProUGUI name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0008599C File Offset: 0x00083B9C
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0001650B File Offset: 0x0001470B
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000859CC File Offset: 0x00083BCC
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x0001652A File Offset: 0x0001472A
		public unsafe TextMeshProUGUI finalVp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_finalVp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_finalVp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000859FC File Offset: 0x00083BFC
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x00016549 File Offset: 0x00014749
		public unsafe TextMeshProUGUI tokenVP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_tokenVP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_tokenVP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x00085A2C File Offset: 0x00083C2C
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x00016568 File Offset: 0x00014768
		public unsafe TextMeshProUGUI cardVP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardVP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardVP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x00085A5C File Offset: 0x00083C5C
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x00016587 File Offset: 0x00014787
		public unsafe GameObject winnerGlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_winnerGlow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_winnerGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x00085A8C File Offset: 0x00083C8C
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x000165A6 File Offset: 0x000147A6
		public unsafe AscensionAnimationLocator cardLimbo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardLimbo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cardLimbo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x00085ABC File Offset: 0x00083CBC
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x000165C5 File Offset: 0x000147C5
		public unsafe int playerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_playerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_playerID)) = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x00085AE4 File Offset: 0x00083CE4
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000165E0 File Offset: 0x000147E0
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x00085B0C File Offset: 0x00083D0C
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x000165FB File Offset: 0x000147FB
		public unsafe List<GameObject> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame.PlayerScoreBreakdown.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_baseNode;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeFieldInfoPtr_finalVp;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeFieldInfoPtr_tokenVP;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeFieldInfoPtr_cardVP;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeFieldInfoPtr_winnerGlow;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr_cardLimbo;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_playerID;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_cards;
	}

	// Token: 0x02000180 RID: 384
	[ObfuscatedName("Popup_EndGame+<HandleSoakTest>d__30")]
	public sealed class _HandleSoakTest_d__30 : global::Il2CppSystem.Object
	{
		// Token: 0x060023D6 RID: 9174 RVA: 0x00085B3C File Offset: 0x00083D3C
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleSoakTest_d__30()
		{
			Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Popup_EndGame>.NativeClassPtr, "<HandleSoakTest>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr);
			Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, "<>1__state");
			Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, "<>2__current");
			Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, "<>4__this");
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666138);
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666139);
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666140);
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666141);
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666142);
			Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr, 100666143);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00085C1C File Offset: 0x00083E1C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleSoakTest_d__30(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_EndGame._HandleSoakTest_d__30>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00085C64 File Offset: 0x00083E64
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00085C98 File Offset: 0x00083E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237205, XrefRangeEnd = 237209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x00085CD4 File Offset: 0x00083ED4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00085D14 File Offset: 0x00083F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237209, XrefRangeEnd = 237214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x00085D48 File Offset: 0x00083F48
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_EndGame._HandleSoakTest_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0001661A File Offset: 0x0001481A
		public _HandleSoakTest_d__30(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x00085D88 File Offset: 0x00083F88
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x00016623 File Offset: 0x00014823
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x00085DB0 File Offset: 0x00083FB0
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0001663E File Offset: 0x0001483E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x00085DE0 File Offset: 0x00083FE0
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x0001665D File Offset: 0x0001485D
		public unsafe Popup_EndGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Popup_EndGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_EndGame._HandleSoakTest_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
