using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x0200000E RID: 14
	public class Dropdown : Selectable
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00009A40 File Offset: 0x00007C40
		// Note: this type is marked as 'beforefieldinit'.
		static Dropdown()
		{
			Il2CppClassPointerStore<Dropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Dropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown>.NativeClassPtr);
			Dropdown.NativeFieldInfoPtr_m_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Template");
			Dropdown.NativeFieldInfoPtr_m_CaptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_CaptionText");
			Dropdown.NativeFieldInfoPtr_m_CaptionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_CaptionImage");
			Dropdown.NativeFieldInfoPtr_m_ItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_ItemText");
			Dropdown.NativeFieldInfoPtr_m_ItemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_ItemImage");
			Dropdown.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Value");
			Dropdown.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Options");
			Dropdown.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_OnValueChanged");
			Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_AlphaFadeSpeed");
			Dropdown.NativeFieldInfoPtr_m_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Dropdown");
			Dropdown.NativeFieldInfoPtr_m_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Blocker");
			Dropdown.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Items");
			Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_AlphaTweenRunner");
			Dropdown.NativeFieldInfoPtr_validTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "validTemplate");
			Dropdown.NativeFieldInfoPtr_s_NoOptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "s_NoOptionData");
			Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663393);
			Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663394);
			Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663395);
			Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663396);
			Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663397);
			Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663398);
			Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663399);
			Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663400);
			Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663401);
			Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663402);
			Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663403);
			Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663404);
			Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663405);
			Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663406);
			Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663407);
			Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663408);
			Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663409);
			Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663410);
			Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663411);
			Dropdown.NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663412);
			Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663413);
			Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663414);
			Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663415);
			Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663416);
			Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663417);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663418);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663419);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663420);
			Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663421);
			Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663422);
			Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663423);
			Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663424);
			Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663425);
			Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663426);
			Dropdown.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663427);
			Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663428);
			Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663429);
			Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663430);
			Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663431);
			Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663432);
			Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663433);
			Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663434);
			Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663435);
			Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663436);
			Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663437);
			Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663438);
			Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663439);
			Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663440);
			Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663441);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00009F70 File Offset: 0x00008170
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00009FB0 File Offset: 0x000081B0
		public unsafe RectTransform template
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109640, XrefRangeEnd = 109641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00009FF4 File Offset: 0x000081F4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000A034 File Offset: 0x00008234
		public unsafe Text captionText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109641, XrefRangeEnd = 109642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000A078 File Offset: 0x00008278
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public unsafe Image captionImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109642, XrefRangeEnd = 109643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000A0FC File Offset: 0x000082FC
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000A13C File Offset: 0x0000833C
		public unsafe Text itemText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109643, XrefRangeEnd = 109644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000A180 File Offset: 0x00008380
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public unsafe Image itemImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109644, XrefRangeEnd = 109645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000A204 File Offset: 0x00008404
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000A244 File Offset: 0x00008444
		public unsafe List<Dropdown.OptionData> options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109645, XrefRangeEnd = 109647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000A288 File Offset: 0x00008488
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000A2C8 File Offset: 0x000084C8
		public unsafe Dropdown.DropdownEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000A30C File Offset: 0x0000850C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000A348 File Offset: 0x00008548
		public unsafe float alphaFadeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000A388 File Offset: 0x00008588
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000A3C4 File Offset: 0x000085C4
		public unsafe int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109647, XrefRangeEnd = 109648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000A404 File Offset: 0x00008604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109648, XrefRangeEnd = 109649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(int input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000A444 File Offset: 0x00008644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109659, RefRangeEnd = 109662, XrefRangeStart = 109649, XrefRangeEnd = 109659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int value, bool sendCallback = true)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000A490 File Offset: 0x00008690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109662, XrefRangeEnd = 109680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000A4CC File Offset: 0x000086CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109680, XrefRangeEnd = 109693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000A508 File Offset: 0x00008708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109693, XrefRangeEnd = 109709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000A544 File Offset: 0x00008744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109709, XrefRangeEnd = 109715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A580 File Offset: 0x00008780
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 109739, RefRangeEnd = 109755, XrefRangeStart = 109715, XrefRangeEnd = 109739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A5B4 File Offset: 0x000087B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109755, XrefRangeEnd = 109760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Dropdown.OptionData> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A5F8 File Offset: 0x000087F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109760, XrefRangeEnd = 109772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000A63C File Offset: 0x0000883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109772, XrefRangeEnd = 109784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Sprite> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000A680 File Offset: 0x00008880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109784, XrefRangeEnd = 109789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000A6B4 File Offset: 0x000088B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109883, RefRangeEnd = 109884, XrefRangeStart = 109789, XrefRangeEnd = 109883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupTemplate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000A6E8 File Offset: 0x000088E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109888, RefRangeEnd = 109892, XrefRangeStart = 109884, XrefRangeEnd = 109888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A728 File Offset: 0x00008928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109892, XrefRangeEnd = 109893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A778 File Offset: 0x00008978
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A7C8 File Offset: 0x000089C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109893, XrefRangeEnd = 109894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000A818 File Offset: 0x00008A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110046, RefRangeEnd = 110048, XrefRangeStart = 109894, XrefRangeEnd = 110046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000A84C File Offset: 0x00008A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110048, XrefRangeEnd = 110112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110112, XrefRangeEnd = 110116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyBlocker(GameObject blocker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blocker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110116, XrefRangeEnd = 110122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateDropdownList(GameObject template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000A954 File Offset: 0x00008B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110122, XrefRangeEnd = 110126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyDropdownList(GameObject dropdownList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropdownList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110126, XrefRangeEnd = 110132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr3) : null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000AA00 File Offset: 0x00008C00
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(Dropdown.DropdownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000AA50 File Offset: 0x00008C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110168, RefRangeEnd = 110169, XrefRangeStart = 110132, XrefRangeEnd = 110168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr3) : null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110169, XrefRangeEnd = 110174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000AB20 File Offset: 0x00008D20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110193, RefRangeEnd = 110196, XrefRangeStart = 110174, XrefRangeEnd = 110193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000AB7C File Offset: 0x00008D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110196, XrefRangeEnd = 110204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000ABBC File Offset: 0x00008DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110222, RefRangeEnd = 110225, XrefRangeStart = 110204, XrefRangeEnd = 110222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110225, XrefRangeEnd = 110229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDestroyDropdownList(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000AC3C File Offset: 0x00008E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110244, RefRangeEnd = 110245, XrefRangeStart = 110229, XrefRangeEnd = 110244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImmediateDestroyDropdownList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000AC70 File Offset: 0x00008E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110257, RefRangeEnd = 110258, XrefRangeStart = 110245, XrefRangeEnd = 110257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectItem(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000242C File Offset: 0x0000062C
		public Dropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002435 File Offset: 0x00000635
		public unsafe RectTransform m_Template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002454 File Offset: 0x00000654
		public unsafe Text m_CaptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000AD14 File Offset: 0x00008F14
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002473 File Offset: 0x00000673
		public unsafe Image m_CaptionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000AD44 File Offset: 0x00008F44
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002492 File Offset: 0x00000692
		public unsafe Text m_ItemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000AD74 File Offset: 0x00008F74
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000024B1 File Offset: 0x000006B1
		public unsafe Image m_ItemImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000ADA4 File Offset: 0x00008FA4
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000024D0 File Offset: 0x000006D0
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000ADCC File Offset: 0x00008FCC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000024EB File Offset: 0x000006EB
		public unsafe Dropdown.OptionDataList m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.OptionDataList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000ADFC File Offset: 0x00008FFC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000250A File Offset: 0x0000070A
		public unsafe Dropdown.DropdownEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000AE2C File Offset: 0x0000902C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002529 File Offset: 0x00000729
		public unsafe float m_AlphaFadeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000AE54 File Offset: 0x00009054
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002544 File Offset: 0x00000744
		public unsafe GameObject m_Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000AE84 File Offset: 0x00009084
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002563 File Offset: 0x00000763
		public unsafe GameObject m_Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000AEB4 File Offset: 0x000090B4
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002582 File Offset: 0x00000782
		public unsafe List<Dropdown.DropdownItem> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dropdown.DropdownItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000AEE4 File Offset: 0x000090E4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000025A1 File Offset: 0x000007A1
		public unsafe TweenRunner<FloatTween> m_AlphaTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<FloatTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000AF14 File Offset: 0x00009114
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000025C0 File Offset: 0x000007C0
		public unsafe bool validTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_validTemplate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_validTemplate)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000AF3C File Offset: 0x0000913C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000025DB File Offset: 0x000007DB
		public unsafe static Dropdown.OptionData s_NoOptionData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dropdown.NativeFieldInfoPtr_s_NoOptionData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.OptionData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dropdown.NativeFieldInfoPtr_s_NoOptionData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_m_Template;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionText;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionImage;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemText;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemImage;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaFadeSpeed;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_m_Dropdown;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_m_Blocker;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaTweenRunner;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_validTemplate;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_s_NoOptionData;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_template_Public_get_RectTransform_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_captionText_Public_get_Text_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_captionImage_Public_get_Image_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_itemText_Public_get_Text_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_itemImage_Public_get_Image_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValue_Public_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_SetupTemplate_Private_Void_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0;

		// Token: 0x0200007A RID: 122
		public class DropdownItem : MonoBehaviour
		{
			// Token: 0x06000B89 RID: 2953 RVA: 0x00033338 File Offset: 0x00031538
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownItem()
			{
				Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "DropdownItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr);
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Text");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Image");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_RectTransform");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Toggle");
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664957);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664958);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664959);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664960);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664961);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664962);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664963);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664964);
				Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664965);
				Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664966);
				Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100664967);
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00033490 File Offset: 0x00031690
			// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000334D0 File Offset: 0x000316D0
			public unsafe Text text
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00033514 File Offset: 0x00031714
			// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00033554 File Offset: 0x00031754
			public unsafe Image image
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00033598 File Offset: 0x00031798
			// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000335D8 File Offset: 0x000317D8
			public unsafe RectTransform rectTransform
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0003361C File Offset: 0x0003181C
			// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0003365C File Offset: 0x0003185C
			public unsafe Toggle toggle
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x000336A0 File Offset: 0x000318A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109597, XrefRangeEnd = 109604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPointerEnter(PointerEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x000336F0 File Offset: 0x000318F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109604, XrefRangeEnd = 109612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnCancel(BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x00033740 File Offset: 0x00031940
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x0000630D File Offset: 0x0000450D
			public DropdownItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0003377C File Offset: 0x0003197C
			// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00006316 File Offset: 0x00004516
			public unsafe Text m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000337AC File Offset: 0x000319AC
			// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00006335 File Offset: 0x00004535
			public unsafe Image m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06000B9A RID: 2970 RVA: 0x000337DC File Offset: 0x000319DC
			// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00006354 File Offset: 0x00004554
			public unsafe RectTransform m_RectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0003380C File Offset: 0x00031A0C
			// (set) Token: 0x06000B9D RID: 2973 RVA: 0x00006373 File Offset: 0x00004573
			public unsafe Toggle m_Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008AF RID: 2223
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040008B0 RID: 2224
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x040008B1 RID: 2225
			private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

			// Token: 0x040008B2 RID: 2226
			private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

			// Token: 0x040008B3 RID: 2227
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_Text_0;

			// Token: 0x040008B4 RID: 2228
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_Text_0;

			// Token: 0x040008B5 RID: 2229
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

			// Token: 0x040008B6 RID: 2230
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

			// Token: 0x040008B7 RID: 2231
			private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

			// Token: 0x040008B8 RID: 2232
			private static readonly IntPtr NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0;

			// Token: 0x040008B9 RID: 2233
			private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0;

			// Token: 0x040008BA RID: 2234
			private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0;

			// Token: 0x040008BB RID: 2235
			private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

			// Token: 0x040008BC RID: 2236
			private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

			// Token: 0x040008BD RID: 2237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007B RID: 123
		[Serializable]
		public class OptionData : Object
		{
			// Token: 0x06000B9E RID: 2974 RVA: 0x0003383C File Offset: 0x00031A3C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr);
				Dropdown.OptionData.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, "m_Text");
				Dropdown.OptionData.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, "m_Image");
				Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664968);
				Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664969);
				Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664970);
				Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664971);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664972);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664973);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664974);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100664975);
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00033930 File Offset: 0x00031B30
			// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00033968 File Offset: 0x00031B68
			public unsafe string text
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000339AC File Offset: 0x00031BAC
			// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000339EC File Offset: 0x00031BEC
			public unsafe Sprite image
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x00033A30 File Offset: 0x00031C30
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00033A6C File Offset: 0x00031C6C
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x00033AB8 File Offset: 0x00031CB8
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x00033B04 File Offset: 0x00031D04
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text, Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x00006392 File Offset: 0x00004592
			public OptionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00033B64 File Offset: 0x00031D64
			// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0000639B File Offset: 0x0000459B
			public unsafe string m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00033B8C File Offset: 0x00031D8C
			// (set) Token: 0x06000BAB RID: 2987 RVA: 0x000063BA File Offset: 0x000045BA
			public unsafe Sprite m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008BE RID: 2238
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040008BF RID: 2239
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x040008C0 RID: 2240
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

			// Token: 0x040008C1 RID: 2241
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

			// Token: 0x040008C2 RID: 2242
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Sprite_0;

			// Token: 0x040008C3 RID: 2243
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0;

			// Token: 0x040008C4 RID: 2244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008C5 RID: 2245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x040008C6 RID: 2246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sprite_0;

			// Token: 0x040008C7 RID: 2247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0;
		}

		// Token: 0x0200007C RID: 124
		[Serializable]
		public class OptionDataList : Object
		{
			// Token: 0x06000BAC RID: 2988 RVA: 0x00033BBC File Offset: 0x00031DBC
			// Note: this type is marked as 'beforefieldinit'.
			static OptionDataList()
			{
				Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "OptionDataList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr);
				Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, "m_Options");
				Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100664976);
				Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100664977);
				Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100664978);
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00033C38 File Offset: 0x00031E38
			// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00033C78 File Offset: 0x00031E78
			public unsafe List<Dropdown.OptionData> options
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x00033CBC File Offset: 0x00031EBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109619, RefRangeEnd = 109620, XrefRangeStart = 109612, XrefRangeEnd = 109619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionDataList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x000063D9 File Offset: 0x000045D9
			public OptionDataList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00033CF8 File Offset: 0x00031EF8
			// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000063E2 File Offset: 0x000045E2
			public unsafe List<Dropdown.OptionData> m_Options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008C8 RID: 2248
			private static readonly IntPtr NativeFieldInfoPtr_m_Options;

			// Token: 0x040008C9 RID: 2249
			private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

			// Token: 0x040008CA RID: 2250
			private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

			// Token: 0x040008CB RID: 2251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007D RID: 125
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x06000BB3 RID: 2995 RVA: 0x00006401 File Offset: 0x00004601
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownEvent()
			{
				Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "DropdownEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr);
				Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr, 100664979);
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00033D28 File Offset: 0x00031F28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109623, RefRangeEnd = 109624, XrefRangeStart = 109620, XrefRangeEnd = 109623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x00006435 File Offset: 0x00004635
			public DropdownEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040008CC RID: 2252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("UnityEngine.UI.Dropdown+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Object
		{
			// Token: 0x06000BB6 RID: 2998 RVA: 0x00033D64 File Offset: 0x00031F64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr);
				Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr, "item");
				Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr, "<>4__this");
				Dropdown.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr, 100664980);
				Dropdown.__c__DisplayClass62_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr, 100664981);
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x00033DE0 File Offset: 0x00031FE0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x00033E1C File Offset: 0x0003201C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109624, XrefRangeEnd = 109631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Show_b__0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.__c__DisplayClass62_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x0000643E File Offset: 0x0000463E
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00033E5C File Offset: 0x0003205C
			// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00006447 File Offset: 0x00004647
			public unsafe Dropdown.DropdownItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00033E8C File Offset: 0x0003208C
			// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00006466 File Offset: 0x00004666
			public unsafe Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008CD RID: 2253
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x040008CE RID: 2254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008CF RID: 2255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008D0 RID: 2256
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("UnityEngine.UI.Dropdown+<DelayedDestroyDropdownList>d__74")]
		public sealed class _DelayedDestroyDropdownList_d__74 : Object
		{
			// Token: 0x06000BBE RID: 3006 RVA: 0x00033EBC File Offset: 0x000320BC
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDestroyDropdownList_d__74()
			{
				Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "<DelayedDestroyDropdownList>d__74");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, "<>1__state");
				Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, "<>2__current");
				Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, "delay");
				Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, "<>4__this");
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664982);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664983);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664984);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664985);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664986);
				Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr, 100664987);
			}

			// Token: 0x06000BBF RID: 3007 RVA: 0x00033FB0 File Offset: 0x000321B0
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDestroyDropdownList_d__74(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__74>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BC0 RID: 3008 RVA: 0x00033FF8 File Offset: 0x000321F8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BC1 RID: 3009 RVA: 0x0003402C File Offset: 0x0003222C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109631, XrefRangeEnd = 109635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00034068 File Offset: 0x00032268
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BC3 RID: 3011 RVA: 0x000340A8 File Offset: 0x000322A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109635, XrefRangeEnd = 109640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000340DC File Offset: 0x000322DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x00006485 File Offset: 0x00004685
			public _DelayedDestroyDropdownList_d__74(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0003411C File Offset: 0x0003231C
			// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0000648E File Offset: 0x0000468E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00034144 File Offset: 0x00032344
			// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000064A9 File Offset: 0x000046A9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00034174 File Offset: 0x00032374
			// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000064C8 File Offset: 0x000046C8
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0003419C File Offset: 0x0003239C
			// (set) Token: 0x06000BCD RID: 3021 RVA: 0x000064E3 File Offset: 0x000046E3
			public unsafe Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008D1 RID: 2257
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008D2 RID: 2258
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008D3 RID: 2259
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040008D4 RID: 2260
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008D5 RID: 2261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008D6 RID: 2262
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008D7 RID: 2263
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008D8 RID: 2264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008D9 RID: 2265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008DA RID: 2266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000080 RID: 128
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>
		{
			// Token: 0x040008DB RID: 2267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0, Il2CppClassPointerStore<Dropdown>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
