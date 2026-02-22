using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200006C RID: 108
public class Achievements_Android : AchievementInterface
{
	// Token: 0x06000E2D RID: 3629 RVA: 0x00043240 File Offset: 0x00041440
	// Note: this type is marked as 'beforefieldinit'.
	static Achievements_Android()
	{
		Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Achievements_Android");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr);
		Achievements_Android.NativeFieldInfoPtr_m_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, "m_achievements");
		Achievements_Android.NativeFieldInfoPtr_m_LastConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, "m_LastConnectionState");
		Achievements_Android.NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, "m_Initialized");
		Achievements_Android.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664281);
		Achievements_Android.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664282);
		Achievements_Android.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664283);
		Achievements_Android.NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664284);
		Achievements_Android.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664285);
		Achievements_Android.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664286);
		Achievements_Android.NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664287);
		Achievements_Android.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr, 100664288);
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x0004334C File Offset: 0x0004154C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238890, XrefRangeEnd = 238898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Android.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00043380 File Offset: 0x00041580
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238898, XrefRangeEnd = 238953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Android.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x000433B4 File Offset: 0x000415B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238953, XrefRangeEnd = 238991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(Il2CppReferenceArray<AchievementData> achievementList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(achievementList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Android.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00043404 File Offset: 0x00041604
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238991, XrefRangeEnd = 239009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionConnectionResultReceived(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Android.NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00043448 File Offset: 0x00041648
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239009, XrefRangeEnd = 239056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementsLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Android.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x0004348C File Offset: 0x0004168C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239056, XrefRangeEnd = 239075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Android.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x000434E4 File Offset: 0x000416E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239075, XrefRangeEnd = 239083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetUsername()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievements_Android.NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00043528 File Offset: 0x00041728
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Achievements_Android()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievements_Android>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_Android.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0000A46E File Offset: 0x0000866E
	public Achievements_Android(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00043564 File Offset: 0x00041764
	// (set) Token: 0x06000E38 RID: 3640 RVA: 0x0000A477 File Offset: 0x00008677
	public unsafe Il2CppReferenceArray<AchievementData> m_achievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_achievements);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00043594 File Offset: 0x00041794
	// (set) Token: 0x06000E3A RID: 3642 RVA: 0x0000A496 File Offset: 0x00008696
	public unsafe GPConnectionState m_LastConnectionState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_LastConnectionState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_LastConnectionState)) = value;
		}
	}

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06000E3B RID: 3643 RVA: 0x000435BC File Offset: 0x000417BC
	// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0000A4B1 File Offset: 0x000086B1
	public unsafe bool m_Initialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_Initialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_Android.NativeFieldInfoPtr_m_Initialized)) = value;
		}
	}

	// Token: 0x040009B3 RID: 2483
	private static readonly IntPtr NativeFieldInfoPtr_m_achievements;

	// Token: 0x040009B4 RID: 2484
	private static readonly IntPtr NativeFieldInfoPtr_m_LastConnectionState;

	// Token: 0x040009B5 RID: 2485
	private static readonly IntPtr NativeFieldInfoPtr_m_Initialized;

	// Token: 0x040009B6 RID: 2486
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040009B7 RID: 2487
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040009B8 RID: 2488
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Il2CppReferenceArray_1_AchievementData_0;

	// Token: 0x040009B9 RID: 2489
	private static readonly IntPtr NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x040009BA RID: 2490
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x040009BB RID: 2491
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_Void_EAchievements_Int64_0;

	// Token: 0x040009BC RID: 2492
	private static readonly IntPtr NativeMethodInfoPtr_GetUsername_Public_Virtual_String_0;

	// Token: 0x040009BD RID: 2493
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
