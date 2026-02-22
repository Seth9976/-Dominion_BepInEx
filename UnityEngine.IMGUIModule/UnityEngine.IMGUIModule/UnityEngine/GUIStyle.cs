using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public sealed class GUIStyle : Object
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyle()
		{
			Il2CppClassPointerStore<GUIStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr);
			GUIStyle.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Ptr");
			GUIStyle.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Normal");
			GUIStyle.NativeFieldInfoPtr_m_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Hover");
			GUIStyle.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Active");
			GUIStyle.NativeFieldInfoPtr_m_Focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Focused");
			GUIStyle.NativeFieldInfoPtr_m_OnNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnNormal");
			GUIStyle.NativeFieldInfoPtr_m_OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnHover");
			GUIStyle.NativeFieldInfoPtr_m_OnActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnActive");
			GUIStyle.NativeFieldInfoPtr_m_OnFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnFocused");
			GUIStyle.NativeFieldInfoPtr_m_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Border");
			GUIStyle.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Padding");
			GUIStyle.NativeFieldInfoPtr_m_Margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Margin");
			GUIStyle.NativeFieldInfoPtr_m_Overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Overflow");
			GUIStyle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Name");
			GUIStyle.NativeFieldInfoPtr_showKeyboardFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "showKeyboardFocus");
			GUIStyle.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "s_None");
			GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663559);
			GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663560);
			GUIStyle.NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663561);
			GUIStyle.NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663562);
			GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663563);
			GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663564);
			GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663565);
			GUIStyle.NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663566);
			GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663567);
			GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663568);
			GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663569);
			GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663570);
			GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663571);
			GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663572);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663573);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663574);
			GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663575);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663576);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663577);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663578);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663579);
			GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663580);
			GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663581);
			GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663582);
			GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663583);
			GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663584);
			GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663585);
			GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663586);
			GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663587);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663588);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663589);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663590);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663591);
			GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663592);
			GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663593);
			GUIStyle.NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663594);
			GUIStyle.NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663595);
			GUIStyle.NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663596);
			GUIStyle.NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663597);
			GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663598);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663600);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663601);
			GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663602);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663603);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663604);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663605);
			GUIStyle.get_fontDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontDelegate>("UnityEngine.GUIStyle::get_font");
			GUIStyle.set_fontDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fontDelegate>("UnityEngine.GUIStyle::set_font");
			GUIStyle.set_imagePositionDelegateField = IL2CPP.ResolveICall<GUIStyle.set_imagePositionDelegate>("UnityEngine.GUIStyle::set_imagePosition");
			GUIStyle.get_alignmentDelegateField = IL2CPP.ResolveICall<GUIStyle.get_alignmentDelegate>("UnityEngine.GUIStyle::get_alignment");
			GUIStyle.set_alignmentDelegateField = IL2CPP.ResolveICall<GUIStyle.set_alignmentDelegate>("UnityEngine.GUIStyle::set_alignment");
			GUIStyle.set_wordWrapDelegateField = IL2CPP.ResolveICall<GUIStyle.set_wordWrapDelegate>("UnityEngine.GUIStyle::set_wordWrap");
			GUIStyle.get_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clippingDelegate>("UnityEngine.GUIStyle::get_clipping");
			GUIStyle.set_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clippingDelegate>("UnityEngine.GUIStyle::set_clipping");
			GUIStyle.set_fixedWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedWidthDelegate>("UnityEngine.GUIStyle::set_fixedWidth");
			GUIStyle.set_fixedHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedHeightDelegate>("UnityEngine.GUIStyle::set_fixedHeight");
			GUIStyle.get_fontSizeDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontSizeDelegate>("UnityEngine.GUIStyle::get_fontSize");
			GUIStyle.set_fontSizeDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fontSizeDelegate>("UnityEngine.GUIStyle::set_fontSize");
			GUIStyle.get_fontStyleDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontStyleDelegate>("UnityEngine.GUIStyle::get_fontStyle");
			GUIStyle.set_fontStyleDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fontStyleDelegate>("UnityEngine.GUIStyle::set_fontStyle");
			GUIStyle.get_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.get_richTextDelegate>("UnityEngine.GUIStyle::get_richText");
			GUIStyle.set_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.set_richTextDelegate>("UnityEngine.GUIStyle::set_richText");
			GUIStyle.Internal_CopyDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CopyDelegate>("UnityEngine.GUIStyle::Internal_Copy");
			GUIStyle.AssignStyleStateDelegateField = IL2CPP.ResolveICall<GUIStyle.AssignStyleStateDelegate>("UnityEngine.GUIStyle::AssignStyleState");
			GUIStyle.AssignRectOffsetDelegateField = IL2CPP.ResolveICall<GUIStyle.AssignRectOffsetDelegate>("UnityEngine.GUIStyle::AssignRectOffset");
			GUIStyle.Internal_GetLineHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetLineHeightDelegate>("UnityEngine.GUIStyle::Internal_GetLineHeight");
			GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate>("UnityEngine.GUIStyle::Internal_GetNumCharactersThatFitWithinWidth");
			GUIStyle.Internal_GetCursorFlashOffsetDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorFlashOffsetDelegate>("UnityEngine.GUIStyle::Internal_GetCursorFlashOffset");
			GUIStyle.get_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_contentOffset_Injected");
			GUIStyle.set_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_contentOffset_Injected");
			GUIStyle.get_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_clipOffset_Injected");
			GUIStyle.set_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_clipOffset_Injected");
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_Internal_clipOffset_Injected");
			GUIStyle.set_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_Internal_clipOffset_Injected");
			GUIStyle.Internal_DrawCursor_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_DrawCursor_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawCursor_Injected");
			GUIStyle.Internal_DrawWithTextSelection_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_DrawWithTextSelection_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected");
			GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected");
			GUIStyle.Internal_GetCursorStringIndex_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorStringIndex_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected");
			GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetHyperlinksRect_Injected");
			GUIStyle.Internal_CalcSize_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CalcSize_InjectedDelegate>("UnityEngine.GUIStyle::Internal_CalcSize_Injected");
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000EB10 File Offset: 0x0000CD10
		public unsafe string rawName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87086, XrefRangeEnd = 87088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87088, XrefRangeEnd = 87090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000EB54 File Offset: 0x0000CD54
		// (set) Token: 0x060003BC RID: 956 RVA: 0x000037BE File Offset: 0x000019BE
		public unsafe ImagePosition imagePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87090, XrefRangeEnd = 87092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_imagePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000EB90 File Offset: 0x0000CD90
		// (set) Token: 0x060003BF RID: 959 RVA: 0x000037F6 File Offset: 0x000019F6
		public unsafe bool wordWrap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87092, XrefRangeEnd = 87094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_wordWrapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003838 File Offset: 0x00001A38
		public unsafe float fixedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87094, XrefRangeEnd = 87096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000EC08 File Offset: 0x0000CE08
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0000384B File Offset: 0x00001A4B
		public unsafe float fixedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87096, XrefRangeEnd = 87098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000EC44 File Offset: 0x0000CE44
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000EC80 File Offset: 0x0000CE80
		public unsafe bool stretchWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87098, XrefRangeEnd = 87100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87100, XrefRangeEnd = 87102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000ECFC File Offset: 0x0000CEFC
		public unsafe bool stretchHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87102, XrefRangeEnd = 87104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87104, XrefRangeEnd = 87106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000ED3C File Offset: 0x0000CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87106, XrefRangeEnd = 87108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(GUIStyle self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000ED80 File Offset: 0x0000CF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87108, XrefRangeEnd = 87110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87110, XrefRangeEnd = 87112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetStyleStatePtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000EE00 File Offset: 0x0000D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87112, XrefRangeEnd = 87114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetRectOffsetPtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000EE4C File Offset: 0x0000D04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87114, XrefRangeEnd = 87116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87116, XrefRangeEnd = 87118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000EF40 File Offset: 0x0000D140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87118, XrefRangeEnd = 87120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87120, XrefRangeEnd = 87122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000F010 File Offset: 0x0000D210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87122, XrefRangeEnd = 87124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Internal_CalcHeight(GUIContent content, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000F06C File Offset: 0x0000D26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87124, XrefRangeEnd = 87126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87126, XrefRangeEnd = 87131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000F100 File Offset: 0x0000D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87131, XrefRangeEnd = 87133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFont(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000F138 File Offset: 0x0000D338
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 87139, RefRangeEnd = 87163, XrefRangeStart = 87133, XrefRangeEnd = 87139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000F174 File Offset: 0x0000D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87163, XrefRangeEnd = 87173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		public unsafe string name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87175, RefRangeEnd = 87176, XrefRangeStart = 87173, XrefRangeEnd = 87175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87176, XrefRangeEnd = 87178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000F224 File Offset: 0x0000D424
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00003982 File Offset: 0x00001B82
		public unsafe GUIStyleState normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87178, XrefRangeEnd = 87184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
			}
			set
			{
				this.AssignStyleState(0, value.m_Ptr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000F264 File Offset: 0x0000D464
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003A1B File Offset: 0x00001C1B
		public unsafe RectOffset margin
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 87190, RefRangeEnd = 87207, XrefRangeStart = 87184, XrefRangeEnd = 87190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(1, value.m_Ptr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003A2C File Offset: 0x00001C2C
		public unsafe RectOffset padding
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 87213, RefRangeEnd = 87223, XrefRangeStart = 87207, XrefRangeEnd = 87213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(2, value.m_Ptr);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87223, XrefRangeEnd = 87229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000F35C File Offset: 0x0000D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87229, XrefRangeEnd = 87231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87231, XrefRangeEnd = 87233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000F444 File Offset: 0x0000D644
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 87245, RefRangeEnd = 87250, XrefRangeStart = 87233, XrefRangeEnd = 87245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hover;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87252, RefRangeEnd = 87253, XrefRangeStart = 87250, XrefRangeEnd = 87252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000F558 File Offset: 0x0000D758
		public unsafe static GUIStyle none
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 87262, RefRangeEnd = 87286, XrefRangeStart = 87253, XrefRangeEnd = 87262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000F58C File Offset: 0x0000D78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalcHeight(GUIContent content, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000F644 File Offset: 0x0000D844
		public unsafe bool isHeightDependantOnWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87286, XrefRangeEnd = 87292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000F680 File Offset: 0x0000D880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87292, XrefRangeEnd = 87294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87294, XrefRangeEnd = 87310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000F718 File Offset: 0x0000D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87310, XrefRangeEnd = 87312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87312, XrefRangeEnd = 87314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000F80C File Offset: 0x0000DA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87314, XrefRangeEnd = 87316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000F880 File Offset: 0x0000DA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87316, XrefRangeEnd = 87318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87318, XrefRangeEnd = 87320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000F930 File Offset: 0x0000DB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87320, XrefRangeEnd = 87322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000035CF File Offset: 0x000017CF
		public GUIStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000F974 File Offset: 0x0000DB74
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000035D8 File Offset: 0x000017D8
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000F99C File Offset: 0x0000DB9C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000035F3 File Offset: 0x000017F3
		public unsafe GUIStyleState m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000F9CC File Offset: 0x0000DBCC
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00003612 File Offset: 0x00001812
		public unsafe GUIStyleState m_Hover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003631 File Offset: 0x00001831
		public unsafe GUIStyleState m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003650 File Offset: 0x00001850
		public unsafe GUIStyleState m_Focused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000366F File Offset: 0x0000186F
		public unsafe GUIStyleState m_OnNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000FA8C File Offset: 0x0000DC8C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000368E File Offset: 0x0000188E
		public unsafe GUIStyleState m_OnHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000FABC File Offset: 0x0000DCBC
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x000036AD File Offset: 0x000018AD
		public unsafe GUIStyleState m_OnActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x000036CC File Offset: 0x000018CC
		public unsafe GUIStyleState m_OnFocused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000FB1C File Offset: 0x0000DD1C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x000036EB File Offset: 0x000018EB
		public unsafe RectOffset m_Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000370A File Offset: 0x0000190A
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00003729 File Offset: 0x00001929
		public unsafe RectOffset m_Margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe RectOffset m_Overflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00003767 File Offset: 0x00001967
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000FC04 File Offset: 0x0000DE04
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00003786 File Offset: 0x00001986
		public unsafe static bool showKeyboardFocus
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000FC20 File Offset: 0x0000DE20
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003794 File Offset: 0x00001994
		public unsafe static GUIStyle s_None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000FC48 File Offset: 0x0000DE48
		// (set) Token: 0x060003BB RID: 955 RVA: 0x000037A6 File Offset: 0x000019A6
		public Font font
		{
			get
			{
				IntPtr intPtr = GUIStyle.get_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				GUIStyle.set_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003BD RID: 957 RVA: 0x000037D1 File Offset: 0x000019D1
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000037E3 File Offset: 0x000019E3
		public TextAnchor alignment
		{
			get
			{
				return GUIStyle.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00003809 File Offset: 0x00001A09
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000381B File Offset: 0x00001A1B
		public TextClipping clipping
		{
			get
			{
				return GUIStyle.get_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000FC74 File Offset: 0x0000DE74
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000382E File Offset: 0x00001A2E
		public Vector2 contentOffset
		{
			get
			{
				Vector2 vector;
				this.get_contentOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_contentOffset_Injected(ref value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000385E File Offset: 0x00001A5E
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003870 File Offset: 0x00001A70
		public int fontSize
		{
			get
			{
				return GUIStyle.get_fontSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_fontSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00003883 File Offset: 0x00001A83
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003895 File Offset: 0x00001A95
		public FontStyle fontStyle
		{
			get
			{
				return GUIStyle.get_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000038A8 File Offset: 0x00001AA8
		// (set) Token: 0x060003CB RID: 971 RVA: 0x000038BA File Offset: 0x00001ABA
		public bool richText
		{
			get
			{
				return GUIStyle.get_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000038CD File Offset: 0x00001ACD
		public Vector2 clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_clipOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_clipOffset_Injected(ref value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000038D7 File Offset: 0x00001AD7
		public Vector2 Internal_clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_Internal_clipOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_Internal_clipOffset_Injected(ref value);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000038E1 File Offset: 0x00001AE1
		public static IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
		{
			return GUIStyle.Internal_CopyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(other));
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000038F9 File Offset: 0x00001AF9
		public void AssignStyleState(int idx, IntPtr srcStyleState)
		{
			GUIStyle.AssignStyleStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), idx, srcStyleState);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000390D File Offset: 0x00001B0D
		public void AssignRectOffset(int idx, IntPtr srcRectOffset)
		{
			GUIStyle.AssignRectOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), idx, srcRectOffset);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003921 File Offset: 0x00001B21
		public static float Internal_GetLineHeight(IntPtr target)
		{
			return GUIStyle.Internal_GetLineHeightDelegateField(target);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000392E File Offset: 0x00001B2E
		public void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
		{
			this.Internal_DrawCursor_Injected(ref position, content, pos, ref cursorColor);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000FCBC File Offset: 0x0000DEBC
		public void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
		{
			this.Internal_DrawWithTextSelection_Injected(ref screenRect, content, isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, cursorLast, ref cursorColor, ref selectionColor);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
		public Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			Vector2 vector;
			this.Internal_GetCursorPixelPosition_Injected(ref position, content, cursorStringIndex, out vector);
			return vector;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000393C File Offset: 0x00001B3C
		public int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return this.Internal_GetCursorStringIndex_Injected(ref position, content, ref cursorPixelPosition);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00003949 File Offset: 0x00001B49
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect(Rect localPosition, GUIContent mContent)
		{
			return this.Internal_GetHyperlinksRect_Injected(ref localPosition, mContent);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003954 File Offset: 0x00001B54
		public int Internal_GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(text), width);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000FD00 File Offset: 0x0000DF00
		public Vector2 Internal_CalcSize(GUIContent content)
		{
			Vector2 vector;
			this.Internal_CalcSize_Injected(content, out vector);
			return vector;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000396D File Offset: 0x00001B6D
		public static float Internal_GetCursorFlashOffset()
		{
			return GUIStyle.Internal_GetCursorFlashOffsetDelegateField();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003979 File Offset: 0x00001B79
		public static void CleanupRoots()
		{
			GUIStyle.s_None = null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000FD18 File Offset: 0x0000DF18
		public void InternalOnAfterDeserialize()
		{
			this.m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(0));
			this.m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(1));
			this.m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(2));
			this.m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(3));
			this.m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(4));
			this.m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(5));
			this.m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(6));
			this.m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(7));
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003993 File Offset: 0x00001B93
		public GUIStyleState hover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Hover) == null)
				{
					guistyleState = (this.m_Hover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(1)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(1, value.m_Ptr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000039A4 File Offset: 0x00001BA4
		public GUIStyleState active
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Active) == null)
				{
					guistyleState = (this.m_Active = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(2)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(2, value.m_Ptr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000FE28 File Offset: 0x0000E028
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000039B5 File Offset: 0x00001BB5
		public GUIStyleState onNormal
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnNormal) == null)
				{
					guistyleState = (this.m_OnNormal = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(4)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(4, value.m_Ptr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000039C6 File Offset: 0x00001BC6
		public GUIStyleState onHover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnHover) == null)
				{
					guistyleState = (this.m_OnHover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(5)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(5, value.m_Ptr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000FE90 File Offset: 0x0000E090
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000039D7 File Offset: 0x00001BD7
		public GUIStyleState onActive
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnActive) == null)
				{
					guistyleState = (this.m_OnActive = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(6)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(6, value.m_Ptr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000FEC4 File Offset: 0x0000E0C4
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000039E8 File Offset: 0x00001BE8
		public GUIStyleState focused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Focused) == null)
				{
					guistyleState = (this.m_Focused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(3)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(3, value.m_Ptr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x000039F9 File Offset: 0x00001BF9
		public GUIStyleState onFocused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnFocused) == null)
				{
					guistyleState = (this.m_OnFocused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(7)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(7, value.m_Ptr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000FF2C File Offset: 0x0000E12C
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003A0A File Offset: 0x00001C0A
		public RectOffset border
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Border) == null)
				{
					rectOffset = (this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(0, value.m_Ptr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003A3D File Offset: 0x00001C3D
		public RectOffset overflow
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Overflow) == null)
				{
					rectOffset = (this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(3, value.m_Ptr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00003A4E File Offset: 0x00001C4E
		public float lineHeight
		{
			get
			{
				return Mathf.Round(GUIStyle.Internal_GetLineHeight(this.m_Ptr));
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003A60 File Offset: 0x00001C60
		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(text), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003A79 File Offset: 0x00001C79
		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(image), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003A92 File Offset: 0x00001C92
		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			this.Draw(position, content, controlID, false, false, on, false);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000FF94 File Offset: 0x0000E194
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
		{
			Event current = Event.current;
			bool flag = current.type == EventType.Repaint;
			if (flag)
			{
				Color cursorColor = new Color(0f, 0f, 0f, 0f);
				float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
				float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
				bool flag2 = cursorFlashSpeed == 0f || num < 0.5f;
				if (flag2)
				{
					cursorColor = GUI.skin.settings.cursorColor;
				}
				this.Internal_DrawCursor(position, content, character, cursorColor);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001002C File Offset: 0x0000E22C
		public void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
		{
			Color cursorColor = new Color(0f, 0f, 0f, 0f);
			float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			bool flag = cursorFlashSpeed == 0f || num < 0.5f;
			if (flag)
			{
				cursorColor = GUI.skin.settings.cursorColor;
			}
			bool flag2 = position.Contains(Event.current.mousePosition);
			this.Internal_DrawWithTextSelection(position, content, flag2, isActive, false, hasKeyboardFocus, drawSelectionAsComposition, firstSelectedCharacter, lastSelectedCharacter, cursorColor, selectionColor);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000100CC File Offset: 0x0000E2CC
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			this.DrawWithTextSelection(position, content, controlID == GUIUtility.hotControl, controlID == GUIUtility.keyboardControl && GUIStyle.showKeyboardFocus, firstSelectedCharacter, lastSelectedCharacter, drawSelectionAsComposition, GUI.skin.settings.selectionColor);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00010110 File Offset: 0x0000E310
		public new static implicit operator GUIStyle(string str)
		{
			bool flag = GUISkin.current == null;
			GUIStyle guistyle;
			if (flag)
			{
				Debug.LogError("Unable to use a named GUIStyle without a current skin. Most likely you need to move your GUIStyle initialization code to OnGUI");
				guistyle = GUISkin.error;
			}
			else
			{
				guistyle = GUISkin.current.GetStyle(str);
			}
			return guistyle;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00010150 File Offset: 0x0000E350
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return this.Internal_GetCursorPixelPosition(position, content, cursorStringIndex);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001016C File Offset: 0x0000E36C
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return this.Internal_GetCursorStringIndex(position, content, cursorPixelPosition);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00010188 File Offset: 0x0000E388
		public int GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return this.Internal_GetNumCharactersThatFitWithinWidth(text, width);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000101A4 File Offset: 0x0000E3A4
		public Vector2 CalcSize(GUIContent content)
		{
			return this.Internal_CalcSize(content);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000101C0 File Offset: 0x0000E3C0
		public Vector2 CalcScreenSize(Vector2 contentSize)
		{
			return new Vector2((this.fixedWidth != 0f) ? this.fixedWidth : Mathf.Ceil(contentSize.x + (float)this.padding.left + (float)this.padding.right), (this.fixedHeight != 0f) ? this.fixedHeight : Mathf.Ceil(contentSize.y + (float)this.padding.top + (float)this.padding.bottom));
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003AB6 File Offset: 0x00001CB6
		public void get_contentOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_contentOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003AC9 File Offset: 0x00001CC9
		public void set_contentOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_contentOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003ADC File Offset: 0x00001CDC
		public void get_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003AEF File Offset: 0x00001CEF
		public void set_clipOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00003B02 File Offset: 0x00001D02
		public void get_Internal_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003B15 File Offset: 0x00001D15
		public void set_Internal_clipOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_Internal_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003B28 File Offset: 0x00001D28
		public void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor)
		{
			GUIStyle.Internal_DrawCursor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), pos, ref cursorColor);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001024C File Offset: 0x0000E44C
		public void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor)
		{
			GUIStyle.Internal_DrawWithTextSelection_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(content), isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, cursorLast, ref cursorColor, ref selectionColor);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00003B44 File Offset: 0x00001D44
		public void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), cursorStringIndex, out ret);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003B60 File Offset: 0x00001D60
		public int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition)
		{
			return GUIStyle.Internal_GetCursorStringIndex_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), ref cursorPixelPosition);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00010284 File Offset: 0x0000E484
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect_Injected(ref Rect localPosition, GUIContent mContent)
		{
			IntPtr intPtr = GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, IL2CPP.Il2CppObjectBaseToPtr(mContent));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003B7A File Offset: 0x00001D7A
		public void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret)
		{
			GUIStyle.Internal_CalcSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(content), out ret);
		}

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_m_Hover;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_m_Focused;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_m_OnNormal;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHover;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_OnActive;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_m_OnFocused;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_m_Border;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_m_Margin;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_m_Overflow;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_showKeyboardFocus;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_s_None;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_rawName_Internal_get_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0;

		// Token: 0x040001F3 RID: 499
		private static readonly GUIStyle.get_fontDelegate get_fontDelegateField;

		// Token: 0x040001F4 RID: 500
		private static readonly GUIStyle.set_fontDelegate set_fontDelegateField;

		// Token: 0x040001F5 RID: 501
		private static readonly GUIStyle.set_imagePositionDelegate set_imagePositionDelegateField;

		// Token: 0x040001F6 RID: 502
		private static readonly GUIStyle.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x040001F7 RID: 503
		private static readonly GUIStyle.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x040001F8 RID: 504
		private static readonly GUIStyle.set_wordWrapDelegate set_wordWrapDelegateField;

		// Token: 0x040001F9 RID: 505
		private static readonly GUIStyle.get_clippingDelegate get_clippingDelegateField;

		// Token: 0x040001FA RID: 506
		private static readonly GUIStyle.set_clippingDelegate set_clippingDelegateField;

		// Token: 0x040001FB RID: 507
		private static readonly GUIStyle.set_fixedWidthDelegate set_fixedWidthDelegateField;

		// Token: 0x040001FC RID: 508
		private static readonly GUIStyle.set_fixedHeightDelegate set_fixedHeightDelegateField;

		// Token: 0x040001FD RID: 509
		private static readonly GUIStyle.get_fontSizeDelegate get_fontSizeDelegateField;

		// Token: 0x040001FE RID: 510
		private static readonly GUIStyle.set_fontSizeDelegate set_fontSizeDelegateField;

		// Token: 0x040001FF RID: 511
		private static readonly GUIStyle.get_fontStyleDelegate get_fontStyleDelegateField;

		// Token: 0x04000200 RID: 512
		private static readonly GUIStyle.set_fontStyleDelegate set_fontStyleDelegateField;

		// Token: 0x04000201 RID: 513
		private static readonly GUIStyle.get_richTextDelegate get_richTextDelegateField;

		// Token: 0x04000202 RID: 514
		private static readonly GUIStyle.set_richTextDelegate set_richTextDelegateField;

		// Token: 0x04000203 RID: 515
		private static readonly GUIStyle.Internal_CopyDelegate Internal_CopyDelegateField;

		// Token: 0x04000204 RID: 516
		private static readonly GUIStyle.AssignStyleStateDelegate AssignStyleStateDelegateField;

		// Token: 0x04000205 RID: 517
		private static readonly GUIStyle.AssignRectOffsetDelegate AssignRectOffsetDelegateField;

		// Token: 0x04000206 RID: 518
		private static readonly GUIStyle.Internal_GetLineHeightDelegate Internal_GetLineHeightDelegateField;

		// Token: 0x04000207 RID: 519
		private static readonly GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate Internal_GetNumCharactersThatFitWithinWidthDelegateField;

		// Token: 0x04000208 RID: 520
		private static readonly GUIStyle.Internal_GetCursorFlashOffsetDelegate Internal_GetCursorFlashOffsetDelegateField;

		// Token: 0x04000209 RID: 521
		private static readonly GUIStyle.get_contentOffset_InjectedDelegate get_contentOffset_InjectedDelegateField;

		// Token: 0x0400020A RID: 522
		private static readonly GUIStyle.set_contentOffset_InjectedDelegate set_contentOffset_InjectedDelegateField;

		// Token: 0x0400020B RID: 523
		private static readonly GUIStyle.get_clipOffset_InjectedDelegate get_clipOffset_InjectedDelegateField;

		// Token: 0x0400020C RID: 524
		private static readonly GUIStyle.set_clipOffset_InjectedDelegate set_clipOffset_InjectedDelegateField;

		// Token: 0x0400020D RID: 525
		private static readonly GUIStyle.get_Internal_clipOffset_InjectedDelegate get_Internal_clipOffset_InjectedDelegateField;

		// Token: 0x0400020E RID: 526
		private static readonly GUIStyle.set_Internal_clipOffset_InjectedDelegate set_Internal_clipOffset_InjectedDelegateField;

		// Token: 0x0400020F RID: 527
		private static readonly GUIStyle.Internal_DrawCursor_InjectedDelegate Internal_DrawCursor_InjectedDelegateField;

		// Token: 0x04000210 RID: 528
		private static readonly GUIStyle.Internal_DrawWithTextSelection_InjectedDelegate Internal_DrawWithTextSelection_InjectedDelegateField;

		// Token: 0x04000211 RID: 529
		private static readonly GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegate Internal_GetCursorPixelPosition_InjectedDelegateField;

		// Token: 0x04000212 RID: 530
		private static readonly GUIStyle.Internal_GetCursorStringIndex_InjectedDelegate Internal_GetCursorStringIndex_InjectedDelegateField;

		// Token: 0x04000213 RID: 531
		private static readonly GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate Internal_GetHyperlinksRect_InjectedDelegateField;

		// Token: 0x04000214 RID: 532
		private static readonly GUIStyle.Internal_CalcSize_InjectedDelegate Internal_CalcSize_InjectedDelegateField;

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060006AD RID: 1709
		private delegate IntPtr get_fontDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060006AF RID: 1711
		private delegate void set_fontDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060006B1 RID: 1713
		private delegate void set_imagePositionDelegate(IntPtr @this, ImagePosition value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060006B3 RID: 1715
		private delegate TextAnchor get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060006B5 RID: 1717
		private delegate void set_alignmentDelegate(IntPtr @this, TextAnchor value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060006B7 RID: 1719
		private delegate void set_wordWrapDelegate(IntPtr @this, bool value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060006B9 RID: 1721
		private delegate TextClipping get_clippingDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060006BB RID: 1723
		private delegate void set_clippingDelegate(IntPtr @this, TextClipping value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060006BD RID: 1725
		private delegate void set_fixedWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060006BF RID: 1727
		private delegate void set_fixedHeightDelegate(IntPtr @this, float value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060006C1 RID: 1729
		private delegate int get_fontSizeDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060006C3 RID: 1731
		private delegate void set_fontSizeDelegate(IntPtr @this, int value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060006C5 RID: 1733
		private delegate FontStyle get_fontStyleDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060006C7 RID: 1735
		private delegate void set_fontStyleDelegate(IntPtr @this, FontStyle value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060006C9 RID: 1737
		private delegate bool get_richTextDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060006CB RID: 1739
		private delegate void set_richTextDelegate(IntPtr @this, bool value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060006CD RID: 1741
		private delegate IntPtr Internal_CopyDelegate(IntPtr self, IntPtr other);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060006CF RID: 1743
		private delegate void AssignStyleStateDelegate(IntPtr @this, int idx, IntPtr srcStyleState);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060006D1 RID: 1745
		private delegate void AssignRectOffsetDelegate(IntPtr @this, int idx, IntPtr srcRectOffset);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060006D3 RID: 1747
		private delegate float Internal_GetLineHeightDelegate(IntPtr target);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060006D5 RID: 1749
		private delegate int Internal_GetNumCharactersThatFitWithinWidthDelegate(IntPtr @this, IntPtr text, float width);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060006D7 RID: 1751
		private delegate float Internal_GetCursorFlashOffsetDelegate();

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060006D9 RID: 1753
		private delegate void get_contentOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060006DB RID: 1755
		private delegate void set_contentOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060006DD RID: 1757
		private delegate void get_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060006DF RID: 1759
		private delegate void set_clipOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060006E1 RID: 1761
		private delegate void get_Internal_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060006E3 RID: 1763
		private delegate void set_Internal_clipOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060006E5 RID: 1765
		private delegate void Internal_DrawCursor_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, int pos, IntPtr cursorColor);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060006E7 RID: 1767
		private delegate void Internal_DrawWithTextSelection_InjectedDelegate(IntPtr @this, IntPtr screenRect, IntPtr content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, IntPtr cursorColor, IntPtr selectionColor);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060006E9 RID: 1769
		private delegate void Internal_GetCursorPixelPosition_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, int cursorStringIndex, [Out] IntPtr ret);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060006EB RID: 1771
		private delegate int Internal_GetCursorStringIndex_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, IntPtr cursorPixelPosition);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060006ED RID: 1773
		private delegate IntPtr Internal_GetHyperlinksRect_InjectedDelegate(IntPtr @this, IntPtr localPosition, IntPtr mContent);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060006EF RID: 1775
		private delegate void Internal_CalcSize_InjectedDelegate(IntPtr @this, IntPtr content, [Out] IntPtr ret);
	}
}
