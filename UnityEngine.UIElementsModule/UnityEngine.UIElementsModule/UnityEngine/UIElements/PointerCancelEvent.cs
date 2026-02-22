using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009A RID: 154
	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent>
	{
		// Token: 0x06000851 RID: 2129 RVA: 0x000278C8 File Offset: 0x00025AC8
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCancelEvent()
		{
			Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCancelEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr);
			PointerCancelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr, 100664112);
			PointerCancelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr, 100664113);
			PointerCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr, 100664114);
			PointerCancelEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr, 100664115);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00027948 File Offset: 0x00025B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96432, XrefRangeEnd = 96438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCancelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0002797C File Offset: 0x00025B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96438, XrefRangeEnd = 96441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCancelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000279B0 File Offset: 0x00025BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96441, XrefRangeEnd = 96447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCancelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCancelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000279EC File Offset: 0x00025BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96447, XrefRangeEnd = 96477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCancelEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00005796 File Offset: 0x00003996
		public PointerCancelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;
	}
}
