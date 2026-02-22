using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BD RID: 189
public class UIToggleHelper : MonoBehaviour
{
	// Token: 0x060016E2 RID: 5858 RVA: 0x0005F2A0 File Offset: 0x0005D4A0
	// Note: this type is marked as 'beforefieldinit'.
	static UIToggleHelper()
	{
		Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIToggleHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr);
		UIToggleHelper.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, "toggle");
		UIToggleHelper.NativeFieldInfoPtr_toToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, "toToggle");
		UIToggleHelper.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, "text");
		UIToggleHelper.NativeFieldInfoPtr_colorOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, "colorOn");
		UIToggleHelper.NativeFieldInfoPtr_colorOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, "colorOff");
		UIToggleHelper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, 100665123);
		UIToggleHelper.NativeMethodInfoPtr_ToggleState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, 100665124);
		UIToggleHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr, 100665125);
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0005F370 File Offset: 0x0005D570
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247904, XrefRangeEnd = 247905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggleHelper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0005F3A4 File Offset: 0x0005D5A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggleHelper.NativeMethodInfoPtr_ToggleState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0005F3D8 File Offset: 0x0005D5D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247905, XrefRangeEnd = 247908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIToggleHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIToggleHelper>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggleHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
	public UIToggleHelper(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0005F414 File Offset: 0x0005D614
	// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000ECD2 File Offset: 0x0000CED2
	public unsafe Toggle toggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_toggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700074A RID: 1866
	// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0005F444 File Offset: 0x0005D644
	// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000ECF1 File Offset: 0x0000CEF1
	public unsafe GameObject toToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_toToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_toToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700074B RID: 1867
	// (get) Token: 0x060016EB RID: 5867 RVA: 0x0005F474 File Offset: 0x0005D674
	// (set) Token: 0x060016EC RID: 5868 RVA: 0x0000ED10 File Offset: 0x0000CF10
	public unsafe TextMeshProUGUI text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_text);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700074C RID: 1868
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
	// (set) Token: 0x060016EE RID: 5870 RVA: 0x0000ED2F File Offset: 0x0000CF2F
	public unsafe Color colorOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_colorOn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_colorOn)) = value;
		}
	}

	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x060016EF RID: 5871 RVA: 0x0005F4CC File Offset: 0x0005D6CC
	// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0000ED4A File Offset: 0x0000CF4A
	public unsafe Color colorOff
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_colorOff);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggleHelper.NativeFieldInfoPtr_colorOff)) = value;
		}
	}

	// Token: 0x04000FC1 RID: 4033
	private static readonly IntPtr NativeFieldInfoPtr_toggle;

	// Token: 0x04000FC2 RID: 4034
	private static readonly IntPtr NativeFieldInfoPtr_toToggle;

	// Token: 0x04000FC3 RID: 4035
	private static readonly IntPtr NativeFieldInfoPtr_text;

	// Token: 0x04000FC4 RID: 4036
	private static readonly IntPtr NativeFieldInfoPtr_colorOn;

	// Token: 0x04000FC5 RID: 4037
	private static readonly IntPtr NativeFieldInfoPtr_colorOff;

	// Token: 0x04000FC6 RID: 4038
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000FC7 RID: 4039
	private static readonly IntPtr NativeMethodInfoPtr_ToggleState_Public_Void_0;

	// Token: 0x04000FC8 RID: 4040
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
