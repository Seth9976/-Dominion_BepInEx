using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006A RID: 106
	public class FocusEvent : FocusEventBase<FocusEvent>
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x000208A4 File Offset: 0x0001EAA4
		// Note: this type is marked as 'beforefieldinit'.
		static FocusEvent()
		{
			Il2CppClassPointerStore<FocusEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr);
			FocusEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr, 100663863);
			FocusEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr, 100663864);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000208FC File Offset: 0x0001EAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94731, XrefRangeEnd = 94738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002094C File Offset: 0x0001EB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94738, XrefRangeEnd = 94741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004E27 File Offset: 0x00003027
		public FocusEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
