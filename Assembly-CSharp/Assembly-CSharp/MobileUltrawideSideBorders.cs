using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000A1 RID: 161
public class MobileUltrawideSideBorders : MonoBehaviour
{
	// Token: 0x060012FA RID: 4858 RVA: 0x00053444 File Offset: 0x00051644
	// Note: this type is marked as 'beforefieldinit'.
	static MobileUltrawideSideBorders()
	{
		Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MobileUltrawideSideBorders");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr);
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_sideBorderObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_sideBorderObjs");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_mainCanvasObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_mainCanvasObj");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_minimumAspectRatioToTurnOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_minimumAspectRatioToTurnOn");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_setAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_setAspectRatio");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bUseVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_bUseVertical");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bSkipFirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_bSkipFirstFrame");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_rootPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_rootPanel");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_lastSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_lastSafeArea");
		MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, "m_bRun");
		MobileUltrawideSideBorders.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664789);
		MobileUltrawideSideBorders.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664790);
		MobileUltrawideSideBorders.NativeMethodInfoPtr_SetHorizontal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664791);
		MobileUltrawideSideBorders.NativeMethodInfoPtr_SetVertical_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664792);
		MobileUltrawideSideBorders.NativeMethodInfoPtr_RefreshSafeArea_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664793);
		MobileUltrawideSideBorders.NativeMethodInfoPtr_ApplySafeArea_Private_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664794);
		MobileUltrawideSideBorders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr, 100664795);
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x000535B4 File Offset: 0x000517B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244009, XrefRangeEnd = 244012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x000535E8 File Offset: 0x000517E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244012, XrefRangeEnd = 244019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0005361C File Offset: 0x0005181C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244037, RefRangeEnd = 244038, XrefRangeStart = 244019, XrefRangeEnd = 244037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_SetHorizontal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00053650 File Offset: 0x00051850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244038, XrefRangeEnd = 244056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_SetVertical_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00053684 File Offset: 0x00051884
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSafeArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_RefreshSafeArea_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x000536B8 File Offset: 0x000518B8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySafeArea(Rect r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr_ApplySafeArea_Private_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x000536F8 File Offset: 0x000518F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244056, XrefRangeEnd = 244058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobileUltrawideSideBorders()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileUltrawideSideBorders>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileUltrawideSideBorders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
	public MobileUltrawideSideBorders(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06001303 RID: 4867 RVA: 0x00053734 File Offset: 0x00051934
	// (set) Token: 0x06001304 RID: 4868 RVA: 0x0000C8CD File Offset: 0x0000AACD
	public unsafe Il2CppReferenceArray<GameObject> m_sideBorderObjs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_sideBorderObjs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_sideBorderObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x06001305 RID: 4869 RVA: 0x00053764 File Offset: 0x00051964
	// (set) Token: 0x06001306 RID: 4870 RVA: 0x0000C8EC File Offset: 0x0000AAEC
	public unsafe RectTransform m_mainCanvasObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_mainCanvasObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_mainCanvasObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x06001307 RID: 4871 RVA: 0x00053794 File Offset: 0x00051994
	// (set) Token: 0x06001308 RID: 4872 RVA: 0x0000C90B File Offset: 0x0000AB0B
	public unsafe float m_minimumAspectRatioToTurnOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_minimumAspectRatioToTurnOn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_minimumAspectRatioToTurnOn)) = value;
		}
	}

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x06001309 RID: 4873 RVA: 0x000537BC File Offset: 0x000519BC
	// (set) Token: 0x0600130A RID: 4874 RVA: 0x0000C926 File Offset: 0x0000AB26
	public unsafe float m_setAspectRatio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_setAspectRatio);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_setAspectRatio)) = value;
		}
	}

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x0600130B RID: 4875 RVA: 0x000537E4 File Offset: 0x000519E4
	// (set) Token: 0x0600130C RID: 4876 RVA: 0x0000C941 File Offset: 0x0000AB41
	public unsafe bool m_bUseVertical
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bUseVertical);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bUseVertical)) = value;
		}
	}

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x0600130D RID: 4877 RVA: 0x0005380C File Offset: 0x00051A0C
	// (set) Token: 0x0600130E RID: 4878 RVA: 0x0000C95C File Offset: 0x0000AB5C
	public unsafe bool m_bSkipFirstFrame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bSkipFirstFrame);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bSkipFirstFrame)) = value;
		}
	}

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x0600130F RID: 4879 RVA: 0x00053834 File Offset: 0x00051A34
	// (set) Token: 0x06001310 RID: 4880 RVA: 0x0000C977 File Offset: 0x0000AB77
	public unsafe RectTransform m_rootPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_rootPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_rootPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x06001311 RID: 4881 RVA: 0x00053864 File Offset: 0x00051A64
	// (set) Token: 0x06001312 RID: 4882 RVA: 0x0000C996 File Offset: 0x0000AB96
	public unsafe Rect m_lastSafeArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_lastSafeArea);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_lastSafeArea)) = value;
		}
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x06001313 RID: 4883 RVA: 0x0005388C File Offset: 0x00051A8C
	// (set) Token: 0x06001314 RID: 4884 RVA: 0x0000C9B1 File Offset: 0x0000ABB1
	public unsafe bool m_bRun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bRun);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileUltrawideSideBorders.NativeFieldInfoPtr_m_bRun)) = value;
		}
	}

	// Token: 0x04000D3F RID: 3391
	private static readonly IntPtr NativeFieldInfoPtr_m_sideBorderObjs;

	// Token: 0x04000D40 RID: 3392
	private static readonly IntPtr NativeFieldInfoPtr_m_mainCanvasObj;

	// Token: 0x04000D41 RID: 3393
	private static readonly IntPtr NativeFieldInfoPtr_m_minimumAspectRatioToTurnOn;

	// Token: 0x04000D42 RID: 3394
	private static readonly IntPtr NativeFieldInfoPtr_m_setAspectRatio;

	// Token: 0x04000D43 RID: 3395
	private static readonly IntPtr NativeFieldInfoPtr_m_bUseVertical;

	// Token: 0x04000D44 RID: 3396
	private static readonly IntPtr NativeFieldInfoPtr_m_bSkipFirstFrame;

	// Token: 0x04000D45 RID: 3397
	private static readonly IntPtr NativeFieldInfoPtr_m_rootPanel;

	// Token: 0x04000D46 RID: 3398
	private static readonly IntPtr NativeFieldInfoPtr_m_lastSafeArea;

	// Token: 0x04000D47 RID: 3399
	private static readonly IntPtr NativeFieldInfoPtr_m_bRun;

	// Token: 0x04000D48 RID: 3400
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D49 RID: 3401
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000D4A RID: 3402
	private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Private_Void_0;

	// Token: 0x04000D4B RID: 3403
	private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Private_Void_0;

	// Token: 0x04000D4C RID: 3404
	private static readonly IntPtr NativeMethodInfoPtr_RefreshSafeArea_Private_Void_0;

	// Token: 0x04000D4D RID: 3405
	private static readonly IntPtr NativeMethodInfoPtr_ApplySafeArea_Private_Void_Rect_0;

	// Token: 0x04000D4E RID: 3406
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
