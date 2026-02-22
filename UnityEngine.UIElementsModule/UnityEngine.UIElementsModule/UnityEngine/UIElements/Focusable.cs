using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000D RID: 13
	public class Focusable : CallbackEventHandler
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000DE84 File Offset: 0x0000C084
		// Note: this type is marked as 'beforefieldinit'.
		static Focusable()
		{
			Il2CppClassPointerStore<Focusable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Focusable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Focusable>.NativeClassPtr);
			Focusable.NativeFieldInfoPtr__focusable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "<focusable>k__BackingField");
			Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "<tabIndex>k__BackingField");
			Focusable.NativeFieldInfoPtr_m_DelegatesFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "m_DelegatesFocus");
			Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "m_ExcludeFromFocusRing");
			Focusable.NativeFieldInfoPtr_isIMGUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "isIMGUIContainer");
			Focusable.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663328);
			Focusable.NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663329);
			Focusable.NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663330);
			Focusable.NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663331);
			Focusable.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663332);
			Focusable.NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663333);
			Focusable.NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663334);
			Focusable.NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663335);
			Focusable.NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100663336);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000E018 File Offset: 0x0000C218
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe bool focusable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._focusable_k__BackingField = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000E054 File Offset: 0x0000C254
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002521 File Offset: 0x00000721
		public unsafe int tabIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._tabIndex_k__BackingField = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000E090 File Offset: 0x0000C290
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
		public unsafe bool delegatesFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !base.Cast<VisualElement>().isCompositeRoot;
				if (flag)
				{
					throw new InvalidOperationException("delegatesFocus should only be set on composite roots.");
				}
				this.m_DelegatesFocus = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public unsafe virtual bool canGrabFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000E114 File Offset: 0x0000C314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91161, XrefRangeEnd = 91168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000E150 File Offset: 0x0000C350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91168, XrefRangeEnd = 91170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Blur()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000E18C File Offset: 0x0000C38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91170, XrefRangeEnd = 91175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetFocusDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91182, RefRangeEnd = 91185, XrefRangeStart = 91175, XrefRangeEnd = 91182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Focusable GetFirstFocusableChild(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002488 File Offset: 0x00000688
		public Focusable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000E210 File Offset: 0x0000C410
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002491 File Offset: 0x00000691
		public unsafe bool _focusable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__focusable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__focusable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000E238 File Offset: 0x0000C438
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000024AC File Offset: 0x000006AC
		public unsafe int _tabIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000E260 File Offset: 0x0000C460
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000024C7 File Offset: 0x000006C7
		public unsafe bool m_DelegatesFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_DelegatesFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_DelegatesFocus)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000E288 File Offset: 0x0000C488
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000024E2 File Offset: 0x000006E2
		public unsafe bool m_ExcludeFromFocusRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000024FD File Offset: 0x000006FD
		public unsafe bool isIMGUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_isIMGUIContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_isIMGUIContainer)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000E30C File Offset: 0x0000C50C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000E324 File Offset: 0x0000C524
		public bool excludeFromFocusRing
		{
			get
			{
				return this.m_ExcludeFromFocusRing;
			}
			set
			{
				bool flag = !base.Cast<VisualElement>().isCompositeRoot;
				if (flag)
				{
					throw new InvalidOperationException("excludeFromFocusRing should only be set on composite roots.");
				}
				this.m_ExcludeFromFocusRing = value;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E358 File Offset: 0x0000C558
		public override void ExecuteDefaultAction(EventBase evt)
		{
			base.ExecuteDefaultAction(evt);
			bool flag = evt != null && evt.target == evt.leafTarget;
			if (flag)
			{
				FocusController focusController = this.focusController;
				if (focusController != null)
				{
					focusController.SwitchFocusOnEvent(evt);
				}
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__focusable_k__BackingField;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__tabIndex_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_DelegatesFocus;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcludeFromFocusRing;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_isIMGUIContainer;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0;
	}
}
