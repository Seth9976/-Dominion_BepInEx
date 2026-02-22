using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000075 RID: 117
	public class MouseEventDispatchingStrategy : Object
	{
		// Token: 0x060006A6 RID: 1702 RVA: 0x00021500 File Offset: 0x0001F700
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEventDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663889);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663890);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663891);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToRegularTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663892);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToIMGUIContainer_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663893);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663894);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_UpdateElementUnderMouse_Private_Static_Void_EventBase_BaseVisualElementPanel_byref_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663895);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr_IsDone_Private_Static_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663896);
			MouseEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr, 100663897);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000215E4 File Offset: 0x0001F7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95004, XrefRangeEnd = 95007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00021634 File Offset: 0x0001F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95007, XrefRangeEnd = 95038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DispatchEvent(EventBase evt, IPanel iPanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00021688 File Offset: 0x0001F888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95038, XrefRangeEnd = 95040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000216DC File Offset: 0x0001F8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95040, XrefRangeEnd = 95042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToRegularTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00021730 File Offset: 0x0001F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95042, XrefRangeEnd = 95059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToIMGUIContainer_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00021784 File Offset: 0x0001F984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95059, XrefRangeEnd = 95060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000217CC File Offset: 0x0001F9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95088, RefRangeEnd = 95090, XrefRangeStart = 95060, XrefRangeEnd = 95088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_UpdateElementUnderMouse_Private_Static_Void_EventBase_BaseVisualElementPanel_byref_VisualElement_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			elementUnderMouse = ((intPtr4 == 0) ? null : new VisualElement(intPtr4));
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00021838 File Offset: 0x0001FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95090, XrefRangeEnd = 95091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr_IsDone_Private_Static_Boolean_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002187C File Offset: 0x0001FA7C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEventDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEventDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00004F77 File Offset: 0x00003177
		public MouseEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToRegularTarget_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToIMGUIContainer_Private_Static_Boolean_EventBase_BaseVisualElementPanel_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_BaseVisualElementPanel_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElementUnderMouse_Private_Static_Void_EventBase_BaseVisualElementPanel_byref_VisualElement_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Private_Static_Boolean_EventBase_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
