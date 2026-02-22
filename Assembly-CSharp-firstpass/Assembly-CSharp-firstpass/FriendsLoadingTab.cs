using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000128 RID: 296
public class FriendsLoadingTab : FeatureTab
{
	// Token: 0x06001473 RID: 5235 RVA: 0x0005DB90 File Offset: 0x0005BD90
	// Note: this type is marked as 'beforefieldinit'.
	static FriendsLoadingTab()
	{
		Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FriendsLoadingTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr);
		FriendsLoadingTab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "avatar");
		FriendsLoadingTab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "logo");
		FriendsLoadingTab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "playerLabel");
		FriendsLoadingTab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "connectButton");
		FriendsLoadingTab.NativeFieldInfoPtr_connectButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "connectButtonLabel");
		FriendsLoadingTab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "defaulttexture");
		FriendsLoadingTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "ConnectionDependedntButtons");
		FriendsLoadingTab.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, "rows");
		FriendsLoadingTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665780);
		FriendsLoadingTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665781);
		FriendsLoadingTab.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665782);
		FriendsLoadingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665783);
		FriendsLoadingTab.NativeMethodInfoPtr_LoadFriendsList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665784);
		FriendsLoadingTab.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665785);
		FriendsLoadingTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665786);
		FriendsLoadingTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665787);
		FriendsLoadingTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665788);
		FriendsLoadingTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr, 100665789);
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x0005DD28 File Offset: 0x0005BF28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187297, XrefRangeEnd = 187391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x0005DD5C File Offset: 0x0005BF5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187391, XrefRangeEnd = 187425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x0005DD90 File Offset: 0x0005BF90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187425, XrefRangeEnd = 187470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x0005DDC4 File Offset: 0x0005BFC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187470, XrefRangeEnd = 187536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x0005DDF8 File Offset: 0x0005BFF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187536, XrefRangeEnd = 187551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFriendsList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_LoadFriendsList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0005DE2C File Offset: 0x0005C02C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187551, XrefRangeEnd = 187582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFriendListLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x0005DE70 File Offset: 0x0005C070
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187582, XrefRangeEnd = 187587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x0005DEA4 File Offset: 0x0005C0A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187587, XrefRangeEnd = 187597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0005DED8 File Offset: 0x0005C0D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187597, XrefRangeEnd = 187613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x0005DF1C File Offset: 0x0005C11C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendsLoadingTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsLoadingTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsLoadingTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00009F77 File Offset: 0x00008177
	public FriendsLoadingTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005DF58 File Offset: 0x0005C158
	// (set) Token: 0x06001480 RID: 5248 RVA: 0x00009F80 File Offset: 0x00008180
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005DF88 File Offset: 0x0005C188
	// (set) Token: 0x06001482 RID: 5250 RVA: 0x00009F9F File Offset: 0x0000819F
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
	// (set) Token: 0x06001484 RID: 5252 RVA: 0x00009FBE File Offset: 0x000081BE
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005DFE8 File Offset: 0x0005C1E8
	// (set) Token: 0x06001486 RID: 5254 RVA: 0x00009FDD File Offset: 0x000081DD
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x06001487 RID: 5255 RVA: 0x0005E018 File Offset: 0x0005C218
	// (set) Token: 0x06001488 RID: 5256 RVA: 0x00009FFC File Offset: 0x000081FC
	public unsafe Text connectButtonLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_connectButtonLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_connectButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x06001489 RID: 5257 RVA: 0x0005E048 File Offset: 0x0005C248
	// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000A01B File Offset: 0x0000821B
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x0600148B RID: 5259 RVA: 0x0005E078 File Offset: 0x0005C278
	// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000A03A File Offset: 0x0000823A
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005E0A8 File Offset: 0x0005C2A8
	// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000A059 File Offset: 0x00008259
	public unsafe Il2CppReferenceArray<FriendInfoPresenter> rows
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_rows);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FriendInfoPresenter>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsLoadingTab.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F94 RID: 3988
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000F95 RID: 3989
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x04000F96 RID: 3990
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04000F97 RID: 3991
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04000F98 RID: 3992
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonLabel;

	// Token: 0x04000F99 RID: 3993
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000F9A RID: 3994
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04000F9B RID: 3995
	private static readonly IntPtr NativeFieldInfoPtr_rows;

	// Token: 0x04000F9C RID: 3996
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000F9D RID: 3997
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x04000F9E RID: 3998
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000F9F RID: 3999
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000FA0 RID: 4000
	private static readonly IntPtr NativeMethodInfoPtr_LoadFriendsList_Public_Void_0;

	// Token: 0x04000FA1 RID: 4001
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x04000FA2 RID: 4002
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x04000FA3 RID: 4003
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x04000FA4 RID: 4004
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x04000FA5 RID: 4005
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
