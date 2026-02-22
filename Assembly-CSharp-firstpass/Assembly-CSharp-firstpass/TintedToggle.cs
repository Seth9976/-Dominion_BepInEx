using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000115 RID: 277
public class TintedToggle : MonoBehaviour
{
	// Token: 0x060012F3 RID: 4851 RVA: 0x00058954 File Offset: 0x00056B54
	// Note: this type is marked as 'beforefieldinit'.
	static TintedToggle()
	{
		Il2CppClassPointerStore<TintedToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TintedToggle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr);
		TintedToggle.NativeFieldInfoPtr_ToggleButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, "ToggleButton");
		TintedToggle.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, "Label");
		TintedToggle.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, "TintColor");
		TintedToggle.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, "Color");
		TintedToggle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, 100665584);
		TintedToggle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, 100665585);
		TintedToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, 100665586);
		TintedToggle.NativeMethodInfoPtr__Start_b__5_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr, 100665587);
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00058A24 File Offset: 0x00056C24
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TintedToggle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x00058A58 File Offset: 0x00056C58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183710, XrefRangeEnd = 183728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TintedToggle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00058A8C File Offset: 0x00056C8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183728, XrefRangeEnd = 183730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TintedToggle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TintedToggle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TintedToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00058AC8 File Offset: 0x00056CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183730, XrefRangeEnd = 183731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__5_0(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TintedToggle.NativeMethodInfoPtr__Start_b__5_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x000095CB File Offset: 0x000077CB
	public TintedToggle(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00058B08 File Offset: 0x00056D08
	// (set) Token: 0x060012FA RID: 4858 RVA: 0x000095D4 File Offset: 0x000077D4
	public unsafe Toggle ToggleButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_ToggleButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_ToggleButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x060012FB RID: 4859 RVA: 0x00058B38 File Offset: 0x00056D38
	// (set) Token: 0x060012FC RID: 4860 RVA: 0x000095F3 File Offset: 0x000077F3
	public unsafe Text Label
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_Label);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x060012FD RID: 4861 RVA: 0x00058B68 File Offset: 0x00056D68
	// (set) Token: 0x060012FE RID: 4862 RVA: 0x00009612 File Offset: 0x00007812
	public unsafe Color TintColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_TintColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_TintColor)) = value;
		}
	}

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x060012FF RID: 4863 RVA: 0x00058B90 File Offset: 0x00056D90
	// (set) Token: 0x06001300 RID: 4864 RVA: 0x0000962D File Offset: 0x0000782D
	public unsafe Color Color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_Color);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TintedToggle.NativeFieldInfoPtr_Color)) = value;
		}
	}

	// Token: 0x04000E85 RID: 3717
	private static readonly IntPtr NativeFieldInfoPtr_ToggleButton;

	// Token: 0x04000E86 RID: 3718
	private static readonly IntPtr NativeFieldInfoPtr_Label;

	// Token: 0x04000E87 RID: 3719
	private static readonly IntPtr NativeFieldInfoPtr_TintColor;

	// Token: 0x04000E88 RID: 3720
	private static readonly IntPtr NativeFieldInfoPtr_Color;

	// Token: 0x04000E89 RID: 3721
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E8A RID: 3722
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000E8B RID: 3723
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000E8C RID: 3724
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Private_Void_Boolean_0;
}
