using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007E RID: 126
	public class MouseEnterEvent : MouseEventBase<MouseEnterEvent>
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x0002331C File Offset: 0x0002151C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEnterEvent()
		{
			Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEnterEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr);
			MouseEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr, 100663958);
			MouseEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr, 100663959);
			MouseEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr, 100663960);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00023388 File Offset: 0x00021588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95491, XrefRangeEnd = 95494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000233C4 File Offset: 0x000215C4
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000233F8 File Offset: 0x000215F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95494, XrefRangeEnd = 95497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEnterEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEnterEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000513E File Offset: 0x0000333E
		public MouseEnterEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
