using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200007B RID: 123
public class AchievementManagerWrapper : MonoBehaviour
{
	// Token: 0x06000F54 RID: 3924 RVA: 0x00046B74 File Offset: 0x00044D74
	// Note: this type is marked as 'beforefieldinit'.
	static AchievementManagerWrapper()
	{
		Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AchievementManagerWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr);
		AchievementManagerWrapper.NativeFieldInfoPtr_m_VersionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_VersionManager");
		AchievementManagerWrapper.NativeFieldInfoPtr_m_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_achievements");
		AchievementManagerWrapper.NativeFieldInfoPtr_m_PlatformManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_PlatformManagers");
		AchievementManagerWrapper.NativeFieldInfoPtr_m_ActiveManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_ActiveManager");
		AchievementManagerWrapper.NativeFieldInfoPtr_m_bEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_bEnabled");
		AchievementManagerWrapper.NativeFieldInfoPtr_m_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "m_queue");
		AchievementManagerWrapper.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "_instance");
		AchievementManagerWrapper.NativeMethodInfoPtr_get_instance_Public_Static_get_AchievementManagerWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664386);
		AchievementManagerWrapper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664387);
		AchievementManagerWrapper.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664388);
		AchievementManagerWrapper.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664389);
		AchievementManagerWrapper.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664390);
		AchievementManagerWrapper.NativeMethodInfoPtr_GetAchievement_Public_AchievementData_EAchievements_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664391);
		AchievementManagerWrapper.NativeMethodInfoPtr_IncrementAchievement_Public_Void_EAchievements_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664392);
		AchievementManagerWrapper.NativeMethodInfoPtr_ResetAchievementData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664393);
		AchievementManagerWrapper.NativeMethodInfoPtr_ClearQueue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664394);
		AchievementManagerWrapper.NativeMethodInfoPtr_CommitQueue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664395);
		AchievementManagerWrapper.NativeMethodInfoPtr_IncrementQueuedAchievement_Private_Void_EAchievements_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664396);
		AchievementManagerWrapper.NativeMethodInfoPtr_SaveData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664397);
		AchievementManagerWrapper.NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_EAchievements_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664398);
		AchievementManagerWrapper.NativeMethodInfoPtr_GetPlatformBasedUsername_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664399);
		AchievementManagerWrapper.NativeMethodInfoPtr_CountBits_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664400);
		AchievementManagerWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, 100664401);
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00046D70 File Offset: 0x00044F70
	public unsafe static AchievementManagerWrapper instance
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 240452, RefRangeEnd = 240460, XrefRangeStart = 240411, XrefRangeEnd = 240452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_get_instance_Public_Static_get_AchievementManagerWrapper_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementManagerWrapper>(intPtr3) : null;
		}
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00046DA4 File Offset: 0x00044FA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240460, XrefRangeEnd = 240497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00046DD8 File Offset: 0x00044FD8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00046E0C File Offset: 0x0004500C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240497, XrefRangeEnd = 240498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00046E40 File Offset: 0x00045040
	[CallerCount(0)]
	public unsafe void SetEnabled(bool bEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00046E80 File Offset: 0x00045080
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240498, XrefRangeEnd = 240501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AchievementData GetAchievement(EAchievements id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_GetAchievement_Public_AchievementData_EAchievements_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AchievementData(intPtr);
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00046EC4 File Offset: 0x000450C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240519, RefRangeEnd = 240520, XrefRangeStart = 240501, XrefRangeEnd = 240519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementAchievement(EAchievements id, long addedValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_IncrementAchievement_Public_Void_EAchievements_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00046F10 File Offset: 0x00045110
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAchievementData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_ResetAchievementData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00046F44 File Offset: 0x00045144
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240524, RefRangeEnd = 240526, XrefRangeStart = 240520, XrefRangeEnd = 240524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearQueue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_ClearQueue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00046F78 File Offset: 0x00045178
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 240549, RefRangeEnd = 240552, XrefRangeStart = 240526, XrefRangeEnd = 240549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CommitQueue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_CommitQueue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00046FAC File Offset: 0x000451AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240552, XrefRangeEnd = 240556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementQueuedAchievement(EAchievements id, long addedValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_IncrementQueuedAchievement_Private_Void_EAchievements_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00046FF8 File Offset: 0x000451F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240564, RefRangeEnd = 240566, XrefRangeStart = 240556, XrefRangeEnd = 240564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_SaveData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x0004702C File Offset: 0x0004522C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240566, XrefRangeEnd = 240570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAchievementUnlocked(EAchievements id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_EAchievements_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00047078 File Offset: 0x00045278
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240570, XrefRangeEnd = 240576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPlatformBasedUsername()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_GetPlatformBasedUsername_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x000470B0 File Offset: 0x000452B0
	[CallerCount(0)]
	public unsafe static int CountBits(long value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr_CountBits_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x000470F0 File Offset: 0x000452F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240576, XrefRangeEnd = 240583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AchievementManagerWrapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManagerWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x0000ADF5 File Offset: 0x00008FF5
	public AchievementManagerWrapper(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004712C File Offset: 0x0004532C
	// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0000ADFE File Offset: 0x00008FFE
	public unsafe VersionManager m_VersionManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_VersionManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_VersionManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004715C File Offset: 0x0004535C
	// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0000AE1D File Offset: 0x0000901D
	public unsafe Il2CppReferenceArray<AchievementData> m_achievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_achievements);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004718C File Offset: 0x0004538C
	// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0000AE3C File Offset: 0x0000903C
	public unsafe Il2CppReferenceArray<AchievementInterface> m_PlatformManagers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_PlatformManagers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementInterface>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_PlatformManagers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06000F6C RID: 3948 RVA: 0x000471BC File Offset: 0x000453BC
	// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0000AE5B File Offset: 0x0000905B
	public unsafe AchievementInterface m_ActiveManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_ActiveManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementInterface>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_ActiveManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000471EC File Offset: 0x000453EC
	// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0000AE7A File Offset: 0x0000907A
	public unsafe bool m_bEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_bEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_bEnabled)) = value;
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00047214 File Offset: 0x00045414
	// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000AE95 File Offset: 0x00009095
	public unsafe List<AchievementManagerWrapper.QueuedAchievementProgress> m_queue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_queue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AchievementManagerWrapper.QueuedAchievementProgress>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManagerWrapper.NativeFieldInfoPtr_m_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00047244 File Offset: 0x00045444
	// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0000AEB4 File Offset: 0x000090B4
	public unsafe static AchievementManagerWrapper _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AchievementManagerWrapper.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManagerWrapper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AchievementManagerWrapper.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000AC0 RID: 2752
	private static readonly IntPtr NativeFieldInfoPtr_m_VersionManager;

	// Token: 0x04000AC1 RID: 2753
	private static readonly IntPtr NativeFieldInfoPtr_m_achievements;

	// Token: 0x04000AC2 RID: 2754
	private static readonly IntPtr NativeFieldInfoPtr_m_PlatformManagers;

	// Token: 0x04000AC3 RID: 2755
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveManager;

	// Token: 0x04000AC4 RID: 2756
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnabled;

	// Token: 0x04000AC5 RID: 2757
	private static readonly IntPtr NativeFieldInfoPtr_m_queue;

	// Token: 0x04000AC6 RID: 2758
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000AC7 RID: 2759
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_AchievementManagerWrapper_0;

	// Token: 0x04000AC8 RID: 2760
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000AC9 RID: 2761
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000ACA RID: 2762
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000ACB RID: 2763
	private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

	// Token: 0x04000ACC RID: 2764
	private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Public_AchievementData_EAchievements_0;

	// Token: 0x04000ACD RID: 2765
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievement_Public_Void_EAchievements_Int64_0;

	// Token: 0x04000ACE RID: 2766
	private static readonly IntPtr NativeMethodInfoPtr_ResetAchievementData_Public_Void_0;

	// Token: 0x04000ACF RID: 2767
	private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Public_Void_0;

	// Token: 0x04000AD0 RID: 2768
	private static readonly IntPtr NativeMethodInfoPtr_CommitQueue_Public_Void_0;

	// Token: 0x04000AD1 RID: 2769
	private static readonly IntPtr NativeMethodInfoPtr_IncrementQueuedAchievement_Private_Void_EAchievements_Int64_0;

	// Token: 0x04000AD2 RID: 2770
	private static readonly IntPtr NativeMethodInfoPtr_SaveData_Public_Void_0;

	// Token: 0x04000AD3 RID: 2771
	private static readonly IntPtr NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_EAchievements_0;

	// Token: 0x04000AD4 RID: 2772
	private static readonly IntPtr NativeMethodInfoPtr_GetPlatformBasedUsername_Public_String_0;

	// Token: 0x04000AD5 RID: 2773
	private static readonly IntPtr NativeMethodInfoPtr_CountBits_Public_Static_Int32_Int64_0;

	// Token: 0x04000AD6 RID: 2774
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018F RID: 399
	[StructLayout(2)]
	public struct QueuedAchievementProgress
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x000874A4 File Offset: 0x000856A4
		// Note: this type is marked as 'beforefieldinit'.
		static QueuedAchievementProgress()
		{
			Il2CppClassPointerStore<AchievementManagerWrapper.QueuedAchievementProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManagerWrapper>.NativeClassPtr, "QueuedAchievementProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManagerWrapper.QueuedAchievementProgress>.NativeClassPtr);
			AchievementManagerWrapper.QueuedAchievementProgress.NativeFieldInfoPtr_achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper.QueuedAchievementProgress>.NativeClassPtr, "achievement");
			AchievementManagerWrapper.QueuedAchievementProgress.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManagerWrapper.QueuedAchievementProgress>.NativeClassPtr, "progress");
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x000169E1 File Offset: 0x00014BE1
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementManagerWrapper.QueuedAchievementProgress>.NativeClassPtr, ref this));
		}

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr_achievement;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x0400193F RID: 6463
		[FieldOffset(0)]
		public EAchievements achievement;

		// Token: 0x04001940 RID: 6464
		[FieldOffset(8)]
		public long progress;
	}
}
