using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000010 RID: 16
	public class FocusController : Object
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x0000E884 File Offset: 0x0000CA84
		// Note: this type is marked as 'beforefieldinit'.
		static FocusController()
		{
			Il2CppClassPointerStore<FocusController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusController>.NativeClassPtr);
			FocusController.NativeFieldInfoPtr__focusRing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "<focusRing>k__BackingField");
			FocusController.NativeFieldInfoPtr_m_FocusedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_FocusedElements");
			FocusController.NativeFieldInfoPtr_m_LastFocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_LastFocusedElement");
			FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "<imguiKeyboardControl>k__BackingField");
			FocusController.NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663348);
			FocusController.NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663349);
			FocusController.NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663350);
			FocusController.NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663351);
			FocusController.NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663352);
			FocusController.NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663353);
			FocusController.NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663354);
			FocusController.NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663355);
			FocusController.NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663356);
			FocusController.NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663357);
			FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663358);
			FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663359);
			FocusController.NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Focusable_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663360);
			FocusController.NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663361);
			FocusController.NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663362);
			FocusController.NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100663363);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000EA44 File Offset: 0x0000CC44
		public unsafe IFocusRing focusRing
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFocusRing>(intPtr3) : null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000EA84 File Offset: 0x0000CC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91214, RefRangeEnd = 91215, XrefRangeStart = 91198, XrefRangeEnd = 91214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFocused(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91217, RefRangeEnd = 91222, XrefRangeStart = 91215, XrefRangeEnd = 91217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetLeafFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000EB14 File Offset: 0x0000CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91222, XrefRangeEnd = 91224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFocusToLastFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000EB48 File Offset: 0x0000CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91224, XrefRangeEnd = 91226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlurLastFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91240, RefRangeEnd = 91243, XrefRangeStart = 91226, XrefRangeEnd = 91240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoFocusChange(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91250, RefRangeEnd = 91251, XrefRangeStart = 91243, XrefRangeEnd = 91250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willGiveFocusTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91258, RefRangeEnd = 91259, XrefRangeStart = 91251, XrefRangeEnd = 91258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willGiveFocusTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000EC90 File Offset: 0x0000CE90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91266, RefRangeEnd = 91268, XrefRangeStart = 91259, XrefRangeEnd = 91266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willTakeFocusFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91275, RefRangeEnd = 91276, XrefRangeStart = 91268, XrefRangeEnd = 91275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willTakeFocusFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91285, RefRangeEnd = 91287, XrefRangeStart = 91276, XrefRangeEnd = 91285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFocusedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91309, RefRangeEnd = 91312, XrefRangeStart = 91287, XrefRangeEnd = 91309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFocusedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000EE20 File Offset: 0x0000D020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91341, RefRangeEnd = 91342, XrefRangeStart = 91312, XrefRangeEnd = 91341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable SwitchFocusOnEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Focusable_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000EE70 File Offset: 0x0000D070
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000EEAC File Offset: 0x0000D0AC
		public unsafe int imguiKeyboardControl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91359, RefRangeEnd = 91362, XrefRangeStart = 91342, XrefRangeEnd = 91359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref imguiKeyboardControlID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imguiContainerHavingKeyboardControl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSwitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000258D File Offset: 0x0000078D
		public FocusController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000EF4C File Offset: 0x0000D14C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002596 File Offset: 0x00000796
		public unsafe IFocusRing _focusRing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__focusRing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFocusRing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__focusRing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000EF7C File Offset: 0x0000D17C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000025B5 File Offset: 0x000007B5
		public unsafe List<FocusController.FocusedElement> m_FocusedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_FocusedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FocusController.FocusedElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_FocusedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000025D4 File Offset: 0x000007D4
		public unsafe Focusable m_LastFocusedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastFocusedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastFocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000025F3 File Offset: 0x000007F3
		public unsafe int _imguiKeyboardControl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000260E File Offset: 0x0000080E
		public Focusable focusedElement
		{
			get
			{
				return this.GetRetargetedFocusedElement(null);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000F004 File Offset: 0x0000D204
		public Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
		{
			VisualElement visualElement;
			if (retargetAgainst == null)
			{
				visualElement = null;
			}
			else
			{
				VisualElement.Hierarchy hierarchy = retargetAgainst.hierarchy;
				visualElement = hierarchy.parent;
			}
			VisualElement visualElement2 = visualElement;
			bool flag = visualElement2 == null;
			if (flag)
			{
				bool flag2 = this.m_FocusedElements.Count > 0;
				if (flag2)
				{
					return this.m_FocusedElements[this.m_FocusedElements.Count - 1].m_FocusedElement;
				}
			}
			else
			{
				for (;;)
				{
					VisualElement.Hierarchy hierarchy;
					bool flag3;
					if (!visualElement2.isCompositeRoot)
					{
						hierarchy = visualElement2.hierarchy;
						flag3 = hierarchy.parent != null;
					}
					else
					{
						flag3 = false;
					}
					if (!flag3)
					{
						break;
					}
					hierarchy = visualElement2.hierarchy;
					visualElement2 = hierarchy.parent;
				}
				List<FocusController.FocusedElement>.Enumerator enumerator = this.m_FocusedElements.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						FocusController.FocusedElement focusedElement = enumerator.Current;
						bool flag4 = focusedElement.m_SubTreeRoot == visualElement2;
						if (flag4)
						{
							return focusedElement.m_FocusedElement;
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
			return null;
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__focusRing_k__BackingField;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusedElements;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFocusedElement;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Focusable_EventBase_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0;

		// Token: 0x020001EB RID: 491
		public sealed class FocusedElement : ValueType
		{
			// Token: 0x06001346 RID: 4934 RVA: 0x0003AF48 File Offset: 0x00039148
			// Note: this type is marked as 'beforefieldinit'.
			static FocusedElement()
			{
				Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "FocusedElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr);
				FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr, "m_SubTreeRoot");
				FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr, "m_FocusedElement");
			}

			// Token: 0x06001347 RID: 4935 RVA: 0x0000C6E2 File Offset: 0x0000A8E2
			public FocusedElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001348 RID: 4936 RVA: 0x0000C6EB File Offset: 0x0000A8EB
			public FocusedElement()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr))
			{
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001349 RID: 4937 RVA: 0x0003AF9C File Offset: 0x0003919C
			// (set) Token: 0x0600134A RID: 4938 RVA: 0x0000C6FD File Offset: 0x0000A8FD
			public unsafe VisualElement m_SubTreeRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600134B RID: 4939 RVA: 0x0003AFCC File Offset: 0x000391CC
			// (set) Token: 0x0600134C RID: 4940 RVA: 0x0000C71C File Offset: 0x0000A91C
			public unsafe Focusable m_FocusedElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000858 RID: 2136
			private static readonly IntPtr NativeFieldInfoPtr_m_SubTreeRoot;

			// Token: 0x04000859 RID: 2137
			private static readonly IntPtr NativeFieldInfoPtr_m_FocusedElement;
		}
	}
}
