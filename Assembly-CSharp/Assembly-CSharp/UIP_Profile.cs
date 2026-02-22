using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BA RID: 186
public class UIP_Profile : MonoBehaviour
{
	// Token: 0x06001650 RID: 5712 RVA: 0x0005D780 File Offset: 0x0005B980
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_Profile()
	{
		Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_Profile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr);
		UIP_Profile.NativeFieldInfoPtr_m_friendNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_friendNameLabel");
		UIP_Profile.NativeFieldInfoPtr_m_ratingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_ratingLabel");
		UIP_Profile.NativeFieldInfoPtr_m_ratingBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_ratingBase");
		UIP_Profile.NativeFieldInfoPtr_m_activeGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_activeGlow");
		UIP_Profile.NativeFieldInfoPtr_m_statusBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_statusBase");
		UIP_Profile.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_RectTransform");
		UIP_Profile.NativeFieldInfoPtr_m_dragSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_dragSource");
		UIP_Profile.NativeFieldInfoPtr_m_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_avatar");
		UIP_Profile.NativeFieldInfoPtr_m_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_button");
		UIP_Profile.NativeFieldInfoPtr_m_onlineIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_onlineIndicator");
		UIP_Profile.NativeFieldInfoPtr_m_indicatorSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_indicatorSprites");
		UIP_Profile.NativeFieldInfoPtr_m_baseNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_baseNodes");
		UIP_Profile.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_Callback");
		UIP_Profile.NativeFieldInfoPtr_m_FriendData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_FriendData");
		UIP_Profile.NativeFieldInfoPtr_m_OfflineProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_OfflineProfile");
		UIP_Profile.NativeFieldInfoPtr_m_OnlineStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "m_OnlineStatus");
		UIP_Profile.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665079);
		UIP_Profile.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665080);
		UIP_Profile.NativeMethodInfoPtr_GetDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665081);
		UIP_Profile.NativeMethodInfoPtr_GetUserID_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665082);
		UIP_Profile.NativeMethodInfoPtr_GetFriendInfo_Public_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665083);
		UIP_Profile.NativeMethodInfoPtr_GetOfflineProfile_Public_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665084);
		UIP_Profile.NativeMethodInfoPtr_HideObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665085);
		UIP_Profile.NativeMethodInfoPtr_ShowObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665086);
		UIP_Profile.NativeMethodInfoPtr_SetFriendData_Public_Void_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665087);
		UIP_Profile.NativeMethodInfoPtr_SetOfflineData_Public_Void_OfflineProfileEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665088);
		UIP_Profile.NativeMethodInfoPtr_SetDraggable_Public_Void_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665089);
		UIP_Profile.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665090);
		UIP_Profile.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665091);
		UIP_Profile.NativeMethodInfoPtr_GetIsSelected_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665092);
		UIP_Profile.NativeMethodInfoPtr_SetFriendName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665093);
		UIP_Profile.NativeMethodInfoPtr_SetRating_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665094);
		UIP_Profile.NativeMethodInfoPtr_SetAvatar_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665095);
		UIP_Profile.NativeMethodInfoPtr_SetUserID_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665096);
		UIP_Profile.NativeMethodInfoPtr_GetOnlineStatus_Public_PlayerOnlineStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665097);
		UIP_Profile.NativeMethodInfoPtr_SetOnlineStatus_Public_Void_PlayerOnlineStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665098);
		UIP_Profile.NativeMethodInfoPtr_OnSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665099);
		UIP_Profile.NativeMethodInfoPtr_IsVisible_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665100);
		UIP_Profile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, 100665101);
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x0005DABC File Offset: 0x0005BCBC
	[CallerCount(0)]
	public unsafe void SetClickListener(UIP_Profile.ClickCallback cb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x0005DB00 File Offset: 0x0005BD00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247702, XrefRangeEnd = 247709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0005DB34 File Offset: 0x0005BD34
	[CallerCount(0)]
	public unsafe string GetDisplayName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetDisplayName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0005DB6C File Offset: 0x0005BD6C
	[CallerCount(0)]
	public unsafe uint GetUserID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetUserID_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0005DBA8 File Offset: 0x0005BDA8
	[CallerCount(0)]
	public unsafe FriendInfo GetFriendInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetFriendInfo_Public_FriendInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new FriendInfo(intPtr);
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
	[CallerCount(0)]
	public unsafe ProfileManager.OfflineProfileEntry GetOfflineProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetOfflineProfile_Public_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0005DC20 File Offset: 0x0005BE20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183709, RefRangeEnd = 183710, XrefRangeStart = 183709, XrefRangeEnd = 183710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_HideObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0005DC54 File Offset: 0x0005BE54
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 183702, RefRangeEnd = 183706, XrefRangeStart = 183702, XrefRangeEnd = 183706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_ShowObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0005DC88 File Offset: 0x0005BE88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247719, RefRangeEnd = 247720, XrefRangeStart = 247709, XrefRangeEnd = 247719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFriendData(FriendInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetFriendData_Public_Void_FriendInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x0005DCD0 File Offset: 0x0005BED0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247733, RefRangeEnd = 247734, XrefRangeStart = 247720, XrefRangeEnd = 247733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOfflineData(ProfileManager.OfflineProfileEntry profile, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetOfflineData_Public_Void_OfflineProfileEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x0005DD20 File Offset: 0x0005BF20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247741, RefRangeEnd = 247743, XrefRangeStart = 247734, XrefRangeEnd = 247741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDraggable(bool bDraggable, Canvas forceBaseCanvas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bDraggable;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forceBaseCanvas);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetDraggable_Public_Void_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0005DD70 File Offset: 0x0005BF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247743, XrefRangeEnd = 247748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInteractable(bool bInteractable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bInteractable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x0005DDB0 File Offset: 0x0005BFB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247750, RefRangeEnd = 247751, XrefRangeStart = 247748, XrefRangeEnd = 247750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsSelected(bool bActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247753, RefRangeEnd = 247755, XrefRangeStart = 247751, XrefRangeEnd = 247753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetIsSelected_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x0005DE2C File Offset: 0x0005C02C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFriendName(string displayName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetFriendName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0005DE70 File Offset: 0x0005C070
	[CallerCount(0)]
	public unsafe void SetRating(ushort rating)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetRating_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247755, XrefRangeEnd = 247757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvatar(ushort avatarIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref avatarIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetAvatar_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0005DEF0 File Offset: 0x0005C0F0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUserID(uint userID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetUserID_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0005DF30 File Offset: 0x0005C130
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20876, RefRangeEnd = 20877, XrefRangeStart = 20876, XrefRangeEnd = 20877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerOnlineStatus GetOnlineStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_GetOnlineStatus_Public_PlayerOnlineStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0005DF6C File Offset: 0x0005C16C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247763, RefRangeEnd = 247765, XrefRangeStart = 247757, XrefRangeEnd = 247763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnlineStatus(PlayerOnlineStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_SetOnlineStatus_Public_Void_PlayerOnlineStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0005DFAC File Offset: 0x0005C1AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247765, XrefRangeEnd = 247766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_OnSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247766, XrefRangeEnd = 247773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsVisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr_IsVisible_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0005E01C File Offset: 0x0005C21C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_Profile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0000E6F3 File Offset: 0x0000C8F3
	public UIP_Profile(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x06001669 RID: 5737 RVA: 0x0005E058 File Offset: 0x0005C258
	// (set) Token: 0x0600166A RID: 5738 RVA: 0x0000E6FC File Offset: 0x0000C8FC
	public unsafe TextMeshProUGUI m_friendNameLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_friendNameLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_friendNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000718 RID: 1816
	// (get) Token: 0x0600166B RID: 5739 RVA: 0x0005E088 File Offset: 0x0005C288
	// (set) Token: 0x0600166C RID: 5740 RVA: 0x0000E71B File Offset: 0x0000C91B
	public unsafe TextMeshProUGUI m_ratingLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_ratingLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_ratingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x0600166D RID: 5741 RVA: 0x0005E0B8 File Offset: 0x0005C2B8
	// (set) Token: 0x0600166E RID: 5742 RVA: 0x0000E73A File Offset: 0x0000C93A
	public unsafe GameObject m_ratingBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_ratingBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_ratingBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x0600166F RID: 5743 RVA: 0x0005E0E8 File Offset: 0x0005C2E8
	// (set) Token: 0x06001670 RID: 5744 RVA: 0x0000E759 File Offset: 0x0000C959
	public unsafe GameObject m_activeGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_activeGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_activeGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x06001671 RID: 5745 RVA: 0x0005E118 File Offset: 0x0005C318
	// (set) Token: 0x06001672 RID: 5746 RVA: 0x0000E778 File Offset: 0x0000C978
	public unsafe GameObject m_statusBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_statusBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_statusBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x06001673 RID: 5747 RVA: 0x0005E148 File Offset: 0x0005C348
	// (set) Token: 0x06001674 RID: 5748 RVA: 0x0000E797 File Offset: 0x0000C997
	public unsafe RectTransform m_RectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_RectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06001675 RID: 5749 RVA: 0x0005E178 File Offset: 0x0005C378
	// (set) Token: 0x06001676 RID: 5750 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
	public unsafe UI_DragSource m_dragSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_dragSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DragSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_dragSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x06001677 RID: 5751 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
	// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000E7D5 File Offset: 0x0000C9D5
	public unsafe Avatar_UI m_avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x06001679 RID: 5753 RVA: 0x0005E1D8 File Offset: 0x0005C3D8
	// (set) Token: 0x0600167A RID: 5754 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
	public unsafe Button m_button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x0600167B RID: 5755 RVA: 0x0005E208 File Offset: 0x0005C408
	// (set) Token: 0x0600167C RID: 5756 RVA: 0x0000E813 File Offset: 0x0000CA13
	public unsafe Image m_onlineIndicator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_onlineIndicator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_onlineIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x0600167D RID: 5757 RVA: 0x0005E238 File Offset: 0x0005C438
	// (set) Token: 0x0600167E RID: 5758 RVA: 0x0000E832 File Offset: 0x0000CA32
	public unsafe Il2CppReferenceArray<Sprite> m_indicatorSprites
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_indicatorSprites);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_indicatorSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x0600167F RID: 5759 RVA: 0x0005E268 File Offset: 0x0005C468
	// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000E851 File Offset: 0x0000CA51
	public unsafe Il2CppReferenceArray<GameObject> m_baseNodes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_baseNodes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_baseNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000723 RID: 1827
	// (get) Token: 0x06001681 RID: 5761 RVA: 0x0005E298 File Offset: 0x0005C498
	// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000E870 File Offset: 0x0000CA70
	public unsafe UIP_Profile.ClickCallback m_Callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_Callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_Profile.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x06001683 RID: 5763 RVA: 0x0005E2C8 File Offset: 0x0005C4C8
	// (set) Token: 0x06001684 RID: 5764 RVA: 0x0000E88F File Offset: 0x0000CA8F
	public FriendInfo m_FriendData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_FriendData);
			return new FriendInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_FriendData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000725 RID: 1829
	// (get) Token: 0x06001685 RID: 5765 RVA: 0x0005E2F8 File Offset: 0x0005C4F8
	// (set) Token: 0x06001686 RID: 5766 RVA: 0x0000E8BD File Offset: 0x0000CABD
	public unsafe ProfileManager.OfflineProfileEntry m_OfflineProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_OfflineProfile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_OfflineProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x06001687 RID: 5767 RVA: 0x0005E328 File Offset: 0x0005C528
	// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000E8DC File Offset: 0x0000CADC
	public unsafe PlayerOnlineStatus m_OnlineStatus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_OnlineStatus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_Profile.NativeFieldInfoPtr_m_OnlineStatus)) = value;
		}
	}

	// Token: 0x04000F65 RID: 3941
	private static readonly IntPtr NativeFieldInfoPtr_m_friendNameLabel;

	// Token: 0x04000F66 RID: 3942
	private static readonly IntPtr NativeFieldInfoPtr_m_ratingLabel;

	// Token: 0x04000F67 RID: 3943
	private static readonly IntPtr NativeFieldInfoPtr_m_ratingBase;

	// Token: 0x04000F68 RID: 3944
	private static readonly IntPtr NativeFieldInfoPtr_m_activeGlow;

	// Token: 0x04000F69 RID: 3945
	private static readonly IntPtr NativeFieldInfoPtr_m_statusBase;

	// Token: 0x04000F6A RID: 3946
	private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

	// Token: 0x04000F6B RID: 3947
	private static readonly IntPtr NativeFieldInfoPtr_m_dragSource;

	// Token: 0x04000F6C RID: 3948
	private static readonly IntPtr NativeFieldInfoPtr_m_avatar;

	// Token: 0x04000F6D RID: 3949
	private static readonly IntPtr NativeFieldInfoPtr_m_button;

	// Token: 0x04000F6E RID: 3950
	private static readonly IntPtr NativeFieldInfoPtr_m_onlineIndicator;

	// Token: 0x04000F6F RID: 3951
	private static readonly IntPtr NativeFieldInfoPtr_m_indicatorSprites;

	// Token: 0x04000F70 RID: 3952
	private static readonly IntPtr NativeFieldInfoPtr_m_baseNodes;

	// Token: 0x04000F71 RID: 3953
	private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

	// Token: 0x04000F72 RID: 3954
	private static readonly IntPtr NativeFieldInfoPtr_m_FriendData;

	// Token: 0x04000F73 RID: 3955
	private static readonly IntPtr NativeFieldInfoPtr_m_OfflineProfile;

	// Token: 0x04000F74 RID: 3956
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatus;

	// Token: 0x04000F75 RID: 3957
	private static readonly IntPtr NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0;

	// Token: 0x04000F76 RID: 3958
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x04000F77 RID: 3959
	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_0;

	// Token: 0x04000F78 RID: 3960
	private static readonly IntPtr NativeMethodInfoPtr_GetUserID_Public_UInt32_0;

	// Token: 0x04000F79 RID: 3961
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendInfo_Public_FriendInfo_0;

	// Token: 0x04000F7A RID: 3962
	private static readonly IntPtr NativeMethodInfoPtr_GetOfflineProfile_Public_OfflineProfileEntry_0;

	// Token: 0x04000F7B RID: 3963
	private static readonly IntPtr NativeMethodInfoPtr_HideObject_Public_Void_0;

	// Token: 0x04000F7C RID: 3964
	private static readonly IntPtr NativeMethodInfoPtr_ShowObject_Public_Void_0;

	// Token: 0x04000F7D RID: 3965
	private static readonly IntPtr NativeMethodInfoPtr_SetFriendData_Public_Void_FriendInfo_0;

	// Token: 0x04000F7E RID: 3966
	private static readonly IntPtr NativeMethodInfoPtr_SetOfflineData_Public_Void_OfflineProfileEntry_Int32_0;

	// Token: 0x04000F7F RID: 3967
	private static readonly IntPtr NativeMethodInfoPtr_SetDraggable_Public_Void_Boolean_Canvas_0;

	// Token: 0x04000F80 RID: 3968
	private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

	// Token: 0x04000F81 RID: 3969
	private static readonly IntPtr NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0;

	// Token: 0x04000F82 RID: 3970
	private static readonly IntPtr NativeMethodInfoPtr_GetIsSelected_Public_Boolean_0;

	// Token: 0x04000F83 RID: 3971
	private static readonly IntPtr NativeMethodInfoPtr_SetFriendName_Public_Void_String_0;

	// Token: 0x04000F84 RID: 3972
	private static readonly IntPtr NativeMethodInfoPtr_SetRating_Public_Void_UInt16_0;

	// Token: 0x04000F85 RID: 3973
	private static readonly IntPtr NativeMethodInfoPtr_SetAvatar_Public_Void_UInt16_0;

	// Token: 0x04000F86 RID: 3974
	private static readonly IntPtr NativeMethodInfoPtr_SetUserID_Public_Void_UInt32_0;

	// Token: 0x04000F87 RID: 3975
	private static readonly IntPtr NativeMethodInfoPtr_GetOnlineStatus_Public_PlayerOnlineStatus_0;

	// Token: 0x04000F88 RID: 3976
	private static readonly IntPtr NativeMethodInfoPtr_SetOnlineStatus_Public_Void_PlayerOnlineStatus_0;

	// Token: 0x04000F89 RID: 3977
	private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Void_0;

	// Token: 0x04000F8A RID: 3978
	private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Public_Boolean_0;

	// Token: 0x04000F8B RID: 3979
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001D3 RID: 467
	public enum ClickEventType
	{
		// Token: 0x04001AC1 RID: 6849
		Evt_Click_Slot
	}

	// Token: 0x020001D4 RID: 468
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x0008DFA0 File Offset: 0x0008C1A0
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_Profile>.NativeClassPtr, "ClickCallback");
			UIP_Profile.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr, 100666364);
			UIP_Profile.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr, 100666365);
			UIP_Profile.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr, 100666366);
			UIP_Profile.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr, 100666367);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0008E014 File Offset: 0x0008C214
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_Profile.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0008E070 File Offset: 0x0008C270
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_Profile slot, UIP_Profile.ClickEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0008E0C0 File Offset: 0x0008C2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247698, XrefRangeEnd = 247702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_Profile slot, UIP_Profile.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0008E144 File Offset: 0x0008C344
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_Profile.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00017ED8 File Offset: 0x000160D8
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00017EE1 File Offset: 0x000160E1
		public static implicit operator UIP_Profile.ClickCallback(Action<UIP_Profile, UIP_Profile.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIP_Profile.ClickCallback>(A_0);
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00017EE9 File Offset: 0x000160E9
		public static UIP_Profile.ClickCallback operator +(UIP_Profile.ClickCallback A_0, UIP_Profile.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIP_Profile.ClickCallback>();
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00017EF7 File Offset: 0x000160F7
		public static UIP_Profile.ClickCallback operator -(UIP_Profile.ClickCallback A_0, UIP_Profile.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIP_Profile.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
