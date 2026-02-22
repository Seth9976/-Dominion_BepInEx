using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012E RID: 302
public class QuestsAndEventsTab : FeatureTab
{
	// Token: 0x060015A5 RID: 5541 RVA: 0x000616E0 File Offset: 0x0005F8E0
	// Note: this type is marked as 'beforefieldinit'.
	static QuestsAndEventsTab()
	{
		Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "QuestsAndEventsTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr);
		QuestsAndEventsTab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "avatar");
		QuestsAndEventsTab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "logo");
		QuestsAndEventsTab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "defaulttexture");
		QuestsAndEventsTab.NativeFieldInfoPtr_pieIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "pieIcon");
		QuestsAndEventsTab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "connectButton");
		QuestsAndEventsTab.NativeFieldInfoPtr_connectButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "connectButtonText");
		QuestsAndEventsTab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "playerLabel");
		QuestsAndEventsTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "ConnectionDependedntButtons");
		QuestsAndEventsTab.NativeFieldInfoPtr_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "EVENT_ID");
		QuestsAndEventsTab.NativeFieldInfoPtr_QUEST_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, "QUEST_ID");
		QuestsAndEventsTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665894);
		QuestsAndEventsTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665895);
		QuestsAndEventsTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665896);
		QuestsAndEventsTab.NativeMethodInfoPtr_LoadEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665897);
		QuestsAndEventsTab.NativeMethodInfoPtr_IncrementEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665898);
		QuestsAndEventsTab.NativeMethodInfoPtr_ShowAllQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665899);
		QuestsAndEventsTab.NativeMethodInfoPtr_ShowAcceptedQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665900);
		QuestsAndEventsTab.NativeMethodInfoPtr_ShowCompletedQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665901);
		QuestsAndEventsTab.NativeMethodInfoPtr_ShowOpenQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665902);
		QuestsAndEventsTab.NativeMethodInfoPtr_AcceptQuest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665903);
		QuestsAndEventsTab.NativeMethodInfoPtr_LoadQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665904);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnEventsLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665905);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsAccepted_Private_Void_GP_QuestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665906);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsCompleted_Private_Void_GP_QuestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665907);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665908);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665909);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665910);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665911);
		QuestsAndEventsTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665912);
		QuestsAndEventsTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr, 100665913);
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00061968 File Offset: 0x0005FB68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190328, XrefRangeEnd = 190420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x0006199C File Offset: 0x0005FB9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190420, XrefRangeEnd = 190454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x000619D0 File Offset: 0x0005FBD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190454, XrefRangeEnd = 190520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x00061A04 File Offset: 0x0005FC04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190520, XrefRangeEnd = 190528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_LoadEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00061A38 File Offset: 0x0005FC38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190528, XrefRangeEnd = 190538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_IncrementEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00061A6C File Offset: 0x0005FC6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190538, XrefRangeEnd = 190546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAllQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_ShowAllQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00061AA0 File Offset: 0x0005FCA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190546, XrefRangeEnd = 190559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAcceptedQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_ShowAcceptedQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00061AD4 File Offset: 0x0005FCD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190559, XrefRangeEnd = 190572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCompletedQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_ShowCompletedQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00061B08 File Offset: 0x0005FD08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190572, XrefRangeEnd = 190585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowOpenQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_ShowOpenQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00061B3C File Offset: 0x0005FD3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190585, XrefRangeEnd = 190595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_AcceptQuest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00061B70 File Offset: 0x0005FD70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190595, XrefRangeEnd = 190603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_LoadQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00061BA4 File Offset: 0x0005FDA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190603, XrefRangeEnd = 190661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEventsLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnEventsLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00061BE8 File Offset: 0x0005FDE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190661, XrefRangeEnd = 190675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnQuestsAccepted(GP_QuestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsAccepted_Private_Void_GP_QuestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00061C2C File Offset: 0x0005FE2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190675, XrefRangeEnd = 190696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnQuestsCompleted(GP_QuestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsCompleted_Private_Void_GP_QuestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00061C70 File Offset: 0x0005FE70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190696, XrefRangeEnd = 190749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnQuestsLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnQuestsLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00061CB4 File Offset: 0x0005FEB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190749, XrefRangeEnd = 190754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00061CE8 File Offset: 0x0005FEE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190754, XrefRangeEnd = 190764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00061D1C File Offset: 0x0005FF1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190764, XrefRangeEnd = 190780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00061D60 File Offset: 0x0005FF60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190780, XrefRangeEnd = 190805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00061D94 File Offset: 0x0005FF94
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuestsAndEventsTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestsAndEventsTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsAndEventsTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x0000AA35 File Offset: 0x00008C35
	public QuestsAndEventsTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x060015BB RID: 5563 RVA: 0x00061DD0 File Offset: 0x0005FFD0
	// (set) Token: 0x060015BC RID: 5564 RVA: 0x0000AA3E File Offset: 0x00008C3E
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x060015BD RID: 5565 RVA: 0x00061E00 File Offset: 0x00060000
	// (set) Token: 0x060015BE RID: 5566 RVA: 0x0000AA5D File Offset: 0x00008C5D
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x060015BF RID: 5567 RVA: 0x00061E30 File Offset: 0x00060030
	// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0000AA7C File Offset: 0x00008C7C
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00061E60 File Offset: 0x00060060
	// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0000AA9B File Offset: 0x00008C9B
	public unsafe Texture2D pieIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_pieIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_pieIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00061E90 File Offset: 0x00060090
	// (set) Token: 0x060015C4 RID: 5572 RVA: 0x0000AABA File Offset: 0x00008CBA
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00061EC0 File Offset: 0x000600C0
	// (set) Token: 0x060015C6 RID: 5574 RVA: 0x0000AAD9 File Offset: 0x00008CD9
	public unsafe Text connectButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_connectButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_connectButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00061EF0 File Offset: 0x000600F0
	// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000AAF8 File Offset: 0x00008CF8
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00061F20 File Offset: 0x00060120
	// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000AB17 File Offset: 0x00008D17
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestsAndEventsTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x060015CB RID: 5579 RVA: 0x00061F50 File Offset: 0x00060150
	// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000AB36 File Offset: 0x00008D36
	public unsafe static string EVENT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(QuestsAndEventsTab.NativeFieldInfoPtr_EVENT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(QuestsAndEventsTab.NativeFieldInfoPtr_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x060015CD RID: 5581 RVA: 0x00061F70 File Offset: 0x00060170
	// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000AB48 File Offset: 0x00008D48
	public unsafe static string QUEST_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(QuestsAndEventsTab.NativeFieldInfoPtr_QUEST_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(QuestsAndEventsTab.NativeFieldInfoPtr_QUEST_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04001060 RID: 4192
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04001061 RID: 4193
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x04001062 RID: 4194
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04001063 RID: 4195
	private static readonly IntPtr NativeFieldInfoPtr_pieIcon;

	// Token: 0x04001064 RID: 4196
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04001065 RID: 4197
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonText;

	// Token: 0x04001066 RID: 4198
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04001067 RID: 4199
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04001068 RID: 4200
	private static readonly IntPtr NativeFieldInfoPtr_EVENT_ID;

	// Token: 0x04001069 RID: 4201
	private static readonly IntPtr NativeFieldInfoPtr_QUEST_ID;

	// Token: 0x0400106A RID: 4202
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400106B RID: 4203
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x0400106C RID: 4204
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x0400106D RID: 4205
	private static readonly IntPtr NativeMethodInfoPtr_LoadEvents_Public_Void_0;

	// Token: 0x0400106E RID: 4206
	private static readonly IntPtr NativeMethodInfoPtr_IncrementEvent_Public_Void_0;

	// Token: 0x0400106F RID: 4207
	private static readonly IntPtr NativeMethodInfoPtr_ShowAllQuests_Public_Void_0;

	// Token: 0x04001070 RID: 4208
	private static readonly IntPtr NativeMethodInfoPtr_ShowAcceptedQuests_Public_Void_0;

	// Token: 0x04001071 RID: 4209
	private static readonly IntPtr NativeMethodInfoPtr_ShowCompletedQuests_Public_Void_0;

	// Token: 0x04001072 RID: 4210
	private static readonly IntPtr NativeMethodInfoPtr_ShowOpenQuests_Public_Void_0;

	// Token: 0x04001073 RID: 4211
	private static readonly IntPtr NativeMethodInfoPtr_AcceptQuest_Public_Void_0;

	// Token: 0x04001074 RID: 4212
	private static readonly IntPtr NativeMethodInfoPtr_LoadQuests_Public_Void_0;

	// Token: 0x04001075 RID: 4213
	private static readonly IntPtr NativeMethodInfoPtr_OnEventsLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x04001076 RID: 4214
	private static readonly IntPtr NativeMethodInfoPtr_OnQuestsAccepted_Private_Void_GP_QuestResult_0;

	// Token: 0x04001077 RID: 4215
	private static readonly IntPtr NativeMethodInfoPtr_OnQuestsCompleted_Private_Void_GP_QuestResult_0;

	// Token: 0x04001078 RID: 4216
	private static readonly IntPtr NativeMethodInfoPtr_OnQuestsLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x04001079 RID: 4217
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x0400107A RID: 4218
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x0400107B RID: 4219
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x0400107C RID: 4220
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400107D RID: 4221
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
