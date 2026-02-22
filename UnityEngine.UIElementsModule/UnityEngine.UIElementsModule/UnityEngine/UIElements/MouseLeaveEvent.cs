using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007F RID: 127
	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent>
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x00023434 File Offset: 0x00021634
		// Note: this type is marked as 'beforefieldinit'.
		static MouseLeaveEvent()
		{
			Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseLeaveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr);
			MouseLeaveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr, 100663961);
			MouseLeaveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr, 100663962);
			MouseLeaveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr, 100663963);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000234A0 File Offset: 0x000216A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95497, XrefRangeEnd = 95500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseLeaveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000234DC File Offset: 0x000216DC
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00023510 File Offset: 0x00021710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95500, XrefRangeEnd = 95503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseLeaveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseLeaveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00005147 File Offset: 0x00003347
		public MouseLeaveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
