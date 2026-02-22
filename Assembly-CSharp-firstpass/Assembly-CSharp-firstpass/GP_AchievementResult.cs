using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000054 RID: 84
public class GP_AchievementResult : GooglePlayResult
{
	// Token: 0x060006B7 RID: 1719 RVA: 0x0002DF14 File Offset: 0x0002C114
	// Note: this type is marked as 'beforefieldinit'.
	static GP_AchievementResult()
	{
		Il2CppClassPointerStore<GP_AchievementResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_AchievementResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AchievementResult>.NativeClassPtr);
		GP_AchievementResult.NativeFieldInfoPtr_achievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AchievementResult>.NativeClassPtr, "achievementId");
		GP_AchievementResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AchievementResult>.NativeClassPtr, 100664109);
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x0002DF6C File Offset: 0x0002C16C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166693, XrefRangeEnd = 166696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AchievementResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AchievementResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AchievementResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00004BBB File Offset: 0x00002DBB
	public GP_AchievementResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x060006BA RID: 1722 RVA: 0x0002DFB8 File Offset: 0x0002C1B8
	// (set) Token: 0x060006BB RID: 1723 RVA: 0x00004BC4 File Offset: 0x00002DC4
	public unsafe string achievementId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AchievementResult.NativeFieldInfoPtr_achievementId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AchievementResult.NativeFieldInfoPtr_achievementId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000571 RID: 1393
	private static readonly IntPtr NativeFieldInfoPtr_achievementId;

	// Token: 0x04000572 RID: 1394
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
