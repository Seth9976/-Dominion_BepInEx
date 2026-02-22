using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000010 RID: 16
public class AscensionAnimationLocatorCenterRow : AscensionAnimationLocator
{
	// Token: 0x06000159 RID: 345 RVA: 0x0001EB84 File Offset: 0x0001CD84
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationLocatorCenterRow()
	{
		Il2CppClassPointerStore<AscensionAnimationLocatorCenterRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationLocatorCenterRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorCenterRow>.NativeClassPtr);
		AscensionAnimationLocatorCenterRow.NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_AnimationLocator_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorCenterRow>.NativeClassPtr, 100663409);
		AscensionAnimationLocatorCenterRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorCenterRow>.NativeClassPtr, 100663410);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0001EBDC File Offset: 0x0001CDDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224856, XrefRangeEnd = 224874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AnimationLocator GetOverrideDestinationLocator(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorCenterRow.NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_AnimationLocator_AnimateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
		}
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0001EC38 File Offset: 0x0001CE38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocatorCenterRow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorCenterRow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorCenterRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002C87 File Offset: 0x00000E87
	public AscensionAnimationLocatorCenterRow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040000DC RID: 220
	private static readonly IntPtr NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_AnimationLocator_AnimateObject_0;

	// Token: 0x040000DD RID: 221
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
