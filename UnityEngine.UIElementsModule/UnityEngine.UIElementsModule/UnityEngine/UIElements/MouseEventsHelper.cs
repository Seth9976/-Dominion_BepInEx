using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000084 RID: 132
	public static class MouseEventsHelper : Object
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x00023914 File Offset: 0x00021B14
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEventsHelper()
		{
			Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEventsHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr);
			MouseEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr, 100663975);
			MouseEventsHelper.NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr, 100663976);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0002396C File Offset: 0x00021B6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95614, RefRangeEnd = 95617, XrefRangeStart = 95572, XrefRangeEnd = 95614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) where TLeaveEvent : MouseEventBase<TLeaveEvent>, new() where TEnterEvent : MouseEventBase<TEnterEvent>, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderMouse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderMouse);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventsHelper.MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0<TLeaveEvent, TEnterEvent>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000239D4 File Offset: 0x00021BD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95632, RefRangeEnd = 95635, XrefRangeStart = 95617, XrefRangeEnd = 95632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderMouse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderMouse);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventsHelper.NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000051E6 File Offset: 0x000033E6
		public MouseEventsHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0;

		// Token: 0x02000215 RID: 533
		private sealed class MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0<TLeaveEvent, TEnterEvent>
		{
			// Token: 0x040008BA RID: 2234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MouseEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0, Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeaveEvent>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnterEvent>.NativeClassPtr))
			}))));
		}
	}
}
