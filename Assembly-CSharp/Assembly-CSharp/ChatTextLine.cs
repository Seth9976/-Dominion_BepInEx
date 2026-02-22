using System;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

// Token: 0x0200009E RID: 158
public class ChatTextLine : MonoBehaviour
{
	// Token: 0x060012C0 RID: 4800 RVA: 0x00052AEC File Offset: 0x00050CEC
	// Note: this type is marked as 'beforefieldinit'.
	static ChatTextLine()
	{
		Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChatTextLine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr);
		ChatTextLine.NativeFieldInfoPtr_m_timestampText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_timestampText");
		ChatTextLine.NativeFieldInfoPtr_m_messageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_messageText");
		ChatTextLine.NativeFieldInfoPtr_m_ChatUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_ChatUserID");
		ChatTextLine.NativeFieldInfoPtr_m_ChatUserDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_ChatUserDisplayName");
		ChatTextLine.NativeFieldInfoPtr_m_ChatTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_ChatTimestamp");
		ChatTextLine.NativeFieldInfoPtr_m_ChatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_ChatMessage");
		ChatTextLine.NativeFieldInfoPtr_m_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, "m_parent");
		ChatTextLine.NativeMethodInfoPtr_SetParent_Public_Void_Popup_Chat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, 100664777);
		ChatTextLine.NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, 100664778);
		ChatTextLine.NativeMethodInfoPtr_SetChatTextLine_Public_Virtual_New_Void_ChatChannelMessageEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, 100664779);
		ChatTextLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr, 100664780);
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00052BF8 File Offset: 0x00050DF8
	[CallerCount(0)]
	public unsafe void SetParent(Popup_Chat parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatTextLine.NativeMethodInfoPtr_SetParent_Public_Void_Popup_Chat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00052C3C File Offset: 0x00050E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243869, XrefRangeEnd = 243874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatTextLine.NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00052C70 File Offset: 0x00050E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243874, XrefRangeEnd = 243899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetChatTextLine(ChatChannelMessageEntry entry, string color_string)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color_string);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatTextLine.NativeMethodInfoPtr_SetChatTextLine_Public_Virtual_New_Void_ChatChannelMessageEntry_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00052CD4 File Offset: 0x00050ED4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatTextLine()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatTextLine>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatTextLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0000C65D File Offset: 0x0000A85D
	public ChatTextLine(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005FC RID: 1532
	// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00052D10 File Offset: 0x00050F10
	// (set) Token: 0x060012C7 RID: 4807 RVA: 0x0000C666 File Offset: 0x0000A866
	public unsafe TextMeshProUGUI m_timestampText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_timestampText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_timestampText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FD RID: 1533
	// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00052D40 File Offset: 0x00050F40
	// (set) Token: 0x060012C9 RID: 4809 RVA: 0x0000C685 File Offset: 0x0000A885
	public unsafe TextMeshProUGUI m_messageText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_messageText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_messageText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x060012CA RID: 4810 RVA: 0x00052D70 File Offset: 0x00050F70
	// (set) Token: 0x060012CB RID: 4811 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
	public unsafe uint m_ChatUserID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatUserID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatUserID)) = value;
		}
	}

	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x060012CC RID: 4812 RVA: 0x00052D98 File Offset: 0x00050F98
	// (set) Token: 0x060012CD RID: 4813 RVA: 0x0000C6BF File Offset: 0x0000A8BF
	public unsafe string m_ChatUserDisplayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatUserDisplayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatUserDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x060012CE RID: 4814 RVA: 0x00052DC0 File Offset: 0x00050FC0
	// (set) Token: 0x060012CF RID: 4815 RVA: 0x0000C6DE File Offset: 0x0000A8DE
	public unsafe string m_ChatTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatTimestamp);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatTimestamp), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00052DE8 File Offset: 0x00050FE8
	// (set) Token: 0x060012D1 RID: 4817 RVA: 0x0000C6FD File Offset: 0x0000A8FD
	public unsafe string m_ChatMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatMessage);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_ChatMessage), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00052E10 File Offset: 0x00051010
	// (set) Token: 0x060012D3 RID: 4819 RVA: 0x0000C71C File Offset: 0x0000A91C
	public unsafe Popup_Chat m_parent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_parent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Popup_Chat>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatTextLine.NativeFieldInfoPtr_m_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D1F RID: 3359
	private static readonly IntPtr NativeFieldInfoPtr_m_timestampText;

	// Token: 0x04000D20 RID: 3360
	private static readonly IntPtr NativeFieldInfoPtr_m_messageText;

	// Token: 0x04000D21 RID: 3361
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatUserID;

	// Token: 0x04000D22 RID: 3362
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatUserDisplayName;

	// Token: 0x04000D23 RID: 3363
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatTimestamp;

	// Token: 0x04000D24 RID: 3364
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatMessage;

	// Token: 0x04000D25 RID: 3365
	private static readonly IntPtr NativeFieldInfoPtr_m_parent;

	// Token: 0x04000D26 RID: 3366
	private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Popup_Chat_0;

	// Token: 0x04000D27 RID: 3367
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	// Token: 0x04000D28 RID: 3368
	private static readonly IntPtr NativeMethodInfoPtr_SetChatTextLine_Public_Virtual_New_Void_ChatChannelMessageEntry_String_0;

	// Token: 0x04000D29 RID: 3369
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
