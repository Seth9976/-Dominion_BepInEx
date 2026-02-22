using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class AscensionVoidTray : MonoBehaviour
{
	// Token: 0x060008CF RID: 2255 RVA: 0x00033DE8 File Offset: 0x00031FE8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionVoidTray()
	{
		Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionVoidTray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr);
		AscensionVoidTray.NativeFieldInfoPtr_m_RedirectLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr, "m_RedirectLocator");
		AscensionVoidTray.NativeMethodInfoPtr_GetRedirectLocator_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr, 100663887);
		AscensionVoidTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr, 100663888);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00033E54 File Offset: 0x00032054
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetRedirectLocator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionVoidTray.NativeMethodInfoPtr_GetRedirectLocator_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00033E94 File Offset: 0x00032094
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionVoidTray()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionVoidTray>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionVoidTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000077D2 File Offset: 0x000059D2
	public AscensionVoidTray(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00033ED0 File Offset: 0x000320D0
	// (set) Token: 0x060008D4 RID: 2260 RVA: 0x000077DB File Offset: 0x000059DB
	public unsafe AscensionAnimationLocator m_RedirectLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionVoidTray.NativeFieldInfoPtr_m_RedirectLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionVoidTray.NativeFieldInfoPtr_m_RedirectLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400057D RID: 1405
	private static readonly IntPtr NativeFieldInfoPtr_m_RedirectLocator;

	// Token: 0x0400057E RID: 1406
	private static readonly IntPtr NativeMethodInfoPtr_GetRedirectLocator_Public_AscensionAnimationLocator_0;

	// Token: 0x0400057F RID: 1407
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
