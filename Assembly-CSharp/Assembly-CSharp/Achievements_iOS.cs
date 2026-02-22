using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200006F RID: 111
public class Achievements_iOS : AchievementInterface
{
	// Token: 0x06000E66 RID: 3686 RVA: 0x00043D3C File Offset: 0x00041F3C
	// Note: this type is marked as 'beforefieldinit'.
	static Achievements_iOS()
	{
		Il2CppClassPointerStore<Achievements_iOS>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Achievements_iOS");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievements_iOS>.NativeClassPtr);
		Achievements_iOS.NativeFieldInfoPtr_m_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievements_iOS>.NativeClassPtr, "m_achievements");
		Achievements_iOS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievements_iOS>.NativeClassPtr, 100664302);
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00043D94 File Offset: 0x00041F94
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Achievements_iOS()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievements_iOS>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievements_iOS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0000A63A File Offset: 0x0000883A
	public Achievements_iOS(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00043DD0 File Offset: 0x00041FD0
	// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0000A643 File Offset: 0x00008843
	public unsafe Il2CppReferenceArray<AchievementData> m_achievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_iOS.NativeFieldInfoPtr_m_achievements);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievements_iOS.NativeFieldInfoPtr_m_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009D7 RID: 2519
	private static readonly IntPtr NativeFieldInfoPtr_m_achievements;

	// Token: 0x040009D8 RID: 2520
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
