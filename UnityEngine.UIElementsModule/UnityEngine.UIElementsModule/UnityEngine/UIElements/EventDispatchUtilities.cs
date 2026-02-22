using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006D RID: 109
	public static class EventDispatchUtilities : Object
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00020A90 File Offset: 0x0001EC90
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatchUtilities()
		{
			Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatchUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr);
			EventDispatchUtilities.NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100663867);
			EventDispatchUtilities.NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100663868);
			EventDispatchUtilities.NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100663869);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00020AFC File Offset: 0x0001ECFC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 94816, RefRangeEnd = 94825, XrefRangeStart = 94741, XrefRangeEnd = 94816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropagateEvent(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00020B34 File Offset: 0x0001ED34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 94843, RefRangeEnd = 94850, XrefRangeStart = 94825, XrefRangeEnd = 94843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropagateToIMGUIContainer(VisualElement root, EventBase evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00020B7C File Offset: 0x0001ED7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94857, RefRangeEnd = 94859, XrefRangeStart = 94850, XrefRangeEnd = 94857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteDefaultAction(EventBase evt, IPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00004E39 File Offset: 0x00003039
		public EventDispatchUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_IPanel_0;
	}
}
