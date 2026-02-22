using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

// Token: 0x020000C4 RID: 196
public class InGameNetworkListener : MonoBehaviour
{
	// Token: 0x0600177B RID: 6011 RVA: 0x00060F34 File Offset: 0x0005F134
	// Note: this type is marked as 'beforefieldinit'.
	static InGameNetworkListener()
	{
		Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InGameNetworkListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr);
		InGameNetworkListener.NativeFieldInfoPtr_m_nextGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_nextGameButton");
		InGameNetworkListener.NativeFieldInfoPtr_m_gameWaitingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_gameWaitingIcon");
		InGameNetworkListener.NativeFieldInfoPtr_m_networkMessagePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_networkMessagePopup");
		InGameNetworkListener.NativeFieldInfoPtr_m_networkMessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_networkMessageText");
		InGameNetworkListener.NativeFieldInfoPtr_m_nextGameWaitingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_nextGameWaitingID");
		InGameNetworkListener.NativeFieldInfoPtr_m_AvailableCardSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_AvailableCardSetFlags");
		InGameNetworkListener.NativeFieldInfoPtr_m_AvailablePromoPackFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, "m_AvailablePromoPackFlags");
		InGameNetworkListener.NativeMethodInfoPtr_HandleExitAfterNetworkDisconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665173);
		InGameNetworkListener.NativeMethodInfoPtr_HandleNextGameButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665174);
		InGameNetworkListener.NativeMethodInfoPtr_HandleLeaveGameAnalytics_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665175);
		InGameNetworkListener.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665176);
		InGameNetworkListener.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665177);
		InGameNetworkListener.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665178);
		InGameNetworkListener.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665179);
		InGameNetworkListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr, 100665180);
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00061090 File Offset: 0x0005F290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248356, XrefRangeEnd = 248367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleExitAfterNetworkDisconnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_HandleExitAfterNetworkDisconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x000610C4 File Offset: 0x0005F2C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248367, XrefRangeEnd = 248405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleNextGameButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_HandleNextGameButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x000610F8 File Offset: 0x0005F2F8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleLeaveGameAnalytics(string reason)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_HandleLeaveGameAnalytics_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x0006113C File Offset: 0x0005F33C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248405, XrefRangeEnd = 248437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00061170 File Offset: 0x0005F370
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248437, XrefRangeEnd = 248451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x000611A4 File Offset: 0x0005F3A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248451, XrefRangeEnd = 248465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000611D8 File Offset: 0x0005F3D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248465, XrefRangeEnd = 248468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00061224 File Offset: 0x0005F424
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameNetworkListener()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameNetworkListener>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameNetworkListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x0000F209 File Offset: 0x0000D409
	public InGameNetworkListener(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x06001785 RID: 6021 RVA: 0x00061260 File Offset: 0x0005F460
	// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000F212 File Offset: 0x0000D412
	public unsafe GameObject m_nextGameButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_nextGameButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_nextGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x06001787 RID: 6023 RVA: 0x00061290 File Offset: 0x0005F490
	// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000F231 File Offset: 0x0000D431
	public unsafe GameObject m_gameWaitingIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_gameWaitingIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_gameWaitingIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x06001789 RID: 6025 RVA: 0x000612C0 File Offset: 0x0005F4C0
	// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000F250 File Offset: 0x0000D450
	public unsafe GameObject m_networkMessagePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_networkMessagePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_networkMessagePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x0600178B RID: 6027 RVA: 0x000612F0 File Offset: 0x0005F4F0
	// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000F26F File Offset: 0x0000D46F
	public unsafe TextMeshProUGUI m_networkMessageText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_networkMessageText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_networkMessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x0600178D RID: 6029 RVA: 0x00061320 File Offset: 0x0005F520
	// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000F28E File Offset: 0x0000D48E
	public unsafe uint m_nextGameWaitingID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_nextGameWaitingID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_nextGameWaitingID)) = value;
		}
	}

	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x0600178F RID: 6031 RVA: 0x00061348 File Offset: 0x0005F548
	// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
	public unsafe uint m_AvailableCardSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_AvailableCardSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_AvailableCardSetFlags)) = value;
		}
	}

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x06001791 RID: 6033 RVA: 0x00061370 File Offset: 0x0005F570
	// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
	public unsafe uint m_AvailablePromoPackFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_AvailablePromoPackFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameNetworkListener.NativeFieldInfoPtr_m_AvailablePromoPackFlags)) = value;
		}
	}

	// Token: 0x0400101F RID: 4127
	private static readonly IntPtr NativeFieldInfoPtr_m_nextGameButton;

	// Token: 0x04001020 RID: 4128
	private static readonly IntPtr NativeFieldInfoPtr_m_gameWaitingIcon;

	// Token: 0x04001021 RID: 4129
	private static readonly IntPtr NativeFieldInfoPtr_m_networkMessagePopup;

	// Token: 0x04001022 RID: 4130
	private static readonly IntPtr NativeFieldInfoPtr_m_networkMessageText;

	// Token: 0x04001023 RID: 4131
	private static readonly IntPtr NativeFieldInfoPtr_m_nextGameWaitingID;

	// Token: 0x04001024 RID: 4132
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailableCardSetFlags;

	// Token: 0x04001025 RID: 4133
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailablePromoPackFlags;

	// Token: 0x04001026 RID: 4134
	private static readonly IntPtr NativeMethodInfoPtr_HandleExitAfterNetworkDisconnect_Public_Void_0;

	// Token: 0x04001027 RID: 4135
	private static readonly IntPtr NativeMethodInfoPtr_HandleNextGameButtonPressed_Public_Void_0;

	// Token: 0x04001028 RID: 4136
	private static readonly IntPtr NativeMethodInfoPtr_HandleLeaveGameAnalytics_Private_Void_String_0;

	// Token: 0x04001029 RID: 4137
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400102A RID: 4138
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400102B RID: 4139
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400102C RID: 4140
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0;

	// Token: 0x0400102D RID: 4141
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
