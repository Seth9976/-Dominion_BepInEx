using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

// Token: 0x02000097 RID: 151
public class StandaloneInputPointerAccess : StandaloneInputModule
{
	// Token: 0x06001234 RID: 4660 RVA: 0x00050D44 File Offset: 0x0004EF44
	// Note: this type is marked as 'beforefieldinit'.
	static StandaloneInputPointerAccess()
	{
		Il2CppClassPointerStore<StandaloneInputPointerAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StandaloneInputPointerAccess");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneInputPointerAccess>.NativeClassPtr);
		StandaloneInputPointerAccess.NativeMethodInfoPtr_GetPointerData_Public_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputPointerAccess>.NativeClassPtr, 100664712);
		StandaloneInputPointerAccess.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputPointerAccess>.NativeClassPtr, 100664713);
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00050D9C File Offset: 0x0004EF9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243321, XrefRangeEnd = 243325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointerEventData GetPointerData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputPointerAccess.NativeMethodInfoPtr_GetPointerData_Public_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00050DDC File Offset: 0x0004EFDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243325, XrefRangeEnd = 243326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StandaloneInputPointerAccess()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneInputPointerAccess>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputPointerAccess.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x0000C29E File Offset: 0x0000A49E
	public StandaloneInputPointerAccess(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000CC0 RID: 3264
	private static readonly IntPtr NativeMethodInfoPtr_GetPointerData_Public_PointerEventData_0;

	// Token: 0x04000CC1 RID: 3265
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
