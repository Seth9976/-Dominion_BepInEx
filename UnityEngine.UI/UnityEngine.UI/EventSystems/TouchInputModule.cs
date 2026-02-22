using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006C RID: 108
	public class TouchInputModule : PointerInputModule
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003104C File Offset: 0x0002F24C
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInputModule()
		{
			Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "TouchInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr);
			TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_LastMousePosition");
			TouchInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_MousePosition");
			TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_InputPointerEvent");
			TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_ForceModuleActive");
			TouchInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664884);
			TouchInputModule.NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664885);
			TouchInputModule.NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664886);
			TouchInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664887);
			TouchInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664888);
			TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664889);
			TouchInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664890);
			TouchInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664891);
			TouchInputModule.NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664892);
			TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664893);
			TouchInputModule.NativeMethodInfoPtr_FakeTouches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664894);
			TouchInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664895);
			TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664896);
			TouchInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664897);
			TouchInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100664898);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000311F8 File Offset: 0x0002F3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122980, XrefRangeEnd = 122981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00031234 File Offset: 0x0002F434
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00031270 File Offset: 0x0002F470
		public unsafe bool allowActivationOnStandalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000312B0 File Offset: 0x0002F4B0
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000312EC File Offset: 0x0002F4EC
		public unsafe bool forceModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0003132C File Offset: 0x0002F52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122981, XrefRangeEnd = 122993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00031368 File Offset: 0x0002F568
		[CallerCount(0)]
		public unsafe override bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000313B0 File Offset: 0x0002F5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122993, XrefRangeEnd = 122996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000313F8 File Offset: 0x0002F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122996, XrefRangeEnd = 122997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseFakeInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00031434 File Offset: 0x0002F634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122997, XrefRangeEnd = 122999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00031470 File Offset: 0x0002F670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122999, XrefRangeEnd = 123003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FakeTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_FakeTouches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000314A4 File Offset: 0x0002F6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123110, RefRangeEnd = 123111, XrefRangeStart = 123003, XrefRangeEnd = 123110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000314D8 File Offset: 0x0002F6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123209, RefRangeEnd = 123210, XrefRangeStart = 123111, XrefRangeEnd = 123209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00031538 File Offset: 0x0002F738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00031574 File Offset: 0x0002F774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123210, XrefRangeEnd = 123242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00005DB3 File Offset: 0x00003FB3
		public TouchInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x000315B8 File Offset: 0x0002F7B8
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00005DBC File Offset: 0x00003FBC
		public unsafe Vector2 m_LastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x000315E0 File Offset: 0x0002F7E0
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00005DD7 File Offset: 0x00003FD7
		public unsafe Vector2 m_MousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_MousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00031608 File Offset: 0x0002F808
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00005DF2 File Offset: 0x00003FF2
		public unsafe PointerEventData m_InputPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00031638 File Offset: 0x0002F838
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00005E11 File Offset: 0x00004011
		public unsafe bool m_ForceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
			}
		}

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_m_InputPointerEvent;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_FakeTouches_Private_Void_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
