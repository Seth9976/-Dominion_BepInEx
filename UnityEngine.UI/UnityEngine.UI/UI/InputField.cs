using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000018 RID: 24
	public class InputField : Selectable
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00010074 File Offset: 0x0000E274
		// Note: this type is marked as 'beforefieldinit'.
		static InputField()
		{
			Il2CppClassPointerStore<InputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "InputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField>.NativeClassPtr);
			InputField.NativeFieldInfoPtr_m_Keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Keyboard");
			InputField.NativeFieldInfoPtr_kSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kSeparators");
			InputField.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_TextComponent");
			InputField.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Placeholder");
			InputField.NativeFieldInfoPtr_m_ContentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ContentType");
			InputField.NativeFieldInfoPtr_m_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_InputType");
			InputField.NativeFieldInfoPtr_m_AsteriskChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_AsteriskChar");
			InputField.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_KeyboardType");
			InputField.NativeFieldInfoPtr_m_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_LineType");
			InputField.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_HideMobileInput");
			InputField.NativeFieldInfoPtr_m_CharacterValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CharacterValidation");
			InputField.NativeFieldInfoPtr_m_CharacterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CharacterLimit");
			InputField.NativeFieldInfoPtr_m_OnEndEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnEndEdit");
			InputField.NativeFieldInfoPtr_m_OnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnSubmit");
			InputField.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnValueChanged");
			InputField.NativeFieldInfoPtr_m_OnValidateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnValidateInput");
			InputField.NativeFieldInfoPtr_m_CaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretColor");
			InputField.NativeFieldInfoPtr_m_CustomCaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CustomCaretColor");
			InputField.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_SelectionColor");
			InputField.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Text");
			InputField.NativeFieldInfoPtr_m_CaretBlinkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretBlinkRate");
			InputField.NativeFieldInfoPtr_m_CaretWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretWidth");
			InputField.NativeFieldInfoPtr_m_ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ReadOnly");
			InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ShouldActivateOnSelect");
			InputField.NativeFieldInfoPtr_m_CaretPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretPosition");
			InputField.NativeFieldInfoPtr_m_CaretSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretSelectPosition");
			InputField.NativeFieldInfoPtr_caretRectTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "caretRectTrans");
			InputField.NativeFieldInfoPtr_m_CursorVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CursorVerts");
			InputField.NativeFieldInfoPtr_m_InputTextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_InputTextCache");
			InputField.NativeFieldInfoPtr_m_CachedInputRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CachedInputRenderer");
			InputField.NativeFieldInfoPtr_m_PreventFontCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_PreventFontCallback");
			InputField.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Mesh");
			InputField.NativeFieldInfoPtr_m_AllowInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_AllowInput");
			InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ShouldActivateNextUpdate");
			InputField.NativeFieldInfoPtr_m_UpdateDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_UpdateDrag");
			InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DragPositionOutOfBounds");
			InputField.NativeFieldInfoPtr_kHScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kHScrollSpeed");
			InputField.NativeFieldInfoPtr_kVScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kVScrollSpeed");
			InputField.NativeFieldInfoPtr_m_CaretVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretVisible");
			InputField.NativeFieldInfoPtr_m_BlinkCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_BlinkCoroutine");
			InputField.NativeFieldInfoPtr_m_BlinkStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_BlinkStartTime");
			InputField.NativeFieldInfoPtr_m_DrawStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DrawStart");
			InputField.NativeFieldInfoPtr_m_DrawEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DrawEnd");
			InputField.NativeFieldInfoPtr_m_DragCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DragCoroutine");
			InputField.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OriginalText");
			InputField.NativeFieldInfoPtr_m_WasCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_WasCanceled");
			InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_HasDoneFocusTransition");
			InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_WaitForSecondsRealtime");
			InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_TouchKeyboardAllowsInPlaceEditing");
			InputField.NativeFieldInfoPtr_kEmailSpecialCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kEmailSpecialCharacters");
			InputField.NativeFieldInfoPtr_m_ProcessingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ProcessingEvent");
			InputField.NativeFieldInfoPtr_k_MaxTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "k_MaxTextLength");
			InputField.NativeMethodInfoPtr_get_input_Private_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663635);
			InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663636);
			InputField.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663637);
			InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663638);
			InputField.NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663639);
			InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663640);
			InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663641);
			InputField.NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663642);
			InputField.NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663643);
			InputField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663644);
			InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663645);
			InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663646);
			InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663647);
			InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663648);
			InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663649);
			InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663650);
			InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663651);
			InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663652);
			InputField.NativeMethodInfoPtr_get_textComponent_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663653);
			InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663654);
			InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663655);
			InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663656);
			InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663657);
			InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663658);
			InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663659);
			InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663660);
			InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663661);
			InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663662);
			InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663663);
			InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663664);
			InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663665);
			InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663666);
			InputField.NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663667);
			InputField.NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663668);
			InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663669);
			InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663670);
			InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663671);
			InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663672);
			InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663673);
			InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663674);
			InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663675);
			InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663676);
			InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663677);
			InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663678);
			InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663679);
			InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663680);
			InputField.NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663681);
			InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663682);
			InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663683);
			InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663684);
			InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663685);
			InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663686);
			InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663687);
			InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663688);
			InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663689);
			InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663690);
			InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663691);
			InputField.NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663692);
			InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663693);
			InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663694);
			InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663695);
			InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663696);
			InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663697);
			InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663698);
			InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663699);
			InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663700);
			InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663701);
			InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663702);
			InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663703);
			InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663704);
			InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663705);
			InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663706);
			InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663707);
			InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663708);
			InputField.NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663709);
			InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663710);
			InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663711);
			InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663712);
			InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663713);
			InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663714);
			InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663715);
			InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663716);
			InputField.NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663717);
			InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663718);
			InputField.NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663719);
			InputField.NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663720);
			InputField.NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663721);
			InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663722);
			InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663723);
			InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663724);
			InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663725);
			InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663726);
			InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663727);
			InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663728);
			InputField.NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663729);
			InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663730);
			InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663731);
			InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663732);
			InputField.NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663733);
			InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663734);
			InputField.NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663735);
			InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663736);
			InputField.NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663737);
			InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663738);
			InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663739);
			InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663740);
			InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663741);
			InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663742);
			InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663743);
			InputField.NativeMethodInfoPtr_Delete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663744);
			InputField.NativeMethodInfoPtr_ForwardSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663745);
			InputField.NativeMethodInfoPtr_Backspace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663746);
			InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663747);
			InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663748);
			InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663749);
			InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663750);
			InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663751);
			InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663752);
			InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663753);
			InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663754);
			InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663755);
			InputField.NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663756);
			InputField.NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663757);
			InputField.NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663758);
			InputField.NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663759);
			InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663760);
			InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663761);
			InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663762);
			InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663763);
			InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663764);
			InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663765);
			InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663766);
			InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663767);
			InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663768);
			InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663769);
			InputField.NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663770);
			InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663771);
			InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663772);
			InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663773);
			InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663774);
			InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663775);
			InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663776);
			InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663777);
			InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663778);
			InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663779);
			InputField.NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663780);
			InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663781);
			InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663782);
			InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663783);
			InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663784);
			InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663785);
			InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663786);
			InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663787);
			InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663788);
			InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663789);
			InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663790);
			InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663791);
			InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663792);
			InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663794);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00011120 File Offset: 0x0000F320
		public unsafe BaseInput input
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 112702, RefRangeEnd = 112712, XrefRangeStart = 112684, XrefRangeEnd = 112702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_input_Private_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00011160 File Offset: 0x0000F360
		public unsafe string compositionString
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 112720, RefRangeEnd = 112805, XrefRangeStart = 112712, XrefRangeEnd = 112720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00011198 File Offset: 0x0000F398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112805, XrefRangeEnd = 112832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000111D4 File Offset: 0x0000F3D4
		public unsafe Mesh mesh
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 112840, RefRangeEnd = 112842, XrefRangeStart = 112832, XrefRangeEnd = 112840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00011214 File Offset: 0x0000F414
		public unsafe TextGenerator cachedInputTextGenerator
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 112846, RefRangeEnd = 112859, XrefRangeStart = 112842, XrefRangeEnd = 112846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00011294 File Offset: 0x0000F494
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00011254 File Offset: 0x0000F454
		public unsafe bool shouldHideMobileInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112862, XrefRangeEnd = 112863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112859, XrefRangeEnd = 112862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0001131C File Offset: 0x0000F51C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000112D0 File Offset: 0x0000F4D0
		public unsafe virtual bool shouldActivateOnSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00011364 File Offset: 0x0000F564
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0001139C File Offset: 0x0000F59C
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112864, RefRangeEnd = 112867, XrefRangeStart = 112863, XrefRangeEnd = 112864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000113E0 File Offset: 0x0000F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112867, XrefRangeEnd = 112868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextWithoutNotify(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00011424 File Offset: 0x0000F624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112910, RefRangeEnd = 112913, XrefRangeStart = 112868, XrefRangeEnd = 112910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00011474 File Offset: 0x0000F674
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000114B0 File Offset: 0x0000F6B0
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000114EC File Offset: 0x0000F6EC
		public unsafe float caretBlinkRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112913, XrefRangeEnd = 112917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0001152C File Offset: 0x0000F72C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00011568 File Offset: 0x0000F768
		public unsafe int caretWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112917, XrefRangeEnd = 112924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000115A8 File Offset: 0x0000F7A8
		// (set) Token: 0x06000272 RID: 626 RVA: 0x000115E8 File Offset: 0x0000F7E8
		public unsafe Text textComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_textComponent_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112969, RefRangeEnd = 112970, XrefRangeStart = 112924, XrefRangeEnd = 112969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0001162C File Offset: 0x0000F82C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0001166C File Offset: 0x0000F86C
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112973, RefRangeEnd = 112974, XrefRangeStart = 112970, XrefRangeEnd = 112973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000116B0 File Offset: 0x0000F8B0
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000116EC File Offset: 0x0000F8EC
		public unsafe Color caretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112974, XrefRangeEnd = 112979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001172C File Offset: 0x0000F92C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00011768 File Offset: 0x0000F968
		public unsafe bool customCaretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112979, XrefRangeEnd = 112983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000117A8 File Offset: 0x0000F9A8
		// (set) Token: 0x0600027A RID: 634 RVA: 0x000117E4 File Offset: 0x0000F9E4
		public unsafe Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112983, XrefRangeEnd = 112988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00011824 File Offset: 0x0000FA24
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00011864 File Offset: 0x0000FA64
		public unsafe InputField.EndEditEvent onEndEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.EndEditEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112988, XrefRangeEnd = 112991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000118A8 File Offset: 0x0000FAA8
		// (set) Token: 0x0600027E RID: 638 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public unsafe InputField.SubmitEvent onSubmit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112991, XrefRangeEnd = 112994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0001192C File Offset: 0x0000FB2C
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0001196C File Offset: 0x0000FB6C
		public unsafe InputField.OnChangeEvent onValueChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112994, XrefRangeEnd = 112997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000119B0 File Offset: 0x0000FBB0
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000119F0 File Offset: 0x0000FBF0
		public unsafe InputField.OnChangeEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00011A34 File Offset: 0x0000FC34
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00011A74 File Offset: 0x0000FC74
		public unsafe InputField.OnValidateInput onValidateInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnValidateInput>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112997, XrefRangeEnd = 113000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		public unsafe int characterLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113000, XrefRangeEnd = 113009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00011B34 File Offset: 0x0000FD34
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00011B70 File Offset: 0x0000FD70
		public unsafe InputField.ContentType contentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 113021, RefRangeEnd = 113027, XrefRangeStart = 113009, XrefRangeEnd = 113021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00011BEC File Offset: 0x0000FDEC
		public unsafe InputField.LineType lineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113027, XrefRangeEnd = 113036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00011C2C File Offset: 0x0000FE2C
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00011C68 File Offset: 0x0000FE68
		public unsafe InputField.InputType inputType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113036, XrefRangeEnd = 113040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public unsafe TouchScreenKeyboard touchScreenKeyboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00011D24 File Offset: 0x0000FF24
		public unsafe TouchScreenKeyboardType keyboardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113040, XrefRangeEnd = 113044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00011D64 File Offset: 0x0000FF64
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		public unsafe InputField.CharacterValidation characterValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113044, XrefRangeEnd = 113048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00011E1C File Offset: 0x0001001C
		public unsafe bool readOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00011E5C File Offset: 0x0001005C
		public unsafe bool multiLine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 113048, RefRangeEnd = 113050, XrefRangeStart = 113048, XrefRangeEnd = 113048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00011E98 File Offset: 0x00010098
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00011ED4 File Offset: 0x000100D4
		public unsafe char asteriskChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113050, XrefRangeEnd = 113054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00011F14 File Offset: 0x00010114
		public unsafe bool wasCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00011F50 File Offset: 0x00010150
		[CallerCount(0)]
		public unsafe void ClampPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00011F90 File Offset: 0x00010190
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00011FCC File Offset: 0x000101CC
		public unsafe int caretPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113054, XrefRangeEnd = 113055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0001200C File Offset: 0x0001020C
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00012048 File Offset: 0x00010248
		public unsafe int caretSelectPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113055, XrefRangeEnd = 113056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00012088 File Offset: 0x00010288
		public new unsafe bool hasSelection
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 113058, RefRangeEnd = 113063, XrefRangeStart = 113056, XrefRangeEnd = 113058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000120C4 File Offset: 0x000102C4
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00012100 File Offset: 0x00010300
		public unsafe int caretPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113063, XrefRangeEnd = 113066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00012140 File Offset: 0x00010340
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0001217C File Offset: 0x0001037C
		public unsafe int selectionAnchorPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113066, XrefRangeEnd = 113067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000121BC File Offset: 0x000103BC
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000121F8 File Offset: 0x000103F8
		public unsafe int selectionFocusPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113067, XrefRangeEnd = 113068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00012238 File Offset: 0x00010438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113068, XrefRangeEnd = 113104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00012274 File Offset: 0x00010474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113104, XrefRangeEnd = 113144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000122B0 File Offset: 0x000104B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113144, XrefRangeEnd = 113148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaretBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000122F0 File Offset: 0x000104F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113150, RefRangeEnd = 113151, XrefRangeStart = 113148, XrefRangeEnd = 113150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00012324 File Offset: 0x00010524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113151, RefRangeEnd = 113154, XrefRangeStart = 113151, XrefRangeEnd = 113151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00012358 File Offset: 0x00010558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113154, XrefRangeEnd = 113167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCaretMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001238C File Offset: 0x0001058C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113168, RefRangeEnd = 113169, XrefRangeStart = 113167, XrefRangeEnd = 113168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000123C0 File Offset: 0x000105C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113168, RefRangeEnd = 113169, XrefRangeStart = 113168, XrefRangeEnd = 113169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000123F4 File Offset: 0x000105F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113176, RefRangeEnd = 113177, XrefRangeStart = 113169, XrefRangeEnd = 113176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00012434 File Offset: 0x00010634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113177, XrefRangeEnd = 113182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextStart(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00012474 File Offset: 0x00010674
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000124A0 File Offset: 0x000106A0
		public unsafe static string clipboard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113182, XrefRangeEnd = 113183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113183, XrefRangeEnd = 113184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000124D8 File Offset: 0x000106D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113184, XrefRangeEnd = 113185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InPlaceEditing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00012514 File Offset: 0x00010714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113185, XrefRangeEnd = 113194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCaretFromKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00012548 File Offset: 0x00010748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113194, XrefRangeEnd = 113211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00012584 File Offset: 0x00010784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113211, XrefRangeEnd = 113235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ScreenToLocal(Vector2 screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000125D0 File Offset: 0x000107D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113236, RefRangeEnd = 113237, XrefRangeStart = 113235, XrefRangeEnd = 113236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001262C File Offset: 0x0001082C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113256, RefRangeEnd = 113257, XrefRangeStart = 113237, XrefRangeEnd = 113256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCharacterIndexFromPosition(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00012678 File Offset: 0x00010878
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113262, RefRangeEnd = 113266, XrefRangeStart = 113257, XrefRangeEnd = 113262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000126C8 File Offset: 0x000108C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113266, XrefRangeEnd = 113267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00012718 File Offset: 0x00010918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113267, XrefRangeEnd = 113290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00012768 File Offset: 0x00010968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113290, XrefRangeEnd = 113294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000127B8 File Offset: 0x000109B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113294, XrefRangeEnd = 113295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00012808 File Offset: 0x00010A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113295, XrefRangeEnd = 113306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00012858 File Offset: 0x00010A58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113347, RefRangeEnd = 113349, XrefRangeStart = 113306, XrefRangeEnd = 113347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputField.EditState KeyPressed(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000128A8 File Offset: 0x00010AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113349, XrefRangeEnd = 113351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000128F4 File Offset: 0x00010AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113351, XrefRangeEnd = 113352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00012938 File Offset: 0x00010B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113352, XrefRangeEnd = 113363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00012988 File Offset: 0x00010B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113369, RefRangeEnd = 113370, XrefRangeStart = 113363, XrefRangeEnd = 113369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSelectedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000129C0 File Offset: 0x00010BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113370, XrefRangeEnd = 113377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindtNextWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000129FC File Offset: 0x00010BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113395, RefRangeEnd = 113397, XrefRangeStart = 113377, XrefRangeEnd = 113395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00012A48 File Offset: 0x00010C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113397, XrefRangeEnd = 113404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindtPrevWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00012A84 File Offset: 0x00010C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113410, RefRangeEnd = 113412, XrefRangeStart = 113404, XrefRangeEnd = 113410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00012AD0 File Offset: 0x00010CD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113419, RefRangeEnd = 113425, XrefRangeStart = 113412, XrefRangeEnd = 113419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00012B2C File Offset: 0x00010D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113465, RefRangeEnd = 113466, XrefRangeStart = 113425, XrefRangeEnd = 113465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00012B84 File Offset: 0x00010D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113506, RefRangeEnd = 113507, XrefRangeStart = 113466, XrefRangeEnd = 113506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00012BDC File Offset: 0x00010DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113507, XrefRangeEnd = 113508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00012C1C File Offset: 0x00010E1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113517, RefRangeEnd = 113520, XrefRangeStart = 113508, XrefRangeEnd = 113517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00012C68 File Offset: 0x00010E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113520, XrefRangeEnd = 113521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113530, RefRangeEnd = 113533, XrefRangeStart = 113521, XrefRangeEnd = 113530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00012CF4 File Offset: 0x00010EF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113544, RefRangeEnd = 113547, XrefRangeStart = 113533, XrefRangeEnd = 113544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Delete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00012D28 File Offset: 0x00010F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113547, XrefRangeEnd = 113553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForwardSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ForwardSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00012D5C File Offset: 0x00010F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113553, XrefRangeEnd = 113562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Backspace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00012D90 File Offset: 0x00010F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113564, RefRangeEnd = 113565, XrefRangeStart = 113562, XrefRangeEnd = 113564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00012DD0 File Offset: 0x00010FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113567, RefRangeEnd = 113570, XrefRangeStart = 113565, XrefRangeEnd = 113567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTouchKeyboardFromEditChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00012E04 File Offset: 0x00011004
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113577, RefRangeEnd = 113581, XrefRangeStart = 113570, XrefRangeEnd = 113577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChangedAndUpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00012E38 File Offset: 0x00011038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113581, XrefRangeEnd = 113587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00012E6C File Offset: 0x0001106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113587, XrefRangeEnd = 113593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00012EA0 File Offset: 0x000110A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113593, XrefRangeEnd = 113599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00012ED4 File Offset: 0x000110D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113599, XrefRangeEnd = 113601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00012F24 File Offset: 0x00011124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113601, XrefRangeEnd = 113630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(char input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00012F70 File Offset: 0x00011170
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 113678, RefRangeEnd = 113691, XrefRangeStart = 113630, XrefRangeEnd = 113678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00012FA4 File Offset: 0x000111A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113691, XrefRangeEnd = 113695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelectionVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00012FE0 File Offset: 0x000111E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113704, RefRangeEnd = 113706, XrefRangeStart = 113695, XrefRangeEnd = 113704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLineStartPosition(TextGenerator gen, int line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00013030 File Offset: 0x00011230
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 113716, RefRangeEnd = 113721, XrefRangeStart = 113706, XrefRangeEnd = 113716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLineEndPosition(TextGenerator gen, int line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00013080 File Offset: 0x00011280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113801, RefRangeEnd = 113802, XrefRangeStart = 113721, XrefRangeEnd = 113801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caretPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000130C0 File Offset: 0x000112C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113802, XrefRangeEnd = 113803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLabelUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000130F4 File Offset: 0x000112F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113807, RefRangeEnd = 113809, XrefRangeStart = 113803, XrefRangeEnd = 113807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGeometryAsDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00013128 File Offset: 0x00011328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113809, XrefRangeEnd = 113810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00013174 File Offset: 0x00011374
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000131B0 File Offset: 0x000113B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000131EC File Offset: 0x000113EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113874, RefRangeEnd = 113875, XrefRangeStart = 113810, XrefRangeEnd = 113874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00013220 File Offset: 0x00011420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113933, RefRangeEnd = 113935, XrefRangeStart = 113875, XrefRangeEnd = 113933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPositioningIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00013254 File Offset: 0x00011454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113954, RefRangeEnd = 113955, XrefRangeStart = 113935, XrefRangeEnd = 113954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFillVBO(Mesh vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00013298 File Offset: 0x00011498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114029, RefRangeEnd = 114030, XrefRangeStart = 113955, XrefRangeEnd = 114029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000132E8 File Offset: 0x000114E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114030, XrefRangeEnd = 114041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCursorVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001331C File Offset: 0x0001151C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114097, RefRangeEnd = 114098, XrefRangeStart = 114041, XrefRangeEnd = 114097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001336C File Offset: 0x0001156C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114131, RefRangeEnd = 114132, XrefRangeStart = 114098, XrefRangeEnd = 114131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000133D8 File Offset: 0x000115D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114143, RefRangeEnd = 114145, XrefRangeStart = 114132, XrefRangeEnd = 114143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001340C File Offset: 0x0001160C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114192, RefRangeEnd = 114193, XrefRangeStart = 114145, XrefRangeEnd = 114192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputFieldInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00013440 File Offset: 0x00011640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114193, XrefRangeEnd = 114195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00013490 File Offset: 0x00011690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114195, XrefRangeEnd = 114196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000134E0 File Offset: 0x000116E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114222, RefRangeEnd = 114224, XrefRangeStart = 114196, XrefRangeEnd = 114222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00013514 File Offset: 0x00011714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114224, XrefRangeEnd = 114226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00013564 File Offset: 0x00011764
		[CallerCount(0)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000135B4 File Offset: 0x000117B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114226, XrefRangeEnd = 114235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000135E8 File Offset: 0x000117E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 114240, RefRangeEnd = 114252, XrefRangeStart = 114235, XrefRangeEnd = 114240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceTextHOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001361C File Offset: 0x0001181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114252, XrefRangeEnd = 114254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustomIfContentTypeIsNot([Optional] Il2CppStructArray<InputField.ContentType> allowedContentTypes)
		{
			if (allowedContentTypes == null)
			{
				allowedContentTypes = new Il2CppStructArray<InputField.ContentType>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allowedContentTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001366C File Offset: 0x0001186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114254, XrefRangeEnd = 114255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000136A0 File Offset: 0x000118A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114255, XrefRangeEnd = 114257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000136F8 File Offset: 0x000118F8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00013734 File Offset: 0x00011934
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00013770 File Offset: 0x00011970
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x000137B8 File Offset: 0x000119B8
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114257, XrefRangeEnd = 114266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00013800 File Offset: 0x00011A00
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00013848 File Offset: 0x00011A48
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00013890 File Offset: 0x00011A90
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114266, XrefRangeEnd = 114277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002FB RID: 763 RVA: 0x000138D8 File Offset: 0x00011AD8
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00013920 File Offset: 0x00011B20
		public unsafe virtual int layoutPriority
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00013968 File Offset: 0x00011B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002D59 File Offset: 0x00000F59
		public void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			this.SetToCustomIfContentTypeIsNot(new Il2CppStructArray<InputField.ContentType>(allowedContentTypes));
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002D67 File Offset: 0x00000F67
		public InputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000139A8 File Offset: 0x00011BA8
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00002D70 File Offset: 0x00000F70
		public unsafe TouchScreenKeyboard m_Keyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Keyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Keyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000139D8 File Offset: 0x00011BD8
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00002D8F File Offset: 0x00000F8F
		public unsafe static Il2CppStructArray<char> kSeparators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kSeparators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kSeparators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00013A00 File Offset: 0x00011C00
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public unsafe Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00013A30 File Offset: 0x00011C30
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00013A60 File Offset: 0x00011C60
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00002DDF File Offset: 0x00000FDF
		public unsafe InputField.ContentType m_ContentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ContentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ContentType)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00013A88 File Offset: 0x00011C88
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe InputField.InputType m_InputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputType)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00013AB0 File Offset: 0x00011CB0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00002E15 File Offset: 0x00001015
		public unsafe char m_AsteriskChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AsteriskChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AsteriskChar)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00013AD8 File Offset: 0x00011CD8
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00002E30 File Offset: 0x00001030
		public unsafe TouchScreenKeyboardType m_KeyboardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_KeyboardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_KeyboardType)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00013B00 File Offset: 0x00011D00
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00002E4B File Offset: 0x0000104B
		public unsafe InputField.LineType m_LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_LineType)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00013B28 File Offset: 0x00011D28
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00002E66 File Offset: 0x00001066
		public unsafe bool m_HideMobileInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HideMobileInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HideMobileInput)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00013B50 File Offset: 0x00011D50
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00002E81 File Offset: 0x00001081
		public unsafe InputField.CharacterValidation m_CharacterValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterValidation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterValidation)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00013B78 File Offset: 0x00011D78
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00002E9C File Offset: 0x0000109C
		public unsafe int m_CharacterLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterLimit)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00013BA0 File Offset: 0x00011DA0
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002EB7 File Offset: 0x000010B7
		public unsafe InputField.EndEditEvent m_OnEndEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnEndEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.EndEditEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnEndEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00013BD0 File Offset: 0x00011DD0
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00002ED6 File Offset: 0x000010D6
		public unsafe InputField.SubmitEvent m_OnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00013C00 File Offset: 0x00011E00
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00002EF5 File Offset: 0x000010F5
		public unsafe InputField.OnChangeEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00013C30 File Offset: 0x00011E30
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00002F14 File Offset: 0x00001114
		public unsafe InputField.OnValidateInput m_OnValidateInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValidateInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.OnValidateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValidateInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00013C60 File Offset: 0x00011E60
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00002F33 File Offset: 0x00001133
		public unsafe Color m_CaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretColor)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00013C88 File Offset: 0x00011E88
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00002F4E File Offset: 0x0000114E
		public unsafe bool m_CustomCaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CustomCaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CustomCaretColor)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00013CB0 File Offset: 0x00011EB0
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00002F69 File Offset: 0x00001169
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00013CD8 File Offset: 0x00011ED8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00002F84 File Offset: 0x00001184
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00013D00 File Offset: 0x00011F00
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00002FA3 File Offset: 0x000011A3
		public unsafe float m_CaretBlinkRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretBlinkRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretBlinkRate)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00013D28 File Offset: 0x00011F28
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00002FBE File Offset: 0x000011BE
		public unsafe int m_CaretWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretWidth)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00013D50 File Offset: 0x00011F50
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00002FD9 File Offset: 0x000011D9
		public unsafe bool m_ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ReadOnly)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00013D78 File Offset: 0x00011F78
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00002FF4 File Offset: 0x000011F4
		public unsafe bool m_ShouldActivateOnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00013DA0 File Offset: 0x00011FA0
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000300F File Offset: 0x0000120F
		public unsafe int m_CaretPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretPosition)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00013DC8 File Offset: 0x00011FC8
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000302A File Offset: 0x0000122A
		public unsafe int m_CaretSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretSelectPosition)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00013DF0 File Offset: 0x00011FF0
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00003045 File Offset: 0x00001245
		public unsafe RectTransform caretRectTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_caretRectTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_caretRectTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00013E20 File Offset: 0x00012020
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003064 File Offset: 0x00001264
		public unsafe Il2CppStructArray<UIVertex> m_CursorVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CursorVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CursorVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00013E50 File Offset: 0x00012050
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003083 File Offset: 0x00001283
		public unsafe TextGenerator m_InputTextCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputTextCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputTextCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00013E80 File Offset: 0x00012080
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000030A2 File Offset: 0x000012A2
		public unsafe CanvasRenderer m_CachedInputRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CachedInputRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CachedInputRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00013EB0 File Offset: 0x000120B0
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000030C1 File Offset: 0x000012C1
		public unsafe bool m_PreventFontCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_PreventFontCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_PreventFontCallback)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00013ED8 File Offset: 0x000120D8
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000030DC File Offset: 0x000012DC
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00013F08 File Offset: 0x00012108
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000030FB File Offset: 0x000012FB
		public unsafe bool m_AllowInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AllowInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AllowInput)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00013F30 File Offset: 0x00012130
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003116 File Offset: 0x00001316
		public unsafe bool m_ShouldActivateNextUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00013F58 File Offset: 0x00012158
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003131 File Offset: 0x00001331
		public unsafe bool m_UpdateDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_UpdateDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_UpdateDrag)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00013F80 File Offset: 0x00012180
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000314C File Offset: 0x0000134C
		public unsafe bool m_DragPositionOutOfBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00013FA8 File Offset: 0x000121A8
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003167 File Offset: 0x00001367
		public unsafe static float kHScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00013FC4 File Offset: 0x000121C4
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003175 File Offset: 0x00001375
		public unsafe static float kVScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00013FE0 File Offset: 0x000121E0
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003183 File Offset: 0x00001383
		public unsafe bool m_CaretVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretVisible)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00014008 File Offset: 0x00012208
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000319E File Offset: 0x0000139E
		public unsafe Coroutine m_BlinkCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00014038 File Offset: 0x00012238
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000031BD File Offset: 0x000013BD
		public unsafe float m_BlinkStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkStartTime)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00014060 File Offset: 0x00012260
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000031D8 File Offset: 0x000013D8
		public unsafe int m_DrawStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawStart)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00014088 File Offset: 0x00012288
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000031F3 File Offset: 0x000013F3
		public unsafe int m_DrawEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawEnd)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000140B0 File Offset: 0x000122B0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000320E File Offset: 0x0000140E
		public unsafe Coroutine m_DragCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000140E0 File Offset: 0x000122E0
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000322D File Offset: 0x0000142D
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00014108 File Offset: 0x00012308
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000324C File Offset: 0x0000144C
		public unsafe bool m_WasCanceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WasCanceled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WasCanceled)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00014130 File Offset: 0x00012330
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003267 File Offset: 0x00001467
		public unsafe bool m_HasDoneFocusTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00014158 File Offset: 0x00012358
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003282 File Offset: 0x00001482
		public unsafe WaitForSecondsRealtime m_WaitForSecondsRealtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00014188 File Offset: 0x00012388
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000032A1 File Offset: 0x000014A1
		public unsafe bool m_TouchKeyboardAllowsInPlaceEditing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000141B0 File Offset: 0x000123B0
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000032BC File Offset: 0x000014BC
		public unsafe static string kEmailSpecialCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000141D0 File Offset: 0x000123D0
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000032CE File Offset: 0x000014CE
		public unsafe Event m_ProcessingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ProcessingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ProcessingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00014200 File Offset: 0x00012400
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000032ED File Offset: 0x000014ED
		public unsafe static int k_MaxTextLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_k_MaxTextLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_k_MaxTextLength, (void*)(&value));
			}
		}

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyboard;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_kSeparators;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentType;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_m_InputType;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_m_AsteriskChar;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_m_LineType;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterValidation;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLimit;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_m_OnEndEdit;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubmit;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValidateInput;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretColor;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomCaretColor;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretBlinkRate;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretWidth;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnly;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateOnSelect;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretPosition;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretSelectPosition;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_caretRectTrans;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorVerts;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_m_InputTextCache;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInputRenderer;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_m_PreventFontCallback;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowInput;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateNextUpdate;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateDrag;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_m_DragPositionOutOfBounds;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_kHScrollSpeed;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_kVScrollSpeed;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretVisible;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkCoroutine;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkStartTime;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawStart;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawEnd;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_m_DragCoroutine;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_m_WasCanceled;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_m_HasDoneFocusTransition;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForSecondsRealtime;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_kEmailSpecialCharacters;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessingEvent;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxTextLength;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Private_get_BaseInput_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Private_get_String_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_Text_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_caretColor_Public_get_Color_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_lineType_Public_get_LineType_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_get_inputType_Public_get_InputType_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretVisible_Private_Void_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretActive_Private_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Protected_Void_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Protected_Void_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedString_Private_String_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Private_Void_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_ForwardSpace_Private_Void_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Private_Void_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Char_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Protected_Void_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Private_Void_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputField_Public_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateInputField_Public_Void_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_EnforceContentType_Private_Void_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x0200008A RID: 138
		public enum ContentType
		{
			// Token: 0x04000906 RID: 2310
			Standard,
			// Token: 0x04000907 RID: 2311
			Autocorrected,
			// Token: 0x04000908 RID: 2312
			IntegerNumber,
			// Token: 0x04000909 RID: 2313
			DecimalNumber,
			// Token: 0x0400090A RID: 2314
			Alphanumeric,
			// Token: 0x0400090B RID: 2315
			Name,
			// Token: 0x0400090C RID: 2316
			EmailAddress,
			// Token: 0x0400090D RID: 2317
			Password,
			// Token: 0x0400090E RID: 2318
			Pin,
			// Token: 0x0400090F RID: 2319
			Custom
		}

		// Token: 0x0200008B RID: 139
		public enum InputType
		{
			// Token: 0x04000911 RID: 2321
			Standard,
			// Token: 0x04000912 RID: 2322
			AutoCorrect,
			// Token: 0x04000913 RID: 2323
			Password
		}

		// Token: 0x0200008C RID: 140
		public enum CharacterValidation
		{
			// Token: 0x04000915 RID: 2325
			None,
			// Token: 0x04000916 RID: 2326
			Integer,
			// Token: 0x04000917 RID: 2327
			Decimal,
			// Token: 0x04000918 RID: 2328
			Alphanumeric,
			// Token: 0x04000919 RID: 2329
			Name,
			// Token: 0x0400091A RID: 2330
			EmailAddress
		}

		// Token: 0x0200008D RID: 141
		public enum LineType
		{
			// Token: 0x0400091C RID: 2332
			SingleLine,
			// Token: 0x0400091D RID: 2333
			MultiLineSubmit,
			// Token: 0x0400091E RID: 2334
			MultiLineNewline
		}

		// Token: 0x0200008E RID: 142
		public sealed class OnValidateInput : MulticastDelegate
		{
			// Token: 0x06000BD7 RID: 3031 RVA: 0x00034388 File Offset: 0x00032588
			// Note: this type is marked as 'beforefieldinit'.
			static OnValidateInput()
			{
				Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "OnValidateInput");
				InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100664991);
				InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100664992);
				InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100664993);
				InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100664994);
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x000343FC File Offset: 0x000325FC
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnValidateInput(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BD9 RID: 3033 RVA: 0x00034458 File Offset: 0x00032658
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 112617, RefRangeEnd = 112619, XrefRangeStart = 112617, XrefRangeEnd = 112617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x000344C4 File Offset: 0x000326C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112619, XrefRangeEnd = 112626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x00034558 File Offset: 0x00032758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112626, XrefRangeEnd = 112628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BDC RID: 3036 RVA: 0x0000652F File Offset: 0x0000472F
			public OnValidateInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000BDD RID: 3037 RVA: 0x00006538 File Offset: 0x00004738
			public static implicit operator InputField.OnValidateInput(Func<string, int, char, char> A_0)
			{
				return DelegateSupport.ConvertDelegate<InputField.OnValidateInput>(A_0);
			}

			// Token: 0x06000BDE RID: 3038 RVA: 0x00006540 File Offset: 0x00004740
			public static InputField.OnValidateInput operator +(InputField.OnValidateInput A_0, InputField.OnValidateInput A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<InputField.OnValidateInput>();
			}

			// Token: 0x06000BDF RID: 3039 RVA: 0x0000654E File Offset: 0x0000474E
			public static InputField.OnValidateInput operator -(InputField.OnValidateInput A_0, InputField.OnValidateInput A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<InputField.OnValidateInput>();
				}
				return delegate2;
			}

			// Token: 0x0400091F RID: 2335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000920 RID: 2336
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0;

			// Token: 0x04000921 RID: 2337
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0;

			// Token: 0x04000922 RID: 2338
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0;
		}

		// Token: 0x0200008F RID: 143
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x06000BE0 RID: 3040 RVA: 0x0000655F File Offset: 0x0000475F
			// Note: this type is marked as 'beforefieldinit'.
			static SubmitEvent()
			{
				Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "SubmitEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr);
				InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr, 100664995);
			}

			// Token: 0x06000BE1 RID: 3041 RVA: 0x000345A8 File Offset: 0x000327A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112631, RefRangeEnd = 112632, XrefRangeStart = 112628, XrefRangeEnd = 112631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubmitEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BE2 RID: 3042 RVA: 0x00006593 File Offset: 0x00004793
			public SubmitEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000923 RID: 2339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000090 RID: 144
		[Serializable]
		public class EndEditEvent : UnityEvent<string>
		{
			// Token: 0x06000BE3 RID: 3043 RVA: 0x0000659C File Offset: 0x0000479C
			// Note: this type is marked as 'beforefieldinit'.
			static EndEditEvent()
			{
				Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "EndEditEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr);
				InputField.EndEditEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr, 100664996);
			}

			// Token: 0x06000BE4 RID: 3044 RVA: 0x000345E4 File Offset: 0x000327E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112635, RefRangeEnd = 112636, XrefRangeStart = 112632, XrefRangeEnd = 112635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndEditEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.EndEditEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BE5 RID: 3045 RVA: 0x000065D0 File Offset: 0x000047D0
			public EndEditEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000924 RID: 2340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000091 RID: 145
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000BE6 RID: 3046 RVA: 0x000065D9 File Offset: 0x000047D9
			// Note: this type is marked as 'beforefieldinit'.
			static OnChangeEvent()
			{
				Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "OnChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr);
				InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr, 100664997);
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x00034620 File Offset: 0x00032820
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112639, RefRangeEnd = 112640, XrefRangeStart = 112636, XrefRangeEnd = 112639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x0000660D File Offset: 0x0000480D
			public OnChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000925 RID: 2341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000092 RID: 146
		public enum EditState
		{
			// Token: 0x04000927 RID: 2343
			Continue,
			// Token: 0x04000928 RID: 2344
			Finish
		}

		// Token: 0x02000093 RID: 147
		[ObfuscatedName("UnityEngine.UI.InputField+<CaretBlink>d__166")]
		public sealed class _CaretBlink_d__166 : Object
		{
			// Token: 0x06000BE9 RID: 3049 RVA: 0x0003465C File Offset: 0x0003285C
			// Note: this type is marked as 'beforefieldinit'.
			static _CaretBlink_d__166()
			{
				Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "<CaretBlink>d__166");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr);
				InputField._CaretBlink_d__166.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, "<>1__state");
				InputField._CaretBlink_d__166.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, "<>2__current");
				InputField._CaretBlink_d__166.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, "<>4__this");
				InputField._CaretBlink_d__166.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100664998);
				InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100664999);
				InputField._CaretBlink_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100665000);
				InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100665001);
				InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100665002);
				InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr, 100665003);
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x0003473C File Offset: 0x0003293C
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaretBlink_d__166(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField._CaretBlink_d__166>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x00034784 File Offset: 0x00032984
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BEC RID: 3052 RVA: 0x000347B8 File Offset: 0x000329B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112640, XrefRangeEnd = 112644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000BED RID: 3053 RVA: 0x000347F4 File Offset: 0x000329F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BEE RID: 3054 RVA: 0x00034834 File Offset: 0x00032A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112644, XrefRangeEnd = 112649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00034868 File Offset: 0x00032A68
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BF0 RID: 3056 RVA: 0x00006616 File Offset: 0x00004816
			public _CaretBlink_d__166(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000348A8 File Offset: 0x00032AA8
			// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0000661F File Offset: 0x0000481F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000348D0 File Offset: 0x00032AD0
			// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0000663A File Offset: 0x0000483A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00034900 File Offset: 0x00032B00
			// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00006659 File Offset: 0x00004859
			public unsafe InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__166.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000929 RID: 2345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400092A RID: 2346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400092B RID: 2347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400092C RID: 2348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400092D RID: 2349
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400092E RID: 2350
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400092F RID: 2351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000930 RID: 2352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000931 RID: 2353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000094 RID: 148
		[ObfuscatedName("UnityEngine.UI.InputField+<MouseDragOutsideRect>d__186")]
		public sealed class _MouseDragOutsideRect_d__186 : Object
		{
			// Token: 0x06000BF7 RID: 3063 RVA: 0x00034930 File Offset: 0x00032B30
			// Note: this type is marked as 'beforefieldinit'.
			static _MouseDragOutsideRect_d__186()
			{
				Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "<MouseDragOutsideRect>d__186");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr);
				InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, "<>1__state");
				InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, "<>2__current");
				InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, "eventData");
				InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, "<>4__this");
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665004);
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665005);
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665006);
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665007);
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665008);
				InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr, 100665009);
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x00034A24 File Offset: 0x00032C24
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MouseDragOutsideRect_d__186(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__186>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00034A6C File Offset: 0x00032C6C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00034AA0 File Offset: 0x00032CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112649, XrefRangeEnd = 112679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00034ADC File Offset: 0x00032CDC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x00034B1C File Offset: 0x00032D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112679, XrefRangeEnd = 112684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00034B50 File Offset: 0x00032D50
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x00006678 File Offset: 0x00004878
			public _MouseDragOutsideRect_d__186(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00034B90 File Offset: 0x00032D90
			// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00006681 File Offset: 0x00004881
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00034BB8 File Offset: 0x00032DB8
			// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0000669C File Offset: 0x0000489C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00034BE8 File Offset: 0x00032DE8
			// (set) Token: 0x06000C04 RID: 3076 RVA: 0x000066BB File Offset: 0x000048BB
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00034C18 File Offset: 0x00032E18
			// (set) Token: 0x06000C06 RID: 3078 RVA: 0x000066DA File Offset: 0x000048DA
			public unsafe InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__186.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000932 RID: 2354
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000933 RID: 2355
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000934 RID: 2356
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x04000935 RID: 2357
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000936 RID: 2358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000937 RID: 2359
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000938 RID: 2360
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000939 RID: 2361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400093A RID: 2362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400093B RID: 2363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
