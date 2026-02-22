using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000FF RID: 255
public class SA_FriendUI : MonoBehaviour
{
	// Token: 0x0600119D RID: 4509 RVA: 0x00054738 File Offset: 0x00052938
	// Note: this type is marked as 'beforefieldinit'.
	static SA_FriendUI()
	{
		Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_FriendUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr);
		SA_FriendUI.NativeFieldInfoPtr__pId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, "_pId");
		SA_FriendUI.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, "avatar");
		SA_FriendUI.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, "playerId");
		SA_FriendUI.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, "playerName");
		SA_FriendUI.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, "defaulttexture");
		SA_FriendUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, 100665440);
		SA_FriendUI.NativeMethodInfoPtr_SetFriendId_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, 100665441);
		SA_FriendUI.NativeMethodInfoPtr_PlayWithFried_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, 100665442);
		SA_FriendUI.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, 100665443);
		SA_FriendUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr, 100665444);
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00054830 File Offset: 0x00052A30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181853, XrefRangeEnd = 181858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FriendUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00054864 File Offset: 0x00052A64
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181891, RefRangeEnd = 181893, XrefRangeStart = 181858, XrefRangeEnd = 181891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFriendId(string pId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FriendUI.NativeMethodInfoPtr_SetFriendId_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x000548A8 File Offset: 0x00052AA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181893, XrefRangeEnd = 181904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayWithFried()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FriendUI.NativeMethodInfoPtr_PlayWithFried_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x000548DC File Offset: 0x00052ADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181904, XrefRangeEnd = 181908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FriendUI.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00054910 File Offset: 0x00052B10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181908, XrefRangeEnd = 181911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_FriendUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_FriendUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FriendUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00008C5D File Offset: 0x00006E5D
	public SA_FriendUI(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0005494C File Offset: 0x00052B4C
	// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00008C66 File Offset: 0x00006E66
	public unsafe string _pId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr__pId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr__pId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00054974 File Offset: 0x00052B74
	// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00008C85 File Offset: 0x00006E85
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000549A4 File Offset: 0x00052BA4
	// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00008CA4 File Offset: 0x00006EA4
	public unsafe SA_Label playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x060011AA RID: 4522 RVA: 0x000549D4 File Offset: 0x00052BD4
	// (set) Token: 0x060011AB RID: 4523 RVA: 0x00008CC3 File Offset: 0x00006EC3
	public unsafe SA_Label playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x060011AC RID: 4524 RVA: 0x00054A04 File Offset: 0x00052C04
	// (set) Token: 0x060011AD RID: 4525 RVA: 0x00008CE2 File Offset: 0x00006EE2
	public unsafe Texture defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_FriendUI.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D9F RID: 3487
	private static readonly IntPtr NativeFieldInfoPtr__pId;

	// Token: 0x04000DA0 RID: 3488
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000DA1 RID: 3489
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000DA2 RID: 3490
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000DA3 RID: 3491
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000DA4 RID: 3492
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DA5 RID: 3493
	private static readonly IntPtr NativeMethodInfoPtr_SetFriendId_Public_Void_String_0;

	// Token: 0x04000DA6 RID: 3494
	private static readonly IntPtr NativeMethodInfoPtr_PlayWithFried_Public_Void_0;

	// Token: 0x04000DA7 RID: 3495
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000DA8 RID: 3496
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
