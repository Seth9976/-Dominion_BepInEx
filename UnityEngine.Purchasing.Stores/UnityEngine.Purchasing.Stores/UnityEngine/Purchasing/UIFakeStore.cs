using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005A RID: 90
	public class UIFakeStore : FakeStore
	{
		// Token: 0x06000321 RID: 801 RVA: 0x000103F0 File Offset: 0x0000E5F0
		// Note: this type is marked as 'beforefieldinit'.
		static UIFakeStore()
		{
			Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UIFakeStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr);
			UIFakeStore.NativeFieldInfoPtr_m_CurrentDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "m_CurrentDialog");
			UIFakeStore.NativeFieldInfoPtr_m_LastSelectedDropdownIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "m_LastSelectedDropdownIndex");
			UIFakeStore.NativeFieldInfoPtr_m_UIFakeStoreWindowObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "m_UIFakeStoreWindowObject");
			UIFakeStore.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "m_EventSystem");
			UIFakeStore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663688);
			UIFakeStore.NativeMethodInfoPtr_StartUI_Protected_Virtual_Boolean_Object_DialogType_Action_2_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663689);
			UIFakeStore.NativeMethodInfoPtr_StartUI_Private_Boolean_String_String_String_List_1_String_Action_2_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663690);
			UIFakeStore.NativeMethodInfoPtr_InstantiateDialog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663691);
			UIFakeStore.NativeMethodInfoPtr_GetOrCreateFakeStoreWindow_Private_UIFakeStoreWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663692);
			UIFakeStore.NativeMethodInfoPtr_AddLifeCycleNotifierAndSetDestroyCallback_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663693);
			UIFakeStore.NativeMethodInfoPtr_EnsureEventSystemCreated_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663694);
			UIFakeStore.NativeMethodInfoPtr_ConfigureDialogWindow_Private_Void_UIFakeStoreWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663695);
			UIFakeStore.NativeMethodInfoPtr_ConfigureDialogWindowCallbacks_Private_Void_UIFakeStoreWindow_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663696);
			UIFakeStore.NativeMethodInfoPtr_CreateEventSystem_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663697);
			UIFakeStore.NativeMethodInfoPtr_CreatePurchaseQuestion_Private_String_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663698);
			UIFakeStore.NativeMethodInfoPtr_CreateRetrieveProductsQuestion_Private_String_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663699);
			UIFakeStore.NativeMethodInfoPtr_OkayButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663700);
			UIFakeStore.NativeMethodInfoPtr_CancelButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663701);
			UIFakeStore.NativeMethodInfoPtr_DropdownValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663702);
			UIFakeStore.NativeMethodInfoPtr_CloseDialog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663703);
			UIFakeStore.NativeMethodInfoPtr_IsShowingDialog_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663704);
			UIFakeStore.NativeMethodInfoPtr__AddLifeCycleNotifierAndSetDestroyCallback_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, 100663705);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFakeStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00010614 File Offset: 0x0000E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154325, XrefRangeEnd = 154401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StartUI<T>(Object model, FakeStore.DialogType dialogType, Action<bool, T> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dialogType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIFakeStore.MethodInfoStoreGeneric_StartUI_Protected_Virtual_Boolean_Object_DialogType_Action_2_Boolean_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001068C File Offset: 0x0000E88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154406, RefRangeEnd = 154407, XrefRangeStart = 154401, XrefRangeEnd = 154406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queryText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(okayButtonText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelButtonText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_StartUI_Private_Boolean_String_String_String_List_1_String_Action_2_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00010724 File Offset: 0x0000E924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154458, RefRangeEnd = 154459, XrefRangeStart = 154407, XrefRangeEnd = 154458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_InstantiateDialog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00010758 File Offset: 0x0000E958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154459, XrefRangeEnd = 154490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFakeStoreWindow GetOrCreateFakeStoreWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_GetOrCreateFakeStoreWindow_Private_UIFakeStoreWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIFakeStoreWindow>(intPtr3) : null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00010798 File Offset: 0x0000E998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154490, XrefRangeEnd = 154499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_AddLifeCycleNotifierAndSetDestroyCallback_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000107DC File Offset: 0x0000E9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154527, RefRangeEnd = 154528, XrefRangeStart = 154499, XrefRangeEnd = 154527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureEventSystemCreated(Transform rootTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_EnsureEventSystemCreated_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00010820 File Offset: 0x0000EA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154565, RefRangeEnd = 154566, XrefRangeStart = 154528, XrefRangeEnd = 154565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogWindow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_ConfigureDialogWindow_Private_Void_UIFakeStoreWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00010864 File Offset: 0x0000EA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154566, XrefRangeEnd = 154585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogWindow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignCancelCallback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignDropDownCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_ConfigureDialogWindowCallbacks_Private_Void_UIFakeStoreWindow_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000108C4 File Offset: 0x0000EAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154585, XrefRangeEnd = 154611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEventSystem(Transform rootTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_CreateEventSystem_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00010908 File Offset: 0x0000EB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154617, RefRangeEnd = 154618, XrefRangeStart = 154611, XrefRangeEnd = 154617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreatePurchaseQuestion(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_CreatePurchaseQuestion_Private_String_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00010950 File Offset: 0x0000EB50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154658, RefRangeEnd = 154660, XrefRangeStart = 154618, XrefRangeEnd = 154658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateRetrieveProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definitions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_CreateRetrieveProductsQuestion_Private_String_ReadOnlyCollection_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00010998 File Offset: 0x0000EB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154660, XrefRangeEnd = 154669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OkayButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_OkayButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000109CC File Offset: 0x0000EBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154669, XrefRangeEnd = 154678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_CancelButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00010A00 File Offset: 0x0000EC00
		[CallerCount(0)]
		public unsafe void DropdownValueChanged(int selectedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectedItem;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_DropdownValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00010A40 File Offset: 0x0000EC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154685, RefRangeEnd = 154687, XrefRangeStart = 154678, XrefRangeEnd = 154685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_CloseDialog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00010A74 File Offset: 0x0000EC74
		[CallerCount(0)]
		public unsafe bool IsShowingDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr_IsShowingDialog_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		[CallerCount(0)]
		public unsafe void _AddLifeCycleNotifierAndSetDestroyCallback_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.NativeMethodInfoPtr__AddLifeCycleNotifierAndSetDestroyCallback_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000038D4 File Offset: 0x00001AD4
		public UIFakeStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000038DD File Offset: 0x00001ADD
		public unsafe DialogRequest m_CurrentDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_CurrentDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_CurrentDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00010B14 File Offset: 0x0000ED14
		// (set) Token: 0x06000338 RID: 824 RVA: 0x000038FC File Offset: 0x00001AFC
		public unsafe int m_LastSelectedDropdownIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_LastSelectedDropdownIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_LastSelectedDropdownIndex)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00010B3C File Offset: 0x0000ED3C
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00003917 File Offset: 0x00001B17
		public unsafe GameObject m_UIFakeStoreWindowObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_UIFakeStoreWindowObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_UIFakeStoreWindowObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00010B6C File Offset: 0x0000ED6C
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003936 File Offset: 0x00001B36
		public unsafe GameObject m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDialog;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_m_LastSelectedDropdownIndex;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_m_UIFakeStoreWindowObject;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_StartUI_Protected_Virtual_Boolean_Object_DialogType_Action_2_Boolean_T_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_StartUI_Private_Boolean_String_String_String_List_1_String_Action_2_Boolean_Int32_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateDialog_Private_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateFakeStoreWindow_Private_UIFakeStoreWindow_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_AddLifeCycleNotifierAndSetDestroyCallback_Private_Void_GameObject_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_EnsureEventSystemCreated_Private_Void_Transform_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDialogWindow_Private_Void_UIFakeStoreWindow_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDialogWindowCallbacks_Private_Void_UIFakeStoreWindow_Boolean_Boolean_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_CreateEventSystem_Private_Void_Transform_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_CreatePurchaseQuestion_Private_String_ProductDefinition_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_CreateRetrieveProductsQuestion_Private_String_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_OkayButtonClicked_Private_Void_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_CancelButtonClicked_Private_Void_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_DropdownValueChanged_Private_Void_Int32_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_CloseDialog_Private_Void_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_IsShowingDialog_Public_Boolean_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr__AddLifeCycleNotifierAndSetDestroyCallback_b__14_0_Private_Void_0;

		// Token: 0x020000BB RID: 187
		[ObfuscatedName("UnityEngine.Purchasing.UIFakeStore+<>c__DisplayClass10_0`1")]
		public sealed class __c__DisplayClass10_0<T> : Object
		{
			// Token: 0x060006DB RID: 1755 RVA: 0x0001C024 File Offset: 0x0001A224
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "<>c__DisplayClass10_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr);
				UIFakeStore.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr, "callback");
				UIFakeStore.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr, 100663706);
				UIFakeStore.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__StartUI_b__0_Internal_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr, 100663707);
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFakeStore.__c__DisplayClass10_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x0001C104 File Offset: 0x0001A304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154320, XrefRangeEnd = 154325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartUI_b__0(bool result, int codeValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref codeValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__StartUI_b__0_Internal_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00005783 File Offset: 0x00003983
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001C150 File Offset: 0x0001A350
			// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0000578C File Offset: 0x0000398C
			public unsafe Action<bool, T> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFakeStore.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000475 RID: 1141
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000476 RID: 1142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000477 RID: 1143
			private static readonly IntPtr NativeMethodInfoPtr__StartUI_b__0_Internal_Void_Boolean_Int32_0;
		}

		// Token: 0x020000BC RID: 188
		[ObfuscatedName("UnityEngine.Purchasing.UIFakeStore+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006E1 RID: 1761 RVA: 0x0001C180 File Offset: 0x0001A380
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr);
				UIFakeStore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr, "<>9");
				UIFakeStore.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr, "<>9__20_0");
				UIFakeStore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr, 100663709);
				UIFakeStore.__c.NativeMethodInfoPtr__CreateRetrieveProductsQuestion_b__20_0_Internal_String_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr, 100663710);
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x0001C1FC File Offset: 0x0001A3FC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFakeStore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x0001C238 File Offset: 0x0001A438
			[CallerCount(0)]
			public unsafe string _CreateRetrieveProductsQuestion_b__20_0(ProductDefinition pid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFakeStore.__c.NativeMethodInfoPtr__CreateRetrieveProductsQuestion_b__20_0_Internal_String_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x000057AB File Offset: 0x000039AB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001C280 File Offset: 0x0001A480
			// (set) Token: 0x060006E6 RID: 1766 RVA: 0x000057B4 File Offset: 0x000039B4
			public unsafe static UIFakeStore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIFakeStore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIFakeStore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIFakeStore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
			// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000057C6 File Offset: 0x000039C6
			public unsafe static Func<ProductDefinition, string> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIFakeStore.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIFakeStore.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000478 RID: 1144
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000479 RID: 1145
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400047A RID: 1146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400047B RID: 1147
			private static readonly IntPtr NativeMethodInfoPtr__CreateRetrieveProductsQuestion_b__20_0_Internal_String_ProductDefinition_0;
		}

		// Token: 0x020000BD RID: 189
		private sealed class MethodInfoStoreGeneric_StartUI_Protected_Virtual_Boolean_Object_DialogType_Action_2_Boolean_T_0<T>
		{
			// Token: 0x0400047C RID: 1148
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UIFakeStore.NativeMethodInfoPtr_StartUI_Protected_Virtual_Boolean_Object_DialogType_Action_2_Boolean_T_0, Il2CppClassPointerStore<UIFakeStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
