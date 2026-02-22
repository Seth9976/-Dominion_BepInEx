using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005B RID: 91
	public class UIFakeStoreDropdown : Object
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00010B9C File Offset: 0x0000ED9C
		// Note: this type is marked as 'beforefieldinit'.
		static UIFakeStoreDropdown()
		{
			Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UIFakeStoreDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr);
			UIFakeStoreDropdown.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, "m_Options");
			UIFakeStoreDropdown.NativeFieldInfoPtr_m_OnDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, "m_OnDropdown");
			UIFakeStoreDropdown.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, "scrollPosition");
			UIFakeStoreDropdown.NativeMethodInfoPtr_DoPopup_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, 100663711);
			UIFakeStoreDropdown.NativeMethodInfoPtr_OnOptionSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, 100663712);
			UIFakeStoreDropdown.NativeMethodInfoPtr_SetOptions_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, 100663713);
			UIFakeStoreDropdown.NativeMethodInfoPtr_SetSelectionAction_Internal_Void_Action_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, 100663714);
			UIFakeStoreDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr, 100663715);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00010C6C File Offset: 0x0000EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154687, XrefRangeEnd = 154714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPopup(int windowID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreDropdown.NativeMethodInfoPtr_DoPopup_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00010CAC File Offset: 0x0000EEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154719, RefRangeEnd = 154720, XrefRangeStart = 154714, XrefRangeEnd = 154719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOptionSelected(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreDropdown.NativeMethodInfoPtr_OnOptionSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00010CEC File Offset: 0x0000EEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154720, XrefRangeEnd = 154726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreDropdown.NativeMethodInfoPtr_SetOptions_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00010D30 File Offset: 0x0000EF30
		[CallerCount(0)]
		public unsafe void SetSelectionAction(Action<int, string> onDropdown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDropdown);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreDropdown.NativeMethodInfoPtr_SetSelectionAction_Internal_Void_Action_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00010D74 File Offset: 0x0000EF74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFakeStoreDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFakeStoreDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003955 File Offset: 0x00001B55
		public UIFakeStoreDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000395E File Offset: 0x00001B5E
		public unsafe List<string> m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000397D File Offset: 0x00001B7D
		public unsafe Action<int, string> m_OnDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_m_OnDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_m_OnDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00010E10 File Offset: 0x0000F010
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreDropdown.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDropdown;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_DoPopup_Public_Void_Int32_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionSelected_Private_Void_Int32_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Internal_Void_List_1_String_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionAction_Internal_Void_Action_2_Int32_String_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
