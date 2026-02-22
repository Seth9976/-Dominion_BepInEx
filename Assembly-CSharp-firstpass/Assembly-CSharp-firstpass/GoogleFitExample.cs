using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;
using SA.Fitness;
using UnityEngine;

// Token: 0x02000129 RID: 297
public class GoogleFitExample : AndroidNativeExampleBase
{
	// Token: 0x0600148F RID: 5263 RVA: 0x0005E0D8 File Offset: 0x0005C2D8
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleFitExample()
	{
		Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleFitExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr);
		GoogleFitExample.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "avatar");
		GoogleFitExample.NativeFieldInfoPtr_pieIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "pieIcon");
		GoogleFitExample.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "connectButton");
		GoogleFitExample.NativeFieldInfoPtr_scoreSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "scoreSubmit");
		GoogleFitExample.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "playerLabel");
		GoogleFitExample.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "ConnectionDependedntButtons");
		GoogleFitExample.NativeFieldInfoPtr_a_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_id");
		GoogleFitExample.NativeFieldInfoPtr_a_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_name");
		GoogleFitExample.NativeFieldInfoPtr_a_descr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_descr");
		GoogleFitExample.NativeFieldInfoPtr_a_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_type");
		GoogleFitExample.NativeFieldInfoPtr_a_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_state");
		GoogleFitExample.NativeFieldInfoPtr_a_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_steps");
		GoogleFitExample.NativeFieldInfoPtr_a_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "a_total");
		GoogleFitExample.NativeFieldInfoPtr_b_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "b_id");
		GoogleFitExample.NativeFieldInfoPtr_b_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "b_name");
		GoogleFitExample.NativeFieldInfoPtr_b_all_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "b_all_time");
		GoogleFitExample.NativeFieldInfoPtr_dataSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "dataSources");
		GoogleFitExample.NativeFieldInfoPtr_SESSION_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, "SESSION_ID");
		GoogleFitExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665790);
		GoogleFitExample.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665791);
		GoogleFitExample.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665792);
		GoogleFitExample.NativeMethodInfoPtr_requestSensors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665793);
		GoogleFitExample.NativeMethodInfoPtr_registerSensorsListeners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665794);
		GoogleFitExample.NativeMethodInfoPtr_listSubscriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665795);
		GoogleFitExample.NativeMethodInfoPtr_subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665796);
		GoogleFitExample.NativeMethodInfoPtr_unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665797);
		GoogleFitExample.NativeMethodInfoPtr_readSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665798);
		GoogleFitExample.NativeMethodInfoPtr_insertSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665799);
		GoogleFitExample.NativeMethodInfoPtr_startSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665800);
		GoogleFitExample.NativeMethodInfoPtr_stopSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665801);
		GoogleFitExample.NativeMethodInfoPtr_readData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665802);
		GoogleFitExample.NativeMethodInfoPtr_readDailyTotal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665803);
		GoogleFitExample.NativeMethodInfoPtr_insertData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665804);
		GoogleFitExample.NativeMethodInfoPtr_updateData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665805);
		GoogleFitExample.NativeMethodInfoPtr_deleteData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665806);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnReadHistoryFinished_Private_Void_ReadHistoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665807);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnReadDailyTotalRequestFinished_Private_Void_ReadDailyTotalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665808);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionReadFinished_Private_Void_ReadSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665809);
		GoogleFitExample.NativeMethodInfoPtr_SA_Fitness_Connection_Instance_OnConnectionFinished_Private_Void_ConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665810);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnRequestFinished_Private_Void_SensorRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665811);
		GoogleFitExample.NativeMethodInfoPtr_Listener_OnRegisterSuccess_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665812);
		GoogleFitExample.NativeMethodInfoPtr_Listener_OnRegisterFail_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665813);
		GoogleFitExample.NativeMethodInfoPtr_Listener_OnDataPointReceived_Private_Void_Int32_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665814);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnRequestFinished1_Private_Void_SubscriptionsRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665815);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnSubscribeFinished_Private_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665816);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnUnsubscribeFinished_Private_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665817);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionStarted_Private_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665818);
		GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionStopped_Private_Void_StopSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665819);
		GoogleFitExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr, 100665820);
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x0005E4DC File Offset: 0x0005C6DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187613, XrefRangeEnd = 187618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x0005E510 File Offset: 0x0005C710
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187628, RefRangeEnd = 187630, XrefRangeStart = 187618, XrefRangeEnd = 187628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x0005E544 File Offset: 0x0005C744
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187630, XrefRangeEnd = 187703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x0005E578 File Offset: 0x0005C778
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187703, XrefRangeEnd = 187737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestSensors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_requestSensors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x0005E5AC File Offset: 0x0005C7AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187737, XrefRangeEnd = 187807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void registerSensorsListeners()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_registerSensorsListeners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x0005E5E0 File Offset: 0x0005C7E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187807, XrefRangeEnd = 187828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void listSubscriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_listSubscriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x0005E614 File Offset: 0x0005C814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187828, XrefRangeEnd = 187854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void subscribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x0005E648 File Offset: 0x0005C848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187854, XrefRangeEnd = 187880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void unsubscribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x0005E67C File Offset: 0x0005C87C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187880, XrefRangeEnd = 187923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readSession()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_readSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187923, XrefRangeEnd = 187931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void insertSession()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_insertSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x0005E6E4 File Offset: 0x0005C8E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187931, XrefRangeEnd = 187974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startSession()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_startSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x0005E718 File Offset: 0x0005C918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187974, XrefRangeEnd = 187998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void stopSession()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_stopSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x0005E74C File Offset: 0x0005C94C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187998, XrefRangeEnd = 188039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_readData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x0005E780 File Offset: 0x0005C980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188039, XrefRangeEnd = 188065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readDailyTotal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_readDailyTotal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188065, XrefRangeEnd = 188073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void insertData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_insertData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x0005E7E8 File Offset: 0x0005C9E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188073, XrefRangeEnd = 188081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_updateData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x0005E81C File Offset: 0x0005CA1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188081, XrefRangeEnd = 188089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void deleteData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_deleteData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0005E850 File Offset: 0x0005CA50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188089, XrefRangeEnd = 188315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnReadHistoryFinished(ReadHistoryResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnReadHistoryFinished_Private_Void_ReadHistoryResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x0005E894 File Offset: 0x0005CA94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188315, XrefRangeEnd = 188397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnReadDailyTotalRequestFinished(ReadDailyTotalResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnReadDailyTotalRequestFinished_Private_Void_ReadDailyTotalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x0005E8D8 File Offset: 0x0005CAD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188397, XrefRangeEnd = 188576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnSessionReadFinished(ReadSessionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionReadFinished_Private_Void_ReadSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x0005E91C File Offset: 0x0005CB1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188576, XrefRangeEnd = 188611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SA_Fitness_Connection_Instance_OnConnectionFinished(ConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_SA_Fitness_Connection_Instance_OnConnectionFinished_Private_Void_ConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x0005E960 File Offset: 0x0005CB60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188611, XrefRangeEnd = 188620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnRequestFinished(SensorRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnRequestFinished_Private_Void_SensorRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188620, XrefRangeEnd = 188628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Listener_OnRegisterSuccess(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Listener_OnRegisterSuccess_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188628, XrefRangeEnd = 188636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Listener_OnRegisterFail(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Listener_OnRegisterFail_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x0005EA24 File Offset: 0x0005CC24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188636, XrefRangeEnd = 188680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Listener_OnDataPointReceived(int id, DataPoint dataPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataPoint);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Listener_OnDataPointReceived_Private_Void_Int32_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0005EA74 File Offset: 0x0005CC74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188680, XrefRangeEnd = 188710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnRequestFinished1(SubscriptionsRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnRequestFinished1_Private_Void_SubscriptionsRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188710, XrefRangeEnd = 188719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnSubscribeFinished(Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnSubscribeFinished_Private_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x0005EAFC File Offset: 0x0005CCFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188719, XrefRangeEnd = 188728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnUnsubscribeFinished(Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnUnsubscribeFinished_Private_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x0005EB40 File Offset: 0x0005CD40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188728, XrefRangeEnd = 188737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnSessionStarted(Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionStarted_Private_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x0005EB84 File Offset: 0x0005CD84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188737, XrefRangeEnd = 188813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Request_OnSessionStopped(StopSessionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr_Request_OnSessionStopped_Private_Void_StopSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x0005EBC8 File Offset: 0x0005CDC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188813, XrefRangeEnd = 188820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleFitExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFitExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFitExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0000A078 File Offset: 0x00008278
	public GoogleFitExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0005EC04 File Offset: 0x0005CE04
	// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0000A081 File Offset: 0x00008281
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0005EC34 File Offset: 0x0005CE34
	// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0000A0A0 File Offset: 0x000082A0
	public unsafe Texture2D pieIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_pieIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_pieIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0005EC64 File Offset: 0x0005CE64
	// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0000A0BF File Offset: 0x000082BF
	public unsafe DefaultPreviewButton connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0005EC94 File Offset: 0x0005CE94
	// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0000A0DE File Offset: 0x000082DE
	public unsafe DefaultPreviewButton scoreSubmit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_scoreSubmit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_scoreSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0005ECC4 File Offset: 0x0005CEC4
	// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0000A0FD File Offset: 0x000082FD
	public unsafe SA_Label playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x060014BA RID: 5306 RVA: 0x0005ECF4 File Offset: 0x0005CEF4
	// (set) Token: 0x060014BB RID: 5307 RVA: 0x0000A11C File Offset: 0x0000831C
	public unsafe Il2CppReferenceArray<DefaultPreviewButton> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DefaultPreviewButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x060014BC RID: 5308 RVA: 0x0005ED24 File Offset: 0x0005CF24
	// (set) Token: 0x060014BD RID: 5309 RVA: 0x0000A13B File Offset: 0x0000833B
	public unsafe SA_Label a_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x060014BE RID: 5310 RVA: 0x0005ED54 File Offset: 0x0005CF54
	// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000A15A File Offset: 0x0000835A
	public unsafe SA_Label a_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005ED RID: 1517
	// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0005ED84 File Offset: 0x0005CF84
	// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000A179 File Offset: 0x00008379
	public unsafe SA_Label a_descr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_descr);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_descr), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0005EDB4 File Offset: 0x0005CFB4
	// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0000A198 File Offset: 0x00008398
	public unsafe SA_Label a_type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_type);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_type), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
	// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000A1B7 File Offset: 0x000083B7
	public unsafe SA_Label a_state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_state);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_state), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0005EE14 File Offset: 0x0005D014
	// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0000A1D6 File Offset: 0x000083D6
	public unsafe SA_Label a_steps
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_steps);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_steps), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0005EE44 File Offset: 0x0005D044
	// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0000A1F5 File Offset: 0x000083F5
	public unsafe SA_Label a_total
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_total);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_a_total), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x060014CA RID: 5322 RVA: 0x0005EE74 File Offset: 0x0005D074
	// (set) Token: 0x060014CB RID: 5323 RVA: 0x0000A214 File Offset: 0x00008414
	public unsafe SA_Label b_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x060014CC RID: 5324 RVA: 0x0005EEA4 File Offset: 0x0005D0A4
	// (set) Token: 0x060014CD RID: 5325 RVA: 0x0000A233 File Offset: 0x00008433
	public unsafe SA_Label b_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x060014CE RID: 5326 RVA: 0x0005EED4 File Offset: 0x0005D0D4
	// (set) Token: 0x060014CF RID: 5327 RVA: 0x0000A252 File Offset: 0x00008452
	public unsafe SA_Label b_all_time
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_all_time);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_b_all_time), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0005EF04 File Offset: 0x0005D104
	// (set) Token: 0x060014D1 RID: 5329 RVA: 0x0000A271 File Offset: 0x00008471
	public unsafe List<DataSource> dataSources
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_dataSources);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSource>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFitExample.NativeFieldInfoPtr_dataSources), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0005EF34 File Offset: 0x0005D134
	// (set) Token: 0x060014D3 RID: 5331 RVA: 0x0000A290 File Offset: 0x00008490
	public unsafe static string SESSION_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleFitExample.NativeFieldInfoPtr_SESSION_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleFitExample.NativeFieldInfoPtr_SESSION_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000FA6 RID: 4006
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000FA7 RID: 4007
	private static readonly IntPtr NativeFieldInfoPtr_pieIcon;

	// Token: 0x04000FA8 RID: 4008
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04000FA9 RID: 4009
	private static readonly IntPtr NativeFieldInfoPtr_scoreSubmit;

	// Token: 0x04000FAA RID: 4010
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04000FAB RID: 4011
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04000FAC RID: 4012
	private static readonly IntPtr NativeFieldInfoPtr_a_id;

	// Token: 0x04000FAD RID: 4013
	private static readonly IntPtr NativeFieldInfoPtr_a_name;

	// Token: 0x04000FAE RID: 4014
	private static readonly IntPtr NativeFieldInfoPtr_a_descr;

	// Token: 0x04000FAF RID: 4015
	private static readonly IntPtr NativeFieldInfoPtr_a_type;

	// Token: 0x04000FB0 RID: 4016
	private static readonly IntPtr NativeFieldInfoPtr_a_state;

	// Token: 0x04000FB1 RID: 4017
	private static readonly IntPtr NativeFieldInfoPtr_a_steps;

	// Token: 0x04000FB2 RID: 4018
	private static readonly IntPtr NativeFieldInfoPtr_a_total;

	// Token: 0x04000FB3 RID: 4019
	private static readonly IntPtr NativeFieldInfoPtr_b_id;

	// Token: 0x04000FB4 RID: 4020
	private static readonly IntPtr NativeFieldInfoPtr_b_name;

	// Token: 0x04000FB5 RID: 4021
	private static readonly IntPtr NativeFieldInfoPtr_b_all_time;

	// Token: 0x04000FB6 RID: 4022
	private static readonly IntPtr NativeFieldInfoPtr_dataSources;

	// Token: 0x04000FB7 RID: 4023
	private static readonly IntPtr NativeFieldInfoPtr_SESSION_ID;

	// Token: 0x04000FB8 RID: 4024
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000FB9 RID: 4025
	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

	// Token: 0x04000FBA RID: 4026
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0;

	// Token: 0x04000FBB RID: 4027
	private static readonly IntPtr NativeMethodInfoPtr_requestSensors_Private_Void_0;

	// Token: 0x04000FBC RID: 4028
	private static readonly IntPtr NativeMethodInfoPtr_registerSensorsListeners_Private_Void_0;

	// Token: 0x04000FBD RID: 4029
	private static readonly IntPtr NativeMethodInfoPtr_listSubscriptions_Private_Void_0;

	// Token: 0x04000FBE RID: 4030
	private static readonly IntPtr NativeMethodInfoPtr_subscribe_Private_Void_0;

	// Token: 0x04000FBF RID: 4031
	private static readonly IntPtr NativeMethodInfoPtr_unsubscribe_Private_Void_0;

	// Token: 0x04000FC0 RID: 4032
	private static readonly IntPtr NativeMethodInfoPtr_readSession_Public_Void_0;

	// Token: 0x04000FC1 RID: 4033
	private static readonly IntPtr NativeMethodInfoPtr_insertSession_Public_Void_0;

	// Token: 0x04000FC2 RID: 4034
	private static readonly IntPtr NativeMethodInfoPtr_startSession_Public_Void_0;

	// Token: 0x04000FC3 RID: 4035
	private static readonly IntPtr NativeMethodInfoPtr_stopSession_Public_Void_0;

	// Token: 0x04000FC4 RID: 4036
	private static readonly IntPtr NativeMethodInfoPtr_readData_Public_Void_0;

	// Token: 0x04000FC5 RID: 4037
	private static readonly IntPtr NativeMethodInfoPtr_readDailyTotal_Public_Void_0;

	// Token: 0x04000FC6 RID: 4038
	private static readonly IntPtr NativeMethodInfoPtr_insertData_Public_Void_0;

	// Token: 0x04000FC7 RID: 4039
	private static readonly IntPtr NativeMethodInfoPtr_updateData_Public_Void_0;

	// Token: 0x04000FC8 RID: 4040
	private static readonly IntPtr NativeMethodInfoPtr_deleteData_Public_Void_0;

	// Token: 0x04000FC9 RID: 4041
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnReadHistoryFinished_Private_Void_ReadHistoryResult_0;

	// Token: 0x04000FCA RID: 4042
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnReadDailyTotalRequestFinished_Private_Void_ReadDailyTotalResult_0;

	// Token: 0x04000FCB RID: 4043
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnSessionReadFinished_Private_Void_ReadSessionResult_0;

	// Token: 0x04000FCC RID: 4044
	private static readonly IntPtr NativeMethodInfoPtr_SA_Fitness_Connection_Instance_OnConnectionFinished_Private_Void_ConnectionResult_0;

	// Token: 0x04000FCD RID: 4045
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnRequestFinished_Private_Void_SensorRequestResult_0;

	// Token: 0x04000FCE RID: 4046
	private static readonly IntPtr NativeMethodInfoPtr_Listener_OnRegisterSuccess_Private_Void_Int32_0;

	// Token: 0x04000FCF RID: 4047
	private static readonly IntPtr NativeMethodInfoPtr_Listener_OnRegisterFail_Private_Void_Int32_0;

	// Token: 0x04000FD0 RID: 4048
	private static readonly IntPtr NativeMethodInfoPtr_Listener_OnDataPointReceived_Private_Void_Int32_DataPoint_0;

	// Token: 0x04000FD1 RID: 4049
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnRequestFinished1_Private_Void_SubscriptionsRequestResult_0;

	// Token: 0x04000FD2 RID: 4050
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnSubscribeFinished_Private_Void_Result_0;

	// Token: 0x04000FD3 RID: 4051
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnUnsubscribeFinished_Private_Void_Result_0;

	// Token: 0x04000FD4 RID: 4052
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnSessionStarted_Private_Void_Result_0;

	// Token: 0x04000FD5 RID: 4053
	private static readonly IntPtr NativeMethodInfoPtr_Request_OnSessionStopped_Private_Void_StopSessionResult_0;

	// Token: 0x04000FD6 RID: 4054
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
