using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200011A RID: 282
public class TBM_Game_Example : AndroidNativeExampleBase
{
	// Token: 0x06001359 RID: 4953 RVA: 0x00059C84 File Offset: 0x00057E84
	// Note: this type is marked as 'beforefieldinit'.
	static TBM_Game_Example()
	{
		Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TBM_Game_Example");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr);
		TBM_Game_Example.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "avatar");
		TBM_Game_Example.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "hi");
		TBM_Game_Example.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "playerLabel");
		TBM_Game_Example.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "gameState");
		TBM_Game_Example.NativeFieldInfoPtr_parisipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "parisipants");
		TBM_Game_Example.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "connectButton");
		TBM_Game_Example.NativeFieldInfoPtr_helloButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "helloButton");
		TBM_Game_Example.NativeFieldInfoPtr_leaveRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "leaveRoomButton");
		TBM_Game_Example.NativeFieldInfoPtr_showRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "showRoomButton");
		TBM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "ConnectionDependedntButtons");
		TBM_Game_Example.NativeFieldInfoPtr_patrisipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, "patrisipants");
		TBM_Game_Example.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665620);
		TBM_Game_Example.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665621);
		TBM_Game_Example.NativeMethodInfoPtr_ActionMatchUpdated_Private_Void_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665622);
		TBM_Game_Example.NativeMethodInfoPtr_InitTBM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665623);
		TBM_Game_Example.NativeMethodInfoPtr_ShowInboxUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665624);
		TBM_Game_Example.NativeMethodInfoPtr_FinishMathc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665625);
		TBM_Game_Example.NativeMethodInfoPtr_findMatch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665626);
		TBM_Game_Example.NativeMethodInfoPtr_ActionMatchCreationCanceled_Private_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665627);
		TBM_Game_Example.NativeMethodInfoPtr_ActionMatchInitiated_Private_Void_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665628);
		TBM_Game_Example.NativeMethodInfoPtr_LoadAllMatchersInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665629);
		TBM_Game_Example.NativeMethodInfoPtr_LoadActiveMatchesInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665630);
		TBM_Game_Example.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665631);
		TBM_Game_Example.NativeMethodInfoPtr_DrawParticipants_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665632);
		TBM_Game_Example.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665633);
		TBM_Game_Example.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665634);
		TBM_Game_Example.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665635);
		TBM_Game_Example.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665636);
		TBM_Game_Example.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr, 100665637);
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00059EF8 File Offset: 0x000580F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184352, XrefRangeEnd = 184408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x00059F2C File Offset: 0x0005812C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184408, XrefRangeEnd = 184420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00059F60 File Offset: 0x00058160
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionMatchUpdated(GP_TBM_UpdateMatchResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_ActionMatchUpdated_Private_Void_GP_TBM_UpdateMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00059FA4 File Offset: 0x000581A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184420, XrefRangeEnd = 184434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTBM()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_InitTBM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00059FD8 File Offset: 0x000581D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184434, XrefRangeEnd = 184442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInboxUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_ShowInboxUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0005A00C File Offset: 0x0005820C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishMathc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_FinishMathc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x0005A040 File Offset: 0x00058240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184442, XrefRangeEnd = 184470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findMatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_findMatch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0005A074 File Offset: 0x00058274
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionMatchCreationCanceled(AndroidActivityResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_ActionMatchCreationCanceled_Private_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0005A0B8 File Offset: 0x000582B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184470, XrefRangeEnd = 184482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionMatchInitiated(GP_TBM_MatchInitiatedResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_ActionMatchInitiated_Private_Void_GP_TBM_MatchInitiatedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0005A0FC File Offset: 0x000582FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184482, XrefRangeEnd = 184490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllMatchersInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_LoadAllMatchersInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0005A130 File Offset: 0x00058330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184490, XrefRangeEnd = 184505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadActiveMatchesInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_LoadActiveMatchesInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0005A164 File Offset: 0x00058364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184505, XrefRangeEnd = 184539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x0005A198 File Offset: 0x00058398
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawParticipants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_DrawParticipants_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x0005A1CC File Offset: 0x000583CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184539, XrefRangeEnd = 184577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0005A200 File Offset: 0x00058400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184577, XrefRangeEnd = 184583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x0005A234 File Offset: 0x00058434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184583, XrefRangeEnd = 184594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x0005A268 File Offset: 0x00058468
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184594, XrefRangeEnd = 184610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0005A2AC File Offset: 0x000584AC
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TBM_Game_Example()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TBM_Game_Example>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TBM_Game_Example.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00009954 File Offset: 0x00007B54
	public TBM_Game_Example(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x0600136D RID: 4973 RVA: 0x0005A2E8 File Offset: 0x000584E8
	// (set) Token: 0x0600136E RID: 4974 RVA: 0x0000995D File Offset: 0x00007B5D
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x0600136F RID: 4975 RVA: 0x0005A318 File Offset: 0x00058518
	// (set) Token: 0x06001370 RID: 4976 RVA: 0x0000997C File Offset: 0x00007B7C
	public unsafe GameObject hi
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_hi);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_hi), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x06001371 RID: 4977 RVA: 0x0005A348 File Offset: 0x00058548
	// (set) Token: 0x06001372 RID: 4978 RVA: 0x0000999B File Offset: 0x00007B9B
	public unsafe SA_Label playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x06001373 RID: 4979 RVA: 0x0005A378 File Offset: 0x00058578
	// (set) Token: 0x06001374 RID: 4980 RVA: 0x000099BA File Offset: 0x00007BBA
	public unsafe SA_Label gameState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_gameState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_gameState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x06001375 RID: 4981 RVA: 0x0005A3A8 File Offset: 0x000585A8
	// (set) Token: 0x06001376 RID: 4982 RVA: 0x000099D9 File Offset: 0x00007BD9
	public unsafe SA_Label parisipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_parisipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_parisipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x06001377 RID: 4983 RVA: 0x0005A3D8 File Offset: 0x000585D8
	// (set) Token: 0x06001378 RID: 4984 RVA: 0x000099F8 File Offset: 0x00007BF8
	public unsafe DefaultPreviewButton connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x06001379 RID: 4985 RVA: 0x0005A408 File Offset: 0x00058608
	// (set) Token: 0x0600137A RID: 4986 RVA: 0x00009A17 File Offset: 0x00007C17
	public unsafe DefaultPreviewButton helloButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_helloButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_helloButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x0600137B RID: 4987 RVA: 0x0005A438 File Offset: 0x00058638
	// (set) Token: 0x0600137C RID: 4988 RVA: 0x00009A36 File Offset: 0x00007C36
	public unsafe DefaultPreviewButton leaveRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_leaveRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_leaveRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x0600137D RID: 4989 RVA: 0x0005A468 File Offset: 0x00058668
	// (set) Token: 0x0600137E RID: 4990 RVA: 0x00009A55 File Offset: 0x00007C55
	public unsafe DefaultPreviewButton showRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_showRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_showRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x0600137F RID: 4991 RVA: 0x0005A498 File Offset: 0x00058698
	// (set) Token: 0x06001380 RID: 4992 RVA: 0x00009A74 File Offset: 0x00007C74
	public unsafe Il2CppReferenceArray<DefaultPreviewButton> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DefaultPreviewButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x06001381 RID: 4993 RVA: 0x0005A4C8 File Offset: 0x000586C8
	// (set) Token: 0x06001382 RID: 4994 RVA: 0x00009A93 File Offset: 0x00007C93
	public unsafe Il2CppReferenceArray<SA_PartisipantUI> patrisipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_patrisipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SA_PartisipantUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TBM_Game_Example.NativeFieldInfoPtr_patrisipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000EC5 RID: 3781
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000EC6 RID: 3782
	private static readonly IntPtr NativeFieldInfoPtr_hi;

	// Token: 0x04000EC7 RID: 3783
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04000EC8 RID: 3784
	private static readonly IntPtr NativeFieldInfoPtr_gameState;

	// Token: 0x04000EC9 RID: 3785
	private static readonly IntPtr NativeFieldInfoPtr_parisipants;

	// Token: 0x04000ECA RID: 3786
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04000ECB RID: 3787
	private static readonly IntPtr NativeFieldInfoPtr_helloButton;

	// Token: 0x04000ECC RID: 3788
	private static readonly IntPtr NativeFieldInfoPtr_leaveRoomButton;

	// Token: 0x04000ECD RID: 3789
	private static readonly IntPtr NativeFieldInfoPtr_showRoomButton;

	// Token: 0x04000ECE RID: 3790
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04000ECF RID: 3791
	private static readonly IntPtr NativeFieldInfoPtr_patrisipants;

	// Token: 0x04000ED0 RID: 3792
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000ED1 RID: 3793
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x04000ED2 RID: 3794
	private static readonly IntPtr NativeMethodInfoPtr_ActionMatchUpdated_Private_Void_GP_TBM_UpdateMatchResult_0;

	// Token: 0x04000ED3 RID: 3795
	private static readonly IntPtr NativeMethodInfoPtr_InitTBM_Public_Void_0;

	// Token: 0x04000ED4 RID: 3796
	private static readonly IntPtr NativeMethodInfoPtr_ShowInboxUI_Public_Void_0;

	// Token: 0x04000ED5 RID: 3797
	private static readonly IntPtr NativeMethodInfoPtr_FinishMathc_Public_Void_0;

	// Token: 0x04000ED6 RID: 3798
	private static readonly IntPtr NativeMethodInfoPtr_findMatch_Public_Void_0;

	// Token: 0x04000ED7 RID: 3799
	private static readonly IntPtr NativeMethodInfoPtr_ActionMatchCreationCanceled_Private_Void_AndroidActivityResult_0;

	// Token: 0x04000ED8 RID: 3800
	private static readonly IntPtr NativeMethodInfoPtr_ActionMatchInitiated_Private_Void_GP_TBM_MatchInitiatedResult_0;

	// Token: 0x04000ED9 RID: 3801
	private static readonly IntPtr NativeMethodInfoPtr_LoadAllMatchersInfo_Public_Void_0;

	// Token: 0x04000EDA RID: 3802
	private static readonly IntPtr NativeMethodInfoPtr_LoadActiveMatchesInfo_Public_Void_0;

	// Token: 0x04000EDB RID: 3803
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0;

	// Token: 0x04000EDC RID: 3804
	private static readonly IntPtr NativeMethodInfoPtr_DrawParticipants_Private_Void_0;

	// Token: 0x04000EDD RID: 3805
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000EDE RID: 3806
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x04000EDF RID: 3807
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x04000EE0 RID: 3808
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x04000EE1 RID: 3809
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
