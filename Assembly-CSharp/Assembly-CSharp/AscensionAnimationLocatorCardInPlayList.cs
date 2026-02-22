using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200000F RID: 15
public class AscensionAnimationLocatorCardInPlayList : AscensionAnimationLocator
{
	// Token: 0x06000156 RID: 342 RVA: 0x00002C45 File Offset: 0x00000E45
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationLocatorCardInPlayList()
	{
		Il2CppClassPointerStore<AscensionAnimationLocatorCardInPlayList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationLocatorCardInPlayList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorCardInPlayList>.NativeClassPtr);
		AscensionAnimationLocatorCardInPlayList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorCardInPlayList>.NativeClassPtr, 100663408);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0001EB48 File Offset: 0x0001CD48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224855, XrefRangeEnd = 224856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocatorCardInPlayList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorCardInPlayList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorCardInPlayList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002C7E File Offset: 0x00000E7E
	public AscensionAnimationLocatorCardInPlayList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
