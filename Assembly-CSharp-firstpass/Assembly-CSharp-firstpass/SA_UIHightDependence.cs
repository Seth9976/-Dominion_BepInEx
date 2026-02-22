using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000145 RID: 325
public class SA_UIHightDependence : MonoBehaviour
{
	// Token: 0x060017EE RID: 6126 RVA: 0x00069684 File Offset: 0x00067884
	// Note: this type is marked as 'beforefieldinit'.
	static SA_UIHightDependence()
	{
		Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_UIHightDependence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr);
		SA_UIHightDependence.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, "_rect");
		SA_UIHightDependence.NativeFieldInfoPtr_KeepRatioInEdiotr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, "KeepRatioInEdiotr");
		SA_UIHightDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, "CaclulcateOnlyOntStart");
		SA_UIHightDependence.NativeFieldInfoPtr_InitialRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, "InitialRect");
		SA_UIHightDependence.NativeFieldInfoPtr_InitialScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, "InitialScreen");
		SA_UIHightDependence.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666200);
		SA_UIHightDependence.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666201);
		SA_UIHightDependence.NativeMethodInfoPtr_ApplyTransformation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666202);
		SA_UIHightDependence.NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666203);
		SA_UIHightDependence.NativeMethodInfoPtr_OnDetroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666204);
		SA_UIHightDependence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr, 100666205);
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00069790 File Offset: 0x00067990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194734, XrefRangeEnd = 194736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x000697C4 File Offset: 0x000679C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194736, XrefRangeEnd = 194738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x000697F8 File Offset: 0x000679F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194752, RefRangeEnd = 194754, XrefRangeStart = 194738, XrefRangeEnd = 194752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTransformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr_ApplyTransformation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0006982C File Offset: 0x00067A2C
	public unsafe RectTransform rect
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194761, RefRangeEnd = 194764, XrefRangeStart = 194754, XrefRangeEnd = 194761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x0006986C File Offset: 0x00067A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194764, XrefRangeEnd = 194767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDetroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr_OnDetroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x000698A0 File Offset: 0x00067AA0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_UIHightDependence()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_UIHightDependence>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIHightDependence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x0000B879 File Offset: 0x00009A79
	public SA_UIHightDependence(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x060017F6 RID: 6134 RVA: 0x000698DC File Offset: 0x00067ADC
	// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000B882 File Offset: 0x00009A82
	public unsafe RectTransform _rect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr__rect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr__rect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0006990C File Offset: 0x00067B0C
	// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000B8A1 File Offset: 0x00009AA1
	public unsafe bool KeepRatioInEdiotr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_KeepRatioInEdiotr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_KeepRatioInEdiotr)) = value;
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x060017FA RID: 6138 RVA: 0x00069934 File Offset: 0x00067B34
	// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000B8BC File Offset: 0x00009ABC
	public unsafe bool CaclulcateOnlyOntStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart)) = value;
		}
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x0006995C File Offset: 0x00067B5C
	// (set) Token: 0x060017FD RID: 6141 RVA: 0x0000B8D7 File Offset: 0x00009AD7
	public unsafe Rect InitialRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_InitialRect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_InitialRect)) = value;
		}
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x060017FE RID: 6142 RVA: 0x00069984 File Offset: 0x00067B84
	// (set) Token: 0x060017FF RID: 6143 RVA: 0x0000B8F2 File Offset: 0x00009AF2
	public unsafe Rect InitialScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_InitialScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIHightDependence.NativeFieldInfoPtr_InitialScreen)) = value;
		}
	}

	// Token: 0x04001218 RID: 4632
	private static readonly IntPtr NativeFieldInfoPtr__rect;

	// Token: 0x04001219 RID: 4633
	private static readonly IntPtr NativeFieldInfoPtr_KeepRatioInEdiotr;

	// Token: 0x0400121A RID: 4634
	private static readonly IntPtr NativeFieldInfoPtr_CaclulcateOnlyOntStart;

	// Token: 0x0400121B RID: 4635
	private static readonly IntPtr NativeFieldInfoPtr_InitialRect;

	// Token: 0x0400121C RID: 4636
	private static readonly IntPtr NativeFieldInfoPtr_InitialScreen;

	// Token: 0x0400121D RID: 4637
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400121E RID: 4638
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400121F RID: 4639
	private static readonly IntPtr NativeMethodInfoPtr_ApplyTransformation_Public_Void_0;

	// Token: 0x04001220 RID: 4640
	private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0;

	// Token: 0x04001221 RID: 4641
	private static readonly IntPtr NativeMethodInfoPtr_OnDetroy_Private_Void_0;

	// Token: 0x04001222 RID: 4642
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
