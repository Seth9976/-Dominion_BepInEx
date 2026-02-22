using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000146 RID: 326
public class SA_UIWidthDependence : MonoBehaviour
{
	// Token: 0x06001800 RID: 6144 RVA: 0x000699AC File Offset: 0x00067BAC
	// Note: this type is marked as 'beforefieldinit'.
	static SA_UIWidthDependence()
	{
		Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_UIWidthDependence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr);
		SA_UIWidthDependence.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, "_rect");
		SA_UIWidthDependence.NativeFieldInfoPtr_KeepRatioInEdiotr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, "KeepRatioInEdiotr");
		SA_UIWidthDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, "CaclulcateOnlyOntStart");
		SA_UIWidthDependence.NativeFieldInfoPtr_InitialRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, "InitialRect");
		SA_UIWidthDependence.NativeFieldInfoPtr_InitialScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, "InitialScreen");
		SA_UIWidthDependence.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666206);
		SA_UIWidthDependence.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666207);
		SA_UIWidthDependence.NativeMethodInfoPtr_ApplyTransformation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666208);
		SA_UIWidthDependence.NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666209);
		SA_UIWidthDependence.NativeMethodInfoPtr_OnDetroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666210);
		SA_UIWidthDependence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr, 100666211);
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00069AB8 File Offset: 0x00067CB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194767, XrefRangeEnd = 194769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00069AEC File Offset: 0x00067CEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194769, XrefRangeEnd = 194771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00069B20 File Offset: 0x00067D20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194785, RefRangeEnd = 194787, XrefRangeStart = 194771, XrefRangeEnd = 194785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTransformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr_ApplyTransformation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06001804 RID: 6148 RVA: 0x00069B54 File Offset: 0x00067D54
	public unsafe RectTransform rect
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194794, RefRangeEnd = 194797, XrefRangeStart = 194787, XrefRangeEnd = 194794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00069B94 File Offset: 0x00067D94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194797, XrefRangeEnd = 194800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDetroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr_OnDetroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00069BC8 File Offset: 0x00067DC8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_UIWidthDependence()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_UIWidthDependence>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UIWidthDependence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x0000B90D File Offset: 0x00009B0D
	public SA_UIWidthDependence(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06001808 RID: 6152 RVA: 0x00069C04 File Offset: 0x00067E04
	// (set) Token: 0x06001809 RID: 6153 RVA: 0x0000B916 File Offset: 0x00009B16
	public unsafe RectTransform _rect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr__rect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr__rect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x0600180A RID: 6154 RVA: 0x00069C34 File Offset: 0x00067E34
	// (set) Token: 0x0600180B RID: 6155 RVA: 0x0000B935 File Offset: 0x00009B35
	public unsafe bool KeepRatioInEdiotr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_KeepRatioInEdiotr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_KeepRatioInEdiotr)) = value;
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x0600180C RID: 6156 RVA: 0x00069C5C File Offset: 0x00067E5C
	// (set) Token: 0x0600180D RID: 6157 RVA: 0x0000B950 File Offset: 0x00009B50
	public unsafe bool CaclulcateOnlyOntStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_CaclulcateOnlyOntStart)) = value;
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x0600180E RID: 6158 RVA: 0x00069C84 File Offset: 0x00067E84
	// (set) Token: 0x0600180F RID: 6159 RVA: 0x0000B96B File Offset: 0x00009B6B
	public unsafe Rect InitialRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_InitialRect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_InitialRect)) = value;
		}
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06001810 RID: 6160 RVA: 0x00069CAC File Offset: 0x00067EAC
	// (set) Token: 0x06001811 RID: 6161 RVA: 0x0000B986 File Offset: 0x00009B86
	public unsafe Rect InitialScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_InitialScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_UIWidthDependence.NativeFieldInfoPtr_InitialScreen)) = value;
		}
	}

	// Token: 0x04001223 RID: 4643
	private static readonly IntPtr NativeFieldInfoPtr__rect;

	// Token: 0x04001224 RID: 4644
	private static readonly IntPtr NativeFieldInfoPtr_KeepRatioInEdiotr;

	// Token: 0x04001225 RID: 4645
	private static readonly IntPtr NativeFieldInfoPtr_CaclulcateOnlyOntStart;

	// Token: 0x04001226 RID: 4646
	private static readonly IntPtr NativeFieldInfoPtr_InitialRect;

	// Token: 0x04001227 RID: 4647
	private static readonly IntPtr NativeFieldInfoPtr_InitialScreen;

	// Token: 0x04001228 RID: 4648
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001229 RID: 4649
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400122A RID: 4650
	private static readonly IntPtr NativeMethodInfoPtr_ApplyTransformation_Public_Void_0;

	// Token: 0x0400122B RID: 4651
	private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_RectTransform_0;

	// Token: 0x0400122C RID: 4652
	private static readonly IntPtr NativeMethodInfoPtr_OnDetroy_Private_Void_0;

	// Token: 0x0400122D RID: 4653
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
