using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200007D RID: 125
public static class PlayServiceUtil : Object
{
	// Token: 0x0600091D RID: 2333 RVA: 0x00036284 File Offset: 0x00034484
	// Note: this type is marked as 'beforefieldinit'.
	static PlayServiceUtil()
	{
		Il2CppClassPointerStore<PlayServiceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PlayServiceUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayServiceUtil>.NativeClassPtr);
		PlayServiceUtil.NativeMethodInfoPtr_GetAchievementStateById_Public_Static_GPAchievementState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayServiceUtil>.NativeClassPtr, 100664390);
		PlayServiceUtil.NativeMethodInfoPtr_GetAchievementTypeById_Public_Static_GPAchievementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayServiceUtil>.NativeClassPtr, 100664391);
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x000362DC File Offset: 0x000344DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 170303, RefRangeEnd = 170304, XrefRangeStart = 170303, XrefRangeEnd = 170303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GPAchievementState GetAchievementStateById(int code)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayServiceUtil.NativeMethodInfoPtr_GetAchievementStateById_Public_Static_GPAchievementState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x0003631C File Offset: 0x0003451C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 170304, RefRangeEnd = 170305, XrefRangeStart = 170304, XrefRangeEnd = 170304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GPAchievementType GetAchievementTypeById(int code)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayServiceUtil.NativeMethodInfoPtr_GetAchievementTypeById_Public_Static_GPAchievementType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00005AC9 File Offset: 0x00003CC9
	public PlayServiceUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000749 RID: 1865
	private static readonly IntPtr NativeMethodInfoPtr_GetAchievementStateById_Public_Static_GPAchievementState_Int32_0;

	// Token: 0x0400074A RID: 1866
	private static readonly IntPtr NativeMethodInfoPtr_GetAchievementTypeById_Public_Static_GPAchievementType_Int32_0;
}
