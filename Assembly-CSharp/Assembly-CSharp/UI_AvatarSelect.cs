using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C8 RID: 200
public class UI_AvatarSelect : MonoBehaviour
{
	// Token: 0x060017EE RID: 6126 RVA: 0x000623D0 File Offset: 0x000605D0
	// Note: this type is marked as 'beforefieldinit'.
	static UI_AvatarSelect()
	{
		Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_AvatarSelect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr);
		UI_AvatarSelect.NativeFieldInfoPtr_m_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "m_toggles");
		UI_AvatarSelect.NativeFieldInfoPtr_m_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "m_buttons");
		UI_AvatarSelect.NativeFieldInfoPtr_m_SetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "m_SetText");
		UI_AvatarSelect.NativeFieldInfoPtr_m_InAppPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "m_InAppPurchase");
		UI_AvatarSelect.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "m_Callback");
		UI_AvatarSelect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665205);
		UI_AvatarSelect.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665206);
		UI_AvatarSelect.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665207);
		UI_AvatarSelect.NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665208);
		UI_AvatarSelect.NativeMethodInfoPtr_HandleToggles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665209);
		UI_AvatarSelect.NativeMethodInfoPtr_OnAvatarClicked_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665210);
		UI_AvatarSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, 100665211);
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x000624F0 File Offset: 0x000606F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248736, XrefRangeEnd = 248761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00062524 File Offset: 0x00060724
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248761, XrefRangeEnd = 248780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00062558 File Offset: 0x00060758
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248780, XrefRangeEnd = 248782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00062598 File Offset: 0x00060798
	[CallerCount(0)]
	public unsafe void Setup(UI_AvatarSelect.ClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x000625DC File Offset: 0x000607DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248795, RefRangeEnd = 248796, XrefRangeStart = 248782, XrefRangeEnd = 248795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleToggles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_HandleToggles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x00062610 File Offset: 0x00060810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248796, XrefRangeEnd = 248807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarClicked(int buttonIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr_OnAvatarClicked_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x00062650 File Offset: 0x00060850
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_AvatarSelect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x0000F682 File Offset: 0x0000D882
	public UI_AvatarSelect(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700079D RID: 1949
	// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0006268C File Offset: 0x0006088C
	// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000F68B File Offset: 0x0000D88B
	public unsafe Il2CppReferenceArray<UI_AvatarSelect.AvatarSetToggle> m_toggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_toggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_AvatarSelect.AvatarSetToggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700079E RID: 1950
	// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000626BC File Offset: 0x000608BC
	// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000F6AA File Offset: 0x0000D8AA
	public unsafe Il2CppReferenceArray<UI_AvatarSelect.AvatarButton> m_buttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_buttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_AvatarSelect.AvatarButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700079F RID: 1951
	// (get) Token: 0x060017FB RID: 6139 RVA: 0x000626EC File Offset: 0x000608EC
	// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000F6C9 File Offset: 0x0000D8C9
	public unsafe TextMeshProUGUI m_SetText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_SetText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_SetText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A0 RID: 1952
	// (get) Token: 0x060017FD RID: 6141 RVA: 0x0006271C File Offset: 0x0006091C
	// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
	public unsafe InAppPurchaseWrapper m_InAppPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_InAppPurchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_InAppPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A1 RID: 1953
	// (get) Token: 0x060017FF RID: 6143 RVA: 0x0006274C File Offset: 0x0006094C
	// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000F707 File Offset: 0x0000D907
	public unsafe UI_AvatarSelect.ClickCallback m_Callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_Callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_AvatarSelect.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001064 RID: 4196
	private static readonly IntPtr NativeFieldInfoPtr_m_toggles;

	// Token: 0x04001065 RID: 4197
	private static readonly IntPtr NativeFieldInfoPtr_m_buttons;

	// Token: 0x04001066 RID: 4198
	private static readonly IntPtr NativeFieldInfoPtr_m_SetText;

	// Token: 0x04001067 RID: 4199
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchase;

	// Token: 0x04001068 RID: 4200
	private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

	// Token: 0x04001069 RID: 4201
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400106A RID: 4202
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x0400106B RID: 4203
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400106C RID: 4204
	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_0;

	// Token: 0x0400106D RID: 4205
	private static readonly IntPtr NativeMethodInfoPtr_HandleToggles_Public_Void_0;

	// Token: 0x0400106E RID: 4206
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarClicked_Public_Void_Int32_0;

	// Token: 0x0400106F RID: 4207
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001E4 RID: 484
	[Serializable]
	public sealed class AvatarSetToggle : ValueType
	{
		// Token: 0x0600273C RID: 10044 RVA: 0x0008F544 File Offset: 0x0008D744
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSetToggle()
		{
			Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "AvatarSetToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr);
			UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr, "toggle");
			UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr, "set");
			UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_lockIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr, "lockIcon");
			UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr, "setName");
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0001832E File Offset: 0x0001652E
		public AvatarSetToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00018337 File Offset: 0x00016537
		public AvatarSetToggle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_AvatarSelect.AvatarSetToggle>.NativeClassPtr))
		{
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		// (set) Token: 0x06002740 RID: 10048 RVA: 0x00018349 File Offset: 0x00016549
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
		// (set) Token: 0x06002742 RID: 10050 RVA: 0x00018368 File Offset: 0x00016568
		public unsafe AvatarManager.EAvatarRestriction set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_set)) = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x0008F618 File Offset: 0x0008D818
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x00018383 File Offset: 0x00016583
		public unsafe GameObject lockIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_lockIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_lockIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x0008F648 File Offset: 0x0008D848
		// (set) Token: 0x06002746 RID: 10054 RVA: 0x000183A2 File Offset: 0x000165A2
		public unsafe string setName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_setName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarSetToggle.NativeFieldInfoPtr_setName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeFieldInfoPtr_lockIcon;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeFieldInfoPtr_setName;
	}

	// Token: 0x020001E5 RID: 485
	[Serializable]
	public sealed class AvatarButton : ValueType
	{
		// Token: 0x06002747 RID: 10055 RVA: 0x0008F670 File Offset: 0x0008D870
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarButton()
		{
			Il2CppClassPointerStore<UI_AvatarSelect.AvatarButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "AvatarButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_AvatarSelect.AvatarButton>.NativeClassPtr);
			UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarButton>.NativeClassPtr, "root");
			UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_AvatarSelect.AvatarButton>.NativeClassPtr, "avatar");
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000183C1 File Offset: 0x000165C1
		public AvatarButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000183CA File Offset: 0x000165CA
		public AvatarButton()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_AvatarSelect.AvatarButton>.NativeClassPtr))
		{
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x0008F6C4 File Offset: 0x0008D8C4
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x000183DC File Offset: 0x000165DC
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x0008F6F4 File Offset: 0x0008D8F4
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x000183FB File Offset: 0x000165FB
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_AvatarSelect.AvatarButton.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeFieldInfoPtr_avatar;
	}

	// Token: 0x020001E6 RID: 486
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x0008F724 File Offset: 0x0008D924
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_AvatarSelect>.NativeClassPtr, "ClickCallback");
			UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr, 100666406);
			UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr, 100666407);
			UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr, 100666408);
			UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr, 100666409);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0008F798 File Offset: 0x0008D998
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_AvatarSelect.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0008F7F4 File Offset: 0x0008D9F4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 84530, RefRangeEnd = 84546, XrefRangeStart = 84530, XrefRangeEnd = 84546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int avatarIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref avatarIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0008F834 File Offset: 0x0008DA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248732, XrefRangeEnd = 248736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int avatarIndex, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref avatarIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0008F8A4 File Offset: 0x0008DAA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_AvatarSelect.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0001841A File Offset: 0x0001661A
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00018423 File Offset: 0x00016623
		public static implicit operator UI_AvatarSelect.ClickCallback(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<UI_AvatarSelect.ClickCallback>(A_0);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0001842B File Offset: 0x0001662B
		public static UI_AvatarSelect.ClickCallback operator +(UI_AvatarSelect.ClickCallback A_0, UI_AvatarSelect.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UI_AvatarSelect.ClickCallback>();
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00018439 File Offset: 0x00016639
		public static UI_AvatarSelect.ClickCallback operator -(UI_AvatarSelect.ClickCallback A_0, UI_AvatarSelect.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UI_AvatarSelect.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
