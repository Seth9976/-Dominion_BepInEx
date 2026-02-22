using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class UILocalizedText : MonoBehaviour
{
	// Token: 0x0600002E RID: 46 RVA: 0x0001B624 File Offset: 0x00019824
	// Note: this type is marked as 'beforefieldinit'.
	static UILocalizedText()
	{
		Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UILocalizedText");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr);
		UILocalizedText.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, "_key");
		UILocalizedText.NativeFieldInfoPtr_UiText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, "UiText");
		UILocalizedText.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663319);
		UILocalizedText.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663320);
		UILocalizedText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663321);
		UILocalizedText.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663322);
		UILocalizedText.NativeMethodInfoPtr_OnChangeLocalization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663323);
		UILocalizedText.NativeMethodInfoPtr_Localize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663324);
		UILocalizedText.NativeMethodInfoPtr_SetTextValue_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663325);
		UILocalizedText.NativeMethodInfoPtr_ParceText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663326);
		UILocalizedText.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663327);
		UILocalizedText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr, 100663328);
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600002F RID: 47 RVA: 0x0001B744 File Offset: 0x00019944
	// (set) Token: 0x06000030 RID: 48 RVA: 0x0001B77C File Offset: 0x0001997C
	public unsafe string Key
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224095, XrefRangeEnd = 224096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0001B7C0 File Offset: 0x000199C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224096, XrefRangeEnd = 224115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0001B7F4 File Offset: 0x000199F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0001B828 File Offset: 0x00019A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224115, XrefRangeEnd = 224116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeLocalization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_OnChangeLocalization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0001B85C File Offset: 0x00019A5C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 224123, RefRangeEnd = 224127, XrefRangeStart = 224116, XrefRangeEnd = 224123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Localize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_Localize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0001B890 File Offset: 0x00019A90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224150, RefRangeEnd = 224151, XrefRangeStart = 224127, XrefRangeEnd = 224150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextValue(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_SetTextValue_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0001B8D4 File Offset: 0x00019AD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224151, XrefRangeEnd = 224158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ParceText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_ParceText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0001B91C File Offset: 0x00019B1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224158, XrefRangeEnd = 224170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0001B950 File Offset: 0x00019B50
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UILocalizedText()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILocalizedText>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILocalizedText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000214A File Offset: 0x0000034A
	public UILocalizedText(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003A RID: 58 RVA: 0x0001B98C File Offset: 0x00019B8C
	// (set) Token: 0x0600003B RID: 59 RVA: 0x00002153 File Offset: 0x00000353
	public unsafe string _key
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILocalizedText.NativeFieldInfoPtr__key);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILocalizedText.NativeFieldInfoPtr__key), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600003C RID: 60 RVA: 0x0001B9B4 File Offset: 0x00019BB4
	// (set) Token: 0x0600003D RID: 61 RVA: 0x00002172 File Offset: 0x00000372
	public unsafe Text UiText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILocalizedText.NativeFieldInfoPtr_UiText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILocalizedText.NativeFieldInfoPtr_UiText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeFieldInfoPtr__key;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr_UiText;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_OnChangeLocalization_Private_Void_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_Localize_Private_Void_0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_SetTextValue_Private_Void_String_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_ParceText_Private_String_String_0;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
