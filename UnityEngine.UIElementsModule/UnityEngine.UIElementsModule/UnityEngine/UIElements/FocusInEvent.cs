using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000069 RID: 105
	public class FocusInEvent : FocusEventBase<FocusInEvent>
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x0002078C File Offset: 0x0001E98C
		// Note: this type is marked as 'beforefieldinit'.
		static FocusInEvent()
		{
			Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusInEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr);
			FocusInEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100663860);
			FocusInEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100663861);
			FocusInEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100663862);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000207F8 File Offset: 0x0001E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94725, XrefRangeEnd = 94728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusInEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00020834 File Offset: 0x0001EA34
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00020868 File Offset: 0x0001EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94728, XrefRangeEnd = 94731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusInEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00004E1E File Offset: 0x0000301E
		public FocusInEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
