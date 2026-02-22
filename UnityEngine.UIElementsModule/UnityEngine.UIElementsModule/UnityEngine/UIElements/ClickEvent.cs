using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009B RID: 155
	public sealed class ClickEvent : PointerEventBase<ClickEvent>
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00027A30 File Offset: 0x00025C30
		// Note: this type is marked as 'beforefieldinit'.
		static ClickEvent()
		{
			Il2CppClassPointerStore<ClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ClickEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr);
			ClickEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100664116);
			ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100664117);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00027A88 File Offset: 0x00025C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96477, XrefRangeEnd = 96481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClickEvent>(intPtr3) : null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00027ADC File Offset: 0x00025CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96481, XrefRangeEnd = 96484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000579F File Offset: 0x0000399F
		public ClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
