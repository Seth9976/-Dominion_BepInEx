using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000080 RID: 128
	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent>
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x0002354C File Offset: 0x0002174C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEnterWindowEvent()
		{
			Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEnterWindowEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr);
			MouseEnterWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100663964);
			MouseEnterWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100663965);
			MouseEnterWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100663966);
			MouseEnterWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100663967);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000235CC File Offset: 0x000217CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95503, XrefRangeEnd = 95506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEnterWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00023608 File Offset: 0x00021808
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0002363C File Offset: 0x0002183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95506, XrefRangeEnd = 95509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEnterWindowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00023678 File Offset: 0x00021878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95509, XrefRangeEnd = 95521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEnterWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00005150 File Offset: 0x00003350
		public MouseEnterWindowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;
	}
}
