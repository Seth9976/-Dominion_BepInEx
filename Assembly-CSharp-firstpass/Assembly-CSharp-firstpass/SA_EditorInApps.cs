using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200013F RID: 319
public class SA_EditorInApps : Object
{
	// Token: 0x060017A5 RID: 6053 RVA: 0x000687A8 File Offset: 0x000669A8
	// Note: this type is marked as 'beforefieldinit'.
	static SA_EditorInApps()
	{
		Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_EditorInApps");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr);
		SA_EditorInApps.NativeFieldInfoPtr__EditorUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr, "_EditorUI");
		SA_EditorInApps.NativeMethodInfoPtr_ShowInAppPopup_Public_Static_Void_String_String_String_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr, 100666169);
		SA_EditorInApps.NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_InApps_EditorUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr, 100666170);
		SA_EditorInApps.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr, 100666171);
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x00068828 File Offset: 0x00066A28
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194466, RefRangeEnd = 194468, XrefRangeStart = 194457, XrefRangeEnd = 194466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowInAppPopup(string title, string describtion, string price, Action<bool> OnComplete = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(describtion);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(price);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnComplete);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorInApps.NativeMethodInfoPtr_ShowInAppPopup_Public_Static_Void_String_String_String_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00068894 File Offset: 0x00066A94
	public unsafe static SA_InApps_EditorUIController EditorUI
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194468, XrefRangeEnd = 194472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorInApps.NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_InApps_EditorUIController_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_InApps_EditorUIController>(intPtr3) : null;
		}
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x000688C8 File Offset: 0x00066AC8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_EditorInApps()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_EditorInApps>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorInApps.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0000B668 File Offset: 0x00009868
	public SA_EditorInApps(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x060017AA RID: 6058 RVA: 0x00068904 File Offset: 0x00066B04
	// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000B671 File Offset: 0x00009871
	public unsafe static SA_InApps_EditorUIController _EditorUI
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorInApps.NativeFieldInfoPtr__EditorUI, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_InApps_EditorUIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorInApps.NativeFieldInfoPtr__EditorUI, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040011E5 RID: 4581
	private static readonly IntPtr NativeFieldInfoPtr__EditorUI;

	// Token: 0x040011E6 RID: 4582
	private static readonly IntPtr NativeMethodInfoPtr_ShowInAppPopup_Public_Static_Void_String_String_String_Action_1_Boolean_0;

	// Token: 0x040011E7 RID: 4583
	private static readonly IntPtr NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_InApps_EditorUIController_0;

	// Token: 0x040011E8 RID: 4584
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
