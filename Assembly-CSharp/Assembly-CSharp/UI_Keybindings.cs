using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000D0 RID: 208
public class UI_Keybindings : UI_FrontEndAndInGameScene
{
	// Token: 0x06001943 RID: 6467 RVA: 0x00065EF4 File Offset: 0x000640F4
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Keybindings()
	{
		Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Keybindings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr);
		UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, "m_keybindSlotPrefab1");
		UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, "m_keybindSlotPrefab2");
		UI_Keybindings.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, "m_contentContainer");
		UI_Keybindings.NativeFieldInfoPtr_m_keybindSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, "m_keybindSlots");
		UI_Keybindings.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, 100665290);
		UI_Keybindings.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, 100665291);
		UI_Keybindings.NativeMethodInfoPtr_HandleClick_Private_Void_UIP_KeybindSlot_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, 100665292);
		UI_Keybindings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr, 100665293);
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00065FC4 File Offset: 0x000641C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250151, XrefRangeEnd = 250209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Keybindings.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00065FF8 File Offset: 0x000641F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250209, XrefRangeEnd = 250222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Keybindings.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00066038 File Offset: 0x00064238
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClick(UIP_KeybindSlot slot, uint managerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managerIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Keybindings.NativeMethodInfoPtr_HandleClick_Private_Void_UIP_KeybindSlot_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00066088 File Offset: 0x00064288
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Keybindings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Keybindings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Keybindings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x000104B6 File Offset: 0x0000E6B6
	public UI_Keybindings(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000815 RID: 2069
	// (get) Token: 0x06001949 RID: 6473 RVA: 0x000660C4 File Offset: 0x000642C4
	// (set) Token: 0x0600194A RID: 6474 RVA: 0x000104BF File Offset: 0x0000E6BF
	public unsafe GameObject m_keybindSlotPrefab1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x0600194B RID: 6475 RVA: 0x000660F4 File Offset: 0x000642F4
	// (set) Token: 0x0600194C RID: 6476 RVA: 0x000104DE File Offset: 0x0000E6DE
	public unsafe GameObject m_keybindSlotPrefab2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlotPrefab2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x0600194D RID: 6477 RVA: 0x00066124 File Offset: 0x00064324
	// (set) Token: 0x0600194E RID: 6478 RVA: 0x000104FD File Offset: 0x0000E6FD
	public unsafe Transform m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x0600194F RID: 6479 RVA: 0x00066154 File Offset: 0x00064354
	// (set) Token: 0x06001950 RID: 6480 RVA: 0x0001051C File Offset: 0x0000E71C
	public unsafe List<UIP_KeybindSlot> m_keybindSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIP_KeybindSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Keybindings.NativeFieldInfoPtr_m_keybindSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001131 RID: 4401
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindSlotPrefab1;

	// Token: 0x04001132 RID: 4402
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindSlotPrefab2;

	// Token: 0x04001133 RID: 4403
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x04001134 RID: 4404
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindSlots;

	// Token: 0x04001135 RID: 4405
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001136 RID: 4406
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x04001137 RID: 4407
	private static readonly IntPtr NativeMethodInfoPtr_HandleClick_Private_Void_UIP_KeybindSlot_UInt32_0;

	// Token: 0x04001138 RID: 4408
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
