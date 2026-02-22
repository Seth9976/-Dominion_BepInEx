using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000090 RID: 144
	public class PointerEventDispatchingStrategy : Object
	{
		// Token: 0x06000791 RID: 1937 RVA: 0x000249D4 File Offset: 0x00022BD4
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664013);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664014);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToTarget_Private_Static_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664015);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664016);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr_UpdateElementUnderPointer_Private_Static_Void_EventBase_IPanel_byref_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664017);
			PointerEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr, 100664018);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00024A7C File Offset: 0x00022C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95843, XrefRangeEnd = 95846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00024ACC File Offset: 0x00022CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95846, XrefRangeEnd = 95854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_New_Void_EventBase_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00024B2C File Offset: 0x00022D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95854, XrefRangeEnd = 95855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEventToTarget(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatchingStrategy.NativeMethodInfoPtr_SendEventToTarget_Private_Static_Void_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00024B64 File Offset: 0x00022D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95855, XrefRangeEnd = 95859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBestTargetForEvent(EventBase evt, IPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatchingStrategy.NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00024BAC File Offset: 0x00022DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95873, RefRangeEnd = 95875, XrefRangeStart = 95859, XrefRangeEnd = 95873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatchingStrategy.NativeMethodInfoPtr_UpdateElementUnderPointer_Private_Static_Void_EventBase_IPanel_byref_VisualElement_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			elementUnderPointer = ((intPtr4 == 0) ? null : new VisualElement(intPtr4));
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00024C18 File Offset: 0x00022E18
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000543D File Offset: 0x0000363D
		public PointerEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_New_Void_EventBase_IPanel_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToTarget_Private_Static_Void_EventBase_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_SetBestTargetForEvent_Private_Static_Void_EventBase_IPanel_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElementUnderPointer_Private_Static_Void_EventBase_IPanel_byref_VisualElement_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
