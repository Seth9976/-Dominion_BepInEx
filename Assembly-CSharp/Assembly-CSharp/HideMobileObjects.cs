using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class HideMobileObjects : MonoBehaviour
{
	// Token: 0x060012F2 RID: 4850 RVA: 0x000532F4 File Offset: 0x000514F4
	// Note: this type is marked as 'beforefieldinit'.
	static HideMobileObjects()
	{
		Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HideMobileObjects");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr);
		HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr, "m_ButtonsToDisableOnMobile");
		HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToEnableOnMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr, "m_ButtonsToEnableOnMobile");
		HideMobileObjects.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr, 100664787);
		HideMobileObjects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr, 100664788);
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00053374 File Offset: 0x00051574
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244005, XrefRangeEnd = 244009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideMobileObjects.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x000533A8 File Offset: 0x000515A8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HideMobileObjects()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideMobileObjects>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideMobileObjects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0000C87D File Offset: 0x0000AA7D
	public HideMobileObjects(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x060012F6 RID: 4854 RVA: 0x000533E4 File Offset: 0x000515E4
	// (set) Token: 0x060012F7 RID: 4855 RVA: 0x0000C886 File Offset: 0x0000AA86
	public unsafe Il2CppReferenceArray<GameObject> m_ButtonsToDisableOnMobile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00053414 File Offset: 0x00051614
	// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0000C8A5 File Offset: 0x0000AAA5
	public unsafe Il2CppReferenceArray<GameObject> m_ButtonsToEnableOnMobile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToEnableOnMobile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideMobileObjects.NativeFieldInfoPtr_m_ButtonsToEnableOnMobile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D3B RID: 3387
	private static readonly IntPtr NativeFieldInfoPtr_m_ButtonsToDisableOnMobile;

	// Token: 0x04000D3C RID: 3388
	private static readonly IntPtr NativeFieldInfoPtr_m_ButtonsToEnableOnMobile;

	// Token: 0x04000D3D RID: 3389
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D3E RID: 3390
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
