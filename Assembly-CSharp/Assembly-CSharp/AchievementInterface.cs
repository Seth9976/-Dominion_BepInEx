using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

// Token: 0x0200007A RID: 122
public class AchievementInterface : MonoBehaviour
{
	// Token: 0x06000F4D RID: 3917 RVA: 0x0004697C File Offset: 0x00044B7C
	// Note: this type is marked as 'beforefieldinit'.
	static AchievementInterface()
	{
		Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AchievementInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr);
		AchievementInterface.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Il2CppReferenceArray_1_AchievementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr, 100664381);
		AchievementInterface.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_New_Void_EAchievements_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr, 100664382);
		AchievementInterface.NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr, 100664383);
		AchievementInterface.NativeMethodInfoPtr_GetUsername_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr, 100664384);
		AchievementInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr, 100664385);
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00046A10 File Offset: 0x00044C10
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize(Il2CppReferenceArray<AchievementData> achievementList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(achievementList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementInterface.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Il2CppReferenceArray_1_AchievementData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00046A60 File Offset: 0x00044C60
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void IncrementAchievement(EAchievements id, long plusValue)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementInterface.NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_New_Void_EAchievements_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00046AB8 File Offset: 0x00044CB8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ResetAllAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementInterface.NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00046AF4 File Offset: 0x00044CF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240409, XrefRangeEnd = 240411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetUsername()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementInterface.NativeMethodInfoPtr_GetUsername_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00046B38 File Offset: 0x00044D38
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AchievementInterface()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementInterface>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0000ADEC File Offset: 0x00008FEC
	public AchievementInterface(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000ABB RID: 2747
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Il2CppReferenceArray_1_AchievementData_0;

	// Token: 0x04000ABC RID: 2748
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievement_Public_Virtual_New_Void_EAchievements_Int64_0;

	// Token: 0x04000ABD RID: 2749
	private static readonly IntPtr NativeMethodInfoPtr_ResetAllAchievements_Public_Virtual_New_Void_0;

	// Token: 0x04000ABE RID: 2750
	private static readonly IntPtr NativeMethodInfoPtr_GetUsername_Public_Virtual_New_String_0;

	// Token: 0x04000ABF RID: 2751
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
