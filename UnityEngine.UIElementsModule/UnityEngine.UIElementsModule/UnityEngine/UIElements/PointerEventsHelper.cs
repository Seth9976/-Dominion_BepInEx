using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000085 RID: 133
	public static class PointerEventsHelper : Object
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x00023A3C File Offset: 0x00021C3C
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventsHelper()
		{
			Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventsHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr);
			PointerEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr, 100663977);
			PointerEventsHelper.NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr, 100663978);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00023A94 File Offset: 0x00021C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95677, RefRangeEnd = 95680, XrefRangeStart = 95635, XrefRangeEnd = 95677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) where TLeaveEvent : PointerEventBase<TLeaveEvent>, new() where TEnterEvent : PointerEventBase<TEnterEvent>, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderPointer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventsHelper.MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0<TLeaveEvent, TEnterEvent>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00023B0C File Offset: 0x00021D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95695, RefRangeEnd = 95698, XrefRangeStart = 95680, XrefRangeEnd = 95695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderPointer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventsHelper.NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000051EF File Offset: 0x000033EF
		public PointerEventsHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0;

		// Token: 0x02000216 RID: 534
		private sealed class MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0<TLeaveEvent, TEnterEvent>
		{
			// Token: 0x040008BB RID: 2235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PointerEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0, Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeaveEvent>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnterEvent>.NativeClassPtr))
			}))));
		}
	}
}
