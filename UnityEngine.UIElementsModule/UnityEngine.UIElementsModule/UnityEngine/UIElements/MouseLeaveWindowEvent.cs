using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000081 RID: 129
	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x000236C8 File Offset: 0x000218C8
		// Note: this type is marked as 'beforefieldinit'.
		static MouseLeaveWindowEvent()
		{
			Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseLeaveWindowEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100663968);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100663969);
			MouseLeaveWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100663970);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100663971);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100663972);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0002375C File Offset: 0x0002195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95521, XrefRangeEnd = 95527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseLeaveWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00023798 File Offset: 0x00021998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95527, XrefRangeEnd = 95530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000237CC File Offset: 0x000219CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95530, XrefRangeEnd = 95536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseLeaveWindowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00023808 File Offset: 0x00021A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95536, XrefRangeEnd = 95554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static MouseLeaveWindowEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseLeaveWindowEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0002384C File Offset: 0x00021A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95554, XrefRangeEnd = 95566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseLeaveWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00005159 File Offset: 0x00003359
		public MouseLeaveWindowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;
	}
}
