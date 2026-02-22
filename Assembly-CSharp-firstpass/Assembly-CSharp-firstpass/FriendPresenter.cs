using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000127 RID: 295
public class FriendPresenter : MonoBehaviour
{
	// Token: 0x06001462 RID: 5218 RVA: 0x0005D894 File Offset: 0x0005BA94
	// Note: this type is marked as 'beforefieldinit'.
	static FriendPresenter()
	{
		Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FriendPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr);
		FriendPresenter.NativeFieldInfoPtr__pId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, "_pId");
		FriendPresenter.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, "avatar");
		FriendPresenter.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, "playerId");
		FriendPresenter.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, "playerName");
		FriendPresenter.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, "defaulttexture");
		FriendPresenter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, 100665775);
		FriendPresenter.NativeMethodInfoPtr_SetFriendId_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, 100665776);
		FriendPresenter.NativeMethodInfoPtr_PlayWithFried_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, 100665777);
		FriendPresenter.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, 100665778);
		FriendPresenter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr, 100665779);
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x0005D98C File Offset: 0x0005BB8C
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendPresenter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x0005D9C0 File Offset: 0x0005BBC0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187277, RefRangeEnd = 187279, XrefRangeStart = 187251, XrefRangeEnd = 187277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFriendId(string pId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendPresenter.NativeMethodInfoPtr_SetFriendId_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x0005DA04 File Offset: 0x0005BC04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187279, XrefRangeEnd = 187290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayWithFried()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendPresenter.NativeMethodInfoPtr_PlayWithFried_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x0005DA38 File Offset: 0x0005BC38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187290, XrefRangeEnd = 187294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendPresenter.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x0005DA6C File Offset: 0x0005BC6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187294, XrefRangeEnd = 187297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendPresenter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00009ED3 File Offset: 0x000080D3
	public FriendPresenter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005DAA8 File Offset: 0x0005BCA8
	// (set) Token: 0x0600146A RID: 5226 RVA: 0x00009EDC File Offset: 0x000080DC
	public unsafe string _pId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr__pId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr__pId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
	// (set) Token: 0x0600146C RID: 5228 RVA: 0x00009EFB File Offset: 0x000080FB
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005DB00 File Offset: 0x0005BD00
	// (set) Token: 0x0600146E RID: 5230 RVA: 0x00009F1A File Offset: 0x0000811A
	public unsafe Text playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005DB30 File Offset: 0x0005BD30
	// (set) Token: 0x06001470 RID: 5232 RVA: 0x00009F39 File Offset: 0x00008139
	public unsafe Text playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005DB60 File Offset: 0x0005BD60
	// (set) Token: 0x06001472 RID: 5234 RVA: 0x00009F58 File Offset: 0x00008158
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendPresenter.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F8A RID: 3978
	private static readonly IntPtr NativeFieldInfoPtr__pId;

	// Token: 0x04000F8B RID: 3979
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000F8C RID: 3980
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000F8D RID: 3981
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000F8E RID: 3982
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000F8F RID: 3983
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000F90 RID: 3984
	private static readonly IntPtr NativeMethodInfoPtr_SetFriendId_Public_Void_String_0;

	// Token: 0x04000F91 RID: 3985
	private static readonly IntPtr NativeMethodInfoPtr_PlayWithFried_Public_Void_0;

	// Token: 0x04000F92 RID: 3986
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000F93 RID: 3987
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
