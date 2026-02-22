using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000137 RID: 311
public class GD_LocalizationExample : MonoBehaviour
{
	// Token: 0x06001713 RID: 5907 RVA: 0x00066570 File Offset: 0x00064770
	// Note: this type is marked as 'beforefieldinit'.
	static GD_LocalizationExample()
	{
		Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GD_LocalizationExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr);
		GD_LocalizationExample.NativeFieldInfoPtr_GUITextStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, "GUITextStyle");
		GD_LocalizationExample.NativeFieldInfoPtr_DOC_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, "DOC_NAME");
		GD_LocalizationExample.NativeFieldInfoPtr_LOCALIZATION_WORK_SHEET_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, "LOCALIZATION_WORK_SHEET_NAME");
		GD_LocalizationExample.NativeFieldInfoPtr_Tokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, "Tokens");
		GD_LocalizationExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, 100666085);
		GD_LocalizationExample.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, 100666086);
		GD_LocalizationExample.NativeMethodInfoPtr_GetLocalizedString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, 100666087);
		GD_LocalizationExample.NativeMethodInfoPtr_Localization_OnLanguageChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, 100666088);
		GD_LocalizationExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr, 100666089);
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00066654 File Offset: 0x00064854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193762, XrefRangeEnd = 193794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00066688 File Offset: 0x00064888
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193794, XrefRangeEnd = 193860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationExample.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x000666BC File Offset: 0x000648BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 193864, RefRangeEnd = 193865, XrefRangeStart = 193860, XrefRangeEnd = 193864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizedString(string tocken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tocken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationExample.NativeMethodInfoPtr_GetLocalizedString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00066704 File Offset: 0x00064904
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193865, XrefRangeEnd = 193884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Localization_OnLanguageChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationExample.NativeMethodInfoPtr_Localization_OnLanguageChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x00066738 File Offset: 0x00064938
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193884, XrefRangeEnd = 193891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GD_LocalizationExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_LocalizationExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0000B3A1 File Offset: 0x000095A1
	public GD_LocalizationExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x0600171A RID: 5914 RVA: 0x00066774 File Offset: 0x00064974
	// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000B3AA File Offset: 0x000095AA
	public unsafe GUIStyle GUITextStyle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationExample.NativeFieldInfoPtr_GUITextStyle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationExample.NativeFieldInfoPtr_GUITextStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x0600171C RID: 5916 RVA: 0x000667A4 File Offset: 0x000649A4
	// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000B3C9 File Offset: 0x000095C9
	public unsafe static string DOC_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GD_LocalizationExample.NativeFieldInfoPtr_DOC_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GD_LocalizationExample.NativeFieldInfoPtr_DOC_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x0600171E RID: 5918 RVA: 0x000667C4 File Offset: 0x000649C4
	// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000B3DB File Offset: 0x000095DB
	public unsafe static string LOCALIZATION_WORK_SHEET_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GD_LocalizationExample.NativeFieldInfoPtr_LOCALIZATION_WORK_SHEET_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GD_LocalizationExample.NativeFieldInfoPtr_LOCALIZATION_WORK_SHEET_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x06001720 RID: 5920 RVA: 0x000667E4 File Offset: 0x000649E4
	// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000B3ED File Offset: 0x000095ED
	public unsafe List<string> Tokens
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationExample.NativeFieldInfoPtr_Tokens);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationExample.NativeFieldInfoPtr_Tokens), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400116C RID: 4460
	private static readonly IntPtr NativeFieldInfoPtr_GUITextStyle;

	// Token: 0x0400116D RID: 4461
	private static readonly IntPtr NativeFieldInfoPtr_DOC_NAME;

	// Token: 0x0400116E RID: 4462
	private static readonly IntPtr NativeFieldInfoPtr_LOCALIZATION_WORK_SHEET_NAME;

	// Token: 0x0400116F RID: 4463
	private static readonly IntPtr NativeFieldInfoPtr_Tokens;

	// Token: 0x04001170 RID: 4464
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001171 RID: 4465
	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	// Token: 0x04001172 RID: 4466
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Private_String_String_0;

	// Token: 0x04001173 RID: 4467
	private static readonly IntPtr NativeMethodInfoPtr_Localization_OnLanguageChanged_Private_Void_0;

	// Token: 0x04001174 RID: 4468
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
