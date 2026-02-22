using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005C RID: 92
	public class UIFakeStoreWindow : MonoBehaviour
	{
		// Token: 0x0600034A RID: 842 RVA: 0x00010E38 File Offset: 0x0000F038
		// Note: this type is marked as 'beforefieldinit'.
		static UIFakeStoreWindow()
		{
			Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UIFakeStoreWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr);
			UIFakeStoreWindow.NativeFieldInfoPtr_m_QueryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_QueryText");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_OkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_OkText");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_CancelText");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_LastSelectedOptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_LastSelectedOptionText");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_OnOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_OnOk");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_OnCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_OnCancel");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_OnDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_OnDropdown");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_CancelEnabled");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_DropdownEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_DropdownEnabled");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_DoDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_DoDropdown");
			UIFakeStoreWindow.NativeFieldInfoPtr_m_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "m_Dropdown");
			UIFakeStoreWindow.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "scrollPosition");
			UIFakeStoreWindow.NativeFieldInfoPtr_k_MenuScreenRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, "k_MenuScreenRatio");
			UIFakeStoreWindow.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663716);
			UIFakeStoreWindow.NativeMethodInfoPtr_CreateCenteredWindowRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663717);
			UIFakeStoreWindow.NativeMethodInfoPtr_DoMainGUI_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663718);
			UIFakeStoreWindow.NativeMethodInfoPtr_DoDropDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663719);
			UIFakeStoreWindow.NativeMethodInfoPtr_OnOkClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663720);
			UIFakeStoreWindow.NativeMethodInfoPtr_OnCancelClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663721);
			UIFakeStoreWindow.NativeMethodInfoPtr_ConfigureMainDialogText_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663722);
			UIFakeStoreWindow.NativeMethodInfoPtr_ConfigureDropdownOptions_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663723);
			UIFakeStoreWindow.NativeMethodInfoPtr_OnDropdown_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663724);
			UIFakeStoreWindow.NativeMethodInfoPtr_AssignCallbacks_Internal_Void_Action_Action_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663725);
			UIFakeStoreWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr, 100663726);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011048 File Offset: 0x0000F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154726, XrefRangeEnd = 154752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001107C File Offset: 0x0000F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154752, XrefRangeEnd = 154757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect CreateCenteredWindowRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_CreateCenteredWindowRect_Private_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154757, XrefRangeEnd = 154786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMainGUI(int windowID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_DoMainGUI_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000110F8 File Offset: 0x0000F2F8
		[CallerCount(0)]
		public unsafe void DoDropDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_DoDropDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001112C File Offset: 0x0000F32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154786, XrefRangeEnd = 154787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOkClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_OnOkClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00011160 File Offset: 0x0000F360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154787, XrefRangeEnd = 154788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCancelClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_OnCancelClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00011194 File Offset: 0x0000F394
		[CallerCount(0)]
		public unsafe void ConfigureMainDialogText(string queryText, string okText, string cancelText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queryText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(okText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_ConfigureMainDialogText_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000111FC File Offset: 0x0000F3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154788, XrefRangeEnd = 154806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDropdownOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_ConfigureDropdownOptions_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011240 File Offset: 0x0000F440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154806, XrefRangeEnd = 154809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDropdown(int index, string selectionText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(selectionText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_OnDropdown_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00011290 File Offset: 0x0000F490
		[CallerCount(0)]
		public unsafe void AssignCallbacks(Action onOk, Action onCancel, Action<int> onDropdown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onOk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDropdown);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr_AssignCallbacks_Internal_Void_Action_Action_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154809, XrefRangeEnd = 154814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFakeStoreWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFakeStoreWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStoreWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000039B7 File Offset: 0x00001BB7
		public UIFakeStoreWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00011334 File Offset: 0x0000F534
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000039C0 File Offset: 0x00001BC0
		public unsafe string m_QueryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_QueryText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_QueryText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0001135C File Offset: 0x0000F55C
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000039DF File Offset: 0x00001BDF
		public unsafe string m_OkText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OkText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OkText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00011384 File Offset: 0x0000F584
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000039FE File Offset: 0x00001BFE
		public unsafe string m_CancelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000113AC File Offset: 0x0000F5AC
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00003A1D File Offset: 0x00001C1D
		public unsafe string m_LastSelectedOptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_LastSelectedOptionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_LastSelectedOptionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000113D4 File Offset: 0x0000F5D4
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00003A3C File Offset: 0x00001C3C
		public unsafe Action m_OnOk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnOk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnOk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00011404 File Offset: 0x0000F604
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00003A5B File Offset: 0x00001C5B
		public unsafe Action m_OnCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnCancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00011434 File Offset: 0x0000F634
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00003A7A File Offset: 0x00001C7A
		public unsafe Action<int> m_OnDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_OnDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00011464 File Offset: 0x0000F664
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00003A99 File Offset: 0x00001C99
		public unsafe bool m_CancelEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_CancelEnabled)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0001148C File Offset: 0x0000F68C
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public unsafe bool m_DropdownEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_DropdownEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_DropdownEnabled)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000369 RID: 873 RVA: 0x000114B4 File Offset: 0x0000F6B4
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003ACF File Offset: 0x00001CCF
		public unsafe bool m_DoDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_DoDropdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_DoDropdown)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000114DC File Offset: 0x0000F6DC
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00003AEA File Offset: 0x00001CEA
		public unsafe UIFakeStoreDropdown m_Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIFakeStoreDropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_m_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0001150C File Offset: 0x0000F70C
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003B09 File Offset: 0x00001D09
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStoreWindow.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00011534 File Offset: 0x0000F734
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003B24 File Offset: 0x00001D24
		public unsafe static float k_MenuScreenRatio
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UIFakeStoreWindow.NativeFieldInfoPtr_k_MenuScreenRatio, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIFakeStoreWindow.NativeFieldInfoPtr_k_MenuScreenRatio, (void*)(&value));
			}
		}

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_m_QueryText;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_m_OkText;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelText;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_m_LastSelectedOptionText;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_m_OnOk;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_m_OnCancel;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDropdown;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelEnabled;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_m_DropdownEnabled;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_m_DoDropdown;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_m_Dropdown;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_k_MenuScreenRatio;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_CreateCenteredWindowRect_Private_Rect_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_DoMainGUI_Private_Void_Int32_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_DoDropDown_Private_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_OnOkClicked_Private_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_OnCancelClicked_Private_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureMainDialogText_Internal_Void_String_String_String_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDropdownOptions_Internal_Void_List_1_String_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_OnDropdown_Private_Void_Int32_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_AssignCallbacks_Internal_Void_Action_Action_Action_1_Int32_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
