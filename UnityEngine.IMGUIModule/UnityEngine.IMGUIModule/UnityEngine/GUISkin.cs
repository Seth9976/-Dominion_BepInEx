using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		// Note: this type is marked as 'beforefieldinit'.
		static GUISkin()
		{
			Il2CppClassPointerStore<GUISkin>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISkin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISkin>.NativeClassPtr);
			GUISkin.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Font");
			GUISkin.NativeFieldInfoPtr_m_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_box");
			GUISkin.NativeFieldInfoPtr_m_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_button");
			GUISkin.NativeFieldInfoPtr_m_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_toggle");
			GUISkin.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_label");
			GUISkin.NativeFieldInfoPtr_m_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textField");
			GUISkin.NativeFieldInfoPtr_m_textArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textArea");
			GUISkin.NativeFieldInfoPtr_m_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_window");
			GUISkin.NativeFieldInfoPtr_m_horizontalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSlider");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_verticalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSlider");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_SliderMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SliderMixed");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarLeftButton");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarRightButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarUpButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarDownButton");
			GUISkin.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_ScrollView");
			GUISkin.NativeFieldInfoPtr_m_CustomStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_CustomStyles");
			GUISkin.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Settings");
			GUISkin.NativeFieldInfoPtr_ms_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "ms_Error");
			GUISkin.NativeFieldInfoPtr_m_Styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Styles");
			GUISkin.NativeFieldInfoPtr_m_SkinChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SkinChanged");
			GUISkin.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "current");
			GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663486);
			GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663487);
			GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663488);
			GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663489);
			GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663490);
			GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663491);
			GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663492);
			GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663493);
			GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663494);
			GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663495);
			GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663496);
			GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663497);
			GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663498);
			GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663499);
			GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663500);
			GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663501);
			GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663502);
			GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663503);
			GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663504);
			GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663505);
			GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663506);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663507);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663508);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663509);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663510);
			GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663511);
			GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663512);
			GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663513);
			GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663514);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663515);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663516);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663517);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663518);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663519);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663520);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663521);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663522);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663523);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663524);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663525);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663526);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663527);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663528);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663529);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663530);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663531);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663532);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663533);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663534);
			GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663535);
			GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663536);
			GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663537);
			GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663538);
			GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663539);
			GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663540);
			GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663541);
			GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663542);
			GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663543);
			GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663544);
			GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663545);
			GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663546);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86575, XrefRangeEnd = 86585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUISkin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000CA30 File Offset: 0x0000AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86585, XrefRangeEnd = 86586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000CA64 File Offset: 0x0000AC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86586, XrefRangeEnd = 86589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRoots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000CACC File Offset: 0x0000ACCC
		public unsafe Font font
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86589, XrefRangeEnd = 86601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000CB10 File Offset: 0x0000AD10
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000CB50 File Offset: 0x0000AD50
		public unsafe GUIStyle box
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86601, XrefRangeEnd = 86602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000CB94 File Offset: 0x0000AD94
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public unsafe GUIStyle label
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86602, XrefRangeEnd = 86603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000CC18 File Offset: 0x0000AE18
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000CC58 File Offset: 0x0000AE58
		public unsafe GUIStyle textField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86603, XrefRangeEnd = 86604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000CC9C File Offset: 0x0000AE9C
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public unsafe GUIStyle textArea
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86604, RefRangeEnd = 86605, XrefRangeStart = 86604, XrefRangeEnd = 86604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86605, XrefRangeEnd = 86606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000CD20 File Offset: 0x0000AF20
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000CD60 File Offset: 0x0000AF60
		public unsafe GUIStyle button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86606, XrefRangeEnd = 86607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		public unsafe GUIStyle toggle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80229, RefRangeEnd = 80231, XrefRangeStart = 80229, XrefRangeEnd = 80231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86607, XrefRangeEnd = 86608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000CE28 File Offset: 0x0000B028
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000CE68 File Offset: 0x0000B068
		public unsafe GUIStyle window
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86608, XrefRangeEnd = 86609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public unsafe GUIStyle horizontalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86609, XrefRangeEnd = 86610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000CF30 File Offset: 0x0000B130
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000CF70 File Offset: 0x0000B170
		public unsafe GUIStyle horizontalSliderThumb
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86610, RefRangeEnd = 86612, XrefRangeStart = 86610, XrefRangeEnd = 86610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86612, XrefRangeEnd = 86613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		public unsafe GUIStyle horizontalSliderThumbExtent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86613, XrefRangeEnd = 86614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000D038 File Offset: 0x0000B238
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000D078 File Offset: 0x0000B278
		public unsafe GUIStyle sliderMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86614, XrefRangeEnd = 86615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public unsafe GUIStyle verticalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86615, XrefRangeEnd = 86616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000D140 File Offset: 0x0000B340
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000D180 File Offset: 0x0000B380
		public unsafe GUIStyle verticalSliderThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86616, XrefRangeEnd = 86617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000D204 File Offset: 0x0000B404
		public unsafe GUIStyle verticalSliderThumbExtent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86617, XrefRangeEnd = 86618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000D288 File Offset: 0x0000B488
		public unsafe GUIStyle horizontalScrollbar
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86618, RefRangeEnd = 86620, XrefRangeStart = 86618, XrefRangeEnd = 86618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86620, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000D2CC File Offset: 0x0000B4CC
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000D30C File Offset: 0x0000B50C
		public unsafe GUIStyle horizontalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86621, XrefRangeEnd = 86622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000D350 File Offset: 0x0000B550
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000D390 File Offset: 0x0000B590
		public unsafe GUIStyle horizontalScrollbarLeftButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86622, XrefRangeEnd = 86623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0000D414 File Offset: 0x0000B614
		public unsafe GUIStyle horizontalScrollbarRightButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86623, XrefRangeEnd = 86624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000D458 File Offset: 0x0000B658
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0000D498 File Offset: 0x0000B698
		public unsafe GUIStyle verticalScrollbar
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86624, RefRangeEnd = 86628, XrefRangeStart = 86624, XrefRangeEnd = 86624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86628, XrefRangeEnd = 86629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000D51C File Offset: 0x0000B71C
		public unsafe GUIStyle verticalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86629, XrefRangeEnd = 86630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000D560 File Offset: 0x0000B760
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		public unsafe GUIStyle verticalScrollbarUpButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86630, XrefRangeEnd = 86631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000D624 File Offset: 0x0000B824
		public unsafe GUIStyle verticalScrollbarDownButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86631, XrefRangeEnd = 86632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000D668 File Offset: 0x0000B868
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public unsafe GUIStyle scrollView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86632, XrefRangeEnd = 86633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000D72C File Offset: 0x0000B92C
		public unsafe Il2CppReferenceArray<GUIStyle> customStyles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86633, XrefRangeEnd = 86634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000D770 File Offset: 0x0000B970
		public unsafe GUISettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		public unsafe static GUIStyle error
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 86647, RefRangeEnd = 86650, XrefRangeStart = 86634, XrefRangeEnd = 86647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 86657, RefRangeEnd = 86683, XrefRangeStart = 86650, XrefRangeEnd = 86657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000D818 File Offset: 0x0000BA18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 86975, RefRangeEnd = 86979, XrefRangeStart = 86683, XrefRangeEnd = 86975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildStyleCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000D84C File Offset: 0x0000BA4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 87021, RefRangeEnd = 87027, XrefRangeStart = 86979, XrefRangeEnd = 87021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle GetStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000D89C File Offset: 0x0000BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87027, XrefRangeEnd = 87031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle FindStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000D8EC File Offset: 0x0000BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87031, XrefRangeEnd = 87040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000D920 File Offset: 0x0000BB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87040, XrefRangeEnd = 87050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000031B4 File Offset: 0x000013B4
		public GUISkin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000D960 File Offset: 0x0000BB60
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000031BD File Offset: 0x000013BD
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000D990 File Offset: 0x0000BB90
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000031DC File Offset: 0x000013DC
		public unsafe GUIStyle m_box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000031FB File Offset: 0x000013FB
		public unsafe GUIStyle m_button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000321A File Offset: 0x0000141A
		public unsafe GUIStyle m_toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000DA20 File Offset: 0x0000BC20
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003239 File Offset: 0x00001439
		public unsafe GUIStyle m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000DA50 File Offset: 0x0000BC50
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe GUIStyle m_textField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000DA80 File Offset: 0x0000BC80
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003277 File Offset: 0x00001477
		public unsafe GUIStyle m_textArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00003296 File Offset: 0x00001496
		public unsafe GUIStyle m_window
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000032B5 File Offset: 0x000014B5
		public unsafe GUIStyle m_horizontalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000DB10 File Offset: 0x0000BD10
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000032D4 File Offset: 0x000014D4
		public unsafe GUIStyle m_horizontalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000DB40 File Offset: 0x0000BD40
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000032F3 File Offset: 0x000014F3
		public unsafe GUIStyle m_horizontalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000DB70 File Offset: 0x0000BD70
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003312 File Offset: 0x00001512
		public unsafe GUIStyle m_verticalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003331 File Offset: 0x00001531
		public unsafe GUIStyle m_verticalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003350 File Offset: 0x00001550
		public unsafe GUIStyle m_verticalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000DC00 File Offset: 0x0000BE00
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000336F File Offset: 0x0000156F
		public unsafe GUIStyle m_SliderMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000DC30 File Offset: 0x0000BE30
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000338E File Offset: 0x0000158E
		public unsafe GUIStyle m_horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000DC60 File Offset: 0x0000BE60
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000033AD File Offset: 0x000015AD
		public unsafe GUIStyle m_horizontalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000DC90 File Offset: 0x0000BE90
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000033CC File Offset: 0x000015CC
		public unsafe GUIStyle m_horizontalScrollbarLeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000033EB File Offset: 0x000015EB
		public unsafe GUIStyle m_horizontalScrollbarRightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000340A File Offset: 0x0000160A
		public unsafe GUIStyle m_verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000DD20 File Offset: 0x0000BF20
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003429 File Offset: 0x00001629
		public unsafe GUIStyle m_verticalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000DD50 File Offset: 0x0000BF50
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003448 File Offset: 0x00001648
		public unsafe GUIStyle m_verticalScrollbarUpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000DD80 File Offset: 0x0000BF80
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003467 File Offset: 0x00001667
		public unsafe GUIStyle m_verticalScrollbarDownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003486 File Offset: 0x00001686
		public unsafe GUIStyle m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000034A5 File Offset: 0x000016A5
		public unsafe Il2CppReferenceArray<GUIStyle> m_CustomStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000DE10 File Offset: 0x0000C010
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000034C4 File Offset: 0x000016C4
		public unsafe GUISettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000DE40 File Offset: 0x0000C040
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000034E3 File Offset: 0x000016E3
		public unsafe static GUIStyle ms_Error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_ms_Error, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_ms_Error, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000DE68 File Offset: 0x0000C068
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000034F5 File Offset: 0x000016F5
		public unsafe Dictionary<string, GUIStyle> m_Styles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000DE98 File Offset: 0x0000C098
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003514 File Offset: 0x00001714
		public unsafe static GUISkin.SkinChangedDelegate m_SkinChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin.SkinChangedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00003526 File Offset: 0x00001726
		public unsafe static GUISkin current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_m_box;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_m_button;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_m_toggle;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_m_textField;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_m_textArea;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_window;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSlider;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumb;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumbExtent;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSlider;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumb;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumbExtent;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderMixed;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbar;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarThumb;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarLeftButton;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarRightButton;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbar;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarThumb;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarUpButton;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarDownButton;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomStyles;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_ms_Error;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_Styles;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_SkinChanged;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Internal_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_BuildStyleCache_Private_Void_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Internal_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x0200006B RID: 107
		public sealed class SkinChangedDelegate : MulticastDelegate
		{
			// Token: 0x0600069F RID: 1695 RVA: 0x00004B67 File Offset: 0x00002D67
			// Note: this type is marked as 'beforefieldinit'.
			static SkinChangedDelegate()
			{
				Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "SkinChangedDelegate");
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663547);
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663548);
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x0001724C File Offset: 0x0001544C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkinChangedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x000172A8 File Offset: 0x000154A8
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x00004BA5 File Offset: 0x00002DA5
			public SkinChangedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x00004BAE File Offset: 0x00002DAE
			public static implicit operator GUISkin.SkinChangedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<GUISkin.SkinChangedDelegate>(A_0);
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00004BB6 File Offset: 0x00002DB6
			public static GUISkin.SkinChangedDelegate operator +(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GUISkin.SkinChangedDelegate>();
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00004BC4 File Offset: 0x00002DC4
			public static GUISkin.SkinChangedDelegate operator -(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GUISkin.SkinChangedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000366 RID: 870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000367 RID: 871
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
