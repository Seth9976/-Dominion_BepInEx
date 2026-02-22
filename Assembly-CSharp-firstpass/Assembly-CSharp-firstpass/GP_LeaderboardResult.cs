using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000055 RID: 85
public class GP_LeaderboardResult : GooglePlayResult
{
	// Token: 0x060006BC RID: 1724 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
	// Note: this type is marked as 'beforefieldinit'.
	static GP_LeaderboardResult()
	{
		Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_LeaderboardResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr);
		GP_LeaderboardResult.NativeFieldInfoPtr__Leaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr, "_Leaderboard");
		GP_LeaderboardResult.NativeMethodInfoPtr__ctor_Public_Void_GPLeaderBoard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr, 100664110);
		GP_LeaderboardResult.NativeMethodInfoPtr_SetInfo_Private_Void_GPLeaderBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr, 100664111);
		GP_LeaderboardResult.NativeMethodInfoPtr_get_Leaderboard_Public_get_GPLeaderBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr, 100664112);
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x0002E060 File Offset: 0x0002C260
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166696, XrefRangeEnd = 166697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_LeaderboardResult(GPLeaderBoard leaderboard, string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_LeaderboardResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderboard);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LeaderboardResult.NativeMethodInfoPtr__ctor_Public_Void_GPLeaderBoard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0002E0C0 File Offset: 0x0002C2C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfo(GPLeaderBoard leaderboard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LeaderboardResult.NativeMethodInfoPtr_SetInfo_Private_Void_GPLeaderBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x0002E104 File Offset: 0x0002C304
	public unsafe GPLeaderBoard Leaderboard
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LeaderboardResult.NativeMethodInfoPtr_get_Leaderboard_Public_get_GPLeaderBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPLeaderBoard>(intPtr3) : null;
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00004BE3 File Offset: 0x00002DE3
	public GP_LeaderboardResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0002E144 File Offset: 0x0002C344
	// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00004BEC File Offset: 0x00002DEC
	public unsafe GPLeaderBoard _Leaderboard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LeaderboardResult.NativeFieldInfoPtr__Leaderboard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPLeaderBoard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LeaderboardResult.NativeFieldInfoPtr__Leaderboard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000573 RID: 1395
	private static readonly IntPtr NativeFieldInfoPtr__Leaderboard;

	// Token: 0x04000574 RID: 1396
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GPLeaderBoard_String_0;

	// Token: 0x04000575 RID: 1397
	private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Private_Void_GPLeaderBoard_0;

	// Token: 0x04000576 RID: 1398
	private static readonly IntPtr NativeMethodInfoPtr_get_Leaderboard_Public_get_GPLeaderBoard_0;
}
