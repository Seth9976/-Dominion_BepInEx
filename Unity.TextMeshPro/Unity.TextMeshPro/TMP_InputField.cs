using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200003F RID: 63
	public class TMP_InputField : Selectable
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0001D79C File Offset: 0x0001B99C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_InputField()
		{
			Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_InputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr);
			TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SoftKeyboard");
			TMP_InputField.NativeFieldInfoPtr_kSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kSeparators");
			TMP_InputField.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RectTransform");
			TMP_InputField.NativeFieldInfoPtr_m_TextViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextViewport");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponentRectMask");
			TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextViewportRectMask");
			TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CachedViewportRect");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponent");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponentRectTransform");
			TMP_InputField.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Placeholder");
			TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_VerticalScrollbar");
			TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_VerticalScrollbarEventHandler");
			TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsDrivenByLayoutComponents");
			TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LayoutGroup");
			TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IScrollHandlerParent");
			TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ScrollPosition");
			TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ScrollSensitivity");
			TMP_InputField.NativeFieldInfoPtr_m_ContentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ContentType");
			TMP_InputField.NativeFieldInfoPtr_m_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_InputType");
			TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_AsteriskChar");
			TMP_InputField.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_KeyboardType");
			TMP_InputField.NativeFieldInfoPtr_m_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LineType");
			TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HideMobileInput");
			TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HideSoftKeyboard");
			TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CharacterValidation");
			TMP_InputField.NativeFieldInfoPtr_m_RegexValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RegexValue");
			TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_GlobalPointSize");
			TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CharacterLimit");
			TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnEndEdit");
			TMP_InputField.NativeFieldInfoPtr_m_OnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnSubmit");
			TMP_InputField.NativeFieldInfoPtr_m_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnSelect");
			TMP_InputField.NativeFieldInfoPtr_m_OnDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnDeselect");
			TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnTextSelection");
			TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnEndTextSelection");
			TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnValueChanged");
			TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnTouchScreenKeyboardStatusChanged");
			TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnValidateInput");
			TMP_InputField.NativeFieldInfoPtr_m_CaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretColor");
			TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CustomCaretColor");
			TMP_InputField.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SelectionColor");
			TMP_InputField.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Text");
			TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretBlinkRate");
			TMP_InputField.NativeFieldInfoPtr_m_CaretWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretWidth");
			TMP_InputField.NativeFieldInfoPtr_m_ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ReadOnly");
			TMP_InputField.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RichText");
			TMP_InputField.NativeFieldInfoPtr_m_StringPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_StringPosition");
			TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_StringSelectPosition");
			TMP_InputField.NativeFieldInfoPtr_m_CaretPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretPosition");
			TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretSelectPosition");
			TMP_InputField.NativeFieldInfoPtr_caretRectTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "caretRectTrans");
			TMP_InputField.NativeFieldInfoPtr_m_CursorVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CursorVerts");
			TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CachedInputRenderer");
			TMP_InputField.NativeFieldInfoPtr_m_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LastPosition");
			TMP_InputField.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Mesh");
			TMP_InputField.NativeFieldInfoPtr_m_AllowInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_AllowInput");
			TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ShouldActivateNextUpdate");
			TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_UpdateDrag");
			TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DragPositionOutOfBounds");
			TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kHScrollSpeed");
			TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kVScrollSpeed");
			TMP_InputField.NativeFieldInfoPtr_m_CaretVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretVisible");
			TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_BlinkCoroutine");
			TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_BlinkStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DragCoroutine");
			TMP_InputField.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OriginalText");
			TMP_InputField.NativeFieldInfoPtr_m_WasCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_WasCanceled");
			TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HasDoneFocusTransition");
			TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_WaitForSecondsRealtime");
			TMP_InputField.NativeFieldInfoPtr_m_PreventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreventCallback");
			TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TouchKeyboardAllowsInPlaceEditing");
			TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsTextComponentUpdateRequired");
			TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isLastKeyBackspace");
			TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PointerDownClickStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_KeyDownStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DoubleClickDelay");
			TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kEmailSpecialCharacters");
			TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsCompositionActive");
			TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ShouldUpdateIMEWindowPosition");
			TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreviousIMEInsertionLine");
			TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_GlobalFontAsset");
			TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnFocusSelectAll");
			TMP_InputField.NativeFieldInfoPtr_m_isSelectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isSelectAll");
			TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ResetOnDeActivation");
			TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SelectionStillActive");
			TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ReleaseSelection");
			TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreviouslySelectedObject");
			TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RestoreOriginalTextOnEscape");
			TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isRichTextEditingAllowed");
			TMP_InputField.NativeFieldInfoPtr_m_LineLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LineLimit");
			TMP_InputField.NativeFieldInfoPtr_m_InputValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_InputValidator");
			TMP_InputField.NativeFieldInfoPtr_m_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isSelected");
			TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsStringPositionDirty");
			TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsCaretPositionDirty");
			TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_forceRectTransformAdjustment");
			TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ProcessingEvent");
			TMP_InputField.NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663877);
			TMP_InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663878);
			TMP_InputField.NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663879);
			TMP_InputField.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663880);
			TMP_InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663881);
			TMP_InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663882);
			TMP_InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663883);
			TMP_InputField.NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663884);
			TMP_InputField.NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663885);
			TMP_InputField.NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663886);
			TMP_InputField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663887);
			TMP_InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663888);
			TMP_InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663889);
			TMP_InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663890);
			TMP_InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663891);
			TMP_InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663892);
			TMP_InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663893);
			TMP_InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663894);
			TMP_InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663895);
			TMP_InputField.NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663896);
			TMP_InputField.NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663897);
			TMP_InputField.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663898);
			TMP_InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663899);
			TMP_InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663900);
			TMP_InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663901);
			TMP_InputField.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663902);
			TMP_InputField.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663903);
			TMP_InputField.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663904);
			TMP_InputField.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663905);
			TMP_InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663906);
			TMP_InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663907);
			TMP_InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663908);
			TMP_InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663909);
			TMP_InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663910);
			TMP_InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663911);
			TMP_InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663912);
			TMP_InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663913);
			TMP_InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663914);
			TMP_InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663915);
			TMP_InputField.NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663916);
			TMP_InputField.NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663917);
			TMP_InputField.NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663918);
			TMP_InputField.NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663919);
			TMP_InputField.NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663920);
			TMP_InputField.NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663921);
			TMP_InputField.NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663922);
			TMP_InputField.NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663923);
			TMP_InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663924);
			TMP_InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663925);
			TMP_InputField.NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663926);
			TMP_InputField.NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663927);
			TMP_InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663928);
			TMP_InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663929);
			TMP_InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663930);
			TMP_InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663931);
			TMP_InputField.NativeMethodInfoPtr_get_pointSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663932);
			TMP_InputField.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663933);
			TMP_InputField.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663934);
			TMP_InputField.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663935);
			TMP_InputField.NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663936);
			TMP_InputField.NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663937);
			TMP_InputField.NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663938);
			TMP_InputField.NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663939);
			TMP_InputField.NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663940);
			TMP_InputField.NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663941);
			TMP_InputField.NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663942);
			TMP_InputField.NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663943);
			TMP_InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663944);
			TMP_InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663945);
			TMP_InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663946);
			TMP_InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663947);
			TMP_InputField.NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663948);
			TMP_InputField.NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663949);
			TMP_InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663950);
			TMP_InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663951);
			TMP_InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663952);
			TMP_InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663953);
			TMP_InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663954);
			TMP_InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663955);
			TMP_InputField.NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663956);
			TMP_InputField.NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663957);
			TMP_InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663958);
			TMP_InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663959);
			TMP_InputField.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663960);
			TMP_InputField.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663961);
			TMP_InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663962);
			TMP_InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663963);
			TMP_InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663964);
			TMP_InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663965);
			TMP_InputField.NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663966);
			TMP_InputField.NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663967);
			TMP_InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663968);
			TMP_InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663969);
			TMP_InputField.NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663970);
			TMP_InputField.NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663971);
			TMP_InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663972);
			TMP_InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663973);
			TMP_InputField.NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663974);
			TMP_InputField.NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663975);
			TMP_InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663976);
			TMP_InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663977);
			TMP_InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663978);
			TMP_InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663979);
			TMP_InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663980);
			TMP_InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663981);
			TMP_InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663982);
			TMP_InputField.NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663983);
			TMP_InputField.NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663984);
			TMP_InputField.NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663985);
			TMP_InputField.NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663986);
			TMP_InputField.NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663987);
			TMP_InputField.NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663988);
			TMP_InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663989);
			TMP_InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663990);
			TMP_InputField.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663991);
			TMP_InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663992);
			TMP_InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663993);
			TMP_InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663994);
			TMP_InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663995);
			TMP_InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663996);
			TMP_InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663997);
			TMP_InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663998);
			TMP_InputField.NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663999);
			TMP_InputField.NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664000);
			TMP_InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664001);
			TMP_InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664002);
			TMP_InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664003);
			TMP_InputField.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664004);
			TMP_InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664005);
			TMP_InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664006);
			TMP_InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664007);
			TMP_InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664008);
			TMP_InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664009);
			TMP_InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664010);
			TMP_InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664011);
			TMP_InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664012);
			TMP_InputField.NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664013);
			TMP_InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664014);
			TMP_InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664015);
			TMP_InputField.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664016);
			TMP_InputField.NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664017);
			TMP_InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664018);
			TMP_InputField.NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664019);
			TMP_InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664020);
			TMP_InputField.NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664021);
			TMP_InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664022);
			TMP_InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664023);
			TMP_InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664024);
			TMP_InputField.NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664025);
			TMP_InputField.NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664026);
			TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664027);
			TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664028);
			TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664029);
			TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664030);
			TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664031);
			TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664032);
			TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664033);
			TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664034);
			TMP_InputField.NativeMethodInfoPtr_Delete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664035);
			TMP_InputField.NativeMethodInfoPtr_DeleteKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664036);
			TMP_InputField.NativeMethodInfoPtr_Backspace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664037);
			TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664038);
			TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664039);
			TMP_InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664040);
			TMP_InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664041);
			TMP_InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664042);
			TMP_InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664043);
			TMP_InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664044);
			TMP_InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664045);
			TMP_InputField.NativeMethodInfoPtr_SendOnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664046);
			TMP_InputField.NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664047);
			TMP_InputField.NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664048);
			TMP_InputField.NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664049);
			TMP_InputField.NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664050);
			TMP_InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664051);
			TMP_InputField.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664052);
			TMP_InputField.NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664053);
			TMP_InputField.NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664054);
			TMP_InputField.NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664055);
			TMP_InputField.NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664056);
			TMP_InputField.NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664057);
			TMP_InputField.NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664058);
			TMP_InputField.NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664059);
			TMP_InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664060);
			TMP_InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664061);
			TMP_InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664062);
			TMP_InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664063);
			TMP_InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664064);
			TMP_InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664065);
			TMP_InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664066);
			TMP_InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664067);
			TMP_InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664068);
			TMP_InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664069);
			TMP_InputField.NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664070);
			TMP_InputField.NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664071);
			TMP_InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664072);
			TMP_InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664073);
			TMP_InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664074);
			TMP_InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664075);
			TMP_InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664076);
			TMP_InputField.NativeMethodInfoPtr_OnControlClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664077);
			TMP_InputField.NativeMethodInfoPtr_ReleaseSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664078);
			TMP_InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664079);
			TMP_InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664080);
			TMP_InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664081);
			TMP_InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664082);
			TMP_InputField.NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664083);
			TMP_InputField.NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664084);
			TMP_InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664085);
			TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664086);
			TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664087);
			TMP_InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664088);
			TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664089);
			TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664090);
			TMP_InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664091);
			TMP_InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664092);
			TMP_InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664093);
			TMP_InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664094);
			TMP_InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664095);
			TMP_InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664096);
			TMP_InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664097);
			TMP_InputField.NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664098);
			TMP_InputField.NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664099);
			TMP_InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664101);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
		public unsafe BaseInput inputSystem
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 141037, RefRangeEnd = 141045, XrefRangeStart = 141019, XrefRangeEnd = 141037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		public unsafe string compositionString
		{
			[CallerCount(88)]
			[CachedScanResults(RefRangeStart = 141053, RefRangeEnd = 141141, XrefRangeStart = 141045, XrefRangeEnd = 141053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001F130 File Offset: 0x0001D330
		public unsafe int compositionLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141141, XrefRangeEnd = 141142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001F16C File Offset: 0x0001D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141142, XrefRangeEnd = 141187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_InputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		public unsafe Mesh mesh
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 141195, RefRangeEnd = 141199, XrefRangeStart = 141187, XrefRangeEnd = 141195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0001F224 File Offset: 0x0001D424
		public unsafe bool shouldHideMobileInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141199, XrefRangeEnd = 141200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141200, XrefRangeEnd = 141202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001F264 File Offset: 0x0001D464
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0001F2A0 File Offset: 0x0001D4A0
		public unsafe bool shouldHideSoftKeyboard
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 141203, RefRangeEnd = 141205, XrefRangeStart = 141202, XrefRangeEnd = 141203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141205, XrefRangeEnd = 141212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141212, XrefRangeEnd = 141213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isKeyboardUsingEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001F31C File Offset: 0x0001D51C
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0001F354 File Offset: 0x0001D554
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 141214, RefRangeEnd = 141230, XrefRangeStart = 141213, XrefRangeEnd = 141214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001F398 File Offset: 0x0001D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141230, XrefRangeEnd = 141231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextWithoutNotify(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001F3DC File Offset: 0x0001D5DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141245, RefRangeEnd = 141249, XrefRangeStart = 141231, XrefRangeEnd = 141245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001F42C File Offset: 0x0001D62C
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001F468 File Offset: 0x0001D668
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		public unsafe float caretBlinkRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141249, XrefRangeEnd = 141253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0001F520 File Offset: 0x0001D720
		public unsafe int caretWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141253, XrefRangeEnd = 141260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001F560 File Offset: 0x0001D760
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0001F5A0 File Offset: 0x0001D7A0
		public unsafe RectTransform textViewport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141263, RefRangeEnd = 141264, XrefRangeStart = 141260, XrefRangeEnd = 141263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0001F624 File Offset: 0x0001D824
		public unsafe TMP_Text textComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141268, RefRangeEnd = 141269, XrefRangeStart = 141264, XrefRangeEnd = 141268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001F668 File Offset: 0x0001D868
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141272, RefRangeEnd = 141273, XrefRangeStart = 141269, XrefRangeEnd = 141272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0001F72C File Offset: 0x0001D92C
		public unsafe Scrollbar verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141273, XrefRangeEnd = 141302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001F770 File Offset: 0x0001D970
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public unsafe float scrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141302, XrefRangeEnd = 141309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001F7EC File Offset: 0x0001D9EC
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0001F828 File Offset: 0x0001DA28
		public unsafe Color caretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141309, XrefRangeEnd = 141314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001F868 File Offset: 0x0001DA68
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001F8A4 File Offset: 0x0001DAA4
		public unsafe bool customCaretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141314, XrefRangeEnd = 141318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001F920 File Offset: 0x0001DB20
		public unsafe Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141318, XrefRangeEnd = 141323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001F960 File Offset: 0x0001DB60
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
		public unsafe TMP_InputField.SubmitEvent onEndEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141323, XrefRangeEnd = 141326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x0001FA24 File Offset: 0x0001DC24
		public unsafe TMP_InputField.SubmitEvent onSubmit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141326, XrefRangeEnd = 141329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001FA68 File Offset: 0x0001DC68
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		public unsafe TMP_InputField.SelectionEvent onSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141329, XrefRangeEnd = 141332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		public unsafe TMP_InputField.SelectionEvent onDeselect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141332, XrefRangeEnd = 141335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001FB70 File Offset: 0x0001DD70
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		public unsafe TMP_InputField.TextSelectionEvent onTextSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141335, XrefRangeEnd = 141338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001FBF4 File Offset: 0x0001DDF4
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x0001FC34 File Offset: 0x0001DE34
		public unsafe TMP_InputField.TextSelectionEvent onEndTextSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141338, XrefRangeEnd = 141341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001FC78 File Offset: 0x0001DE78
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
		public unsafe TMP_InputField.OnChangeEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnChangeEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141341, XrefRangeEnd = 141344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		public unsafe TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TouchScreenKeyboardEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141344, XrefRangeEnd = 141347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001FD80 File Offset: 0x0001DF80
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		public unsafe TMP_InputField.OnValidateInput onValidateInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnValidateInput>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141347, XrefRangeEnd = 141350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001FE04 File Offset: 0x0001E004
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x0001FE40 File Offset: 0x0001E040
		public unsafe int characterLimit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 96663, RefRangeEnd = 96665, XrefRangeStart = 96663, XrefRangeEnd = 96665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141350, XrefRangeEnd = 141359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001FE80 File Offset: 0x0001E080
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0001FEBC File Offset: 0x0001E0BC
		public unsafe float pointSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_pointSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141359, XrefRangeEnd = 141377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public unsafe TMP_FontAsset fontAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141391, RefRangeEnd = 141392, XrefRangeStart = 141377, XrefRangeEnd = 141391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001FF80 File Offset: 0x0001E180
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		public unsafe bool onFocusSelectAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00020038 File Offset: 0x0001E238
		public unsafe bool resetOnDeActivation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00020078 File Offset: 0x0001E278
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x000200B4 File Offset: 0x0001E2B4
		public unsafe bool restoreOriginalTextOnEscape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000200F4 File Offset: 0x0001E2F4
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00020130 File Offset: 0x0001E330
		public unsafe bool isRichTextEditingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00020170 File Offset: 0x0001E370
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x000201AC File Offset: 0x0001E3AC
		public unsafe TMP_InputField.ContentType contentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 141404, RefRangeEnd = 141412, XrefRangeStart = 141392, XrefRangeEnd = 141404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000201EC File Offset: 0x0001E3EC
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00020228 File Offset: 0x0001E428
		public unsafe TMP_InputField.LineType lineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141412, XrefRangeEnd = 141421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000202A4 File Offset: 0x0001E4A4
		public unsafe int lineLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141421, XrefRangeEnd = 141424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000202E4 File Offset: 0x0001E4E4
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00020320 File Offset: 0x0001E520
		public unsafe TMP_InputField.InputType inputType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141424, XrefRangeEnd = 141428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00020360 File Offset: 0x0001E560
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0002039C File Offset: 0x0001E59C
		public unsafe TouchScreenKeyboardType keyboardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141428, XrefRangeEnd = 141432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000203DC File Offset: 0x0001E5DC
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00020418 File Offset: 0x0001E618
		public unsafe TMP_InputField.CharacterValidation characterValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141432, XrefRangeEnd = 141436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00020458 File Offset: 0x0001E658
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00020498 File Offset: 0x0001E698
		public unsafe TMP_InputValidator inputValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputValidator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141436, XrefRangeEnd = 141440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000204DC File Offset: 0x0001E6DC
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00020518 File Offset: 0x0001E718
		public unsafe bool readOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00020558 File Offset: 0x0001E758
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00020594 File Offset: 0x0001E794
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141440, XrefRangeEnd = 141445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000205D4 File Offset: 0x0001E7D4
		public unsafe bool multiLine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 141445, RefRangeEnd = 141447, XrefRangeStart = 141445, XrefRangeEnd = 141445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00020610 File Offset: 0x0001E810
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0002064C File Offset: 0x0001E84C
		public unsafe char asteriskChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141447, XrefRangeEnd = 141451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002068C File Offset: 0x0001E88C
		public unsafe bool wasCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000206C8 File Offset: 0x0001E8C8
		[CallerCount(0)]
		public unsafe void ClampStringPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00020708 File Offset: 0x0001E908
		[CallerCount(0)]
		public unsafe void ClampCaretPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00020748 File Offset: 0x0001E948
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00020784 File Offset: 0x0001E984
		public unsafe int caretPositionInternal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 141452, RefRangeEnd = 141463, XrefRangeStart = 141451, XrefRangeEnd = 141452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 141463, RefRangeEnd = 141465, XrefRangeStart = 141463, XrefRangeEnd = 141463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000207C4 File Offset: 0x0001E9C4
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00020800 File Offset: 0x0001EA00
		public unsafe int stringPositionInternal
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 141466, RefRangeEnd = 141471, XrefRangeStart = 141465, XrefRangeEnd = 141466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 141471, RefRangeEnd = 141474, XrefRangeStart = 141471, XrefRangeEnd = 141471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00020840 File Offset: 0x0001EA40
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0002087C File Offset: 0x0001EA7C
		public unsafe int caretSelectPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141474, XrefRangeEnd = 141475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 141475, RefRangeEnd = 141477, XrefRangeStart = 141475, XrefRangeEnd = 141475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000208BC File Offset: 0x0001EABC
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000208F8 File Offset: 0x0001EAF8
		public unsafe int stringSelectPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141477, XrefRangeEnd = 141478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 141478, RefRangeEnd = 141482, XrefRangeStart = 141478, XrefRangeEnd = 141478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00020938 File Offset: 0x0001EB38
		public new unsafe bool hasSelection
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 141485, RefRangeEnd = 141496, XrefRangeStart = 141482, XrefRangeEnd = 141485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00020974 File Offset: 0x0001EB74
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000209B0 File Offset: 0x0001EBB0
		public unsafe int caretPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141496, XrefRangeEnd = 141499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000209F0 File Offset: 0x0001EBF0
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00020A2C File Offset: 0x0001EC2C
		public unsafe int selectionAnchorPosition
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 141452, RefRangeEnd = 141463, XrefRangeStart = 141452, XrefRangeEnd = 141463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141499, XrefRangeEnd = 141500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00020A6C File Offset: 0x0001EC6C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		public unsafe int selectionFocusPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141500, XrefRangeEnd = 141501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00020B24 File Offset: 0x0001ED24
		public unsafe int stringPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141501, XrefRangeEnd = 141504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00020B64 File Offset: 0x0001ED64
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		public unsafe int selectionStringAnchorPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 141466, RefRangeEnd = 141471, XrefRangeStart = 141466, XrefRangeEnd = 141471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141504, XrefRangeEnd = 141505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00020C1C File Offset: 0x0001EE1C
		public unsafe int selectionStringFocusPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141505, XrefRangeEnd = 141506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00020C5C File Offset: 0x0001EE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141506, XrefRangeEnd = 141643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00020C98 File Offset: 0x0001EE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141643, XrefRangeEnd = 141706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00020CD4 File Offset: 0x0001EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141706, XrefRangeEnd = 141730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00020D18 File Offset: 0x0001EF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141730, XrefRangeEnd = 141734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaretBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00020D58 File Offset: 0x0001EF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141736, RefRangeEnd = 141737, XrefRangeStart = 141734, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00020D8C File Offset: 0x0001EF8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141737, RefRangeEnd = 141740, XrefRangeStart = 141737, XrefRangeEnd = 141737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141741, RefRangeEnd = 141742, XrefRangeStart = 141740, XrefRangeEnd = 141741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141743, RefRangeEnd = 141744, XrefRangeStart = 141742, XrefRangeEnd = 141743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00020E28 File Offset: 0x0001F028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141744, XrefRangeEnd = 141759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00020E68 File Offset: 0x0001F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141759, XrefRangeEnd = 141769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextStart(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141787, RefRangeEnd = 141788, XrefRangeStart = 141769, XrefRangeEnd = 141787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToEndOfLine(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141806, RefRangeEnd = 141807, XrefRangeStart = 141788, XrefRangeEnd = 141806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToStartOfLine(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00020F40 File Offset: 0x0001F140
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00020F6C File Offset: 0x0001F16C
		public unsafe static string clipboard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 141812, RefRangeEnd = 141821, XrefRangeStart = 141807, XrefRangeEnd = 141812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InPlaceEditing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141821, XrefRangeEnd = 141840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStringPositionFromKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00021014 File Offset: 0x0001F214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141840, XrefRangeEnd = 141855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00021050 File Offset: 0x0001F250
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141861, RefRangeEnd = 141865, XrefRangeStart = 141855, XrefRangeEnd = 141861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000210A0 File Offset: 0x0001F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141865, XrefRangeEnd = 141866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141866, XrefRangeEnd = 141896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00021140 File Offset: 0x0001F340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141896, XrefRangeEnd = 141900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00021190 File Offset: 0x0001F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141900, XrefRangeEnd = 141901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000211E0 File Offset: 0x0001F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141901, XrefRangeEnd = 141912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00021230 File Offset: 0x0001F430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141952, RefRangeEnd = 141954, XrefRangeStart = 141912, XrefRangeEnd = 141952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_InputField.EditState KeyPressed(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00021280 File Offset: 0x0001F480
		[CallerCount(0)]
		public unsafe virtual bool IsValidChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000212D4 File Offset: 0x0001F4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141954, XrefRangeEnd = 141955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00021318 File Offset: 0x0001F518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141955, XrefRangeEnd = 141973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00021368 File Offset: 0x0001F568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141973, XrefRangeEnd = 141984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000213B8 File Offset: 0x0001F5B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141989, RefRangeEnd = 141992, XrefRangeStart = 141984, XrefRangeEnd = 141989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScrollPositionRelativeToViewport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000213F4 File Offset: 0x0001F5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141999, RefRangeEnd = 142000, XrefRangeStart = 141992, XrefRangeEnd = 141999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSelectedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002142C File Offset: 0x0001F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142000, XrefRangeEnd = 142008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNextWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00021468 File Offset: 0x0001F668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142018, RefRangeEnd = 142020, XrefRangeStart = 142008, XrefRangeEnd = 142018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRight(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000214B4 File Offset: 0x0001F6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142020, XrefRangeEnd = 142030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPrevWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000214F0 File Offset: 0x0001F6F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142040, RefRangeEnd = 142042, XrefRangeStart = 142030, XrefRangeEnd = 142040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLeft(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002153C File Offset: 0x0001F73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142044, RefRangeEnd = 142045, XrefRangeStart = 142042, XrefRangeEnd = 142044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00021594 File Offset: 0x0001F794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142047, RefRangeEnd = 142048, XrefRangeStart = 142045, XrefRangeEnd = 142047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000215EC File Offset: 0x0001F7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142052, RefRangeEnd = 142053, XrefRangeStart = 142048, XrefRangeEnd = 142052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00021644 File Offset: 0x0001F844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142058, RefRangeEnd = 142059, XrefRangeStart = 142053, XrefRangeEnd = 142058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002169C File Offset: 0x0001F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142059, XrefRangeEnd = 142060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000216DC File Offset: 0x0001F8DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142075, RefRangeEnd = 142078, XrefRangeStart = 142060, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00021728 File Offset: 0x0001F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142078, XrefRangeEnd = 142079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00021768 File Offset: 0x0001F968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142094, RefRangeEnd = 142097, XrefRangeStart = 142079, XrefRangeEnd = 142094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000217B4 File Offset: 0x0001F9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142097, XrefRangeEnd = 142098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000217F4 File Offset: 0x0001F9F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142126, RefRangeEnd = 142128, XrefRangeStart = 142098, XrefRangeEnd = 142126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageUp(bool shift, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00021840 File Offset: 0x0001FA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142128, XrefRangeEnd = 142129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00021880 File Offset: 0x0001FA80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142157, RefRangeEnd = 142159, XrefRangeStart = 142129, XrefRangeEnd = 142157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageDown(bool shift, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000218CC File Offset: 0x0001FACC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 142160, RefRangeEnd = 142165, XrefRangeStart = 142159, XrefRangeEnd = 142160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Delete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00021900 File Offset: 0x0001FB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142193, RefRangeEnd = 142194, XrefRangeStart = 142165, XrefRangeEnd = 142193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_DeleteKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00021934 File Offset: 0x0001FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142194, XrefRangeEnd = 142232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Backspace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00021968 File Offset: 0x0001FB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142232, XrefRangeEnd = 142234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000219B8 File Offset: 0x0001FBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142234, XrefRangeEnd = 142251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(char input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00021A04 File Offset: 0x0001FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142251, XrefRangeEnd = 142263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00021A44 File Offset: 0x0001FC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142265, RefRangeEnd = 142268, XrefRangeStart = 142263, XrefRangeEnd = 142265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTouchKeyboardFromEditChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00021A78 File Offset: 0x0001FC78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 142272, RefRangeEnd = 142276, XrefRangeStart = 142268, XrefRangeEnd = 142272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChangedAndUpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00021AAC File Offset: 0x0001FCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142279, RefRangeEnd = 142280, XrefRangeStart = 142276, XrefRangeEnd = 142279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142280, XrefRangeEnd = 142283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00021B14 File Offset: 0x0001FD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142286, RefRangeEnd = 142287, XrefRangeStart = 142283, XrefRangeEnd = 142286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00021B48 File Offset: 0x0001FD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142287, XrefRangeEnd = 142290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00021B7C File Offset: 0x0001FD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142290, XrefRangeEnd = 142293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnFocusLost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142293, XrefRangeEnd = 142299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnTextSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142305, RefRangeEnd = 142307, XrefRangeStart = 142299, XrefRangeEnd = 142305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndTextSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00021C18 File Offset: 0x0001FE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142307, XrefRangeEnd = 142311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTouchScreenKeyboardStatusChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00021C4C File Offset: 0x0001FE4C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 142367, RefRangeEnd = 142387, XrefRangeStart = 142311, XrefRangeEnd = 142367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00021C80 File Offset: 0x0001FE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142387, XrefRangeEnd = 142396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142396, XrefRangeEnd = 142397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollbarValueChange(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaskRegions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00021D28 File Offset: 0x0001FF28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142413, RefRangeEnd = 142415, XrefRangeStart = 142397, XrefRangeEnd = 142413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00021D68 File Offset: 0x0001FF68
		[CallerCount(0)]
		public unsafe int GetCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00021DB4 File Offset: 0x0001FFB4
		[CallerCount(0)]
		public unsafe int GetMinCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00021E00 File Offset: 0x00020000
		[CallerCount(0)]
		public unsafe int GetMaxCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00021E4C File Offset: 0x0002004C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 142416, RefRangeEnd = 142426, XrefRangeStart = 142415, XrefRangeEnd = 142416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStringIndexFromCaretPosition(int caretPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caretPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00021E98 File Offset: 0x00020098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142426, XrefRangeEnd = 142427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLabelUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00021ECC File Offset: 0x000200CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142431, RefRangeEnd = 142433, XrefRangeStart = 142427, XrefRangeEnd = 142431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGeometryAsDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00021F00 File Offset: 0x00020100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142433, XrefRangeEnd = 142442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00021F4C File Offset: 0x0002014C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00021F88 File Offset: 0x00020188
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00021FC4 File Offset: 0x000201C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142442, XrefRangeEnd = 142451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00021FF8 File Offset: 0x000201F8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 142509, RefRangeEnd = 142518, XrefRangeStart = 142451, XrefRangeEnd = 142509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPositioningIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002202C File Offset: 0x0002022C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142556, RefRangeEnd = 142558, XrefRangeStart = 142518, XrefRangeEnd = 142556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFillVBO(Mesh vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00022070 File Offset: 0x00020270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142622, RefRangeEnd = 142623, XrefRangeStart = 142558, XrefRangeEnd = 142622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000220C0 File Offset: 0x000202C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142623, XrefRangeEnd = 142634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCursorVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000220F4 File Offset: 0x000202F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142663, RefRangeEnd = 142664, XrefRangeStart = 142634, XrefRangeEnd = 142663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00022144 File Offset: 0x00020344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142711, RefRangeEnd = 142713, XrefRangeStart = 142664, XrefRangeEnd = 142711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCharVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000221A0 File Offset: 0x000203A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142730, RefRangeEnd = 142732, XrefRangeStart = 142713, XrefRangeEnd = 142730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char Validate(string text, int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0002220C File Offset: 0x0002040C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 142742, RefRangeEnd = 142747, XrefRangeStart = 142732, XrefRangeEnd = 142742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00022240 File Offset: 0x00020440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142780, RefRangeEnd = 142781, XrefRangeStart = 142747, XrefRangeEnd = 142780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputFieldInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00022274 File Offset: 0x00020474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142781, XrefRangeEnd = 142786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000222C4 File Offset: 0x000204C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142786, XrefRangeEnd = 142787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00022314 File Offset: 0x00020514
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnControlClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00022348 File Offset: 0x00020548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142795, RefRangeEnd = 142796, XrefRangeStart = 142787, XrefRangeEnd = 142795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ReleaseSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002237C File Offset: 0x0002057C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142820, RefRangeEnd = 142823, XrefRangeStart = 142796, XrefRangeEnd = 142820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateInputField(bool clearSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearSelection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000223BC File Offset: 0x000205BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142823, XrefRangeEnd = 142828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0002240C File Offset: 0x0002060C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142828, XrefRangeEnd = 142831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0002245C File Offset: 0x0002065C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142831, XrefRangeEnd = 142840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00022490 File Offset: 0x00020690
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 142845, RefRangeEnd = 142857, XrefRangeStart = 142840, XrefRangeEnd = 142845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextComponentWrapMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000224C4 File Offset: 0x000206C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142857, XrefRangeEnd = 142862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextComponentRichTextMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000224F8 File Offset: 0x000206F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142862, XrefRangeEnd = 142864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustomIfContentTypeIsNot([Optional] Il2CppStructArray<TMP_InputField.ContentType> allowedContentTypes)
		{
			if (allowedContentTypes == null)
			{
				allowedContentTypes = new Il2CppStructArray<TMP_InputField.ContentType>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allowedContentTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00022548 File Offset: 0x00020748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142864, XrefRangeEnd = 142865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002257C File Offset: 0x0002077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characterValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000225BC File Offset: 0x000207BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142865, XrefRangeEnd = 142867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00022614 File Offset: 0x00020814
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00022650 File Offset: 0x00020850
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0002268C File Offset: 0x0002088C
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000226D4 File Offset: 0x000208D4
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142867, XrefRangeEnd = 142880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0002271C File Offset: 0x0002091C
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00022764 File Offset: 0x00020964
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000227AC File Offset: 0x000209AC
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142880, XrefRangeEnd = 142893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000227F4 File Offset: 0x000209F4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002283C File Offset: 0x00020A3C
		public unsafe virtual int layoutPriority
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00022884 File Offset: 0x00020A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142893, XrefRangeEnd = 142904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalPointSize(float pointSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000228C4 File Offset: 0x00020AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142904, XrefRangeEnd = 142915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00022908 File Offset: 0x00020B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004F24 File Offset: 0x00003124
		public void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
			this.SetToCustomIfContentTypeIsNot(new Il2CppStructArray<TMP_InputField.ContentType>(allowedContentTypes));
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00004F32 File Offset: 0x00003132
		public TMP_InputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00022948 File Offset: 0x00020B48
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00004F3B File Offset: 0x0000313B
		public unsafe TouchScreenKeyboard m_SoftKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00022978 File Offset: 0x00020B78
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00004F5A File Offset: 0x0000315A
		public unsafe static Il2CppStructArray<char> kSeparators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kSeparators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kSeparators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000229A0 File Offset: 0x00020BA0
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00004F6C File Offset: 0x0000316C
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000229D0 File Offset: 0x00020BD0
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00004F8B File Offset: 0x0000318B
		public unsafe RectTransform m_TextViewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00022A00 File Offset: 0x00020C00
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00004FAA File Offset: 0x000031AA
		public unsafe RectMask2D m_TextComponentRectMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00022A30 File Offset: 0x00020C30
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00004FC9 File Offset: 0x000031C9
		public unsafe RectMask2D m_TextViewportRectMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00022A60 File Offset: 0x00020C60
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00004FE8 File Offset: 0x000031E8
		public unsafe Rect m_CachedViewportRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00022A88 File Offset: 0x00020C88
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00005003 File Offset: 0x00003203
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00022AB8 File Offset: 0x00020CB8
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00005022 File Offset: 0x00003222
		public unsafe RectTransform m_TextComponentRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00022AE8 File Offset: 0x00020CE8
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00005041 File Offset: 0x00003241
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00022B18 File Offset: 0x00020D18
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00005060 File Offset: 0x00003260
		public unsafe Scrollbar m_VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00022B48 File Offset: 0x00020D48
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000507F File Offset: 0x0000327F
		public unsafe TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ScrollbarEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00022B78 File Offset: 0x00020D78
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000509E File Offset: 0x0000329E
		public unsafe bool m_IsDrivenByLayoutComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00022BA0 File Offset: 0x00020DA0
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x000050B9 File Offset: 0x000032B9
		public unsafe LayoutGroup m_LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000050D8 File Offset: 0x000032D8
		public unsafe IScrollHandler m_IScrollHandlerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScrollHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00022C00 File Offset: 0x00020E00
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000050F7 File Offset: 0x000032F7
		public unsafe float m_ScrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00022C28 File Offset: 0x00020E28
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00005112 File Offset: 0x00003312
		public unsafe float m_ScrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00022C50 File Offset: 0x00020E50
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0000512D File Offset: 0x0000332D
		public unsafe TMP_InputField.ContentType m_ContentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ContentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ContentType)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00022C78 File Offset: 0x00020E78
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00005148 File Offset: 0x00003348
		public unsafe TMP_InputField.InputType m_InputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputType)) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00022CA0 File Offset: 0x00020EA0
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005163 File Offset: 0x00003363
		public unsafe char m_AsteriskChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00022CC8 File Offset: 0x00020EC8
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0000517E File Offset: 0x0000337E
		public unsafe TouchScreenKeyboardType m_KeyboardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyboardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyboardType)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00022CF0 File Offset: 0x00020EF0
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00005199 File Offset: 0x00003399
		public unsafe TMP_InputField.LineType m_LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineType)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00022D18 File Offset: 0x00020F18
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x000051B4 File Offset: 0x000033B4
		public unsafe bool m_HideMobileInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00022D40 File Offset: 0x00020F40
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000051CF File Offset: 0x000033CF
		public unsafe bool m_HideSoftKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00022D68 File Offset: 0x00020F68
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000051EA File Offset: 0x000033EA
		public unsafe TMP_InputField.CharacterValidation m_CharacterValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00022D90 File Offset: 0x00020F90
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00005205 File Offset: 0x00003405
		public unsafe string m_RegexValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RegexValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RegexValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00022DB8 File Offset: 0x00020FB8
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005224 File Offset: 0x00003424
		public unsafe float m_GlobalPointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize)) = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00022DE0 File Offset: 0x00020FE0
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000523F File Offset: 0x0000343F
		public unsafe int m_CharacterLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00022E08 File Offset: 0x00021008
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000525A File Offset: 0x0000345A
		public unsafe TMP_InputField.SubmitEvent m_OnEndEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00022E38 File Offset: 0x00021038
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00005279 File Offset: 0x00003479
		public unsafe TMP_InputField.SubmitEvent m_OnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00022E68 File Offset: 0x00021068
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00005298 File Offset: 0x00003498
		public unsafe TMP_InputField.SelectionEvent m_OnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00022E98 File Offset: 0x00021098
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000052B7 File Offset: 0x000034B7
		public unsafe TMP_InputField.SelectionEvent m_OnDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00022EC8 File Offset: 0x000210C8
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000052D6 File Offset: 0x000034D6
		public unsafe TMP_InputField.TextSelectionEvent m_OnTextSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00022EF8 File Offset: 0x000210F8
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000052F5 File Offset: 0x000034F5
		public unsafe TMP_InputField.TextSelectionEvent m_OnEndTextSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00022F28 File Offset: 0x00021128
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00005314 File Offset: 0x00003514
		public unsafe TMP_InputField.OnChangeEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00022F58 File Offset: 0x00021158
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00005333 File Offset: 0x00003533
		public unsafe TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TouchScreenKeyboardEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00022F88 File Offset: 0x00021188
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00005352 File Offset: 0x00003552
		public unsafe TMP_InputField.OnValidateInput m_OnValidateInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnValidateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00022FB8 File Offset: 0x000211B8
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00005371 File Offset: 0x00003571
		public unsafe Color m_CaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretColor)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00022FE0 File Offset: 0x000211E0
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0000538C File Offset: 0x0000358C
		public unsafe bool m_CustomCaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00023008 File Offset: 0x00021208
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x000053A7 File Offset: 0x000035A7
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00023030 File Offset: 0x00021230
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x000053C2 File Offset: 0x000035C2
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00023058 File Offset: 0x00021258
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000053E1 File Offset: 0x000035E1
		public unsafe float m_CaretBlinkRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00023080 File Offset: 0x00021280
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x000053FC File Offset: 0x000035FC
		public unsafe int m_CaretWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretWidth)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000230A8 File Offset: 0x000212A8
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00005417 File Offset: 0x00003617
		public unsafe bool m_ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReadOnly)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000230D0 File Offset: 0x000212D0
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00005432 File Offset: 0x00003632
		public unsafe bool m_RichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RichText)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000230F8 File Offset: 0x000212F8
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0000544D File Offset: 0x0000364D
		public unsafe int m_StringPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringPosition)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00023120 File Offset: 0x00021320
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00005468 File Offset: 0x00003668
		public unsafe int m_StringSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00023148 File Offset: 0x00021348
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00005483 File Offset: 0x00003683
		public unsafe int m_CaretPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretPosition)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00023170 File Offset: 0x00021370
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0000549E File Offset: 0x0000369E
		public unsafe int m_CaretSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00023198 File Offset: 0x00021398
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000054B9 File Offset: 0x000036B9
		public unsafe RectTransform caretRectTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_caretRectTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_caretRectTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000231C8 File Offset: 0x000213C8
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000054D8 File Offset: 0x000036D8
		public unsafe Il2CppStructArray<UIVertex> m_CursorVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CursorVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CursorVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000231F8 File Offset: 0x000213F8
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x000054F7 File Offset: 0x000036F7
		public unsafe CanvasRenderer m_CachedInputRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00023228 File Offset: 0x00021428
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005516 File Offset: 0x00003716
		public unsafe Vector2 m_LastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LastPosition)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00023250 File Offset: 0x00021450
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00005531 File Offset: 0x00003731
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00023280 File Offset: 0x00021480
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00005550 File Offset: 0x00003750
		public unsafe bool m_AllowInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AllowInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AllowInput)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000232A8 File Offset: 0x000214A8
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0000556B File Offset: 0x0000376B
		public unsafe bool m_ShouldActivateNextUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000232D0 File Offset: 0x000214D0
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00005586 File Offset: 0x00003786
		public unsafe bool m_UpdateDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000232F8 File Offset: 0x000214F8
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000055A1 File Offset: 0x000037A1
		public unsafe bool m_DragPositionOutOfBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00023320 File Offset: 0x00021520
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000055BC File Offset: 0x000037BC
		public unsafe static float kHScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002333C File Offset: 0x0002153C
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x000055CA File Offset: 0x000037CA
		public unsafe static float kVScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00023358 File Offset: 0x00021558
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x000055D8 File Offset: 0x000037D8
		public unsafe bool m_CaretVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretVisible)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00023380 File Offset: 0x00021580
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x000055F3 File Offset: 0x000037F3
		public unsafe Coroutine m_BlinkCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000233B0 File Offset: 0x000215B0
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00005612 File Offset: 0x00003812
		public unsafe float m_BlinkStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000233D8 File Offset: 0x000215D8
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0000562D File Offset: 0x0000382D
		public unsafe Coroutine m_DragCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00023408 File Offset: 0x00021608
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0000564C File Offset: 0x0000384C
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00023430 File Offset: 0x00021630
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0000566B File Offset: 0x0000386B
		public unsafe bool m_WasCanceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WasCanceled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WasCanceled)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00023458 File Offset: 0x00021658
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00005686 File Offset: 0x00003886
		public unsafe bool m_HasDoneFocusTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00023480 File Offset: 0x00021680
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x000056A1 File Offset: 0x000038A1
		public unsafe WaitForSecondsRealtime m_WaitForSecondsRealtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x000234B0 File Offset: 0x000216B0
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x000056C0 File Offset: 0x000038C0
		public unsafe bool m_PreventCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreventCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreventCallback)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000234D8 File Offset: 0x000216D8
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000056DB File Offset: 0x000038DB
		public unsafe bool m_TouchKeyboardAllowsInPlaceEditing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00023500 File Offset: 0x00021700
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000056F6 File Offset: 0x000038F6
		public unsafe bool m_IsTextComponentUpdateRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00023528 File Offset: 0x00021728
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00005711 File Offset: 0x00003911
		public unsafe bool m_isLastKeyBackspace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00023550 File Offset: 0x00021750
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0000572C File Offset: 0x0000392C
		public unsafe float m_PointerDownClickStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00023578 File Offset: 0x00021778
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00005747 File Offset: 0x00003947
		public unsafe float m_KeyDownStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000235A0 File Offset: 0x000217A0
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005762 File Offset: 0x00003962
		public unsafe float m_DoubleClickDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000235C8 File Offset: 0x000217C8
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0000577D File Offset: 0x0000397D
		public unsafe static string kEmailSpecialCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000235E8 File Offset: 0x000217E8
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0000578F File Offset: 0x0000398F
		public unsafe bool m_IsCompositionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00023610 File Offset: 0x00021810
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000057AA File Offset: 0x000039AA
		public unsafe bool m_ShouldUpdateIMEWindowPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00023638 File Offset: 0x00021838
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x000057C5 File Offset: 0x000039C5
		public unsafe int m_PreviousIMEInsertionLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00023660 File Offset: 0x00021860
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x000057E0 File Offset: 0x000039E0
		public unsafe TMP_FontAsset m_GlobalFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00023690 File Offset: 0x00021890
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x000057FF File Offset: 0x000039FF
		public unsafe bool m_OnFocusSelectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000236B8 File Offset: 0x000218B8
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0000581A File Offset: 0x00003A1A
		public unsafe bool m_isSelectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelectAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelectAll)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000236E0 File Offset: 0x000218E0
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00005835 File Offset: 0x00003A35
		public unsafe bool m_ResetOnDeActivation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00023708 File Offset: 0x00021908
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00005850 File Offset: 0x00003A50
		public unsafe bool m_SelectionStillActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00023730 File Offset: 0x00021930
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0000586B File Offset: 0x00003A6B
		public unsafe bool m_ReleaseSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00023758 File Offset: 0x00021958
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00005886 File Offset: 0x00003A86
		public unsafe GameObject m_PreviouslySelectedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00023788 File Offset: 0x00021988
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x000058A5 File Offset: 0x00003AA5
		public unsafe bool m_RestoreOriginalTextOnEscape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape)) = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000237B0 File Offset: 0x000219B0
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x000058C0 File Offset: 0x00003AC0
		public unsafe bool m_isRichTextEditingAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000237D8 File Offset: 0x000219D8
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x000058DB File Offset: 0x00003ADB
		public unsafe int m_LineLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineLimit)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00023800 File Offset: 0x00021A00
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x000058F6 File Offset: 0x00003AF6
		public unsafe TMP_InputValidator m_InputValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00023830 File Offset: 0x00021A30
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00005915 File Offset: 0x00003B15
		public unsafe bool m_isSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelected)) = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00023858 File Offset: 0x00021A58
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00005930 File Offset: 0x00003B30
		public unsafe bool m_IsStringPositionDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty)) = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00023880 File Offset: 0x00021A80
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0000594B File Offset: 0x00003B4B
		public unsafe bool m_IsCaretPositionDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000238A8 File Offset: 0x00021AA8
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00005966 File Offset: 0x00003B66
		public unsafe bool m_forceRectTransformAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000238D0 File Offset: 0x00021AD0
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00005981 File Offset: 0x00003B81
		public unsafe Event m_ProcessingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_m_SoftKeyboard;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_kSeparators;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_m_TextViewport;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponentRectMask;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_m_TextViewportRectMask;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedViewportRect;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponentRectTransform;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbar;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarEventHandler;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenByLayoutComponents;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutGroup;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_m_IScrollHandlerParent;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollPosition;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollSensitivity;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentType;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_m_InputType;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_m_AsteriskChar;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_m_LineType;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_HideSoftKeyboard;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterValidation;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_m_RegexValue;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalPointSize;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLimit;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_OnEndEdit;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubmit;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSelect;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeselect;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_m_OnTextSelection;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_m_OnEndTextSelection;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValidateInput;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretColor;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomCaretColor;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretBlinkRate;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretWidth;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnly;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_m_RichText;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_m_StringPosition;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_m_StringSelectPosition;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretPosition;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretSelectPosition;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_caretRectTrans;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorVerts;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInputRenderer;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPosition;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowInput;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateNextUpdate;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateDrag;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_m_DragPositionOutOfBounds;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_kHScrollSpeed;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_kVScrollSpeed;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretVisible;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkCoroutine;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkStartTime;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr_m_DragCoroutine;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_m_WasCanceled;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_m_HasDoneFocusTransition;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForSecondsRealtime;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_m_PreventCallback;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextComponentUpdateRequired;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_m_isLastKeyBackspace;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownClickStartTime;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyDownStartTime;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_m_DoubleClickDelay;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_kEmailSpecialCharacters;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCompositionActive;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousIMEInsertionLine;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalFontAsset;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_m_OnFocusSelectAll;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_m_isSelectAll;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetOnDeActivation;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionStillActive;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseSelection;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviouslySelectedObject;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_m_isRichTextEditingAllowed;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_m_LineLimit;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_InputValidator;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_m_isSelected;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_m_IsStringPositionDirty;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCaretPositionDirty;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_m_forceRectTransformAdjustment;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessingEvent;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Private_get_String_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_get_caretColor_Public_get_Color_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_pointSize_Public_get_Single_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_lineType_Public_get_LineType_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_get_inputType_Public_get_InputType_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretVisible_Private_Void_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretActive_Private_Void_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Protected_Void_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Protected_Void_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedString_Private_String_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Private_Void_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Private_Void_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Private_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Char_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_SendOnFocus_Protected_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Protected_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Private_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputField_Public_Void_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_OnControlClick_Public_Void_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSelection_Public_Void_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_EnforceContentType_Private_Void_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x0200008D RID: 141
		public enum ContentType
		{
			// Token: 0x04000BFF RID: 3071
			Standard,
			// Token: 0x04000C00 RID: 3072
			Autocorrected,
			// Token: 0x04000C01 RID: 3073
			IntegerNumber,
			// Token: 0x04000C02 RID: 3074
			DecimalNumber,
			// Token: 0x04000C03 RID: 3075
			Alphanumeric,
			// Token: 0x04000C04 RID: 3076
			Name,
			// Token: 0x04000C05 RID: 3077
			EmailAddress,
			// Token: 0x04000C06 RID: 3078
			Password,
			// Token: 0x04000C07 RID: 3079
			Pin,
			// Token: 0x04000C08 RID: 3080
			Custom
		}

		// Token: 0x0200008E RID: 142
		public enum InputType
		{
			// Token: 0x04000C0A RID: 3082
			Standard,
			// Token: 0x04000C0B RID: 3083
			AutoCorrect,
			// Token: 0x04000C0C RID: 3084
			Password
		}

		// Token: 0x0200008F RID: 143
		public enum CharacterValidation
		{
			// Token: 0x04000C0E RID: 3086
			None,
			// Token: 0x04000C0F RID: 3087
			Digit,
			// Token: 0x04000C10 RID: 3088
			Integer,
			// Token: 0x04000C11 RID: 3089
			Decimal,
			// Token: 0x04000C12 RID: 3090
			Alphanumeric,
			// Token: 0x04000C13 RID: 3091
			Name,
			// Token: 0x04000C14 RID: 3092
			Regex,
			// Token: 0x04000C15 RID: 3093
			EmailAddress,
			// Token: 0x04000C16 RID: 3094
			CustomValidator
		}

		// Token: 0x02000090 RID: 144
		public enum LineType
		{
			// Token: 0x04000C18 RID: 3096
			SingleLine,
			// Token: 0x04000C19 RID: 3097
			MultiLineSubmit,
			// Token: 0x04000C1A RID: 3098
			MultiLineNewline
		}

		// Token: 0x02000091 RID: 145
		public sealed class OnValidateInput : MulticastDelegate
		{
			// Token: 0x06000F43 RID: 3907 RVA: 0x0003CF90 File Offset: 0x0003B190
			// Note: this type is marked as 'beforefieldinit'.
			static OnValidateInput()
			{
				Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "OnValidateInput");
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664854);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664855);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664856);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664857);
			}

			// Token: 0x06000F44 RID: 3908 RVA: 0x0003D004 File Offset: 0x0003B204
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnValidateInput(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F45 RID: 3909 RVA: 0x0003D060 File Offset: 0x0003B260
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 112617, RefRangeEnd = 112619, XrefRangeStart = 112617, XrefRangeEnd = 112619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char Invoke(string text, int charIndex, char addedChar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000F46 RID: 3910 RVA: 0x0003D0CC File Offset: 0x0003B2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140949, XrefRangeEnd = 140956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedChar;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000F47 RID: 3911 RVA: 0x0003D160 File Offset: 0x0003B360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F48 RID: 3912 RVA: 0x00009344 File Offset: 0x00007544
			public OnValidateInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000F49 RID: 3913 RVA: 0x0000934D File Offset: 0x0000754D
			public static implicit operator TMP_InputField.OnValidateInput(Func<string, int, char, char> A_0)
			{
				return DelegateSupport.ConvertDelegate<TMP_InputField.OnValidateInput>(A_0);
			}

			// Token: 0x06000F4A RID: 3914 RVA: 0x00009355 File Offset: 0x00007555
			public static TMP_InputField.OnValidateInput operator +(TMP_InputField.OnValidateInput A_0, TMP_InputField.OnValidateInput A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TMP_InputField.OnValidateInput>();
			}

			// Token: 0x06000F4B RID: 3915 RVA: 0x00009363 File Offset: 0x00007563
			public static TMP_InputField.OnValidateInput operator -(TMP_InputField.OnValidateInput A_0, TMP_InputField.OnValidateInput A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TMP_InputField.OnValidateInput>();
				}
				return delegate2;
			}

			// Token: 0x04000C1B RID: 3099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000C1C RID: 3100
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0;

			// Token: 0x04000C1D RID: 3101
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0;

			// Token: 0x04000C1E RID: 3102
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0;
		}

		// Token: 0x02000092 RID: 146
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x06000F4C RID: 3916 RVA: 0x00009374 File Offset: 0x00007574
			// Note: this type is marked as 'beforefieldinit'.
			static SubmitEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "SubmitEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr);
				TMP_InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr, 100664858);
			}

			// Token: 0x06000F4D RID: 3917 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 140959, RefRangeEnd = 140961, XrefRangeStart = 140956, XrefRangeEnd = 140959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubmitEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F4E RID: 3918 RVA: 0x000093A8 File Offset: 0x000075A8
			public SubmitEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C1F RID: 3103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000093 RID: 147
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000F4F RID: 3919 RVA: 0x000093B1 File Offset: 0x000075B1
			// Note: this type is marked as 'beforefieldinit'.
			static OnChangeEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "OnChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr);
				TMP_InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr, 100664859);
			}

			// Token: 0x06000F50 RID: 3920 RVA: 0x0003D1EC File Offset: 0x0003B3EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 140964, RefRangeEnd = 140965, XrefRangeStart = 140961, XrefRangeEnd = 140964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F51 RID: 3921 RVA: 0x000093E5 File Offset: 0x000075E5
			public OnChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C20 RID: 3104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000094 RID: 148
		[Serializable]
		public class SelectionEvent : UnityEvent<string>
		{
			// Token: 0x06000F52 RID: 3922 RVA: 0x000093EE File Offset: 0x000075EE
			// Note: this type is marked as 'beforefieldinit'.
			static SelectionEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "SelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr);
				TMP_InputField.SelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr, 100664860);
			}

			// Token: 0x06000F53 RID: 3923 RVA: 0x0003D228 File Offset: 0x0003B428
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 140968, RefRangeEnd = 140970, XrefRangeStart = 140965, XrefRangeEnd = 140968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.SelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F54 RID: 3924 RVA: 0x00009422 File Offset: 0x00007622
			public SelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C21 RID: 3105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000095 RID: 149
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x06000F55 RID: 3925 RVA: 0x0000942B File Offset: 0x0000762B
			// Note: this type is marked as 'beforefieldinit'.
			static TextSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "TextSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr);
				TMP_InputField.TextSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr, 100664861);
			}

			// Token: 0x06000F56 RID: 3926 RVA: 0x0003D264 File Offset: 0x0003B464
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 140973, RefRangeEnd = 140975, XrefRangeStart = 140970, XrefRangeEnd = 140973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.TextSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F57 RID: 3927 RVA: 0x0000945F File Offset: 0x0000765F
			public TextSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C22 RID: 3106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000096 RID: 150
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
		{
			// Token: 0x06000F58 RID: 3928 RVA: 0x00009468 File Offset: 0x00007668
			// Note: this type is marked as 'beforefieldinit'.
			static TouchScreenKeyboardEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "TouchScreenKeyboardEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr);
				TMP_InputField.TouchScreenKeyboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr, 100664862);
			}

			// Token: 0x06000F59 RID: 3929 RVA: 0x0003D2A0 File Offset: 0x0003B4A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 140978, RefRangeEnd = 140979, XrefRangeStart = 140975, XrefRangeEnd = 140978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TouchScreenKeyboardEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.TouchScreenKeyboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F5A RID: 3930 RVA: 0x0000949C File Offset: 0x0000769C
			public TouchScreenKeyboardEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C23 RID: 3107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000097 RID: 151
		public enum EditState
		{
			// Token: 0x04000C25 RID: 3109
			Continue,
			// Token: 0x04000C26 RID: 3110
			Finish
		}

		// Token: 0x02000098 RID: 152
		[ObfuscatedName("TMPro.TMP_InputField+<CaretBlink>d__276")]
		public sealed class _CaretBlink_d__276 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F5B RID: 3931 RVA: 0x0003D2DC File Offset: 0x0003B4DC
			// Note: this type is marked as 'beforefieldinit'.
			static _CaretBlink_d__276()
			{
				Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "<CaretBlink>d__276");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr);
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>1__state");
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>2__current");
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>4__this");
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664863);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664864);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664865);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664866);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664867);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664868);
			}

			// Token: 0x06000F5C RID: 3932 RVA: 0x0003D3BC File Offset: 0x0003B5BC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaretBlink_d__276(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F5D RID: 3933 RVA: 0x0003D404 File Offset: 0x0003B604
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F5E RID: 3934 RVA: 0x0003D438 File Offset: 0x0003B638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140979, XrefRangeEnd = 140983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0003D474 File Offset: 0x0003B674
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F60 RID: 3936 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140983, XrefRangeEnd = 140988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0003D4E8 File Offset: 0x0003B6E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F62 RID: 3938 RVA: 0x000094A5 File Offset: 0x000076A5
			public _CaretBlink_d__276(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0003D528 File Offset: 0x0003B728
			// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000094AE File Offset: 0x000076AE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0003D550 File Offset: 0x0003B750
			// (set) Token: 0x06000F66 RID: 3942 RVA: 0x000094C9 File Offset: 0x000076C9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0003D580 File Offset: 0x0003B780
			// (set) Token: 0x06000F68 RID: 3944 RVA: 0x000094E8 File Offset: 0x000076E8
			public unsafe TMP_InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C27 RID: 3111
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C28 RID: 3112
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C29 RID: 3113
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C2A RID: 3114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C2B RID: 3115
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C2C RID: 3116
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C2D RID: 3117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C2E RID: 3118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C2F RID: 3119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000099 RID: 153
		[ObfuscatedName("TMPro.TMP_InputField+<MouseDragOutsideRect>d__294")]
		public sealed class _MouseDragOutsideRect_d__294 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F69 RID: 3945 RVA: 0x0003D5B0 File Offset: 0x0003B7B0
			// Note: this type is marked as 'beforefieldinit'.
			static _MouseDragOutsideRect_d__294()
			{
				Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "<MouseDragOutsideRect>d__294");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>1__state");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>2__current");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>4__this");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "eventData");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664869);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664870);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664871);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664872);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664873);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664874);
			}

			// Token: 0x06000F6A RID: 3946 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MouseDragOutsideRect_d__294(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F6B RID: 3947 RVA: 0x0003D6EC File Offset: 0x0003B8EC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F6C RID: 3948 RVA: 0x0003D720 File Offset: 0x0003B920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140988, XrefRangeEnd = 141014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0003D75C File Offset: 0x0003B95C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x0003D79C File Offset: 0x0003B99C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141014, XrefRangeEnd = 141019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F70 RID: 3952 RVA: 0x00009507 File Offset: 0x00007707
			public _MouseDragOutsideRect_d__294(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0003D810 File Offset: 0x0003BA10
			// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00009510 File Offset: 0x00007710
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0003D838 File Offset: 0x0003BA38
			// (set) Token: 0x06000F74 RID: 3956 RVA: 0x0000952B File Offset: 0x0000772B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0003D868 File Offset: 0x0003BA68
			// (set) Token: 0x06000F76 RID: 3958 RVA: 0x0000954A File Offset: 0x0000774A
			public unsafe TMP_InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0003D898 File Offset: 0x0003BA98
			// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00009569 File Offset: 0x00007769
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C30 RID: 3120
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C31 RID: 3121
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C32 RID: 3122
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C33 RID: 3123
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x04000C34 RID: 3124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C35 RID: 3125
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C36 RID: 3126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C37 RID: 3127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C38 RID: 3128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C39 RID: 3129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
