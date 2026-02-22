using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public class TextEditor : Object
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00014838 File Offset: 0x00012A38
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditor()
		{
			Il2CppClassPointerStore<TextEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditor>.NativeClassPtr);
			TextEditor.NativeFieldInfoPtr_keyboardOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "keyboardOnScreen");
			TextEditor.NativeFieldInfoPtr_controlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "controlID");
			TextEditor.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "style");
			TextEditor.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "multiline");
			TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "hasHorizontalCursorPos");
			TextEditor.NativeFieldInfoPtr_isPasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "isPasswordField");
			TextEditor.NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "scrollOffset");
			TextEditor.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Content");
			TextEditor.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Position");
			TextEditor.NativeFieldInfoPtr_m_CursorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_CursorIndex");
			TextEditor.NativeFieldInfoPtr_m_SelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_SelectIndex");
			TextEditor.NativeFieldInfoPtr_m_RevealCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_RevealCursor");
			TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_MouseDragSelectsWholeWords");
			TextEditor.NativeFieldInfoPtr_m_DblClickInitPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickInitPos");
			TextEditor.NativeFieldInfoPtr_m_DblClickSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickSnap");
			TextEditor.NativeFieldInfoPtr_m_bJustSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_bJustSelected");
			TextEditor.NativeFieldInfoPtr_m_iAltCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_iAltCursorPos");
			TextEditor.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663735);
			TextEditor.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663736);
			TextEditor.NativeMethodInfoPtr_get_position_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663737);
			TextEditor.NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663738);
			TextEditor.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663739);
			TextEditor.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663740);
			TextEditor.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663741);
			TextEditor.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663742);
			TextEditor.NativeMethodInfoPtr_ClearCursorPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663743);
			TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663744);
			TextEditor.NativeMethodInfoPtr_SelectAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663745);
			TextEditor.NativeMethodInfoPtr_Copy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663746);
			TextEditor.NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663747);
			TextEditor.NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663748);
			TextEditor.NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663749);
			TextEditor.NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663750);
			TextEditor.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663751);
			TextEditor.NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663752);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00014B24 File Offset: 0x00012D24
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00014B5C File Offset: 0x00012D5C
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88608, RefRangeEnd = 88609, XrefRangeStart = 88603, XrefRangeEnd = 88608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00014BA0 File Offset: 0x00012DA0
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0001525C File Offset: 0x0001345C
		public unsafe Rect position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_position_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.m_Position == value;
				if (!flag)
				{
					this.scrollOffset = Vector2.zero;
					this.m_Position = value;
					this.UpdateScrollOffset();
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00014BDC File Offset: 0x00012DDC
		public unsafe virtual Rect localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00014C24 File Offset: 0x00012E24
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00014C60 File Offset: 0x00012E60
		public unsafe int cursorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88609, XrefRangeEnd = 88610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00014CA0 File Offset: 0x00012EA0
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00014CDC File Offset: 0x00012EDC
		public unsafe int selectIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88610, XrefRangeEnd = 88611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00014D1C File Offset: 0x00012F1C
		[CallerCount(0)]
		public unsafe void ClearCursorPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ClearCursorPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00014D50 File Offset: 0x00012F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88624, RefRangeEnd = 88625, XrefRangeStart = 88611, XrefRangeEnd = 88624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00014D8C File Offset: 0x00012F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88627, RefRangeEnd = 88628, XrefRangeStart = 88625, XrefRangeEnd = 88627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88632, RefRangeEnd = 88633, XrefRangeStart = 88628, XrefRangeEnd = 88632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Copy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00014DF4 File Offset: 0x00012FF4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCursorIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00014E30 File Offset: 0x00013030
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelectIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00014E6C File Offset: 0x0001306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88633, XrefRangeEnd = 88634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampTextIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00014EAC File Offset: 0x000130AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 88646, RefRangeEnd = 88652, XrefRangeStart = 88634, XrefRangeEnd = 88646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidCodePointIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00014EEC File Offset: 0x000130EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88652, XrefRangeEnd = 88657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00014F38 File Offset: 0x00013138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88657, XrefRangeEnd = 88663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000459A File Offset: 0x0000279A
		public TextEditor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00014F84 File Offset: 0x00013184
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x000045A3 File Offset: 0x000027A3
		public unsafe TouchScreenKeyboard keyboardOnScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00014FB4 File Offset: 0x000131B4
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x000045C2 File Offset: 0x000027C2
		public unsafe int controlID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00014FDC File Offset: 0x000131DC
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x000045DD File Offset: 0x000027DD
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001500C File Offset: 0x0001320C
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000045FC File Offset: 0x000027FC
		public unsafe bool multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00015034 File Offset: 0x00013234
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x00004617 File Offset: 0x00002817
		public unsafe bool hasHorizontalCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001505C File Offset: 0x0001325C
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00004632 File Offset: 0x00002832
		public unsafe bool isPasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00015084 File Offset: 0x00013284
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0000464D File Offset: 0x0000284D
		public unsafe Vector2 scrollOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x000150AC File Offset: 0x000132AC
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00004668 File Offset: 0x00002868
		public unsafe GUIContent m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000150DC File Offset: 0x000132DC
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00004687 File Offset: 0x00002887
		public unsafe Rect m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00015104 File Offset: 0x00013304
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x000046A2 File Offset: 0x000028A2
		public unsafe int m_CursorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001512C File Offset: 0x0001332C
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x000046BD File Offset: 0x000028BD
		public unsafe int m_SelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00015154 File Offset: 0x00013354
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x000046D8 File Offset: 0x000028D8
		public unsafe bool m_RevealCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001517C File Offset: 0x0001337C
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000046F3 File Offset: 0x000028F3
		public unsafe bool m_MouseDragSelectsWholeWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000151A4 File Offset: 0x000133A4
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0000470E File Offset: 0x0000290E
		public unsafe int m_DblClickInitPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000151CC File Offset: 0x000133CC
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00004729 File Offset: 0x00002929
		public unsafe TextEditor.DblClickSnapping m_DblClickSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000151F4 File Offset: 0x000133F4
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00004744 File Offset: 0x00002944
		public unsafe bool m_bJustSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001521C File Offset: 0x0001341C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000475F File Offset: 0x0000295F
		public unsafe int m_iAltCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00015244 File Offset: 0x00013444
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000477A File Offset: 0x0000297A
		public GUIContent content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00015298 File Offset: 0x00013498
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00004784 File Offset: 0x00002984
		public TextEditor.DblClickSnapping doubleClickSnapping
		{
			get
			{
				return this.m_DblClickSnap;
			}
			set
			{
				this.m_DblClickSnap = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000152B0 File Offset: 0x000134B0
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000478E File Offset: 0x0000298E
		public int altCursorPosition
		{
			get
			{
				return this.m_iAltCursorPos;
			}
			set
			{
				this.m_iAltCursorPos = value;
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004798 File Offset: 0x00002998
		public void OnFocus()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000047A5 File Offset: 0x000029A5
		public void OnLostFocus()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000047B2 File Offset: 0x000029B2
		public void GrabGraphicalCursorPos()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000152C8 File Offset: 0x000134C8
		public bool HandleKeyEvent(Event e)
		{
			return this.HandleKeyEvent(e, false);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000047BF File Offset: 0x000029BF
		public bool HandleKeyEvent(Event e, bool textIsReadOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000152E4 File Offset: 0x000134E4
		public bool DeleteLineBack()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.cursorIndex;
				int num2 = num;
				while (num2-- != 0)
				{
					bool flag2 = this.text.get_Chars(num2) == '\n';
					if (flag2)
					{
						num = num2 + 1;
						break;
					}
				}
				bool flag3 = num2 == -1;
				if (flag3)
				{
					num = 0;
				}
				bool flag4 = this.cursorIndex != num;
				if (flag4)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000153A0 File Offset: 0x000135A0
		public bool DeleteWordBack()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.FindEndOfPreviousWord(this.cursorIndex);
				bool flag2 = this.cursorIndex != num;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00015420 File Offset: 0x00013620
		public bool DeleteWordForward()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.FindStartOfNextWord(this.cursorIndex);
				bool flag2 = this.cursorIndex < this.text.Length;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(this.cursorIndex, num - this.cursorIndex);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00015498 File Offset: 0x00013698
		public bool Delete()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				bool flag2 = this.cursorIndex < this.text.Length;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(this.cursorIndex, this.NextCodePointIndex(this.cursorIndex) - this.cursorIndex);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00015510 File Offset: 0x00013710
		public bool CanPaste()
		{
			return GUIUtility.systemCopyBuffer.Length != 0;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00015530 File Offset: 0x00013730
		public bool Backspace()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				bool flag2 = this.cursorIndex > 0;
				if (flag2)
				{
					int num = this.PreviousCodePointIndex(this.cursorIndex);
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					this.ClearCursorPos();
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000047CC File Offset: 0x000029CC
		public void SelectNone()
		{
			this.selectIndex = this.cursorIndex;
			this.ClearCursorPos();
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000155B4 File Offset: 0x000137B4
		public bool hasSelection
		{
			get
			{
				return this.cursorIndex != this.selectIndex;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000155D8 File Offset: 0x000137D8
		public string SelectedText
		{
			get
			{
				bool flag = this.cursorIndex == this.selectIndex;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					bool flag2 = this.cursorIndex < this.selectIndex;
					if (flag2)
					{
						text = this.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
					}
					else
					{
						text = this.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
					}
				}
				return text;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00015658 File Offset: 0x00013858
		public bool DeleteSelection()
		{
			bool flag = this.cursorIndex == this.selectIndex;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.cursorIndex < this.selectIndex;
				if (flag3)
				{
					this.m_Content.text = String.Concat(this.text.Substring(0, this.cursorIndex), this.text.Substring(this.selectIndex, this.text.Length - this.selectIndex));
					this.selectIndex = this.cursorIndex;
				}
				else
				{
					this.m_Content.text = String.Concat(this.text.Substring(0, this.selectIndex), this.text.Substring(this.cursorIndex, this.text.Length - this.cursorIndex));
					this.cursorIndex = this.selectIndex;
				}
				this.ClearCursorPos();
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001574C File Offset: 0x0001394C
		public void ReplaceSelection(string replace)
		{
			this.DeleteSelection();
			this.m_Content.text = this.text.Insert(this.cursorIndex, replace);
			this.selectIndex = (this.cursorIndex += replace.Length);
			this.ClearCursorPos();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000047E3 File Offset: 0x000029E3
		public void Insert(char c)
		{
			this.ReplaceSelection(c.ToString());
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000157A4 File Offset: 0x000139A4
		public void MoveSelectionToAltCursor()
		{
			bool flag = this.m_iAltCursorPos == -1;
			if (!flag)
			{
				int iAltCursorPos = this.m_iAltCursorPos;
				string selectedText = this.SelectedText;
				this.m_Content.text = this.text.Insert(iAltCursorPos, selectedText);
				bool flag2 = iAltCursorPos < this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex += selectedText.Length;
					this.selectIndex += selectedText.Length;
				}
				this.DeleteSelection();
				this.selectIndex = (this.cursorIndex = iAltCursorPos);
				this.ClearCursorPos();
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00015844 File Offset: 0x00013A44
		public void MoveRight()
		{
			this.ClearCursorPos();
			bool flag = this.selectIndex == this.cursorIndex;
			if (flag)
			{
				this.cursorIndex = this.NextCodePointIndex(this.cursorIndex);
				this.DetectFocusChange();
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				bool flag2 = this.selectIndex > this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex = this.selectIndex;
				}
				else
				{
					this.selectIndex = this.cursorIndex;
				}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000158C8 File Offset: 0x00013AC8
		public void MoveLeft()
		{
			bool flag = this.selectIndex == this.cursorIndex;
			if (flag)
			{
				this.cursorIndex = this.PreviousCodePointIndex(this.cursorIndex);
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				bool flag2 = this.selectIndex > this.cursorIndex;
				if (flag2)
				{
					this.selectIndex = this.cursorIndex;
				}
				else
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			this.ClearCursorPos();
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000047F4 File Offset: 0x000029F4
		public void MoveUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004801 File Offset: 0x00002A01
		public void MoveDown()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00015944 File Offset: 0x00013B44
		public void MoveLineStart()
		{
			int num = ((this.selectIndex < this.cursorIndex) ? this.selectIndex : this.cursorIndex);
			int num2 = num;
			while (num2-- != 0)
			{
				bool flag = this.text.get_Chars(num2) == '\n';
				if (flag)
				{
					this.selectIndex = (this.cursorIndex = num2 + 1);
					return;
				}
			}
			this.selectIndex = (this.cursorIndex = 0);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000159C0 File Offset: 0x00013BC0
		public void MoveLineEnd()
		{
			int num = ((this.selectIndex > this.cursorIndex) ? this.selectIndex : this.cursorIndex);
			int i = num;
			int length = this.text.Length;
			while (i < length)
			{
				bool flag = this.text.get_Chars(i) == '\n';
				if (flag)
				{
					this.selectIndex = (this.cursorIndex = i);
					return;
				}
				i++;
			}
			this.selectIndex = (this.cursorIndex = length);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00015A4C File Offset: 0x00013C4C
		public void MoveGraphicalLineStart()
		{
			this.cursorIndex = (this.selectIndex = this.GetGraphicalLineStart((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex));
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00015A90 File Offset: 0x00013C90
		public void MoveGraphicalLineEnd()
		{
			this.cursorIndex = (this.selectIndex = this.GetGraphicalLineEnd((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex));
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00015AD4 File Offset: 0x00013CD4
		public void MoveTextStart()
		{
			this.selectIndex = (this.cursorIndex = 0);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00015AF4 File Offset: 0x00013CF4
		public void MoveTextEnd()
		{
			this.selectIndex = (this.cursorIndex = this.text.Length);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00015B20 File Offset: 0x00013D20
		public int IndexOfEndOfLine(int startIndex)
		{
			int num = this.text.IndexOf('\n', startIndex);
			return (num != -1) ? num : this.text.Length;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00015B54 File Offset: 0x00013D54
		public void MoveParagraphForward()
		{
			this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			bool flag = this.cursorIndex < this.text.Length;
			if (flag)
			{
				this.selectIndex = (this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1));
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00015BC0 File Offset: 0x00013DC0
		public void MoveParagraphBackward()
		{
			this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			bool flag = this.cursorIndex > 1;
			if (flag)
			{
				this.selectIndex = (this.cursorIndex = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1);
			}
			else
			{
				this.selectIndex = (this.cursorIndex = 0);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000480E File Offset: 0x00002A0E
		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
			this.MoveCursorToPosition_Internal(cursorPosition, Event.current.shift);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00015C3C File Offset: 0x00013E3C
		public void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
			this.selectIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			bool flag = !shift;
			if (flag)
			{
				this.cursorIndex = this.selectIndex;
			}
			this.DetectFocusChange();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00015C94 File Offset: 0x00013E94
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			this.m_iAltCursorPos = Mathf.Min(this.text.Length, cursorStringIndex);
			this.DetectFocusChange();
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00015CE4 File Offset: 0x00013EE4
		public bool IsOverSelection(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			return cursorStringIndex < Mathf.Max(this.cursorIndex, this.selectIndex) && cursorStringIndex > Mathf.Min(this.cursorIndex, this.selectIndex);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004823 File Offset: 0x00002A23
		public void SelectToPosition(Vector2 cursorPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00015D48 File Offset: 0x00013F48
		public void SelectLeft()
		{
			bool bJustSelected = this.m_bJustSelected;
			if (bJustSelected)
			{
				bool flag = this.cursorIndex > this.selectIndex;
				if (flag)
				{
					int cursorIndex = this.cursorIndex;
					this.cursorIndex = this.selectIndex;
					this.selectIndex = cursorIndex;
				}
			}
			this.m_bJustSelected = false;
			this.cursorIndex = this.PreviousCodePointIndex(this.cursorIndex);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00015DAC File Offset: 0x00013FAC
		public void SelectRight()
		{
			bool bJustSelected = this.m_bJustSelected;
			if (bJustSelected)
			{
				bool flag = this.cursorIndex < this.selectIndex;
				if (flag)
				{
					int cursorIndex = this.cursorIndex;
					this.cursorIndex = this.selectIndex;
					this.selectIndex = cursorIndex;
				}
			}
			this.m_bJustSelected = false;
			this.cursorIndex = this.NextCodePointIndex(this.cursorIndex);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00004830 File Offset: 0x00002A30
		public void SelectUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000483D File Offset: 0x00002A3D
		public void SelectDown()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000484A File Offset: 0x00002A4A
		public void SelectTextEnd()
		{
			this.cursorIndex = this.text.Length;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000485F File Offset: 0x00002A5F
		public void SelectTextStart()
		{
			this.cursorIndex = 0;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000486A File Offset: 0x00002A6A
		public void MouseDragSelectsWholeWords(bool on)
		{
			this.m_MouseDragSelectsWholeWords = on;
			this.m_DblClickInitPos = this.cursorIndex;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004880 File Offset: 0x00002A80
		public void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			this.m_DblClickSnap = snapping;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00015E10 File Offset: 0x00014010
		public int GetGraphicalLineStart(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.localPosition, this.m_Content, p);
			cursorPixelPosition.y += 1f / GUIUtility.pixelsPerPoint;
			cursorPixelPosition.x = 0f;
			return this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00015E78 File Offset: 0x00014078
		public int GetGraphicalLineEnd(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.localPosition, this.m_Content, p);
			cursorPixelPosition.y += 1f / GUIUtility.pixelsPerPoint;
			cursorPixelPosition.x += 5000f;
			return this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00015EE4 File Offset: 0x000140E4
		public int FindNextSeperator(int startPos)
		{
			int length = this.text.Length;
			while (startPos < length && this.ClassifyChar(startPos) > TextEditor.CharacterType.LetterLike)
			{
				startPos = this.NextCodePointIndex(startPos);
			}
			while (startPos < length && this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike)
			{
				startPos = this.NextCodePointIndex(startPos);
			}
			return startPos;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00015F44 File Offset: 0x00014144
		public int FindPrevSeperator(int startPos)
		{
			startPos = this.PreviousCodePointIndex(startPos);
			while (startPos > 0 && this.ClassifyChar(startPos) > TextEditor.CharacterType.LetterLike)
			{
				startPos = this.PreviousCodePointIndex(startPos);
			}
			bool flag = startPos == 0;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				while (startPos > 0 && this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike)
				{
					startPos = this.PreviousCodePointIndex(startPos);
				}
				bool flag2 = this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike;
				if (flag2)
				{
					num = startPos;
				}
				else
				{
					num = this.NextCodePointIndex(startPos);
				}
			}
			return num;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00015FC8 File Offset: 0x000141C8
		public void MoveWordRight()
		{
			this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			this.cursorIndex = (this.selectIndex = this.FindNextSeperator(this.cursorIndex));
			this.ClearCursorPos();
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00016020 File Offset: 0x00014220
		public void MoveToStartOfNextWord()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex != this.selectIndex;
			if (flag)
			{
				this.MoveRight();
			}
			else
			{
				this.cursorIndex = (this.selectIndex = this.FindStartOfNextWord(this.cursorIndex));
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00016074 File Offset: 0x00014274
		public void MoveToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex != this.selectIndex;
			if (flag)
			{
				this.MoveLeft();
			}
			else
			{
				this.cursorIndex = (this.selectIndex = this.FindEndOfPreviousWord(this.cursorIndex));
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000488A File Offset: 0x00002A8A
		public void SelectToStartOfNextWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindStartOfNextWord(this.cursorIndex);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000048A7 File Offset: 0x00002AA7
		public void SelectToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindEndOfPreviousWord(this.cursorIndex);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000160C8 File Offset: 0x000142C8
		public TextEditor.CharacterType ClassifyChar(int index)
		{
			bool flag = Char.IsWhiteSpace(this.text, index);
			TextEditor.CharacterType characterType;
			if (flag)
			{
				characterType = TextEditor.CharacterType.WhiteSpace;
			}
			else
			{
				bool flag2 = Char.IsLetterOrDigit(this.text, index) || this.text.get_Chars(index) == '\'';
				if (flag2)
				{
					characterType = TextEditor.CharacterType.LetterLike;
				}
				else
				{
					characterType = TextEditor.CharacterType.Symbol;
				}
			}
			return characterType;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00016118 File Offset: 0x00014318
		public int FindStartOfNextWord(int p)
		{
			int length = this.text.Length;
			bool flag = p == length;
			int num;
			if (flag)
			{
				num = p;
			}
			else
			{
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				bool flag2 = characterType != TextEditor.CharacterType.WhiteSpace;
				if (flag2)
				{
					p = this.NextCodePointIndex(p);
					while (p < length && this.ClassifyChar(p) == characterType)
					{
						p = this.NextCodePointIndex(p);
					}
				}
				else
				{
					bool flag3 = this.text.get_Chars(p) == '\t' || this.text.get_Chars(p) == '\n';
					if (flag3)
					{
						return this.NextCodePointIndex(p);
					}
				}
				bool flag4 = p == length;
				if (flag4)
				{
					num = p;
				}
				else
				{
					bool flag5 = this.text.get_Chars(p) == ' ';
					if (flag5)
					{
						while (p < length && this.ClassifyChar(p) == TextEditor.CharacterType.WhiteSpace)
						{
							p = this.NextCodePointIndex(p);
						}
					}
					else
					{
						bool flag6 = this.text.get_Chars(p) == '\t' || this.text.get_Chars(p) == '\n';
						if (flag6)
						{
							return p;
						}
					}
					num = p;
				}
			}
			return num;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00016238 File Offset: 0x00014438
		public int FindEndOfPreviousWord(int p)
		{
			bool flag = p == 0;
			int num;
			if (flag)
			{
				num = p;
			}
			else
			{
				p = this.PreviousCodePointIndex(p);
				while (p > 0 && this.text.get_Chars(p) == ' ')
				{
					p = this.PreviousCodePointIndex(p);
				}
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				bool flag2 = characterType != TextEditor.CharacterType.WhiteSpace;
				if (flag2)
				{
					while (p > 0 && this.ClassifyChar(this.PreviousCodePointIndex(p)) == characterType)
					{
						p = this.PreviousCodePointIndex(p);
					}
				}
				num = p;
			}
			return num;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000162C8 File Offset: 0x000144C8
		public void MoveWordLeft()
		{
			this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			this.cursorIndex = this.FindPrevSeperator(this.cursorIndex);
			this.selectIndex = this.cursorIndex;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001631C File Offset: 0x0001451C
		public void SelectWordRight()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000163A8 File Offset: 0x000145A8
		public void SelectWordLeft()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			bool flag = this.cursorIndex > this.selectIndex;
			if (flag)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00016434 File Offset: 0x00014634
		public void ExpandSelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineStart(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00016494 File Offset: 0x00014694
		public void ExpandSelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineEnd(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000048C4 File Offset: 0x00002AC4
		public void SelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000048E1 File Offset: 0x00002AE1
		public void SelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000164F4 File Offset: 0x000146F4
		public void SelectParagraphForward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			bool flag2 = this.cursorIndex < this.text.Length;
			if (flag2)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1);
				bool flag3 = flag && this.cursorIndex > this.selectIndex;
				if (flag3)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001656C File Offset: 0x0001476C
		public void SelectParagraphBackward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			bool flag2 = this.cursorIndex > 1;
			if (flag2)
			{
				this.cursorIndex = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				bool flag3 = flag && this.cursorIndex < this.selectIndex;
				if (flag3)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			else
			{
				this.selectIndex = (this.cursorIndex = 0);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000165F8 File Offset: 0x000147F8
		public void SelectCurrentWord()
		{
			int cursorIndex = this.cursorIndex;
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Backward);
				this.selectIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Forward);
			}
			else
			{
				this.cursorIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Forward);
				this.selectIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Backward);
			}
			this.ClearCursorPos();
			this.m_bJustSelected = true;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00016670 File Offset: 0x00014870
		public int FindEndOfClassification(int p, TextEditor.Direction dir)
		{
			bool flag = this.text.Length == 0;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = p == this.text.Length;
				if (flag2)
				{
					p = this.PreviousCodePointIndex(p);
				}
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				for (;;)
				{
					if (dir != TextEditor.Direction.Forward)
					{
						if (dir == TextEditor.Direction.Backward)
						{
							p = this.PreviousCodePointIndex(p);
							bool flag3 = p == 0;
							if (flag3)
							{
								break;
							}
						}
					}
					else
					{
						p = this.NextCodePointIndex(p);
						bool flag4 = p == this.text.Length;
						if (flag4)
						{
							goto Block_7;
						}
					}
					if (this.ClassifyChar(p) != characterType)
					{
						goto Block_8;
					}
				}
				return (this.ClassifyChar(0) == characterType) ? 0 : this.NextCodePointIndex(0);
				Block_7:
				return this.text.Length;
				Block_8:
				bool flag5 = dir == TextEditor.Direction.Forward;
				if (flag5)
				{
					num = p;
				}
				else
				{
					num = this.NextCodePointIndex(p);
				}
			}
			return num;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00016758 File Offset: 0x00014958
		public void SelectCurrentParagraph()
		{
			this.ClearCursorPos();
			int length = this.text.Length;
			bool flag = this.cursorIndex < length;
			if (flag)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex) + 1;
			}
			bool flag2 = this.selectIndex != 0;
			if (flag2)
			{
				this.selectIndex = this.text.LastIndexOf('\n', this.selectIndex - 1) + 1;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000167C8 File Offset: 0x000149C8
		public void UpdateScrollOffsetIfNeeded(Event evt)
		{
			bool flag = evt.type != EventType.Repaint && evt.type != EventType.Layout;
			if (flag)
			{
				this.UpdateScrollOffset();
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000048FE File Offset: 0x00002AFE
		public void UpdateScrollOffset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000490B File Offset: 0x00002B0B
		public void DrawCursor(string newText)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000167FC File Offset: 0x000149FC
		public bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly)
		{
			this.m_RevealCursor = true;
			switch (operation)
			{
			case TextEditor.TextEditOp.MoveLeft:
				this.MoveLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveRight:
				this.MoveRight();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveUp:
				this.MoveUp();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveDown:
				this.MoveDown();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveLineStart:
				this.MoveLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveLineEnd:
				this.MoveLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveTextStart:
				this.MoveTextStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveTextEnd:
				this.MoveTextEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveGraphicalLineStart:
				this.MoveGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveGraphicalLineEnd:
				this.MoveGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveWordLeft:
				this.MoveWordLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveWordRight:
				this.MoveWordRight();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveParagraphForward:
				this.MoveParagraphForward();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveParagraphBackward:
				this.MoveParagraphBackward();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveToStartOfNextWord:
				this.MoveToStartOfNextWord();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveToEndOfPreviousWord:
				this.MoveToEndOfPreviousWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectLeft:
				this.SelectLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectRight:
				this.SelectRight();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectUp:
				this.SelectUp();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectDown:
				this.SelectDown();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectTextStart:
				this.SelectTextStart();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectTextEnd:
				this.SelectTextEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineStart:
				this.ExpandSelectGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd:
				this.ExpandSelectGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectGraphicalLineStart:
				this.SelectGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectGraphicalLineEnd:
				this.SelectGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectWordLeft:
				this.SelectWordLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectWordRight:
				this.SelectWordRight();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectToEndOfPreviousWord:
				this.SelectToEndOfPreviousWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectToStartOfNextWord:
				this.SelectToStartOfNextWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectParagraphBackward:
				this.SelectParagraphBackward();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectParagraphForward:
				this.SelectParagraphForward();
				goto IL_0328;
			case TextEditor.TextEditOp.Delete:
				return !textIsReadOnly && this.Delete();
			case TextEditor.TextEditOp.Backspace:
				return !textIsReadOnly && this.Backspace();
			case TextEditor.TextEditOp.DeleteWordBack:
				return !textIsReadOnly && this.DeleteWordBack();
			case TextEditor.TextEditOp.DeleteWordForward:
				return !textIsReadOnly && this.DeleteWordForward();
			case TextEditor.TextEditOp.DeleteLineBack:
				return !textIsReadOnly && this.DeleteLineBack();
			case TextEditor.TextEditOp.Cut:
				return !textIsReadOnly && this.Cut();
			case TextEditor.TextEditOp.Copy:
				this.Copy();
				goto IL_0328;
			case TextEditor.TextEditOp.Paste:
				return !textIsReadOnly && this.Paste();
			case TextEditor.TextEditOp.SelectAll:
				this.SelectAll();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectNone:
				this.SelectNone();
				goto IL_0328;
			}
			Debug.Log(String.Concat("Unimplemented: ", operation.ToString()));
			IL_0328:
			return false;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004918 File Offset: 0x00002B18
		public void SaveBackup()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004925 File Offset: 0x00002B25
		public void Undo()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00016B38 File Offset: 0x00014D38
		public bool Cut()
		{
			bool isPasswordField = this.isPasswordField;
			bool flag;
			if (isPasswordField)
			{
				flag = false;
			}
			else
			{
				this.Copy();
				flag = this.DeleteSelection();
			}
			return flag;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00016B68 File Offset: 0x00014D68
		public Il2CppStructArray<Rect> GetHyperlinksRect()
		{
			return this.style.Internal_GetHyperlinksRect(this.localPosition, this.m_Content);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016B94 File Offset: 0x00014D94
		public static string ReplaceNewlinesWithSpaces(string value)
		{
			value = value.Replace("\r\n", " ");
			value = value.Replace('\n', ' ');
			value = value.Replace('\r', ' ');
			return value;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00016BD4 File Offset: 0x00014DD4
		public bool Paste()
		{
			string text = GUIUtility.systemCopyBuffer;
			bool flag = text != "";
			bool flag3;
			if (flag)
			{
				bool flag2 = !this.multiline;
				if (flag2)
				{
					text = TextEditor.ReplaceNewlinesWithSpaces(text);
				}
				this.ReplaceSelection(text);
				flag3 = true;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00004932 File Offset: 0x00002B32
		public static void MapKey(string key, TextEditor.TextEditOp action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000493F File Offset: 0x00002B3F
		public void InitKeyActions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000494C File Offset: 0x00002B4C
		public void DetectFocusChange()
		{
			this.OnDetectFocusChange();
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00004956 File Offset: 0x00002B56
		public virtual void OnDetectFocusChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00016C20 File Offset: 0x00014E20
		public int PreviousCodePointIndex(int index)
		{
			bool flag = index > 0;
			if (flag)
			{
				index--;
			}
			while (index > 0 && Char.IsLowSurrogate(this.text.get_Chars(index)))
			{
				index--;
			}
			return index;
		}

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_keyboardOnScreen;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_controlID;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_isPasswordField;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_scrollOffset;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorIndex;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectIndex;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_m_RevealCursor;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDragSelectsWholeWords;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickInitPos;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickSnap;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_m_bJustSelected;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_m_iAltCursorPos;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Rect_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_ClearCursorPos_Private_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Void_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0;

		// Token: 0x020000A6 RID: 166
		public enum DblClickSnapping : byte
		{
			// Token: 0x04000369 RID: 873
			WORDS,
			// Token: 0x0400036A RID: 874
			PARAGRAPHS
		}

		// Token: 0x020000A7 RID: 167
		public enum CharacterType
		{
			// Token: 0x0400036C RID: 876
			LetterLike,
			// Token: 0x0400036D RID: 877
			Symbol,
			// Token: 0x0400036E RID: 878
			Symbol2,
			// Token: 0x0400036F RID: 879
			WhiteSpace
		}

		// Token: 0x020000A8 RID: 168
		public enum Direction
		{
			// Token: 0x04000371 RID: 881
			Forward,
			// Token: 0x04000372 RID: 882
			Backward
		}

		// Token: 0x020000A9 RID: 169
		public enum TextEditOp
		{
			// Token: 0x04000374 RID: 884
			MoveLeft,
			// Token: 0x04000375 RID: 885
			MoveRight,
			// Token: 0x04000376 RID: 886
			MoveUp,
			// Token: 0x04000377 RID: 887
			MoveDown,
			// Token: 0x04000378 RID: 888
			MoveLineStart,
			// Token: 0x04000379 RID: 889
			MoveLineEnd,
			// Token: 0x0400037A RID: 890
			MoveTextStart,
			// Token: 0x0400037B RID: 891
			MoveTextEnd,
			// Token: 0x0400037C RID: 892
			MovePageUp,
			// Token: 0x0400037D RID: 893
			MovePageDown,
			// Token: 0x0400037E RID: 894
			MoveGraphicalLineStart,
			// Token: 0x0400037F RID: 895
			MoveGraphicalLineEnd,
			// Token: 0x04000380 RID: 896
			MoveWordLeft,
			// Token: 0x04000381 RID: 897
			MoveWordRight,
			// Token: 0x04000382 RID: 898
			MoveParagraphForward,
			// Token: 0x04000383 RID: 899
			MoveParagraphBackward,
			// Token: 0x04000384 RID: 900
			MoveToStartOfNextWord,
			// Token: 0x04000385 RID: 901
			MoveToEndOfPreviousWord,
			// Token: 0x04000386 RID: 902
			SelectLeft,
			// Token: 0x04000387 RID: 903
			SelectRight,
			// Token: 0x04000388 RID: 904
			SelectUp,
			// Token: 0x04000389 RID: 905
			SelectDown,
			// Token: 0x0400038A RID: 906
			SelectTextStart,
			// Token: 0x0400038B RID: 907
			SelectTextEnd,
			// Token: 0x0400038C RID: 908
			SelectPageUp,
			// Token: 0x0400038D RID: 909
			SelectPageDown,
			// Token: 0x0400038E RID: 910
			ExpandSelectGraphicalLineStart,
			// Token: 0x0400038F RID: 911
			ExpandSelectGraphicalLineEnd,
			// Token: 0x04000390 RID: 912
			SelectGraphicalLineStart,
			// Token: 0x04000391 RID: 913
			SelectGraphicalLineEnd,
			// Token: 0x04000392 RID: 914
			SelectWordLeft,
			// Token: 0x04000393 RID: 915
			SelectWordRight,
			// Token: 0x04000394 RID: 916
			SelectToEndOfPreviousWord,
			// Token: 0x04000395 RID: 917
			SelectToStartOfNextWord,
			// Token: 0x04000396 RID: 918
			SelectParagraphBackward,
			// Token: 0x04000397 RID: 919
			SelectParagraphForward,
			// Token: 0x04000398 RID: 920
			Delete,
			// Token: 0x04000399 RID: 921
			Backspace,
			// Token: 0x0400039A RID: 922
			DeleteWordBack,
			// Token: 0x0400039B RID: 923
			DeleteWordForward,
			// Token: 0x0400039C RID: 924
			DeleteLineBack,
			// Token: 0x0400039D RID: 925
			Cut,
			// Token: 0x0400039E RID: 926
			Copy,
			// Token: 0x0400039F RID: 927
			Paste,
			// Token: 0x040003A0 RID: 928
			SelectAll,
			// Token: 0x040003A1 RID: 929
			SelectNone,
			// Token: 0x040003A2 RID: 930
			ScrollStart,
			// Token: 0x040003A3 RID: 931
			ScrollEnd,
			// Token: 0x040003A4 RID: 932
			ScrollPageUp,
			// Token: 0x040003A5 RID: 933
			ScrollPageDown
		}
	}
}
