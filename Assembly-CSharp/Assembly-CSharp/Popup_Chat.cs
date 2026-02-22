using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000A6 RID: 166
public class Popup_Chat : MonoBehaviour
{
	// Token: 0x06001333 RID: 4915 RVA: 0x00053DE0 File Offset: 0x00051FE0
	// Note: this type is marked as 'beforefieldinit'.
	static Popup_Chat()
	{
		Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Popup_Chat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr);
		Popup_Chat.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "k_maxDataSize");
		Popup_Chat.NativeFieldInfoPtr_m_PopupWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_PopupWindow");
		Popup_Chat.NativeFieldInfoPtr_m_PopupWindowIngamePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_PopupWindowIngamePanel");
		Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_NewChatIndicator");
		Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicatorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_NewChatIndicatorCount");
		Popup_Chat.NativeFieldInfoPtr_m_PopupHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_PopupHeader");
		Popup_Chat.NativeFieldInfoPtr_m_ChatTextScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatTextScrollView");
		Popup_Chat.NativeFieldInfoPtr_m_ChatTextPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatTextPanel");
		Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatTextLinePrefab");
		Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePhonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatTextLinePhonePrefab");
		Popup_Chat.NativeFieldInfoPtr_m_ChatEntryField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatEntryField");
		Popup_Chat.NativeFieldInfoPtr_m_profilePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_profilePopup");
		Popup_Chat.NativeFieldInfoPtr_m_localChatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_localChatColor");
		Popup_Chat.NativeFieldInfoPtr_m_otherChatColor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_otherChatColor1");
		Popup_Chat.NativeFieldInfoPtr_m_otherChatColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_otherChatColor2");
		Popup_Chat.NativeFieldInfoPtr_m_bProfileAlwaysVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_bProfileAlwaysVisible");
		Popup_Chat.NativeFieldInfoPtr_m_ChatChannelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_ChatChannelID");
		Popup_Chat.NativeFieldInfoPtr_m_LastChatMessageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_LastChatMessageIndex");
		Popup_Chat.NativeFieldInfoPtr_m_bMoveScrollRectToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_bMoveScrollRectToBottom");
		Popup_Chat.NativeFieldInfoPtr_m_localColorString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_localColorString");
		Popup_Chat.NativeFieldInfoPtr_m_otherColorString1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_otherColorString1");
		Popup_Chat.NativeFieldInfoPtr_m_otherColorString2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_otherColorString2");
		Popup_Chat.NativeFieldInfoPtr_m_lastUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_lastUsername");
		Popup_Chat.NativeFieldInfoPtr_m_localUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_localUsername");
		Popup_Chat.NativeFieldInfoPtr_m_bUseColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_bUseColor2");
		Popup_Chat.NativeFieldInfoPtr_m_chatObjList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, "m_chatObjList");
		Popup_Chat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664807);
		Popup_Chat.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664808);
		Popup_Chat.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664809);
		Popup_Chat.NativeMethodInfoPtr_ResetColorStrings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664810);
		Popup_Chat.NativeMethodInfoPtr_Recolor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664811);
		Popup_Chat.NativeMethodInfoPtr_SetLocalUsername_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664812);
		Popup_Chat.NativeMethodInfoPtr_UpdateDisplay_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664813);
		Popup_Chat.NativeMethodInfoPtr_UpdateChatMessageList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664814);
		Popup_Chat.NativeMethodInfoPtr_GetLastChat_Public_ChatTextLine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664815);
		Popup_Chat.NativeMethodInfoPtr_OnChatEntryClicked_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664816);
		Popup_Chat.NativeMethodInfoPtr_DisplayLocalProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664817);
		Popup_Chat.NativeMethodInfoPtr_SubmitChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664818);
		Popup_Chat.NativeMethodInfoPtr_UpdateChatPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664819);
		Popup_Chat.NativeMethodInfoPtr_ClosePopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664820);
		Popup_Chat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr, 100664821);
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00054144 File Offset: 0x00052344
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244119, XrefRangeEnd = 244125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00054178 File Offset: 0x00052378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244125, XrefRangeEnd = 244144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x000541AC File Offset: 0x000523AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244144, XrefRangeEnd = 244152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x000541E0 File Offset: 0x000523E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244189, RefRangeEnd = 244191, XrefRangeStart = 244152, XrefRangeEnd = 244189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetColorStrings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_ResetColorStrings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00054214 File Offset: 0x00052414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244191, XrefRangeEnd = 244199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Recolor(uint factionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref factionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_Recolor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00054254 File Offset: 0x00052454
	[CallerCount(0)]
	public unsafe void SetLocalUsername(string username)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_SetLocalUsername_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00054298 File Offset: 0x00052498
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244232, RefRangeEnd = 244233, XrefRangeStart = 244199, XrefRangeEnd = 244232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDisplay(uint channel_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channel_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_UpdateDisplay_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x000542D8 File Offset: 0x000524D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244292, RefRangeEnd = 244294, XrefRangeStart = 244233, XrefRangeEnd = 244292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateChatMessageList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_UpdateChatMessageList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x0005430C File Offset: 0x0005250C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244294, XrefRangeEnd = 244297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatTextLine GetLastChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_GetLastChat_Public_ChatTextLine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChatTextLine>(intPtr3) : null;
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0005434C File Offset: 0x0005254C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244305, RefRangeEnd = 244306, XrefRangeStart = 244297, XrefRangeEnd = 244305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChatEntryClicked(string username, uint userID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_OnChatEntryClicked_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x0005439C File Offset: 0x0005259C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244314, RefRangeEnd = 244315, XrefRangeStart = 244306, XrefRangeEnd = 244314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayLocalProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_DisplayLocalProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x000543D0 File Offset: 0x000525D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244315, XrefRangeEnd = 244329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_SubmitChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00054404 File Offset: 0x00052604
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244343, RefRangeEnd = 244345, XrefRangeStart = 244329, XrefRangeEnd = 244343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateChatPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_UpdateChatPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00054438 File Offset: 0x00052638
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244345, XrefRangeEnd = 244350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClosePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr_ClosePopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x0005446C File Offset: 0x0005266C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244350, XrefRangeEnd = 244353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Popup_Chat()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_Chat>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup_Chat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x0000CAB7 File Offset: 0x0000ACB7
	public Popup_Chat(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x06001344 RID: 4932 RVA: 0x000544A8 File Offset: 0x000526A8
	// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Popup_Chat.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Popup_Chat.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x06001346 RID: 4934 RVA: 0x000544C4 File Offset: 0x000526C4
	// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000CACE File Offset: 0x0000ACCE
	public unsafe GameObject m_PopupWindow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupWindow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x06001348 RID: 4936 RVA: 0x000544F4 File Offset: 0x000526F4
	// (set) Token: 0x06001349 RID: 4937 RVA: 0x0000CAED File Offset: 0x0000ACED
	public unsafe Chat_InGame_Panel m_PopupWindowIngamePanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupWindowIngamePanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chat_InGame_Panel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupWindowIngamePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x0600134A RID: 4938 RVA: 0x00054524 File Offset: 0x00052724
	// (set) Token: 0x0600134B RID: 4939 RVA: 0x0000CB0C File Offset: 0x0000AD0C
	public unsafe GameObject m_NewChatIndicator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x0600134C RID: 4940 RVA: 0x00054554 File Offset: 0x00052754
	// (set) Token: 0x0600134D RID: 4941 RVA: 0x0000CB2B File Offset: 0x0000AD2B
	public unsafe TextMeshProUGUI m_NewChatIndicatorCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicatorCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_NewChatIndicatorCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x0600134E RID: 4942 RVA: 0x00054584 File Offset: 0x00052784
	// (set) Token: 0x0600134F RID: 4943 RVA: 0x0000CB4A File Offset: 0x0000AD4A
	public unsafe TextMeshProUGUI m_PopupHeader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupHeader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_PopupHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x06001350 RID: 4944 RVA: 0x000545B4 File Offset: 0x000527B4
	// (set) Token: 0x06001351 RID: 4945 RVA: 0x0000CB69 File Offset: 0x0000AD69
	public unsafe ScrollRect m_ChatTextScrollView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextScrollView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x06001352 RID: 4946 RVA: 0x000545E4 File Offset: 0x000527E4
	// (set) Token: 0x06001353 RID: 4947 RVA: 0x0000CB88 File Offset: 0x0000AD88
	public unsafe GameObject m_ChatTextPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x06001354 RID: 4948 RVA: 0x00054614 File Offset: 0x00052814
	// (set) Token: 0x06001355 RID: 4949 RVA: 0x0000CBA7 File Offset: 0x0000ADA7
	public unsafe GameObject m_ChatTextLinePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x06001356 RID: 4950 RVA: 0x00054644 File Offset: 0x00052844
	// (set) Token: 0x06001357 RID: 4951 RVA: 0x0000CBC6 File Offset: 0x0000ADC6
	public unsafe GameObject m_ChatTextLinePhonePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePhonePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatTextLinePhonePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x06001358 RID: 4952 RVA: 0x00054674 File Offset: 0x00052874
	// (set) Token: 0x06001359 RID: 4953 RVA: 0x0000CBE5 File Offset: 0x0000ADE5
	public unsafe TMP_InputField m_ChatEntryField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatEntryField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatEntryField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x0600135A RID: 4954 RVA: 0x000546A4 File Offset: 0x000528A4
	// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000CC04 File Offset: 0x0000AE04
	public unsafe UIP_ProfilePopup m_profilePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_profilePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_ProfilePopup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_profilePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x0600135C RID: 4956 RVA: 0x000546D4 File Offset: 0x000528D4
	// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000CC23 File Offset: 0x0000AE23
	public unsafe Color m_localChatColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localChatColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localChatColor)) = value;
		}
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x0600135E RID: 4958 RVA: 0x000546FC File Offset: 0x000528FC
	// (set) Token: 0x0600135F RID: 4959 RVA: 0x0000CC3E File Offset: 0x0000AE3E
	public unsafe Color m_otherChatColor1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherChatColor1);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherChatColor1)) = value;
		}
	}

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x06001360 RID: 4960 RVA: 0x00054724 File Offset: 0x00052924
	// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000CC59 File Offset: 0x0000AE59
	public unsafe Color m_otherChatColor2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherChatColor2);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherChatColor2)) = value;
		}
	}

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x06001362 RID: 4962 RVA: 0x0005474C File Offset: 0x0005294C
	// (set) Token: 0x06001363 RID: 4963 RVA: 0x0000CC74 File Offset: 0x0000AE74
	public unsafe bool m_bProfileAlwaysVisible
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bProfileAlwaysVisible);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bProfileAlwaysVisible)) = value;
		}
	}

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06001364 RID: 4964 RVA: 0x00054774 File Offset: 0x00052974
	// (set) Token: 0x06001365 RID: 4965 RVA: 0x0000CC8F File Offset: 0x0000AE8F
	public unsafe uint m_ChatChannelID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatChannelID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_ChatChannelID)) = value;
		}
	}

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06001366 RID: 4966 RVA: 0x0005479C File Offset: 0x0005299C
	// (set) Token: 0x06001367 RID: 4967 RVA: 0x0000CCAA File Offset: 0x0000AEAA
	public unsafe uint m_LastChatMessageIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_LastChatMessageIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_LastChatMessageIndex)) = value;
		}
	}

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x06001368 RID: 4968 RVA: 0x000547C4 File Offset: 0x000529C4
	// (set) Token: 0x06001369 RID: 4969 RVA: 0x0000CCC5 File Offset: 0x0000AEC5
	public unsafe bool m_bMoveScrollRectToBottom
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bMoveScrollRectToBottom);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bMoveScrollRectToBottom)) = value;
		}
	}

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x0600136A RID: 4970 RVA: 0x000547EC File Offset: 0x000529EC
	// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
	public unsafe string m_localColorString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localColorString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localColorString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x0600136C RID: 4972 RVA: 0x00054814 File Offset: 0x00052A14
	// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000CCFF File Offset: 0x0000AEFF
	public unsafe string m_otherColorString1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherColorString1);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherColorString1), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005483C File Offset: 0x00052A3C
	// (set) Token: 0x0600136F RID: 4975 RVA: 0x0000CD1E File Offset: 0x0000AF1E
	public unsafe string m_otherColorString2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherColorString2);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_otherColorString2), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x06001370 RID: 4976 RVA: 0x00054864 File Offset: 0x00052A64
	// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000CD3D File Offset: 0x0000AF3D
	public unsafe string m_lastUsername
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_lastUsername);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_lastUsername), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005488C File Offset: 0x00052A8C
	// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000CD5C File Offset: 0x0000AF5C
	public unsafe string m_localUsername
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localUsername);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_localUsername), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x06001374 RID: 4980 RVA: 0x000548B4 File Offset: 0x00052AB4
	// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000CD7B File Offset: 0x0000AF7B
	public unsafe bool m_bUseColor2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bUseColor2);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_bUseColor2)) = value;
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x06001376 RID: 4982 RVA: 0x000548DC File Offset: 0x00052ADC
	// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000CD96 File Offset: 0x0000AF96
	public unsafe List<ChatTextLine> m_chatObjList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_chatObjList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChatTextLine>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup_Chat.NativeFieldInfoPtr_m_chatObjList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D65 RID: 3429
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x04000D66 RID: 3430
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupWindow;

	// Token: 0x04000D67 RID: 3431
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupWindowIngamePanel;

	// Token: 0x04000D68 RID: 3432
	private static readonly IntPtr NativeFieldInfoPtr_m_NewChatIndicator;

	// Token: 0x04000D69 RID: 3433
	private static readonly IntPtr NativeFieldInfoPtr_m_NewChatIndicatorCount;

	// Token: 0x04000D6A RID: 3434
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupHeader;

	// Token: 0x04000D6B RID: 3435
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatTextScrollView;

	// Token: 0x04000D6C RID: 3436
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatTextPanel;

	// Token: 0x04000D6D RID: 3437
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatTextLinePrefab;

	// Token: 0x04000D6E RID: 3438
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatTextLinePhonePrefab;

	// Token: 0x04000D6F RID: 3439
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatEntryField;

	// Token: 0x04000D70 RID: 3440
	private static readonly IntPtr NativeFieldInfoPtr_m_profilePopup;

	// Token: 0x04000D71 RID: 3441
	private static readonly IntPtr NativeFieldInfoPtr_m_localChatColor;

	// Token: 0x04000D72 RID: 3442
	private static readonly IntPtr NativeFieldInfoPtr_m_otherChatColor1;

	// Token: 0x04000D73 RID: 3443
	private static readonly IntPtr NativeFieldInfoPtr_m_otherChatColor2;

	// Token: 0x04000D74 RID: 3444
	private static readonly IntPtr NativeFieldInfoPtr_m_bProfileAlwaysVisible;

	// Token: 0x04000D75 RID: 3445
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatChannelID;

	// Token: 0x04000D76 RID: 3446
	private static readonly IntPtr NativeFieldInfoPtr_m_LastChatMessageIndex;

	// Token: 0x04000D77 RID: 3447
	private static readonly IntPtr NativeFieldInfoPtr_m_bMoveScrollRectToBottom;

	// Token: 0x04000D78 RID: 3448
	private static readonly IntPtr NativeFieldInfoPtr_m_localColorString;

	// Token: 0x04000D79 RID: 3449
	private static readonly IntPtr NativeFieldInfoPtr_m_otherColorString1;

	// Token: 0x04000D7A RID: 3450
	private static readonly IntPtr NativeFieldInfoPtr_m_otherColorString2;

	// Token: 0x04000D7B RID: 3451
	private static readonly IntPtr NativeFieldInfoPtr_m_lastUsername;

	// Token: 0x04000D7C RID: 3452
	private static readonly IntPtr NativeFieldInfoPtr_m_localUsername;

	// Token: 0x04000D7D RID: 3453
	private static readonly IntPtr NativeFieldInfoPtr_m_bUseColor2;

	// Token: 0x04000D7E RID: 3454
	private static readonly IntPtr NativeFieldInfoPtr_m_chatObjList;

	// Token: 0x04000D7F RID: 3455
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D80 RID: 3456
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D81 RID: 3457
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000D82 RID: 3458
	private static readonly IntPtr NativeMethodInfoPtr_ResetColorStrings_Public_Void_0;

	// Token: 0x04000D83 RID: 3459
	private static readonly IntPtr NativeMethodInfoPtr_Recolor_Public_Void_UInt32_0;

	// Token: 0x04000D84 RID: 3460
	private static readonly IntPtr NativeMethodInfoPtr_SetLocalUsername_Public_Void_String_0;

	// Token: 0x04000D85 RID: 3461
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_UInt32_0;

	// Token: 0x04000D86 RID: 3462
	private static readonly IntPtr NativeMethodInfoPtr_UpdateChatMessageList_Public_Void_0;

	// Token: 0x04000D87 RID: 3463
	private static readonly IntPtr NativeMethodInfoPtr_GetLastChat_Public_ChatTextLine_0;

	// Token: 0x04000D88 RID: 3464
	private static readonly IntPtr NativeMethodInfoPtr_OnChatEntryClicked_Public_Void_String_UInt32_0;

	// Token: 0x04000D89 RID: 3465
	private static readonly IntPtr NativeMethodInfoPtr_DisplayLocalProfile_Public_Void_0;

	// Token: 0x04000D8A RID: 3466
	private static readonly IntPtr NativeMethodInfoPtr_SubmitChat_Public_Void_0;

	// Token: 0x04000D8B RID: 3467
	private static readonly IntPtr NativeMethodInfoPtr_UpdateChatPosition_Public_Void_0;

	// Token: 0x04000D8C RID: 3468
	private static readonly IntPtr NativeMethodInfoPtr_ClosePopup_Public_Void_0;

	// Token: 0x04000D8D RID: 3469
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
