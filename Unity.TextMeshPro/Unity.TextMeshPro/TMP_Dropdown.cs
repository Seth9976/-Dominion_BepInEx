using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200002C RID: 44
	public class TMP_Dropdown : Selectable
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x00016718 File Offset: 0x00014918
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Dropdown()
		{
			Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Dropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr);
			TMP_Dropdown.NativeFieldInfoPtr_m_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Template");
			TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_CaptionText");
			TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_CaptionImage");
			TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Placeholder");
			TMP_Dropdown.NativeFieldInfoPtr_m_ItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_ItemText");
			TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_ItemImage");
			TMP_Dropdown.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Value");
			TMP_Dropdown.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Options");
			TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_OnValueChanged");
			TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_AlphaFadeSpeed");
			TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Dropdown");
			TMP_Dropdown.NativeFieldInfoPtr_m_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Blocker");
			TMP_Dropdown.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Items");
			TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_AlphaTweenRunner");
			TMP_Dropdown.NativeFieldInfoPtr_validTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "validTemplate");
			TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Coroutine");
			TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "s_NoOptionData");
			TMP_Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663659);
			TMP_Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663660);
			TMP_Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663661);
			TMP_Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663662);
			TMP_Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663663);
			TMP_Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663664);
			TMP_Dropdown.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663665);
			TMP_Dropdown.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663666);
			TMP_Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663667);
			TMP_Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663668);
			TMP_Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663669);
			TMP_Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663670);
			TMP_Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663671);
			TMP_Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663672);
			TMP_Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663673);
			TMP_Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663674);
			TMP_Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663675);
			TMP_Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663676);
			TMP_Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663677);
			TMP_Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663678);
			TMP_Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663679);
			TMP_Dropdown.NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663680);
			TMP_Dropdown.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663681);
			TMP_Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663682);
			TMP_Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663683);
			TMP_Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663684);
			TMP_Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663685);
			TMP_Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663686);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663687);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663688);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663689);
			TMP_Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663690);
			TMP_Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663691);
			TMP_Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663692);
			TMP_Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663693);
			TMP_Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663694);
			TMP_Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663695);
			TMP_Dropdown.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663696);
			TMP_Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663697);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663698);
			TMP_Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663699);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663700);
			TMP_Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663701);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663702);
			TMP_Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663703);
			TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663704);
			TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663705);
			TMP_Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663706);
			TMP_Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663707);
			TMP_Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663708);
			TMP_Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663709);
			TMP_Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663710);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00016CAC File Offset: 0x00014EAC
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00016CEC File Offset: 0x00014EEC
		public unsafe RectTransform template
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138263, XrefRangeEnd = 138264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00016D30 File Offset: 0x00014F30
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00016D70 File Offset: 0x00014F70
		public unsafe TMP_Text captionText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138264, XrefRangeEnd = 138265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00016DB4 File Offset: 0x00014FB4
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00016DF4 File Offset: 0x00014FF4
		public unsafe Image captionImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138265, XrefRangeEnd = 138266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00016E38 File Offset: 0x00015038
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00016E78 File Offset: 0x00015078
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138266, XrefRangeEnd = 138267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00016EBC File Offset: 0x000150BC
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00016EFC File Offset: 0x000150FC
		public unsafe TMP_Text itemText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138267, XrefRangeEnd = 138268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00016F40 File Offset: 0x00015140
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00016F80 File Offset: 0x00015180
		public unsafe Image itemImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138268, XrefRangeEnd = 138269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00016FC4 File Offset: 0x000151C4
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00017004 File Offset: 0x00015204
		public unsafe List<TMP_Dropdown.OptionData> options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138269, XrefRangeEnd = 138271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00017048 File Offset: 0x00015248
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00017088 File Offset: 0x00015288
		public unsafe TMP_Dropdown.DropdownEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000170CC File Offset: 0x000152CC
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00017108 File Offset: 0x00015308
		public unsafe float alphaFadeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00017148 File Offset: 0x00015348
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00017184 File Offset: 0x00015384
		public unsafe int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138271, XrefRangeEnd = 138272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000171C4 File Offset: 0x000153C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138272, XrefRangeEnd = 138273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(int input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00017204 File Offset: 0x00015404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138287, RefRangeEnd = 138290, XrefRangeStart = 138273, XrefRangeEnd = 138287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00017250 File Offset: 0x00015450
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138290, XrefRangeEnd = 138294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001728C File Offset: 0x0001548C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138294, XrefRangeEnd = 138312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Dropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000172C8 File Offset: 0x000154C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138312, XrefRangeEnd = 138325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00017304 File Offset: 0x00015504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138325, XrefRangeEnd = 138341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00017340 File Offset: 0x00015540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138341, XrefRangeEnd = 138347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001737C File Offset: 0x0001557C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 138376, RefRangeEnd = 138393, XrefRangeStart = 138347, XrefRangeEnd = 138376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000173B0 File Offset: 0x000155B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138393, XrefRangeEnd = 138398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<TMP_Dropdown.OptionData> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000173F4 File Offset: 0x000155F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138398, XrefRangeEnd = 138411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00017438 File Offset: 0x00015638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138411, XrefRangeEnd = 138424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Sprite> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001747C File Offset: 0x0001567C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138424, XrefRangeEnd = 138433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000174B0 File Offset: 0x000156B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138527, RefRangeEnd = 138528, XrefRangeStart = 138433, XrefRangeEnd = 138527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupTemplate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000174E4 File Offset: 0x000156E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138532, RefRangeEnd = 138536, XrefRangeStart = 138528, XrefRangeEnd = 138532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00017524 File Offset: 0x00015724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138536, XrefRangeEnd = 138537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00017574 File Offset: 0x00015774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000175C4 File Offset: 0x000157C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138537, XrefRangeEnd = 138538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00017614 File Offset: 0x00015814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138691, RefRangeEnd = 138693, XrefRangeStart = 138538, XrefRangeEnd = 138691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00017648 File Offset: 0x00015848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138693, XrefRangeEnd = 138757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000176A4 File Offset: 0x000158A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138757, XrefRangeEnd = 138761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyBlocker(GameObject blocker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blocker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000176F4 File Offset: 0x000158F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138761, XrefRangeEnd = 138767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateDropdownList(GameObject template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00017750 File Offset: 0x00015950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138767, XrefRangeEnd = 138771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyDropdownList(GameObject dropdownList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropdownList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000177A0 File Offset: 0x000159A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138771, XrefRangeEnd = 138777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr3) : null;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000177FC File Offset: 0x000159FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(TMP_Dropdown.DropdownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001784C File Offset: 0x00015A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138813, RefRangeEnd = 138814, XrefRangeStart = 138777, XrefRangeEnd = 138813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selected;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr3) : null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000178D0 File Offset: 0x00015AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138814, XrefRangeEnd = 138819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlphaFadeList(float duration, float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001791C File Offset: 0x00015B1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138838, RefRangeEnd = 138841, XrefRangeStart = 138819, XrefRangeEnd = 138838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlphaFadeList(float duration, float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00017978 File Offset: 0x00015B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138841, XrefRangeEnd = 138849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000179B8 File Offset: 0x00015BB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138866, RefRangeEnd = 138869, XrefRangeStart = 138849, XrefRangeEnd = 138866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000179EC File Offset: 0x00015BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138869, XrefRangeEnd = 138873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDestroyDropdownList(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00017A38 File Offset: 0x00015C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138892, RefRangeEnd = 138894, XrefRangeStart = 138873, XrefRangeEnd = 138892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImmediateDestroyDropdownList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00017A6C File Offset: 0x00015C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138906, RefRangeEnd = 138907, XrefRangeStart = 138894, XrefRangeEnd = 138906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectItem(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00003FCF File Offset: 0x000021CF
		public TMP_Dropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00017AB0 File Offset: 0x00015CB0
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00003FD8 File Offset: 0x000021D8
		public unsafe RectTransform m_Template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00017AE0 File Offset: 0x00015CE0
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003FF7 File Offset: 0x000021F7
		public unsafe TMP_Text m_CaptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00017B10 File Offset: 0x00015D10
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00004016 File Offset: 0x00002216
		public unsafe Image m_CaptionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00017B40 File Offset: 0x00015D40
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004035 File Offset: 0x00002235
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00017B70 File Offset: 0x00015D70
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00004054 File Offset: 0x00002254
		public unsafe TMP_Text m_ItemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00017BA0 File Offset: 0x00015DA0
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00004073 File Offset: 0x00002273
		public unsafe Image m_ItemImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00017BD0 File Offset: 0x00015DD0
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00004092 File Offset: 0x00002292
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00017BF8 File Offset: 0x00015DF8
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000040AD File Offset: 0x000022AD
		public unsafe TMP_Dropdown.OptionDataList m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.OptionDataList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00017C28 File Offset: 0x00015E28
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x000040CC File Offset: 0x000022CC
		public unsafe TMP_Dropdown.DropdownEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00017C58 File Offset: 0x00015E58
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000040EB File Offset: 0x000022EB
		public unsafe float m_AlphaFadeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00017C80 File Offset: 0x00015E80
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004106 File Offset: 0x00002306
		public unsafe GameObject m_Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00017CB0 File Offset: 0x00015EB0
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00004125 File Offset: 0x00002325
		public unsafe GameObject m_Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00017CE0 File Offset: 0x00015EE0
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe List<TMP_Dropdown.DropdownItem> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.DropdownItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00017D10 File Offset: 0x00015F10
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00004163 File Offset: 0x00002363
		public unsafe TweenRunner<FloatTween> m_AlphaTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<FloatTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00017D40 File Offset: 0x00015F40
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00004182 File Offset: 0x00002382
		public unsafe bool validTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_validTemplate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_validTemplate)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00017D68 File Offset: 0x00015F68
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000419D File Offset: 0x0000239D
		public unsafe Coroutine m_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00017D98 File Offset: 0x00015F98
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000041BC File Offset: 0x000023BC
		public unsafe static TMP_Dropdown.OptionData s_NoOptionData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.OptionData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_m_Template;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionText;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionImage;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemText;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemImage;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaFadeSpeed;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_m_Dropdown;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_m_Blocker;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaTweenRunner;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_validTemplate;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_m_Coroutine;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_s_NoOptionData;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_template_Public_get_RectTransform_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_captionImage_Public_get_Image_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_itemImage_Public_get_Image_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValue_Public_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_SetupTemplate_Private_Void_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0;

		// Token: 0x0200007F RID: 127
		public class DropdownItem : MonoBehaviour
		{
			// Token: 0x06000EC3 RID: 3779 RVA: 0x0003B664 File Offset: 0x00039864
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownItem()
			{
				Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "DropdownItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr);
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Text");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Image");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_RectTransform");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Toggle");
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664805);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664806);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664807);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664808);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664809);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664810);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664811);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664812);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664813);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664814);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100664815);
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0003B7BC File Offset: 0x000399BC
			// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0003B7FC File Offset: 0x000399FC
			public unsafe TMP_Text text
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0003B840 File Offset: 0x00039A40
			// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0003B880 File Offset: 0x00039A80
			public unsafe Image image
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0003B8C4 File Offset: 0x00039AC4
			// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0003B904 File Offset: 0x00039B04
			public unsafe RectTransform rectTransform
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0003B948 File Offset: 0x00039B48
			// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0003B988 File Offset: 0x00039B88
			public unsafe Toggle toggle
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000ECC RID: 3788 RVA: 0x0003B9CC File Offset: 0x00039BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138225, XrefRangeEnd = 138232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPointerEnter(PointerEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000ECD RID: 3789 RVA: 0x0003BA1C File Offset: 0x00039C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138232, XrefRangeEnd = 138240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnCancel(BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000ECE RID: 3790 RVA: 0x0003BA6C File Offset: 0x00039C6C
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000ECF RID: 3791 RVA: 0x00008FD5 File Offset: 0x000071D5
			public DropdownItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0003BAA8 File Offset: 0x00039CA8
			// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00008FDE File Offset: 0x000071DE
			public unsafe TMP_Text m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0003BAD8 File Offset: 0x00039CD8
			// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00008FFD File Offset: 0x000071FD
			public unsafe Image m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0003BB08 File Offset: 0x00039D08
			// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0000901C File Offset: 0x0000721C
			public unsafe RectTransform m_RectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0003BB38 File Offset: 0x00039D38
			// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0000903B File Offset: 0x0000723B
			public unsafe Toggle m_Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BB2 RID: 2994
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04000BB3 RID: 2995
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x04000BB4 RID: 2996
			private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

			// Token: 0x04000BB5 RID: 2997
			private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

			// Token: 0x04000BB6 RID: 2998
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0;

			// Token: 0x04000BB7 RID: 2999
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0;

			// Token: 0x04000BB8 RID: 3000
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

			// Token: 0x04000BB9 RID: 3001
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

			// Token: 0x04000BBA RID: 3002
			private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

			// Token: 0x04000BBB RID: 3003
			private static readonly IntPtr NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0;

			// Token: 0x04000BBC RID: 3004
			private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0;

			// Token: 0x04000BBD RID: 3005
			private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0;

			// Token: 0x04000BBE RID: 3006
			private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

			// Token: 0x04000BBF RID: 3007
			private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

			// Token: 0x04000BC0 RID: 3008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000080 RID: 128
		[Serializable]
		public class OptionData : global::Il2CppSystem.Object
		{
			// Token: 0x06000ED8 RID: 3800 RVA: 0x0003BB68 File Offset: 0x00039D68
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr);
				TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, "m_Text");
				TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, "m_Image");
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664816);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664817);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664818);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664819);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664820);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664821);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664822);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100664823);
			}

			// Token: 0x1700057D RID: 1405
			// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0003BC5C File Offset: 0x00039E5C
			// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0003BC94 File Offset: 0x00039E94
			public unsafe string text
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700057E RID: 1406
			// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0003BCD8 File Offset: 0x00039ED8
			// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0003BD18 File Offset: 0x00039F18
			public unsafe Sprite image
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EDD RID: 3805 RVA: 0x0003BD5C File Offset: 0x00039F5C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EDE RID: 3806 RVA: 0x0003BD98 File Offset: 0x00039F98
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EDF RID: 3807 RVA: 0x0003BDE4 File Offset: 0x00039FE4
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EE0 RID: 3808 RVA: 0x0003BE30 File Offset: 0x0003A030
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text, Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EE1 RID: 3809 RVA: 0x0000905A File Offset: 0x0000725A
			public OptionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0003BE90 File Offset: 0x0003A090
			// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00009063 File Offset: 0x00007263
			public unsafe string m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700057C RID: 1404
			// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003BEB8 File Offset: 0x0003A0B8
			// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00009082 File Offset: 0x00007282
			public unsafe Sprite m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BC1 RID: 3009
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04000BC2 RID: 3010
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x04000BC3 RID: 3011
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

			// Token: 0x04000BC4 RID: 3012
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

			// Token: 0x04000BC5 RID: 3013
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Sprite_0;

			// Token: 0x04000BC6 RID: 3014
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0;

			// Token: 0x04000BC7 RID: 3015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BC8 RID: 3016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04000BC9 RID: 3017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sprite_0;

			// Token: 0x04000BCA RID: 3018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0;
		}

		// Token: 0x02000081 RID: 129
		[Serializable]
		public class OptionDataList : global::Il2CppSystem.Object
		{
			// Token: 0x06000EE6 RID: 3814 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
			// Note: this type is marked as 'beforefieldinit'.
			static OptionDataList()
			{
				Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "OptionDataList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr);
				TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, "m_Options");
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100664824);
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100664825);
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100664826);
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0003BF64 File Offset: 0x0003A164
			// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0003BFA4 File Offset: 0x0003A1A4
			public unsafe List<TMP_Dropdown.OptionData> options
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EE9 RID: 3817 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 138247, RefRangeEnd = 138248, XrefRangeStart = 138240, XrefRangeEnd = 138247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionDataList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EEA RID: 3818 RVA: 0x000090A1 File Offset: 0x000072A1
			public OptionDataList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700057F RID: 1407
			// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0003C024 File Offset: 0x0003A224
			// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000090AA File Offset: 0x000072AA
			public unsafe List<TMP_Dropdown.OptionData> m_Options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BCB RID: 3019
			private static readonly IntPtr NativeFieldInfoPtr_m_Options;

			// Token: 0x04000BCC RID: 3020
			private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

			// Token: 0x04000BCD RID: 3021
			private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

			// Token: 0x04000BCE RID: 3022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000082 RID: 130
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x06000EED RID: 3821 RVA: 0x000090C9 File Offset: 0x000072C9
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownEvent()
			{
				Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "DropdownEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr);
				TMP_Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr, 100664827);
			}

			// Token: 0x06000EEE RID: 3822 RVA: 0x0003C054 File Offset: 0x0003A254
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 138251, RefRangeEnd = 138252, XrefRangeStart = 138248, XrefRangeEnd = 138251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EEF RID: 3823 RVA: 0x000090FD File Offset: 0x000072FD
			public DropdownEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000BCF RID: 3023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("TMPro.TMP_Dropdown+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000EF0 RID: 3824 RVA: 0x0003C090 File Offset: 0x0003A290
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr);
				TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, "item");
				TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, "<>4__this");
				TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, 100664828);
				TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, 100664829);
			}

			// Token: 0x06000EF1 RID: 3825 RVA: 0x0003C10C File Offset: 0x0003A30C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EF2 RID: 3826 RVA: 0x0003C148 File Offset: 0x0003A348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138252, XrefRangeEnd = 138254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Show_b__0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EF3 RID: 3827 RVA: 0x00009106 File Offset: 0x00007306
			public __c__DisplayClass69_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0003C188 File Offset: 0x0003A388
			// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0000910F File Offset: 0x0000730F
			public unsafe TMP_Dropdown.DropdownItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
			// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0000912E File Offset: 0x0000732E
			public unsafe TMP_Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BD0 RID: 3024
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04000BD1 RID: 3025
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000BD2 RID: 3026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BD3 RID: 3027
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x02000084 RID: 132
		[ObfuscatedName("TMPro.TMP_Dropdown+<DelayedDestroyDropdownList>d__81")]
		public sealed class _DelayedDestroyDropdownList_d__81 : global::Il2CppSystem.Object
		{
			// Token: 0x06000EF8 RID: 3832 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDestroyDropdownList_d__81()
			{
				Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "<DelayedDestroyDropdownList>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>1__state");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>2__current");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "delay");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>4__this");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664830);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664831);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664832);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664833);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664834);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100664835);
			}

			// Token: 0x06000EF9 RID: 3833 RVA: 0x0003C2DC File Offset: 0x0003A4DC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDestroyDropdownList_d__81(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EFA RID: 3834 RVA: 0x0003C324 File Offset: 0x0003A524
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x0003C358 File Offset: 0x0003A558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138254, XrefRangeEnd = 138258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0003C394 File Offset: 0x0003A594
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EFD RID: 3837 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138258, XrefRangeEnd = 138263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0003C408 File Offset: 0x0003A608
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x0000914D File Offset: 0x0000734D
			public _DelayedDestroyDropdownList_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0003C448 File Offset: 0x0003A648
			// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00009156 File Offset: 0x00007356
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0003C470 File Offset: 0x0003A670
			// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00009171 File Offset: 0x00007371
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0003C4A0 File Offset: 0x0003A6A0
			// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00009190 File Offset: 0x00007390
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
			// (set) Token: 0x06000F07 RID: 3847 RVA: 0x000091AB File Offset: 0x000073AB
			public unsafe TMP_Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BD4 RID: 3028
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000BD5 RID: 3029
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000BD6 RID: 3030
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04000BD7 RID: 3031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000BD8 RID: 3032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000BD9 RID: 3033
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BDA RID: 3034
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000BDB RID: 3035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000BDC RID: 3036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BDD RID: 3037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000085 RID: 133
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>
		{
			// Token: 0x04000BDE RID: 3038
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0, Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
