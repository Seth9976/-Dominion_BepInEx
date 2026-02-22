using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012C RID: 300
public class LeaderboardsUITab : FeatureTab
{
	// Token: 0x0600154E RID: 5454 RVA: 0x0006071C File Offset: 0x0005E91C
	// Note: this type is marked as 'beforefieldinit'.
	static LeaderboardsUITab()
	{
		Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeaderboardsUITab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr);
		LeaderboardsUITab.NativeFieldInfoPtr_LEADERBOARD_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "LEADERBOARD_ID");
		LeaderboardsUITab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "avatar");
		LeaderboardsUITab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "defaulttexture");
		LeaderboardsUITab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "logo");
		LeaderboardsUITab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "connectButton");
		LeaderboardsUITab.NativeFieldInfoPtr_connectButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "connectButtonLabel");
		LeaderboardsUITab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "playerLabel");
		LeaderboardsUITab.NativeFieldInfoPtr_GlobalButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "GlobalButton");
		LeaderboardsUITab.NativeFieldInfoPtr_FriendsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "FriendsButton");
		LeaderboardsUITab.NativeFieldInfoPtr_AllTimeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "AllTimeButton");
		LeaderboardsUITab.NativeFieldInfoPtr_WeekButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "WeekButton");
		LeaderboardsUITab.NativeFieldInfoPtr_TodayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "TodayButton");
		LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "SubmitScoreButton");
		LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "SubmitScoreLabel");
		LeaderboardsUITab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "ConnectionDependedntButtons");
		LeaderboardsUITab.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "lines");
		LeaderboardsUITab.NativeFieldInfoPtr_loadedLeaderBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "loadedLeaderBoard");
		LeaderboardsUITab.NativeFieldInfoPtr_displayCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "displayCollection");
		LeaderboardsUITab.NativeFieldInfoPtr_displayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "displayTime");
		LeaderboardsUITab.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, "score");
		LeaderboardsUITab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665867);
		LeaderboardsUITab.NativeMethodInfoPtr_LoadScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665868);
		LeaderboardsUITab.NativeMethodInfoPtr_OpenUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665869);
		LeaderboardsUITab.NativeMethodInfoPtr_ShowGlobal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665870);
		LeaderboardsUITab.NativeMethodInfoPtr_ShowLocal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665871);
		LeaderboardsUITab.NativeMethodInfoPtr_ShowAllTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665872);
		LeaderboardsUITab.NativeMethodInfoPtr_ShowWeek_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665873);
		LeaderboardsUITab.NativeMethodInfoPtr_ShowDay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665874);
		LeaderboardsUITab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665875);
		LeaderboardsUITab.NativeMethodInfoPtr_UpdateScoresDisaplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665876);
		LeaderboardsUITab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665877);
		LeaderboardsUITab.NativeMethodInfoPtr_SubmitScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665878);
		LeaderboardsUITab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665879);
		LeaderboardsUITab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665880);
		LeaderboardsUITab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665881);
		LeaderboardsUITab.NativeMethodInfoPtr_ActionScoreRequestReceived_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665882);
		LeaderboardsUITab.NativeMethodInfoPtr_OnScoreSbumitted_Private_Void_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665883);
		LeaderboardsUITab.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665884);
		LeaderboardsUITab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665885);
		LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665886);
		LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665887);
		LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_2_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665888);
		LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665889);
		LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_4_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr, 100665890);
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00060ABC File Offset: 0x0005ECBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189825, XrefRangeEnd = 189940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00060AF0 File Offset: 0x0005ECF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189940, XrefRangeEnd = 189949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_LoadScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x00060B24 File Offset: 0x0005ED24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189949, XrefRangeEnd = 189959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OpenUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00060B58 File Offset: 0x0005ED58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189959, XrefRangeEnd = 189960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowGlobal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ShowGlobal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00060B8C File Offset: 0x0005ED8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189960, XrefRangeEnd = 189961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ShowLocal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00060BC0 File Offset: 0x0005EDC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189961, XrefRangeEnd = 189962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAllTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ShowAllTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00060BF4 File Offset: 0x0005EDF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189962, XrefRangeEnd = 189963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowWeek()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ShowWeek_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00060C28 File Offset: 0x0005EE28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189963, XrefRangeEnd = 189964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowDay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ShowDay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00060C5C File Offset: 0x0005EE5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189964, XrefRangeEnd = 189998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00060C90 File Offset: 0x0005EE90
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 190035, RefRangeEnd = 190046, XrefRangeStart = 189998, XrefRangeEnd = 190035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateScoresDisaplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_UpdateScoresDisaplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00060CC4 File Offset: 0x0005EEC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190046, XrefRangeEnd = 190120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00060CF8 File Offset: 0x0005EEF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190120, XrefRangeEnd = 190136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_SubmitScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00060D2C File Offset: 0x0005EF2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190136, XrefRangeEnd = 190141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00060D60 File Offset: 0x0005EF60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190141, XrefRangeEnd = 190151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00060D94 File Offset: 0x0005EF94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190151, XrefRangeEnd = 190167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x00060DD8 File Offset: 0x0005EFD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190167, XrefRangeEnd = 190231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionScoreRequestReceived(GooglePlayResult obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_ActionScoreRequestReceived_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00060E1C File Offset: 0x0005F01C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190231, XrefRangeEnd = 190244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreSbumitted(GP_LeaderboardResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OnScoreSbumitted_Private_Void_GP_LeaderboardResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x00060E60 File Offset: 0x0005F060
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190244, XrefRangeEnd = 190288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x00060E94 File Offset: 0x0005F094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190288, XrefRangeEnd = 190289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeaderboardsUITab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsUITab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00060ED0 File Offset: 0x0005F0D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190289, XrefRangeEnd = 190290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__20_0(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00060F10 File Offset: 0x0005F110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190290, XrefRangeEnd = 190291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__20_1(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00060F50 File Offset: 0x0005F150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190291, XrefRangeEnd = 190292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__20_2(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_2_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x00060F90 File Offset: 0x0005F190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190292, XrefRangeEnd = 190293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__20_3(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00060FD0 File Offset: 0x0005F1D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190293, XrefRangeEnd = 190294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__20_4(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsUITab.NativeMethodInfoPtr__Start_b__20_4_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x0000A6D8 File Offset: 0x000088D8
	public LeaderboardsUITab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x06001568 RID: 5480 RVA: 0x00061010 File Offset: 0x0005F210
	// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000A6E1 File Offset: 0x000088E1
	public unsafe static string LEADERBOARD_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeaderboardsUITab.NativeFieldInfoPtr_LEADERBOARD_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeaderboardsUITab.NativeFieldInfoPtr_LEADERBOARD_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x0600156A RID: 5482 RVA: 0x00061030 File Offset: 0x0005F230
	// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000A6F3 File Offset: 0x000088F3
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x0600156C RID: 5484 RVA: 0x00061060 File Offset: 0x0005F260
	// (set) Token: 0x0600156D RID: 5485 RVA: 0x0000A712 File Offset: 0x00008912
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x0600156E RID: 5486 RVA: 0x00061090 File Offset: 0x0005F290
	// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000A731 File Offset: 0x00008931
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x06001570 RID: 5488 RVA: 0x000610C0 File Offset: 0x0005F2C0
	// (set) Token: 0x06001571 RID: 5489 RVA: 0x0000A750 File Offset: 0x00008950
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x06001572 RID: 5490 RVA: 0x000610F0 File Offset: 0x0005F2F0
	// (set) Token: 0x06001573 RID: 5491 RVA: 0x0000A76F File Offset: 0x0000896F
	public unsafe Text connectButtonLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_connectButtonLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_connectButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x06001574 RID: 5492 RVA: 0x00061120 File Offset: 0x0005F320
	// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000A78E File Offset: 0x0000898E
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x06001576 RID: 5494 RVA: 0x00061150 File Offset: 0x0005F350
	// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000A7AD File Offset: 0x000089AD
	public unsafe Toggle GlobalButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_GlobalButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_GlobalButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x06001578 RID: 5496 RVA: 0x00061180 File Offset: 0x0005F380
	// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000A7CC File Offset: 0x000089CC
	public unsafe Toggle FriendsButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_FriendsButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_FriendsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x0600157A RID: 5498 RVA: 0x000611B0 File Offset: 0x0005F3B0
	// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000A7EB File Offset: 0x000089EB
	public unsafe Toggle AllTimeButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_AllTimeButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_AllTimeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x0600157C RID: 5500 RVA: 0x000611E0 File Offset: 0x0005F3E0
	// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000A80A File Offset: 0x00008A0A
	public unsafe Toggle WeekButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_WeekButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_WeekButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x0600157E RID: 5502 RVA: 0x00061210 File Offset: 0x0005F410
	// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000A829 File Offset: 0x00008A29
	public unsafe Toggle TodayButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_TodayButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_TodayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x06001580 RID: 5504 RVA: 0x00061240 File Offset: 0x0005F440
	// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000A848 File Offset: 0x00008A48
	public unsafe Button SubmitScoreButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x06001582 RID: 5506 RVA: 0x00061270 File Offset: 0x0005F470
	// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000A867 File Offset: 0x00008A67
	public unsafe Text SubmitScoreLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_SubmitScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x000612A0 File Offset: 0x0005F4A0
	// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000A886 File Offset: 0x00008A86
	public unsafe Il2CppReferenceArray<Selectable> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x06001586 RID: 5510 RVA: 0x000612D0 File Offset: 0x0005F4D0
	// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000A8A5 File Offset: 0x00008AA5
	public unsafe Il2CppReferenceArray<LeaderboardInfoPresenter> lines
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_lines);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LeaderboardInfoPresenter>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_lines), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x06001588 RID: 5512 RVA: 0x00061300 File Offset: 0x0005F500
	// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000A8C4 File Offset: 0x00008AC4
	public unsafe GPLeaderBoard loadedLeaderBoard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_loadedLeaderBoard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPLeaderBoard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_loadedLeaderBoard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x0600158A RID: 5514 RVA: 0x00061330 File Offset: 0x0005F530
	// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000A8E3 File Offset: 0x00008AE3
	public unsafe GPCollectionType displayCollection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_displayCollection);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_displayCollection)) = value;
		}
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x0600158C RID: 5516 RVA: 0x00061358 File Offset: 0x0005F558
	// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000A8FE File Offset: 0x00008AFE
	public unsafe GPBoardTimeSpan displayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_displayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_displayTime)) = value;
		}
	}

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x0600158E RID: 5518 RVA: 0x00061380 File Offset: 0x0005F580
	// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000A919 File Offset: 0x00008B19
	public unsafe int score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_score);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsUITab.NativeFieldInfoPtr_score)) = value;
		}
	}

	// Token: 0x04001029 RID: 4137
	private static readonly IntPtr NativeFieldInfoPtr_LEADERBOARD_ID;

	// Token: 0x0400102A RID: 4138
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x0400102B RID: 4139
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x0400102C RID: 4140
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x0400102D RID: 4141
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x0400102E RID: 4142
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonLabel;

	// Token: 0x0400102F RID: 4143
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04001030 RID: 4144
	private static readonly IntPtr NativeFieldInfoPtr_GlobalButton;

	// Token: 0x04001031 RID: 4145
	private static readonly IntPtr NativeFieldInfoPtr_FriendsButton;

	// Token: 0x04001032 RID: 4146
	private static readonly IntPtr NativeFieldInfoPtr_AllTimeButton;

	// Token: 0x04001033 RID: 4147
	private static readonly IntPtr NativeFieldInfoPtr_WeekButton;

	// Token: 0x04001034 RID: 4148
	private static readonly IntPtr NativeFieldInfoPtr_TodayButton;

	// Token: 0x04001035 RID: 4149
	private static readonly IntPtr NativeFieldInfoPtr_SubmitScoreButton;

	// Token: 0x04001036 RID: 4150
	private static readonly IntPtr NativeFieldInfoPtr_SubmitScoreLabel;

	// Token: 0x04001037 RID: 4151
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04001038 RID: 4152
	private static readonly IntPtr NativeFieldInfoPtr_lines;

	// Token: 0x04001039 RID: 4153
	private static readonly IntPtr NativeFieldInfoPtr_loadedLeaderBoard;

	// Token: 0x0400103A RID: 4154
	private static readonly IntPtr NativeFieldInfoPtr_displayCollection;

	// Token: 0x0400103B RID: 4155
	private static readonly IntPtr NativeFieldInfoPtr_displayTime;

	// Token: 0x0400103C RID: 4156
	private static readonly IntPtr NativeFieldInfoPtr_score;

	// Token: 0x0400103D RID: 4157
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400103E RID: 4158
	private static readonly IntPtr NativeMethodInfoPtr_LoadScore_Public_Void_0;

	// Token: 0x0400103F RID: 4159
	private static readonly IntPtr NativeMethodInfoPtr_OpenUI_Public_Void_0;

	// Token: 0x04001040 RID: 4160
	private static readonly IntPtr NativeMethodInfoPtr_ShowGlobal_Public_Void_0;

	// Token: 0x04001041 RID: 4161
	private static readonly IntPtr NativeMethodInfoPtr_ShowLocal_Public_Void_0;

	// Token: 0x04001042 RID: 4162
	private static readonly IntPtr NativeMethodInfoPtr_ShowAllTime_Public_Void_0;

	// Token: 0x04001043 RID: 4163
	private static readonly IntPtr NativeMethodInfoPtr_ShowWeek_Public_Void_0;

	// Token: 0x04001044 RID: 4164
	private static readonly IntPtr NativeMethodInfoPtr_ShowDay_Public_Void_0;

	// Token: 0x04001045 RID: 4165
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x04001046 RID: 4166
	private static readonly IntPtr NativeMethodInfoPtr_UpdateScoresDisaplay_Private_Void_0;

	// Token: 0x04001047 RID: 4167
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04001048 RID: 4168
	private static readonly IntPtr NativeMethodInfoPtr_SubmitScore_Public_Void_0;

	// Token: 0x04001049 RID: 4169
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x0400104A RID: 4170
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x0400104B RID: 4171
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x0400104C RID: 4172
	private static readonly IntPtr NativeMethodInfoPtr_ActionScoreRequestReceived_Private_Void_GooglePlayResult_0;

	// Token: 0x0400104D RID: 4173
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreSbumitted_Private_Void_GP_LeaderboardResult_0;

	// Token: 0x0400104E RID: 4174
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400104F RID: 4175
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04001050 RID: 4176
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_0_Private_Void_Boolean_0;

	// Token: 0x04001051 RID: 4177
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_1_Private_Void_Boolean_0;

	// Token: 0x04001052 RID: 4178
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_2_Private_Void_Boolean_0;

	// Token: 0x04001053 RID: 4179
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_3_Private_Void_Boolean_0;

	// Token: 0x04001054 RID: 4180
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_4_Private_Void_Boolean_0;
}
