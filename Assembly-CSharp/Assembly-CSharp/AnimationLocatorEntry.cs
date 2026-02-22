using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000080 RID: 128
public class AnimationLocatorEntry : Object
{
	// Token: 0x0600101F RID: 4127 RVA: 0x000496C8 File Offset: 0x000478C8
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationLocatorEntry()
	{
		Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimationLocatorEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr);
		AnimationLocatorEntry.NativeFieldInfoPtr_m_LocatorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr, "m_LocatorID");
		AnimationLocatorEntry.NativeFieldInfoPtr_m_Locator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr, "m_Locator");
		AnimationLocatorEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr, 100664474);
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00049734 File Offset: 0x00047934
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLocatorEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationLocatorEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocatorEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0000B3AA File Offset: 0x000095AA
	public AnimationLocatorEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06001022 RID: 4130 RVA: 0x00049770 File Offset: 0x00047970
	// (set) Token: 0x06001023 RID: 4131 RVA: 0x0000B3B3 File Offset: 0x000095B3
	public unsafe int m_LocatorID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocatorEntry.NativeFieldInfoPtr_m_LocatorID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocatorEntry.NativeFieldInfoPtr_m_LocatorID)) = value;
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06001024 RID: 4132 RVA: 0x00049798 File Offset: 0x00047998
	// (set) Token: 0x06001025 RID: 4133 RVA: 0x0000B3CE File Offset: 0x000095CE
	public unsafe AnimationLocator m_Locator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocatorEntry.NativeFieldInfoPtr_m_Locator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocatorEntry.NativeFieldInfoPtr_m_Locator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B4C RID: 2892
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorID;

	// Token: 0x04000B4D RID: 2893
	private static readonly IntPtr NativeFieldInfoPtr_m_Locator;

	// Token: 0x04000B4E RID: 2894
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
