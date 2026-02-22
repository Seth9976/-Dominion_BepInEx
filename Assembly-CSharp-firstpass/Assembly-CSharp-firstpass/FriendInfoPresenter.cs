using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000126 RID: 294
public class FriendInfoPresenter : MonoBehaviour
{
	// Token: 0x06001448 RID: 5192 RVA: 0x0005D464 File Offset: 0x0005B664
	// Note: this type is marked as 'beforefieldinit'.
	static FriendInfoPresenter()
	{
		Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FriendInfoPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr);
		FriendInfoPresenter.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "Id");
		FriendInfoPresenter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "Name");
		FriendInfoPresenter.NativeFieldInfoPtr_HasIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "HasIcon");
		FriendInfoPresenter.NativeFieldInfoPtr_HasImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "HasImage");
		FriendInfoPresenter.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "Avatar");
		FriendInfoPresenter.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "playerId");
		FriendInfoPresenter.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "playerName");
		FriendInfoPresenter.NativeFieldInfoPtr_hasIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "hasIcon");
		FriendInfoPresenter.NativeFieldInfoPtr_hasImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "hasImage");
		FriendInfoPresenter.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, "avatar");
		FriendInfoPresenter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, 100665771);
		FriendInfoPresenter.NativeMethodInfoPtr_SetInfo_Public_Void_String_String_Boolean_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, 100665772);
		FriendInfoPresenter.NativeMethodInfoPtr_UpdateUi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, 100665773);
		FriendInfoPresenter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr, 100665774);
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x0005D5AC File Offset: 0x0005B7AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187228, XrefRangeEnd = 187229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInfoPresenter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x0005D5E0 File Offset: 0x0005B7E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187237, RefRangeEnd = 187238, XrefRangeStart = 187229, XrefRangeEnd = 187237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfo(string id, string name, bool icon, bool image, Texture2D srcImage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icon;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref image;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(srcImage);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInfoPresenter.NativeMethodInfoPtr_SetInfo_Public_Void_String_String_Boolean_Boolean_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x0005D664 File Offset: 0x0005B864
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187245, RefRangeEnd = 187247, XrefRangeStart = 187238, XrefRangeEnd = 187245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInfoPresenter.NativeMethodInfoPtr_UpdateUi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x0005D698 File Offset: 0x0005B898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187247, XrefRangeEnd = 187251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendInfoPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendInfoPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInfoPresenter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00009D9C File Offset: 0x00007F9C
	public FriendInfoPresenter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
	// (set) Token: 0x0600144F RID: 5199 RVA: 0x00009DA5 File Offset: 0x00007FA5
	public unsafe Text Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06001450 RID: 5200 RVA: 0x0005D704 File Offset: 0x0005B904
	// (set) Token: 0x06001451 RID: 5201 RVA: 0x00009DC4 File Offset: 0x00007FC4
	public unsafe Text Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06001452 RID: 5202 RVA: 0x0005D734 File Offset: 0x0005B934
	// (set) Token: 0x06001453 RID: 5203 RVA: 0x00009DE3 File Offset: 0x00007FE3
	public unsafe Toggle HasIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_HasIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_HasIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x0005D764 File Offset: 0x0005B964
	// (set) Token: 0x06001455 RID: 5205 RVA: 0x00009E02 File Offset: 0x00008002
	public unsafe Toggle HasImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_HasImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_HasImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x06001456 RID: 5206 RVA: 0x0005D794 File Offset: 0x0005B994
	// (set) Token: 0x06001457 RID: 5207 RVA: 0x00009E21 File Offset: 0x00008021
	public unsafe Image Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x06001458 RID: 5208 RVA: 0x0005D7C4 File Offset: 0x0005B9C4
	// (set) Token: 0x06001459 RID: 5209 RVA: 0x00009E40 File Offset: 0x00008040
	public unsafe string playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_playerId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_playerId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x0600145A RID: 5210 RVA: 0x0005D7EC File Offset: 0x0005B9EC
	// (set) Token: 0x0600145B RID: 5211 RVA: 0x00009E5F File Offset: 0x0000805F
	public unsafe string playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_playerName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x0600145C RID: 5212 RVA: 0x0005D814 File Offset: 0x0005BA14
	// (set) Token: 0x0600145D RID: 5213 RVA: 0x00009E7E File Offset: 0x0000807E
	public unsafe bool hasIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_hasIcon);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_hasIcon)) = value;
		}
	}

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x0600145E RID: 5214 RVA: 0x0005D83C File Offset: 0x0005BA3C
	// (set) Token: 0x0600145F RID: 5215 RVA: 0x00009E99 File Offset: 0x00008099
	public unsafe bool hasImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_hasImage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_hasImage)) = value;
		}
	}

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x06001460 RID: 5216 RVA: 0x0005D864 File Offset: 0x0005BA64
	// (set) Token: 0x06001461 RID: 5217 RVA: 0x00009EB4 File Offset: 0x000080B4
	public unsafe Sprite avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfoPresenter.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F7C RID: 3964
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x04000F7D RID: 3965
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x04000F7E RID: 3966
	private static readonly IntPtr NativeFieldInfoPtr_HasIcon;

	// Token: 0x04000F7F RID: 3967
	private static readonly IntPtr NativeFieldInfoPtr_HasImage;

	// Token: 0x04000F80 RID: 3968
	private static readonly IntPtr NativeFieldInfoPtr_Avatar;

	// Token: 0x04000F81 RID: 3969
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000F82 RID: 3970
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000F83 RID: 3971
	private static readonly IntPtr NativeFieldInfoPtr_hasIcon;

	// Token: 0x04000F84 RID: 3972
	private static readonly IntPtr NativeFieldInfoPtr_hasImage;

	// Token: 0x04000F85 RID: 3973
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000F86 RID: 3974
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000F87 RID: 3975
	private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Public_Void_String_String_Boolean_Boolean_Texture2D_0;

	// Token: 0x04000F88 RID: 3976
	private static readonly IntPtr NativeMethodInfoPtr_UpdateUi_Private_Void_0;

	// Token: 0x04000F89 RID: 3977
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
