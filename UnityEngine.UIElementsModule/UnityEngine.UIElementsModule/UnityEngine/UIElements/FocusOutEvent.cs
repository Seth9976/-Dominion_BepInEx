using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000067 RID: 103
	public class FocusOutEvent : FocusEventBase<FocusOutEvent>
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00020590 File Offset: 0x0001E790
		// Note: this type is marked as 'beforefieldinit'.
		static FocusOutEvent()
		{
			Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusOutEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr);
			FocusOutEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100663855);
			FocusOutEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100663856);
			FocusOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100663857);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000205FC File Offset: 0x0001E7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94713, XrefRangeEnd = 94716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusOutEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00020638 File Offset: 0x0001E838
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0002066C File Offset: 0x0001E86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94716, XrefRangeEnd = 94719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00004E0C File Offset: 0x0000300C
		public FocusOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
