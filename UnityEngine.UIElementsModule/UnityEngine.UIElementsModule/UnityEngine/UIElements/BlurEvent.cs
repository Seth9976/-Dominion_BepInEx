using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000068 RID: 104
	public class BlurEvent : FocusEventBase<BlurEvent>
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x000206A8 File Offset: 0x0001E8A8
		// Note: this type is marked as 'beforefieldinit'.
		static BlurEvent()
		{
			Il2CppClassPointerStore<BlurEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BlurEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr);
			BlurEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr, 100663858);
			BlurEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr, 100663859);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00020700 File Offset: 0x0001E900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94719, XrefRangeEnd = 94722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlurEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00020750 File Offset: 0x0001E950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94722, XrefRangeEnd = 94725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlurEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlurEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00004E15 File Offset: 0x00003015
		public BlurEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
