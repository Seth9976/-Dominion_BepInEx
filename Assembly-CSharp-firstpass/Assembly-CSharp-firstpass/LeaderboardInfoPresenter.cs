using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012B RID: 299
public class LeaderboardInfoPresenter : MonoBehaviour
{
	// Token: 0x06001531 RID: 5425 RVA: 0x00060258 File Offset: 0x0005E458
	// Note: this type is marked as 'beforefieldinit'.
	static LeaderboardInfoPresenter()
	{
		Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeaderboardInfoPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr);
		LeaderboardInfoPresenter.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "Rank");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "Score");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_PlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "PlayerId");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "Name");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "Avatar");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "id");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "playerName");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "rank");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "score");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "avatar");
		LeaderboardInfoPresenter.NativeFieldInfoPtr_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, "old");
		LeaderboardInfoPresenter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, 100665862);
		LeaderboardInfoPresenter.NativeMethodInfoPtr_SetInfo_Public_Void_String_String_String_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, 100665863);
		LeaderboardInfoPresenter.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, 100665864);
		LeaderboardInfoPresenter.NativeMethodInfoPtr_UpdateUi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, 100665865);
		LeaderboardInfoPresenter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr, 100665866);
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x000603C8 File Offset: 0x0005E5C8
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardInfoPresenter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x000603FC File Offset: 0x0005E5FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 189800, RefRangeEnd = 189801, XrefRangeStart = 189790, XrefRangeEnd = 189800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfo(string rank, string score, string id, string name, Texture2D icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rank);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(score);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardInfoPresenter.NativeMethodInfoPtr_SetInfo_Public_Void_String_String_String_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00060488 File Offset: 0x0005E688
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 189807, RefRangeEnd = 189808, XrefRangeStart = 189801, XrefRangeEnd = 189807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardInfoPresenter.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x000604BC File Offset: 0x0005E6BC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 189815, RefRangeEnd = 189819, XrefRangeStart = 189808, XrefRangeEnd = 189815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardInfoPresenter.NativeMethodInfoPtr_UpdateUi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x000604F0 File Offset: 0x0005E6F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189819, XrefRangeEnd = 189825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeaderboardInfoPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardInfoPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardInfoPresenter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0000A57A File Offset: 0x0000877A
	public LeaderboardInfoPresenter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06001538 RID: 5432 RVA: 0x0006052C File Offset: 0x0005E72C
	// (set) Token: 0x06001539 RID: 5433 RVA: 0x0000A583 File Offset: 0x00008783
	public unsafe Text Rank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Rank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Rank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x0600153A RID: 5434 RVA: 0x0006055C File Offset: 0x0005E75C
	// (set) Token: 0x0600153B RID: 5435 RVA: 0x0000A5A2 File Offset: 0x000087A2
	public unsafe Text Score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Score);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Score), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x0600153C RID: 5436 RVA: 0x0006058C File Offset: 0x0005E78C
	// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000A5C1 File Offset: 0x000087C1
	public unsafe Text PlayerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_PlayerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_PlayerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x000605BC File Offset: 0x0005E7BC
	// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000A5E0 File Offset: 0x000087E0
	public unsafe Text Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x06001540 RID: 5440 RVA: 0x000605EC File Offset: 0x0005E7EC
	// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000A5FF File Offset: 0x000087FF
	public unsafe Image Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x06001542 RID: 5442 RVA: 0x0006061C File Offset: 0x0005E81C
	// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000A61E File Offset: 0x0000881E
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x06001544 RID: 5444 RVA: 0x00060644 File Offset: 0x0005E844
	// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000A63D File Offset: 0x0000883D
	public unsafe string playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_playerName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x06001546 RID: 5446 RVA: 0x0006066C File Offset: 0x0005E86C
	// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000A65C File Offset: 0x0000885C
	public unsafe string rank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_rank);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_rank), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x06001548 RID: 5448 RVA: 0x00060694 File Offset: 0x0005E894
	// (set) Token: 0x06001549 RID: 5449 RVA: 0x0000A67B File Offset: 0x0000887B
	public unsafe string score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_score);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_score), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x000606BC File Offset: 0x0005E8BC
	// (set) Token: 0x0600154B RID: 5451 RVA: 0x0000A69A File Offset: 0x0000889A
	public unsafe Sprite avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x0600154C RID: 5452 RVA: 0x000606EC File Offset: 0x0005E8EC
	// (set) Token: 0x0600154D RID: 5453 RVA: 0x0000A6B9 File Offset: 0x000088B9
	public unsafe Sprite old
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_old);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardInfoPresenter.NativeFieldInfoPtr_old), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001019 RID: 4121
	private static readonly IntPtr NativeFieldInfoPtr_Rank;

	// Token: 0x0400101A RID: 4122
	private static readonly IntPtr NativeFieldInfoPtr_Score;

	// Token: 0x0400101B RID: 4123
	private static readonly IntPtr NativeFieldInfoPtr_PlayerId;

	// Token: 0x0400101C RID: 4124
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x0400101D RID: 4125
	private static readonly IntPtr NativeFieldInfoPtr_Avatar;

	// Token: 0x0400101E RID: 4126
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x0400101F RID: 4127
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04001020 RID: 4128
	private static readonly IntPtr NativeFieldInfoPtr_rank;

	// Token: 0x04001021 RID: 4129
	private static readonly IntPtr NativeFieldInfoPtr_score;

	// Token: 0x04001022 RID: 4130
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04001023 RID: 4131
	private static readonly IntPtr NativeFieldInfoPtr_old;

	// Token: 0x04001024 RID: 4132
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04001025 RID: 4133
	private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Public_Void_String_String_String_String_Texture2D_0;

	// Token: 0x04001026 RID: 4134
	private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

	// Token: 0x04001027 RID: 4135
	private static readonly IntPtr NativeMethodInfoPtr_UpdateUi_Private_Void_0;

	// Token: 0x04001028 RID: 4136
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
