using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000028 RID: 40
public class AN_PlusButtonsManager : Singleton<AN_PlusButtonsManager>
{
	// Token: 0x0600042C RID: 1068 RVA: 0x00024ADC File Offset: 0x00022CDC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PlusButtonsManager()
	{
		Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PlusButtonsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr);
		AN_PlusButtonsManager.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, "buttons");
		AN_PlusButtonsManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, 100663768);
		AN_PlusButtonsManager.NativeMethodInfoPtr_RegisterButton_Public_Void_AN_PlusButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, 100663769);
		AN_PlusButtonsManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, 100663770);
		AN_PlusButtonsManager.NativeMethodInfoPtr_OnPlusClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, 100663771);
		AN_PlusButtonsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr, 100663772);
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00024B84 File Offset: 0x00022D84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163316, XrefRangeEnd = 163327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonsManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00024BB8 File Offset: 0x00022DB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163327, XrefRangeEnd = 163331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterButton(AN_PlusButton b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonsManager.NativeMethodInfoPtr_RegisterButton_Public_Void_AN_PlusButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00024BFC File Offset: 0x00022DFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163331, XrefRangeEnd = 163352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationPause(bool IsPaused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsPaused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonsManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00024C3C File Offset: 0x00022E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163352, XrefRangeEnd = 163372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlusClicked(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonsManager.NativeMethodInfoPtr_OnPlusClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00024C80 File Offset: 0x00022E80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163372, XrefRangeEnd = 163384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PlusButtonsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusButtonsManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00003D43 File Offset: 0x00001F43
	public AN_PlusButtonsManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x00024CBC File Offset: 0x00022EBC
	// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003D4C File Offset: 0x00001F4C
	public unsafe List<AN_PlusButton> buttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButtonsManager.NativeFieldInfoPtr_buttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AN_PlusButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButtonsManager.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000324 RID: 804
	private static readonly IntPtr NativeFieldInfoPtr_buttons;

	// Token: 0x04000325 RID: 805
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000326 RID: 806
	private static readonly IntPtr NativeMethodInfoPtr_RegisterButton_Public_Void_AN_PlusButton_0;

	// Token: 0x04000327 RID: 807
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

	// Token: 0x04000328 RID: 808
	private static readonly IntPtr NativeMethodInfoPtr_OnPlusClicked_Private_Void_String_0;

	// Token: 0x04000329 RID: 809
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
