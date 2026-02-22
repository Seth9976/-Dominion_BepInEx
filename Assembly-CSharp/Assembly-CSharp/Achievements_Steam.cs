using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Steamworks;

// Token: 0x02000070 RID: 112
public class Achievements_Steam : AchievementInterface
{
	// Token: 0x06000E6B RID: 3691 RVA: 0x00043E00 File Offset: 0x00042000
	// Note: this type is marked as 'beforefieldinit'.
	static Achievements_Steam()
	{
		Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Achievements_Steam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr);
		Achievements_Steam.NativeFieldInfoPtr_m_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_achievements");
		Achievements_Steam.NativeFieldInfoPtr_m_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_GameID");
		Achievements_Steam.NativeFieldInfoPtr_m_bRequestedStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_bRequestedStats");
		Achievements_Steam.NativeFieldInfoPtr_m_bStatsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_bStatsValid");
		Achievements_Steam.NativeFieldInfoPtr_m_bStoreStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_bStoreStats");
		Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_CallbackUserStatsReceived");
		Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_CallbackUserStatsStored");
		Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserAchievementStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, "m_CallbackUserAchievementStored");
		Achievements_Steam.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664303);
		Achievements_Steam.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664304);
		Achievements_Steam.NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664305);
		Achievements_Steam.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664306);
		Achievements_Steam.NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664307);
		Achievements_Steam.NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664308);
		Achievements_Steam.NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664309);
		Achievements_Steam.NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664310);
		Achievements_Steam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr, 100664311);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00043F84 File Offset: 0x00042184
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239563, XrefRangeEnd = 239572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Steam.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00043FB8 File Offset: 0x000421B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239572, XrefRangeEnd = 239608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(Il2CppReferenceArray<AchievementData> achievementList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(achievementList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Steam.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00044008 File Offset: 0x00042208
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResetAllAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Steam.NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00044044 File Offset: 0x00042244
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239608, XrefRangeEnd = 239618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void IncrementAchievement(EAchievements id, long plusValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref plusValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Steam.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0004409C File Offset: 0x0004229C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239618, XrefRangeEnd = 239649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementStored(UserAchievementStored_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pCallback));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Steam.NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x000440E4 File Offset: 0x000422E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239649, XrefRangeEnd = 239662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserStatsStored(UserStatsStored_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Steam.NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00044124 File Offset: 0x00042324
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239662, XrefRangeEnd = 239676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserStatsReceived(UserStatsReceived_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Steam.NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00044164 File Offset: 0x00042364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239676, XrefRangeEnd = 239678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetUsername()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Steam.NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x000441A8 File Offset: 0x000423A8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Achievements_Steam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievements_Steam>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Steam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x0000A662 File Offset: 0x00008862
	public Achievements_Steam(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000441E4 File Offset: 0x000423E4
	// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0000A66B File Offset: 0x0000886B
	public unsafe Il2CppReferenceArray<AchievementData> m_achievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_achievements);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00044214 File Offset: 0x00042414
	// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0000A68A File Offset: 0x0000888A
	public unsafe CGameID m_GameID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_GameID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_GameID)) = value;
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0004423C File Offset: 0x0004243C
	// (set) Token: 0x06000E7B RID: 3707 RVA: 0x0000A6A5 File Offset: 0x000088A5
	public unsafe bool m_bRequestedStats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bRequestedStats);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bRequestedStats)) = value;
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00044264 File Offset: 0x00042464
	// (set) Token: 0x06000E7D RID: 3709 RVA: 0x0000A6C0 File Offset: 0x000088C0
	public unsafe bool m_bStatsValid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bStatsValid);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bStatsValid)) = value;
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0004428C File Offset: 0x0004248C
	// (set) Token: 0x06000E7F RID: 3711 RVA: 0x0000A6DB File Offset: 0x000088DB
	public unsafe bool m_bStoreStats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bStoreStats);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_bStoreStats)) = value;
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06000E80 RID: 3712 RVA: 0x000442B4 File Offset: 0x000424B4
	// (set) Token: 0x06000E81 RID: 3713 RVA: 0x0000A6F6 File Offset: 0x000088F6
	public unsafe Callback<UserStatsReceived_t> m_CallbackUserStatsReceived
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsReceived);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<UserStatsReceived_t>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000442E4 File Offset: 0x000424E4
	// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0000A715 File Offset: 0x00008915
	public unsafe Callback<UserStatsStored_t> m_CallbackUserStatsStored
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsStored);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<UserStatsStored_t>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserStatsStored), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00044314 File Offset: 0x00042514
	// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0000A734 File Offset: 0x00008934
	public unsafe Callback<UserAchievementStored_t> m_CallbackUserAchievementStored
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserAchievementStored);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<UserAchievementStored_t>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Steam.NativeFieldInfoPtr_m_CallbackUserAchievementStored), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009D9 RID: 2521
	private static readonly IntPtr NativeFieldInfoPtr_m_achievements;

	// Token: 0x040009DA RID: 2522
	private static readonly IntPtr NativeFieldInfoPtr_m_GameID;

	// Token: 0x040009DB RID: 2523
	private static readonly IntPtr NativeFieldInfoPtr_m_bRequestedStats;

	// Token: 0x040009DC RID: 2524
	private static readonly IntPtr NativeFieldInfoPtr_m_bStatsValid;

	// Token: 0x040009DD RID: 2525
	private static readonly IntPtr NativeFieldInfoPtr_m_bStoreStats;

	// Token: 0x040009DE RID: 2526
	private static readonly IntPtr NativeFieldInfoPtr_m_CallbackUserStatsReceived;

	// Token: 0x040009DF RID: 2527
	private static readonly IntPtr NativeFieldInfoPtr_m_CallbackUserStatsStored;

	// Token: 0x040009E0 RID: 2528
	private static readonly IntPtr NativeFieldInfoPtr_m_CallbackUserAchievementStored;

	// Token: 0x040009E1 RID: 2529
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040009E2 RID: 2530
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0;

	// Token: 0x040009E3 RID: 2531
	private static readonly IntPtr NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_Void_0;

	// Token: 0x040009E4 RID: 2532
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0;

	// Token: 0x040009E5 RID: 2533
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0;

	// Token: 0x040009E6 RID: 2534
	private static readonly IntPtr NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0;

	// Token: 0x040009E7 RID: 2535
	private static readonly IntPtr NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0;

	// Token: 0x040009E8 RID: 2536
	private static readonly IntPtr NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0;

	// Token: 0x040009E9 RID: 2537
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
